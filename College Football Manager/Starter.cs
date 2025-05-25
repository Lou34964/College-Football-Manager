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

namespace College_Football_Manager
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void Starter_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Hide();

            //load Template data if file exsists
            if (File.Exists(AppState.CurrentYearPath))
            {
                //MessageBox.Show(Path.GetFullPath(AppState.CurrentYearPath));
                AppState.CurrentYear = XML.LoadMetaData(AppState.CurrentYearPath);
                AppState.CurrentYear.Teams = AppState.CurrentYear.Teams.OrderBy(t => t.TeamName).ToList();
                XML.SaveMetaData();

                //setlogo
                foreach(var team in AppState.CurrentYear.Teams)
                {
                    team.SetLogo();
                }
            }

            //load available years
            AppState.YearsAvailable.AddRange(CFM.GetAvailableYears());

            //load Dashboard
            DashBoard db = new DashBoard();
            db.Show();
        }

    }
}
