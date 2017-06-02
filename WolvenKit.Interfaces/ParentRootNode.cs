using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Interfaces
{
    public class ParentRootNode : IWitcherTreeNode
    {
        public ParentRootNode()
        {
            Directories = new Dictionary<string, IWitcherTreeNode>();
            Files = new Dictionary<string, List<IWitcherFile>>();
            Name = "Root";
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
                    current = current.Parent as ParentRootNode;
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
