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
            MessageBox.Show("PS3 Jailbreaker v1");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //button1.Click += new System.EventHandler(Click);
            this.timer1.Start();

            if (comboBox1.Text == "v3.55" || comboBox1.Text == "v3.50" || comboBox1.Text == "v3.42" || comboBox1.Text == "v3.41" && comboBox2.Text == "Rogero" || comboBox2.Text == "Rebug" || comboBox2.Text == "Kmeaw")
            {
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Please Enter A Firmware");
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Enter A Version");
                }
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                this.progressBar1.Increment(1);
                this.progressBar2.Increment(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        public void tsLabel1_Click(object sender, EventArgs e)
        {
                tsLabel1.Text = "PS3";

                if (toolStripDropDownButton1.Text == "PS4")
                {
                    tsLabel1.Text = "PS4";
                }
                 
                 
        }

        public void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
