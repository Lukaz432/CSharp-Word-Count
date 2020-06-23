using System;
using System.Windows.Forms;

namespace Word_Count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            string text = wordBox.Text;
            char[] separator = { ' ' };
            int wordsCount = text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
            MessageBox.Show(wordsCount.ToString());
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            wordBox.Text = "";
        }
    }
}
