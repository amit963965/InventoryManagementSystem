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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        void fillCatagories()
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Catagories", con);
            con.Open();
            var rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatagoriesName", typeof(string));
            dt.Load(rd);
            comboBox1.ValueMember = "CatagoriesName";
            comboBox1.DataSource = dt;
            con.Close();
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




        private void ManageProducts_Load(object sender, EventArgs e)
        {
            Run();
            fillCatagories();
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Products", con);
            con.Open();
            var rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANL63A9;Initial Catalog=INVENTORYMANAGEMENT;Integrated Security=True;Encrypt=False");
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into Products values('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + int.Parse(textBox3.Text) + "','" + int.Parse(textBox4.Text) + "','" + textBox5.Text + "','" + comboBox1.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ManageProducts_Load(null, null);
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string id = textBox1.Text;
            string Name = textBox2.Text;
            string Qty = textBox3.Text;
            string Price = textBox4.Text;
            string Desc = textBox5.Text;
            string cmb = comboBox1.Text;
            SqlCommand cmd = new SqlCommand("update Products set ProductId=" + id + ",ProductName='" + Name + "',ProductQty=" + Qty + ",ProductPrice=" + Price + ",Description='" + Desc + "',Catagories='" + comboBox1.Text + "' where ProductId=" + id, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ManageProducts_Load(null, null);
            Clear();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Please Select A valid ROW");
                Clear();
            }
            else
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductQty"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Catagories"].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string id = textBox1.Text;
            SqlCommand cmd = new SqlCommand("delete from Products where ProductId=" + id, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ManageProducts_Load(null, null);
            Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm hm = new HomeForm();
            hm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.BackColor = Color.Red;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.Indigo;
        }
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button1.BackColor = Color.Aqua;
            button1.ForeColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = Color.Aquamarine;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
            button3.BackColor = Color.Aqua;
            button3.ForeColor = Color.Green;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
            button2.BackColor = Color.Blue;
            button3.Visible = false;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Aquamarine;
            button2.BackColor = Color.DarkGreen;
            button3.Visible = true;
        }

       
    }
}
