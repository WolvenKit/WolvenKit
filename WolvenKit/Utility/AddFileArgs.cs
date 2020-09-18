using System.Collections.Generic;
using System.IO;
using WolvenKit.Common;
using WolvenKit.CR2W;

namespace WolvenKit
{
    public class AddFileArgs
    {
        public IEnumerable<IWitcherArchiveManager> Managers { get; }
        public List<WitcherListViewItem> SelectedPaths { get; }
        public bool AddAsDLC { get; }
        public bool Uncook { get; }
        public bool Export { get; }

        public AddFileArgs(IEnumerable<IWitcherArchiveManager> managers, List<WitcherListViewItem> selectedPaths, bool addAsDLC, bool uncook, bool export)
        {
            Managers = managers;
            SelectedPaths = selectedPaths;
            AddAsDLC = addAsDLC;
            Uncook = uncook;
            Export = export;
        }
    }
}