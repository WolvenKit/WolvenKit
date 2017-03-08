using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmOutput : DockContent
    {
        public frmOutput()
        {
            InitializeComponent();
        }

        public void AddText(string text)
        {
            txOutput.AppendText(text);
            txOutput.ScrollToCaret();
        }

        internal void Clear()
        {
            txOutput.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(txOutput.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Title = "Choose a location to save the log to.";
                sf.Filter = "Text file (.txt) | *.txt";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sf.FileName,txOutput.Lines);
                }
            }
        }
    }
}