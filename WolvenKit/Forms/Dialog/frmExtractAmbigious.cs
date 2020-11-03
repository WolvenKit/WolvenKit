using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.Common;

namespace WolvenKit
{
    public partial class frmExtractAmbigious : Form
    {
        public IWitcherFile SelectedBundle => filesDict[(string)(lsBundleList.SelectedItem)];

        public bool Skip => dnamaCHB.Checked;
        private Dictionary<string, IWitcherFile> filesDict;

        public frmExtractAmbigious(IEnumerable<IWitcherFile> options)
        {
            InitializeComponent();
            filesDict = new Dictionary<string, IWitcherFile>();

            var files = options.ToList();
            for (int i = 0; i < files.Count; i++)
            {
                var file = files[i];
                var key = $"{file.Name}";
                if (filesDict.ContainsKey(key))
                {
                    key = $"{key}_{i}";
                }
                filesDict.Add(key, file);
                lsBundleList.Items.Add(key);
            }

            lsBundleList.SelectedIndex = lsBundleList.Items.Count - 1;
        }
    }
}