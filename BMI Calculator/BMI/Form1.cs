using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(cmbGender.Text == "")
            {
                MessageBox.Show("Please select a gender!");
            }

            double height = (double)numericHeight.Value;
            double weight = (double)numericWeight.Value;
            double bmi = weight / Math.Pow(0.01 * height, 2);

            bool isUnderveight = bmi < 18.5;
            bool isNormal = bmi >= 18.5 && bmi <= 24.9;
            bool isOverweight = bmi >= 25 && bmi <= 29.9;
            bool isObese = bmi >= 30 && bmi <= 34.9;
            bool isExtremelyObese = bmi >= 40;

            if (isUnderveight)
            {
                MessageBox.Show($"Body mass index is: {bmi}, Underweight");
            } else if(isNormal)
            {
                MessageBox.Show($"Body mass index is: {bmi}, You are Normal");
            }
            else if (isOverweight)
            {
                MessageBox.Show($"Body mass index is: {bmi}, You are Overweight");
            }
            else if (isObese)
            {
                MessageBox.Show($"Body mass index is: {bmi}, You are Obese");
            }
            else
            {
                MessageBox.Show($"Body mass index is: {bmi}, You are Mega Obese");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
