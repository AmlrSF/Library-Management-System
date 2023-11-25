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
    public partial class book_insertion : Form
    {
        public book_insertion()
        {
            InitializeComponent();
        }

        private void bookImage_Click(object sender, EventArgs e)
        {
            // Create and configure the OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                openFileDialog.Title = "Select an Image File";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    bookImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void BookAddBtn_Click(object sender, EventArgs e)
        {
            
            string author = bookAuthor.Text;
            string title = bookTitle.Text;
            string description = bookDescription.Text;

            
            if (decimal.TryParse(bookPrice.Text, out decimal price))
            {
                
                string genre = BookGenre.Text;
                string maisonEd = bookmed.Text;


                if (int.TryParse(bookpage.Text, out int nbPages))
                {
                    string image = bookImage.ImageLocation;

                    
                    Book newBook = new Book
                    {
                        Author = author,
                        Title = title,
                        Description = description,
                        Price = price,
                        Genre = genre,
                        MaisonEdition = maisonEd,
                        NbPages = nbPages,
                        ImageUrl = image
                    };

                    
                    Program.libray.AddBookToLibrary(newBook);

                    
                    MessageBox.Show("Book added successfully!");

                    
                    ClearFormControls();
                }
                else
                {                  
                    MessageBox.Show("Invalid number of pages. Please enter a valid integer.");
                }
            }
            else
            {
                MessageBox.Show("Invalid price. Please enter a valid decimal number.");
            }
        }


        private void ClearFormControls()
        {
            bookAuthor.Text = string.Empty;
            bookTitle.Text = string.Empty;
            bookDescription.Text = string.Empty;
            bookPrice.Text = string.Empty;
            BookGenre.Text = string.Empty;
            bookmed.Text = string.Empty;
            bookNbPage.Text = string.Empty;

            bookImage.ImageLocation = @"C:\Users\elbootic.com\Desktop\Liberay Management System\download(2).png";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            document_list dcsL = new document_list();
            dcsL.Show();
            this.Hide();
        }

    }
}
