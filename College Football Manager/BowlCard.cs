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
    public partial class BowlCard : UserControl
    {
        public Bowl Bowl
        {
            get { return Bowl; }
            set
            {
                labelBowlName.Text = value.BowlName;
                if (value.WinningTeamID != 0)
                {
                    pictureBoxLogo.Image = AppState.CurrentYear.Teams.First(t => t.ID == value.WinningTeamID).Logo;
                    labelTeamName.Text = AppState.CurrentYear.Teams.First(t => t.ID == value.WinningTeamID).TeamName;
                    labelTeamName.BackColor = AppState.CurrentYear.Teams.First(t => t.ID == value.WinningTeamID).TeamPrimaryColor;
                    labelTeamName.ForeColor = GetContrastColor(labelTeamName.BackColor);
                }
            }
        }

        public Color GetContrastColor(Color color)
        {
            int brightness = (int)(color.R * 0.229 + color.G * 0.578 + color.B * 0.114);
            return brightness > 150 ? Color.Black : Color.White;
        }

        public BowlCard(Bowl b)
        {
            InitializeComponent();
            Bowl = b;
        }

        private void labelTeamName_Paint(object sender, PaintEventArgs e)
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
                Color.DarkGray,  // left fade
                teamColor,       // strong center
                Color.DarkGray   // right fade
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
