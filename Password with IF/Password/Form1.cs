using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password
{
    public partial class Password : Form
    {
        public Password()


        {
            InitializeComponent();
        }

        int intCounter;

        private void btnInput_Click(object sender, EventArgs e)
        {
            const string strInput = "Example";
            
            
            if (txtInput.Text == strInput) {
                MessageBox.Show("Correct");
                Application.Exit();
            }//if
            else {
                
                intCounter++;

                if (intCounter == 5) {
                    MessageBox.Show("too many attempts");
                        Enabled = false;
                }
                else {
                    MessageBox.Show("Wrong");
                    txtInput.Clear();
                } //else
            }//else
        }//private void
    } //partial class
} //namespace
