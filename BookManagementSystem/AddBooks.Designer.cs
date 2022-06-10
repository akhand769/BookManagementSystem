namespace BookManagementSystem
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.CatCbSearchCb = new System.Windows.Forms.ComboBox();
            this.booklistlbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.BCatCb = new System.Windows.Forms.ComboBox();
            this.categorieslbl = new System.Windows.Forms.Label();
            this.BauthTb = new System.Windows.Forms.TextBox();
            this.BTitleTb = new System.Windows.Forms.TextBox();
            this.Authorlbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Booktitlelbl = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookDGV
            // 
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.Location = new System.Drawing.Point(24, 485);
            this.BookDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.ReadOnly = true;
            this.BookDGV.RowHeadersWidth = 51;
            this.BookDGV.RowTemplate.Height = 29;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(1058, 531);
            this.BookDGV.TabIndex = 20;
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AutoEllipsis = true;
            this.RefreshBtn.BackColor = System.Drawing.Color.Khaki;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.RefreshBtn.Location = new System.Drawing.Point(669, 418);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(142, 38);
            this.RefreshBtn.TabIndex = 19;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CatCbSearchCb
            // 
            this.CatCbSearchCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatCbSearchCb.FormattingEnabled = true;
            this.CatCbSearchCb.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Math",
            "Physics",
            "Novels",
            "Biography"});
            this.CatCbSearchCb.Location = new System.Drawing.Point(404, 418);
            this.CatCbSearchCb.Margin = new System.Windows.Forms.Padding(2);
            this.CatCbSearchCb.Name = "CatCbSearchCb";
            this.CatCbSearchCb.Size = new System.Drawing.Size(230, 33);
            this.CatCbSearchCb.TabIndex = 18;
            this.CatCbSearchCb.Text = "Filter by Category";
            this.CatCbSearchCb.SelectedIndexChanged += new System.EventHandler(this.CatCbSearchCb_SelectedIndexChanged);
            // 
            // booklistlbl
            // 
            this.booklistlbl.AutoSize = true;
            this.booklistlbl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booklistlbl.Location = new System.Drawing.Point(422, 374);
            this.booklistlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.booklistlbl.Name = "booklistlbl";
            this.booklistlbl.Size = new System.Drawing.Size(119, 32);
            this.booklistlbl.TabIndex = 16;
            this.booklistlbl.Text = "Book List";
            // 
            // EditBtn
            // 
            this.EditBtn.AutoEllipsis = true;
            this.EditBtn.BackColor = System.Drawing.Color.Khaki;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.Black;
            this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.EditBtn.Location = new System.Drawing.Point(296, 292);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditBtn.Size = new System.Drawing.Size(172, 55);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.AutoEllipsis = true;
            this.ResetBtn.BackColor = System.Drawing.Color.Khaki;
            this.ResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ResetBtn.Location = new System.Drawing.Point(759, 298);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(166, 55);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoEllipsis = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Khaki;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.DeleteBtn.Location = new System.Drawing.Point(528, 298);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(170, 55);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoEllipsis = true;
            this.SaveBtn.BackColor = System.Drawing.Color.Khaki;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SaveBtn.Location = new System.Drawing.Point(51, 292);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(181, 55);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(694, 239);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(2);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(150, 31);
            this.QtyTb.TabIndex = 10;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pricelbl.Location = new System.Drawing.Point(862, 188);
            this.Pricelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(77, 32);
            this.Pricelbl.TabIndex = 9;
            this.Pricelbl.Text = "Price";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(862, 239);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(2);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(150, 31);
            this.PriceTb.TabIndex = 11;
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantitylbl.Location = new System.Drawing.Point(694, 188);
            this.quantitylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(124, 32);
            this.quantitylbl.TabIndex = 8;
            this.quantitylbl.Text = "Quantity";
            // 
            // BCatCb
            // 
            this.BCatCb.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCatCb.FormattingEnabled = true;
            this.BCatCb.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Math",
            "Physics",
            "Novels",
            "Biography"});
            this.BCatCb.Location = new System.Drawing.Point(440, 231);
            this.BCatCb.Margin = new System.Windows.Forms.Padding(2);
            this.BCatCb.Name = "BCatCb";
            this.BCatCb.Size = new System.Drawing.Size(230, 33);
            this.BCatCb.TabIndex = 7;
            this.BCatCb.Text = "Select Category";
            // 
            // categorieslbl
            // 
            this.categorieslbl.AutoSize = true;
            this.categorieslbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorieslbl.Location = new System.Drawing.Point(440, 188);
            this.categorieslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categorieslbl.Name = "categorieslbl";
            this.categorieslbl.Size = new System.Drawing.Size(144, 30);
            this.categorieslbl.TabIndex = 6;
            this.categorieslbl.Text = "Categories";
            // 
            // BauthTb
            // 
            this.BauthTb.Location = new System.Drawing.Point(232, 232);
            this.BauthTb.Margin = new System.Windows.Forms.Padding(2);
            this.BauthTb.Name = "BauthTb";
            this.BauthTb.Size = new System.Drawing.Size(179, 31);
            this.BauthTb.TabIndex = 4;
            // 
            // BTitleTb
            // 
            this.BTitleTb.Location = new System.Drawing.Point(24, 232);
            this.BTitleTb.Margin = new System.Windows.Forms.Padding(2);
            this.BTitleTb.Name = "BTitleTb";
            this.BTitleTb.Size = new System.Drawing.Size(185, 31);
            this.BTitleTb.TabIndex = 3;
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Authorlbl.Location = new System.Drawing.Point(232, 186);
            this.Authorlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(98, 32);
            this.Authorlbl.TabIndex = 2;
            this.Authorlbl.Text = "Author";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Booktitlelbl
            // 
            this.Booktitlelbl.AutoSize = true;
            this.Booktitlelbl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Booktitlelbl.Location = new System.Drawing.Point(24, 186);
            this.Booktitlelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Booktitlelbl.Name = "Booktitlelbl";
            this.Booktitlelbl.Size = new System.Drawing.Size(131, 32);
            this.Booktitlelbl.TabIndex = 1;
            this.Booktitlelbl.Text = "Book Title";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(4, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(110, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(71, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Back";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(48, 909);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 58);
            this.panel6.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(25, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 1016);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BookDGV);
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.CatCbSearchCb);
            this.panel2.Controls.Add(this.booklistlbl);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.PriceTb);
            this.panel2.Controls.Add(this.QtyTb);
            this.panel2.Controls.Add(this.Pricelbl);
            this.panel2.Controls.Add(this.quantitylbl);
            this.panel2.Controls.Add(this.BCatCb);
            this.panel2.Controls.Add(this.categorieslbl);
            this.panel2.Controls.Add(this.BauthTb);
            this.panel2.Controls.Add(this.BTitleTb);
            this.panel2.Controls.Add(this.Authorlbl);
            this.panel2.Controls.Add(this.Booktitlelbl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(388, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 1030);
            this.panel2.TabIndex = 5;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView BookDGV;
        private Button RefreshBtn;
        private ComboBox CatCbSearchCb;
        private Label booklistlbl;
        private Button EditBtn;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
        private TextBox QtyTb;
        private Label Pricelbl;
        private TextBox PriceTb;
        private Label quantitylbl;
        private ComboBox BCatCb;
        private Label categorieslbl;
        private TextBox BauthTb;
        private TextBox BTitleTb;
        private Label Authorlbl;
        private PictureBox pictureBox2;
        private Label Booktitlelbl;
        private PictureBox pictureBox6;
        private Label label8;
        private Label label9;
        private Panel panel6;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}