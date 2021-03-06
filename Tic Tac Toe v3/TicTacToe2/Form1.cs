﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        int intPlayer = 1;
        int combination;

        private void lbl1_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl1.Text = "x";
                lbl1.Enabled = false;
            }
            else
            {
                lbl1.Text = "o";
                lbl1.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl2.Text = "x";
                lbl2.Enabled = false;
            }
            else
            {
                lbl2.Text = "o";
                lbl2.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl3.Text = "x";
                lbl3.Enabled = false;
            }
            else
            {
                lbl3.Text = "o";
                lbl3.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl4.Text = "x";
                lbl4.Enabled = false;
            }
            else
            {
                lbl4.Text = "o";
                lbl4.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl5.Text = "x";
                lbl5.Enabled = false;
            }
            else
            {
                lbl5.Text = "o";
                lbl5.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl6.Text = "x";
                lbl6.Enabled = false;
            }
            else
            {
                lbl6.Text = "o";
                lbl6.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl7.Text = "x";
                lbl7.Enabled = false;
            }
            else
            {
                lbl7.Text = "o";
                lbl7.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl8.Text = "x";
                lbl8.Enabled = false;
            }
            else
            {
                lbl8.Text = "o";
                lbl8.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            if (intPlayer == 1)
            {
                lbl9.Text = "x";
                lbl9.Enabled = false;
            }
            else
            {
                lbl9.Text = "o";
                lbl9.Enabled = false;
            }
            checkBoard();
            intPlayer *= -1;
        }


        private void checkBoard()
        {
            if (lbl1.Text == "x" & lbl2.Text == "x" & lbl3.Text == "x")
            {
                combination = 1;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl1.Text == "x" & lbl4.Text == "x" & lbl7.Text == "x")
            {
                combination = 2;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl1.Text == "x" & lbl5.Text == "x" & lbl9.Text == "x")
            {
                combination = 3;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl4.Text == "x" & lbl5.Text == "x" & lbl6.Text == "x")
            {
                combination = 4;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl7.Text == "x" & lbl8.Text == "x" & lbl9.Text == "x")
            {
                combination = 5;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl3.Text == "x" & lbl5.Text == "x" & lbl7.Text == "x")
            {
                combination = 6;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl2.Text == "x" & lbl5.Text == "x" & lbl8.Text == "x")
            {
                combination = 7;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl3.Text == "x" & lbl6.Text == "x" & lbl9.Text == "x")
            {
                combination = 8;
                tmr1.Start();
                MessageBox.Show("x wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl1.Text == "o" & lbl2.Text == "o" & lbl3.Text == "o")
            {
                combination = 1;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl1.Text == "o" & lbl4.Text == "o" & lbl7.Text == "o")
            {
                combination = 2;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl1.Text == "o" & lbl5.Text == "o" & lbl9.Text == "o")
            {
                combination = 3;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl4.Text == "o" & lbl5.Text == "o" & lbl6.Text == "o")
            {
                combination = 4;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl7.Text == "o" & lbl8.Text == "o" & lbl9.Text == "o")
            {
                combination = 5;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl3.Text == "o" & lbl5.Text == "o" & lbl7.Text == "o")
            {
                combination = 6;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl2.Text == "o" & lbl5.Text == "o" & lbl8.Text == "o")
            {
                combination = 7;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl3.Text == "o" & lbl6.Text == "o" & lbl9.Text == "o")
            { 
                combination = 8;
                tmr1.Start();
                MessageBox.Show("o wins");
                restart();
                tmr1.Stop();
            }
            else if (lbl1.Text != "" & lbl2.Text != "" & lbl3.Text != "" & lbl4.Text != "" & lbl5.Text != "" & lbl6.Text != "" & lbl7.Text != "" & lbl8.Text != "" & lbl9.Text != "")
            {
                restart();
            }
        }
        private void restart()
        {
            DialogResult result = MessageBox.Show("Do you want to play again?","Tic Tac Toe", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
                lbl4.Text = "";
                lbl5.Text = "";
                lbl6.Text = "";
                lbl7.Text = "";
                lbl8.Text = "";
                lbl9.Text = "";

                lbl1.Enabled = true;
                lbl2.Enabled = true;
                lbl3.Enabled = true;
                lbl4.Enabled = true;
                lbl5.Enabled = true;
                lbl6.Enabled = true;
                lbl7.Enabled = true;
                lbl8.Enabled = true;
                lbl9.Enabled = true;
            }

            else
                Application.Exit();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (combination == 1)
            {

                lbl1.Visible = false; lbl2.Visible = false; ; lbl3.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl1.Visible = true; lbl2.Visible = true; lbl3.Visible = true;
            }
            else if (combination == 2)
            {
                lbl1.Visible = false; lbl4.Visible = false; lbl7.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl1.Visible = true; lbl4.Visible = true; lbl7.Visible = true;
            }
            else if (combination == 3)
            {
                lbl1.Visible = false; lbl5.Visible = false; lbl9.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl1.Visible = true; lbl5.Visible = true; lbl9.Visible = true;
            }
            else if (combination == 4)
            {
                lbl4.Visible = false; lbl5.Visible = false; lbl6.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl4.Visible = true; lbl5.Visible = true; lbl6.Visible = true;
            }
            else if (combination == 5)
            {
                lbl7.Visible = false; lbl8.Visible = false; lbl9.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl7.Visible = true; lbl8.Visible = true; lbl9.Visible = true;
            }
            else if (combination == 6)
            {
                lbl3.Visible = false; lbl5.Visible = false; lbl7.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl3.Visible = true; lbl5.Visible = true; lbl7.Visible = true;
            }
            else if (combination == 7)
            {
                lbl2.Visible = false; lbl5.Visible = false; lbl8.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl2.Visible = true; lbl5.Visible = true; lbl8.Visible = true;
            }
            else if (combination == 8)
            {
                lbl3.Visible = false; lbl6.Visible = false; lbl9.Visible = false;
                System.Threading.Thread.Sleep(300);
                lbl3.Visible = true; lbl6.Visible = true; lbl9.Visible = true;
            }
        }

    }
}
