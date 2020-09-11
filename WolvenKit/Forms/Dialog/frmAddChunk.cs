using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.CR2W.Types;

namespace WolvenKit
{
    public partial class frmAddChunk : Form
    {
        public frmAddChunk(List<string> list = null)
        {
            InitializeComponent();

            if (list != null)
            {
                var types = list;
                types.Sort();
                txType.Items.AddRange(types.ToArray());
            }
            else
            {

                var types = CR2WTypeManager.AvailableTypes;
                types.ToList().Sort();

                txType.Items.AddRange(types.ToArray());
            }
        }

        public string ChunkType
        {
            get { return txType.Text; }
            set { txType.Text = value; }
        }
    }
}