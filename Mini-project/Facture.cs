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
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserUi dashboard = new UserUi();
            dashboard.Show();
            this.Hide();
        }

        List<LibraryItem> items = Program.libray.GetAllItemsInLibrary();

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


        private void Facture_Load(object sender, EventArgs e)
        {
            flowPanelFacture.AutoScroll = true;
            flowPanelFacture.Padding = new Padding(10);
            int i = 0;
            foreach (var item in items)
            {
                if (item.IsBought)
                {
                    Panel itemPanel = new Panel
                    {
                        Width = 200,
                        Height = 120,
                        Margin = new Padding(5),
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        ImageLocation = item.ImageUrl,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 100,
                        Height = 120,
                    };

                    Label titleLabel = new Label
                    {
                        Text = "Title: " + item.Title,
                        Location = new Point(110, 10),
                        AutoSize = true,
                    };

                    Label priceLabel = new Label
                    {
                        Text = "Price: " + item.Price.ToString("C"),
                        Location = new Point(110, 40),
                        AutoSize = true,
                    };

                    // Add controls to the itemPanel
                    itemPanel.Controls.Add(pictureBox);
                    itemPanel.Controls.Add(titleLabel);
                    itemPanel.Controls.Add(priceLabel);

                    // Add the itemPanel to the flowPanelFacture
                    flowPanelFacture.Controls.Add(itemPanel);
                    i++;
                }


            }

            Total.Text =this.CalculateCartTotal().ToString("C");    
            Amount.Text = i.ToString()+" Docs";
        }

    }
}
