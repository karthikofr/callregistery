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


    public partial class CallRegistery : UserControl
    {
        private static CallRegistery _instance;
        public static CallRegistery Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new CallRegistery();
                return _instance;

            }
        }


        SqlConnection con = new SqlConnection(@"Server =ADMIN3-PC\SQLEXPRESS;Database=OfrCallRegistery;UID=sa;Password=Karthik@12345");
        public CallRegistery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into OfrCallRegisteryT values('" + textBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Suceess");
            textBox1.Text = comboBox2.Text = comboBox3.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void CallRegistery_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
