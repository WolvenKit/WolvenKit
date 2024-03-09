using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using HandyControl.Data;
using ReactiveUI;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.Extensions;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Views.Dialogs.Windows;
using Application = System.Windows.Application;
using DataFormats = System.Windows.DataFormats;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using TreeNode = Syncfusion.UI.Xaml.TreeGrid.TreeNode;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView : ReactiveUserControl<ProjectExplorerViewModel>
    {
        /// <summary>Identifies the <see cref="TreeItemSource"/> dependency property.</summary>
        public static readonly DependencyProperty TreeItemSourceProperty =
            DependencyProperty.Register(nameof(TreeItemSource), typeof(ObservableCollection<FileModel>),
                typeof(ProjectExplorerView), new PropertyMetadata(null));

        public ObservableCollection<FileModel> TreeItemSource
        {
            get => (ObservableCollection<FileModel>)GetValue(TreeItemSourceProperty);
            set => SetValue(TreeItemSourceProperty, value);
        }

        public static readonly DependencyProperty FlatItemSourceProperty =
            DependencyProperty.Register(nameof(FlatItemSource), typeof(ObservableCollection<FileModel>),
                typeof(ProjectExplorerView), new PropertyMetadata(null));


        // Shift: fold/unfold child nodes
        private static bool IsShiftBeingHeld => Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);

        // Ctrl: copy file on drag&drop instead of moving
        private static bool IsControlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);

        
        public ObservableCollection<FileModel> FlatItemSource
        {
            get => (ObservableCollection<FileModel>)GetValue(FlatItemSourceProperty);
            set => SetValue(FlatItemSourceProperty, value);
        }

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

            TreeGrid.MouseDown += TreeGrid_MouseDown;

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            

            this.WhenActivated(disposables =>
            {
                if (DataContext is ProjectExplorerViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                AddKeyUpEvent();

                Interactions.DeleteFiles = _ =>
                {
                    var result = AdonisUI.Controls.MessageBox.Show(
                    "The selected item(s) will be moved to the Recycle Bin.",
                    "WolvenKit",
                    AdonisUI.Controls.MessageBoxButton.OKCancel,
                    AdonisUI.Controls.MessageBoxImage.Information,
                    AdonisUI.Controls.MessageBoxResult.OK);

                    return result == AdonisUI.Controls.MessageBoxResult.OK;
                };

                Interactions.Rename = input =>
                    {
                        var dialog = new RenameDialog();
                        if (dialog.ViewModel is not null)
                        {
                            dialog.ViewModel.Text = input;
                        }

                        if (dialog.ViewModel is not RenameDialogViewModel innerVm
                            || dialog.ShowDialog(Application.Current.MainWindow) != true)
                        {
                            return "";
                        }

                        return innerVm.Text;

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

                //ViewModel?.ExpandAllCommand.Subscribe(x => ExpandAll());
                //ViewModel?.CollapseAllCommand.Subscribe(x => CollapseAll());
                //ViewModel?.ExpandChildrenCommand.Subscribe(x => ExpandChildren());
                //ViewModel?.CollapseChildrenCommand.Subscribe(x => CollapseChildren());

                

                //EventBindings
                Observable
                    .FromEventPattern(TreeGrid, nameof(TreeGrid.CellDoubleTapped))
                    .Subscribe(p => OnCellDoubleTapped(p.Sender, p.EventArgs as TreeGridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);

                Observable
                    .FromEventPattern(TreeGridFlat, nameof(TreeGridFlat.CellDoubleTapped))
                    .Subscribe(p => OnCellDoubleTapped(p.Sender, p.EventArgs as TreeGridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);


                this.BindCommand(ViewModel,
                    viewModel => viewModel.OpenRootFolderCommand,
                    view => view.OpenFolderButton);
                this.BindCommand(ViewModel,
                    viewModel => viewModel.RefreshCommand,
                    view => view.RefreshButton);

                this.WhenAnyValue(x => x.ViewModel.BindGrid1, x => x.ViewModel.IsFlatModeEnabled)
                    .Subscribe((_) =>
                    {
                        if (ViewModel?.IsFlatModeEnabled == true)
                        {
                            SetCurrentValue(FlatItemSourceProperty, ViewModel?.BindGrid1);
                        }
                        else
                        {
                            BeforeDataSourceUpdate();
                            SetCurrentValue(TreeItemSourceProperty, ViewModel?.BindGrid1);
                            AfterDataSourceUpdate();
                        }
                    });
            });
        }

        private void AddKeyUpEvent()
        {
            if (ViewModel?.IsKeyUpEventAssigned != true)
            {
                return;
            }

            // register to KeyUp because KeyDown doesn't forward "F2"
            KeyUp += OnKeyUp;
            ViewModel.IsKeyUpEventAssigned = true;
        }

        private Dictionary<string, bool> _nodeExpansionState;
        private string _selectedNodeState;

        private void BeforeDataSourceUpdate()
        {
            if (TreeGrid?.View == null || TreeGrid.View.Nodes.RootNodes.Count == 0)
            {
                return;
            }
            
            _selectedNodeState = ((FileModel)TreeGrid.SelectedItem)?.FullName;
            _nodeExpansionState = [];
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

                _nodeExpansionState.TryAdd(((FileModel)node.Item).FullName, node.IsExpanded);

                foreach (var childNode in node.ChildNodes)
                {
                    if (((FileModel)childNode.Item).IsDirectory)
                    {
                        GetStates(childNode);
                    }
                }
            }
        }

        private void AfterDataSourceUpdate()
        {
            if (TreeGrid?.View == null || TreeGrid.View.Nodes.RootNodes.Count == 0 || _nodeExpansionState is null)
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

            _nodeExpansionState = null;
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
                if (!_nodeExpansionState.TryGetValue(fullName, out var value) || value)
                {
                    TreeGrid.ExpandNode(node);
                }

                if (IsShiftBeingHeld) return;

                foreach (var childNode in node.ChildNodes)
                {
                    SetStates(childNode);
                }
            }
        }

        private void OnCellDoubleTapped(object _, TreeGridCellDoubleTappedEventArgs treeGridCellDoubleTappedEventArgs)
        {
            if (treeGridCellDoubleTappedEventArgs.Node.Item is FileModel model)
            {
                ViewModel?.GetAppViewModel().OpenFileCommand.SafeExecute(model);
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (PESearchBar.IsFocused)
            {
                return;
            }
            
            if (e.Key == Key.F2 )
            {
                ViewModel?.RenameFileCommand.SafeExecute(null);

            }
            else if (e.Key == Key.Delete)
            {
                ViewModel?.DeleteFileCommand.SafeExecute(null);

            }
        }

        private bool IsFirstTime { get; set; } = true;

        private void TreeGrid_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (ViewModel is null || TreeGrid?.View is null)
            {
                return;
            }

            TreeGrid.View.Filter = IsFileIn;
            TreeGrid.View.RefreshFilter();
            if (IsFirstTime)
            {
                IsFirstTime = false;
                return;
            }

            if (ViewModel?.LastSelected == null)
            {
                return;
            }

            TreeGrid.ExpandAllNodes();
            var rowIndex = TreeGrid.ResolveToRowIndex(ViewModel?.LastSelected);
            if (rowIndex <= -1)
            {
                return;
            }

            var q = TreeGrid.ResolveToRowIndex(rowIndex - 1);
            var columnIndex = TreeGrid.ResolveToStartColumnIndex();
            TreeGrid.ScrollInView(new RowColumnIndex(q, columnIndex));
            TreeGrid.SelectRows(q, q);

        }

        private void TreeGridFlat_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (ViewModel is null || TreeGridFlat?.View is null)
            {
                return;
            }

            TreeGridFlat.View.Filter = IsFileInFlat;
            TreeGridFlat.View.RefreshFilter();
            if (IsFirstTime)
            {
                IsFirstTime = false;
                return;
            }

            if (ViewModel?.LastSelected == null)
            {
                return;
            }

            var rowIndex = TreeGridFlat.ResolveToRowIndex(ViewModel?.LastSelected);
            if (rowIndex <= -1)
            {
                return;
            }

            var q = TreeGridFlat.ResolveToRowIndex(rowIndex - 1);
            var columnIndex = TreeGridFlat.ResolveToStartColumnIndex();
            TreeGridFlat.ScrollInView(new RowColumnIndex(q, columnIndex));
            TreeGridFlat.SelectRows(q, q);


        }

        private bool IsFileIn(object o)
        {
            if (tabControl == null || o is not FileModel fm)
            {
                return false;
            }

            // Filtered by search
            if (!string.IsNullOrWhiteSpace(_currentFolderQuery) && !fm.Name.Contains(_currentFolderQuery))
            {
                return false;
            }

            return tabControl.SelectedIndex switch
            {
                0 => fm.FullName.StartsWith(fm.Project.FileDirectory),
                1 => fm.FullName.StartsWith(fm.Project.ModDirectory),
                2 => fm.FullName.StartsWith(fm.Project.RawDirectory, StringComparison.CurrentCultureIgnoreCase),
                3 => fm.FullName.StartsWith(fm.Project.ResourcesDirectory),
                _ => true
            };
        }

        private bool IsFileInFlat(object o) => tabControl != null && o is FileModel fm && IsFileIn(o) && !fm.IsDirectory;

        private void tabControl_SelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (TreeGrid?.View is null)
            {
                return;
            }

            if (ViewModel?.IsFlatModeEnabled == true)
            {
                TreeGridFlat.View.Filter = IsFileInFlat;
                TreeGridFlat.View.RefreshFilter();
            }
            else
            {
                TreeGrid.View.Filter = IsFileIn;
                TreeGrid.View.RefreshFilter();
            }
        }

