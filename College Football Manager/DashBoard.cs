using College_Football_Manager.MetaSettings;
using College_Football_Manager.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Football_Manager
{
    public partial class DashBoard : Form
    {
        List<Team> SelectedConferenceStandings;

        public DashBoard()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Settings Form
            MetaSettings.SettingsMain sm = new MetaSettings.SettingsMain();
            sm.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            LoadYearsAvailable();

            var selectedTeam = AppState.CurrentYear.Teams.FirstOrDefault(t => t.ID == AppState.CurrentYear.Mdata.Team);

            if (selectedTeam != null)
            {
                labelTeam.DataBindings.Clear();
                labelTeam.DataBindings.Add("Text", selectedTeam, "TeamName");

                labelYear.DataBindings.Clear();
                labelYear.DataBindings.Add("Text", AppState.CurrentYear.Mdata, "Year");
            }

            CommonLoad(selectedTeam);
        }
        public void LoadYearsAvailable()
        {
            toolStripComboBoxYears.Items.Clear();
            foreach (int i in AppState.YearsAvailable)
            {
                toolStripComboBoxYears.Items.Add(i.ToString());
            }
        }
        public void LoadData()
        {
            LoadYearsAvailable();

            var selectedTeam = AppState.CurrentYear.Teams.FirstOrDefault(t => t.ID == AppState.CurrentYear.Mdata.Team);

            if (selectedTeam != null)
            {
                labelTeam.DataBindings.Clear();
                labelTeam.DataBindings.Add("Text", selectedTeam, "TeamName");

                labelYear.DataBindings.Clear();
                labelYear.DataBindings.Add("Text", AppState.CurrentYear.Mdata, "Year");
            }

            CommonLoad(selectedTeam);
        }
        public void LoadDataFromYearSelect()
        {
            var selectedTeam = AppState.CurrentYear.Teams.FirstOrDefault(t => t.ID == AppState.CurrentYear.Mdata.Team);

            if (selectedTeam != null)
            {
                labelTeam.DataBindings.Clear();
                labelTeam.DataBindings.Add("Text", selectedTeam, "TeamName");

                labelYear.DataBindings.Clear();
                labelYear.DataBindings.Add("Text", AppState.CurrentYear.Mdata, "Year");
            }
            LoadYearsAvailable();
            CommonLoad(selectedTeam);
        }

        public void CommonLoad(Team selectedTeam)
        {
            AppState.TeamsByConference.Sort();
            listBoxStandings.Items.Clear();
            listBoxStandings.DisplayMember = "TeamName";


            labelTeam.Text = selectedTeam.TeamName;
            labelTeam.BackColor = selectedTeam.TeamPrimaryColor;
            labelTeam.ForeColor = selectedTeam.TeamSecondaryColor;
            labelYear.Text = AppState.CurrentYear.Mdata.Year.ToString();

            foreach (Team team in AppState.CurrentYear.Teams)
            {
                team.Logo = Image.FromFile(team.ImageFileName);
            }

            LoadGames();
            LoadRankingTeamButtons();
            UpdateWinLoss();

            comboBoxTeamBowlPlayed.SelectedIndexChanged -= comboBoxTeamBowlPlayed_SelectedIndexChanged;
            comboBoxTeamBowlPlayed.DataSource = AppState.CurrentYear.Bowls;
            comboBoxTeamBowlPlayed.DisplayMember = "BowlName";
            comboBoxTeamBowlPlayed.SelectedItem = AppState.CurrentYear.Bowls.FirstOrDefault(b => b.BowlName == AppState.CurrentYear.Mdata.Bowl);
            comboBoxTeamBowlPlayed.SelectedIndexChanged += comboBoxTeamBowlPlayed_SelectedIndexChanged;
            checkBoxBowlWon.Checked = AppState.CurrentYear.Mdata.Won;

            comboBoxMyEndRanking.Text = AppState.CurrentYear.Mdata.Endranking == 0 ? "None" : AppState.CurrentYear.Mdata.Endranking.ToString();

            numericUpDownOff.ValueChanged -= numericUpDownRating_ValueChanged;
            numericUpDownDef.ValueChanged -= numericUpDownRating_ValueChanged;
            numericUpDownOvr.ValueChanged -= numericUpDownRating_ValueChanged;

            numericUpDownOff.Value = AppState.CurrentYear.Mdata.Off;
            numericUpDownDef.Value = AppState.CurrentYear.Mdata.Def;
            numericUpDownOvr.Value = AppState.CurrentYear.Mdata.Ovr;

            numericUpDownOff.ValueChanged += numericUpDownRating_ValueChanged;
            numericUpDownDef.ValueChanged += numericUpDownRating_ValueChanged;
            numericUpDownOvr.ValueChanged += numericUpDownRating_ValueChanged;

            AppState.CurrentYear.Bowls = AppState.CurrentYear.Bowls.OrderBy(b => b.BowlName).ToList();

            List<string> ignoredBowlNames = new List<string>
            {
                "R1_G1",
                "R1_G2",
                "R1_G3",
                "R1_G4",
                "Peach Bowl",
                "AllState Bowl",
                "Rose Bowl",
                "Fiesta Bowl",
                "Cotton Bowl",
                "Orange Bowl",
                "Championship"
            };

            var filteredbowls = AppState.CurrentYear.Bowls.Where(b => !ignoredBowlNames.Contains(b.BowlName)).ToList();

            comboBoxBowls.DataSource = filteredbowls;
            comboBoxBowls.DisplayMember = "BowlName";
            comboBoxBowls.SelectedIndexChanged += BowlSelectT;
            comboBoxConferenceChampion.DataSource = null;
            AppState.CurrentYear.CFP = AppState.CurrentYear.CFPFilePath == string.Empty || AppState.CurrentYear.CFPFilePath == null ? null : Image.FromFile(AppState.CurrentYear.CFPFilePath);
            pictureBoxBracket.Image = AppState.CurrentYear.CFP;

            comboBoxCoach.SelectedIndexChanged -= comboBoxCoach_SelectedIndexChanged;
            switch (AppState.CurrentYear.Mdata.Coaching_Position)
            {
                case "HC":
                    comboBoxCoach.SelectedIndex = 0;
                    break;
                case "OC":
                    comboBoxCoach.SelectedIndex = 1;
                    break;
                case "DC":
                    comboBoxCoach.SelectedIndex = 2;
                    break;
            }
            comboBoxCoach.SelectedIndexChanged += comboBoxCoach_SelectedIndexChanged;


            //load Bowl Team Buttons
            flowLayoutPanelTeamButtonsBowls.SuspendLayout();
            List<Button> btns = new List<Button>();
            flowLayoutPanelTeamButtonsBowls.Controls.Clear();
            foreach (Team team in AppState.CurrentYear.Teams)
            {
                if (IsFcsTeam(team.TeamName))
                {
                    continue;
                }

                Button button = new Button();
                //button.Size = new Size(200, 50);
                button.Image = new Bitmap(team.Logo, new Size(32, 32));
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.AutoSize = true;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                button.BackColor = Color.White;
                button.ForeColor = team.TeamPrimaryColor;
                button.Tag = team;
                button.Text = team.TeamName;
                button.Click += BowlTeamButton_Click;

                btns.Add(button);

            }
            flowLayoutPanelTeamButtonsBowls.Controls.AddRange(btns.ToArray());
            if ((comboBoxBowls.SelectedItem as Bowl).WinningTeamID > 0)
            {
                foreach (Button button in flowLayoutPanelTeamButtonsBowls.Controls.OfType<Button>())
                {
                    if ((comboBoxBowls.SelectedItem as Bowl).WinningTeamID != (button.Tag as Team).ID)
                    {
                        TeamConferenceButton_Disable(button);
                    }
                }
            }
            flowLayoutPanelTeamButtonsBowls.ResumeLayout();
        }
        public void LoadGames()
        {
            flowLayoutPanelGameBar.SuspendLayout();
            flowLayoutPanelGameBar.Controls.Clear();
            List<GameBar> gameBars = new List<GameBar>();
            foreach (Game g in AppState.CurrentYear.Games)
            {
                GameBar gb = new GameBar(g);
                gb.LoadData();
                gameBars.Add(gb);
                //flowLayoutPanelGameBar.Controls.Add(gb);
            }
            flowLayoutPanelGameBar.Controls.AddRange(gameBars.ToArray());
            flowLayoutPanelGameBar.ResumeLayout();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewYear ny = new NewYear();
            ny.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Team> stTeams = new List<Team>();
            foreach (object o in listBoxStandings.Items)
            {
                stTeams.Add(o as Team);
            }

            AppState.CurrentYear.ConferenceStandings.SetStandings(comboBoxConferenceSelect.SelectedItem.ToString(), stTeams);

            XML.SaveMetaData();

            //MessageBox.Show("Data Saved");
        }

        private void comboBoxConferenceSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedConference = comboBoxConferenceSelect.SelectedIndex > -1 ? comboBoxConferenceSelect.SelectedItem.ToString() : null;

            if (selectedConference == null)
                return;

            switch (selectedConference)
            {
                case "Independent":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.Independent);
                    LoadTeamsButtons(AppState.TeamsByConference.Independent, AppState.CurrentYear.ConferenceStandings.Independent);
                    populateChampion(AppState.TeamsByConference.Independent, AppState.CurrentYear.ConferenceChamps.Independent);
                    break;
                case "Cusa":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.Cusa);
                    LoadTeamsButtons(AppState.TeamsByConference.Cusa, AppState.CurrentYear.ConferenceStandings.Cusa);
                    populateChampion(AppState.TeamsByConference.Cusa, AppState.CurrentYear.ConferenceChamps.Cusa);
                    break;
                case "XII":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.XII);
                    LoadTeamsButtons(AppState.TeamsByConference.XII, AppState.CurrentYear.ConferenceStandings.XII);
                    populateChampion(AppState.TeamsByConference.XII, AppState.CurrentYear.ConferenceChamps.XII);
                    break;
                case "Mac":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.Mac);
                    LoadTeamsButtons(AppState.TeamsByConference.Mac, AppState.CurrentYear.ConferenceStandings.Mac);
                    populateChampion(AppState.TeamsByConference.Mac, AppState.CurrentYear.ConferenceChamps.Mac);
                    break;
                case "Sunbelt":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.Sunbelt);
                    LoadTeamsButtons(AppState.TeamsByConference.Sunbelt, AppState.CurrentYear.ConferenceStandings.Sunbelt);
                    populateChampion(AppState.TeamsByConference.Sunbelt, AppState.CurrentYear.ConferenceChamps.Sunbelt);
                    break;
                case "American":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.American);
                    LoadTeamsButtons(AppState.TeamsByConference.American, AppState.CurrentYear.ConferenceStandings.American);
                    populateChampion(AppState.TeamsByConference.American, AppState.CurrentYear.ConferenceChamps.American);
                    break;
                case "MWC":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.MWC);
                    LoadTeamsButtons(AppState.TeamsByConference.MWC, AppState.CurrentYear.ConferenceStandings.MWC);
                    populateChampion(AppState.TeamsByConference.MWC, AppState.CurrentYear.ConferenceChamps.MWC);
                    break;
                case "SEC":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.SEC);
                    LoadTeamsButtons(AppState.TeamsByConference.SEC, AppState.CurrentYear.ConferenceStandings.SEC);
                    populateChampion(AppState.TeamsByConference.SEC, AppState.CurrentYear.ConferenceChamps.SEC);
                    break;
                case "ACC":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.ACC);
                    LoadTeamsButtons(AppState.TeamsByConference.ACC, AppState.CurrentYear.ConferenceStandings.ACC);
                    populateChampion(AppState.TeamsByConference.ACC, AppState.CurrentYear.ConferenceChamps.ACC);
                    break;
                case "B10":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.B10);
                    LoadTeamsButtons(AppState.TeamsByConference.B10, AppState.CurrentYear.ConferenceStandings.B10);
                    populateChampion(AppState.TeamsByConference.B10, AppState.CurrentYear.ConferenceChamps.B10);
                    break;
                case "Pac12":
                    LoadStandingsList(AppState.CurrentYear.ConferenceStandings.Pac12);
                    LoadTeamsButtons(AppState.TeamsByConference.Pac12, AppState.CurrentYear.ConferenceStandings.Pac12);
                    populateChampion(AppState.TeamsByConference.Pac12, AppState.CurrentYear.ConferenceChamps.Pac12);
                    break;
            }

            //check buttons
            foreach (Button b in flowLayoutPanelConferenceTeams.Controls.OfType<Button>())
            {
                if (listBoxStandings.Items.Contains(b.Text))
                {
                    b.Enabled = false;
                    b.BackColor = Color.LightGray;
                    b.ForeColor = Color.Black;
                }
            }

            void populateChampion(List<Team> confTeams, int confChamp)
            {
                comboBoxConferenceChampion.SelectedIndexChanged -= ComboboxConferenceChampion_IndexChanged;
                AppState.TeamsByConference.Sort();
                comboBoxConferenceChampion.DataSource = confTeams;
                comboBoxConferenceChampion.DisplayMember = "TeamName";
                comboBoxConferenceChampion.SelectedIndex = -1;


                if (confChamp > 0)
                {
                    comboBoxConferenceChampion.SelectedItem = AppState.CurrentYear.Teams.Where(t => t.ID == confChamp).FirstOrDefault();
                }

                comboBoxConferenceChampion.SelectedIndexChanged += ComboboxConferenceChampion_IndexChanged;


            }
        }

        private void ComboboxConferenceChampion_IndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxConferenceSelect.Text)
            {
                case "Independent":
                    AppState.CurrentYear.ConferenceChamps.Independent = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "Cusa":
                    AppState.CurrentYear.ConferenceChamps.Cusa = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "XII":
                    AppState.CurrentYear.ConferenceChamps.XII = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "Mac":
                    AppState.CurrentYear.ConferenceChamps.Mac = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "Sunbelt":
                    AppState.CurrentYear.ConferenceChamps.Sunbelt = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "American":
                    AppState.CurrentYear.ConferenceChamps.American = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "MWC":
                    AppState.CurrentYear.ConferenceChamps.MWC = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "SEC":
                    AppState.CurrentYear.ConferenceChamps.SEC = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "ACC":
                    AppState.CurrentYear.ConferenceChamps.ACC = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "B10":
                    AppState.CurrentYear.ConferenceChamps.B10 = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                case "Pac12":
                    AppState.CurrentYear.ConferenceChamps.Pac12 = (comboBoxConferenceChampion.SelectedItem as Team) == null ? 0 : (comboBoxConferenceChampion.SelectedItem as Team).ID;
                    break;
                default:
                    return;
            }
            XML.SaveMetaData();
        }

        private void LoadTeamsButtons(List<Team> ConferenceTeams, List<int> standings)
        {
            //listBoxStandings.Items.Clear();
            flowLayoutPanelConferenceTeams.Controls.Clear();

            foreach (Team team in ConferenceTeams)
            {
                if (IsFcsTeam(team.TeamName))
                    continue;

                Button button = new Button();
                //button.Size = new Size(200, 50);
                button.Image = new Bitmap(team.Logo, new Size(32, 32));
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.AutoSize = true;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                button.BackColor = Color.White;
                button.ForeColor = team.TeamPrimaryColor;
                button.Tag = team;
                button.Text = team.TeamName;
                button.Click += TeamConferenceButton_Click;


                flowLayoutPanelConferenceTeams.Controls.Add(button);

                if (listBoxStandings.Items.Contains(team))
                {
                    TeamConferenceButton_Disable(button);
                }
            }


        }

        private bool IsFcsTeam(string teamname)
        {
            return teamname.StartsWith("FCS ", StringComparison.OrdinalIgnoreCase);
        }

        private void LoadStandingsList(List<int> tids)
        {
            listBoxStandings.Items.Clear();
            foreach (int id in tids)
            {
                listBoxStandings.Items.Add(AppState.CurrentYear.GetTeamByID(id));
            }
        }

        private void TeamConferenceButton_Click(object sender, EventArgs e)
        {

            listBoxStandings.Items.Add((sender as Button).Tag as Team);
            TeamConferenceButton_Disable(sender as Button);
        }

        private void TeamConferenceButton_Enable(Button btn)
        {
            if (btn == null)
                return;

            btn.Enabled = true;
            btn.BackColor = Color.White;
            btn.ForeColor = (btn.Tag as Team).TeamPrimaryColor;
        }
        private void TeamConferenceButton_Disable(Button btn)
        {
            if (btn == null)
                return;

            btn.Enabled = false;
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flowLayoutPanelConferenceTeams.Controls.OfType<Button>())
            {
                TeamConferenceButton_Enable(btn);
            }
            listBoxStandings.Items.Clear();
        }

        private void ResetConferenceStandings(string conference)
        {

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Game nGame = new Game
            {
                GameID = AppState.CurrentYear.Games.Any() ? AppState.CurrentYear.Games.Max(g => g.GameID) + 1 : 1
            };

            AppState.CurrentYear.Games.Add(nGame);

            LoadGames();
        }
        public void RemoveGame(Game game, GameBar gameBar)
        {
            try
            {
                flowLayoutPanelGameBar.Controls.Remove(gameBar);
                AppState.CurrentYear.Games.Remove(game);
                XML.SaveMetaData();
            }
            catch (Exception e) { MessageBox.Show($"Error: {e.Message}"); }
        }

        private void toolStripComboBoxYears_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            XML.SaveMetaData();

            AppState.CurrentYearPath = $"./Years/{toolStripComboBoxYears.Text}.xml";
            AppState.CurrentYear = XML.LoadMetaData(AppState.CurrentYearPath);
            LoadData();
            foreach (var team in AppState.CurrentYear.Teams)
            {
                team.SetLogo();
            }
            LoadGames();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void LoadRankingTeamButtons()
        {
            flowLayoutPanelRankingsTeams.SuspendLayout();
            flowLayoutPanelRankingsTeams.Controls.Clear();
            List<Button> buttons = new List<Button>();
            foreach (Team team in AppState.CurrentYear.Teams)
            {
                if (IsFcsTeam(team.TeamName))
                    continue;

                Button button = new Button();
                //button.Size = new Size(200, 50);
                button.Image = new Bitmap(team.Logo, new Size(32, 32));
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.AutoSize = true;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                button.BackColor = Color.White;
                button.ForeColor = team.TeamPrimaryColor;
                button.Tag = team;
                button.Text = team.TeamName;
                button.Click += TeamRankingsButton_Click;

                buttons.Add(button);

                if (listBoxRankings.Items.Contains(team) || listBoxRankings.Items.Count == 25)
                {
                    button.Enabled = false;
                    button.BackColor = Color.LightGray;
                    button.ForeColor = Color.Black;
                }
            }

            flowLayoutPanelRankingsTeams.Controls.AddRange(buttons.ToArray());
            flowLayoutPanelRankingsTeams.ResumeLayout();

        }

        List<Button> ButtonRankings = new List<Button>();

        public void TeamRankingsButton_Click(object sender, EventArgs e)
        {
            ButtonRankings.Add((Button)sender);
            listBoxRankings.DisplayMember = "TeamName";
            listBoxRankings.Items.Add(((sender as Button).Tag as Team));
            TeamRankingsButton_Disable(sender as Button);

            if (listBoxRankings.Items.Count == 25)
            {
                foreach (Button b in flowLayoutPanelRankingsTeams.Controls.OfType<Button>())
                {
                    TeamRankingsButton_Disable(b);
                }
            }
        }

        private void TeamRankingsButton_Enable(Button btn)
        {
            if (btn == null)
                return;

            btn.Enabled = true;
            btn.BackColor = Color.White;
            btn.ForeColor = (btn.Tag as Team).TeamPrimaryColor;
        }
        private void TeamRankingsButton_Disable(Button btn)
        {
            if (btn == null)
                return;

            btn.Enabled = false;
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
        }

        private void comboBoxRankings_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRankings.DisplayMember = "TeamName";
            ButtonRankings.Clear();
            switch (comboBoxRankings.Text)
            {
                case "AP":
                    listBoxRankings.Items.Clear();
                    foreach (int id in AppState.CurrentYear.FinalRankings.AP_Poll)
                    {
                        Team t = AppState.CurrentYear.Teams.First(x => x.ID == id);
                        listBoxRankings.Items.Add(t);
                    }
                    break;
                case "Coaches":
                    listBoxRankings.Items.Clear();
                    foreach (int id in AppState.CurrentYear.FinalRankings.Coaches)
                    {
                        listBoxRankings.Items.Add(AppState.CurrentYear.Teams.First(t => t.ID == id));
                    }
                    break;
                case "CFP":
                    listBoxRankings.Items.Clear();
                    foreach (int id in AppState.CurrentYear.FinalRankings.CFP)
                    {
                        listBoxRankings.Items.Add(AppState.CurrentYear.Teams.First(t => t.ID == id));
                    }
                    break;
                default:
                    listBoxRankings.Items.Clear();
                    break;
            }
            LoadRankingTeamButtons();
        }

        private void buttonResetRankings_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanelRankingsTeams.Controls.OfType<Button>())
            {
                TeamRankingsButton_Enable(button);
            }
            listBoxRankings.Items.Clear();
            switch (comboBoxRankings.Text)
            {
                case "AP":
                    AppState.CurrentYear.FinalRankings.ClearRankings(AppState.CurrentYear.FinalRankings.AP_Poll);
                    break;
                case "Coaches":
                    AppState.CurrentYear.FinalRankings.ClearRankings(AppState.CurrentYear.FinalRankings.Coaches);
                    break;
                case "CFP":
                    AppState.CurrentYear.FinalRankings.ClearRankings(AppState.CurrentYear.FinalRankings.CFP);
                    break;
                default:
                    break;
            }
        }

        private void buttonSaveRankings_Click(object sender, EventArgs e)
        {
            List<Team> rkTeams = new List<Team>();
            foreach (object o in listBoxRankings.Items)
            {

                rkTeams.Add(o as Team);
            }

            AppState.CurrentYear.FinalRankings.SetRankings(rkTeams, comboBoxRankings.Text);

            XML.SaveMetaData();

            //MessageBox.Show("Data Saved");
        }

        public void UpdateWinLoss()
        {
            labelWins.Text = AppState.CurrentYear.Mdata.Wins.ToString();
            labelLosses.Text = AppState.CurrentYear.Mdata.Losses.ToString();
        }
        public void UpdateBowlsToGamesTab()
        {
            comboBoxTeamBowlPlayed.DataSource = null;
            comboBoxTeamBowlPlayed.DataSource = AppState.CurrentYear.Bowls;
            comboBoxTeamBowlPlayed.DisplayMember = "BowlName";
        }

        private void comboBoxTeamBowlPlayed_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppState.CurrentYear.Mdata.Bowl = comboBoxTeamBowlPlayed.Text;

            XML.SaveMetaData();
        }

        private void checkBoxBowlWon_CheckedChanged(object sender, EventArgs e)
        {
            AppState.CurrentYear.Mdata.Won = checkBoxBowlWon.Checked;
            XML.SaveMetaData();
        }

        private void comboBoxMyEndRanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppState.CurrentYear.Mdata.Endranking = comboBoxMyEndRanking.Text == "None" ? 0 : int.Parse(comboBoxMyEndRanking.Text);
            XML.SaveMetaData();
        }

        private void numericUpDownRating_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"sender = {(sender as NumericUpDown).Name}");
            AppState.CurrentYear.Mdata.Off = int.Parse(numericUpDownOff.Value.ToString());
            AppState.CurrentYear.Mdata.Def = int.Parse(numericUpDownDef.Value.ToString());
            AppState.CurrentYear.Mdata.Ovr = int.Parse(numericUpDownOvr.Value.ToString());
            XML.SaveMetaData();
        }

        private void BowlSelectT(object sender, EventArgs e)
        {
            flowLayoutPanelTeamButtonsBowls.SuspendLayout();
            
            if ((comboBoxBowls.SelectedItem as Bowl).WinningTeamID > 0)
            {
                foreach (Button button in flowLayoutPanelTeamButtonsBowls.Controls.OfType<Button>())
                {
                    if ((comboBoxBowls.SelectedItem as Bowl).WinningTeamID != (button.Tag as Team).ID)
                    {
                        TeamConferenceButton_Disable(button);
                    }
                    else
                    {
                        TeamConferenceButton_Enable(button);
                    }
                }
            }
            else
            {
                foreach (Button button in flowLayoutPanelTeamButtonsBowls.Controls.OfType<Button>())
                {
                    TeamConferenceButton_Enable(button);
                }
            }
                flowLayoutPanelTeamButtonsBowls.ResumeLayout();
        }

        private void BowlTeamButton_Click(object sender, EventArgs e)
        {
            (comboBoxBowls.SelectedItem as Bowl).WinningTeamID = ((sender as Button).Tag as Team).ID;

            //greyout
            foreach (Button b in flowLayoutPanelTeamButtonsBowls.Controls.OfType<Button>())
            {
                if (b != (sender as Button))
                {
                    TeamConferenceButton_Disable(b);
                }
            }
            XML.SaveMetaData();
        }

        private void buttonBowlReset_Click(object sender, EventArgs e)
        {
            (comboBoxBowls.SelectedItem as Bowl).WinningTeamID = 0;
            foreach (Button b in flowLayoutPanelTeamButtonsBowls.Controls.OfType<Button>())
            {
                TeamConferenceButton_Enable(b);
            }
            XML.SaveMetaData();
        }

        private void buttonConferenceChampReset_Click(object sender, EventArgs e)
        {
            comboBoxConferenceChampion.SelectedIndexChanged -= ComboboxConferenceChampion_IndexChanged;
            comboBoxConferenceChampion.SelectedIndex = -1;
            switch (comboBoxConferenceSelect.Text)
            {
                case "Independent":
                    AppState.CurrentYear.ConferenceChamps.Independent = 0;
                    break;
                case "Cusa":
                    AppState.CurrentYear.ConferenceChamps.Cusa = 0;
                    break;
                case "XII":
                    AppState.CurrentYear.ConferenceChamps.XII = 0;
                    break;
                case "Mac":
                    AppState.CurrentYear.ConferenceChamps.Mac = 0;
                    break;
                case "Sunbelt":
                    AppState.CurrentYear.ConferenceChamps.Sunbelt = 0;
                    break;
                case "American":
                    AppState.CurrentYear.ConferenceChamps.American = 0;
                    break;
                case "MWC":
                    AppState.CurrentYear.ConferenceChamps.MWC = 0;
                    break;
                case "SEC":
                    AppState.CurrentYear.ConferenceChamps.SEC = 0;
                    break;
                case "ACC":
                    AppState.CurrentYear.ConferenceChamps.ACC = 0;
                    break;
                case "B10":
                    AppState.CurrentYear.ConferenceChamps.B10 = 0;
                    break;
                case "Pac12":
                    AppState.CurrentYear.ConferenceChamps.Pac12 = 0;
                    break;
                default:
                    // optional: handle unknown conference
                    break;
            }
            XML.SaveMetaData();
            comboBoxConferenceChampion.SelectedIndexChanged += ComboboxConferenceChampion_IndexChanged;
        }

        private void buttonImportCFP_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Image Files (*.png;)|*.png;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string savePath = $"./CFPImages/{AppState.CurrentYear.Mdata.Year}.png";
                File.Copy(ofd.FileName, savePath, true);

                using var tempImage = Image.FromFile(savePath);
                var loadedImage = new Bitmap(tempImage);

                pictureBoxBracket.Image = loadedImage;
                AppState.CurrentYear.CFPFilePath = savePath;
                AppState.CurrentYear.CFP = new Bitmap(loadedImage);

                XML.SaveMetaData();
            }
        }

        private void pictureBoxBracket_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBoxBracket_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filepath = files[0];

                string extenstion = Path.GetExtension(filepath).ToLower();
                if (extenstion == ".png")
                {
                    string savePath = Path.Combine("./CFPImages", AppState.CurrentYear.Mdata.Year.ToString(), ".png");
                    Directory.CreateDirectory(Path.GetDirectoryName(savePath)!);
                    File.Copy(filepath, savePath, true);

                    pictureBoxBracket.Image = Image.FromFile(savePath);
                    AppState.CurrentYear.CFPFilePath = savePath;
                    AppState.CurrentYear.CFP = Image.FromFile(savePath);
                    XML.SaveMetaData();
                }
                else
                {
                    MessageBox.Show("Only .png files are allowed.");
                }
            }
        }

        private void buttonDeleteCFP_Click(object sender, EventArgs e)
        {
            AppState.CurrentYear.CFP = null;
            AppState.CurrentYear.CFPFilePath = string.Empty;
            pictureBoxBracket.Image = null;
            XML.SaveMetaData();

            string Path = $"./CFPImages/{AppState.CurrentYear.Mdata.Year.ToString()}.png";
            File.Delete(Path);
        }

        private void buttonBowlFullView_Click(object sender, EventArgs e)
        {
            FullBowls fb = new FullBowls();
            fb.Show();
        }

        private void buttonExportList_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Team t in listBoxRankings.Items)
            {
                sb.AppendLine(t.TeamName);
            }
            Clipboard.SetText(sb.ToString());
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanelLegacy.Controls.Clear();

            labelLegacyWins.Text = "0";
            labelLegacyLosses.Text = "0";

            var yearFiles = Directory
            .GetFiles("./Years", "*.xml")
            .Where(path => !Path.GetFileName(path).Equals("Template.xml", StringComparison.OrdinalIgnoreCase))
            .ToList();

            foreach (string file in yearFiles)
            {
                try
                {
                    MetaData data = XML.LoadMetaData(file);

                    data.Teams.FirstOrDefault(t => t.ID == data.Mdata.Team).SetLogo();

                    flowLayoutPanelLegacy.Controls.Add(new YearCard(data));

                    labelLegacyWins.Text = (int.Parse(labelLegacyWins.Text) + data.Mdata.Wins).ToString();
                    labelLegacyLosses.Text = (int.Parse(labelLegacyLosses.Text) + data.Mdata.Losses).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {file}\n\n{ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonRankingsUndo_Click(object sender, EventArgs e)
        {
            listBoxRankings.Items.RemoveAt(listBoxRankings.Items.Count - 1);
            TeamRankingsButton_Enable(ButtonRankings[ButtonRankings.Count - 1]);
            ButtonRankings.RemoveAt(ButtonRankings.Count - 1);
        }

        private void comboBoxCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppState.CurrentYear.Mdata.Coaching_Position = (string)comboBoxCoach.SelectedItem;
            XML.SaveMetaData();
        }

        private void labelTeam_Paint(object sender, PaintEventArgs e)
        {
            var label = sender as Label;
            if (label == null) return;

            Rectangle rect = label.ClientRectangle;
            Color teamColor = label.BackColor; // This is your strong middle color

            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                rect,
                teamColor,        // start with the team color
                teamColor,        // will be overridden by blend
                System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                var blend = new System.Drawing.Drawing2D.ColorBlend
                {
                    Positions = new[] { 0f, 0.5f, 1f },
                    Colors = new[]
                    {
                SystemColors.ControlDarkDark,  // left fade
                teamColor,       // strong center
                SystemColors.ControlDarkDark   // right fade
            }
                };

                brush.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush, rect);
            }

            // Draw text on top
            TextRenderer.DrawText(
                e.Graphics,
                label.Text,
                label.Font,
                rect,
                label.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
