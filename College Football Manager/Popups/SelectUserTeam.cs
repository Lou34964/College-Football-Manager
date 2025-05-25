using College_Football_Manager.MetaSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Football_Manager.Popups
{
    public partial class SelectUserTeam : Form
    {
        public SelectUserTeam()
        {
            InitializeComponent();
        }

        private void SelectUserTeam_Load(object sender, EventArgs e)
        {
            CenterToParent();
            comboBox1.DataSource = null;
            comboBox1.DataSource = AppState.CurrentYear.Teams;
            comboBox1.DisplayMember = "TeamName";


        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                return;

            AppState.CurrentYear.Mdata.Team = (comboBox1.SelectedItem as Team).ID;

            XML.SaveMetaData();

            //update dashboard
            DashBoard dashBoard = Application.OpenForms.OfType<DashBoard>().FirstOrDefault();
            dashBoard.LoadData();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
