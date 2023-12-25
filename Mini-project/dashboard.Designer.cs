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
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMagazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Button();
            this.magazine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(133, 27);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBToolStripMenuItem,
            this.addNewMagazineToolStripMenuItem,
            this.viewDocumentsToolStripMenuItem});
            this.documentsToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.documentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // addNewBToolStripMenuItem
            // 
            this.addNewBToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBToolStripMenuItem.Name = "addNewBToolStripMenuItem";
            this.addNewBToolStripMenuItem.Size = new System.Drawing.Size(280, 28);
            this.addNewBToolStripMenuItem.Text = "Add New Book";
            this.addNewBToolStripMenuItem.Click += new System.EventHandler(this.addNewBToolStripMenuItem_Click);
            // 
            // addNewMagazineToolStripMenuItem
            // 
            this.addNewMagazineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewMagazineToolStripMenuItem.Name = "addNewMagazineToolStripMenuItem";
            this.addNewMagazineToolStripMenuItem.Size = new System.Drawing.Size(280, 28);
            this.addNewMagazineToolStripMenuItem.Text = "Add New Magazine";
            this.addNewMagazineToolStripMenuItem.Click += new System.EventHandler(this.addNewMagazineToolStripMenuItem_Click);
            // 
            // viewDocumentsToolStripMenuItem
            // 
            this.viewDocumentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewDocumentsToolStripMenuItem.Name = "viewDocumentsToolStripMenuItem";
            this.viewDocumentsToolStripMenuItem.Size = new System.Drawing.Size(280, 28);
            this.viewDocumentsToolStripMenuItem.Text = "View documents";
            this.viewDocumentsToolStripMenuItem.Click += new System.EventHandler(this.viewDocumentsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Size = new System.Drawing.Size(867, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(92, 27);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(10, 153);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(555, 93);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "Welcome Sir.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(22, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "As admin, add or delete documents and magazines\r\n for efficient library managemen" +
    "t.";
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.book.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(26, 325);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(152, 41);
            this.book.TabIndex = 4;
            this.book.Text = "New Book";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // magazine
            // 
            this.magazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.magazine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magazine.ForeColor = System.Drawing.Color.White;
            this.magazine.Location = new System.Drawing.Point(184, 325);
            this.magazine.Name = "magazine";
            this.magazine.Size = new System.Drawing.Size(189, 41);
            this.magazine.TabIndex = 5;
            this.magazine.Text = "New Magazine";
            this.magazine.UseVisualStyleBackColor = false;
            this.magazine.Click += new System.EventHandler(this.magazine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.magazine);
            this.Controls.Add(this.book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMagazineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDocumentsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button magazine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
    }
}