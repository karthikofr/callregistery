using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OfrCallRegistery
{
    public partial class Customer : UserControl
    {
        private static Customer _instance;
        public static Customer Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Customer();
                return _instance;

            }
        }
        SqlConnection con = new SqlConnection(@"Server =ADMIN3-PC\SQLEXPRESS;Database=OfrCallRegistery;UID=sa;Password=Karthik@12345");
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            data();
            data2();
            data3();
            data4();
            data5();
            data6();
            data7();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Hide();
        
        }
        private void data()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where CustomerType like 'Customer'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView1.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label3.Text = "Total Entries :  " + ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads


        }
        private void data2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where CustomerType like 'Customer' and EmployeeName like 'Akshay'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView2.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label5.Text =  ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads


        }
        private void data3()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where CustomerType like 'Customer' and EmployeeName like 'Deepika'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView3.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label7.Text = ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads


        }
        private void data4()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where CustomerType like 'Customer' and EmployeeName like 'Lavanya P'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView3.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label9.Text = ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads


        }
        private void data5()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where CustomerType like 'Customer' and EmployeeName like 'Lekha'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView3.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label11.Text =  ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads


        }
        private void data6()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where CustomerType like 'Customer' and EmployeeName like 'Shilpa'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView3.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label13.Text =  ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads


        }
        private void data7()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where CustomerType like 'Customer' and EmployeeName like 'Sujith'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView3.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label15.Text = ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads


        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            data();
            data2();
            data3();
            data4();
            data5();
            data6();
            data7();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            data();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.PeachPuff;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
             pictureBox2.BackColor = Color.DimGray;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.PeachPuff;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DimGray;
        }
    }
}
