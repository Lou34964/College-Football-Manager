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
    public partial class YearCard : UserControl
    {
        public MetaData Year { get; set; }
        public Team MyTeam { get; set; }
        public YearCard(MetaData year)
        {
            InitializeComponent();
            DoubleBuffered = true;
            Year = year;
            BorderStyle = BorderStyle.Fixed3D;
            MyTeam = Year.Teams.FirstOrDefault(t => t.ID == Year.Mdata.Team);
            SetData();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            string watermarkText = Year.Mdata.Year.ToString();

            using Font watermarkFont = new Font("Segoe UI", 60, FontStyle.Bold, GraphicsUnit.Pixel);
            using Brush watermarkBrush = new SolidBrush(Color.FromArgb(100, GetContrastingTextColor(MyTeam.TeamPrimaryColor)));

            SizeF textSize = e.Graphics.MeasureString(watermarkText, watermarkFont);
            PointF center = new PointF(
                ((Width - textSize.Width) / 2) - 40,
                (Height - textSize.Height) / 2
                );

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.DrawString(watermarkText, watermarkFont, watermarkBrush, center);
        }
        private Color GetContrastingTextColor(Color bg)
        {
            // Formula for luminance perception
            double luminance = (0.299 * bg.R + 0.587 * bg.G + 0.114 * bg.B);
            return luminance > 128 ? Color.Black : Color.White;
        }
        public void SetData()
        {

            this.BackColor = MyTeam.TeamPrimaryColor;
            pictureBoxTeamLogo.Image = MyTeam.Logo;
            //pictureBoxTeamLogo.BackColor = Color.FromArgb(Math.Min(MyTeam.TeamPrimaryColor.R + 30, 255), Math.Min(MyTeam.TeamPrimaryColor.G + 30, 255), Math.Min(MyTeam.TeamPrimaryColor.B + 30, 255));
            pictureBoxTeamLogo.BackColor = Color.White;
            labelTeamName.Text = MyTeam.TeamName;
            labelOff.Text = $"Offense: {Year.Mdata.Off}";
            labelDef.Text = $"Defense: {Year.Mdata.Def}";
            labelOvr.Text = $"Overall: {Year.Mdata.Ovr}";
            labelFinalRanking.Text = $"Final Ranking: {Year.Mdata.Endranking}";
            labelWins.Text = $"{Year.Mdata.Wins}";
            labelLosses.Text = $"{Year.Mdata.Losses}";
            labelBowl.Text = $"Bowl: {Year.Mdata.Bowl}";
            if (Year.Mdata.Bowl == "None")
            {
                labelWon.Text = string.Empty;
            }
            else
            {
                labelWon.Text = Year.Mdata.Won ? "Won" : "Lost";
            }
            labelCoachPos.Text = Year.Mdata.Coaching_Position;

            pictureBoxTeamLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            foreach (Label l in this.Controls.OfType<Label>())
            {
                if (l.Name == "labelWins" || l.Name == "labelLosses")
                    continue;
                l.ForeColor = GetContrastingTextColor(MyTeam.TeamPrimaryColor);
            }
        }

        private void YearCard_Load(object sender, EventArgs e)
        {

        }
    }
}
