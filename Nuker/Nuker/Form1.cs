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
               string message = "Are You Sure?";
               MessageBoxButtons buttons = MessageBoxButtons.YesNo;
               MessageBoxIcon icon = MessageBoxIcon.Question;
	           MessageBoxDefaultButton defaultbutton = MessageBoxDefaultButton.Button2;
               MessageBox.Show(message, buttons, icon, defaultbutton);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("hello and welcome!", "welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
