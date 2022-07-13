using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        //first section
        double a, b;
        int sb;
        public Form1()
        {
            InitializeComponent();
        }
        // This is Equal Button 
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                b = 0;
                string equl = textBox1.Text;
                Double kb = double.Parse(equl);
                b = kb;
            }
          catch
            {
                MessageBox.Show("You entred Wrong Number");
            }
            //adding Button
            if (sb==1)
            {
                label1.Text = a + " +  " + b + "  =  ";
                double answer = a + b;
                textBox1.Text= answer.ToString();  
                    }
            //subtract button
            else if (sb==2)
            {
                label1.Text = a + " -  " +  b + " = ";
                Double answer = a - b;
                textBox1.Text = answer.ToString();  
            }
            //multiplication button
            else if (sb == 3)
            {
                label1.Text = a + "  X  " + b + " = ";
                Double answer = a * b;
                textBox1.Text = answer.ToString();
            }
            //divisin button
            else if (sb == 4)
            {
                label1.Text = a + "  /  " + b + " = ";
                Double answer = a / b;
                textBox1.Text = answer.ToString();
            }
            //remainder button
            else if (sb == 5)
            {
                label1.Text = a + "  % " + b + " = ";
                Double answer = a % b;
                textBox1.Text = answer.ToString();
            }
        }
        //This makes subtraction
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                sb = 0;
                string jb = textBox1.Text;
                Double kb = double.Parse(jb);
                a = kb;
                textBox1.Text = "";
                textBox1.Focus();
                sb = 2;
            }
          catch
            {
                MessageBox.Show("You Entred Wrong Number");
            }
        }


        //This makes Clear
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        //This makes Close
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This makes Multiplication
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                sb = 0;
                string jb = textBox1.Text;
                Double kb = double.Parse(jb);
                a = kb;
                textBox1.Text = "";
                textBox1.Focus();
                sb = 3;
                label1.Text = kb + " X ";
            }
            catch
            {
                MessageBox.Show("You Entred Wrong Number");
            }
           

        }
        //This makes division
        private void button4_divide_Click(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                sb = 0;
                string jb = textBox1.Text;
                Double kb = double.Parse(jb);
                a = kb;
                textBox1.Text = "";
                textBox1.Focus();
                sb = 4;
                label1.Text = kb + " / ";

            }
            catch
            {
                MessageBox.Show("You Entred Wrong Number");
            }
           
        }
        //This makes Remainder
        private void button5_rem_Click(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                sb = 0;
                string jb = textBox1.Text;
                Double kb = double.Parse(jb);
                a = kb;
                textBox1.Text = "";
                textBox1.Focus();
                sb = 5;
                label1.Text = kb + " % ";
            }
            catch
            {
                MessageBox.Show("You Entred Wronng Number");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //This makes Adding
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                sb = 0;
                string jb = textBox1.Text;
                Double kb = double.Parse(jb);
                a = kb;
                textBox1.Text = "";
                textBox1.Focus();
                sb = 1;
                label1.Text = kb + " +";

            }
            catch
            {
                MessageBox.Show("You Entred Wrong Number");
            }
            
        }

    }
}
