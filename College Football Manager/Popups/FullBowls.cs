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
    public partial class FullBowls : Form
    {
        public FullBowls()
        {
            InitializeComponent();
        }

        private void FullBowls_Load(object sender, EventArgs e)
        {
            CenterToParent();
            List<string> ignoredBowls = new()
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
                "Championship",
                "None"
            };

            foreach (Bowl bowl in AppState.CurrentYear.Bowls)
            {
                if (ignoredBowls.Contains(bowl.BowlName))
                    continue;

                BowlCard card = new BowlCard(bowl);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
