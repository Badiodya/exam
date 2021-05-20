using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ExamHelp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void страница1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"pages\page1.html");
        }

        private void страница2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"pages\page2.html");
        }
    }
}
