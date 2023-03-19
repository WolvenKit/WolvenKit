using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using HandyControl.Data;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.Extensions;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView : ReactiveUserControl<ProjectExplorerViewModel>
    {
        #region Constructors

        public ProjectExplorerView()
        {
            InitializeComponent();
            TreeGrid.ItemsSourceChanged += TreeGrid_ItemsSourceChanged;
            TreeGridFlat.ItemsSourceChanged += TreeGridFlat_ItemsSourceChanged;
            TreeGrid.RowDragDropController.DragStart += RowDragDropController_DragStart;
            TreeGrid.RowDragDropController.DragOver += RowDragDropController_DragOver;
            TreeGrid.RowDragDropController.DragLeave += RowDragDropController_DragLeave;
            TreeGrid.RowDragDropController.Drop += RowDragDropController_Drop;
            TreeGrid.RowDragDropController.Dropped += RowDragDropController_Dropped;
            TreeGrid.RowDragDropController.CanAutoExpand = true;

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            ViewModel = Locator.Current.GetService<ProjectExplorerViewModel>();
            DataContext = ViewModel;

            ViewModel.BeforeDataSourceUpdate += OnBeforeDataSourceUpdate;
            ViewModel.AfterDataSourceUpdate += OnAfterDataSourceUpdate;

            this.WhenActivated(disposables =>
            {
                Interactions.DeleteFiles = input =>
                {
                    var count = input.Count();

                    var result = AdonisUI.Controls.MessageBox.Show(
                    "The selected item(s) will be moved to the Recycle Bin.",
                    "WolvenKit",
                    AdonisUI.Controls.MessageBoxButton.OKCancel,
                    AdonisUI.Controls.MessageBoxImage.Information,
                    AdonisUI.Controls.MessageBoxResult.OK);
                    if (result == AdonisUI.Controls.MessageBoxResult.OK)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                };

                Interactions.Rename = input =>
                    {
                        var dialog = new RenameDialog();
                        dialog.ViewModel.Text = input;

                        var result = "";
                        if (dialog.ShowDialog(Application.Current.MainWindow) == true)
                        {
                            var innerVm = dialog.ViewModel;

                            result = innerVm.Text;
                        }
                        return result;

                        //return Observable.Start(() =>
                        //{
                        //    var result = "";
                        //    if (dialog.ShowDialog(Application.Current.MainWindow) == true)
                        //    {
                        //        var innerVm = dialog.ViewModel;

                        //        result = innerVm.Text;
                        //    }

                        //    interaction.SetOutput(result);
                        //}, RxApp.MainThreadScheduler);
                    };

                //ViewModel.ExpandAllCommand.Subscribe(x => ExpandAll());
                //ViewModel.CollapseAllCommand.Subscribe(x => CollapseAll());
                //ViewModel.ExpandChildrenCommand.Subscribe(x => ExpandChildren());
                //ViewModel.CollapseChildrenCommand.Subscribe(x => CollapseChildren());

                

                //EventBindings
                Observable
                    .FromEventPattern(TreeGrid, nameof(TreeGrid.CellDoubleTapped))
                    .Subscribe(_ => OnCellDoubleTapped(_.Sender, _.EventArgs as TreeGridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);

                Observable
                    .FromEventPattern(TreeGridFlat, nameof(TreeGridFlat.CellDoubleTapped))
                    .Subscribe(_ => OnCellDoubleTapped(_.Sender, _.EventArgs as TreeGridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.BindGrid1,
                        view => view.TreeGrid.ItemsSource)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.BindGrid1,
                        view => view.TreeGridFlat.ItemsSource)
                    .DisposeWith(disposables);


                this.BindCommand(ViewModel,
                    viewModel => viewModel.OpenRootFolderCommand,
                    view => view.OpenFolderButton);
                this.BindCommand(ViewModel,
                    viewModel => viewModel.RefreshCommand,
                    view => view.RefreshButton);
            });

            AddKeyUpEvent();
        }

        private void AddKeyUpEvent()
        {
            if (ViewModel.IsKeyUpEventAssigned)
            {
                return;
            }

            // register to KeyUp because KeyDown doesn't forward "F2"
            KeyUp += OnKeyUp;
            ViewModel.IsKeyUpEventAssigned = true;
        }

        private Dictionary<string, bool> _nodeState;
        private string _selectedNodeState;

        private void OnBeforeDataSourceUpdate(object sender, EventArgs e)
        {
            if (TreeGrid?.View == null || TreeGrid.View.Nodes.RootNodes.Count == 0)
            {
                return;
            }

            _selectedNodeState = ((FileModel)TreeGrid.SelectedItem)?.FullName;
            _nodeState = new Dictionary<string, bool>();
            foreach (var node in TreeGrid.View.Nodes.RootNodes)
            {
                if (((FileModel)node.Item).IsDirectory)
                {
                    GetStates(node);
                }
            }
            
            void GetStates(TreeNode node)
            {
                if (!node.HasChildNodes)
                {
                    return;
                }

                _nodeState.TryAdd(((FileModel)node.Item).FullName, node.IsExpanded);

                foreach (var childNode in node.ChildNodes)
                {
                    if (((FileModel)childNode.Item).IsDirectory)
                    {
                        GetStates(childNode);
                    }
                }
            }
        }

        private void OnAfterDataSourceUpdate(object sender, EventArgs e)
        {
            if (TreeGrid?.View == null || TreeGrid.View.Nodes.RootNodes.Count == 0 || _nodeState == null)
            {
                return;
            }

            TreeGrid.CollapseAllNodes();
            foreach (var node in TreeGrid.View.Nodes.RootNodes)
            {
                if (((FileModel)node.Item).IsDirectory)
                {
                    SetStates(node);
                }
            }

            _nodeState = null;
            _selectedNodeState = null;
            
            void SetStates(TreeNode node)
            {
                if (((FileModel)node.Item).FullName == _selectedNodeState)
                {
                    TreeGrid.SetCurrentValue(SfGridBase.SelectedItemProperty, node.Item);
                }

                if (!node.HasChildNodes)
                {
                    return;
                }

                var fullName = ((FileModel)node.Item).FullName;
                if (!_nodeState.ContainsKey(fullName) || _nodeState[fullName])
                {
                    TreeGrid.ExpandNode(node);
                }

                foreach (var childNode in node.ChildNodes)
                {
                    SetStates(childNode);
                }
            }
        }

        private void OnCellDoubleTapped(object sender, TreeGridCellDoubleTappedEventArgs treeGridCellDoubleTappedEventArgs)
        {
            if (treeGridCellDoubleTappedEventArgs.Node.Item is FileModel model)
            {
                ViewModel.GetAppViewModel().OpenFileCommand.SafeExecute(model);
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 )
            {
                ViewModel.RenameFileCommand.SafeExecute(null);

            }
            else if (e.Key == Key.Delete)
            {
                ViewModel.DeleteFileCommand.SafeExecute(null);

            }
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
                TreeGrid.View.Filter = IsFileIn;
                TreeGrid.View.RefreshFilter();
                if (!_isfirsttime)
                {
                    if (viewModel.LastSelected != null)
                    {
                        TreeGrid.ExpandAllNodes();
                        var rowIndex = TreeGrid.ResolveToRowIndex(viewModel.LastSelected);
                        if (rowIndex > -1)
                        {
                            var q = TreeGrid.ResolveToRowIndex(rowIndex - 1);
                            var columnIndex = TreeGrid.ResolveToStartColumnIndex();
                            TreeGrid.ScrollInView(new RowColumnIndex(q, columnIndex));
                            TreeGrid.SelectRows(q, q);
                        }
                    }
                }
                else
                { _isfirsttime = false; }
            }
        }

        private void TreeGridFlat_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }
            if (TreeGridFlat == null)
            { return; }
            if (TreeGridFlat.View != null)
            {
                TreeGridFlat.View.Filter = IsFileInFlat;
                TreeGridFlat.View.RefreshFilter();
                if (!_isfirsttime)
                {
                    if (viewModel.LastSelected != null)
                    {
                        var rowIndex = TreeGridFlat.ResolveToRowIndex(viewModel.LastSelected);
                        if (rowIndex > -1)
                        {
                            var q = TreeGridFlat.ResolveToRowIndex(rowIndex - 1);
                            var columnIndex = TreeGridFlat.ResolveToStartColumnIndex();
                            TreeGridFlat.ScrollInView(new RowColumnIndex(q, columnIndex));
                            TreeGridFlat.SelectRows(q, q);
                        }
                    }
                }
                else
                { _isfirsttime = false; }
            }
        }

        private bool IsFileIn(object o)
        {
            var includeFile = false;
            if (tabControl != null && o is FileModel fm)
            {
                includeFile = true;
                switch (tabControl.SelectedIndex)
                {
                    case 0:
                        includeFile = fm.FullName.StartsWith(fm.Project.FileDirectory);
                        break;
                    case 1:
                        includeFile = fm.FullName.StartsWith(fm.Project.ModDirectory);
                        break;
                    case 2:
                        includeFile = fm.FullName.ToLower().StartsWith(fm.Project.RawDirectory.ToLower());
                        break;
                    case 3:
                        includeFile = fm.FullName.StartsWith(fm.Project.ResourcesDirectory);
                        break;
                    default:
                        break;
                }

                if (!string.IsNullOrWhiteSpace(_currentFolderQuery) && !fm.Name.Contains(_currentFolderQuery))
                {
                    includeFile = false;
                }
            }
            return includeFile;
        }

        private bool IsFileInFlat(object o) => tabControl != null && o is FileModel fm && IsFileIn(o) && !fm.IsDirectory;

        private void tabControl_SelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (TreeGrid != null && TreeGrid.View != null)
            {
                TreeGrid.View.Filter = IsFileIn;
                TreeGridFlat.View.Filter = IsFileInFlat;
                TreeGrid.View.RefreshFilter();
                TreeGridFlat.View.RefreshFilter();
            }
        }

