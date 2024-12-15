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
    public partial class ManageCatagory : Form
    {
        public ManageCatagory()
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

        private void ManageCatagory_Load(object sender, EventArgs e)
        {
            Run();
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Catagories", con);
            con.Open();
            var rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into Catagories values(@CatagoriesId,@CatagoriesName)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@CatagoriesId", textBox1.Text);
            cmd.Parameters.AddWithValue("@CatagoriesName", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            ManageCatagory_Load(null, null);
            Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string id = textBox1.Text;
            string Name = textBox2.Text;
            SqlCommand cmd = new SqlCommand("update Catagories set CatagoriesId=" + id + ",CatagoriesName='" + Name + "' where CatagoriesId=" + id, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ManageCatagory_Load(null, null);
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string id = textBox1.Text;
            SqlCommand cmd = new SqlCommand("delete from Catagories where CatagoriesId=" + id, con);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
            ManageCatagory_Load(null, null);
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Please Select Correct Value");
            }
            else
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["CatagoriesId"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["CatagoriesName"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm hm = new HomeForm();
            hm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Indigo;
        }
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
