using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                user.Focus();
            }));
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!terms.Checked)
            {
                MessageBox.Show("Please accept the terms to log in.", "Terms Not Accepted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string checkUsername = user.Text;
            string checkPassword = Password.Text;

            if (string.IsNullOrEmpty(checkUsername) || string.IsNullOrEmpty(checkPassword))
            {
                MessageBox.Show("You must enter both username and password to log in.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user.Focus();
            }
            else if (checkPassword == "admin")
            {
                dashboard dash = new dashboard();
                dash.Show();
                this.Hide();
            }
            else if (checkPassword == "user")
            {
                // Handle user login
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user.Focus();
                user.Text = "";
                Password.Text = "";
            }
        }
    }
}
