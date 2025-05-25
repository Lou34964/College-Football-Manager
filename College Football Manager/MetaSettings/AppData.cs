using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace College_Football_Manager.MetaSettings
{
    public static class CFM
    {
        public static List<int> GetAvailableYears()
        {
            var Result = new List<int>();

            foreach (var file in Directory.GetFiles("./Years", "*.xml"))
            {
                //check if file is template
                if (Path.GetFileName(file).Equals("Template.xml", StringComparison.OrdinalIgnoreCase))
                    continue;

                try
                {
                    var serializer = new XmlSerializer(typeof(MetaData));
                    using var reader = new StreamReader(file);
                    MetaData meta = (MetaData)serializer.Deserialize(reader);
                    if (meta.Mdata != null)
                    {
                        Result.Add(meta.Mdata.Year);
                    }
                }
                catch (Exception ex) 
                {
                    throw new FileLoadException($"Error: {ex.Message}");
                }
            }

            return Result.Order().ToList();
        }
    }
    public static class AppState
    {
        public static MetaData CurrentYear = new MetaData();

        public static string CurrentYearPath = @$"./Years/Template.xml";

        public static List<int> YearsAvailable = new List<int>();

        public static TeamsByConference TeamsByConference = new TeamsByConference();

        public static ConferenceLogos ConferenceLogos = new ConferenceLogos();

        public static void SortTeamsByID()
        {
            CurrentYear.Teams = CurrentYear.Teams.OrderBy(t => t.ID).ToList();
        }

        public static void CopyNewYear(string InFile, int Year)
        {
            //deserialize sceme data
            var serializer = new XmlSerializer(typeof(MetaData));
            using var reader = new StreamReader(InFile);
            var inmeta = (MetaData)serializer.Deserialize(reader);

            //check not null
            if(inmeta?.Mdata != null)
            {
                //copy metadata*
                MetaData newYear = new MetaData();
                newYear.Teams = inmeta.Teams;
                newYear.Mdata.Year = Year;
                newYear.Mdata.Team = inmeta.Mdata.Team;
                newYear.CopyBowls(inmeta.Bowls);
                newYear.Mdata.Coaching_Position = inmeta.Mdata.Coaching_Position;
                
                //set new year
                CurrentYear = newYear;
                CurrentYearPath = $"./Years/{Year}.xml";

                //save new year
                XML.SaveMetaData();

                //reload new year
                CurrentYear = XML.LoadMetaData(CurrentYearPath);

                //set team logos
                foreach (var team in AppState.CurrentYear.Teams)
                {
                    team.SetLogo();
                }

                //reset forms data.
                DashBoard db = Application.OpenForms.OfType<DashBoard>().FirstOrDefault();
                db.LoadData();
            }
        }
    }
    [XmlRoot("MetaData")]
    public class MetaData
    {
        public List<Team> Teams { get; set; } = new();
        public List<Game> Games { get; set; } = new();
        public Mdata Mdata { get; set; } = new();
        [XmlIgnore]
        public Image CFP { get; set; }
        public string CFPFilePath { get; set; }
        public List<Bowl> Bowls { get; set; } = new();
        public FinalRankings FinalRankings { get; set; } = new();
        public ConferenceStandings ConferenceStandings { get; set; } = new();
        public ConferenceChamps ConferenceChamps { get; set; } = new();

        public Team GetTeamByID(int id)
        {
            return Teams.FirstOrDefault(t => t.ID == id);
            //return Teams.First(t => t.ID == id);
        }

        public void CopyBowls(List<Bowl> inBowls)
        {
            foreach (Bowl b in inBowls)
            {
                Bowls.Add(new Bowl { BowlName = b.BowlName });
            }
        }

        public void LoadCFPImage()
        {
            if (!string.IsNullOrEmpty(CFPFilePath) && File.Exists(CFPFilePath))
            {
                CFP = Image.FromFile(CFPFilePath);
            }
        }
    }


    public static class XML
    {
        public static void SaveMetaData()
        {
            var serializer = new XmlSerializer(typeof(MetaData));
            using var writer = new StreamWriter(AppState.CurrentYearPath);
            serializer.Serialize(writer, AppState.CurrentYear);
        }

        public static MetaData LoadMetaData(string FilePath)
        {
            var serializer = new XmlSerializer(typeof(MetaData));
            using var reader = new StreamReader(FilePath);
            var result = serializer.Deserialize(reader);

            if (result is MetaData metadata)
            {
                return metadata;
            }

            throw new InvalidDataException("Failed to deserialize MetaData");
        }
    }

    public class TeamsByConference
    {
        public List<Team> Independent = new List<Team>();
        public List<Team> Cusa = new List<Team>();
        public List<Team> XII = new List<Team>();
        public List<Team> Mac = new List<Team>();
        public List<Team> Sunbelt = new List<Team>();
        public List<Team> American = new List<Team>();
        public List<Team> MWC = new List<Team>();
        public List<Team> SEC = new List<Team>();
        public List<Team> ACC = new List<Team>();
        public List<Team> B10 = new List<Team>();
        public List<Team> Pac12 = new List<Team>();

        public bool Sort()
        {
            try
            {
                Independent.Clear();
                Independent.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "Independent"));
                Cusa.Clear();
                Cusa.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "Cusa"));
                XII.Clear();
                XII.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "XII"));
                Mac.Clear();
                Mac.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "Mac"));
                Sunbelt.Clear();
                Sunbelt.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "Sunbelt"));
                American.Clear();
                American.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "American"));
                MWC.Clear();
                MWC.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "MWC"));
                SEC.Clear();
                SEC.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "SEC"));
                ACC.Clear();
                ACC.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "ACC"));
                B10.Clear();
                B10.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "B10"));
                Pac12.Clear();
                Pac12.AddRange(AppState.CurrentYear.Teams.Where(t => t.Conference == "Pac12"));

                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }

    public class Mdata
    {
        public int Year { get; set; }
        public int Team { get; set; }
        public int Off { get; set; }
        public int Def { get; set; }
        public int Ovr { get; set; }
        public int Wins { get; set; }
        public int ExtraWins { get; set; }
        public int Losses { get; set; }
        public int ExtraLosses { get; set; }
        public string Bowl { get; set; } = "None";
        public bool Won { get; set; }
        public int Endranking { get; set; }
        public string Coaching_Position { get; set; }
    }

    public enum Coaching_Position
    {
        HC,
        OC,
        DC
    }

    public class Game
    {
        public int GameID{ get; set; }
        public string GameName { get; set; } = string.Empty;
        public int Opponent { get; set; }
        public int Rank { get; set; }
        public int OpponentRank { get; set; }
        public GameLocation GameLocation{ get; set; }
        public GameResult GameResult{ get; set; }
        public int TeamScore { get; set; }
        public int OpponentScore { get; set; }
        
    }
    public enum GameLocation
    {
        Home,
        Away,
        Neutral
    }
    public enum GameResult
    {
        None,
        Win,
        Loss
    }

    public class Bowl
    {
        public string BowlName { get; set; }
        public int WinningTeamID { get; set; }

        public Bowl() { }

        public Bowl(string name, int winner)
        {
            BowlName = name;
            WinningTeamID = winner;
        }
    }

    public class ConferenceChamps
    {
        public int ACC { get; set; } = new();
        public int American { get; set; } = new();
        public int B10 { get; set; } = new();
        public int Cusa { get; set; } = new();
        public int Independent { get; set; } = new();
        public int Mac { get; set; } = new();
        public int MWC { get; set; } = new();
        public int Pac12 { get; set; } = new();
        public int SEC { get; set; } = new();
        public int Sunbelt { get; set; } = new();
        public int XII { get; set; } = new();

        public int GetConferenceChampionID(string conf)
        {
            return conf switch
            {
                "ACC" => ACC,
                "American" => American,
                "B10" => B10,
                "Cusa" => Cusa,
                "Independent" => Independent,
                "Mac" => Mac,
                "MWC" => MWC,
                "Pac12" => Pac12,
                "SEC" => SEC,
                "Sunbelt" => Sunbelt,
                "XII" => XII,
                _ => -1 // Return -1 if not found
            };
        }
        public Team GetConferenceChampionTeam(string conf)
        {
            int id = GetConferenceChampionID(conf);
            return AppState.CurrentYear.Teams.FirstOrDefault(t => t.ID == id);
        }
        public void SetConferenceChampion(string conf, int teamID)
        {
            switch (conf)
            {
                case "ACC": ACC = teamID; break;
                case "American": American = teamID; break;
                case "B10": B10 = teamID; break;
                case "Cusa": Cusa = teamID; break;
                case "Independent": Independent = teamID; break;
                case "Mac": Mac = teamID; break;
                case "MWC": MWC = teamID; break;
                case "Pac12": Pac12 = teamID; break;
                case "SEC": SEC = teamID; break;
                case "Sunbelt": Sunbelt = teamID; break;
                case "XII": XII = teamID; break;
            }
        }
    }

    public class FinalRankings
    {
        public List<int> AP_Poll { get; set; } = new();
        public List<int> Coaches { get; set; } = new();
        public List<int> CFP { get; set; } = new();

        public void SetRankings(List<Team> rankings, string poll)
        {
            switch (poll)
            {
                case "AP":
                    setit(AP_Poll, rankings);
                    break;
                case "Coaches":
                    setit(Coaches, rankings);
                    break;
                case "CFP":
                    setit(CFP, rankings);
                    break;
                default:
                    return;
            }

            void setit(List<int> poll, List<Team> rankings)
            {
                poll.Clear();
                foreach(var team in rankings)
                {
                    poll.Add(team.ID);
                }
            }
        }
        public void ClearRankings(List<int> poll)
        {
            poll.Clear();
            XML.SaveMetaData();
        }
    }

    public class ConferenceStandings
    {
        public List<int> ACC { get; set; } = new();
        public List<int> American { get; set; } = new();
        public List<int> XII { get; set; } = new();
        public List<int> B10 { get; set; } = new();
        public List<int> Cusa { get; set; } = new();
        public List<int> Independent { get; set; } = new();
        public List<int> Mac { get; set; } = new();
        public List<int> MWC { get; set; } = new();
        public List<int> SEC { get; set; } = new();
        public List<int> Sunbelt { get; set; } = new();
        public List<int> Pac12 { get; set; } = new();

        public void SetStandings(string Conference, List<Team> teams)
        {
            switch (Conference)
            {
                case "Independent":
                    setit(Independent, teams);
                    break;
                case "Cusa":
                    setit(Cusa, teams);
                    break;
                case "XII":
                    setit(XII, teams);
                    break;
                case "Mac":
                    setit(Mac, teams);
                    break;
                case "Sunbelt":
                    setit(Sunbelt, teams);
                    break;
                case "American":
                    setit(American, teams);
                    break;
                case "MWC":
                    setit(MWC, teams);
                    break;
                case "SEC":
                    setit(SEC, teams);
                    break;
                case "ACC":
                    setit(ACC, teams);
                    break;
                case "B10":
                    setit(B10, teams);
                    break;
                case "Pac12":
                    setit(Pac12, teams);
                    break;
                default:
                    return;
            }

        }

        private void setit(List<int> toset, List<Team> teams)
        {
            toset.Clear();
            foreach (var team in teams)
            {
                toset.Add(team.ID);
            }
        }
    }

    public class ConferenceLogos
    {
        public Image Independant = Image.FromFile($"./Icons/Division-I-FBS-Independents-logo-300x300.png");
        public Image Cusa = Image.FromFile($"./Icons/Conference_USA_logo-300x300.png");
        public Image XII = Image.FromFile($"./Icons/Big_12_Conference_logo-300x300.png");
        public Image Mac = Image.FromFile($"./Icons/Mid-American_Conference_logo-300x300.png");
        public Image Sunbelt = Image.FromFile($"./Icons/Sun_Belt_Conference_2020_logo-300x300.png");
        public Image American = Image.FromFile($"./Icons/American_Athletic_Conference_logo-300x300.png");
        public Image MWC = Image.FromFile($"./Icons/Mountain_West_Conference_logo-300x300.png");
        public Image SEC = Image.FromFile($"./Icons/Southeastern_Conference_logo-300x300.png");
        public Image ACC = Image.FromFile($"./Icons/Atlantic_Coast_Conference_ACC_logo-300x300.png");
        public Image B10 = Image.FromFile($"./Icons/Big_Ten_Conference_logo-300x300.png");
        public Image Pac12 = Image.FromFile($"./Icons/Pac-12_logo-300x300.png");

        public Image GetConferenceImage(string Conference)
        {
            switch (Conference)
            {
                case "Independent":
                    return Independant;
                case "Cusa":
                    return Cusa;
                case "XII":
                    return XII;
                case "Mac":
                    return Mac;
                case "Sunbelt":
                    return Sunbelt;
                case "American":
                    return American;
                case "MWC":
                    return MWC;
                case "SEC":
                    return SEC;
                case "ACC":
                    return ACC;
                case "B10":
                    return B10;
                case "Pac12":
                    return Pac12;
                default:
                    return null;
            }
        }
    }

}
