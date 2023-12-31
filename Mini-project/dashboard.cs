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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void addNewBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_insertion book_Insertion = new book_insertion();
            book_Insertion.Show();
            this.Hide();
        }

        private void viewDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document_list docsL = new document_list();
            docsL.Show();
            this.Hide();
        }

        private void addNewMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            magazaine_insertion magazine_insertion = new magazaine_insertion();
            magazine_insertion.Show();
            this.Hide();    
        }

        private void bookshelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookshelf bk = new bookshelf();
            bk.Show();
            this.Hide();
            
        }

        private void favoriteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            favorites fav = new favorites();
            fav.Show();
            this.Hide();
        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facture fact = new Facture();
            fact.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            Welcome.Text =  Program.Username + ".";
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void book_Click(object sender, EventArgs e)
        {
            book_insertion book_Insertion = new book_insertion();
            book_Insertion.Show();
            this.Hide();
        }

        private void magazine_Click(object sender, EventArgs e)
        {
            magazaine_insertion magazine_insertion = new magazaine_insertion();
            magazine_insertion.Show();
            this.Hide();
        }
    }
}
