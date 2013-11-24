namespace moving_text_game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMove = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextScoreTick = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timeCount = new System.Windows.Forms.Label();
            this.timerCountUp = new System.Windows.Forms.Timer(this.components);
            this.gameStarted = new System.Windows.Forms.Label();
            this.gameStartCheck = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impossibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChanglogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.movment = new System.Windows.Forms.Timer(this.components);
            this.rand = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Label();
            this.currentNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSchemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(457, 305);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(65, 13);
            this.lblMove.TabIndex = 0;
            this.lblMove.Text = "Click on me!";
            this.lblMove.Click += new System.EventHandler(this.lblMove_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(12, 24);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(175, 13);
            this.lblTop.TabIndex = 1;
            this.lblTop.Text = "Press \"X\" To Reset the AI\'s postion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antony Sedgewick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text Score:";
            // 
            // TextScoreTick
            // 
            this.TextScoreTick.Enabled = true;
            this.TextScoreTick.Interval = 5500;
            this.TextScoreTick.Tick += new System.EventHandler(this.TextScoreTick_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mouse Score:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(184, 634);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Version";
            this.lblVersion.Visible = false;
            // 
            // timeCount
            // 
            this.timeCount.AutoSize = true;
            this.timeCount.Location = new System.Drawing.Point(897, 9);
            this.timeCount.Name = "timeCount";
            this.timeCount.Size = new System.Drawing.Size(30, 13);
            this.timeCount.TabIndex = 8;
            this.timeCount.Text = "Time";
            // 
            // timerCountUp
            // 
            this.timerCountUp.Enabled = true;
            this.timerCountUp.Interval = 1000;
            this.timerCountUp.Tick += new System.EventHandler(this.timerCountUp_Tick);
            // 
            // gameStarted
            // 
            this.gameStarted.AutoSize = true;
            this.gameStarted.Location = new System.Drawing.Point(897, 634);
            this.gameStarted.Name = "gameStarted";
            this.gameStarted.Size = new System.Drawing.Size(78, 13);
            this.gameStarted.TabIndex = 9;
            this.gameStarted.Text = "Game Started?";
            this.gameStarted.Visible = false;
            // 
            // gameStartCheck
            // 
            this.gameStartCheck.Enabled = true;
            this.gameStartCheck.Tick += new System.EventHandler(this.gameStartCheck_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.difficultyToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.namesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloursToolStripMenuItem,
            this.debuggingToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.playersToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.textToolStripMenuItem,
            this.colorSchemesToolStripMenuItem});
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coloursToolStripMenuItem.Text = "Colours";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // debuggingToolStripMenuItem
            // 
            this.debuggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.debuggingToolStripMenuItem.Name = "debuggingToolStripMenuItem";
            this.debuggingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.debuggingToolStripMenuItem.Text = "Debugging";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem1,
            this.playerToolStripMenuItem});
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // playersToolStripMenuItem1
            // 
            this.playersToolStripMenuItem1.Name = "playersToolStripMenuItem1";
            this.playersToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.playersToolStripMenuItem1.Text = "1 Player";
            this.playersToolStripMenuItem1.Click += new System.EventHandler(this.playersToolStripMenuItem1_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.playerToolStripMenuItem.Text = "2 Players";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.insaneToolStripMenuItem,
            this.impossibleToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // insaneToolStripMenuItem
            // 
            this.insaneToolStripMenuItem.Name = "insaneToolStripMenuItem";
            this.insaneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insaneToolStripMenuItem.Text = "Insane";
            this.insaneToolStripMenuItem.Click += new System.EventHandler(this.insaneToolStripMenuItem_Click);
            // 
            // impossibleToolStripMenuItem
            // 
            this.impossibleToolStripMenuItem.Name = "impossibleToolStripMenuItem";
            this.impossibleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.impossibleToolStripMenuItem.Text = "Impossible";
            this.impossibleToolStripMenuItem.Click += new System.EventHandler(this.impossibleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.viewTitlesToolStripMenuItem,
            this.viewChanglogToolStripMenuItem,
            this.currentNamesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // viewTitlesToolStripMenuItem
            // 
            this.viewTitlesToolStripMenuItem.Name = "viewTitlesToolStripMenuItem";
            this.viewTitlesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewTitlesToolStripMenuItem.Text = "View Titles";
            this.viewTitlesToolStripMenuItem.Visible = false;
            this.viewTitlesToolStripMenuItem.Click += new System.EventHandler(this.viewTitlesToolStripMenuItem_Click);
            // 
            // viewChanglogToolStripMenuItem
            // 
            this.viewChanglogToolStripMenuItem.Name = "viewChanglogToolStripMenuItem";
            this.viewChanglogToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewChanglogToolStripMenuItem.Text = "View Changlog";
            this.viewChanglogToolStripMenuItem.Click += new System.EventHandler(this.viewChanglogToolStripMenuItem_Click);
            // 
            // namesToolStripMenuItem
            // 
            this.namesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseToolStripMenuItem,
            this.textToolStripMenuItem1,
            this.resetNamesToolStripMenuItem});
            this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
            this.namesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.namesToolStripMenuItem.Text = "Names";
            // 
            // mouseToolStripMenuItem
            // 
            this.mouseToolStripMenuItem.Name = "mouseToolStripMenuItem";
            this.mouseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mouseToolStripMenuItem.Text = "Mouse";
            this.mouseToolStripMenuItem.Click += new System.EventHandler(this.mouseToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.textToolStripMenuItem1.Text = "Text";
            this.textToolStripMenuItem1.Click += new System.EventHandler(this.textToolStripMenuItem1_Click);
            // 
            // resetNamesToolStripMenuItem
            // 
            this.resetNamesToolStripMenuItem.Enabled = false;
            this.resetNamesToolStripMenuItem.Name = "resetNamesToolStripMenuItem";
            this.resetNamesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetNamesToolStripMenuItem.Text = "Reset Names";
            this.resetNamesToolStripMenuItem.Click += new System.EventHandler(this.resetNamesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // movment
            // 
            this.movment.Enabled = true;
            this.movment.Tick += new System.EventHandler(this.movment_Tick);
            // 
            // rand
            // 
            this.rand.AutoSize = true;
            this.rand.Location = new System.Drawing.Point(310, 634);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(28, 13);
            this.rand.TabIndex = 11;
            this.rand.Text = "rand";
            this.rand.Visible = false;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(487, 634);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(90, 13);
            this.debug.TabIndex = 12;
            this.debug.Text = "debugging output";
            this.debug.Visible = false;
            // 
            // currentNamesToolStripMenuItem
            // 
            this.currentNamesToolStripMenuItem.Name = "currentNamesToolStripMenuItem";
            this.currentNamesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.currentNamesToolStripMenuItem.Text = "Current Names";
            this.currentNamesToolStripMenuItem.Click += new System.EventHandler(this.currentNamesToolStripMenuItem_Click);
            // 
            // colorSchemesToolStripMenuItem
            // 
            this.colorSchemesToolStripMenuItem.Name = "colorSchemesToolStripMenuItem";
            this.colorSchemesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.colorSchemesToolStripMenuItem.Text = "Color Schemes";
            this.colorSchemesToolStripMenuItem.Visible = false;
            this.colorSchemesToolStripMenuItem.Click += new System.EventHandler(this.colorSchemesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 656);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.rand);
            this.Controls.Add(this.gameStarted);
            this.Controls.Add(this.timeCount);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TextScoreTick;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label timeCount;
        private System.Windows.Forms.Timer timerCountUp;
        private System.Windows.Forms.Label gameStarted;
        private System.Windows.Forms.Timer gameStartCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetNamesToolStripMenuItem;
        private System.Windows.Forms.Label rand;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impossibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.Timer movment;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debuggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewTitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewChanglogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSchemesToolStripMenuItem;
    }
}

