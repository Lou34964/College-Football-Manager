namespace College_Football_Manager.Popups
{
    partial class SelectUserTeam
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
            comboBox1 = new ComboBox();
            buttonSelect = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 29);
            comboBox1.TabIndex = 0;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(12, 47);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(340, 33);
            buttonSelect.TabIndex = 1;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 86);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(340, 33);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // SelectUserTeam
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(364, 133);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSelect);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SelectUserTeam";
            Text = "SelectUserTeam";
            Load += SelectUserTeam_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button buttonSelect;
        private Button buttonCancel;
    }
}