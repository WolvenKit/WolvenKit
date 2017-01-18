using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W.Types;
using System.IO;

namespace W3Edit.CR2W.Editors
{
    public interface IByteSource
    {
        byte[] Bytes { get; set; }
    }

    public partial class ByteArrayEditor : UserControl
    {
        private IByteSource bytes;
        public IByteSource Variable
        {
            get { return bytes; }
            set
            {
                bytes = value;
                lblSize.Text = value.Bytes.Length + " bytes";
            }
        }

        public ByteArrayEditor()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            ((CVariable)Variable).cr2w.CreateVariableEditor(((CVariable)Variable), EVariableEditorAction.Open);
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            ((CVariable)Variable).cr2w.CreateVariableEditor(((CVariable)Variable), EVariableEditorAction.Import);
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            ((CVariable)Variable).cr2w.CreateVariableEditor(((CVariable)Variable), EVariableEditorAction.Export);
        }
    }
}
