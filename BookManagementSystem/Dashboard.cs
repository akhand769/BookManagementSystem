using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akhan\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(BQty) from BookTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bstlbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Amount) from BillTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            amountlbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(UName) from UserTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            userlbl.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void userlbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Books Obj = new Books();
            Obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            PrintOrder Obj = new PrintOrder();
            Obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ViewOnline Obj = new ViewOnline();
            Obj.Show();
            this.Hide();
        }

        private void amountlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
