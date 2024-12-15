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
using System.Configuration;


namespace College_project
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        public void CON()
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into Users values(@UName,@UFullName,@UPassword,@UMobile)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@UName", textBox1.Text);
            cmd.Parameters.AddWithValue("@UFullName", textBox2.Text);
            cmd.Parameters.AddWithValue("@UPassword", textBox3.Text);
            cmd.Parameters.AddWithValue("@UMobile", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            CON();
            ManageUser_Load(null, null);
            Clear();

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

        private void ManageUser_Load(object sender, EventArgs e)
        {
           // Run();
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            con.Open();
            var rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string UName = textBox1.Text;
            string UFullName = textBox2.Text;
            string UPassword = textBox3.Text;
            string UPhone =  textBox4.Text;

            SqlCommand cmd = new SqlCommand("update Users set UName='" + UName + "',UFullName='" + UFullName + "',UPassword='" + UPassword + "',UPhone=" + UPhone + " where UPhone=" +UPhone, con);

            con.Open();
                    cmd.ExecuteNonQuery();
           
            ManageUser_Load(null, null);
            con.Close();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string UPhone = textBox4.Text;
            SqlCommand cmd = new SqlCommand("delete from Users where UPhone=" + UPhone, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ManageUser_Load(null, null);
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("you select an invalid row");
                Clear();
            }
            else{
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["UName"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["UFullName"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["UPassword"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["UPhone"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm hm = new HomeForm();
            hm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.Red;

        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Indigo;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Size = new Size(100, 95);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(93, 89);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
        }
    }
}
