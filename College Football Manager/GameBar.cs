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
    public partial class GameBar : UserControl
    {
        Game GameData { get; set; }
        public GameBar(Game g)
        {
            InitializeComponent();
            GameData = g;
        }

        private void GameBar_Load(object sender, EventArgs e)
        {
            pictureBoxMyTeam.Image = AppState.CurrentYear.Teams.Where(t => t.ID == AppState.CurrentYear.Mdata.Team).FirstOrDefault().Logo;
            comboBoxOpponent.DataSource = AppState.CurrentYear.Teams;
            comboBoxOpponent.ValueMember = "ID";
            comboBoxOpponent.DisplayMember = "TeamName";
        }

        public void LoadData()
        {
            comboBoxOpponent.SelectedIndexChanged -= comboBoxOpponent_SelectedIndexChanged;

            this.BorderStyle = BorderStyle.FixedSingle;
            comboBoxOpponent.DataSource = AppState.CurrentYear.Teams;
            comboBoxOpponent.ValueMember = "ID";
            comboBoxOpponent.DisplayMember = "TeamName";
            textBoxMyRank.Text = GameData.Rank > 0 ? GameData.Rank.ToString() : string.Empty;
            textBoxOpponentRank.Text = GameData.OpponentRank > 0 ? GameData.OpponentRank.ToString() : string.Empty;
            Team opponent = AppState.CurrentYear.Teams.FirstOrDefault(t => t.ID == GameData.Opponent);
            comboBoxOpponent.SelectedValue = opponent == null ? 0 : opponent.ID;
            Team myteam = AppState.CurrentYear.Teams.Where(t => t.ID == AppState.CurrentYear.Mdata.Team).FirstOrDefault();
            pictureBoxMyTeam.Image = AppState.CurrentYear.Teams.Where(t => t.ID == AppState.CurrentYear.Mdata.Team).FirstOrDefault().Logo;
            pictureBoxOpponent.Image = opponent == null ? null : (comboBoxOpponent.SelectedItem as Team).Logo;
            textBoxMyScore.Text = GameData.TeamScore == -1 ? string.Empty : GameData.TeamScore.ToString();
            textBoxOpponentScore.Text = GameData.OpponentScore == -1 ? string.Empty : GameData.OpponentScore.ToString();
            switch (GameData.GameLocation)
            {
                case GameLocation.Home:
                    comboBoxLocation.SelectedIndex = 0;
                    break;
                case GameLocation.Away:
                    comboBoxLocation.SelectedIndex = 1;
                    break;
                case GameLocation.Neutral:
                    comboBoxLocation.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
            switch (GameData.GameResult)
            {
                case GameResult.None:
                    labelWL.Text = string.Empty;
                    break;
                case GameResult.Win:
                    labelWL.Text = "W";
                    labelWL.ForeColor = Color.Green;
                    break;
                case GameResult.Loss:
                    labelWL.Text = "L";
                    labelWL.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
            textBoxName.Text = GameData.GameName;

            comboBoxOpponent.SelectedIndexChanged += comboBoxOpponent_SelectedIndexChanged;
        }

        private void comboBoxOpponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameData.Opponent = (comboBoxOpponent.SelectedItem as Team).ID;
            pictureBoxOpponent.Image = (comboBoxOpponent.SelectedItem as Team).Logo;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DashBoard db = Application.OpenForms.OfType<DashBoard>().FirstOrDefault();
            if (db != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this game?", "Delete Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.RemoveGame(GameData, this);
                    UpdateWinLoss();
                    db.UpdateWinLoss();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //verify data
            if (!CheckData())
            {
                MessageBox.Show("Check entered data.");
                return;
            }

            GameData.Rank = textBoxMyRank.Text == string.Empty ? 0 : int.Parse(textBoxMyRank.Text);
            GameData.OpponentRank = textBoxOpponentRank.Text == string.Empty ? 0 : int.Parse(textBoxOpponentRank.Text);
            GameData.Opponent = (comboBoxOpponent.SelectedItem as Team).ID;
            GameData.GameName = textBoxName.Text;
            GameData.TeamScore = textBoxMyScore.Text == string.Empty ? -1 : int.Parse(textBoxMyScore.Text);
            GameData.OpponentScore = textBoxOpponentScore.Text == string.Empty ? -1 : int.Parse(textBoxOpponentScore.Text);
            if (GameData.TeamScore == GameData.OpponentScore) { GameData.GameResult = GameResult.None; labelWL.Text = string.Empty; }
            else if (GameData.TeamScore > GameData.OpponentScore) { GameData.GameResult = GameResult.Win; labelWL.Text = "W"; labelWL.ForeColor = Color.Green; }
            else { GameData.GameResult = GameResult.Loss; labelWL.Text = "L"; labelWL.ForeColor = Color.Red; }
            switch (comboBoxLocation.Text)
            {
                case "VS":
                    GameData.GameLocation = GameLocation.Home;
                    break;
                case "AT":
                    GameData.GameLocation = GameLocation.Away;
                    break;
                case "N":
                    GameData.GameLocation = GameLocation.Neutral;
                    break;
                default:
                    break;
            }

            UpdateWinLoss();
            Application.OpenForms.OfType<DashBoard>().First().UpdateWinLoss();

            XML.SaveMetaData();

            var i = 0;
        }
        private bool CheckData()
        {
            if (comboBoxOpponent.SelectedIndex == -1) return false;
            if (comboBoxLocation.SelectedIndex == -1) return false;
            return true;
        }

        public void UpdateWinLoss()
        {
            AppState.CurrentYear.Mdata.Wins = 0;
            AppState.CurrentYear.Mdata.Losses = 0;
            foreach (Game g in AppState.CurrentYear.Games)
            {
                if (g.GameResult == GameResult.Win)
                {
                    AppState.CurrentYear.Mdata.Wins++;
                }
                else if (g.GameResult == GameResult.Loss)
                {
                    AppState.CurrentYear.Mdata.Losses++;
                }
                else { continue; }
            }
        }

        private void textBoxMyScore_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void textBoxMyScore_Leave(object sender, EventArgs e)
        {
            int score = ((TextBox)sender).Text == string.Empty ? 0 : int.Parse(((TextBox)sender).Text);
            ((TextBox)sender).Text = score.ToString();
        }
    }
}
