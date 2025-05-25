namespace College_Football_Manager.MetaSettings
{
    partial class TeamsSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsSettingsForm));
            buttonAdd = new Button();
            buttonRemove = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            pictureBoxTeamSelected = new PictureBox();
            button1 = new Button();
            pictureBoxConference = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeamSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConference).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(14, 794);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 27);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(303, 794);
            buttonRemove.Margin = new Padding(4, 3, 4, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(88, 27);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(14, 14);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 772);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(398, 293);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 187);
            textBox1.TabIndex = 4;
            // 
            // pictureBoxTeamSelected
            // 
            pictureBoxTeamSelected.Location = new Point(488, 488);
            pictureBoxTeamSelected.Margin = new Padding(4, 3, 4, 3);
            pictureBoxTeamSelected.Name = "pictureBoxTeamSelected";
            pictureBoxTeamSelected.Size = new Size(175, 173);
            pictureBoxTeamSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeamSelected.TabIndex = 5;
            pictureBoxTeamSelected.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(156, 794);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 6;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBoxConference
            // 
            pictureBoxConference.Location = new Point(526, 667);
            pictureBoxConference.Margin = new Padding(4, 3, 4, 3);
            pictureBoxConference.Name = "pictureBoxConference";
            pictureBoxConference.Size = new Size(100, 100);
            pictureBoxConference.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxConference.TabIndex = 7;
            pictureBoxConference.TabStop = false;
            // 
            // TeamsSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(778, 868);
            Controls.Add(pictureBoxConference);
            Controls.Add(button1);
            Controls.Add(pictureBoxTeamSelected);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TeamsSettingsForm";
            Text = "TeamsSettingsForm";
            Load += TeamsSettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeamSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConference).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBoxTeamSelected;
        private System.Windows.Forms.Button button1;
        private PictureBox pictureBoxConference;
    }
}