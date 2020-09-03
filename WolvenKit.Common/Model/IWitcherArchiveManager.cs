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
    /// <summary>
    /// Top-level game file, holds archived game assets. Types :
    /// .bundle, .cache (collision, texture, sound) .w3speech
    /// </summary>
    public interface IWitcherArchiveManager
    {
        WitcherTreeNode RootNode { get; set; }
        List<IWitcherFile> FileList { get; set; }
        EBundleType TypeName { get; }
        List<string> Extensions { get; set; }
        AutoCompleteStringCollection AutocompleteSource { get; set; }
        Dictionary<string, List<IWitcherFile>> Items { get; set; }
    }
}
