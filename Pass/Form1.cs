using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string username = "PartyMan11";
            string Password = "Doge11";
            bool usernameinput = false;
            bool passwordinput = false;


            switch (username)
            {
                case "Partyman11":
                    usernameinput = true;
                    break;
                default:
                    usernameinput = false;
                    break;
            }

            switch (Password)
            {
                case "Doge11":
                    passwordinput = true;
                    break;
                default:
                    passwordinput = false;
                    break;
            }

            if (usernameinput && passwordinput == true)
            {
                bool validlogin = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
