using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Interfaces;

namespace WolvenKit
{
    public class WitcherListItem : ListViewItem, ICloneable
    {
        public bool IsDirectory { get; set; }
        public WitcherTreeNode Node { get; set; }
        public string FullPath { get; set; }

        public string ExplorerPath
        {
            get
            {
                return Path.Combine(Node.FullPath, Path.GetFileName(FullPath));
            }
        }

        public override object Clone()
        {
            var c = (WitcherListItem)this.MemberwiseClone();
            c.IsDirectory = IsDirectory;
            c.Node = Node;
            c.FullPath = FullPath;
            return c;
        }
    }
}
