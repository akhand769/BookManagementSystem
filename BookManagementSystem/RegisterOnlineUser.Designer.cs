namespace BookManagementSystem
{
    partial class RegisterOnlineUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dobbx = new System.Windows.Forms.DateTimePicker();
            this.maibx = new System.Windows.Forms.TextBox();
            this.addbx = new System.Windows.Forms.TextBox();
            this.mbbx = new System.Windows.Forms.TextBox();
            this.Namebx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Passbx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(460, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(92, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(92, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(63, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Mail -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(93, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address - ";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(500, 681);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(94, 29);
            this.register.TabIndex = 6;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Passbx);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dobbx);
            this.panel1.Controls.Add(this.maibx);
            this.panel1.Controls.Add(this.addbx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mbbx);
            this.panel1.Controls.Add(this.Namebx);
            this.panel1.Location = new System.Drawing.Point(33, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 725);
            this.panel1.TabIndex = 7;
            // 
            // dobbx
            // 
            this.dobbx.Location = new System.Drawing.Point(222, 193);
            this.dobbx.Name = "dobbx";
            this.dobbx.Size = new System.Drawing.Size(250, 27);
            this.dobbx.TabIndex = 5;
            // 
            // maibx
            // 
            this.maibx.Location = new System.Drawing.Point(218, 419);
            this.maibx.Name = "maibx";
            this.maibx.Size = new System.Drawing.Size(259, 27);
            this.maibx.TabIndex = 4;
            // 
            // addbx
            // 
            this.addbx.Location = new System.Drawing.Point(220, 314);
            this.addbx.Multiline = true;
            this.addbx.Name = "addbx";
            this.addbx.Size = new System.Drawing.Size(500, 70);
            this.addbx.TabIndex = 3;
            // 
            // mbbx
            // 
            this.mbbx.Location = new System.Drawing.Point(218, 260);
            this.mbbx.Name = "mbbx";
            this.mbbx.Size = new System.Drawing.Size(259, 27);
            this.mbbx.TabIndex = 2;
            // 
            // Namebx
            // 
            this.Namebx.Location = new System.Drawing.Point(220, 128);
            this.Namebx.Name = "Namebx";
            this.Namebx.Size = new System.Drawing.Size(500, 27);
            this.Namebx.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(58, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password -";
            // 
            // Passbx
            // 
            this.Passbx.Location = new System.Drawing.Point(222, 473);
            this.Passbx.Name = "Passbx";
            this.Passbx.Size = new System.Drawing.Size(259, 27);
            this.Passbx.TabIndex = 7;
            // 
            // RegisterOnlineUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1094, 774);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterOnlineUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterOnlineUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button register;
        private Panel panel1;
        private TextBox maibx;
        private TextBox addbx;
        private TextBox mbbx;
        private TextBox Namebx;
        private DateTimePicker dobbx;
        private TextBox Passbx;
        private Label label7;
    }
}