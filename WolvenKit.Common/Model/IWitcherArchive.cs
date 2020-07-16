using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public interface IWitcherArchive
    {
        WitcherTreeNode RootNode { get; set; }
        List<IWitcherFile> FileList { get; set; }
        EBundleType TypeName { get; }
        List<string> Extensions { get; set; }
        AutoCompleteStringCollection AutocompleteSource { get; set; }
        Dictionary<string, List<IWitcherFile>> Items { get; set; }
    }
}
