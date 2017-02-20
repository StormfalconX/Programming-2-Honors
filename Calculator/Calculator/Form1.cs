using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Calculator : Form
    {

        double num1;
        double num2;
        string strNum1 = string.Empty;
        string strNum2 = string.Empty;
        string strOperator = string.Empty;
        bool boolOperator = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "1";

            if (boolOperator == true)
            {
                strNum2 += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "2";

            if (boolOperator == true)
            {
                strNum2 += "2";
            }
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "3";

            if (boolOperator == true)
            {
                strNum2 += "3";
            }
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "4";

            if (boolOperator == true)
            {
                strNum2 += "4";
            }
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "5";

            if (boolOperator == true)
            {
                strNum2 += "5";
            }
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "6";

            if (boolOperator == true)
            {
                strNum2 += "6";
            }
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "7";

            if (boolOperator == true)
            {
                strNum2 += "7";
            }
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "8";

            if (boolOperator == true)
            {
                strNum2 += "8";
            }
           
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "9";;

            if (boolOperator == true)
            {
                strNum2 += "9";
            }
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "0";

            if (boolOperator == true)
            {
                strNum2 += "0";
            }
           
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += ".";

            if (boolOperator == true)
            {
                strNum2 += ".";
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            lblDisplay.Text += "+";
            boolOperator = true;
            strOperator = "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            lblDisplay.Text += "-";
            boolOperator = true;
            strOperator = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            lblDisplay.Text += "*";
            boolOperator = true;
            strOperator = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            lblDisplay.Text += "/";
            boolOperator = true;
            strOperator = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.ResetText();
            num1 = 0;
            num2 = 0;

            strNum1 = "";
            strNum2 = "";

            boolOperator = false;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double answer;

            num1 = Convert.ToDouble(strNum1);
            num2 = Convert.ToDouble(strNum2);

            if (strOperator == "+")
            {
                answer = num1 + num2;
                lblDisplay.Text = answer.ToString();
            }
            else if (strOperator == "-")
            {
                answer = num1 - num2;
                lblDisplay.Text = answer.ToString();
            }
            else if (strOperator == "*")
            {
                answer = num1 * num2;
                lblDisplay.Text = answer.ToString();
            }
            else if (strOperator == "/")
            {
                answer = num1 / num2;
                lblDisplay.Text = answer.ToString();
            }
            

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            num1 = Convert.ToDouble(strNum1);

            lblDisplay.Text = "Sin of " + num1 + " = " + Math.Sin(num1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;

            num1 = Convert.ToDouble(strNum1);

            lblDisplay.Text = "Cos of " + num1 + " = " + Math.Cos(num1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            num1 = Convert.ToDouble(strNum1);

            lblDisplay.Text = "Tan of " + num1 + " = " + Math.Tan(num1);
        }

        private void btnArcSin_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            num1 = Convert.ToDouble(strNum1);

            lblDisplay.Text = "Sin-1 of " + num1 + " = " + Math.Asin(num1);
        }

        private void btnArcCos_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            num1 = Convert.ToDouble(strNum1);

            lblDisplay.Text = "Cos-1 of " + num1 + " = " + Math.Acos(num1);
        }

        private void btnArctan_Click(object sender, EventArgs e)
        {
            strNum1 = lblDisplay.Text;
            num1 = Convert.ToDouble(strNum1);

            lblDisplay.Text = "Tan-1 of " + num1 + " = " + Math.Atan(num1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           string temp = string.Empty;
           temp = strNum1.TrimEnd();
           lblDisplay.Text = temp;
            
        }
    }
}