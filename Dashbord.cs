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
    public partial class Dashbord : UserControl
    {
        private static Dashbord _instance;
        public static Dashbord Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Dashbord();
                return _instance;

            }
        }


        SqlConnection con = new SqlConnection(@"Server =ADMIN3-PC\SQLEXPRESS;Database=OfrCallRegistery;UID=sa;Password=Karthik@12345");
        public Dashbord()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            data();

            timer1.Start();
         
            label2.Text = DateTime.Now.ToLongTimeString();


            /*SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            dataGridView1.DataSource = ds.Tables[0];
            //count table of Number of Records in database
            label3.Text ="Total Entries :  "+ ds.Tables[0].Rows.Count.ToString();
            //count table of Number of Records in database downloads
            int A, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[2].Value);
            }
            label4.Text = "Downloads : " + B.ToString();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        public void downloadCount()
        {
            int A, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[2].Value);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            data();
        }
        private void data()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.OfrCallRegisteryT", con);
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

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

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
