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
    
    public partial class Billing : Form
    {
        int n = 0;
        static int GrndTotal = 0;
        public Billing()
        {
            InitializeComponent();
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        int key = 0,stock=0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Bid.Text = BookDGV.CurrentRow.Cells[0].Value.ToString();
            BNameTb.Text = BookDGV.CurrentRow.Cells[1].Value.ToString();
            PriceTb.Text = BookDGV.CurrentRow.Cells[5].Value.ToString();
            if (BNameTb.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.CurrentRow.Cells[0].Value.ToString());
                stock = Convert.ToInt32(BookDGV.CurrentRow.Cells[4].Value.ToString());
            }
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
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
                try
                {
                    Con.Open();
                    string query = "update BookTbl set BQTY='" + newQty + "' where  BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Book Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                if(Convert.ToInt32(row.Cells["Column1"].Value)==Convert.ToInt32(Bid.Text))
                {
                    flag = 1;
                    break;
                }

            }
            if (flag == 1)
            {
                MessageBox.Show("Already added");
            }
            else
            {
                if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > stock)
                {
                    MessageBox.Show("No Enough Stock");
                }
                else
                {
                    int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(BillDGV);
                    newRow.Cells[0].Value = Bid.Text;
                    newRow.Cells[1].Value = BNameTb.Text;
                    newRow.Cells[2].Value = PriceTb.Text;
                    newRow.Cells[3].Value = QtyTb.Text;
                    newRow.Cells[4].Value = total;
                    BillDGV.Rows.Add(newRow);
                    n++;
                    GrndTotal = GrndTotal + total;
                    int p = GrndTotal;
                    TotalLbl.Text = "Rs  " + p.ToString();
                    UpdateBook();


                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            
            if (ClientTb.Text == "" || BNameTb.Text == "" )
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }

                try
                {
                   
                   
                    Reset();
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;

        private void Billing_Load(object sender, EventArgs e)
        {
            usernamelbl.Text = Login.UserName;

        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            AddBooks Obj = new AddBooks();
            Obj.Show();
            this.Hide();
        }

        private void ClientTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void RmBtn_Click(object sender, EventArgs e)
        {
           
                int quantity=0;
            
            string value;
            if (BillDGV.Rows.Count > 1)
            {
                int rowIndex = BillDGV.CurrentCell.RowIndex;
                value = BillDGV.Rows[rowIndex].Cells[3].Value.ToString();
                quantity = Convert.ToInt32(value);
               
                String id = BillDGV.Rows[rowIndex].Cells[0].Value.ToString();
                
                BillDGV.Rows.RemoveAt(rowIndex);
               
                try
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select BQty from BookTbl where BId='" + Convert.ToInt32(id) + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int sum = Convert.ToInt32(dt.Rows[0][0].ToString()) + quantity;

                    string query = "update BookTbl set BQTY='" + sum + "' where  BId='" + id + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cart Empty");
            }
                 
            
        }

        private void Booktitlelbl_Click(object sender, EventArgs e)
        {

        }

        private void Authorlbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        string prodname ="Null";
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID  PRODUCT  PRICE  QUANTITY  TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(20, 40));
            foreach(DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(20, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(42, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(122, pos), new StringFormat());
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos), new StringFormat());
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos), new StringFormat());
                pos += 25;

            }
            Con.Open();
            if (BNameTb.Text == "")
            {
                MessageBox.Show("Null");
            }
            //int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);

            //GrndTotal = GrndTotal + total;
            String str = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");

            string query = "insert into BillTbl values('" + BNameTb.Text + "','" + ClientTb.Text + "','" + GrndTotal + "','" + str + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bill Saved Successfully");
            Con.Close();
            e.Graphics.DrawString("Grand Total : RS" + GrndTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("**********BookStore**********" , new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            TotalLbl.Text = "Total";
            GrndTotal = 0;
            pos = 60;


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            Bid.Text = "";
            BNameTb.Text = "";
            QtyTb.Text = "";
            ClientTb.Text = "";
            PriceTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            GrndTotal = 0;
            TotalLbl.Text = "Total";
        }
    }
}
