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
    public partial class OrderView : Form
    {
        public OrderView()
        {
            InitializeComponent();
        }
        void populateOrders()
        {
            string cs = ConfigurationManager.ConnectionStrings["A"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders", con);
            var rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Marquee;
            for (int i = 0; i < 10; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageOrder mo = new ManageOrder();
            mo.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
           // e.Graphics.DrawString("OrderId:" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80,100));
            //e.Graphics.DrawString("CustomerId:" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 120));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Indigo;
        }
    }
}
