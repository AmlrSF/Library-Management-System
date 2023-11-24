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
    }
}
