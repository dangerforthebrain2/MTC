using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Forms;

namespace moving_text_game
{
    public partial class Form1 : Form
    {
        
       // Author: Antony Sedgewick

       // central place for stroge of global controls

       // score inital values, and intial time 
       int score, score2, time, ran = 0;
       // Version Numbers(change these to change the version number)
       int version1 = 0;
       int version2 = 5;
       // optinal version letter, when and full number interation is not approprate
       String optinalVersionLetter = "";
       // greek version (leave blank for full)
       String greek = "Alpha ";
       //default movment values
       int hoz = 12;
       int vert = 15;
       // single / multiplayer version
       String players = "";
       // setting the names of the players
       String text;
       String mouse;
       //initaliing the title name strings
       String titles;
       //initalising the forms
       Form2 fm;
       textName fm1;
       ChangeLog fm2;
       Schemes fm3;
       // the look of the text player
       String textLeft = ">----";
       String textRight = "----<";
       //all initial stats
       String stats = System.IO.File.ReadAllText("..\\..\\stats.stor");
       String mainTitleText;
       //stats stuff
       int played, txtWin, mouWin;
       String[] set1;
       String[] set2;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
       {
            played++;
            //using this string to shortening the title
            mainTitleText = "The Moving Text Chase " + greek + "Version: " + version1 + "." + version2 + optinalVersionLetter + players;
            //names & changlog contents loading
            mouse = System.IO.File.ReadAllText("..\\..\\mouseName.stor");
            text = System.IO.File.ReadAllText("..\\..\\textName.stor");
            //setting the intial text of the text player
            lblMove.Text = "Click on me!";
            // sets the version, names of players, and shows a message box
            lblVersion.Text = "Version: " + version1 + "." + version2 + optinalVersionLetter;
            //load text from filesystem
            label2.Text = text + "'s" + " Score: ";
            label3.Text = mouse + "'s" + " Score: ";

            TextReader tr = new StreamReader("..\\..\\titles.stor");
            titles = tr.ReadToEnd();
            tr.Close();
            set1 = titles.Split('\n');
            // setting the title, stating the name, weather its alpha or beta, then the version number
            //generates a random number upon load
            Random r = new Random();
            ran = r.Next(10);
            //ran = 9;
            if (ran == 0)
            {
                this.Text = mainTitleText + set1[0];
            }
            if (ran == 1)
            {
                this.Text = mainTitleText + set1[1];
            }
            if (ran == 2)
            {
                this.Text = mainTitleText + set1[2];
            }
            if (ran == 3)
            {
                this.Text = mainTitleText + set1[3];
            }
            if (ran == 4)
            {
                this.Text = mainTitleText + set1[4];
            }
            if (ran == 5)
            {
                this.Text = mainTitleText + set1[5];
            }
            if (ran == 6)
            {
                this.Text = mainTitleText + set1[6];
            }
            if (ran == 7)
            {
                this.Text = mainTitleText + set1[7];
            }
            if (ran == 8)
            {
                this.Text = mainTitleText + set1[8];
            }
            if (ran == 9)
            {
                this.Text = mainTitleText + set1[9];
            }
            //picks out all the label and menustrip controls, then sets their colours
            for (int x = 0; x < Controls.Count; x++)
            {
                if (Controls[x].GetType() == typeof(MenuStrip))
                {
                    Controls[x].BackColor = Color.Transparent;
                    Controls[x].ForeColor = Color.Black;

                } 
                if (Controls[x].GetType() == typeof(Label))
                {
                    Controls[x].BackColor = Color.Transparent;
                    Controls[x].ForeColor = Color.Black;

                }
            }
            this.BackColor = Color.White;
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            set2 = stats.Split('\n');
            played = Int16.Parse(set2[0]);
            txtWin = Int16.Parse(set2[1]);
            mouWin = Int16.Parse(set2[2]);
        }
        //debug display options
        public void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStarted.Visible = true;
            rand.Visible = true;
            debug.Visible = true;
            lblVersion.Visible = true;
            viewTitlesToolStripMenuItem.Visible = true;
            colorSchemesToolStripMenuItem.Visible = true;
            if (enableToolStripMenuItem.Visible == false)
            {
                disableToolStripMenuItem.Visible = true;
            }

        }

