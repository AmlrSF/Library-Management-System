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
    public partial class UserUi : Form
    {
        public UserUi()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facture fact = new Facture();
            fact.Show();
            this.Hide();
        }

        private void favoriteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            favorites fav = new favorites();
            fav.Show();
            this.Hide();
        }

        private void bookshelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookshelf bk = new bookshelf();
            bk.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void book_Click(object sender, EventArgs e)
        {
            bookshelf sh = new bookshelf();
            sh.Show();
            this.Hide();
        }

        private void UserUi_Load(object sender, EventArgs e)
        {
            Welcome.Text = Program.Username + ".";
        }
    }
}
