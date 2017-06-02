using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Interfaces
{
    public class WitcherTreeNode
    {
        public WitcherTreeNode()
        {
            Directories = new Dictionary<string, WitcherTreeNode>();
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
                    current = current.Parent;
                    if (current == null)
                        break;
                }

                return path;
            }
        }

        public string Name { get; set; }
        public WitcherTreeNode Parent { get; set; }
        public Dictionary<string, WitcherTreeNode> Directories { get; set; }
        public Dictionary<string, List<IWitcherFile>> Files { get; set; }
    }
}
