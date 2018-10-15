using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfrCallRegistery
{
    public partial class Form1 : Form
    {
        private bool Drag;
        private int MouseX;
        private int MouseY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!panel4.Controls.Contains(Dashbord.Instance))
            {
                panel4.Controls.Add(Dashbord.Instance);
                Dashbord.Instance.Dock = DockStyle.Fill;
                Dashbord.Instance.BringToFront();
            }
            else

                Dashbord.Instance.BringToFront();
            label2.Text = "Dashbord";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(CallRegistery.Instance))
            {
                panel4.Controls.Add(CallRegistery.Instance);
                CallRegistery.Instance.Dock = DockStyle.Fill;
                CallRegistery.Instance.BringToFront();
            }
            else

                CallRegistery.Instance.BringToFront();
            label2.Text = "Call Registery";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Names.Instance))
            {
                panel4.Controls.Add(Names.Instance);
                Names.Instance.Dock = DockStyle.Fill;
                Names.Instance.BringToFront();
            }
            else

                Names.Instance.BringToFront();
            label2.Text = "Lekha";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!panel4.Controls.Contains(Shilpa.Instance))
            {
                panel4.Controls.Add(Shilpa.Instance);
                Shilpa.Instance.Dock = DockStyle.Fill;
                Shilpa.Instance.BringToFront();
            }
            else

                Shilpa.Instance.BringToFront();
            label2.Text = "Shilpa";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Lavanya_P.Instance))
            {
                panel4.Controls.Add(Lavanya_P.Instance);
                Lavanya_P.Instance.Dock = DockStyle.Fill;
                Lavanya_P.Instance.BringToFront();
            }
            else

                Lavanya_P.Instance.BringToFront();
            label2.Text = "Lavanya P";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Deepika.Instance))
            {
                panel4.Controls.Add(Deepika.Instance);
                Deepika.Instance.Dock = DockStyle.Fill;
                Deepika.Instance.BringToFront();
            }
            else

                Deepika.Instance.BringToFront();
            label2.Text = "Deepika";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Sujith.Instance))
            {
                panel4.Controls.Add(Sujith.Instance);
                Sujith.Instance.Dock = DockStyle.Fill;
                Sujith.Instance.BringToFront();
            }
            else

                Sujith.Instance.BringToFront();
            label2.Text = "Sujith";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(DashbordSchools.Instance))
            {
                panel4.Controls.Add(DashbordSchools.Instance);
                DashbordSchools.Instance.Dock = DockStyle.Fill;
                DashbordSchools.Instance.BringToFront();
            }
            else

                DashbordSchools.Instance.BringToFront();
            label2.Text = "Dashbord Schools";

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
           // button1.BackColor = Color.Maroon;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
           // button1.BackColor = Color.MediumTurquoise;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (!panel4.Controls.Contains(Dashbord.Instance))
            {
                panel4.Controls.Add(Dashbord.Instance);
                Dashbord.Instance.Dock = DockStyle.Fill;
                Dashbord.Instance.BringToFront();
            }
            else

                Dashbord.Instance.BringToFront();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.PeachPuff;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Turquoise;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.PeachPuff;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(NamesS.Instance))
            {
                panel4.Controls.Add(NamesS.Instance);
                NamesS.Instance.Dock = DockStyle.Fill;
                NamesS.Instance.BringToFront();
            }
            else

                NamesS.Instance.BringToFront();
            label2.Text = "Schools Registerys";
        }
       

        private void button10_Click_1(object sender, EventArgs e)
        {

            if (!panel4.Controls.Contains(Customer.Instance))
            {
                panel4.Controls.Add(Customer.Instance);
                Customer.Instance.Dock = DockStyle.Fill;
                Customer.Instance.BringToFront();
            }
            else

                Customer.Instance.BringToFront();
            label2.Text = "Customers";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Retailer.Instance))
            {
                panel4.Controls.Add(Retailer.Instance);
                Retailer.Instance.Dock = DockStyle.Fill;
                Retailer.Instance.BringToFront();
            }
            else

                Retailer.Instance.BringToFront();
            label2.Text = "Retailers";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Wholeseelrs.Instance))
            {
                panel4.Controls.Add(Wholeseelrs.Instance);
                Wholeseelrs.Instance.Dock = DockStyle.Fill;
                Wholeseelrs.Instance.BringToFront();
            }
            else

                Wholeseelrs.Instance.BringToFront();
            label2.Text = "Wholesellers";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumTurquoise;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumTurquoise;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumTurquoise;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.MediumTurquoise;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGray;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.MediumTurquoise;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightGray;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.MediumTurquoise;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightGray;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.MediumTurquoise;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightGray;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.MediumTurquoise;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightGray;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.MediumTurquoise;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.LightGray;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.MediumTurquoise;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.LightGray;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.MediumTurquoise;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.LightGray;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.MediumTurquoise;
        }
    }
}
