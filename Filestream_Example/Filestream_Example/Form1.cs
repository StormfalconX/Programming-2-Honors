using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Filestream_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string FileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Programming 2\\DATA\\data01.txt";

            label1.Text = "Editing: " + FileName;



            FileStream FS = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);

            byte[] bText = new byte[FS.Length]; //array of bytes, size of file
            FS.Read(bText, 0, bText.Length); //read file contents
            textBox1.Text = System.Text.Encoding.ASCII.GetString(bText); //convert byte array into string for text property

            FS.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string FileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Programming 2\\DATA\\data01.txt";

            label1.Text = "Saved to: " + FileName;

            FileStream FS = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);

            byte[] btext = System.Text.Encoding.ASCII.GetBytes(textBox1.Text); //covert text property contents to byte array

            FS.Write(btext, 0, btext.Length);//write byte array to file from beginning to end

            FS.Close();
        }
    }
}
