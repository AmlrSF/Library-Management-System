namespace Mini_project
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookshelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMagazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.bookshelfToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.favoriteBooksToolStripMenuItem,
            this.paToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // bookshelfToolStripMenuItem
            // 
            this.bookshelfToolStripMenuItem.Name = "bookshelfToolStripMenuItem";
            this.bookshelfToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.bookshelfToolStripMenuItem.Text = "bookshelf";
            this.bookshelfToolStripMenuItem.Click += new System.EventHandler(this.bookshelfToolStripMenuItem_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBToolStripMenuItem,
            this.addNewMagazineToolStripMenuItem,
            this.viewDocumentsToolStripMenuItem});
            this.documentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // addNewBToolStripMenuItem
            // 
            this.addNewBToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBToolStripMenuItem.Name = "addNewBToolStripMenuItem";
            this.addNewBToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.addNewBToolStripMenuItem.Text = "Add New Book";
            this.addNewBToolStripMenuItem.Click += new System.EventHandler(this.addNewBToolStripMenuItem_Click);
            // 
            // addNewMagazineToolStripMenuItem
            // 
            this.addNewMagazineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewMagazineToolStripMenuItem.Name = "addNewMagazineToolStripMenuItem";
            this.addNewMagazineToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.addNewMagazineToolStripMenuItem.Text = "Add New Magazine";
            this.addNewMagazineToolStripMenuItem.Click += new System.EventHandler(this.addNewMagazineToolStripMenuItem_Click);
            // 
            // viewDocumentsToolStripMenuItem
            // 
            this.viewDocumentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewDocumentsToolStripMenuItem.Name = "viewDocumentsToolStripMenuItem";
            this.viewDocumentsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.viewDocumentsToolStripMenuItem.Text = "View documents";
            this.viewDocumentsToolStripMenuItem.Click += new System.EventHandler(this.viewDocumentsToolStripMenuItem_Click);
            // 
            // favoriteBooksToolStripMenuItem
            // 
            this.favoriteBooksToolStripMenuItem.Name = "favoriteBooksToolStripMenuItem";
            this.favoriteBooksToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.favoriteBooksToolStripMenuItem.Text = "Favorite Books";
            this.favoriteBooksToolStripMenuItem.Click += new System.EventHandler(this.favoriteBooksToolStripMenuItem_Click);
            // 
            // paToolStripMenuItem
            // 
            this.paToolStripMenuItem.Name = "paToolStripMenuItem";
            this.paToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.paToolStripMenuItem.Text = "Facture";
            this.paToolStripMenuItem.Click += new System.EventHandler(this.paToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 452);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMagazineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookshelfToolStripMenuItem;
    }
}