using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_with_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int i = 0;
            string strInput = txtInput.Text;
            bool blnCorrect = false;

            string[] strBadInput = new string[3];

            do {
                if (checkPassword(strInput)) {
                    MessageBox.Show("correct");
                    blnCorrect = true;
                    Application.Exit();
                } //if

                else {
                    
                    strBadInput[i] = txtInput.Text;
                    i ++;
                    MessageBox.Show("incorrect");
                    
                    if (i == 3)
                    {
                        
                        lockout(strBadInput);
                    }

                    else
                    {
                        txtInput.Text = Microsoft.VisualBasic.Interaction.InputBox("try again: ");
                        if (checkPassword(strInput))
                        {
                            MessageBox.Show("correct");
                            blnCorrect = true;
                            Application.Exit();
                        }
                    }

                }//else
                
            }while(i<3 & blnCorrect == false); 
        }

        private void lockout(string[] strBadInput)
        {
            txtInput.Text = "";
            txtInput.Enabled = false;
            btnSubmit.Enabled = false;

            MessageBox.Show("too many attempts" + "\n" +
                                        "first attempt = " + strBadInput[0] + "\n" +
                                        "second attempt = " + strBadInput[1] + "\n" +
                                        "third attempt = " + strBadInput[2] + "\n");
        }

        private bool checkPassword(string PW)
        {
            if (txtInput.Text == "Example")
                return true;
            else
                return false;
        }

    } // public partial
} //namespace
