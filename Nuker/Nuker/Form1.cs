using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nuker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double version = 1.0;
            string caption = "Nuker";
            MessageBox.Show("Welcome To Nuker v" + version, caption);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 250;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 250)
            {
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
                this.timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5); 
        }
    }
}
