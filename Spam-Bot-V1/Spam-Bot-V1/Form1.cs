using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spam_Bot_V1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(richTextBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
        }
    }
}
