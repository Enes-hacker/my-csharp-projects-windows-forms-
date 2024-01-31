using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreYT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HF8V2OU\\SQLEXPRESS; Database=BookYT; Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand("Select * FROM Users Where Usename ='" + txtUsename.Text + "'and Password='" + txtPassword.Text + "'", connection);

            SqlDataReader sqlDataReader;

            sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                Dashboard dashboard= new Dashboard();
                dashboard.Show();
                this.Hide();
            
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

            connection.Close();


        }
    }
}
