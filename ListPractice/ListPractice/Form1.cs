using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> namesList = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            namesList.Add(Microsoft.VisualBasic.Interaction.InputBox("Enter High Score"));
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            foreach (string name in namesList)
            {
                lstDisplay.Items.Add(name);
            }
        }

        private void btnShowHigh_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2(namesList);
            fm2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have " + lstDisplay.Items.Count + " items in you list!");
        }


    }
}
