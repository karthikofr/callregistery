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
    public partial class Deepika : UserControl
    {


        private static Deepika _instance;
        public static Deepika Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Deepika();
                return _instance;

            }
        }
        SqlConnection con = new SqlConnection(@"Server =ADMIN3-PC\SQLEXPRESS;Database=OfrCallRegistery;UID=sa;Password=Karthik@12345");
        public Deepika()
        {
            InitializeComponent();
        }

        private void Deepika_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where EmployeeName like 'Deepika'", con);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT where EmployeeName like 'Deepika'", con);
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
