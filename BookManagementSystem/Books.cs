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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
      
            populate();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akhan\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void book_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
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
        private void filter()
        {
            Con.Open();
            string query = "select * from BookTbl where BCat='"+CatCbSearchCb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(BTitleTb.Text==""||BauthTb.Text == ""|| QtyTb.Text==""||PriceTb.Text==""||BCatCb.SelectedIndex==-1)
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
                }catch(Exception Ex)
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
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            BTitleTb.Text = BookDGV.CurrentRow.Cells[1].Value.ToString();
            BauthTb.Text = BookDGV.CurrentRow.Cells[2].Value.ToString();
            BCatCb.Text = BookDGV.CurrentRow.Cells[3].Value.ToString();
            QtyTb.Text= BookDGV.CurrentRow.Cells[4].Value.ToString();
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
            if (key==0)
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
                    string query = "update BookTbl set BTitle='"+BTitleTb.Text+"',BAuthor='"+BauthTb.Text+"',BCat='"+BCatCb.SelectedItem.ToString()+"',bQTY='"+QtyTb.Text+"',BPrice='"+PriceTb.Text+"' where  BId="+key+";";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PriceTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BCatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categorieslbl_Click(object sender, EventArgs e)
        {

        }

        private void BauthTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTitleTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authorlbl_Click(object sender, EventArgs e)
        {

        }

        private void Booktitlelbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            ChooseMode Obj = new ChooseMode();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
