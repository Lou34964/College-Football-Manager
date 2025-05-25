namespace College_Football_Manager.MetaSettings
{
    partial class AddTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeam));
            textBoxTeamName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPrimaryColor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxSecondaryColor = new TextBox();
            comboBoxConference = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBoxFilename = new TextBox();
            ButtonSelectFile = new Button();
            buttonPrimaryColorSelect = new Button();
            buttonSecondaryColorSelect = new Button();
            colorDialog1 = new ColorDialog();
            buttonAdd = new Button();
            panelPrimaryColor = new Panel();
            panelSecondaryColor = new Panel();
            buttonCancel = new Button();
            checkBoxMultiTeam = new CheckBox();
            SuspendLayout();
            // 
            // textBoxTeamName
            // 
            textBoxTeamName.Location = new Point(244, 58);
            textBoxTeamName.Name = "textBoxTeamName";
            textBoxTeamName.Size = new Size(374, 26);
            textBoxTeamName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 61);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 93);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 3;
            label2.Text = "PrimaryColor:";
            // 
            // textBoxPrimaryColor
            // 
            textBoxPrimaryColor.Location = new Point(244, 90);
            textBoxPrimaryColor.Name = "textBoxPrimaryColor";
            textBoxPrimaryColor.Size = new Size(140, 26);
            textBoxPrimaryColor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 109);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "HEX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 125);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 6;
            label4.Text = "SecondaryColor:";
            // 
            // textBoxSecondaryColor
            // 
            textBoxSecondaryColor.Location = new Point(244, 122);
            textBoxSecondaryColor.Name = "textBoxSecondaryColor";
            textBoxSecondaryColor.Size = new Size(140, 26);
            textBoxSecondaryColor.TabIndex = 5;
            // 
            // comboBoxConference
            // 
            comboBoxConference.FormattingEnabled = true;
            comboBoxConference.Items.AddRange(new object[] { "Independent", "Cusa", "XII", "Mac", "Sunbelt", "American", "MWC", "SEC", "ACC", "B10", "Pac12" });
            comboBoxConference.Location = new Point(244, 154);
            comboBoxConference.Name = "comboBoxConference";
            comboBoxConference.Size = new Size(140, 28);
            comboBoxConference.TabIndex = 7;
            comboBoxConference.Text = "Independent";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 157);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 8;
            label5.Text = "Conference:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 191);
            label6.Name = "label6";
            label6.Size = new Size(173, 20);
            label6.TabIndex = 10;
            label6.Text = "Image Logo File Name:";
            // 
            // textBoxFilename
            // 
            textBoxFilename.Location = new Point(244, 188);
            textBoxFilename.Name = "textBoxFilename";
            textBoxFilename.Size = new Size(374, 26);
            textBoxFilename.TabIndex = 9;
            // 
            // ButtonSelectFile
            // 
            ButtonSelectFile.Location = new Point(624, 186);
            ButtonSelectFile.Name = "ButtonSelectFile";
            ButtonSelectFile.Size = new Size(89, 31);
            ButtonSelectFile.TabIndex = 11;
            ButtonSelectFile.Text = "Select";
            ButtonSelectFile.UseVisualStyleBackColor = true;
            ButtonSelectFile.Click += ButtonSelectFile_Click;
            // 
            // buttonPrimaryColorSelect
            // 
            buttonPrimaryColorSelect.Location = new Point(396, 93);
            buttonPrimaryColorSelect.Name = "buttonPrimaryColorSelect";
            buttonPrimaryColorSelect.Size = new Size(17, 20);
            buttonPrimaryColorSelect.TabIndex = 12;
            buttonPrimaryColorSelect.UseVisualStyleBackColor = true;
            buttonPrimaryColorSelect.Click += buttonPrimaryColorSelect_Click;
            // 
            // buttonSecondaryColorSelect
            // 
            buttonSecondaryColorSelect.Location = new Point(396, 125);
            buttonSecondaryColorSelect.Name = "buttonSecondaryColorSelect";
            buttonSecondaryColorSelect.Size = new Size(17, 20);
            buttonSecondaryColorSelect.TabIndex = 13;
            buttonSecondaryColorSelect.UseVisualStyleBackColor = true;
            buttonSecondaryColorSelect.Click += buttonSecondaryColorSelect_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(244, 259);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(130, 69);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelPrimaryColor
            // 
            panelPrimaryColor.Location = new Point(419, 98);
            panelPrimaryColor.Name = "panelPrimaryColor";
            panelPrimaryColor.Size = new Size(15, 15);
            panelPrimaryColor.TabIndex = 15;
            // 
            // panelSecondaryColor
            // 
            panelSecondaryColor.Location = new Point(419, 130);
            panelSecondaryColor.Name = "panelSecondaryColor";
            panelSecondaryColor.Size = new Size(15, 15);
            panelSecondaryColor.TabIndex = 16;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(488, 259);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(130, 69);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxMultiTeam
            // 
            checkBoxMultiTeam.AutoSize = true;
            checkBoxMultiTeam.Location = new Point(244, 345);
            checkBoxMultiTeam.Name = "checkBoxMultiTeam";
            checkBoxMultiTeam.Size = new Size(61, 24);
            checkBoxMultiTeam.TabIndex = 18;
            checkBoxMultiTeam.Text = "Multi";
            checkBoxMultiTeam.UseVisualStyleBackColor = true;
            // 
            // AddTeam
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(818, 415);
            Controls.Add(checkBoxMultiTeam);
            Controls.Add(buttonCancel);
            Controls.Add(panelSecondaryColor);
            Controls.Add(panelPrimaryColor);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSecondaryColorSelect);
            Controls.Add(buttonPrimaryColorSelect);
            Controls.Add(ButtonSelectFile);
            Controls.Add(label6);
            Controls.Add(textBoxFilename);
            Controls.Add(label5);
            Controls.Add(comboBoxConference);
            Controls.Add(label4);
            Controls.Add(textBoxSecondaryColor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPrimaryColor);
            Controls.Add(label1);
            Controls.Add(textBoxTeamName);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddTeam";
            Text = "AddTeam";
            Load += AddTeam_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrimaryColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSecondaryColor;
        private System.Windows.Forms.ComboBox comboBoxConference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Button ButtonSelectFile;
        private System.Windows.Forms.Button buttonPrimaryColorSelect;
        private System.Windows.Forms.Button buttonSecondaryColorSelect;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelPrimaryColor;
        private System.Windows.Forms.Panel panelSecondaryColor;
        private System.Windows.Forms.Button buttonCancel;
        private CheckBox checkBoxMultiTeam;
    }
}