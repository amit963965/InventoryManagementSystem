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
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
        }
        void populate()
        {
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
        void populateProduct()
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Products", con);
            con.Open();
            var rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            ProductGV.DataSource = dt;
            con.Close();

        }
        void SelectCatagory()
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Catagories", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatagoriesName", typeof(string));
            var rd = cmd.ExecuteReader();
            dt.Load(rd);
            comboBox1.ValueMember = "CatagoriesName";
            comboBox1.DataSource = dt;
            con.Close();
        }
        void Running()
        {
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.ForeColor = Color.AliceBlue;
            for (int i = 0;i<10;i++)
            {
                progressBar1.Value = i;
            }
        }




        private void ManageOrder_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            populate();
            populateProduct();
            SelectCatagory();
            table.Columns.Add("num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("quantity", typeof(int));
            table.Columns.Add("Unit Price", typeof(int));
            table.Columns.Add("Total Price", typeof(int));
            OrderGV.DataSource = table;
            Running();
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1)
            {
                return;
                

            }
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
        }

        void display_datagrid()
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Products where Catagories='" + comboBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            ProductGV.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_datagrid();
        }


        int flag = 0;
        int stock;
        int Num = 0;
        int Uprice, TotalPrice, Qty;
        string? product;
        DataTable table = new DataTable();


        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (textBox3.Text == "") { MessageBox.Show("enter the quantity of products"); }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(textBox3.Text) > stock)
            {
                MessageBox.Show("No enough available stock");
            }
            else
            {
                Num = Num + 1;
                Qty = Convert.ToInt32(textBox3.Text);
                TotalPrice = Qty * Uprice;
                table.Rows.Add(Num, product, Qty, Uprice, TotalPrice);
                OrderGV.DataSource = table;
                flag = 0;
               


            }
            sum = sum + TotalPrice;
            TotalAmount.Text = sum.ToString();
            UpdateProd();



        }
        void UpdateProd()
        {
            int newQty = stock - Convert.ToInt32(textBox3.Text);
            int ProductId = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
            if (newQty < 0)
            {
                MessageBox.Show("enter stock valid");
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("update Products set ProductQty=" + newQty + " where ProductId=" + ProductId, con);
                cmd.ExecuteNonQuery();
                con.Close();
                populateProduct();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.Show();
            this.Hide();
        }

        private void ProductGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                product = ProductGV.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                stock = Convert.ToInt32(ProductGV.Rows[e.RowIndex].Cells["ProductQty"].Value.ToString());
                Uprice = Convert.ToInt32(ProductGV.Rows[e.RowIndex].Cells["ProductPrice"].Value.ToString());
                flag = 1;
            }
        }
        void Clear()
        {
           // textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populate();
            populateProduct();
            comboBox1.Text = "";
            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderView vo = new OrderView();
            vo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( textBox2.Text == "" || textBox4.Text == "" || TotalAmount.Text == "")
            {
                MessageBox.Show(" enter product");
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Orders values(@CustomerId,@CustomerName,@Date,@TotalAmount)", con);
               // cmd.Parameters.AddWithValue("@OrderId", textBox1.Text);
                cmd.Parameters.AddWithValue("@CustomerId", textBox2.Text);
                cmd.Parameters.AddWithValue("@CustomerName", textBox4.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("order added succesfully");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            label11.BackColor = Color.Red;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.Indigo;
        }
        
       
        
    }
}
