using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class ChangeLog : Form
    {
        String log;
        public ChangeLog()
        {
            InitializeComponent();
        }

        private void ChangeLog_Load(object sender, EventArgs e)
        {
            log = System.IO.File.ReadAllText("..\\..\\ChangeLog.txt");
            textBox1.Text = log;
        }
    }
}
