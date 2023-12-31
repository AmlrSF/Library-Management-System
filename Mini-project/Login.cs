﻿using System;
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
            string checkPassword = Pass.Text;

            if (string.IsNullOrEmpty(checkUsername) || string.IsNullOrEmpty(checkPassword))
            {
                MessageBox.Show("You must enter both username and password to log in.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user.Focus();
            }
            else if (checkPassword == "Admin")
            {
                Program.Username = checkUsername;

                dashboard dash = new dashboard();
                dash.Show();
                this.Hide();
            }
            else if (checkPassword == "User")
            {
                Program.Username = checkUsername;
                UserUi user = new UserUi();
                user.Show();
                this.Hide();            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user.Focus();
                user.Text = "";
                Pass.Text = "";
            }
        }
    }
}
