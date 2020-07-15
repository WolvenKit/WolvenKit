using System.Collections.Generic;
using System.IO;
using WolvenKit.Common;
using WolvenKit.CR2W;

namespace WolvenKit
{
    public class AddFileArgs
    {
        public List<IWitcherArchive> Managers { get; set; }
        public List<WitcherListViewItem> SelectedPaths { get; set; }
        public bool AddAsDLC { get; set; }
        public bool Uncook { get; set; }
        public bool Export { get; set; }

        public AddFileArgs(List<IWitcherArchive> managers, List<WitcherListViewItem> selectedPaths, bool addAsDLC, bool uncook, bool export)
        {
            Managers = managers;
            SelectedPaths = selectedPaths;
            AddAsDLC = addAsDLC;
            Uncook = uncook;
            Export = export;
        }
    }
}