using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WolvenKit
{
    public partial class frmExtractAmbigious : Form
    {
        public string SelectedBundle => (string)(lsBundleList.SelectedItem);
        public bool Skip => dnamaCHB.Checked;

        public frmExtractAmbigious(IEnumerable<string> options)
        {
            InitializeComponent();

            lsBundleList.Items.AddRange(options.ToArray());
            lsBundleList.SelectedIndex = lsBundleList.Items.Count - 1;
        }
    }
}