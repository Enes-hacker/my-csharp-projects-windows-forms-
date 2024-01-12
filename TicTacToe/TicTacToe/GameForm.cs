using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        private bool player1Turn = true;
        private int turn = 0;
        public GameForm(string player1, string player2)
        {
            
            InitializeComponent();

            lblPlayer1.Text = player1;
            lblPlayer2.Text = player2;
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            //pic.ImageLocation = "../../cirle-removebg-preview.png";

            //Player logic
            //If Player1 done then Player 2 turns
            if (pic.ImageLocation == null) //once a box is played it cannnot be replaced
            {
                if (player1Turn)
                {
                    pic.ImageLocation = "../../cirle-removebg-preview.png";
                }
                else
                {
                    pic.ImageLocation = "../../cross-removebg-preview.png";
                }
                player1Turn = !player1Turn;  //player one turn goes to player2

                turn++;

                this.checkWinner(); //calling the method
            }
            
        }

        //Winner check
        private void checkWinner()
        {
            //Rows Check
            if(pictureBox1.ImageLocation != null && pictureBox1.ImageLocation == pictureBox2.ImageLocation && pictureBox2.ImageLocation == pictureBox3.ImageLocation)
            {
                this.ShowWinner();
            }
            if (pictureBox4.ImageLocation != null && pictureBox4.ImageLocation == pictureBox5.ImageLocation && pictureBox5.ImageLocation == pictureBox6.ImageLocation)
            {
                this.ShowWinner();
            }
            if (pictureBox7.ImageLocation != null && pictureBox7.ImageLocation == pictureBox8.ImageLocation && pictureBox8.ImageLocation == pictureBox9.ImageLocation)
            {
                this.ShowWinner();
            }

            //Cols Check
            if (pictureBox1.ImageLocation != null && pictureBox1.ImageLocation == pictureBox4.ImageLocation && pictureBox4.ImageLocation == pictureBox7.ImageLocation)
            {
                this.ShowWinner();
            }
            if (pictureBox2.ImageLocation != null && pictureBox2.ImageLocation == pictureBox5.ImageLocation && pictureBox5.ImageLocation == pictureBox8.ImageLocation)
            {
                this.ShowWinner();
            }
            if (pictureBox3.ImageLocation != null && pictureBox3.ImageLocation == pictureBox6.ImageLocation && pictureBox6.ImageLocation == pictureBox9.ImageLocation)
            {
                this.ShowWinner();
            }

            //Diagonal Check
            if (pictureBox1.ImageLocation != null && pictureBox1.ImageLocation == pictureBox5.ImageLocation && pictureBox5.ImageLocation == pictureBox9.ImageLocation)
            {
                this.ShowWinner();
            }
            if (pictureBox3.ImageLocation != null && pictureBox3.ImageLocation == pictureBox5.ImageLocation && pictureBox5.ImageLocation == pictureBox7.ImageLocation)
            {
                this.ShowWinner();
            }

            if(turn >= 9)
            {
                MessageBox.Show("Draw!");
                this.ResetGame();
            }

        }

        private void ShowWinner() //method for showing the winner
        {
            if (player1Turn)
            {
                MessageBox.Show($"{lblPlayer2} wins"); //prints the winner of player2
                lblPlayerScore2.Text = (int.Parse(lblPlayerScore2.Text) + 1).ToString(); //increment of score
            }
            else
            {
                MessageBox.Show($"{lblPlayer1} wins"); //prints the winner of player1
                lblPlayerScore1.Text = (int.Parse(lblPlayerScore1.Text ) + 1).ToString(); //increment of score
            }
            //Restarting the fields after winner

            this.ResetGame();

           
        }
        
        private void ResetGame()
        {
            turn = 0; //After the game is complete and we have a winner we turn turn into 0
            player1Turn = true;
            pictureBox1.ImageLocation = null;
            pictureBox2.ImageLocation = null;
            pictureBox3.ImageLocation = null;
            pictureBox4.ImageLocation = null;
            pictureBox5.ImageLocation = null;
            pictureBox6.ImageLocation = null;
            pictureBox7.ImageLocation = null;
            pictureBox8.ImageLocation = null;
            pictureBox9.ImageLocation = null;
        }
    }
}
