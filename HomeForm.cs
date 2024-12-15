using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_project
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageProducts mp = new ManageProducts();
            mp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageCatagory manageCatagory = new ManageCatagory();
            manageCatagory.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManageCustomer mc = new ManageCustomer();
            mc.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageOrder mo = new ManageOrder();
            mo.Show();
            this.Hide();
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            ManageCatagory mc = new ManageCatagory();
            mc.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            ManageCustomer mc = new ManageCustomer();
            mc.Show();
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            ManageOrder mo = new ManageOrder();
            mo.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.Red;

        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.Indigo;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {


            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Marquee;
            for (int i = 0; i < 10; i++)
            {
                progressBar1.Value = i;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
