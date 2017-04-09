using System;
using System.Windows.Forms;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Editors
{
    public interface IByteSource
    {
        byte[] Bytes { get; set; }
    }

    public partial class ByteArrayEditor : UserControl
    {
        private IByteSource bytes;

        public ByteArrayEditor()
        {
            InitializeComponent();
        }

        public IByteSource Variable
        {
            get { return bytes; }
            set
            {
                bytes = value;
                lblSize.Text = value.Bytes.Length + " bytes";
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            ((CVariable) Variable).cr2w.CreateVariableEditor(((CVariable) Variable), EVariableEditorAction.Open);
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            ((CVariable) Variable).cr2w.CreateVariableEditor(((CVariable) Variable), EVariableEditorAction.Import);
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            ((CVariable) Variable).cr2w.CreateVariableEditor(((CVariable) Variable), EVariableEditorAction.Export);
        }
    }
}