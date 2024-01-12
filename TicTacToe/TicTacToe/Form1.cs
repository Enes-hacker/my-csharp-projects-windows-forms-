using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPlayer1.Text == null || txtPlayer1.Text == "")
            {
                MessageBox.Show("Please Eneter Player 1");
                return;
            }
            if (txtPlayer2.Text == null || txtPlayer2.Text == "")
            {
                MessageBox.Show("Please Eneter Player 2");
                return;
            }

            this.Hide();
            GameForm gameForm = new GameForm(txtPlayer1.Text, txtPlayer2.Text);
            gameForm.ShowDialog();
        }
    }
}
