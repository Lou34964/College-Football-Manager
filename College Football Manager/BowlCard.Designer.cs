namespace College_Football_Manager
{
    partial class BowlCard
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
            labelBowlName = new Label();
            pictureBoxLogo = new PictureBox();
            labelTeamName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelBowlName
            // 
            labelBowlName.Location = new Point(3, 15);
            labelBowlName.Name = "labelBowlName";
            labelBowlName.RightToLeft = RightToLeft.Yes;
            labelBowlName.Size = new Size(203, 21);
            labelBowlName.TabIndex = 0;
            labelBowlName.Text = "long bowl names suuck";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(212, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(45, 45);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTeamName
            // 
            labelTeamName.AutoSize = true;
            labelTeamName.Location = new Point(263, 15);
            labelTeamName.Name = "labelTeamName";
            labelTeamName.Size = new Size(173, 21);
            labelTeamName.TabIndex = 2;
            labelTeamName.Text = "long bowl names suuck";
            labelTeamName.Paint += labelTeamName_Paint;
            // 
            // BowlCard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(labelTeamName);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelBowlName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "BowlCard";
            Size = new Size(442, 56);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBowlName;
        private PictureBox pictureBoxLogo;
        private Label labelTeamName;
    }
}
