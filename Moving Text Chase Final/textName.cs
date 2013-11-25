using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Forms
{
    public partial class textName : Form
    {
        public textName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextWriter tw = new StreamWriter("..\\..\\textName.txt");
            tw.Write(textBox1.Text);
            tw.Close();
        }
    }
}
