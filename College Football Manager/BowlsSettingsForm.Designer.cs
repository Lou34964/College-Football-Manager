namespace College_Football_Manager
{
    partial class BowlsSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BowlsSettingsForm));
            listBox1 = new ListBox();
            buttonAdd = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(543, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(313, 655);
            listBox1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(151, 205);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(117, 52);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 29);
            textBox1.TabIndex = 2;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 146);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 3;
            label1.Text = "Bowl Name";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(432, 621);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(102, 46);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // BowlsSettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(868, 690);
            Controls.Add(buttonRemove);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonAdd);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "BowlsSettingsForm";
            Text = "BowlsSettingsForm";
            Load += BowlsSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonAdd;
        private TextBox textBox1;
        private Label label1;
        private Button buttonRemove;
    }
}