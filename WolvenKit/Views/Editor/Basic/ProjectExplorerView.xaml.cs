using System.Windows;
using HandyControl.Data;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Models;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView
    {
        #region Constructors

        public static ProjectExplorerView GlobalPEView;

        public ProjectExplorerView()
        {
            InitializeComponent();
            GlobalPEView = this;
            TreeGrid.ItemsSourceChanged += TreeGrid_ItemsSourceChanged;
        }

        private bool _isfirsttime { get; set; } = true;

        private void TreeGrid_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }
            if (TreeGrid == null)
            { return; }
            if (TreeGrid.View != null)
            {
                if (!_isfirsttime)
                {
                    if (viewModel.LastSelected != null)
                    {
                        TreeGrid.ExpandAllNodes();
                        var rowIndex = this.TreeGrid.ResolveToRowIndex(viewModel.LastSelected);
                        if (rowIndex > -1)
                        {
                            var q = TreeGrid.ResolveToRowIndex(rowIndex - 1);
                            var columnIndex = this.TreeGrid.ResolveToStartColumnIndex();
                            this.TreeGrid.ScrollInView(new RowColumnIndex(q, columnIndex));
                            TreeGrid.SelectRows(q, q);
                        }
                    }
                }
                else
                { _isfirsttime = false; }
            }
        }

        //private void View_NodeCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    Trace.WriteLine("hello");
        //    //if (e.NewItems != null)
        //    //{
        //    //    foreach (var nerd in e.NewItems)
        //    //    {
        //    //        Trace.WriteLine(nerd.ToString());
        //    //        TreeGrid.ExpandNode((TreeNode)nerd);
        //    //    }
        //    //}

        //    if (ViewModel is not ProjectExplorerViewModel viewModel)
        //    {
        //        return;
        //    }

        //    //var rootnodes = TreeGrid.View.Nodes.RootNodes;
        //    //foreach (var rootnode in rootnodes)
        //    //{
        //    //    TreeGrid.ExpandNode(rootnode);
        //    //}

        //    Trace.WriteLine(e.Action.ToString());
        //}

        //protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        //{
        //    if (ViewModel is not ProjectExplorerViewModel viewModel)
        //    {
        //        return;
        //    }

        //    var name = e.PropertyName;
        //    switch (name)
        //    {
        //        case nameof(viewModel.IsTreeBeingEdited):
        //            if (viewModel.IsTreeBeingEdited)
        //            {
        //                TreeGrid.View.BeginInit(TreeViewRefreshMode.DeferRefresh);
        //            }
        //            else
        //            {
        //                TreeGrid.View.EndInit();
        //            }
        //            break;
        //    }
        //}

        #endregion Constructors

        public void ExpandChildren()
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }

            var model = viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.ExpandAllNodes(node);
        }

        private void ExpandChildren_OnClick(object sender, RoutedEventArgs e) => ExpandChildren();

        public void CollapseChildren()
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }

            var model = viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.CollapseAllNodes(node);
        }

        private void CollapseChildren_OnClick(object sender, RoutedEventArgs e) => CollapseChildren();

        public void ExpandAll() => TreeGrid.ExpandAllNodes();

        public void CollapseAll() => TreeGrid.CollapseAllNodes();

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e) => ExpandAll();

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e) => CollapseAll();

        private string _currentFolderQuery = "";

        private bool FilterNodes(object o) => o is FileModel data && data.Name.Contains(_currentFolderQuery);

        private void PESearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            // expand all
            TreeGrid.ExpandAllNodes();
            _currentFolderQuery = e.Info;

            // filter programmatially
            TreeGrid.View.Filter = FilterNodes;
            TreeGrid.View.RefreshFilter();
        }

        private void UserControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StaticReferences.RibbonViewInstance.projectexplorercontextab.SetCurrentValue(ContextTabGroup.IsGroupVisibleProperty, true);
        }
    }
}
