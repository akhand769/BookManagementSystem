using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UPassTb.Text=="Password")
            {
                Books Obj = new Books();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password - Contact the Admin");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChooseMode Obj = new ChooseMode();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
