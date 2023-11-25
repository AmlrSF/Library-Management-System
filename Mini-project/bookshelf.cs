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
    public partial class bookshelf : Form
    {
        public bookshelf()
        {
            InitializeComponent();
        }

        private void bookshelf_Load(object sender, EventArgs e)
        {
            flowPanelDocs.AutoSize = true;
            flowPanelDocs.AutoScroll = true;
            flowPanelDocs.Padding = new Padding(10); // Adjust the padding

            var items = Program.libray.GetAllItemsInLibrary();

            foreach (var item in items)
            {
                Panel itemPanel = new Panel
                {
                    Width = 150, // Adjust the width for your design
                    Height = 200, // Adjust the height for your design
                    Margin = new Padding(10), // Adjust the margin for spacing between items
                    BorderStyle = BorderStyle.FixedSingle, // Add a border for visual separation
                };

                itemPanel.Click += (s, ev) =>
                {
                    ShowDetails(item);
                };
                Label typeLabel = new Label
                {
                    Text = (item is Book) ? "Type: Book" : "Type: Magazine",
                    ForeColor = System.Drawing.Color.White,
                    BackColor = (item is Book) ? System.Drawing.Color.Green : System.Drawing.Color.Blue,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 100,
                    Height = 20,
                };

                PictureBox pictureBox = new PictureBox
                {
                    ImageLocation = item.ImageUrl,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 150,
                    Height = 100,
                };


                Label titleLabel = new Label
                {
                    Text = "Title: " + item.Title,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Label priceLabel = new Label
                {
                    Text = "Price: " + item.Price.ToString("C"),
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                };


                if (item is Book book)
                {
                    Label genre = new Label
                    {
                        Text = "Genre: " + book.Genre,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label maisonEditionLabel = new Label
                    {
                        Text = "Maison Edition: " + book.MaisonEdition,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    // Add controls to the itemPanel for books
                    itemPanel.Controls.Add(typeLabel);
                    itemPanel.Controls.Add(pictureBox);
                    itemPanel.Controls.Add(titleLabel);
                    itemPanel.Controls.Add(genre);
                    itemPanel.Controls.Add(maisonEditionLabel);
                    itemPanel.Controls.Add(priceLabel);
                }
                else if (item is Magazine magazine)
                {
                    Label issueNumberLabel = new Label
                    {
                        Text = "Issue Number: " + magazine.IssueNumber,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label maisonEditionLabel = new Label
                    {
                        Text = "Maison Edition: " + magazine.MaisonEdition,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    // Add controls to the itemPanel for magazines
                    itemPanel.Controls.Add(typeLabel);
                    itemPanel.Controls.Add(pictureBox);
                    itemPanel.Controls.Add(titleLabel);
                    itemPanel.Controls.Add(issueNumberLabel);
                    itemPanel.Controls.Add(maisonEditionLabel);
                    itemPanel.Controls.Add(priceLabel);
                }
                // Add the itemPanel to the flowPanelDocs
                flowPanelDocs.Controls.Add(itemPanel);
            }
        }



        private void ShowDetails(LibraryItem item)
        {
            // Implement the logic to show details of the selected item
            // You can create a new form or update an existing one to show the details
            // You can access the specific properties of the item (e.g., item.Title, item.Description, etc.)
            // and display them in the details form.
        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Hide();
        }

        
    }
}