#pragma warning disable 1998

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
            if (ViewModel is not { } viewModel)
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

        private void PESearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            // expand all
            TreeGrid.ExpandAllNodes();
            _currentFolderQuery = e.Info;

            // filter programmatially
            TreeGrid.View.RefreshFilter();
        }

        private void RowDragDropController_DragStart(object sender, TreeGridRowDragStartEventArgs e)
        {

        }
        private void RowDragDropController_DragOver(object sender, TreeGridRowDragOverEventArgs e)
        {
            if (e.Data.GetDataPresent("Nodes"))
            {
                if (e.Data.GetData("Nodes") is ObservableCollection<TreeNode> treeNodes && treeNodes[0].Item is FileModel sourceFile)
                {
                    if (e.TargetNode.Item is FileModel targetFile)
                    {
                        if (targetFile == sourceFile)
                        {
                            e.ShowDragUI = false;
                            e.Handled = true;
                        }
                        else
                        {
                            e.ShowDragUI = true;
                            e.Handled = false;
                        }
                    }
                }
            }
        }

        private void RowDragDropController_DragLeave(object sender, TreeGridRowDragLeaveEventArgs e)
        {

        }
        private async void RowDragDropController_Drop(object sender, TreeGridRowDropEventArgs e)
        {
            e.Handled = true;
            // this should all be somewhere else, right?
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    if (e.TargetNode.Item is FileModel targetFile)
                    {
                        var targetDirectory = Path.GetDirectoryName(targetFile.FullName);
                        if (File.GetAttributes(targetFile.FullName).HasFlag(FileAttributes.Directory))
                        {
                            targetDirectory = targetFile.FullName;
                        }
                        var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
                        await ProcessFileAction(files, targetDirectory, true);
                    }
                }
                else if (e.Data.GetDataPresent("Nodes"))
                {
                    var treeNodes = e.Data.GetData("Nodes") as ObservableCollection<TreeNode>;

                    if (treeNodes.Count == 0 || treeNodes == null)
                    {
                        return;
                    }

                    if (e.TargetNode.Item is FileModel targetFile)
                    {
                        var targetDirectory = Path.GetDirectoryName(targetFile.FullName);
                        if (File.GetAttributes(targetFile.FullName).HasFlag(FileAttributes.Directory))
                        {
                            targetDirectory = targetFile.FullName;
                        }
                        var files = new List<string>();
                        foreach (var node in treeNodes)
                        {
                            if (node.Item is FileModel sourceFile)
                            {
                                files.Add(sourceFile.FullName);
                            }
                        }
                        // 1146: addresses "prevent self-drag-and-drop" 
                        if (files.Count > 0 && files[0] == targetDirectory)
                        {
                            return;
                        }
                            
                        await ProcessFileAction(files, targetDirectory, false);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        private void RowDragDropController_Dropped(object sender, TreeGridRowDroppedEventArgs e)
        {

        }

        public bool IsControlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);

        private async Task ProcessFileAction(List<string> sourceFiles, string targetDirectory, bool onlyCopy)
        {
            foreach (var sourceFile in sourceFiles)
            {
                var newFile = Path.Combine(targetDirectory, Path.GetFileName(sourceFile));
                if (File.GetAttributes(sourceFile).HasFlag(FileAttributes.Directory))
                {
                    foreach (var dirPath in Directory.GetDirectories(sourceFile, "*", SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(sourceFile, newFile));
                    }

                    foreach (var newPath in Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(sourceFile, newFile), true);
                    }
                }
                else
                {
                    if (sourceFile == newFile)
                    {
                        return;
                    }

                    if (File.Exists(newFile))
                    {
                        if (await Interactions.ShowMessageBoxAsync("File already exists at that location - overwrite it?", "File Overwrite Confirmation", WMessageBoxButtons.YesNo) == WMessageBoxResult.No)
                        {
                            return;
                        }
                    }

                    if (IsControlBeingHeld || onlyCopy)
                    {
                        File.Copy(sourceFile, newFile, true);
                    }
                    else
                    {
                        File.Move(sourceFile, newFile, true);
                    }
                }
            }
        }

        private void TreeGrid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!StaticReferences.AllowVideoPreview)
            {
                return;
            }

            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                var dg = sender as SfTreeGrid;
                if (dg.SelectedItem == null)
                {
                    return;
                }
                var selected = dg.SelectedItem as FileModel;

                if (!selected.FullName.ToLower().Contains("bk2"))
                {
                    return;
                }

                var args = $"\"{selected.FullName}\" /I102 /p";
                var procInfo =
                    new System.Diagnostics.ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(),
                        "test.exe"))
                    {

                        Arguments = args,
                        WorkingDirectory = ISettingsManager.GetWorkDir()
                    };

                var process = Process.Start(procInfo);
                process?.WaitForInputIdle();
            }
        }
    }
}
