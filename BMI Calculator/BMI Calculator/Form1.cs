using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable data = new DataTable();
            data.Columns.Add("activityIndex");
            data.Columns.Add("activityName");

            data.Rows.Add(1.2 , "Low Activity");
            data.Rows.Add(1.35, "Medium Activity");
            data.Rows.Add(1.5, "High Activity");
            data.Rows.Add(1.725, "Ultra Activity");
            data.Rows.Add(1.9, "Extreme Activity");

            cmbActivity.DataSource = data;
            cmbActivity.ValueMember = "activityIndex";
            cmbActivity.DisplayMember = "activityName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbGender.Text == null || cmbGender.Text == "")
            {
                MessageBox.Show("Please select a gender");
                return;
            }

            string gender = cmbGender.Text;
            int age = (int)numAge.Value;
            int height = (int)numHeight.Value;
            int weight = (int)numWeight.Value;
            double activityIndex = double.Parse(cmbActivity.SelectedValue.ToString());

            double minCalories = 66 + (13.5 * weight) + (5 * height) - (6.5 * age);

            if(gender == "Female")
            {
                minCalories = 66 + (9.5 * weight) + (1.8 * height) - (4.5 * age);
            }

            double dailyCalories = activityIndex * minCalories;

            double bmi = weight / Math.Pow(0.01 * height, 2);

            
            MessageBox.Show($"Minimum Calories: {minCalories}, DailyCalories: {dailyCalories},Weight index: {bmi}{0:F2} ");
        }
    }
}
