using System;
using System.Windows.Forms;

namespace WolvenKit
{
    public partial class Input : Form
    {
        public string Resulttext => textBox1.Text;

        public Input(string question)
        {
            InitializeComponent();
            questionLabel.Text = question;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
