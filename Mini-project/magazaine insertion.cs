using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Mini_project
{
    public partial class magazaine_insertion : Form
    {
        public magazaine_insertion()
        {
            InitializeComponent();
        }

        private void magazineAddBtn_Click(object sender, EventArgs e)
        {
            string author = magazineAuthor.Text;
            string title = magazineTitle.Text;
            string description = magazineDescription.Text;

            if (decimal.TryParse(magazinePrice.Text, out decimal price))
            {
         
                if (int.TryParse(magazineIsueeN.Text, out int issueNumber))
                {
                    string maisonEd = magazinemed.Text;
                    string image = MagazineImage.ImageLocation;

                    
                    Magazine newMagazine = new Magazine
                    {
                        Author = author,
                        Title = title,
                        Description = description,
                        Price = price,
                        IssueNumber = issueNumber,
                        MaisonEdition = maisonEd,
                        ImageUrl = image
                    };

                    
                    Program.libray.AddMagazineToLibrary(newMagazine);

                    
                    MessageBox.Show("Magazine added successfully!");

                    
                    ClearFormControls();
                }
                else
                {
                    // Display an error message for invalid issue number
                    MessageBox.Show("Invalid issue number. Please enter a valid integer.");
                }
            }
            else
            {
                // Display an error message for invalid price
                MessageBox.Show("Invalid price. Please enter a valid decimal number.");
            }
        }

        private void ClearFormControls()
        {
            // Clear values in your form controls
            magazineAuthor.Text = string.Empty;
            magazineTitle.Text = string.Empty;
            magazineDescription.Text = string.Empty;
            magazinePrice.Text = string.Empty;
            magazineIsueeN.Text = string.Empty;
            magazinemed.Text = string.Empty;
            MagazineImage.ImageLocation = string.Empty;
        }

        private void ListMagazineBtn_Click(object sender, EventArgs e)
        {
            document_list docsL = new document_list();
            docsL.Show();
            this.Hide();
        }

        private void MagazineImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                openFileDialog.Title = "Select an Image File";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    MagazineImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();  
            dashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void magazaine_insertion_Load(object sender, EventArgs e)
        {

        }
    }
}
