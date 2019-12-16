using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double Function(double x1, double x2)
        {
            double ResFunct = 45*x1*Math.Sin(x2)+Math.Sqrt(9*x2*x1*x1*x1);
            return ResFunct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox2.Text);
                double ResFunct = Function(x1, x2);
                string Res = ResFunct.ToString("0.##E+00");
                textBox3.Text = Res;

            }
            catch
            {
                MessageBox.Show("Не правильні данні!");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
