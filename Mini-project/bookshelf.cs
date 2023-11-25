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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Mini_project
{
    public partial class bookshelf : Form
    {
        public bookshelf()
        {
            InitializeComponent();
        }

        List<LibraryItem> items = Program.libray.GetAllItemsInLibrary();

        

        private void bookshelf_Load(object sender, EventArgs e)
        {
            flowPanelDocs.AutoScroll = true;
            flowPanelDocs.Padding = new Padding(10);
            

            foreach (var item in items)
            {
                if (!item.IsBought)
                {
                    Panel itemPanel = new Panel
                    {
                        Width = 150,
                        Height = 200,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle,
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

                    pictureBox.Click += (s, ev) =>
                    {
                        ShowDetails(item);
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

                    priceLabel.Click += (s, ev) =>
                    {
                        ShowDetails(item);
                    };

                    titleLabel.Click += (s, ev) =>
                    {
                        ShowDetails(item);
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

            foreach(var item in  items){
                if (item.IsBought)
                {


                    // If IsBought is true, create a small itemPanel for the cart
                    Panel smallItemPanel = new Panel
                    {
                        Width = 80,
                        Height = 120,
                        Margin = new Padding(5),
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    PictureBox smallPictureBox = new PictureBox
                    {
                        ImageLocation = item.ImageUrl,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 80,
                        Height = 60,
                    };

                    Label smallTitleLabel = new Label
                    {
                        Text = "Title: " + item.Title,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label smallPriceLabel = new Label
                    {
                        Text = "Price: " + item.Price,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };


                    smallPictureBox.Click += (sende, even) =>
                    {
                        try
                        {
                            Program.libray.DropItem(item.Title);
                            RefreshDisplay();
                            MessageBox.Show("Item dropped from cart!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to drop the item. Error: {ex.Message}");
                        }
                    };

                    // Add controls to the smallItemPanel
                    smallItemPanel.Controls.Add(smallPictureBox);
                    smallItemPanel.Controls.Add(smallTitleLabel);
                    smallItemPanel.Controls.Add(smallPriceLabel);
                    //smallItemPanel.Controls.Add(dropItem);
                    // Add the smallItemPanel to the cartPanel
                    Cart.Controls.Add(smallItemPanel);
                }
            }

        }

        private decimal CalculateCartTotal()
        {
            decimal total = 0;

            foreach (var item in items)
            {
                if (item.IsBought)
                {
                    total += item.Price;
                }
            }

            return total;
        }


        private void ShowDetails(LibraryItem item)
        {
            
            Form detailsForm = new Form
            {
                Text = "Item Details",
                Width = 600,
                Height = 400, 
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent
            };

           
            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = item.ImageUrl,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 250,
                Height = detailsForm.ClientSize.Height - 20,
                Location = new Point(10, 10),
            };

            Label titleLabel = new Label
            {
                Text = "Title: " + item.Title,
                Location = new Point(280, 10),
                AutoSize = true
            };

            Label descriptionTextBox = new Label
            {
                Text = "Description: " + item.Description,
                Location = new Point(280, 10),
                AutoSize = true
            };

            Label priceLabel = new Label
            {
                Text = "Price: " + item.Price.ToString("C"),
                Location = new Point(280, 150),
                AutoSize = true
            };
            if (item is Book book)
            {
                Label authorLabel = new Label
                {
                    Text = "Author: " + book.Author,
                    Location = new Point(280, 180),
                    AutoSize = true
                };

                Label genreLabel = new Label
                {
                    Text = "Genre: " + book.Genre,
                    Location = new Point(280, 210),
                    AutoSize = true
                };

                Label pagesLabel = new Label
                {
                    Text = "Number of Pages: " + book.NbPages,
                    Location = new Point(280, 240),
                    AutoSize = true
                };

                // Add book-specific labels
                detailsForm.Controls.Add(authorLabel);
                detailsForm.Controls.Add(genreLabel);
                detailsForm.Controls.Add(pagesLabel);
            }
            else if (item is Magazine magazine)
            {
                Label issueNumberLabel = new Label
                {
                    Text = "Issue Number: " + magazine.IssueNumber,
                    Location = new Point(280, 180),
                    AutoSize = true
                };

                Label maisonEditionLabel = new Label
                {
                    Text = "Maison Edition: " + magazine.MaisonEdition,
                    Location = new Point(280, 210),
                    AutoSize = true
                };

                // Add magazine-specific labels
                detailsForm.Controls.Add(issueNumberLabel);
                detailsForm.Controls.Add(maisonEditionLabel);
            }

            // Add controls to the form
            detailsForm.Controls.Add(pictureBox);
            detailsForm.Controls.Add(titleLabel);
            detailsForm.Controls.Add(descriptionTextBox);
            detailsForm.Controls.Add(priceLabel);

            // Add buttons
            Button buyButton = new Button
            {
                Text = "Buy",
                Location = new Point(280, 300),
            };

            Button addToFavoritesButton = new Button
            {
                Text = "Fav",
                Location = new Point(400, 300),
            };

            buyButton.Click += (sender, e) =>
            {
                try
                {
                    Program.libray.BuyItem(item.Title);
                    RefreshDisplay();
                    
                    MessageBox.Show("Item bought successfully!");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to buy the item. Error: {ex.Message}");
                }
            };

            addToFavoritesButton.Click += (sender, e) =>
            {
                try
                {
                    Program.libray.MarkItemAsFavorite(item.Title);
                    RefreshDisplay();
                    MessageBox.Show("Item added to favorites successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to add the item to favorites. Error: {ex.Message}");
                }
            };

            detailsForm.Controls.Add(buyButton);
            detailsForm.Controls.Add(addToFavoritesButton);

            detailsForm.ShowDialog();
        }

        private void RefreshDisplay()
        {
            
            flowPanelDocs.Controls.Clear();
            Cart.Controls.Clear();
    
            
            foreach (var item in items)
            {
                if (!item.IsBought)
                {
                    DisplayItemInPanel(flowPanelDocs, item);
                }
                else
                {

                    // If IsBought is true, create a small itemPanel for the cart
                    Panel smallItemPanel = new Panel
                    {
                        Width = 80,
                        Height = 120,
                        Margin = new Padding(5),
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    PictureBox smallPictureBox = new PictureBox
                    {
                        ImageLocation = item.ImageUrl,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 80,
                        Height = 60,
                    };

                    Label smallTitleLabel = new Label
                    {
                        Text = "Title: " + item.Title,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label smallPriceLabel = new Label
                    {
                        Text = "Price: " + item.Price,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };


                    smallPictureBox.Click += (sender, e) =>
                    {
                        try
                        {
                            Program.libray.DropItem(item.Title);
                            RefreshDisplay();
                            MessageBox.Show("Item dropped from cart!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to drop the item. Error: {ex.Message}");
                        }
                    };

                    // Add controls to the smallItemPanel
                    smallItemPanel.Controls.Add(smallPictureBox);
                    smallItemPanel.Controls.Add(smallTitleLabel);
                    smallItemPanel.Controls.Add(smallPriceLabel);
                    //smallItemPanel.Controls.Add(dropItem);
                    // Add the smallItemPanel to the cartPanel
                    Cart.Controls.Add(smallItemPanel);
                }
            }

            total.Text = this.CalculateCartTotal().ToString();

        }

        private void DisplayItemInPanel(Panel panel, LibraryItem item, bool isCart = false)
        {
            Panel itemPanel = new Panel
            {
                Width = 150,
                Height = 200,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
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

            pictureBox.Click += (s, ev) =>
            {
                ShowDetails(item);
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

            priceLabel.Click += (s, ev) =>
            {
                ShowDetails(item);
            };

            titleLabel.Click += (s, ev) =>
            {
                ShowDetails(item);
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

            // Add the itemPanel to the specified panel
            panel.Controls.Add(itemPanel);

    
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Hide();
        }

       
    }
}

