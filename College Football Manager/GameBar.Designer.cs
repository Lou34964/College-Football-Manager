namespace College_Football_Manager
{
    partial class GameBar
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
            textBoxMyScore = new TextBox();
            pictureBoxMyTeam = new PictureBox();
            comboBoxLocation = new ComboBox();
            pictureBoxOpponent = new PictureBox();
            textBoxOpponentScore = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxOpponent = new ComboBox();
            textBoxOpponentRank = new TextBox();
            textBoxMyRank = new TextBox();
            buttonSave = new Button();
            buttonDelete = new Button();
            textBoxName = new TextBox();
            labelWL = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMyTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpponent).BeginInit();
            SuspendLayout();
            // 
            // textBoxMyScore
            // 
            textBoxMyScore.Location = new Point(127, 32);
            textBoxMyScore.Name = "textBoxMyScore";
            textBoxMyScore.Size = new Size(56, 29);
            textBoxMyScore.TabIndex = 0;
            textBoxMyScore.Enter += textBoxMyScore_Enter;
            textBoxMyScore.Leave += textBoxMyScore_Leave;
            // 
            // pictureBoxMyTeam
            // 
            pictureBoxMyTeam.Location = new Point(55, 12);
            pictureBoxMyTeam.Name = "pictureBoxMyTeam";
            pictureBoxMyTeam.Size = new Size(66, 62);
            pictureBoxMyTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMyTeam.TabIndex = 1;
            pictureBoxMyTeam.TabStop = false;
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Items.AddRange(new object[] { "VS", "AT", "N" });
            comboBoxLocation.Location = new Point(189, 32);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(52, 29);
            comboBoxLocation.TabIndex = 2;
            // 
            // pictureBoxOpponent
            // 
            pictureBoxOpponent.Location = new Point(309, 12);
            pictureBoxOpponent.Name = "pictureBoxOpponent";
            pictureBoxOpponent.Size = new Size(66, 62);
            pictureBoxOpponent.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOpponent.TabIndex = 4;
            pictureBoxOpponent.TabStop = false;
            // 
            // textBoxOpponentScore
            // 
            textBoxOpponentScore.Location = new Point(247, 32);
            textBoxOpponentScore.Name = "textBoxOpponentScore";
            textBoxOpponentScore.Size = new Size(56, 29);
            textBoxOpponentScore.TabIndex = 3;
            textBoxOpponentScore.Enter += textBoxMyScore_Enter;
            textBoxOpponentScore.Leave += textBoxMyScore_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 14);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 5;
            label1.Text = "Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 14);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Score";
            // 
            // comboBoxOpponent
            // 
            comboBoxOpponent.FormattingEnabled = true;
            comboBoxOpponent.Location = new Point(381, 45);
            comboBoxOpponent.Name = "comboBoxOpponent";
            comboBoxOpponent.Size = new Size(187, 29);
            comboBoxOpponent.TabIndex = 7;
            comboBoxOpponent.SelectedIndexChanged += comboBoxOpponent_SelectedIndexChanged;
            // 
            // textBoxOpponentRank
            // 
            textBoxOpponentRank.Location = new Point(381, 10);
            textBoxOpponentRank.Name = "textBoxOpponentRank";
            textBoxOpponentRank.Size = new Size(43, 29);
            textBoxOpponentRank.TabIndex = 9;
            // 
            // textBoxMyRank
            // 
            textBoxMyRank.Location = new Point(6, 10);
            textBoxMyRank.Name = "textBoxMyRank";
            textBoxMyRank.Size = new Size(43, 29);
            textBoxMyRank.TabIndex = 10;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(430, 7);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(51, 32);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(487, 7);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(81, 32);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(127, 67);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(176, 29);
            textBoxName.TabIndex = 13;
            // 
            // labelWL
            // 
            labelWL.AutoSize = true;
            labelWL.BackColor = Color.Black;
            labelWL.BorderStyle = BorderStyle.Fixed3D;
            labelWL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWL.Location = new Point(6, 70);
            labelWL.MaximumSize = new Size(28, 23);
            labelWL.MinimumSize = new Size(28, 23);
            labelWL.Name = "labelWL";
            labelWL.Size = new Size(28, 23);
            labelWL.TabIndex = 14;
            // 
            // GameBar
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelWL);
            Controls.Add(textBoxName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(textBoxMyRank);
            Controls.Add(textBoxOpponentRank);
            Controls.Add(comboBoxOpponent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxOpponent);
            Controls.Add(textBoxOpponentScore);
            Controls.Add(comboBoxLocation);
            Controls.Add(pictureBoxMyTeam);
            Controls.Add(textBoxMyScore);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "GameBar";
            Size = new Size(580, 104);
            Load += GameBar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMyTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpponent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMyScore;
        private PictureBox pictureBoxMyTeam;
        private ComboBox comboBoxLocation;
        private PictureBox pictureBoxOpponent;
        private TextBox textBoxOpponentScore;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxOpponent;
        private TextBox textBoxOpponentRank;
        private TextBox textBoxMyRank;
        private Button buttonSave;
        private Button buttonDelete;
        private TextBox textBoxName;
        private Label labelWL;
    }
}
