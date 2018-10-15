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
    public partial class NamesS : UserControl
    {
        private static NamesS _instance;
        public static NamesS Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new NamesS();
                return _instance;

            }
        }


        public NamesS()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server =ADMIN3-PC\SQLEXPRESS;Database=OfrCallRegistery;UID=sa;Password=Karthik@12345");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.School values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+ comboBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Suceess");
            textBox1.Text = textBox2.Text = textBox3.Text =  textBox4.Text  = comboBox2.Text = "";
        }

        private void NamesS_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
