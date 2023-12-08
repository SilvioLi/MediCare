using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare
{
    public partial class LogIn : Form
    {
        public bool valid = false;
        public LogIn()
        {
            InitializeComponent();
            userName.Text = "user";
            password.Text = "123";
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        public void logIn_button_Click(object sender, EventArgs e)
        {       
                if (userName.Text == "user" && password.Text == "123")
                {
                    MessageBox.Show("Wecome");
                    Form1 form = new Form1();
                    valid = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect. Please try again");
                }        

        }
    }
}
