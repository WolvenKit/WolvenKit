using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Edit
{
    public partial class frmExtractAmbigious : Form
    {
        public frmExtractAmbigious(IEnumerable<string> options)
        {
            InitializeComponent();

            lsBundleList.Items.AddRange(options.ToArray());
            lsBundleList.SelectedIndex = lsBundleList.Items.Count -1;
        }

        public string SelectedBundle
        {
            get
            {
                return (string)lsBundleList.SelectedItem;
            }
        }
    }
}
