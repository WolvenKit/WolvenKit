using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
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
using WolvenKit.Views.Dialogs;
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

            TreeGrid.MouseDoubleClick += TreeGrid_DoubleClicked;

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
                    };


                Interactions.AskForTextInput = () =>
                {
                    var dialog = new InputDialogView();

                    if (dialog.ViewModel is not InputDialogViewModel innerVm
                        || dialog.ShowDialog(Application.Current.MainWindow) != true)
                    {
                        return "";
                    }

                    return innerVm.Text;
                };
               

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

                void RefreshViewModel()
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
                }

                // Pulling these two apart makes sure that the view grid isn't refreshed twice
                // (node expansion states weren't ready on second time around)
                this.WhenAnyValue(x => x.ViewModel.BindGrid1)
                    .Subscribe((sender) => RefreshViewModel());
                this.WhenAnyValue(x => x.ViewModel.IsFlatModeEnabled)
                    .Subscribe((sender) => RefreshViewModel());
            });
        }

        private void AddKeyUpEvent()
        {
            if (ViewModel is null || ViewModel.IsKeyUpEventAssigned)
            {
                return;
            }

            // register to KeyUp because KeyDown doesn't forward "F2"
            KeyUp += OnKeyUp;
            KeyDown += OnKeystateChanged; 
            ViewModel.IsKeyUpEventAssigned = true;
        }

        private Dictionary<string, bool> _nodeExpansionState;
        private string _selectedNodeState;

        private void BeforeDataSourceUpdate()
        {
            if (_isRefreshing || TreeGrid?.View == null || TreeGrid.View.Nodes.RootNodes.Count == 0)
            {
                return;
            }

            _isRefreshing = true;

            _refreshTimer = new System.Timers.Timer(500);
            _refreshTimer.Elapsed += (s, e) => _isRefreshing = false;
            _refreshTimer.AutoReset = false;
            _refreshTimer.Start();
            
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

        private bool _isRefreshing = false;
        private System.Timers.Timer _refreshTimer;
        
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

            return; 
            
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
            
                if (ViewModel.ModifierViewStateService.IsShiftKeyPressed)
                {
                    return;
                }
            
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

        /// <summary>
        /// Called from view on keyup/keydown event. Synchronises modifier state with ModifierViewStateModel.
        /// </summary>
        private void OnKeystateChanged(object sender, KeyEventArgs e) => ViewModel?.RefreshModifierStates();

        /// <summary>
        /// Called from view on key down event. Handles search bar and rename/delete commands.
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            // For context menu switching
            OnKeystateChanged(sender, e);
            
            if (PESearchBar.IsFocused)
            {
                return;
            }
            if (e.Key == Key.F2 )
            {
                ViewModel?.RenameFileCommand.SafeExecute(null);
                return;
            }

            if (e.Key == Key.Delete)
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

        private void ExpandAll()
        {
            foreach (var viewNode in TreeGrid.View.Nodes)
            {
                if (viewNode.Item is not FileModel || IsFileIn(viewNode.Item))
                {
                    TreeGrid.ExpandAllNodes(viewNode);
                }
            }
        }

        private void CollapseAll()
        {
            foreach (var viewNode in TreeGrid.View.Nodes)
            {
                if (viewNode.Item is not FileModel || IsFileIn(viewNode.Item))
                {
                    TreeGrid.CollapseAllNodes(viewNode);
                }
            }
        }

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
                    if (e.TargetNode.Item is not FileModel targetFile)
                    {
                        return;
                    }

                    var targetDirectory = Path.GetDirectoryName(targetFile.FullName);
                    if (File.GetAttributes(targetFile.FullName).HasFlag(FileAttributes.Directory))
                    {
                        targetDirectory = targetFile.FullName;
                    }

                    var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop) ?? []);
                    await ProcessFileAction(files, targetDirectory);
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

                    await ProcessFileAction(files, targetDirectory);
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

        /// <summary>
        ///  Since the previous implementation would sometimes fail silently and claim that perfectly viable files weren't found,
        /// here's an attempt at implementing everything in a more robust way that's also more in line with windows move/copy behaviour.
        /// </summary>
        private async Task ProcessFileAction(IReadOnlyList<string> sourceFiles, string targetDirectory)
        {
            var isCopy = ViewModel?.ModifierViewStateService.GetModifierState(ModifierKeys.Control) == true;

            // Abort if a directory is dragged on itself or its parent
            if (!isCopy && sourceFiles.Count == 1 &&
                (sourceFiles[0] == targetDirectory || Path.GetDirectoryName(sourceFiles[0]) == targetDirectory))
            {
                return;
            }

            // Split files and directories apart for cleaner handling
            var directories = sourceFiles.Where(s => File.GetAttributes(s).HasFlag(FileAttributes.Directory)).ToList();

            // Create a dictionary to map source files to target files
            var fileMap = new Dictionary<string, string>();

            // Add files directly under the source directories to the map
            foreach (var sourceFile in sourceFiles.Where(s => !directories.Contains(s)))
            {
                var targetFile = Path.Combine(targetDirectory, Path.GetFileName(sourceFile));
                fileMap[sourceFile] = targetFile;
            }

            // Add files under the subdirectories of the source directories to the map
            foreach (var directory in directories.Where(Directory.Exists))
            {
                var directoryParent = Path.GetDirectoryName(directory) ?? directory;
                foreach (var sourceFile in Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories))
                {
                    // we don't care about directories, just about files
                    if (File.GetAttributes(sourceFile).HasFlag(FileAttributes.Directory))
                    {
                        continue;
                    }

                    var relativePath = sourceFile.Substring(directoryParent.Length).TrimStart(Path.DirectorySeparatorChar);
                    var targetFile = Path.Combine(targetDirectory, relativePath);
                    if (targetFile == sourceFile && isCopy)
                    {
                        var directoryName = Path.GetFileName(Path.GetDirectoryName(sourceFile)) ?? "INVALID";
                        relativePath = relativePath.Replace(directoryName, $"{directoryName} - Copy");
                        targetFile = Path.Combine(targetDirectory, relativePath);
                    }

                    fileMap[sourceFile] = targetFile;
                }
            }

            var existingFiles = fileMap.Values.Where(File.Exists)
                .Select(s => s.Replace(targetDirectory, "")).OrderBy(s => s).Distinct()
                .ToList();

            // If we have 0 - 10 files, we'll show one dialogue. Otherwise, we'll ask for each file individually.
            var isOverwrite = existingFiles.Count == 0;
            var isAskIndividually = existingFiles.Count > 10;

            if (existingFiles.Count is < 10 and > 0)
            {
                var messageBoxResult = await Interactions.ShowMessageBoxAsync(
                    $"Overwrite the following files? \n\n  {string.Join("\n  ", existingFiles)}",
                    "File Overwrite Confirmation", WMessageBoxButtons.YesNoCancel);

                if (messageBoxResult == WMessageBoxResult.Cancel)
                {
                    return;
                }

                isOverwrite = messageBoxResult == WMessageBoxResult.Yes;
            }

            foreach (var copyMe in fileMap)
            {
                var targetFile = copyMe.Value ?? "";

                var canWriteToTargetFile =
                    !File.Exists(targetFile)
                    || isOverwrite
                    || (isAskIndividually && await Interactions.ShowMessageBoxAsync(
                        $"Overwrite the following file? {targetFile}",
                        "File Overwrite Confirmation",
                        WMessageBoxButtons.YesNo) == WMessageBoxResult.Yes);
                if (!canWriteToTargetFile)
                {
                    if (!isCopy)
                    {
                        continue;
                    }

                    var filenameWithoutExtension = Path.GetFileNameWithoutExtension(targetFile);
                    targetFile = targetFile.Replace(filenameWithoutExtension, $"{filenameWithoutExtension} - Copy");
                }

                var containingDirectory = Path.GetDirectoryName(targetFile) ?? "";
                if (!Directory.Exists(containingDirectory))
                {
                    Directory.CreateDirectory(containingDirectory);
                }

                if (isCopy)
                {
                    File.Copy(copyMe.Key, targetFile, true);
                }
                else
                {
                    File.Move(copyMe.Key, targetFile, true);
                }
            }

            if (isCopy)
            {
                return;
            }

            foreach (var directory in directories.OrderByDescending(dir => dir.Length).ToList())
            {
                if (Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories).Any())
                {
                    continue;
                }

                Directory.Delete(directory, true);
            }
        }

        private void TreeGrid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        }

        /// <summary>
        /// Double-clicking on a node will toggle its child expansion states
        /// </summary>
        private void TreeGrid_DoubleClicked(object sender, MouseButtonEventArgs e)
        {
            // Get the node under the mouse cursor
            var originalSource = e.OriginalSource as FrameworkElement;

            var node = originalSource?.DataContext switch
            {
                TreeNode n => n,
                FileModel model => TreeGrid.View.Nodes.GetNode(model),
                _ => null
            };

            if (node is null || node.ChildNodes.Count == 0 || !node.ChildNodes.Any((x) => x.HasChildNodes))
            {
                return;
            }

            // Get current expansion state from first nested child node. newExpansionStateOverride param takes precedence.
            var actualExpansionState = node.ChildNodes
                .FirstOrDefault((x) => x.HasChildNodes)?.IsExpanded ?? false;

            e.Handled = true;
            foreach (var childNode in node.ChildNodes)
            {
                if (actualExpansionState)
                {
                    TreeGrid.CollapseNode(childNode);
                    continue;
                }

                // Disable collapsing of child nodes with Ctrl
                if (ViewModel is { ModifierViewStateService.IsCtrlKeyPressed: false })
                {
                    TreeGrid.CollapseAllNodes(childNode);
                }

                TreeGrid.ExpandNode(childNode);
            }
            // SetChildExpansionStates(node);
        }
    }
}
