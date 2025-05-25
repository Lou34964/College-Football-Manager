using College_Football_Manager.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Football_Manager.MetaSettings
{
    public partial class SettingsMain : Form
    {
        public SettingsMain()
        {
            InitializeComponent();
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            //open Teams Settings Page
            TeamsSettingsForm tsf = new TeamsSettingsForm();
            tsf.Show();
        }

        private void SettingsMain_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void buttonSetMyTeam_Click(object sender, EventArgs e)
        {
            SelectUserTeam selectUserTeam = new SelectUserTeam();
            selectUserTeam.ShowDialog();
        }

        private void buttonBowls_Click(object sender, EventArgs e)
        {
            BowlsSettingsForm tsf = new BowlsSettingsForm();
            tsf.ShowDialog();
        }
    }
}
