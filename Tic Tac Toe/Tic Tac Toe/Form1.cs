using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        string box1;
        string box2;
        string box3;
        string box4;
        string box5;
        string box6;
        string box7;
        string box8;
        string box9;

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text == "x")
            {
                box1 = "x";
                checkBoardX();
            }
            else if (txt1.Text == "o")
            {
                box1 = "o";
                checkBoardO();
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text == "x")
            {
                box2 = "x";
                checkBoardX();
            }
            else if (txt2.Text == "o")
            {
                box2 = "o";
                checkBoardO();
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (txt3.Text == "x")
            {
                box3 = "x";
                checkBoardX();
            }
            else if (txt3.Text == "o")
            {
                box3 = "o";
                checkBoardO();
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (txt4.Text == "x")
            {
                box4 = "x";
                checkBoardX();
            }
            else if (txt4.Text == "o")
            {
                box4 = "o";
                checkBoardO();
            }
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            if (txt5.Text == "x")
            {
                box5 = "x";
                checkBoardX();
            }
            else if (txt5.Text == "o")
            {
                box5 = "o";
                checkBoardO();
            }
        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {
            if (txt6.Text == "x")
            {
                box6 = "x";
                checkBoardX();
            }
            else if (txt6.Text == "o")
            {
                box6 = "o";
                checkBoardO();
            }
        }

        private void txt7_TextChanged(object sender, EventArgs e)
        {
            if (txt7.Text == "x")
            {
                box7 = "x";
                checkBoardX();
            }
            else if (txt7.Text == "o")
            {
                box7 = "o";
                checkBoardO();
            }
        }

        private void txt8_TextChanged(object sender, EventArgs e)
        {
            if (txt8.Text == "x")
            {
                box8 = "x";
                checkBoardX();
            }
            else if (txt8.Text == "o")
            {
                box8 = "o";
                checkBoardO();
            }
        }

        private void txt9_TextChanged(object sender, EventArgs e)
        {
            if (txt9.Text == "x")
            {
                box9 = "x";
                checkBoardX();
            }
            else if (txt9.Text == "o")
            {
                box9 = "o";
                checkBoardO();
            }
        }

        private void checkBoardX()
        {
            if (box1 == "x" & box2 == "x" & box3 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (box4 == "x" & box5 == "x" & box6 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (box7 == "x" & box8 == "x" & box9 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (box1 == "x" & box4 == "x" & box7 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (box2 == "x" & box5 == "x" & box8 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (box3 == "x" & box6 == "x" & box9 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (box1 == "x" & box5 == "x" & box9 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (box3 == "x" & box5 == "x" & box7 == "x")
            {
                MessageBox.Show("Player 1 wins");
                restart();
            }
            else if (txt1.Text != "" & txt2.Text != "" & txt3.Text != "" & txt4.Text != "" & txt5.Text != "" & txt6.Text != "" & txt7.Text != "" & txt8.Text != "" & txt9.Text != "") 
            {
                MessageBox.Show("game over");
                restart();
            }
        }

        private void checkBoardO()
        {
            if (box1 == "o" & box2 == "o" & box3 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (box4 == "o" & box5 == "o" & box6 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (box7 == "o" & box8 == "o" & box9 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (box1 == "o" & box4 == "o" & box7 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (box2 == "o" & box5 == "o" & box8 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (box3 == "o" & box6 == "o" & box9 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (box1 == "o" & box5 == "o" & box9 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (box3 == "o" & box5 == "o" & box7 == "o")
            {
                MessageBox.Show("Player 2 wins");
                restart();
            }
            else if (txt1.Text != "" & txt2.Text != "" & txt3.Text != "" & txt4.Text != "" & txt5.Text != "" & txt6.Text != "" & txt7.Text != "" & txt8.Text != "" & txt9.Text != "")
            {
                MessageBox.Show("game over");
                restart();
            }
        }

        public void restart()
        {
            string YorN;
            
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";

            box1 = "";
            box2 = "";
            box3 = "";
            box4 = "";
            box5 = "";
            box6 = "";
            box7 = "";
            box8 = "";
            box9 = "";

            YorN = Microsoft.VisualBasic.Interaction.InputBox("Do you want to play again? Enter y or n.");

            if (YorN == "y")
                MessageBox.Show("The board is reset.");
            else if (YorN == "n")
                Application.Exit();
            else
            {
                MessageBox.Show("invalid entry");
                restart();
            }
        }
    }//public partial class
}//namespace