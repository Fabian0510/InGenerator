using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "")
            {
                richTextBox.Text = "NoDataError";
            }
            else
            {
                string inputText;
                string outputText;
                inputText = richTextBox.Text;
                outputText = "('";
                inputText = inputText.Replace("\t", "','");
                inputText = inputText.Replace("\n", "");
                inputText = inputText.Remove(inputText.Length - 2);
                outputText = outputText + inputText;
                outputText = outputText + ")";
                richTextBox.Clear();
                richTextBox.Text = outputText;
                inputText = "";
                outputText = "";
                inputText = "";
                richTextBox.Focus();
                richTextBox.SelectAll();
            }
        }


    }
}
