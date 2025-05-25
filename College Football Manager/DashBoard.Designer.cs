using College_Football_Manager.MetaSettings;
using System.Windows.Forms;

namespace College_Football_Manager
{
    partial class DashBoard
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
            Application.Exit();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            yearToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBoxYears = new ToolStripComboBox();
            tabControlDashboard = new TabControl();
            tabPageGames = new TabPage();
            checkBoxBowlWon = new CheckBox();
            label3 = new Label();
            comboBoxTeamBowlPlayed = new ComboBox();
            label5 = new Label();
            labelLosses = new Label();
            labelWins = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonNewGame = new Button();
            flowLayoutPanelGameBar = new FlowLayoutPanel();
            tabPageConferences = new TabPage();
            listBox2 = new ListBox();
            buttonConferenceChampReset = new Button();
            label9 = new Label();
            comboBoxConferenceChampion = new ComboBox();
            buttonReset = new Button();
            buttonSave = new Button();
            listBoxStandings = new ListBox();
            comboBoxConferenceSelect = new ComboBox();
            flowLayoutPanelConferenceTeams = new FlowLayoutPanel();
            tabPageFinalRankings = new TabPage();
            buttonRankingsUndo = new Button();
            listBox1 = new ListBox();
            buttonExportList = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            numericUpDownDef = new NumericUpDown();
            numericUpDownOvr = new NumericUpDown();
            numericUpDownOff = new NumericUpDown();
            comboBoxMyEndRanking = new ComboBox();
            label4 = new Label();
            comboBoxRankings = new ComboBox();
            buttonResetRankings = new Button();
            buttonSaveRankings = new Button();
            listBoxRankings = new ListBox();
            flowLayoutPanelRankingsTeams = new FlowLayoutPanel();
            tabPageBowls = new TabPage();
            buttonBowlFullView = new Button();
            buttonBowlReset = new Button();
            flowLayoutPanelTeamButtonsBowls = new FlowLayoutPanel();
            comboBoxBowls = new ComboBox();
            tabPagePlayoff = new TabPage();
            buttonDeleteCFP = new Button();
            pictureBoxBracket = new PictureBox();
            buttonImportCFP = new Button();
            tabPageLegacy = new TabPage();
            label11 = new Label();
            labelLegacyLosses = new Label();
            labelLegacyWins = new Label();
            label14 = new Label();
            label15 = new Label();
            label10 = new Label();
            pictureBoxRefresh = new PictureBox();
            flowLayoutPanelLegacy = new FlowLayoutPanel();
            labelYear = new Label();
            labelTeam = new Label();
            comboBoxCoach = new ComboBox();
            menuStrip1.SuspendLayout();
            tabControlDashboard.SuspendLayout();
            tabPageGames.SuspendLayout();
            tabPageConferences.SuspendLayout();
            tabPageFinalRankings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOvr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOff).BeginInit();
            tabPageBowls.SuspendLayout();
            tabPagePlayoff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBracket).BeginInit();
            tabPageLegacy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, yearToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1875, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(62, 25);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(136, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(136, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // yearToolStripMenuItem
            // 
            yearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripComboBoxYears });
            yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            yearToolStripMenuItem.Size = new Size(52, 25);
            yearToolStripMenuItem.Text = "Year";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(181, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripComboBoxYears
            // 
            toolStripComboBoxYears.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripComboBoxYears.Name = "toolStripComboBoxYears";
            toolStripComboBoxYears.Size = new Size(121, 29);
            toolStripComboBoxYears.SelectedIndexChanged += toolStripComboBoxYears_SelectedIndexChanged;
            toolStripComboBoxYears.Click += toolStripComboBoxYears_Click;
            // 
            // tabControlDashboard
            // 
            tabControlDashboard.Controls.Add(tabPageGames);
            tabControlDashboard.Controls.Add(tabPageConferences);
            tabControlDashboard.Controls.Add(tabPageFinalRankings);
            tabControlDashboard.Controls.Add(tabPageBowls);
            tabControlDashboard.Controls.Add(tabPagePlayoff);
            tabControlDashboard.Controls.Add(tabPageLegacy);
            tabControlDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlDashboard.Location = new Point(12, 89);
            tabControlDashboard.Name = "tabControlDashboard";
            tabControlDashboard.SelectedIndex = 0;
            tabControlDashboard.Size = new Size(1851, 739);
            tabControlDashboard.TabIndex = 1;
            // 
            // tabPageGames
            // 
            tabPageGames.BackColor = Color.DarkGray;
            tabPageGames.Controls.Add(checkBoxBowlWon);
            tabPageGames.Controls.Add(label3);
            tabPageGames.Controls.Add(comboBoxTeamBowlPlayed);
            tabPageGames.Controls.Add(label5);
            tabPageGames.Controls.Add(labelLosses);
            tabPageGames.Controls.Add(labelWins);
            tabPageGames.Controls.Add(label2);
            tabPageGames.Controls.Add(label1);
            tabPageGames.Controls.Add(buttonNewGame);
            tabPageGames.Controls.Add(flowLayoutPanelGameBar);
            tabPageGames.Location = new Point(4, 30);
            tabPageGames.Name = "tabPageGames";
            tabPageGames.Padding = new Padding(3);
            tabPageGames.Size = new Size(1843, 705);
            tabPageGames.TabIndex = 0;
            tabPageGames.Text = "Games";
            // 
            // checkBoxBowlWon
            // 
            checkBoxBowlWon.AutoSize = true;
            checkBoxBowlWon.Location = new Point(897, 334);
            checkBoxBowlWon.Name = "checkBoxBowlWon";
            checkBoxBowlWon.Size = new Size(144, 25);
            checkBoxBowlWon.TabIndex = 9;
            checkBoxBowlWon.Text = "Won Bowl Game";
            checkBoxBowlWon.UseVisualStyleBackColor = true;
            checkBoxBowlWon.CheckedChanged += checkBoxBowlWon_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(897, 275);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 8;
            label3.Text = "Bowl";
            // 
            // comboBoxTeamBowlPlayed
            // 
            comboBoxTeamBowlPlayed.FormattingEnabled = true;
            comboBoxTeamBowlPlayed.Location = new Point(897, 299);
            comboBoxTeamBowlPlayed.Name = "comboBoxTeamBowlPlayed";
            comboBoxTeamBowlPlayed.Size = new Size(235, 29);
            comboBoxTeamBowlPlayed.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(988, 43);
            label5.Name = "label5";
            label5.Size = new Size(21, 30);
            label5.TabIndex = 6;
            label5.Text = "-";
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.BackColor = Color.Black;
            labelLosses.BorderStyle = BorderStyle.Fixed3D;
            labelLosses.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelLosses.ForeColor = Color.Red;
            labelLosses.Location = new Point(1018, 41);
            labelLosses.MaximumSize = new Size(39, 32);
            labelLosses.MinimumSize = new Size(39, 32);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(39, 32);
            labelLosses.TabIndex = 5;
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
            labelWins.Location = new Point(938, 41);
            labelWins.MaximumSize = new Size(39, 32);
            labelWins.MinimumSize = new Size(39, 32);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(39, 32);
            labelWins.TabIndex = 4;
            labelWins.Text = "0";
            labelWins.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1010, 21);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 3;
            label2.Text = "Losses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(937, 21);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 2;
            label1.Text = "Wins";
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(657, 17);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(102, 34);
            buttonNewGame.TabIndex = 1;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // flowLayoutPanelGameBar
            // 
            flowLayoutPanelGameBar.AutoScroll = true;
            flowLayoutPanelGameBar.BackColor = Color.Silver;
            flowLayoutPanelGameBar.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanelGameBar.Location = new Point(27, 17);
            flowLayoutPanelGameBar.Name = "flowLayoutPanelGameBar";
            flowLayoutPanelGameBar.Padding = new Padding(3);
            flowLayoutPanelGameBar.Size = new Size(624, 581);
            flowLayoutPanelGameBar.TabIndex = 0;
            // 
            // tabPageConferences
            // 
            tabPageConferences.BackColor = Color.DarkGray;
            tabPageConferences.Controls.Add(listBox2);
            tabPageConferences.Controls.Add(buttonConferenceChampReset);
            tabPageConferences.Controls.Add(label9);
            tabPageConferences.Controls.Add(comboBoxConferenceChampion);
            tabPageConferences.Controls.Add(buttonReset);
            tabPageConferences.Controls.Add(buttonSave);
            tabPageConferences.Controls.Add(listBoxStandings);
            tabPageConferences.Controls.Add(comboBoxConferenceSelect);
            tabPageConferences.Controls.Add(flowLayoutPanelConferenceTeams);
            tabPageConferences.Location = new Point(4, 30);
            tabPageConferences.Name = "tabPageConferences";
            tabPageConferences.Padding = new Padding(3);
            tabPageConferences.Size = new Size(1843, 705);
            tabPageConferences.TabIndex = 1;
            tabPageConferences.Text = "Conference Standings";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.DarkGray;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Segoe UI", 12F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            listBox2.Location = new Point(929, 82);
            listBox2.Name = "listBox2";
            listBox2.RightToLeft = RightToLeft.Yes;
            listBox2.Size = new Size(23, 525);
            listBox2.TabIndex = 21;
            // 
            // buttonConferenceChampReset
            // 
            buttonConferenceChampReset.Location = new Point(1497, 84);
            buttonConferenceChampReset.Name = "buttonConferenceChampReset";
            buttonConferenceChampReset.Size = new Size(21, 23);
            buttonConferenceChampReset.TabIndex = 7;
            buttonConferenceChampReset.UseVisualStyleBackColor = true;
            buttonConferenceChampReset.Click += buttonConferenceChampReset_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1275, 58);
            label9.Name = "label9";
            label9.Size = new Size(85, 21);
            label9.TabIndex = 6;
            label9.Text = "Champion:";
            // 
            // comboBoxConferenceChampion
            // 
            comboBoxConferenceChampion.FormattingEnabled = true;
            comboBoxConferenceChampion.Items.AddRange(new object[] { "Independent", "Cusa", "XII", "Mac", "Sunbelt", "American", "MWC", "SEC", "ACC", "B10", "Pac12" });
            comboBoxConferenceChampion.Location = new Point(1275, 82);
            comboBoxConferenceChampion.Name = "comboBoxConferenceChampion";
            comboBoxConferenceChampion.Size = new Size(216, 29);
            comboBoxConferenceChampion.TabIndex = 5;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(1275, 637);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(92, 37);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1049, 39);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(92, 37);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // listBoxStandings
            // 
            listBoxStandings.BackColor = Color.DarkGray;
            listBoxStandings.Enabled = false;
            listBoxStandings.FormattingEnabled = true;
            listBoxStandings.ItemHeight = 21;
            listBoxStandings.Location = new Point(958, 82);
            listBoxStandings.Name = "listBoxStandings";
            listBoxStandings.Size = new Size(311, 592);
            listBoxStandings.TabIndex = 2;
            // 
            // comboBoxConferenceSelect
            // 
            comboBoxConferenceSelect.FormattingEnabled = true;
            comboBoxConferenceSelect.Items.AddRange(new object[] { "ACC", "American", "XII", "B10", "Cusa", "Independent", "Mac", "MWC", "Pac12", "SEC", "Sunbelt" });
            comboBoxConferenceSelect.Location = new Point(6, 19);
            comboBoxConferenceSelect.Name = "comboBoxConferenceSelect";
            comboBoxConferenceSelect.Size = new Size(216, 29);
            comboBoxConferenceSelect.TabIndex = 1;
            comboBoxConferenceSelect.SelectedIndexChanged += comboBoxConferenceSelect_SelectedIndexChanged;
            // 
            // flowLayoutPanelConferenceTeams
            // 
            flowLayoutPanelConferenceTeams.Location = new Point(6, 82);
            flowLayoutPanelConferenceTeams.Name = "flowLayoutPanelConferenceTeams";
            flowLayoutPanelConferenceTeams.Padding = new Padding(3);
            flowLayoutPanelConferenceTeams.Size = new Size(917, 607);
            flowLayoutPanelConferenceTeams.TabIndex = 0;
            // 
            // tabPageFinalRankings
            // 
            tabPageFinalRankings.BackColor = Color.DarkGray;
            tabPageFinalRankings.Controls.Add(buttonRankingsUndo);
            tabPageFinalRankings.Controls.Add(listBox1);
            tabPageFinalRankings.Controls.Add(buttonExportList);
            tabPageFinalRankings.Controls.Add(label8);
            tabPageFinalRankings.Controls.Add(label7);
            tabPageFinalRankings.Controls.Add(label6);
            tabPageFinalRankings.Controls.Add(numericUpDownDef);
            tabPageFinalRankings.Controls.Add(numericUpDownOvr);
            tabPageFinalRankings.Controls.Add(numericUpDownOff);
            tabPageFinalRankings.Controls.Add(comboBoxMyEndRanking);
            tabPageFinalRankings.Controls.Add(label4);
            tabPageFinalRankings.Controls.Add(comboBoxRankings);
            tabPageFinalRankings.Controls.Add(buttonResetRankings);
            tabPageFinalRankings.Controls.Add(buttonSaveRankings);
            tabPageFinalRankings.Controls.Add(listBoxRankings);
            tabPageFinalRankings.Controls.Add(flowLayoutPanelRankingsTeams);
            tabPageFinalRankings.Location = new Point(4, 30);
            tabPageFinalRankings.Name = "tabPageFinalRankings";
            tabPageFinalRankings.Padding = new Padding(3);
            tabPageFinalRankings.Size = new Size(1843, 705);
            tabPageFinalRankings.TabIndex = 2;
            tabPageFinalRankings.Text = "Rankings";
            tabPageFinalRankings.Click += tabPage1_Click;
            // 
            // buttonRankingsUndo
            // 
            buttonRankingsUndo.Location = new Point(1275, 564);
            buttonRankingsUndo.Name = "buttonRankingsUndo";
            buttonRankingsUndo.Size = new Size(92, 37);
            buttonRankingsUndo.TabIndex = 22;
            buttonRankingsUndo.Text = "Undo";
            buttonRankingsUndo.UseVisualStyleBackColor = true;
            buttonRankingsUndo.Click += buttonRankingsUndo_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkGray;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            listBox1.Location = new Point(929, 52);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(23, 525);
            listBox1.TabIndex = 20;
            // 
            // buttonExportList
            // 
            buttonExportList.Location = new Point(1286, 348);
            buttonExportList.Name = "buttonExportList";
            buttonExportList.Size = new Size(99, 49);
            buttonExportList.TabIndex = 19;
            buttonExportList.Text = "Export List";
            buttonExportList.UseVisualStyleBackColor = true;
            buttonExportList.Click += buttonExportList_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1328, 159);
            label8.Name = "label8";
            label8.Size = new Size(39, 21);
            label8.TabIndex = 18;
            label8.Text = "Ovr:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1330, 124);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 17;
            label7.Text = "Def:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1332, 89);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 16;
            label6.Text = "Off:";
            // 
            // numericUpDownDef
            // 
            numericUpDownDef.Location = new Point(1373, 122);
            numericUpDownDef.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownDef.Name = "numericUpDownDef";
            numericUpDownDef.Size = new Size(121, 29);
            numericUpDownDef.TabIndex = 15;
            // 
            // numericUpDownOvr
            // 
            numericUpDownOvr.Location = new Point(1373, 157);
            numericUpDownOvr.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownOvr.Name = "numericUpDownOvr";
            numericUpDownOvr.Size = new Size(121, 29);
            numericUpDownOvr.TabIndex = 14;
            // 
            // numericUpDownOff
            // 
            numericUpDownOff.Location = new Point(1373, 87);
            numericUpDownOff.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownOff.Name = "numericUpDownOff";
            numericUpDownOff.Size = new Size(121, 29);
            numericUpDownOff.TabIndex = 13;
            // 
            // comboBoxMyEndRanking
            // 
            comboBoxMyEndRanking.FormattingEnabled = true;
            comboBoxMyEndRanking.Items.AddRange(new object[] { "None", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            comboBoxMyEndRanking.Location = new Point(1373, 52);
            comboBoxMyEndRanking.Name = "comboBoxMyEndRanking";
            comboBoxMyEndRanking.Size = new Size(121, 29);
            comboBoxMyEndRanking.TabIndex = 12;
            comboBoxMyEndRanking.SelectedIndexChanged += comboBoxMyEndRanking_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1278, 54);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 11;
            label4.Text = "MyRanking";
            // 
            // comboBoxRankings
            // 
            comboBoxRankings.FormattingEnabled = true;
            comboBoxRankings.Items.AddRange(new object[] { "AP", "Coaches", "CPF" });
            comboBoxRankings.Location = new Point(6, 17);
            comboBoxRankings.Name = "comboBoxRankings";
            comboBoxRankings.Size = new Size(201, 29);
            comboBoxRankings.TabIndex = 9;
            comboBoxRankings.SelectedIndexChanged += comboBoxRankings_SelectedIndexChanged;
            // 
            // buttonResetRankings
            // 
            buttonResetRankings.Location = new Point(1275, 607);
            buttonResetRankings.Name = "buttonResetRankings";
            buttonResetRankings.Size = new Size(92, 37);
            buttonResetRankings.TabIndex = 8;
            buttonResetRankings.Text = "Reset";
            buttonResetRankings.UseVisualStyleBackColor = true;
            buttonResetRankings.Click += buttonResetRankings_Click;
            // 
            // buttonSaveRankings
            // 
            buttonSaveRankings.Location = new Point(1049, 9);
            buttonSaveRankings.Name = "buttonSaveRankings";
            buttonSaveRankings.Size = new Size(92, 37);
            buttonSaveRankings.TabIndex = 7;
            buttonSaveRankings.Text = "Save";
            buttonSaveRankings.UseVisualStyleBackColor = true;
            buttonSaveRankings.Click += buttonSaveRankings_Click;
            // 
            // listBoxRankings
            // 
            listBoxRankings.BackColor = Color.DarkGray;
            listBoxRankings.Enabled = false;
            listBoxRankings.FormattingEnabled = true;
            listBoxRankings.ItemHeight = 21;
            listBoxRankings.Location = new Point(958, 52);
            listBoxRankings.Name = "listBoxRankings";
            listBoxRankings.Size = new Size(311, 592);
            listBoxRankings.TabIndex = 6;
            // 
            // flowLayoutPanelRankingsTeams
            // 
            flowLayoutPanelRankingsTeams.AutoScroll = true;
            flowLayoutPanelRankingsTeams.Location = new Point(6, 52);
            flowLayoutPanelRankingsTeams.Name = "flowLayoutPanelRankingsTeams";
            flowLayoutPanelRankingsTeams.Padding = new Padding(3);
            flowLayoutPanelRankingsTeams.Size = new Size(917, 607);
            flowLayoutPanelRankingsTeams.TabIndex = 5;
            // 
            // tabPageBowls
            // 
            tabPageBowls.BackColor = Color.DarkGray;
            tabPageBowls.Controls.Add(buttonBowlFullView);
            tabPageBowls.Controls.Add(buttonBowlReset);
            tabPageBowls.Controls.Add(flowLayoutPanelTeamButtonsBowls);
            tabPageBowls.Controls.Add(comboBoxBowls);
            tabPageBowls.Location = new Point(4, 30);
            tabPageBowls.Name = "tabPageBowls";
            tabPageBowls.Padding = new Padding(3);
            tabPageBowls.Size = new Size(1843, 705);
            tabPageBowls.TabIndex = 3;
            tabPageBowls.Text = "Bowls";
            // 
            // buttonBowlFullView
            // 
            buttonBowlFullView.Location = new Point(1752, 10);
            buttonBowlFullView.Name = "buttonBowlFullView";
            buttonBowlFullView.Size = new Size(85, 28);
            buttonBowlFullView.TabIndex = 3;
            buttonBowlFullView.Text = "Full View";
            buttonBowlFullView.UseVisualStyleBackColor = true;
            buttonBowlFullView.Click += buttonBowlFullView_Click;
            // 
            // buttonBowlReset
            // 
            buttonBowlReset.Location = new Point(227, 7);
            buttonBowlReset.Name = "buttonBowlReset";
            buttonBowlReset.Size = new Size(85, 28);
            buttonBowlReset.TabIndex = 2;
            buttonBowlReset.Text = "Reset";
            buttonBowlReset.UseVisualStyleBackColor = true;
            buttonBowlReset.Click += buttonBowlReset_Click;
            // 
            // flowLayoutPanelTeamButtonsBowls
            // 
            flowLayoutPanelTeamButtonsBowls.Location = new Point(6, 44);
            flowLayoutPanelTeamButtonsBowls.Name = "flowLayoutPanelTeamButtonsBowls";
            flowLayoutPanelTeamButtonsBowls.Size = new Size(1831, 645);
            flowLayoutPanelTeamButtonsBowls.TabIndex = 1;
            // 
            // comboBoxBowls
            // 
            comboBoxBowls.FormattingEnabled = true;
            comboBoxBowls.Location = new Point(6, 6);
            comboBoxBowls.Name = "comboBoxBowls";
            comboBoxBowls.Size = new Size(215, 29);
            comboBoxBowls.TabIndex = 0;
            // 
            // tabPagePlayoff
            // 
            tabPagePlayoff.BackColor = Color.FromArgb(64, 64, 64);
            tabPagePlayoff.Controls.Add(buttonDeleteCFP);
            tabPagePlayoff.Controls.Add(pictureBoxBracket);
            tabPagePlayoff.Controls.Add(buttonImportCFP);
            tabPagePlayoff.Location = new Point(4, 30);
            tabPagePlayoff.Name = "tabPagePlayoff";
            tabPagePlayoff.Padding = new Padding(3);
            tabPagePlayoff.Size = new Size(1843, 705);
            tabPagePlayoff.TabIndex = 4;
            tabPagePlayoff.Text = "Playoff";
            // 
            // buttonDeleteCFP
            // 
            buttonDeleteCFP.Location = new Point(1753, 15);
            buttonDeleteCFP.Name = "buttonDeleteCFP";
            buttonDeleteCFP.Size = new Size(75, 29);
            buttonDeleteCFP.TabIndex = 2;
            buttonDeleteCFP.Text = "Delete";
            buttonDeleteCFP.UseVisualStyleBackColor = true;
            buttonDeleteCFP.Click += buttonDeleteCFP_Click;
            // 
            // pictureBoxBracket
            // 
            pictureBoxBracket.AllowDrop = true;
            pictureBoxBracket.Location = new Point(10, 50);
            pictureBoxBracket.Name = "pictureBoxBracket";
            pictureBoxBracket.Size = new Size(1818, 642);
            pictureBoxBracket.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBracket.TabIndex = 1;
            pictureBoxBracket.TabStop = false;
            pictureBoxBracket.DragDrop += pictureBoxBracket_DragDrop;
            pictureBoxBracket.DragEnter += pictureBoxBracket_DragEnter;
            // 
            // buttonImportCFP
            // 
            buttonImportCFP.Location = new Point(9, 8);
            buttonImportCFP.Name = "buttonImportCFP";
            buttonImportCFP.Size = new Size(75, 29);
            buttonImportCFP.TabIndex = 0;
            buttonImportCFP.Text = "Import";
            buttonImportCFP.UseVisualStyleBackColor = true;
            buttonImportCFP.Click += buttonImportCFP_Click;
            // 
            // tabPageLegacy
            // 
            tabPageLegacy.BackColor = Color.DarkGray;
            tabPageLegacy.Controls.Add(label11);
            tabPageLegacy.Controls.Add(labelLegacyLosses);
            tabPageLegacy.Controls.Add(labelLegacyWins);
            tabPageLegacy.Controls.Add(label14);
            tabPageLegacy.Controls.Add(label15);
            tabPageLegacy.Controls.Add(label10);
            tabPageLegacy.Controls.Add(pictureBoxRefresh);
            tabPageLegacy.Controls.Add(flowLayoutPanelLegacy);
            tabPageLegacy.Location = new Point(4, 30);
            tabPageLegacy.Name = "tabPageLegacy";
            tabPageLegacy.Padding = new Padding(3);
            tabPageLegacy.Size = new Size(1843, 705);
            tabPageLegacy.TabIndex = 5;
            tabPageLegacy.Text = "Legacy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1020, 197);
            label11.Name = "label11";
            label11.Size = new Size(21, 30);
            label11.TabIndex = 11;
            label11.Text = "-";
            // 
            // labelLegacyLosses
            // 
            labelLegacyLosses.AutoSize = true;
            labelLegacyLosses.BackColor = Color.Black;
            labelLegacyLosses.BorderStyle = BorderStyle.Fixed3D;
            labelLegacyLosses.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelLegacyLosses.ForeColor = Color.Red;
            labelLegacyLosses.Location = new Point(1050, 195);
            labelLegacyLosses.MaximumSize = new Size(70, 32);
            labelLegacyLosses.MinimumSize = new Size(70, 32);
            labelLegacyLosses.Name = "labelLegacyLosses";
            labelLegacyLosses.Size = new Size(70, 32);
            labelLegacyLosses.TabIndex = 10;
            labelLegacyLosses.Text = "0";
            labelLegacyLosses.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLegacyWins
            // 
            labelLegacyWins.AutoSize = true;
            labelLegacyWins.BackColor = Color.Black;
            labelLegacyWins.BorderStyle = BorderStyle.Fixed3D;
            labelLegacyWins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelLegacyWins.ForeColor = Color.FromArgb(46, 125, 50);
            labelLegacyWins.Location = new Point(938, 195);
            labelLegacyWins.MaximumSize = new Size(70, 32);
            labelLegacyWins.MinimumSize = new Size(70, 32);
            labelLegacyWins.Name = "labelLegacyWins";
            labelLegacyWins.Size = new Size(70, 32);
            labelLegacyWins.TabIndex = 9;
            labelLegacyWins.Text = "0";
            labelLegacyWins.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1058, 175);
            label14.Name = "label14";
            label14.Size = new Size(56, 21);
            label14.TabIndex = 8;
            label14.Text = "Losses";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(952, 175);
            label15.Name = "label15";
            label15.Size = new Size(45, 21);
            label15.TabIndex = 7;
            label15.Text = "Wins";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 25F);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(6, 14);
            label10.Name = "label10";
            label10.Size = new Size(179, 46);
            label10.TabIndex = 2;
            label10.Text = "My Legacy";
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Image = Properties.Resources.Refresh;
            pictureBoxRefresh.Location = new Point(834, 52);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(30, 30);
            pictureBoxRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRefresh.TabIndex = 1;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // flowLayoutPanelLegacy
            // 
            flowLayoutPanelLegacy.AutoScroll = true;
            flowLayoutPanelLegacy.Location = new Point(6, 84);
            flowLayoutPanelLegacy.Name = "flowLayoutPanelLegacy";
            flowLayoutPanelLegacy.Padding = new Padding(3);
            flowLayoutPanelLegacy.Size = new Size(858, 615);
            flowLayoutPanelLegacy.TabIndex = 0;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelYear.ForeColor = Color.White;
            labelYear.Location = new Point(838, 42);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(64, 30);
            labelYear.TabIndex = 2;
            labelYear.Text = "{Year}";
            // 
            // labelTeam
            // 
            labelTeam.AutoSize = true;
            labelTeam.BackColor = SystemColors.ControlDarkDark;
            labelTeam.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTeam.Location = new Point(12, 42);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new Size(74, 30);
            labelTeam.TabIndex = 3;
            labelTeam.Text = "{Team}";
            labelTeam.Paint += labelTeam_Paint;
            // 
            // comboBoxCoach
            // 
            comboBoxCoach.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCoach.FormattingEnabled = true;
            comboBoxCoach.Items.AddRange(new object[] { "HC", "OC", "DC" });
            comboBoxCoach.Location = new Point(1738, 45);
            comboBoxCoach.Name = "comboBoxCoach";
            comboBoxCoach.Size = new Size(59, 38);
            comboBoxCoach.TabIndex = 4;
            comboBoxCoach.SelectedIndexChanged += comboBoxCoach_SelectedIndexChanged;
            // 
            // DashBoard
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1875, 840);
            Controls.Add(comboBoxCoach);
            Controls.Add(labelTeam);
            Controls.Add(labelYear);
            Controls.Add(tabControlDashboard);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1891, 879);
            MinimumSize = new Size(1891, 879);
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlDashboard.ResumeLayout(false);
            tabPageGames.ResumeLayout(false);
            tabPageGames.PerformLayout();
            tabPageConferences.ResumeLayout(false);
            tabPageConferences.PerformLayout();
            tabPageFinalRankings.ResumeLayout(false);
            tabPageFinalRankings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOvr).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOff).EndInit();
            tabPageBowls.ResumeLayout(false);
            tabPagePlayoff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBracket).EndInit();
            tabPageLegacy.ResumeLayout(false);
            tabPageLegacy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem yearToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripComboBox toolStripComboBoxYears;
        private TabControl tabControlDashboard;
        private TabPage tabPageGames;
        private TabPage tabPageConferences;
        private Label labelYear;
        private Label labelTeam;
        private ComboBox comboBoxConferenceSelect;
        private FlowLayoutPanel flowLayoutPanelConferenceTeams;
        private Button buttonReset;
        private Button buttonSave;
        private ListBox listBoxStandings;
        private FlowLayoutPanel flowLayoutPanelGameBar;
        private Button buttonNewGame;
        private TabPage tabPageFinalRankings;
        private ComboBox comboBoxRankings;
        private Button buttonResetRankings;
        private Button buttonSaveRankings;
        private ListBox listBoxRankings;
        private FlowLayoutPanel flowLayoutPanelRankingsTeams;
        private Label labelLosses;
        private Label labelWins;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox comboBoxTeamBowlPlayed;
        private CheckBox checkBoxBowlWon;
        private Label label3;
        private ComboBox comboBoxMyEndRanking;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private NumericUpDown numericUpDownDef;
        private NumericUpDown numericUpDownOvr;
        private NumericUpDown numericUpDownOff;
        private TabPage tabPageBowls;
        private Button buttonBowlReset;
        private FlowLayoutPanel flowLayoutPanelTeamButtonsBowls;
        private ComboBox comboBoxBowls;
        private Label label9;
        private ComboBox comboBoxConferenceChampion;
        private Button buttonConferenceChampReset;
        private TabPage tabPagePlayoff;
        private Button buttonImportCFP;
        private Button buttonDeleteCFP;
        private PictureBox pictureBoxBracket;
        private Button buttonBowlFullView;
        private Button buttonExportList;
        private ListBox listBox1;
        private ListBox listBox2;
        private TabPage tabPageLegacy;
        private FlowLayoutPanel flowLayoutPanelLegacy;
        private PictureBox pictureBoxRefresh;
        private Label label10;
        private Label label11;
        private Label labelLegacyLosses;
        private Label labelLegacyWins;
        private Label label14;
        private Label label15;
        private Button buttonRankingsUndo;
        private ComboBox comboBoxCoach;
    }
}