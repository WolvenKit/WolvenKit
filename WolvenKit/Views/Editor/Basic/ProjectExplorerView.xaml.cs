using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shell;
using HandyControl.Data;
using MahApps.Metro.Controls;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.Windows.Tools.Controls;
using Wolvenkit.InteropControls;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
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

        private void TreeGrid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!StaticReferences.AllowVideoPreview)
            {
                return;
            }

            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                SfTreeGrid dg = sender as SfTreeGrid;
                if (dg.SelectedItem == null)
                {
                    return;
                }
                var selected = dg.SelectedItem as FileModel;

                if (!selected.FullName.ToLower().Contains("bk2"))
                {
                    return;
                }

                var x = "Resources\\Media\\test.exe | " + selected.FullName + "/I2 /P /L";

                var appControl = new AppControl();
                appControl.ExeName = x.Split('|')[0];
                appControl.Args = x.Split('|')[1];
                appControl.VisualPoint = new Point(0.0, 30.0);

                if (StaticReferences.XoWindow == null)
                {
                    StaticReferences.XoWindow = new HandyControl.Controls.GlowWindow();
                    StaticReferences.XoWindow.Closed += (sender, args) => StaticReferences.XoWindow = null;
                }

                if (StaticReferences.XoWindow.Content != null)
                {
                    return;
                }
                StaticReferences.XoWindow.Unloaded += new RoutedEventHandler((s, e) =>
                {
                    var q = s as HandyControl.Controls.GlowWindow;
                    q.Close();
                    StaticReferences.XoWindow = null;
                    StaticReferences.XoWindow = new HandyControl.Controls.GlowWindow();
                });

                Grid grid = new Grid();
                grid.Children.Add(appControl);
                StaticReferences.XoWindow.SetCurrentValue(ContentProperty, grid);
                StaticReferences.XoWindow.SetCurrentValue(Window.TopmostProperty, true);
                StaticReferences.XoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                StaticReferences.XoWindow.Show();
            }
        }

        private void BKExport_Click(object sender, RoutedEventArgs e)
        {
            var q = TreeGrid.SelectedItems[0] as FileModel;

            if (!q.Extension.ToLower().Contains("bk2"))
            { return; }
            var procInfo = new System.Diagnostics.ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"));
            procInfo.Arguments = q.FullName + " " + Path.ChangeExtension(q.FullName, ".avi") + "/o /#";
            procInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"));
            // Start the process
            var process = System.Diagnostics.Process.Start(procInfo);
            // Wait for process to be created and enter idle condition
            process.WaitForInputIdle();
        }

        private void BKImport_Click(object sender, RoutedEventArgs e)
        {
            var q = TreeGrid.SelectedItems[0] as FileModel;

            if (!q.Extension.ToLower().Contains("avi"))
            { return; }

            var procInfo = new System.Diagnostics.ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"));
            procInfo.Arguments = q.FullName + " " + Path.ChangeExtension(q.FullName, ".bk2") + "/o /#";
            procInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"));
            // Start the process
            var process = System.Diagnostics.Process.Start(procInfo);
            // Wait for process to be created and enter idle condition
            process.WaitForInputIdle();
        }
    }
}