        public void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStarted.Visible = false;
            rand.Visible = false;
            debug.Visible = false;
            lblVersion.Visible = false;
            viewTitlesToolStripMenuItem.Visible = false;
            colorSchemesToolStripMenuItem.Visible = false;
            if (disableToolStripMenuItem.Visible == false)
            {
                enableToolStripMenuItem.Visible = true;
            }
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // position reset control
            if (e.KeyCode == Keys.X)
            {
                System.Threading.Thread.Sleep(100);
                lblMove.Left = this.Width / 2 - lblMove.Width / 2;
                lblMove.Visible = true;
                TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
                Debug.Listeners.Add(tr1);
                Debug.WriteLine(DateTime.Now + " Text Reset");
                tr1.Close();
                String actlog = System.IO.File.ReadAllText("..\\..\\ActionsLog.stor");
                this.lblMove.Location = new Point(457, 305);
            }
            if (movment.Enabled == false || players == "MP")
            {
                // movment controls 
                if (e.KeyCode == Keys.Left)
                {
                    lblMove.Left -= 15;
                    lblMove.Text = textLeft;
                    TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
                    Debug.Listeners.Add(tr1);
                    Debug.WriteLine(DateTime.Now + " Moved Left");
                    tr1.Close();
                }

                if (e.KeyCode == Keys.Right)
                {
                    lblMove.Left += 15;
                    lblMove.Text = textRight;
                    TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
                    Debug.Listeners.Add(tr1);
                    Debug.WriteLine(DateTime.Now + " Moved Right");
                    tr1.Close();
                }

                if (e.KeyCode == Keys.Down)
                {
                    lblMove.Top += 17;
                    TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
                    Debug.Listeners.Add(tr1);
                    Debug.WriteLine(DateTime.Now + " Moved Up");
                    tr1.Close();
                }
                if (e.KeyCode == Keys.Up)
                {
                    lblMove.Top -= 17;
                    TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
                    Debug.Listeners.Add(tr1);
                    Debug.WriteLine(DateTime.Now + " Moved Down");
                    tr1.Close();
                }
            }
        }
        //viewing of the titles
        private void viewTitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(titles);
        }
        //the moving text player
        public void lblMove_Click(object sender, EventArgs e)
        {
            //mouse click detection and mouse score upcount
            score ++;
            lblMove.Visible = false;
            label3.Text =   mouse + "'s" + " Score: " + score.ToString();
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
            Debug.Listeners.Add(tr1);
            Debug.WriteLine(DateTime.Now + " Text Hit With Mouse");
            tr1.Close();
            //shows that the mouse player is the winner if they reach 20 points
            if (score == 20)
            {
                System.Windows.Forms.MessageBox.Show(mouse + " Wins! \n" + "You won in " + time + " Seconds");
                Application.Exit();
            }
            if (lblMove.Visible == false)
            {
                lblMove.Text = ">----";
            }
        }
 
        public void OnProcessExit(object sender, EventArgs e)
        {
                TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
                Debug.Listeners.Add(tr1);
                Debug.WriteLine(DateTime.Now + " Game Closed");
                tr1.Close();
        if (score == 20)
        {
         mouWin++;
         //set2[1] = mouWin.ToString;
        }
        if (score2 == 30)
        {
            txtWin++;
        }

        }

        public void TextScoreTick_Tick(object sender, EventArgs e)
        {
            // Text Score upcount
            label2.Visible = true;
            // only count up the score if the TextPlayer is visable
            if (lblMove.Visible == true)
            {
                if (lblMove.Text == ">----" || lblMove.Text == "----<")
                {
                    score2++;
                    label2.Text = text + "'s" + " Score: " + score2.ToString();
                }
            }
            // shows a box showing that the text player has won if they reach 30 points
            if (players == "SP")
            {
                if (score2 == 30)
                {
                    System.Windows.Forms.MessageBox.Show(text + " Wins!\n" + "The AI won in " + time + " Seconds");
                    Application.Exit();
                }
            }
            if (players == "MP")
            {
                if (score2 == 30)
                {
                    System.Windows.Forms.MessageBox.Show(text + " Wins!\n" + "You won in:  " + time + " Seconds");
                    Application.Exit();
                }
                // debugging score output
                if (score != 0)
                {
                    TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ScoreLog.stor"));
                    Debug.Listeners.Add(tr1);
                    Debug.WriteIf(score2 != 0, DateTime.Now + " TextScore  is: " + score2.ToString() + Environment.NewLine);
                    Debug.WriteIf(score != 0, DateTime.Now + " MouseScore is: " + score.ToString() + Environment.NewLine);
                    tr1.Close();
                }
               
            }
        }

        private void timerCountUp_Tick(object sender, EventArgs e)
        {
            // make the timer invisable if the player hasn't moved
            if (gameStarted.Text == "Game Started?")
            {
                timeCount.Visible = false;
            }
            // start counting if the player has moved
            if (gameStarted.Text == "GAME STARTED!")
            {
                timeCount.Visible = true;
                time++;
                timeCount.Text = "Seconds Played: " + time.ToString();
                TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ScoreLog.stor"));
                Debug.Listeners.Add(tr1);
                Debug.WriteLine("Seconds Played " + time);
                tr1.Close();
            }
        }

        // game started checker
        public void gameStartCheck_Tick(object sender, EventArgs e)
        {
            if (lblMove.Text == ">----" || lblMove.Text == "----<")
            {
                gameStarted.Text = "GAME STARTED!";
            }
        }

        // menu strip objects
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
            Debug.Listeners.Add(tr1);
            Debug.WriteLine("Setting Background Colour to: " + colorDialog1.Color);
            tr1.Close();
        }

        public void textToolStripMenuItem_Click(object sender, EventArgs e)
        { // colour setting
            colorDialog2.ShowDialog();
            for (int x = 0; x < Controls.Count; x++)
                if (Controls[x].GetType() == typeof(Menu))
                {
                    Controls[x].BackColor = colorDialog1.Color;
                    Controls[x].ForeColor = colorDialog2.Color;
                }
            for (int x = 0; x < Controls.Count; x++)
                if (Controls[x].GetType() == typeof(Label))
                {
                    Controls[x].BackColor = colorDialog1.Color;
                    Controls[x].ForeColor = colorDialog2.Color;
                }
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
            Debug.Listeners.Add(tr1);
            Debug.WriteLine("Setting Text Colours to: " + colorDialog1.Color);
            tr1.Close();
            if (colorDialog1.Color == colorDialog2.Color)
            { // anti cheat system for colour
                MessageBox.Show("You have been caught cheating!", "Cheat Detected");
                this.BackColor = System.Drawing.Color.White;
                label1.BackColor = System.Drawing.Color.Transparent;

                for (int x = 0; x < Controls.Count; x++)
                    if (Controls[x].GetType() == typeof(Label))
                    {
                        Controls[x].BackColor = Color.Transparent;
                        Controls[x].ForeColor = Color.Black;
                    }
                Debug.Listeners.Add(tr1);
                Debug.WriteLine("Cheating Dected at: " + DateTime.Now);
                tr1.Close();
            }
            for (int x = 0; x < Controls.Count; x++)
            Controls[x].BackColor = Color.Transparent;
        }

        // exit button and comfirmation
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            DialogResult r = MessageBox.Show("Are you sure?", "Exit", (MessageBoxButtons.YesNo));
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // random movment
        public void movment_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int val = r.Next(4);


            if (val == 0)
            {
                lblMove.Left -= hoz;
                lblMove.Text = textLeft;
            }
            if (val == 1)
            {
                lblMove.Left += hoz;
                lblMove.Text = textRight;
            }
            if (val == 2)
            {
                lblMove.Top += vert;
            }
            if (val == 3)
            {
                lblMove.Top -= vert;
            }

            rand.Text = "randomMovment: " + " " + val + " , " + "randomTitle: " + " " + ran;
            // debug text updating 
            debug.Text = "  Debugging Enabled" + " " + played + " " + txtWin + " " + mouWin + " ";
        }
        // difficulty settings
        public void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movment.Interval = 100;
            hoz = 12;
            vert = 15;
        }

        public void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movment.Interval = 100;
            hoz = 15;
            vert = 17;
        }

        public void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movment.Interval = 100;
            hoz = 75;
            vert = 77;
        }

        public void insaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movment.Interval = 100;
            hoz = 80;
            vert = 82;
        }

        public void impossibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movment.Interval = 100;
            hoz = 95;
            vert = 97;
        }        
        
        // instructions infomation
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (players == "")
            {
                System.Windows.Forms.MessageBox.Show("The game starts automaticly on the easy difficulty." + "\n" + "The AI or Text" + " player" +
                    " will move randomly in four directions." + "\n" + "its your job to click on the randomly moving text, before its score reaches 30." + "\n"
                    + "if you click the text 20 times before the text reaches 30 you win." + "\n" + "when you hit the text, press X on your keyboard to reset its postion, " +
                "you also do this if the text leaves the screen.");
            }
            if (players == "MP")
            {
                System.Windows.Forms.MessageBox.Show("The second player can move with the arrow keys." +
                    " its the second player's job to click on the randomly moving text, before their score reaches 30." + "\n"
                    + "if you click the text 20 times before the second player's score reaches 30 you win." + "\n" + "when you hit the text, press X on your keyboard to reset its postion, " +
                "you also do this if the text leaves the screen.");
            }
        }

        //game reseting
        public void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time = 0;
            score = 0;
            score2 = 0;
            this.lblMove.Location = new Point(457, 305);

        }
        //swtiches for SP and MP
        public void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movment.Enabled = false;
            players = "MP";
          //debug.Text = "Players: " + players;
            lblTop.Text = "Press X To Reset the Second Player's postion";
            if (rand.Visible == true)
            {
                debug.Visible = true;
            }
            time = 0;
            score = 0;
            score2 = 0;
            this.lblMove.Location = new Point(457, 305);
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
            Debug.Listeners.Add(tr1);
            Debug.WriteLine(DateTime.Now + " Changed to MP");
            tr1.Close();
        }

        public void playersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            movment.Enabled = true;
            players = "SP";
            debug.Text = "Players: " + players;
            lblTop.Text = "Press X To Reset the AI's postion";
            if (rand.Visible == true)
            {
                debug.Visible = true;
            }
            time = 0;
            score = 0;
            score2 = 0;
            this.lblMove.Location = new Point(457, 305);
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.AppendText("..\\..\\ActionsLog.stor"));
            Debug.Listeners.Add(tr1);
            Debug.WriteLine(DateTime.Now + " Changed to SP");
            tr1.Close();
            
        }
        //name changing
        public void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fm1 = new textName();
            fm1.Show();
            if (fm1.Visible == false)
            {
                label2.Text = text + "'s" + " Score: ";
            }
        }

        public void mouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm = new Form2();
            fm.Show();
            if (fm.Visible == false)
            {
                label3.Text = mouse + "'s" + " Score: ";
            }
        }

        // about infomation
        public void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(mainTitleText + "\n" + "Coded by : Antony Sedgewick");
        }

        private void viewChanglogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm2 = new ChangeLog();
            fm2.Show();
        }

        private void currentNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Name: " + text + "\n"+ "Mouse Name: " + mouse);
        }

        private void colorSchemesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm3 = new Schemes();
            fm3.Show();
        }
    }
}

// Author: Antony Sedgewick 
