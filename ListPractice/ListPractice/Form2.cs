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
    public partial class Form2 : Form
    {
        public Form2(List<string> listReceived)
        {
            InitializeComponent();
            listReceived.Sort();
            listReceived.Reverse();

            foreach (string name in listReceived)
            {
                lstHighScores.Items.Add(name);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
