using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Interfaces
{
    public interface IWitcherArchive
    {
        WitcherTreeNode RootNode { get; set; }
        List<IWitcherFile> FileList { get; set; }
        List<string> Extensions { get; set; }
        AutoCompleteStringCollection AutocompleteSource { get; set; }
        Dictionary<string, List<IWitcherFile>> Items { get; set; }
        /*string FileName { get; set; }
        string ParentFile { get; set; }

        void Extract(string fileName);
        void Extract(Stream output);*/
    }
}
