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

        double num1; double num2; string strTemp = string.Empty; string strOperator = string.Empty; int counter;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            Button btnNumber = new Button();
            btnNumber = (Button)sender;
            strTemp += btnNumber.Text;
            lblDisplay.Text = strTemp;
        }

        private void Operation(object sender, EventArgs e)
        {
            Button btnOperate = new Button();
            btnOperate = (Button)sender;

            counter++;
            if (counter > 1)
            {
                Calculate();
            }

            strOperator = btnOperate.Text;
            num1 = Convert.ToDouble(lblDisplay.Text);
            strTemp = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        public void Calculate()
        {
            num2 = Convert.ToDouble(strTemp);
            if (strOperator == "+")
            {
                double answer = num1 + num2;
                lblDisplay.Text = Convert.ToString(answer);
            }
            else if (strOperator == "*")
            {
                double answer = num1 * num2;
                lblDisplay.Text = Convert.ToString(answer);
            }
            else if (strOperator == "/")
            {
                double answer = num1 / num2;
                lblDisplay.Text = Convert.ToString(answer);
            }
            else if (strOperator == "-")
            {
                double answer = num1 - num2;
                lblDisplay.Text = Convert.ToString(answer);
            }
            num1 = Convert.ToDouble(lblDisplay.Text);
            strTemp = string.Empty;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            strTemp = string.Empty;
            strOperator = string.Empty;
        }

    }

}