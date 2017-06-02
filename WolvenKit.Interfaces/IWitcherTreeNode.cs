using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Interfaces
{
    public interface IWitcherTreeNode
    {
        string FullPath { get; }
        string Name { get; set; }
        IWitcherTreeNode Parent { get; set; }
        Dictionary<string, IWitcherTreeNode> Directories { get; set; }
        Dictionary<string, List<IWitcherFile>> Files { get; set; }
    }
}
