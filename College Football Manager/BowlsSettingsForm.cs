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
    public partial class BowlsSettingsForm : Form
    {
        public BowlsSettingsForm()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonAdd;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void BowlsSettingsForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = AppState.CurrentYear.Bowls;
            listBox1.DisplayMember = "BowlName";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AppState.CurrentYear.Bowls.FirstOrDefault(b => b.BowlName == textBox1.Text) == null || AppState.CurrentYear.Bowls.Count < 1)
            {
                AppState.CurrentYear.Bowls.Add(new Bowl { BowlName = textBox1.Text });

                XML.SaveMetaData();

                listBox1.DataSource = null;
                listBox1.DataSource = AppState.CurrentYear.Bowls;
                listBox1.DisplayMember = "BowlName";
                
                textBox1.Text = string.Empty;

                Application.OpenForms.OfType<DashBoard>().First().UpdateBowlsToGamesTab();
            }
            else
            {
                MessageBox.Show("Bowl Already Exists.");
                return;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            AppState.CurrentYear.Bowls.Remove(listBox1.SelectedItem as Bowl);

            listBox1.DataSource = null;
            listBox1.DataSource = AppState.CurrentYear.Bowls;
            listBox1.DisplayMember = "BowlName";

            XML.SaveMetaData();
            Application.OpenForms.OfType<DashBoard>().First().UpdateBowlsToGamesTab();
        }
    }
}
