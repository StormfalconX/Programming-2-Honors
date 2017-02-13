using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_Generator_Forms
{
    public partial class PassGen : Form
    {
        public PassGen()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
            
        }

        public void Generate()
        {
            string strPassword = string.Empty;
            Random rPick = new Random();
            Random rUpper = new Random();
            Random rLower = new Random();
            Random rNum = new Random();

            bool blnUpper = false;
            bool blnLower = false;
            bool blnNum = false;

            do
            {
                int i = rPick.Next(1, 4);

                if (i == 1)
                {
                    strPassword += (char)('A' + rUpper.Next(0, 26));
                    blnUpper = true;
                }
                else if (i == 2)
                {
                    strPassword += (char)('a' + rLower.Next(0, 26));
                    blnLower = true;
                }
                else
                {
                    strPassword += (int)('1' + rNum.Next(1, 10));
                    blnNum = true;
                }
            } while (strPassword.Length < 8);

            if (blnLower == true & blnNum == true & blnUpper == true)
            {
                txtPassword.Text = "the password is " + strPassword;
            }
            else
            {
                Generate();
            }
        }
    }
}
