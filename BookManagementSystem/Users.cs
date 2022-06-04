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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akhan\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();

            sda.Fill(ds);
            UserDGV.EnableHeadersVisualStyles = false;
            UserDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UPhone ='" + PhoneTb.Text + "'", Con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (PhoneTb.Text == "" || Convert.ToInt64(PhoneTb.Text) > 9999999999 || Convert.ToInt64(PhoneTb.Text) < 6000000000)
            {
                MessageBox.Show("Invalid Phone Number");
            }
            else if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "")
            {
                
                MessageBox.Show("MISSING INFORMATION");
            }
            
            else if(Int64.Parse(dt1.Rows[0][0].ToString()) >= 1)
            {
                MessageBox.Show("Seller Already Exists.");
            }
            else
            {
                SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from UserTbl where UPhone ='" + PhoneTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda3.Fill(dt);

                if (Int64.Parse(dt.Rows[0][0].ToString()) >= 1)
                {
                    MessageBox.Show("Seller Already Exists");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "insert into UserTbl values('" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + PassTb.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Saved Successfully");
                        Con.Close();
                        populate();
                        // Reset();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }
            }
        }
        private void Reset()
        {
            UnameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserDGV.CurrentRow.Cells[1].Value.ToString();
            PhoneTb.Text = UserDGV.CurrentRow.Cells[2].Value.ToString();
            AddTb.Text = UserDGV.CurrentRow.Cells[3].Value.ToString();
            PassTb.Text = UserDGV.CurrentRow.Cells[4].Value.ToString();

            if (UnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTbl set UName='" + UnameTb.Text + "',UPhone='" + PhoneTb.Text + "',UAdd='" + AddTb.Text + "',UPass='" + PassTb.Text + "' where UId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Books Obj = new Books();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ChooseMode Obj = new ChooseMode();
            Obj.Show();
            this.Hide();
        }
    }
}
