namespace College_Football_Manager.MetaSettings
{
    partial class SettingsMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMain));
            buttonTeams = new Button();
            buttonSetMyTeam = new Button();
            buttonBowls = new Button();
            SuspendLayout();
            // 
            // buttonTeams
            // 
            buttonTeams.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTeams.Location = new Point(154, 54);
            buttonTeams.Margin = new Padding(4, 3, 4, 3);
            buttonTeams.Name = "buttonTeams";
            buttonTeams.Size = new Size(187, 59);
            buttonTeams.TabIndex = 0;
            buttonTeams.Text = "Teams";
            buttonTeams.UseVisualStyleBackColor = true;
            buttonTeams.Click += buttonTeams_Click;
            // 
            // buttonSetMyTeam
            // 
            buttonSetMyTeam.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSetMyTeam.Location = new Point(154, 119);
            buttonSetMyTeam.Margin = new Padding(4, 3, 4, 3);
            buttonSetMyTeam.Name = "buttonSetMyTeam";
            buttonSetMyTeam.Size = new Size(187, 59);
            buttonSetMyTeam.TabIndex = 1;
            buttonSetMyTeam.Text = "Set My Team";
            buttonSetMyTeam.UseVisualStyleBackColor = true;
            buttonSetMyTeam.Click += buttonSetMyTeam_Click;
            // 
            // buttonBowls
            // 
            buttonBowls.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBowls.Location = new Point(154, 184);
            buttonBowls.Margin = new Padding(4, 3, 4, 3);
            buttonBowls.Name = "buttonBowls";
            buttonBowls.Size = new Size(187, 59);
            buttonBowls.TabIndex = 2;
            buttonBowls.Text = "Bowls";
            buttonBowls.UseVisualStyleBackColor = true;
            buttonBowls.Click += buttonBowls_Click;
            // 
            // SettingsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(522, 837);
            Controls.Add(buttonBowls);
            Controls.Add(buttonSetMyTeam);
            Controls.Add(buttonTeams);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "SettingsMain";
            Text = "SettingsMain";
            Load += SettingsMain_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTeams;
        private Button buttonSetMyTeam;
        private Button buttonBowls;
    }
}