using System.Windows.Forms;

namespace WolvenKit.CR2W.Editors
{
    public partial class PtrEditor : UserControl
    {
        public PtrEditor()
        {
            InitializeComponent();
        }

        public TextBox Flags { get; private set; }
        public TextBox HandlePath { get; private set; }
        public TextBox FileType { get; private set; }
    }
}