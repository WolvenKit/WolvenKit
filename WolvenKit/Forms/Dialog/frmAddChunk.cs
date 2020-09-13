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
                txType.Items.AddRange(types.ToArray<object>());
            }
            else
            {

                var types = CR2WTypeManager.AvailableTypes;
                var enumerable = types as string[] ?? types.ToArray();
                enumerable.ToList().Sort();

                txType.Items.AddRange(enumerable.ToArray<object>());
            }
        }

        public string ChunkType => txType.Text;
    }
}