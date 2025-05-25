namespace College_Football_Manager
{
    partial class YearCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxTeamLogo = new PictureBox();
            labelTeamName = new Label();
            label1 = new Label();
            labelOff = new Label();
            labelDef = new Label();
            labelOvr = new Label();
            labelFinalRanking = new Label();
            label11 = new Label();
            labelLosses = new Label();
            labelWins = new Label();
            label14 = new Label();
            label15 = new Label();
            labelBowl = new Label();
            labelWon = new Label();
            labelCoachPos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeamLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTeamLogo
            // 
            pictureBoxTeamLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxTeamLogo.Dock = DockStyle.Left;
            pictureBoxTeamLogo.Location = new Point(0, 0);
            pictureBoxTeamLogo.Margin = new Padding(4);
            pictureBoxTeamLogo.Name = "pictureBoxTeamLogo";
            pictureBoxTeamLogo.Size = new Size(148, 148);
            pictureBoxTeamLogo.TabIndex = 0;
            pictureBoxTeamLogo.TabStop = false;
            // 
            // labelTeamName
            // 
            labelTeamName.AutoSize = true;
            labelTeamName.BackColor = Color.Transparent;
            labelTeamName.Font = new Font("Segoe UI", 16F);
            labelTeamName.Location = new Point(155, 13);
            labelTeamName.Name = "labelTeamName";
            labelTeamName.Size = new Size(129, 30);
            labelTeamName.TabIndex = 1;
            labelTeamName.Text = "Team Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(449, 13);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 2;
            label1.Text = "Ratings";
            // 
            // labelOff
            // 
            labelOff.AutoSize = true;
            labelOff.BackColor = Color.Transparent;
            labelOff.Font = new Font("Segoe UI", 13F);
            labelOff.Location = new Point(430, 41);
            labelOff.Name = "labelOff";
            labelOff.Size = new Size(78, 25);
            labelOff.TabIndex = 3;
            labelOff.Text = "Offense:";
            // 
            // labelDef
            // 
            labelDef.AutoSize = true;
            labelDef.BackColor = Color.Transparent;
            labelDef.Font = new Font("Segoe UI", 13F);
            labelDef.Location = new Point(428, 66);
            labelDef.Name = "labelDef";
            labelDef.Size = new Size(80, 25);
            labelDef.TabIndex = 4;
            labelDef.Text = "Defense:";
            // 
            // labelOvr
            // 
            labelOvr.AutoSize = true;
            labelOvr.BackColor = Color.Transparent;
            labelOvr.Font = new Font("Segoe UI", 13F);
            labelOvr.Location = new Point(437, 91);
            labelOvr.Name = "labelOvr";
            labelOvr.Size = new Size(71, 25);
            labelOvr.TabIndex = 5;
            labelOvr.Text = "Overall:";
            // 
            // labelFinalRanking
            // 
            labelFinalRanking.AutoSize = true;
            labelFinalRanking.BackColor = Color.Transparent;
            labelFinalRanking.Location = new Point(577, 13);
            labelFinalRanking.Name = "labelFinalRanking";
            labelFinalRanking.Size = new Size(107, 21);
            labelFinalRanking.TabIndex = 6;
            labelFinalRanking.Text = "Final Ranking:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(613, 63);
            label11.Name = "label11";
            label11.Size = new Size(21, 30);
            label11.TabIndex = 16;
            label11.Text = "-";
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.BackColor = Color.Black;
            labelLosses.BorderStyle = BorderStyle.Fixed3D;
            labelLosses.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelLosses.ForeColor = Color.Red;
            labelLosses.Location = new Point(643, 61);
            labelLosses.MaximumSize = new Size(39, 32);
            labelLosses.MinimumSize = new Size(39, 32);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(39, 32);
            labelLosses.TabIndex = 15;
            labelLosses.Text = "0";
            labelLosses.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelWins
            // 
            labelWins.AutoSize = true;
            labelWins.BackColor = Color.Black;
            labelWins.BorderStyle = BorderStyle.Fixed3D;
            labelWins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelWins.ForeColor = Color.FromArgb(46, 125, 50);
            labelWins.Location = new Point(563, 61);
            labelWins.MaximumSize = new Size(39, 32);
            labelWins.MinimumSize = new Size(39, 32);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(39, 32);
            labelWins.TabIndex = 14;
            labelWins.Text = "0";
            labelWins.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(635, 41);
            label14.Name = "label14";
            label14.Size = new Size(56, 21);
            label14.TabIndex = 13;
            label14.Text = "Losses";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(562, 41);
            label15.Name = "label15";
            label15.Size = new Size(45, 21);
            label15.TabIndex = 12;
            label15.Text = "Wins";
            // 
            // labelBowl
            // 
            labelBowl.AutoSize = true;
            labelBowl.BackColor = Color.Transparent;
            labelBowl.Location = new Point(563, 95);
            labelBowl.Name = "labelBowl";
            labelBowl.Size = new Size(51, 21);
            labelBowl.TabIndex = 17;
            labelBowl.Text = "Bowl: ";
            // 
            // labelWon
            // 
            labelWon.AutoSize = true;
            labelWon.BackColor = Color.Transparent;
            labelWon.Location = new Point(563, 116);
            labelWon.Name = "labelWon";
            labelWon.Size = new Size(42, 21);
            labelWon.TabIndex = 18;
            labelWon.Text = "Won";
            // 
            // labelCoachPos
            // 
            labelCoachPos.AutoSize = true;
            labelCoachPos.BackColor = Color.Transparent;
            labelCoachPos.Font = new Font("Segoe UI", 16F);
            labelCoachPos.Location = new Point(155, 109);
            labelCoachPos.Name = "labelCoachPos";
            labelCoachPos.Size = new Size(73, 30);
            labelCoachPos.TabIndex = 19;
            labelCoachPos.Text = "Coach";
            // 
            // YearCard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelCoachPos);
            Controls.Add(labelWon);
            Controls.Add(labelBowl);
            Controls.Add(label11);
            Controls.Add(labelLosses);
            Controls.Add(labelWins);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(labelFinalRanking);
            Controls.Add(labelOvr);
            Controls.Add(labelDef);
            Controls.Add(labelOff);
            Controls.Add(label1);
            Controls.Add(labelTeamName);
            Controls.Add(pictureBoxTeamLogo);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "YearCard";
            Size = new Size(783, 148);
            Load += YearCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeamLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTeamLogo;
        private Label labelTeamName;
        private Label label1;
        private Label labelOff;
        private Label labelDef;
        private Label labelOvr;
        private Label labelFinalRanking;
        private Label label11;
        private Label labelLosses;
        private Label labelWins;
        private Label label14;
        private Label label15;
        private Label labelBowl;
        private Label labelWon;
        private Label labelCoachPos;
    }
}
