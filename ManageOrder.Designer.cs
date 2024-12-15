namespace College_project
{
    partial class ManageOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrder));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label11 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            ProductGV = new DataGridView();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            OrderGV = new DataGridView();
            label8 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            label9 = new Label();
            button4 = new Button();
            button5 = new Button();
            label10 = new Label();
            TotalAmount = new TextBox();
            panel2 = new Panel();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 100);
            panel1.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(932, 0);
            label11.Name = "label11";
            label11.Size = new Size(32, 34);
            label11.TabIndex = 43;
            label11.Text = "X";
            label11.Click += label11_Click;
            label11.MouseLeave += label11_MouseLeave;
            label11.MouseHover += label11_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(408, 60);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 2;
            label2.Text = "MANAGE ORDERS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(131, 6);
            label1.Name = "label1";
            label1.Size = new Size(711, 54);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(95, 82);
            button2.TabIndex = 32;
            button2.Text = "Home";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(108, 119);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 18;
            label3.Text = "CUSTOMER LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Fuchsia;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Cyan;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(73, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox2.ForeColor = Color.Blue;
            textBox2.Location = new Point(181, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(12, 336);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 23;
            label5.Text = "CustomerId";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(181, 433);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(101, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(12, 431);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 25;
            label6.Text = "Order Date";
            // 
            // ProductGV
            // 
            ProductGV.AllowUserToAddRows = false;
            ProductGV.AllowUserToDeleteRows = false;
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.BackgroundColor = Color.LightBlue;
            ProductGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGV.GridColor = Color.Black;
            ProductGV.Location = new Point(409, 149);
            ProductGV.Name = "ProductGV";
            ProductGV.ReadOnly = true;
            ProductGV.RowHeadersVisible = false;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.Size = new Size(524, 150);
            ProductGV.TabIndex = 26;
            ProductGV.CellClick += ProductGV_CellClick_1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DarkKhaki;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(443, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 27;
            comboBox1.Text = "Select Catagory";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Blue;
            textBox3.Location = new Point(625, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(515, 316);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 29;
            label7.Text = "Quantity";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Fuchsia;
            button1.Location = new Point(745, 315);
            button1.Name = "button1";
            button1.Size = new Size(134, 31);
            button1.TabIndex = 30;
            button1.Text = "Add to Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderGV
            // 
            OrderGV.AllowUserToAddRows = false;
            OrderGV.AllowUserToDeleteRows = false;
            OrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGV.BackgroundColor = Color.LightBlue;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.GridColor = Color.Black;
            OrderGV.Location = new Point(409, 352);
            OrderGV.Name = "OrderGV";
            OrderGV.ReadOnly = true;
            OrderGV.RowHeadersVisible = false;
            OrderGV.Size = new Size(524, 150);
            OrderGV.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(12, 384);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 34;
            label8.Text = "CustomerName";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox4.ForeColor = Color.Blue;
            textBox4.Location = new Point(181, 386);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 33;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(593, 109);
            button3.Name = "button3";
            button3.Size = new Size(123, 35);
            button3.TabIndex = 35;
            button3.Text = "All Products";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(656, 505);
            label9.Name = "label9";
            label9.Size = new Size(133, 25);
            label9.TabIndex = 36;
            label9.Text = "Total Amount";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(31, 473);
            button4.Name = "button4";
            button4.Size = new Size(151, 57);
            button4.TabIndex = 38;
            button4.Text = "Insert Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGreen;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(255, 128, 0);
            button5.Location = new Point(188, 473);
            button5.Name = "button5";
            button5.Size = new Size(145, 57);
            button5.TabIndex = 39;
            button5.Text = "Order View";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label10.Location = new Point(795, 505);
            label10.Name = "label10";
            label10.Size = new Size(32, 25);
            label10.TabIndex = 41;
            label10.Text = "Rs";
            // 
            // TotalAmount
            // 
            TotalAmount.BackColor = Color.Yellow;
            TotalAmount.BorderStyle = BorderStyle.None;
            TotalAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TotalAmount.ForeColor = Color.Blue;
            TotalAmount.Location = new Point(833, 505);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(100, 25);
            TotalAmount.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Controls.Add(progressBar1);
            panel2.Location = new Point(1, 551);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 84);
            panel2.TabIndex = 43;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Black;
            progressBar1.Location = new Point(62, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(846, 23);
            progressBar1.TabIndex = 44;
            // 
            // ManageOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(963, 581);
            Controls.Add(panel2);
            Controls.Add(TotalAmount);
            Controls.Add(label10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(OrderGV);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(ProductGV);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrder";
            Load += ManageOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private DataGridView ProductGV;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label7;
        private Button button1;
        private DataGridView OrderGV;
        private Button button2;
        private Label label8;
        private TextBox textBox4;
        private Button button3;
        private Label label9;
        private Button button4;
        private Button button5;
        private Label label10;
        private TextBox TotalAmount;
        private Label label11;
        private Panel panel2;
        private ProgressBar progressBar1;
    }
}