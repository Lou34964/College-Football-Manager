using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Football_Manager.MetaSettings
{
    public partial class AddTeam : Form
    {
        public SettingFormState SettingFormState { get; set; }
        public int TeamIDSelected { get; set; }
        public AddTeam()
        {
            InitializeComponent();
        }

        public AddTeam(Team t)
        {
            InitializeComponent();

            SettingFormState = SettingFormState.Edit;
            TeamIDSelected = t.ID;
            textBoxTeamName.Text = t.TeamName;
            textBoxFilename.Text = t.ImageFileName;
            textBoxPrimaryColor.Text = $"#{t.TeamPrimaryColor.R:X2}{t.TeamPrimaryColor.G:X2}{t.TeamPrimaryColor.B:X2}";
            textBoxSecondaryColor.Text = $"#{t.TeamSecondaryColor.R:X2}{t.TeamSecondaryColor.G:X2}{t.TeamSecondaryColor.B:X2}";
            switch (t.Conference)
            {
                case "Independent":
                    comboBoxConference.SelectedIndex = 0;
                    break;
                case "Cusa":
                    comboBoxConference.SelectedIndex = 1;
                    break;
                case "XII":
                    comboBoxConference.SelectedIndex = 2;
                    break;
                case "Mac":
                    comboBoxConference.SelectedIndex = 3;
                    break;
                case "Sunbelt":
                    comboBoxConference.SelectedIndex = 4;
                    break;
                case "American":
                    comboBoxConference.SelectedIndex = 5;
                    break;
                case "MWC":
                    comboBoxConference.SelectedIndex = 6;
                    break;
                case "SEC":
                    comboBoxConference.SelectedIndex = 7;
                    break;
                case "ACC":
                    comboBoxConference.SelectedIndex = 8;
                    break;
                case "B10":
                    comboBoxConference.SelectedIndex = 9;
                    break;
                case "Pac12":
                    comboBoxConference.SelectedIndex = 10;
                    break;
                default:
                    comboBoxConference.SelectedIndex = -1;
                    break;
            }
            panelPrimaryColor.BackColor = t.TeamPrimaryColor;
            panelSecondaryColor.BackColor = t.TeamSecondaryColor;

            buttonAdd.Text = "Save";
        }

        private void buttonPrimaryColorSelect_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    textBoxPrimaryColor.Text = $"#{cd.Color.R:X2}{cd.Color.G:X2}{cd.Color.B:X2}";
                    panelPrimaryColor.BackColor = cd.Color;
                }
            }
        }

        private void buttonSecondaryColorSelect_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    textBoxSecondaryColor.Text = $"#{cd.Color.R:X2}{cd.Color.G:X2}{cd.Color.B:X2}";
                    panelSecondaryColor.BackColor = cd.Color;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (SettingFormState == SettingFormState.Add)
            {
                //verify data
                //checks - if true = return
                if (textBoxTeamName.Text == string.Empty)
                {
                    return;
                }
                if (textBoxPrimaryColor.Text == string.Empty)
                {
                    return;
                }
                if (textBoxSecondaryColor.Text == string.Empty)
                {
                    return;
                }
                if (textBoxFilename.Text == string.Empty)
                {
                    return;
                }

                //create new team
                Team newTeam = new Team();
                newTeam.TeamName = textBoxTeamName.Text;
                newTeam.TeamPrimaryColor = ColorTranslator.FromHtml(textBoxPrimaryColor.Text);
                newTeam.TeamSecondaryColor = ColorTranslator.FromHtml(textBoxSecondaryColor.Text);
                newTeam.Conference = comboBoxConference.Text;
                newTeam.ImageFileName = textBoxFilename.Text;
                newTeam.ID = AppState.CurrentYear.Teams.Count > 0 ? AppState.CurrentYear.Teams.Max(x => x.ID) + 1 : 1;

                //add new team to the current year teams list.
                AppState.CurrentYear.Teams.Add(newTeam);

                //sort
                AppState.CurrentYear.Teams = AppState.CurrentYear.Teams.OrderBy(x => x.TeamName).ToList();
            }
            else
            {
                //verify data
                //checks - if true = return
                if (textBoxTeamName.Text == string.Empty)
                {
                    return;
                }
                if (textBoxPrimaryColor.Text == string.Empty)
                {
                    return;
                }
                if (textBoxSecondaryColor.Text == string.Empty)
                {
                    return;
                }
                if (textBoxFilename.Text == string.Empty)
                {
                    return;
                }

                AppState.CurrentYear.Teams.Where(t => t.ID == TeamIDSelected).First().TeamName = textBoxTeamName.Text;
                AppState.CurrentYear.Teams.Where(t => t.ID == TeamIDSelected).First().TeamPrimaryColor = ColorTranslator.FromHtml(textBoxPrimaryColor.Text); ;
                AppState.CurrentYear.Teams.Where(t => t.ID == TeamIDSelected).First().TeamSecondaryColor = ColorTranslator.FromHtml(textBoxSecondaryColor.Text);
                AppState.CurrentYear.Teams.Where(t => t.ID == TeamIDSelected).First().Conference = comboBoxConference.Text;
                AppState.CurrentYear.Teams.Where(t => t.ID == TeamIDSelected).First().ImageFileName = textBoxFilename.Text;
                AppState.CurrentYear.Teams.Where(t => t.ID == TeamIDSelected).First().ID = TeamIDSelected;
            }

            //save data to file

            XML.SaveMetaData();

            //update teamslist
            TeamsSettingsForm tsf = Application.OpenForms.OfType<TeamsSettingsForm>().FirstOrDefault();
            if (tsf != null)
            {
                tsf.UpdateTeams();
            }

            //multi team add
            if (checkBoxMultiTeam.Checked)
            {
                textBoxTeamName.Text = string.Empty;
                textBoxPrimaryColor.Text = string.Empty;
                textBoxSecondaryColor.Text = string.Empty;
                textBoxFilename.Text = string.Empty;
                panelPrimaryColor.BackColor = Color.Transparent;
                panelSecondaryColor.BackColor = Color.Transparent;
            }
            else { Close(); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();

            oFD.InitialDirectory = "./Icons";
            if(oFD.ShowDialog() == DialogResult.OK)
            {
                textBoxFilename.Text = oFD.FileName;
            }
        }
    }

    public enum SettingFormState
    {
        Add = 0,
        Edit = 1
    }
}
