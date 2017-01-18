using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmOutput : DockContent
    {
        public void AddText(string text)
        {
            txOutput.AppendText(text);
            //txOutput.Select(txOutput.TextLength, 0);
            txOutput.ScrollToCaret();
        }

        public frmOutput()
        {
            InitializeComponent();
        }

        internal void Clear()
        {
            txOutput.Clear();
        }
    }
}
