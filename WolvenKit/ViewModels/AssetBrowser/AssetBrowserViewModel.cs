using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.ViewModels.AssetBrowser
{
    class AssetBrowserViewModel : ViewModelBase
    {
        public GameFileTreeNode CurrentNode { get; set; } = new GameFileTreeNode();
        public List<AssetBrowserData> CurrentNodeFiles { get; set; } = new List<AssetBrowserData>();
        public GameFileTreeNode RootNode { get; set; }
    }
}
