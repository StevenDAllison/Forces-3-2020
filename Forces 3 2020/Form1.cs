using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces_3_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin (double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return(Math.Asin(x)*180.0/Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //use try-catch to avoid input errors
            try
            {
                //read values for force and angle from textboxes
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                //calculate Fx and Fy using equations Fx = Fcos and Fy = Fsin
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                //Output solutions to label1 and label2
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;
            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double Fx = double.Parse(textBox3.Text);
            double Fy = double.Parse(textBox4.Text);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
