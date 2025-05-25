using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Football_Manager.MetaSettings
{
    public partial class TeamsSettingsForm : Form
    {
        CustomPictureBox SelectedPB = null;
        ToolTip ttip = new ToolTip();


        public TeamsSettingsForm()
        {
            InitializeComponent();
        }

        private void TeamsSettingsForm_Load(object sender, EventArgs e)
        {
            CenterToParent();

            //loadteams
            UpdateTeams();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTeam at = new AddTeam();
            at.ShowDialog();
        }


        public void UpdateTeams()
        {
            SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            List<CustomPictureBox> cpb = new List<CustomPictureBox>();
            foreach (Team t in AppState.CurrentYear.Teams)
            {
                CustomPictureBox npb = new CustomPictureBox();
                npb.Size = new Size(75, 75);
                npb.TeamData = t;
                npb.BorderStyle = BorderStyle.FixedSingle;
                npb.Image = t.Logo;
                cpb.Add(npb);
                npb.SizeMode = PictureBoxSizeMode.StretchImage;
                string tooltiptext = $"ID: {t.ID}\nName: {t.TeamName}\nPrimaryColor: {$"#{t.TeamPrimaryColor.R:X2}{t.TeamPrimaryColor.G:X2}{t.TeamPrimaryColor.B:X2}"}\nSecondaryColor: {$"#{t.TeamSecondaryColor.R:X2}{t.TeamSecondaryColor.G:X2}{t.TeamSecondaryColor.B:X2}"}\nConference: {t.Conference}\nLogoFilePath: {t.ImageFileName}";
                ttip.SetToolTip(npb, tooltiptext);
                npb.Click += SelectPictureBox;
            }
            flowLayoutPanel1.Controls.AddRange(cpb.ToArray());
            ResumeLayout();
        }

        public void SelectPictureBox(object sender, EventArgs e)
        {
            foreach (CustomPictureBox customPictureBox in flowLayoutPanel1.Controls.OfType<CustomPictureBox>())
            {
                customPictureBox.BorderStyle = BorderStyle.FixedSingle;
            }

            CustomPictureBox pb = sender as CustomPictureBox;

            pb.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxTeamSelected.Image = pb.Image;
            SelectedPB = pb;
            textBox1.Text = pb.TeamData.TeamName;
            pictureBoxConference.Image = AppState.ConferenceLogos.GetConferenceImage(pb.TeamData.Conference);
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedPB != null)
            {
                AddTeam at = new AddTeam(SelectedPB.TeamData);
                at.ShowDialog();
            }
        }
    }
}
