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
    }
}
