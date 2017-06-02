using System.Collections.Generic;
using System.IO;
using WolvenKit.Interfaces;

namespace WolvenKit.Bundles
{
    public class BundleTreeNode : IWitcherTreeNode
    {
        public BundleTreeNode()
        {
            Directories = new Dictionary<string, IWitcherTreeNode>();
            Files = new Dictionary<string, List<IWitcherFile>>();
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
                    current = current.Parent as BundleTreeNode;
                    if (current == null)
                        break;
                }

                return path;
            }
        }

        public string Name { get; set; }
        public IWitcherTreeNode Parent { get; set; }
        public Dictionary<string, IWitcherTreeNode> Directories { get; set; }
        public Dictionary<string, List<IWitcherFile>> Files { get; set; }
    }
}