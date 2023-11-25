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
    public partial class document_list : Form
    {
        public document_list()
        {
            InitializeComponent();
        }

        DataTable docs = new DataTable();
        DataTable magazineTable = new DataTable("Magazines");

        private void afficheBooks()
        {
            // Example: Adding rows to the DataTable from the library
            foreach (var item in Program.libray.GetAllItemsInLibrary())
            {
                if (item is Book book)
                {
                    DataRow row = docs.NewRow();
                    row["Title"] = book.Title;
                    row["Author"] = book.Author;
                    row["Genre"] = book.Genre;
                    row["NbPages"] = book.NbPages;
                    row["MaisonEdition"] = book.MaisonEdition;
                    row["ImageUrl"] = book.ImageUrl;
                    row["Description"] = book.Description;
                    row["Price"] = book.Price;

                    docs.Rows.Add(row);
                }
            }
        }

        private void afficheMagazine()
        {
            foreach (var item in Program.libray.GetAllItemsInLibrary())
            {
                if (item is Magazine magazine)
                {
                    DataRow row = magazineTable.NewRow();
                    row["Title"] = magazine.Title;
                    row["Author"] = magazine.Author;
                    row["IssueNumber"] = magazine.IssueNumber;
                    row["MaisonEdition"] = magazine.MaisonEdition;
                    row["ImageUrl"] = magazine.ImageUrl;
                    row["Description"] = magazine.Description;
                    row["Price"] = magazine.Price;

                    magazineTable.Rows.Add(row);
                }
            }

        }



        private void document_list_Load(object sender, EventArgs e)
        {
            // books magazine
            docs.Columns.Add("Title", typeof(string));
            docs.Columns.Add("Author", typeof(string));
            docs.Columns.Add("Genre", typeof(string));
            docs.Columns.Add("NbPages", typeof(int));
            docs.Columns.Add("MaisonEdition", typeof(string));
            docs.Columns.Add("ImageUrl", typeof(string));
            docs.Columns.Add("Description", typeof(string));
            docs.Columns.Add("Price", typeof(decimal));

            //magazine table
            magazineTable.Columns.Add("Title", typeof(string));
            magazineTable.Columns.Add("Author", typeof(string));
            magazineTable.Columns.Add("IssueNumber", typeof(int));
            magazineTable.Columns.Add("MaisonEdition", typeof(string));
            magazineTable.Columns.Add("ImageUrl", typeof(string));
            magazineTable.Columns.Add("Description", typeof(string));
            magazineTable.Columns.Add("Price", typeof(decimal));

            afficheBooks();

            bindingSource1.DataSource = docs;

            bindingNavigator1.BindingSource = bindingSource1;

            dataGridView1.DataSource = bindingSource1;

            //*****************************************

            afficheMagazine();

            bindingSource2.DataSource = magazineTable;

            bindingNavigator2.BindingSource = bindingSource2;

            dataGridView2.DataSource = bindingSource2;

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Hide();
        }



        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                object titleValue = selectedRow.Cells["Title"].Value;


                if (titleValue != null)
                {
                    Program.libray.RemoveItemFromLibrary(titleValue.ToString());
                    MessageBox.Show("Book :  "+titleValue.ToString()+" deleted Succesfully");
                    docs.Clear();
                    afficheBooks();
                }
            }
        }

        private void DeleteMagBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                object titleValue = selectedRow.Cells["Title"].Value;


                if (titleValue != null)
                {
                    Program.libray.RemoveItemFromLibrary(titleValue.ToString());
                    MessageBox.Show("Magazine :  " + titleValue.ToString() + " deleted Succesfully");
                    magazineTable.Clear();
                    afficheMagazine();
                }
            }
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            Program.libray.RemoveAllItemsFromLibrary();
            magazineTable.Clear();
            docs.Clear();
            MessageBox.Show("all docs deleted Succesfully");
        }

        private void addNewMagBtn_Click(object sender, EventArgs e)
        {
            magazaine_insertion mgInsertion = new magazaine_insertion();
            mgInsertion.Show();
            this.Hide();

        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            book_insertion inBook = new book_insertion();
            inBook.Show();
            this.Hide();
        }
    }
}
