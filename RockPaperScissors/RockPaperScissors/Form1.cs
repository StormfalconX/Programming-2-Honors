using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playerCounter;
        int pcCounter;

        int playerSelection;
        int pcSelection;

        private void btn_Click(object sender, EventArgs e)
        {
            Button btnClick = new Button();
            btnClick = (Button)sender;
            if (btnClick.Text == "Rock")
            {
                playerSelection = 1;
                RockPaperScissors();
            }
            else if (btnClick.Text == "Paper")
            {
                playerSelection = 2;
                RockPaperScissors();
            }
            else
            {
                playerSelection = 3;
                RockPaperScissors();
            }
        }

        public void RockPaperScissors()
        {
            Random randInt = new Random();

            pcSelection = randInt.Next(1,4);

            if (playerSelection == 1 & pcSelection == 1)
            {
                lblSelection.Text = "Rock";
                MessageBox.Show("It is a tie");
            }
            else if (playerSelection == 1 & pcSelection == 2)
            {
                lblSelection.Text = "Paper";
                MessageBox.Show("Computer Wins");
                pcCounter++;
                lblPC.Text = pcCounter.ToString();
            }
            else if (playerSelection == 1 & pcSelection == 3)
            {
                lblSelection.Text = "Scissors";
                MessageBox.Show("You Win");
                playerCounter++;
                lblUser.Text = playerCounter.ToString();
            }
            else if (playerSelection == 2 & pcSelection == 1)
            {

                lblSelection.Text = "Rock";
                MessageBox.Show("You Win");
                playerCounter++;
                lblUser.Text = playerCounter.ToString();
            }
            else if (playerSelection == 2 & pcSelection == 2)
            {
                lblSelection.Text = "Paper";
                MessageBox.Show("It is a tie");
            }
            else if (playerSelection == 2 & pcSelection == 3)
            {

                lblSelection.Text = "Scissors";
                MessageBox.Show("Computer Win");
                pcCounter++;
                lblPC.Text = pcCounter.ToString();
            }
            else if (playerSelection == 3 & pcSelection == 1)
            {

                lblSelection.Text = "Rock";
                MessageBox.Show("Computer Win");
                pcCounter++;
                lblPC.Text = pcCounter.ToString();
            }
            else if (playerSelection == 3 & pcSelection == 2)
            {

                lblSelection.Text = "Paper";
                MessageBox.Show("You Win");
                playerCounter++;
                lblUser.Text = playerCounter.ToString();
            }
            else if (playerSelection == 3 & pcSelection == 3)
            {

                lblSelection.Text = "Rock";
                MessageBox.Show("It is a tie");
            }
        }

        
        /*private void btnRock_Click(object sender, EventArgs e)
        {
            playerSelection = 1;
            RockPaperScissors();

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerSelection = 2;
            RockPaperScissors();

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerSelection = 3;
            RockPaperScissors();
        }*/
    }
}
