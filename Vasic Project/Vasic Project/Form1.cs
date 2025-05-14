using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vasic_Project
{
    public partial class Form1 : Form
    {
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Number buttons for first textbox
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        // Decimal point
        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        // Operations
        private void button11_Click(object sender, EventArgs e) // Addition
        {
            operation = "+";
        }

        private void button12_Click(object sender, EventArgs e) // Subtraction
        {
            operation = "-";
        }

        private void button13_Click(object sender, EventArgs e) // Multiplication
        {
            operation = "*";
        }

        private void button14_Click(object sender, EventArgs e) // Division
        {
            operation = "/";
        }

        // Equals
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = double.Parse(textBox1.Text);
                double secondNumber = double.Parse(textBox2.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                }

                textBox3.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers and select an operation.");
            }
        }

        // Clear
        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            operation = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
