using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Common;

namespace WolvenKit
{
    public class WitcherListViewItem : ListViewItem, ICloneable
    {
        public bool IsDirectory { get; set; }
        public WitcherTreeNode Node { get; set; }
        public string RelativePath { get; set; }

        public WitcherListViewItem() { }

        public WitcherListViewItem(IWitcherFile wf)
        {
            IsDirectory = false;
            Node = new WitcherTreeNode();
            Node.Name = Path.Combine("Root", wf.Bundle.TypeName.ToString(), Path.GetDirectoryName(wf.Name));
            RelativePath = wf.Name;
            this.Text = wf.Name;
        }

        public string AssetBrowserPath
        {
            get
            {
                if (Node != null)
                {
                    return Path.Combine(Node.FullPath, Path.GetFileName(RelativePath));
                }
                else
                {
                    return "";
                }
                
            }
        }

        public override object Clone()
        {
            var c = (WitcherListViewItem)this.MemberwiseClone();
            c.IsDirectory = IsDirectory;
            c.Node = Node;
            c.RelativePath = RelativePath;
            return c;
        }
    }
}
