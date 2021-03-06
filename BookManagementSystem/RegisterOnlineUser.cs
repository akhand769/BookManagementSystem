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
using System.Text.RegularExpressions;

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
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (mbbx.Text == "" || Convert.ToInt64(mbbx.Text) > 9999999999 || Convert.ToInt64(mbbx.Text) < 6000000000)
            {
                MessageBox.Show("Invalid Phone Number");
            }
            else
            {
                SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from OnlineUser where email ='" + maibx.Text + "'", Con);
                DataTable dt = new DataTable();
                sda3.Fill(dt);
                if (Int64.Parse(dt.Rows[0][0].ToString()) >=1)
                {
                    MessageBox.Show("User Already Exists");
                }
                else
                {
                    if (!Regex.IsMatch(maibx.Text, pattern))
                    {
                        MessageBox.Show("Invalid Email address ");
                    }
                    else if (Namebx.Text == "" || maibx.Text == "" || dobbx.Text == "" || addbx.Text == "")
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
                   

                    //Do something
                }
                
                
                

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginUser Obj = new LoginUser();
            Obj.Show();
            this.Hide();
        }
    }
}