#pragma warning disable 1998

        #endregion Constructors

        private void ExpandChildren()
        {
            if (ViewModel is null) return;

            var model = ViewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.ExpandAllNodes(node);
        }

        private void ExpandChildren_OnClick(object sender, RoutedEventArgs e) => ExpandChildren();

        private void CollapseChildren()
        {
            if (ViewModel is null) return;

            var model = ViewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.CollapseAllNodes(node);
            TreeGrid.ExpandNode(node);
        }

        private void CollapseChildren_OnClick(object sender, RoutedEventArgs e) => CollapseChildren();

        private void ExpandAll() => TreeGrid.ExpandAllNodes();

        private void CollapseAll() => TreeGrid.CollapseAllNodes();

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e) => ExpandAll();

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e) => CollapseAll();

        private string _currentFolderQuery = "";

        private void PESearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            _currentFolderQuery = e.Info;

            if (ViewModel?.IsFlatModeEnabled == true)
            {
                TreeGridFlat.View.RefreshFilter();
            }
            else
            {
                // expand all
                TreeGrid.ExpandAllNodes();

                // filter programmatically
                TreeGrid.View.RefreshFilter();
            }
        }

        private bool _isDragging = false;

        private void RowDragDropController_DragStart(object sender, TreeGridRowDragStartEventArgs e) =>
            _isDragging = true;

        private void RowDragDropController_DragOver(object sender, TreeGridRowDragOverEventArgs e)
        {
            if (!e.Data.GetDataPresent("Nodes") ||
                e.Data.GetData("Nodes") is not ObservableCollection<TreeNode> treeNodes ||
                treeNodes[0].Item is not FileModel sourceFile ||
                e.TargetNode.Item is not FileModel targetFile)
            {
                return;
            }

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

        private void RowDragDropController_DragLeave(object sender, TreeGridRowDragLeaveEventArgs e) =>
            _isDragging = false;

        private async void RowDragDropController_Drop(object sender, TreeGridRowDropEventArgs e)
        {
            e.Handled = _isDragging; // which should be true at this point
            
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

                        var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop) ?? []);
                        await ProcessFileAction(files, targetDirectory, true);
                    }
                }
                else if (e.Data.GetDataPresent("Nodes"))
                {
                    if (e.Data.GetData("Nodes") is not ObservableCollection<TreeNode> treeNodes
                        || treeNodes.Count == 0
                        || e.TargetNode.Item is not FileModel targetFile)
                    {
                        return;
                    }

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
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        private void RowDragDropController_Dropped(object sender, TreeGridRowDroppedEventArgs e)
        {

        }

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

        private void SetChildExpansionStates(TreeNode node, bool? newExpansionStateOverride = null)
        {
            if (node.ChildNodes.Count == 0 || !node.ChildNodes.Any((x) => x.HasChildNodes))
            {
                return;
            }

            // Get current expansion state from first nested child node. newExpansionStateOverride param takes precedence.
            var actualExpansionState = node.ChildNodes
                .FirstOrDefault((x) => x.HasChildNodes)?.IsExpanded ?? false;

            // Node is expanded: Collapse child nodes
            if (newExpansionStateOverride == false || actualExpansionState)
            {
                foreach (var childNode in node.ChildNodes)
                {
                    TreeGrid.CollapseNode(childNode);
                }

                return;
            }

            // Node is collapsed: Expand child nodes
            foreach (var childNode in node.ChildNodes)
            {
                TreeGrid.ExpandNode(childNode);
                // Unless control is being held, let's collapse all child nodes first
                if (!IsControlBeingHeld && newExpansionStateOverride == null)
                {
                    SetChildExpansionStates(childNode, false);
                }
            }
        }

        /// <summary>
        /// Shift-clicking on a node will toggle its child expansion states
        /// </summary>
        private void TreeGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsShiftBeingHeld)
            {
                return;
            }

            // Get the node under the mouse cursor
            var originalSource = e.OriginalSource as FrameworkElement;

            var node = originalSource?.DataContext switch
            {
                TreeNode n => n,
                FileModel model => TreeGrid.View.Nodes.GetNode(model),
                _ => null
            };

            if (node is null)
            {
                return;
            }

            e.Handled = true;
            SetChildExpansionStates(node);
        }
    }
}
