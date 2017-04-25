using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit
{
    public partial class frmDebug : Form
    {
        public frmDebug()
        {
            InitializeComponent();
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(logbox.SelectedText);
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(logbox.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sf = new SaveFileDialog();
            sf.Title = "Please select where to save the log.";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sf.FileName,logbox.Lines);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
