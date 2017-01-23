using System.Windows.Forms;
using W3Edit.CR2W.Types;

namespace W3Edit
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