using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game file, holds archived game assets. Types :
    /// .bundle, .cache (collision, texture, sound) .w3speech
    /// </summary>
    public interface IGameArchiveManager
    {
        WitcherTreeNode RootNode { get; set; }
        List<IGameFile> FileList { get; set; }
        EBundleType TypeName { get; }
        List<string> Extensions { get; set; }
        List<string> AutocompleteSource { get; set; }
        Dictionary<string, List<IGameFile>> Items { get; set; }
    }
}
