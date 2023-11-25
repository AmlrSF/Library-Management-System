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

  
    }
}
