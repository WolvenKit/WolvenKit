using System.Windows.Forms;
using W3Edit.CR2W.Types;

namespace W3Edit
{
    public partial class frmAddVariable : Form
    {
        public frmAddVariable()
        {
            InitializeComponent();

            var mng = CR2WTypeManager.Get();

            var types = mng.AvailableTypes;
            types.Sort();

            txType.Items.AddRange(types.ToArray());
        }

        public string VariableName
        {
            get { return txName.Text; }
            set { txName.Text = value; }
        }

        public string VariableType
        {
            get { return txType.Text; }
            set { txType.Text = value; }
        }
    }
}