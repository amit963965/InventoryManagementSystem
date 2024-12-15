using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace College_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from  Users where UName='" + textBox1.Text + "' and UPassword='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            var rd = cmd.ExecuteReader();
            dt.Load(rd);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm cust = new HomeForm();
                cust.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter valid username or password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void X_MouseHover(object sender, EventArgs e)
        {


            X.BackColor = Color.Red;
            X.ForeColor = Color.White;

        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = Color.Green;
            X.ForeColor = Color.Black;
        }
    }
}
