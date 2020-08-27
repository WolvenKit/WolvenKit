using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common.Services;
using WolvenKit.Services;
using WolvenKit.Extensions;

namespace WolvenKit
{
    public partial class frmOutput : DockContent, IThemedContent
    {
        

        public frmOutput()
        {
            InitializeComponent();
            ApplyCustomTheme();
        }

        public void AddText(string text,Logtype type = Logtype.Normal)
        {
            switch (type)
            {
                case Logtype.Error:
                    txOutput.AppendText(text,Color.Red);
                    break;
                case Logtype.Important:
                    txOutput.AppendText(text, Color.Orange);
                    break;
                case Logtype.Wcc:
                    txOutput.AppendText(text);
                    break;
                case Logtype.Success:
                    txOutput.AppendText(text, Color.LimeGreen);
                    break;
                default:
                    txOutput.AppendText("[" + DateTime.Now.ToString("G") + "]: " + text);
                    break;
            }
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

        private void clearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
        }
        
        public void ApplyCustomTheme()
        {
            this.txOutput.BackColor = UIController.GetBackColor();
            this.txOutput.ForeColor = UIController.GetForeColor();
        }

        private void txOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }

    
}