using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookManagementSystem
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }
        public static string UserName = "";
        private void label4_Click(object sender, EventArgs e)
        {
            ChooseMode Obj = new ChooseMode();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akhan\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OnlineUser where email ='" + Uname.Text + "' and Password='" + UPass.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Int64.Parse(dt.Rows[0][0].ToString())>=1)
            {
                UserName = Uname.Text;
                BookOrder Obj = new BookOrder();
                Obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
            }
            Con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterOnlineUser Obj = new RegisterOnlineUser();
            Obj.Show();
            this.Hide();
        }

        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
