namespace Mini_project
{
    partial class UserUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookshelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.bookshelfToolStripMenuItem,
            this.favoriteBooksToolStripMenuItem,
            this.paToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Size = new System.Drawing.Size(1003, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(133, 27);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // bookshelfToolStripMenuItem
            // 
            this.bookshelfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookshelfToolStripMenuItem.Name = "bookshelfToolStripMenuItem";
            this.bookshelfToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.bookshelfToolStripMenuItem.Text = "bookshelf";
            this.bookshelfToolStripMenuItem.Click += new System.EventHandler(this.bookshelfToolStripMenuItem_Click);
            // 
            // favoriteBooksToolStripMenuItem
            // 
            this.favoriteBooksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.favoriteBooksToolStripMenuItem.Name = "favoriteBooksToolStripMenuItem";
            this.favoriteBooksToolStripMenuItem.Size = new System.Drawing.Size(169, 27);
            this.favoriteBooksToolStripMenuItem.Text = "Favorite Books";
            this.favoriteBooksToolStripMenuItem.Click += new System.EventHandler(this.favoriteBooksToolStripMenuItem_Click);
            // 
            // paToolStripMenuItem
            // 
            this.paToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.paToolStripMenuItem.Name = "paToolStripMenuItem";
            this.paToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.paToolStripMenuItem.Text = "Facture";
            this.paToolStripMenuItem.Click += new System.EventHandler(this.paToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(92, 27);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 54);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome";
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.book.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(36, 379);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(208, 41);
            this.book.TabIndex = 10;
            this.book.Text = "Browse Docs";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 80);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcome.Location = new System.Drawing.Point(23, 163);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(555, 93);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "Welcome Sir.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // UserUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUi";
            this.Text = "UserUi";
            this.Load += new System.EventHandler(this.UserUi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookshelfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}