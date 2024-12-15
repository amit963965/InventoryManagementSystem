using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_project
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        void Run()
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

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            Run();
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Customer", con);
            con.Open();
            var rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerPhone"].Value.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ANL63A9;Initial Catalog=INVENTORYMANAGEMENT;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Orders where CustomerId=" + textBox1.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Orderlabel.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmount) from Orders where CustomerId=" + textBox1.Text + "", con);
            DataTable dt1 = new DataTable();
             sda1.Fill(dt1);
            Oamountlabel.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(Date) from Orders where CustomerId=" + textBox1.Text + "", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Datelabel.Text = dt2.Rows[0][0].ToString();


        }
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into Customer values(@CustomerId,@CustomerName,@CustomerPhone)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@CustomerId", textBox1.Text);
            cmd.Parameters.AddWithValue("@CustomerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@CustomerPhone", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            ManageCustomer_Load(null, null);
            Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string CName = textBox2.Text;
            string CPhone = textBox3.Text;
            string id = textBox1.Text;
            SqlCommand cmd = new SqlCommand("update Customer set CustomerName='" + CName + "',CustomerPhone=" + CPhone + " where CustomerId=" + id, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ManageCustomer_Load(null, null);
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string id = textBox1.Text;
            SqlCommand cmd = new SqlCommand("delete from Customer where CustomerId=" + id, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ManageCustomer_Load(null, null);
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm hm = new HomeForm();
            hm.Show();
            this.Hide();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkGreen;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Indigo;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
