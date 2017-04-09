using System.Windows.Forms;
using WolvenKit.CR2W.Types;

namespace WolvenKit
{
    public partial class frmAddChunk : Form
    {
        public frmAddChunk()
        {
            InitializeComponent();


            var mng = CR2WTypeManager.Get();

            var types = mng.AvailableTypes;
            types.Sort();

            txType.Items.AddRange(types.ToArray());
        }

        public string ChunkType
        {
            get { return txType.Text; }
            set { txType.Text = value; }
        }
    }
}