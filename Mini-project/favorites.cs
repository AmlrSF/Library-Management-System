using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Mini_project
{
    public partial class favorites : Form
    {
        public favorites()
        {
            InitializeComponent();
        }

        List<LibraryItem> items = Program.libray.GetAllItemsInLibrary();



        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dah = new dashboard();
            dah.Show();
            this.Hide();
        }

        private void favorites_Load(object sender, EventArgs e)
        {

            flowPanelFavs.AutoScroll = true;
            flowPanelFavs.Padding = new Padding(10);

            foreach (var item in items)
            {
                if (item.IsFavorite)
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


                    smallPictureBox.Click += (sende, ev) =>
                        {
                        // Display a confirmation dialog
                        DialogResult result = MessageBox.Show("Are you sure you want to remove this item from favorites?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                // If user clicked Yes, unmark the item as a favorite
                                Program.libray.unMarkItemAsFavorite(item.Title);
                                
                                MessageBox.Show("Item removed from favorites!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Failed to remove the item. Error: {ex.Message}");
                            }
                        }
                    };


        // Add controls to the smallItemPanel
        smallItemPanel.Controls.Add(smallPictureBox);
                    smallItemPanel.Controls.Add(smallTitleLabel);
                    smallItemPanel.Controls.Add(smallPriceLabel);
                    //smallItemPanel.Controls.Add(dropItem);
                    // Add the smallItemPanel to the cartPanel
                    flowPanelFavs.Controls.Add(smallItemPanel);
                }
            }
        }
    }
}
