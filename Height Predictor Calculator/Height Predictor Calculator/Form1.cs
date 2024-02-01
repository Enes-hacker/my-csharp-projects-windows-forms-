using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Height_Predictor_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double fatherHeight = (double)numFHeight.Value;
            double motherHeight = (double)numMHeight.Value;
            string gender = cmbGender.Text;
            double result; 


            if(gender == "Male")
            {
                result = (fatherHeight + motherHeight + 12) / 2;
                    MessageBox.Show($"Your child heighr prediction is: {result} +-5");
            } 
            else if(gender == "Female")
            {
                result = (fatherHeight + motherHeight - 12) / 2;
                    MessageBox.Show($"Your child heighr prediction is: {result} +-5");
            }
        }
    }
}
