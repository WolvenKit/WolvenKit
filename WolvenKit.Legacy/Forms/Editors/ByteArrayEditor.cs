using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WolvenKit.Model;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Forms.Editors
{
    public partial class ByteArrayEditor : UserControl
    {
        private IByteSource bytes;
        public event EventHandler<RequestByteArrayFileOpenArgs> RequestBytesOpen;

        public ByteArrayEditor()
        {
            InitializeComponent();
        }

        public IByteSource Variable
        {
            get => bytes;
            set
            {
                bytes = value;
                lblSize.Text = value.GetBytes().Length + " bytes";
            }
        }

        private void btOpen_Click(object sender, EventArgs e) =>
            RequestBytesOpen?.Invoke(this, new RequestByteArrayFileOpenArgs((CVariable) Variable));

        private void btImport_Click(object sender, EventArgs e) => UIController.Get().ImportBytes((CVariable)Variable);

        private void btExport_Click(object sender, EventArgs e) => UIController.Get().ExportBytes(Variable);
    }
}