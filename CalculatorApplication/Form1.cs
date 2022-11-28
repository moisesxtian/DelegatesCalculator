using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double num1;
        public static double num2;
        private void button1_Click(object sender, EventArgs e)
        {
            getInput();
            CalculatorClass calc = new CalculatorClass();
            CalculatorClass.Formula getSum = CalculatorClass.getSum;
            CalculatorClass.Formula getProduct = CalculatorClass.getProduct;
            CalculatorClass.Formula getDifference = CalculatorClass.getDifference;
            CalculatorClass.Formula getQuotient = CalculatorClass.getQuotient;
            if (comboBox1.Text.Equals("+"))
            {
                label1.Text = getSum(num1, num2).ToString();
            }
            else if (comboBox1.Text.Equals("-")) 
            {
                label1.Text = getDifference(num1, num2).ToString();
            }
            else if (comboBox1.Text.Equals("/"))
            {
                label1.Text = getQuotient(num1, num2).ToString();
            }
            else if (comboBox1.Text.Equals("*"))
            {
                label1.Text = getProduct(num1, num2).ToString();
            }
        }
        void getInput()
        {

            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
