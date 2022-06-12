namespace BookManagementSystem
{
    partial class BookOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Booktitlelbl = new System.Windows.Forms.Label();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.booklistlbl = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Authorlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Bid = new System.Windows.Forms.TextBox();
            this.RmBtn = new System.Windows.Forms.Button();
            this.Bookname = new System.Windows.Forms.TextBox();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(390, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Your Cart";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PriceTb
            // 
            this.PriceTb.Enabled = false;
            this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceTb.Location = new System.Drawing.Point(560, 241);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(2);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(100, 32);
            this.PriceTb.TabIndex = 24;
            this.PriceTb.TextChanged += new System.EventHandler(this.PriceTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(560, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Books";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamelbl.Location = new System.Drawing.Point(88, 62);
            this.usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(151, 32);
            this.usernamelbl.TabIndex = 28;
            this.usernamelbl.Text = "User Name";
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalLbl.Location = new System.Drawing.Point(1104, 906);
            this.TotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(89, 45);
            this.TotalLbl.TabIndex = 27;
            this.TotalLbl.Text = "Total";
            this.TotalLbl.Click += new System.EventHandler(this.TotalLbl_Click);
            // 
            // BillDGV
            // 
            this.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BillDGV.GridColor = System.Drawing.Color.White;
            this.BillDGV.Location = new System.Drawing.Point(55, 411);
            this.BillDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BillDGV.RowHeadersWidth = 51;
            this.BillDGV.RowTemplate.Height = 29;
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(910, 278);
            this.BillDGV.TabIndex = 26;
            this.BillDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDGV_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(22, 914);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 64);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(2, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(85, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(95, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Logout";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 0;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Shop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 1057);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(81, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Booktitlelbl
            // 
            this.Booktitlelbl.AutoSize = true;
            this.Booktitlelbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Booktitlelbl.Location = new System.Drawing.Point(183, 203);
            this.Booktitlelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Booktitlelbl.Name = "Booktitlelbl";
            this.Booktitlelbl.Size = new System.Drawing.Size(137, 25);
            this.Booktitlelbl.TabIndex = 1;
            this.Booktitlelbl.Text = "Book Name";
            this.Booktitlelbl.Click += new System.EventHandler(this.Booktitlelbl_Click);
            // 
            // BookDGV
            // 
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.BackgroundColor = System.Drawing.Color.White;
            this.BookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookDGV.CausesValidation = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.BookDGV.Location = new System.Drawing.Point(55, 771);
            this.BookDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.ReadOnly = true;
            this.BookDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.BookDGV.RowTemplate.Height = 29;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(973, 271);
            this.BookDGV.TabIndex = 20;
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick_1);
            // 
            // booklistlbl
            // 
            this.booklistlbl.AutoSize = true;
            this.booklistlbl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booklistlbl.Location = new System.Drawing.Point(457, 716);
            this.booklistlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.booklistlbl.Name = "booklistlbl";
            this.booklistlbl.Size = new System.Drawing.Size(119, 32);
            this.booklistlbl.TabIndex = 16;
            this.booklistlbl.Text = "Book List";
            this.booklistlbl.Click += new System.EventHandler(this.booklistlbl_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.AutoEllipsis = true;
            this.PrintBtn.BackColor = System.Drawing.Color.Khaki;
            this.PrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintBtn.ForeColor = System.Drawing.Color.Black;
            this.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.PrintBtn.Location = new System.Drawing.Point(1075, 969);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrintBtn.Size = new System.Drawing.Size(172, 38);
            this.PrintBtn.TabIndex = 15;
            this.PrintBtn.Text = "Place Order";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.AutoEllipsis = true;
            this.ResetBtn.BackColor = System.Drawing.Color.Khaki;
            this.ResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ResetBtn.Location = new System.Drawing.Point(994, 237);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(139, 38);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoEllipsis = true;
            this.SaveBtn.BackColor = System.Drawing.Color.Khaki;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SaveBtn.Location = new System.Drawing.Point(740, 237);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(197, 39);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Add To Cart";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Authorlbl.Location = new System.Drawing.Point(402, 205);
            this.Authorlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(105, 25);
            this.Authorlbl.TabIndex = 2;
            this.Authorlbl.Text = "Quantity";
            this.Authorlbl.Click += new System.EventHandler(this.Authorlbl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Bid);
            this.panel2.Controls.Add(this.RmBtn);
            this.panel2.Controls.Add(this.Bookname);
            this.panel2.Controls.Add(this.QtyTb);
            this.panel2.Controls.Add(this.usernamelbl);
            this.panel2.Controls.Add(this.TotalLbl);
            this.panel2.Controls.Add(this.BillDGV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PriceTb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BookDGV);
            this.panel2.Controls.Add(this.booklistlbl);
            this.panel2.Controls.Add(this.PrintBtn);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.Authorlbl);
            this.panel2.Controls.Add(this.Booktitlelbl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(269, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 1057);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(55, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Bid";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Bid
            // 
            this.Bid.Enabled = false;
            this.Bid.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bid.Location = new System.Drawing.Point(55, 241);
            this.Bid.Margin = new System.Windows.Forms.Padding(4);
            this.Bid.Name = "Bid";
            this.Bid.Size = new System.Drawing.Size(91, 32);
            this.Bid.TabIndex = 34;
            this.Bid.TextChanged += new System.EventHandler(this.Bid_TextChanged);
            // 
            // RmBtn
            // 
            this.RmBtn.BackColor = System.Drawing.Color.Khaki;
            this.RmBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RmBtn.Location = new System.Drawing.Point(754, 301);
            this.RmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RmBtn.Name = "RmBtn";
            this.RmBtn.Size = new System.Drawing.Size(379, 40);
            this.RmBtn.TabIndex = 33;
            this.RmBtn.Text = "Remove from Cart";
            this.RmBtn.UseVisualStyleBackColor = false;
            this.RmBtn.Click += new System.EventHandler(this.RmBtn_Click);
            // 
            // Bookname
            // 
            this.Bookname.Enabled = false;
            this.Bookname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bookname.Location = new System.Drawing.Point(183, 244);
            this.Bookname.Margin = new System.Windows.Forms.Padding(4);
            this.Bookname.Name = "Bookname";
            this.Bookname.Size = new System.Drawing.Size(182, 32);
            this.Bookname.TabIndex = 30;
            this.Bookname.TextChanged += new System.EventHandler(this.Bookname_TextChanged);
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyTb.Location = new System.Drawing.Point(418, 241);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(89, 32);
            this.QtyTb.TabIndex = 29;
            this.QtyTb.TextChanged += new System.EventHandler(this.QtyTb_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // BookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1548, 1079);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookOrder";
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label4;
        private TextBox PriceTb;
        private Label label3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Label usernamelbl;
        private Label TotalLbl;
        private DataGridView BillDGV;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label Booktitlelbl;
        private DataGridView BookDGV;
        private Label booklistlbl;
        private Button PrintBtn;
        private Button ResetBtn;
        private Button SaveBtn;
        private Label Authorlbl;
        private Panel panel2;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox QtyTb;
        private TextBox Bookname;
        private Button RmBtn;
        private Label label7;
        private TextBox Bid;
    }
}