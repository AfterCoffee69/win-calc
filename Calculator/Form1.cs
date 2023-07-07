using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double firstNum;
        public double secondNum;
        public double result;
        char sign = '+';

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button B = (Button) sender;
            if (textBox1.Text == "0" && B.Text != ",")
                textBox1.Text = B.Text;
            else
                textBox1.Text += B.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                firstNum = Convert.ToDouble(textBox1.Text);
                sign = (sender as Button).Text[0];
                textBox2.Text = sign.ToString();
                textBox1.Clear();
            }
            catch { }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                secondNum = Convert.ToDouble(textBox1.Text);
                textBox2.Clear();

                switch (sign)
                {
                    case '+':
                        result = firstNum + secondNum;
                        textBox1.Text = result.ToString();
                        break;
                    case '-':
                        result = firstNum - secondNum;
                        textBox1.Text = result.ToString();
                        break;
                    case 'x':
                        result = firstNum * secondNum;
                        textBox1.Text = result.ToString();
                        break;
                    case '/':
                        result = firstNum / secondNum;
                        textBox1.Text = result.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" )
                if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else textBox1.Text = '-' + textBox1.Text;
        }
    }
}
