using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToInt32(textBox1.Text);
            double bNumber = Convert.ToInt32(textBox2.Text);
            double result = aNumber * bNumber;

            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToInt32(textBox1.Text);
            double bNumber = Convert.ToInt32(textBox2.Text);
            double result = aNumber - bNumber;

            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToInt32(textBox1.Text);
            double bNumber = Convert.ToInt32(textBox2.Text);
            double result = aNumber + bNumber;

            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToInt32(textBox1.Text);
            double bNumber = Convert.ToInt32(textBox2.Text);

            if(aNumber == 0)
            {
                MessageBox.Show("you cannot divide to zero!!!");
            }
            else
            {
                double result = aNumber / bNumber;
                textBox3.Text = result.ToString();
            }
        }
    }
}
