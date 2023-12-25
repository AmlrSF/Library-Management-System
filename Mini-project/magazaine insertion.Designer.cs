namespace Mini_project
{
    partial class magazaine_insertion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magazaine_insertion));
            this.ListMagazineBtn = new System.Windows.Forms.Button();
            this.magazineAddBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MagazineImage = new System.Windows.Forms.PictureBox();
            this.magazinemed = new System.Windows.Forms.TextBox();
            this.bookMEditino = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.magazinePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.magazineDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.magazineAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.magazineTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.magazineIsueeN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MagazineImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ListMagazineBtn
            // 
            this.ListMagazineBtn.Location = new System.Drawing.Point(320, 367);
            this.ListMagazineBtn.Name = "ListMagazineBtn";
            this.ListMagazineBtn.Size = new System.Drawing.Size(227, 41);
            this.ListMagazineBtn.TabIndex = 37;
            this.ListMagazineBtn.Text = "List of Magazines";
            this.ListMagazineBtn.UseVisualStyleBackColor = true;
            this.ListMagazineBtn.Click += new System.EventHandler(this.ListMagazineBtn_Click);
            // 
            // magazineAddBtn
            // 
            this.magazineAddBtn.Location = new System.Drawing.Point(317, 318);
            this.magazineAddBtn.Name = "magazineAddBtn";
            this.magazineAddBtn.Size = new System.Drawing.Size(227, 41);
            this.magazineAddBtn.TabIndex = 35;
            this.magazineAddBtn.Text = "Add Magazine";
            this.magazineAddBtn.UseVisualStyleBackColor = true;
            this.magazineAddBtn.Click += new System.EventHandler(this.magazineAddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Book Picture";
            // 
            // MagazineImage
            // 
            this.MagazineImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MagazineImage.Image = ((System.Drawing.Image)(resources.GetObject("MagazineImage.Image")));
            this.MagazineImage.Location = new System.Drawing.Point(317, 72);
            this.MagazineImage.Name = "MagazineImage";
            this.MagazineImage.Size = new System.Drawing.Size(227, 210);
            this.MagazineImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MagazineImage.TabIndex = 33;
            this.MagazineImage.TabStop = false;
            this.MagazineImage.Click += new System.EventHandler(this.MagazineImage_Click);
            // 
            // magazinemed
            // 
            this.magazinemed.Location = new System.Drawing.Point(59, 435);
            this.magazinemed.Name = "magazinemed";
            this.magazinemed.Size = new System.Drawing.Size(206, 22);
            this.magazinemed.TabIndex = 32;
            // 
            // bookMEditino
            // 
            this.bookMEditino.AutoSize = true;
            this.bookMEditino.Location = new System.Drawing.Point(65, 416);
            this.bookMEditino.Name = "bookMEditino";
            this.bookMEditino.Size = new System.Drawing.Size(105, 16);
            this.bookMEditino.TabIndex = 31;
            this.bookMEditino.Text = "Maison d\'edition";
            this.bookMEditino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Issue Number";
            // 
            // magazinePrice
            // 
            this.magazinePrice.Location = new System.Drawing.Point(62, 318);
            this.magazinePrice.Name = "magazinePrice";
            this.magazinePrice.Size = new System.Drawing.Size(206, 22);
            this.magazinePrice.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // magazineDescription
            // 
            this.magazineDescription.Location = new System.Drawing.Point(62, 186);
            this.magazineDescription.Name = "magazineDescription";
            this.magazineDescription.Size = new System.Drawing.Size(203, 96);
            this.magazineDescription.TabIndex = 24;
            this.magazineDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // magazineAuthor
            // 
            this.magazineAuthor.Location = new System.Drawing.Point(59, 128);
            this.magazineAuthor.Name = "magazineAuthor";
            this.magazineAuthor.Size = new System.Drawing.Size(206, 22);
            this.magazineAuthor.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Author";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // magazineTitle
            // 
            this.magazineTitle.Location = new System.Drawing.Point(59, 72);
            this.magazineTitle.Name = "magazineTitle";
            this.magazineTitle.Size = new System.Drawing.Size(206, 22);
            this.magazineTitle.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // magazineIsueeN
            // 
            this.magazineIsueeN.Location = new System.Drawing.Point(65, 376);
            this.magazineIsueeN.Name = "magazineIsueeN";
            this.magazineIsueeN.Size = new System.Drawing.Size(206, 22);
            this.magazineIsueeN.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // magazaine_insertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.magazineIsueeN);
            this.Controls.Add(this.ListMagazineBtn);
            this.Controls.Add(this.magazineAddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MagazineImage);
            this.Controls.Add(this.magazinemed);
            this.Controls.Add(this.bookMEditino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.magazinePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.magazineDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.magazineAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magazineTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "magazaine_insertion";
            this.Text = "magazaine_insertion";
            ((System.ComponentModel.ISupportInitialize)(this.MagazineImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListMagazineBtn;
        private System.Windows.Forms.Button magazineAddBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox MagazineImage;
        private System.Windows.Forms.TextBox magazinemed;
        private System.Windows.Forms.Label bookMEditino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox magazinePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox magazineDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox magazineAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox magazineTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox magazineIsueeN;
        private System.Windows.Forms.Button button1;
    }
}