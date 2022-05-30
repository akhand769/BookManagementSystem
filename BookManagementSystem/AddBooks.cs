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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akhan\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();

            sda.Fill(ds);
            BookDGV.EnableHeadersVisualStyles = false;
            BookDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        int key = 0;
        private void filter()
        {
            Con.Open();
            string query = "select * from BookTbl where BCat='" + CatCbSearchCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.CurrentRow.Cells[1].Value.ToString();
            BauthTb.Text = BookDGV.CurrentRow.Cells[2].Value.ToString();
            BCatCb.Text = BookDGV.CurrentRow.Cells[3].Value.ToString();
            QtyTb.Text = BookDGV.CurrentRow.Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.CurrentRow.Cells[5].Value.ToString();
            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.CurrentRow.Cells[0].Value.ToString());
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
                    string query = "delete from BookTbl where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfully");
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
            if (BTitleTb.Text == "" || BauthTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update BookTbl set BTitle='" + BTitleTb.Text + "',BAuthor='" + BauthTb.Text + "',BCat='" + BCatCb.SelectedItem.ToString() + "',bQTY='" + QtyTb.Text + "',BPrice='" + PriceTb.Text + "' where  BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully");
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BauthTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTbl values('" + BTitleTb.Text + "','" + BauthTb.Text + "','" + BCatCb.SelectedItem.ToString() + "','" + QtyTb.Text + "','" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
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

        private void CatCbSearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
        }
        private void Reset()
        {
            BTitleTb.Text = "";
            BauthTb.Text = "";
            BCatCb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
            CatCbSearchCb.SelectedItem = null;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }
    }
}
