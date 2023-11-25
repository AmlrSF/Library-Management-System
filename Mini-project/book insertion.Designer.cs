namespace Mini_project
{
    partial class book_insertion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_insertion));
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.bookAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookDescription = new System.Windows.Forms.RichTextBox();
            this.bookPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BookGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookpage = new System.Windows.Forms.TextBox();
            this.bookNbPage = new System.Windows.Forms.Label();
            this.bookmed = new System.Windows.Forms.TextBox();
            this.bookMEditino = new System.Windows.Forms.Label();
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BookAddBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(47, 63);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(206, 22);
            this.bookTitle.TabIndex = 1;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Location = new System.Drawing.Point(47, 119);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(206, 22);
            this.bookAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // bookDescription
            // 
            this.bookDescription.Location = new System.Drawing.Point(50, 177);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(203, 96);
            this.bookDescription.TabIndex = 5;
            this.bookDescription.Text = "";
            // 
            // bookPrice
            // 
            this.bookPrice.Location = new System.Drawing.Point(50, 309);
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.Size = new System.Drawing.Size(206, 22);
            this.bookPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookGenre
            // 
            this.BookGenre.FormattingEnabled = true;
            this.BookGenre.Items.AddRange(new object[] {
            "Mystery/Thriller",
            "Science Fiction",
            "Romance",
            "Fantasy",
            "Historical Fiction"});
            this.BookGenre.Location = new System.Drawing.Point(50, 367);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.Size = new System.Drawing.Size(206, 24);
            this.BookGenre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genre";
            // 
            // bookpage
            // 
            this.bookpage.Location = new System.Drawing.Point(50, 426);
            this.bookpage.Name = "bookpage";
            this.bookpage.Size = new System.Drawing.Size(206, 22);
            this.bookpage.TabIndex = 11;
            // 
            // bookNbPage
            // 
            this.bookNbPage.AutoSize = true;
            this.bookNbPage.Location = new System.Drawing.Point(47, 407);
            this.bookNbPage.Name = "bookNbPage";
            this.bookNbPage.Size = new System.Drawing.Size(117, 16);
            this.bookNbPage.TabIndex = 10;
            this.bookNbPage.Text = "Nombre de pages";
            this.bookNbPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookmed
            // 
            this.bookmed.Location = new System.Drawing.Point(53, 485);
            this.bookmed.Name = "bookmed";
            this.bookmed.Size = new System.Drawing.Size(206, 22);
            this.bookmed.TabIndex = 13;
            // 
            // bookMEditino
            // 
            this.bookMEditino.AutoSize = true;
            this.bookMEditino.Location = new System.Drawing.Point(50, 466);
            this.bookMEditino.Name = "bookMEditino";
            this.bookMEditino.Size = new System.Drawing.Size(105, 16);
            this.bookMEditino.TabIndex = 12;
            this.bookMEditino.Text = "Maison d\'edition";
            this.bookMEditino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookImage
            // 
            this.bookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookImage.Image = ((System.Drawing.Image)(resources.GetObject("bookImage.Image")));
            this.bookImage.Location = new System.Drawing.Point(305, 63);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(227, 227);
            this.bookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookImage.TabIndex = 14;
            this.bookImage.TabStop = false;
            this.bookImage.Click += new System.EventHandler(this.bookImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Book Picture";
            // 
            // BookAddBtn
            // 
            this.BookAddBtn.Location = new System.Drawing.Point(305, 309);
            this.BookAddBtn.Name = "BookAddBtn";
            this.BookAddBtn.Size = new System.Drawing.Size(227, 41);
            this.BookAddBtn.TabIndex = 16;
            this.BookAddBtn.Text = "Add Book";
            this.BookAddBtn.UseVisualStyleBackColor = true;
            this.BookAddBtn.Click += new System.EventHandler(this.BookAddBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search for book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "List of books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // book_insertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookAddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookImage);
            this.Controls.Add(this.bookmed);
            this.Controls.Add(this.bookMEditino);
            this.Controls.Add(this.bookpage);
            this.Controls.Add(this.bookNbPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BookGenre);
            this.Controls.Add(this.bookPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.label1);
            this.Name = "book_insertion";
            this.Text = "book_insertion";
            //this.Load += new System.EventHandler(this.book_insertion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.TextBox bookAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox bookDescription;
        private System.Windows.Forms.TextBox bookPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BookGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookpage;
        private System.Windows.Forms.Label bookNbPage;
        private System.Windows.Forms.TextBox bookmed;
        private System.Windows.Forms.Label bookMEditino;
        private System.Windows.Forms.PictureBox bookImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BookAddBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}