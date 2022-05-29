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
    public partial class RegisterOnlineUser : Form
    {
        public RegisterOnlineUser()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akhan\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void button1_Click(object sender, EventArgs e)
        {
            if( mbbx.Text == ""||Convert.ToInt64(mbbx.Text)>9999999999|| Convert.ToInt64(mbbx.Text) < 6000000000 )
            {
                MessageBox.Show("Invalid Phone Number");
            }
            else if(Namebx.Text==""||maibx.Text==""||dobbx.Text==""||addbx.Text=="")
            {
                MessageBox.Show("All fields are mandatory to Fill");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into OnlineUser values('" + Namebx.Text + "','" + dobbx.Text + "','" + maibx.Text + "','" + mbbx.Text + "','" + addbx.Text + "','" + Passbx.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Succesfully");
                    Con.Close();
                    LoginUser Obj = new LoginUser();
                    Obj.Show();
                    this.Hide();
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
