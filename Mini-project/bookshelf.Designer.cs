namespace Mini_project
{
    partial class bookshelf
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPanelDocs = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.FlowLayoutPanel();
            this.total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Size = new System.Drawing.Size(1195, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Documents";
            // 
            // flowPanelDocs
            // 
            this.flowPanelDocs.Location = new System.Drawing.Point(13, 134);
            this.flowPanelDocs.Name = "flowPanelDocs";
            this.flowPanelDocs.Size = new System.Drawing.Size(777, 530);
            this.flowPanelDocs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(809, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total  :";
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(816, 134);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(367, 530);
            this.Cart.TabIndex = 5;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(957, 81);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(30, 32);
            this.total.TabIndex = 6;
            this.total.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Browse our store, you can find difference docs like books , magazine feel free to" +
    " choose";
            // 
            // bookshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowPanelDocs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bookshelf";
            this.Text = "bookshelf";
            this.Load += new System.EventHandler(this.bookshelf_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelDocs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel Cart;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label3;
    }
}