using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using HandyControl.Data;
using ReactiveUI;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView : ReactiveUserControl<ProjectExplorerViewModel>
    {
        /// <summary>Identifies the <see cref="TreeItemSource"/> dependency property.</summary>
        public static readonly DependencyProperty TreeItemSourceProperty =
            DependencyProperty.Register(nameof(TreeItemSource), typeof(ObservableCollection<FileSystemModel>),
                typeof(ProjectExplorerView), new PropertyMetadata(null));

        public ObservableCollection<FileSystemModel> TreeItemSource
        {
            get => (ObservableCollection<FileSystemModel>)GetValue(TreeItemSourceProperty);
            set => SetValue(TreeItemSourceProperty, value);
        }

        public static readonly DependencyProperty FlatItemSourceProperty =
            DependencyProperty.Register(nameof(FlatItemSource), typeof(ObservableCollection<FileSystemModel>),
                typeof(ProjectExplorerView), new PropertyMetadata(null));
        
        public ObservableCollection<FileSystemModel> FlatItemSource
        {
            get => (ObservableCollection<FileSystemModel>)GetValue(FlatItemSourceProperty);
            set => SetValue(FlatItemSourceProperty, value);
        }

        private string _currentFolderQuery = "";
        private bool _isDragging;

        #region Constructors

        public ProjectExplorerView()
        {
            InitializeComponent();
            TreeGrid.ItemsSourceChanged += TreeGrid_ItemsSourceChanged;
            TreeGridFlat.ItemsSourceChanged += TreeGridFlat_ItemsSourceChanged;
            TreeGrid.RowDragDropController.DragStart += RowDragDropController_DragStart;
            TreeGrid.RowDragDropController.DragOver += RowDragDropController_DragOver;
            TreeGrid.RowDragDropController.Drop += RowDragDropController_Drop;
            TreeGrid.RowDragDropController.Dropped += RowDragDropController_Dropped;
            TreeGrid.RowDragDropController.CanAutoExpand = true;

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            TreeGrid.SortComparers.Add(new() { Comparer = new FilePathComparer(), PropertyName = "Name" });
            TreeGridFlat.SortComparers.Add(new() { Comparer = new FilePathComparer(), PropertyName = "GameRelativePath" });
            TreeGridFlat.SortComparers.Add(new() { Comparer = new FileSizeComparer(), PropertyName = "FileSizeStr" });

            TreeGrid.NodeExpanding += TreeGrid_OnNodeExpanding;
            TreeGrid.NodeExpanded += TreeGrid_OnNodeExpanded;
            TreeGrid.NodeCollapsing += TreeGrid_OnNodeCollapsing;
            TreeGrid.NodeCollapsed += TreeGrid_OnNodeCollapsed;
            

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

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.FileTree,
                        view => view.TreeGrid.ItemsSource)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.FileList,
                        view => view.TreeGridFlat.ItemsSource)
                    .DisposeWith(disposables);
            });
        }

        private void TreeGrid_OnNodeExpanding(object sender, NodeExpandingEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!_automatic)
            {
                if (ViewModel.ModifierViewStateService.IsShiftKeyPressed)
                {
                    _automatic = true;

                    ExpandAllNodes(e.Node);

                    _automatic = false;
                    return;
                }
            }
        }

        private void ExpandAllNodes(TreeNode node)
        {
            TreeGrid.ExpandAllNodes(node);
            if (ViewModel != null)
            {
                RecursiveStateSave(node.ChildNodes);
            }

            void RecursiveStateSave(TreeNodes childNodes)
            {
                foreach (var childNode in childNodes)
                {
                    if (childNode.Item is FileSystemModel fileSystemModel)
                    {
                        ViewModel!.ExpansionStateDictionary[fileSystemModel.RawRelativePath] = true;
                    }
                    RecursiveStateSave(childNode.ChildNodes);
                }
            }
        }

        private void CollapseAllNodes(TreeNode node)
        {
            if (ViewModel != null)
            {
                RecursiveStateSave(node.ChildNodes);
            }
            TreeGrid.CollapseAllNodes(node);
            void RecursiveStateSave(TreeNodes childNodes)
            {
                foreach (var childNode in childNodes)
                {
                    if (childNode.Item is FileSystemModel fileSystemModel)
                    {
                        ViewModel!.ExpansionStateDictionary[fileSystemModel.RawRelativePath] = false;
                    }
                    RecursiveStateSave(childNode.ChildNodes);
                }
            }
        }

        private void TreeGrid_OnNodeExpanded(object sender, NodeExpandedEventArgs e)
        {
            if (ViewModel is null || e.Node.Item is not FileSystemModel fileSystemModel)
            {
                return;
            }

            ViewModel.ExpansionStateDictionary[fileSystemModel.RawRelativePath] = true;
        }

        private bool _automatic;

        private void TreeGrid_OnNodeCollapsing(object sender, NodeCollapsingEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!_automatic)
            {
                if (ViewModel.ModifierViewStateService.IsCtrlKeyPressed && e.Node.HasChildNodes)
                {
                    _automatic = true;

                    e.Cancel = true;

                    var state = e.Node.ChildNodes[0].IsExpanded;
                    foreach (var childNode in e.Node.ChildNodes)
                    {
                        if (ViewModel.ModifierViewStateService.IsShiftKeyPressed)
                        {
                            if (state)
                            {
                                CollapseAllNodes(childNode);
                            }
                            else
                            {
                                ExpandAllNodes(childNode);
                            }
                        }
                        else
                        {
                            if (state)
                            {
                                TreeGrid.CollapseNode(childNode);
                            }
                            else
                            {
                                TreeGrid.ExpandNode(childNode);
                            }
                        }
                    }

                    _automatic = false;
                    return;
                }

                if (ViewModel.ModifierViewStateService.IsShiftKeyPressed)
                {
                    _automatic = true;

                    CollapseAllNodes(e.Node);

                    _automatic = false;
                    return;
                }
            }
        }

        private void TreeGrid_OnNodeCollapsed(object sender, NodeCollapsedEventArgs e)
        {
            if (ViewModel is null || e.Node.Item is not FileSystemModel fileSystemModel)
            {
                return;
            }

            ViewModel.ExpansionStateDictionary[fileSystemModel.RawRelativePath] = false;
        }

        private void AddKeyUpEvent()
        {
            if (ViewModel is null || ViewModel.IsKeyUpEventAssigned)
            {
                return;
            }

            // register to KeyUp because KeyDown doesn't forward "F2"
            KeyUp += OnKeyUp;
            KeyDown += OnKeyStateChanged; 
            ViewModel.IsKeyUpEventAssigned = true;
        }

        private void OnCellDoubleTapped(object sender, TreeGridCellDoubleTappedEventArgs e)
        {
            if (e.Node.Item is not FileSystemModel model)
            {
                return;
            }

            if (!model.IsDirectory)
            {
                ViewModel?.GetAppViewModel().OpenFileCommand.SafeExecute(model);
                return;
            }

            if (sender is not SfTreeGrid { Name: nameof(TreeGrid) })
            {
                return;
            }

            if (e.Node.IsExpanded)
            {
                TreeGrid.CollapseNode(e.Node);
            }
            else
            {
                TreeGrid.ExpandNode(e.Node);
            }
        }

        /// <summary>
        /// Called from view on keyup/keydown event. Synchronises modifier state with ModifierViewStateModel.
        /// </summary>
        private void OnKeyStateChanged(object sender, KeyEventArgs e) => ViewModel?.RefreshModifierStates();

        /// <summary>
        /// Called from view on key down event. Handles search bar and rename/delete commands.
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            // For context menu switching
            OnKeyStateChanged(sender, e);
            
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

        private void TreeGrid_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (TreeGrid?.View is null)
            {
                return;
            }

            TreeGrid.View.NodeCollectionChanged += View_OnNodeCollectionChanged;

            TreeGrid.View.Filter = IsFileIn;
            TreeGrid.View.RefreshFilter();
        }

        private void View_OnNodeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is not TreeNode { Item: FileSystemModel { IsDirectory: true } fileSystemModel } treeNode)
                    {
                        continue;
                    }

                    if (ViewModel.GetExpansionState(fileSystemModel.RawRelativePath))
                    {
                        TreeGrid.ExpandNode(treeNode);
                    }
                }
            }

            if (e.Action == NotifyCollectionChangedAction.Remove && e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    if (item is not TreeNode { Item: FileSystemModel { IsDirectory: true } fileSystemModel } treeNode)
                    {
                        continue;
                    }

                    ViewModel.ExpansionStateDictionary.Remove(fileSystemModel.RawRelativePath);
                }
            }
        }

        private void TreeGridFlat_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (TreeGridFlat?.View is null)
            {
                return;
            }

            TreeGridFlat.View.Filter = IsFileInFlat;
            TreeGridFlat.View.RefreshFilter();
        }

        private bool IsFileIn(object o)
        {
            if (tabControl == null || o is not FileSystemModel fm)
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
                0 => true,
                1 => fm.RawRelativePath.StartsWith("archive"),
                2 => fm.RawRelativePath.StartsWith("raw", StringComparison.CurrentCultureIgnoreCase),
                3 => fm.RawRelativePath.StartsWith("resources"),
                _ => true
            };
        }

        private bool IsFileInFlat(object o) => tabControl != null && o is FileSystemModel fm && IsFileIn(o) && !fm.IsDirectory;

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

        #endregion Constructors

        private void ExpandChildren_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            var model = ViewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            ExpandAllNodes(node);
        }

        private void CollapseChildren_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            var model = ViewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            CollapseAllNodes(node);
            TreeGrid.ExpandNode(node);
        }

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e)
        {
            foreach (var viewNode in TreeGrid.View.Nodes)
            {
                if (viewNode.Item is not FileSystemModel || IsFileIn(viewNode.Item))
                {
                    ExpandAllNodes(viewNode);
                }
            }
        }

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e)
        {
            foreach (var viewNode in TreeGrid.View.Nodes)
            {
                if (viewNode.Item is not FileSystemModel || IsFileIn(viewNode.Item))
                {
                    CollapseAllNodes(viewNode);
                }
            }
        }

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

        private void RowDragDropController_DragStart(object sender, TreeGridRowDragStartEventArgs e) =>
            _isDragging = true;

        private void RowDragDropController_DragOver(object sender, TreeGridRowDragOverEventArgs e)
        {
            if (!e.Data.GetDataPresent("Nodes") ||
                e.Data.GetData("Nodes") is not ObservableCollection<TreeNode> treeNodes ||
                treeNodes[0].Item is not FileSystemModel sourceFile ||
                e.TargetNode.Item is not FileSystemModel targetFile)
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

        private async void RowDragDropController_Drop(object sender, TreeGridRowDropEventArgs e)
        {
            e.Handled = _isDragging; // which should be true at this point
            
            // this should all be somewhere else, right?
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    if (e.TargetNode.Item is not FileSystemModel targetFile)
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
                        || e.TargetNode.Item is not FileSystemModel targetFile)
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
                        if (node.Item is FileSystemModel sourceFile)
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
        private void RowDragDropController_Dropped(object sender, TreeGridRowDroppedEventArgs e) => 
            _isDragging = false;

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
                .Select(s => s.Replace(targetDirectory, "").TrimStart(Path.DirectorySeparatorChar)).OrderBy(s => s).Distinct()
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

        private class FilePathComparer : IComparer<object>, ISortDirection
        {
            public int Compare(object x, object y)
            {
                var item1 = x as FileSystemModel;
                var item2 = y as FileSystemModel;
                var c = 0;

                if (item1 != null && item2 == null)
                {
                    c = -1;
                }
                else if (item1 == null && item2 != null)
                {
                    c = 1;
                }
                else if (item1 != null && item2 != null)
                {
                    if (item1.IsDirectory && !item2.IsDirectory)
                    {
                        c = -1;
                    }
                    else if (!item1.IsDirectory && item2.IsDirectory)
                    {
                        c = 1;
                    }
                    else
                    {
                        c = CompareParts();
                        if (c == 0)
                        {
                            c = string.CompareOrdinal(item1.GameRelativePath, item2.GameRelativePath);
                        }
                    }
                }

                if (SortDirection == ListSortDirection.Descending)
                {
                    c = -c;
                }

                return c;

                int CompareParts()
                {
                    var item1Parts = item1.GameRelativePath.Split(Path.DirectorySeparatorChar);
                    var item2Parts = item2.GameRelativePath.Split(Path.DirectorySeparatorChar);

                    if (item1Parts.Length != item2Parts.Length)
                    {
                        return item1Parts.Length.CompareTo(item2Parts.Length);
                    }

                    for (var i = 0; i < Math.Min(item1Parts.Length, item2Parts.Length); i++)
                    {
                        var result = string.CompareOrdinal(item1Parts[i], item2Parts[i]);
                        if (result != 0)
                        {
                            return result;
                        }
                    }

                    return 0;
                }
            }

            public ListSortDirection SortDirection { get; set; }
        }

        private class FileSizeComparer : IComparer<object>, ISortDirection
        {
            public int Compare(object x, object y)
            {
                var item1 = x as FileSystemModel;
                var item2 = y as FileSystemModel;
                var c = 0;

                if (item1 != null && item2 == null)
                {
                    c = -1;
                }
                else if (item1 == null && item2 != null)
                {
                    c = 1;
                }
                else if (item1 != null && item2 != null)
                {
                    c = item1.FileSize.CompareTo(item2.FileSize);
                }

                if (SortDirection == ListSortDirection.Descending)
                {
                    c = -c;
                }

                return c;
            }

            public ListSortDirection SortDirection { get; set; }
        }
    }
}
