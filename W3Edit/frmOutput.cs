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
    }
}