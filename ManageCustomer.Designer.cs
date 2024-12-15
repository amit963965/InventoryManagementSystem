namespace College_project
{
    partial class ManageCustomer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Orderlabel = new Label();
            label6 = new Label();
            panel3 = new Panel();
            Oamountlabel = new Label();
            label10 = new Label();
            panel4 = new Panel();
            Datelabel = new Label();
            label12 = new Label();
            progressBar1 = new ProgressBar();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 106);
            label7.Name = "label7";
            label7.Size = new Size(177, 32);
            label7.TabIndex = 30;
            label7.Text = " Customer List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(43, 232);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 28;
            label5.Text = "Customer Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(43, 191);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 27;
            label4.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(43, 145);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 26;
            label3.Text = "Customer Id";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Green;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Fuchsia;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(357, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(298, 171);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(716, 106);
            button4.Name = "button4";
            button4.Size = new Size(85, 62);
            button4.TabIndex = 24;
            button4.Text = "Home";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button3.ForeColor = Color.Orange;
            button3.Location = new Point(100, 331);
            button3.Name = "button3";
            button3.Size = new Size(96, 38);
            button3.TabIndex = 23;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.Orange;
            button2.Location = new Point(193, 280);
            button2.Name = "button2";
            button2.Size = new Size(92, 45);
            button2.TabIndex = 22;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(33, 280);
            button1.Name = "button1";
            button1.Size = new Size(79, 45);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox3.ForeColor = Color.Blue;
            textBox3.Location = new Point(204, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox2.ForeColor = Color.Blue;
            textBox2.Location = new Point(204, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(204, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 102);
            panel1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(778, 0);
            label8.Name = "label8";
            label8.Size = new Size(26, 27);
            label8.TabIndex = 34;
            label8.Text = "X";
            label8.Click += label8_Click;
            label8.MouseLeave += label8_MouseLeave;
            label8.MouseHover += label8_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(269, 54);
            label2.Name = "label2";
            label2.Size = new Size(255, 32);
            label2.TabIndex = 2;
            label2.Text = "MANAGE CUSTOMER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(78, 3);
            label1.Name = "label1";
            label1.Size = new Size(675, 51);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(Orderlabel);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(53, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 87);
            panel2.TabIndex = 31;
            // 
            // Orderlabel
            // 
            Orderlabel.AutoSize = true;
            Orderlabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orderlabel.ForeColor = Color.Fuchsia;
            Orderlabel.Location = new Point(43, 31);
            Orderlabel.Name = "Orderlabel";
            Orderlabel.Size = new Size(78, 30);
            Orderlabel.TabIndex = 1;
            Orderlabel.Text = "Orders";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 9);
            label6.Name = "label6";
            label6.Size = new Size(84, 17);
            label6.TabIndex = 0;
            label6.Text = "Order Count";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(Oamountlabel);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(310, 400);
            panel3.Name = "panel3";
            panel3.Size = new Size(169, 87);
            panel3.TabIndex = 32;
            // 
            // Oamountlabel
            // 
            Oamountlabel.AutoSize = true;
            Oamountlabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Oamountlabel.ForeColor = Color.Lime;
            Oamountlabel.Location = new Point(33, 31);
            Oamountlabel.Name = "Oamountlabel";
            Oamountlabel.Size = new Size(94, 30);
            Oamountlabel.TabIndex = 1;
            Oamountlabel.Text = "Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 9);
            label10.Name = "label10";
            label10.Size = new Size(97, 17);
            label10.TabIndex = 0;
            label10.Text = "Order Amount";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkViolet;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(Datelabel);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(578, 400);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 87);
            panel4.TabIndex = 33;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Datelabel.ForeColor = Color.Aqua;
            Datelabel.Location = new Point(57, 31);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(58, 30);
            Datelabel.TabIndex = 1;
            Datelabel.Text = "Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 9);
            label12.Name = "label12";
            label12.Size = new Size(105, 17);
            label12.TabIndex = 0;
            label12.Text = "Last Order Date";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(667, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 34;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Indigo;
            panel5.Controls.Add(progressBar1);
            panel5.Location = new Point(-3, 510);
            panel5.Name = "panel5";
            panel5.Size = new Size(804, 88);
            panel5.TabIndex = 35;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 542);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomer";
            Load += ManageCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label Orderlabel;
        private Label label6;
        private Panel panel3;
        private Label Oamountlabel;
        private Label label10;
        private Panel panel4;
        private Label Datelabel;
        private Label label12;
        private Label label8;
        private ProgressBar progressBar1;
        private Panel panel5;
    }
}