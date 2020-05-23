using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppendingText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open/create file called \"party list.txt\"");
            // create the output stream and open file called "party list.txt" 
            // preserving contents if any
            StreamWriter outputFile; 
            outputFile = File.AppendText("party list.txt");

            // add five lines of text
            outputFile.WriteLine("Last-minute guests:");
            outputFile.WriteLine("- Lynn");
            outputFile.WriteLine("- Steve");
            outputFile.WriteLine("- Bianca");
            outputFile.WriteLine("- John");

            // close the stream/file, ensuring all data will be saved in the file
            outputFile.Close();
            MessageBox.Show("Names added to \"party list.txt\".");
        }
    }
}
