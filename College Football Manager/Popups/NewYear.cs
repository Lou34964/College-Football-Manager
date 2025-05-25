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
    public partial class NewYear : Form
    {
        public NewYear()
        {
            InitializeComponent();
        }

        private void NewYear_Load(object sender, EventArgs e)
        {
            CenterToParent();
            int lastYear = Directory.GetFiles("./Years", "*.xml")
                .Select(f => Path.GetFileNameWithoutExtension(f))
                .Where(name => name != "Template" && int.TryParse(name, out _))
                .Select(name => int.Parse(name))
                .DefaultIfEmpty(2023)
                .Max();

            int start = lastYear + 1;
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(start + i);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;

            if (MessageBox.Show($"Are you sure you want to start a year on {comboBox1.Text}?\n\nIf you press yes, you will need to select the year file you want to copy scheme from.", "New Year?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Path.GetFullPath("./Years");
                openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AppState.CopyNewYear(openFileDialog.FileName, int.Parse(comboBox1.Text));
                }
                AppState.YearsAvailable.Clear();
                AppState.YearsAvailable.AddRange(CFM.GetAvailableYears());
                Application.OpenForms.OfType<DashBoard>().First().LoadYearsAvailable();
                Close();
            }
            else return;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
