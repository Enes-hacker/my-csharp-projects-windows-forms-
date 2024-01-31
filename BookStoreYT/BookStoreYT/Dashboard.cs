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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadBooksData();
        }

        public void loadBooksData()
        {
            //1.SqlConnection - connectiong strings
            //SqlCommand - query
            //3.Datatable
            //4.Data Adapter
            //5.Binding Source
            
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HF8V2OU\\SQLEXPRESS; Database=BookYT; Integrated Security=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand("Select * FROM Books", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand= cmd;

            DataTable dataTable= new DataTable();

            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dgvBooks.DataSource = bindingSource;
            sqlDataAdapter.Update(dataTable);

            connection.Close();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = ""; 
            txtTitle.Text = string.Empty;   
            txtAuthor.Text = string.Empty;
            numYear.Value = 0;
            numPages.Value = 0; 
            numPrice.Value = 0; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //1.SqlConnection - connectiong strings
            //SqlCommand - query
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HF8V2OU\\SQLEXPRESS; Database=BookYT; Integrated Security=True");

            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Books([ID] ,[Title] ,[Author],[Year], [Pages] ,[Price]) VALUES('"+txtID.Text+ "', '"+txtTitle.Text+"','"+txtAuthor.Text+"','"+numYear.Value+"','"+numPages.Value+"','"+numPrice.Value+"')", connection); 
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Saved Successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
               


            loadBooksData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //1.SqlConnection - connectiong strings
            //SqlCommand - query
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HF8V2OU\\SQLEXPRESS; Database=BookYT; Integrated Security=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE ID= '"+txtID.Text+"'", connection);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);


            loadBooksData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //1.SqlConnection - connectiong strings
            //SqlCommand - query
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HF8V2OU\\SQLEXPRESS; Database=BookYT; Integrated Security=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand("UPDATE [Books]   SET [Title]='"+txtTitle.Text+ "', [Author]='"+txtAuthor.Text+ "',[Year]='"+numYear.Value+ "',[Pages]='"+numPages.Value+ "',[Price]='"+numPrice.Value+"' Where ID='"+txtID.Text+"'", connection);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);


            loadBooksData();
        }
    }
}
