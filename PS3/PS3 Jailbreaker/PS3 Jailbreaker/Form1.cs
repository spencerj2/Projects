using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PS3_Jailbreaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "v3.55")
            {
                this.progressBar1.Increment(1);
                this.progressBar1.Increment(1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
