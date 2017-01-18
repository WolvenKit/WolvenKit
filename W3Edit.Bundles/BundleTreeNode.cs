using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.Bundles
{
    public class BundleTreeNode
    {
        public BundleTreeNode()
        {
            Directories = new Dictionary<string, BundleTreeNode>();
            Files = new Dictionary<string, List<BundleItem>>();
            Name = "";
        }

        public string FullPath
        {
            get
            {
                var path = "";
                var current = this;
                while (true)
                {
                    path = Path.Combine(current.Name, path);
                    current = current.Parent;
                    if (current == null)
                        break;
                }

                return path;
            }
        }

        public string Name { get; set; }
        public BundleTreeNode Parent { get; set; }
        public Dictionary<string, BundleTreeNode> Directories { get; set; }
        public Dictionary<string, List<BundleItem>> Files { get; set; }
    }
}
