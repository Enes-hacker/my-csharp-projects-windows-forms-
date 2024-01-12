using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppYT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResult.Text = string.Empty;    
        }

        //calculate button

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(textBoxOne.Text);
            double secondNumber = double.Parse(textBoxTwo.Text);
            string sign = textBoxSign.Text;

            double result = 0;

            switch (sign)
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
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    break;
                default:
                    MessageBox.Show("Invalid Sign");
                    break;

                    
            }
            labelResult.Text = result.ToString();

        }

        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
            // labelResult.Text = "";
            textBoxOne.Text = string.Empty; 
            textBoxTwo.Text = string.Empty;
            textBoxSign.Text = string.Empty;    
        }
    }
}
