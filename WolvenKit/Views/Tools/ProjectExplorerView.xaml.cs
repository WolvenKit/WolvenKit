using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.Messaging;
using HandyControl.Data;
using ReactiveUI;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Services;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
using WolvenKit.Helpers;
using WolvenKit.Views.Templates;
using RowColumnIndex = Syncfusion.UI.Xaml.ScrollAxis.RowColumnIndex;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView :
        IRecipient<ChalkboardService.WillStartLoadingProjectFiles>,
        IRecipient<ChalkboardService.DidFinishLoadingProjectFiles>
    {
        #region fields

        private readonly IMessenger _messenger;

        private List<IDisposable> _disposables = [];

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
        private bool _automatic;
        private HashSet<string> _searchVisiblePaths;

        private readonly DispatcherTimer _searchDebounceTimer;
        private bool _isDragging;
        private CancellationTokenSource _deferRefreshTokenSource = new();

        /// <summary>
        /// When true, NodeExpanded/NodeCollapsed must not persist expansion state or write
        /// FileSystemModel.IsExpanded via the ViewModel. Used for search-driven expand/restore
        /// so bulk view operations do not dirtily rewrite the project tree state.
        /// </summary>
        private bool _suppressExpansionPersistence;

        /// <summary>
        /// True after search auto-expanded ancestors so clearing the query can restore
        /// ExpansionStateDictionary without re-touching an untouched tree.
        /// </summary>
        private bool _searchMutatedExpansion;

        #endregion fields

        #region Constructor

        public ProjectExplorerView()
        {
            InitializeComponent();

            _messenger = WeakReferenceMessenger.Default;
            _messenger.RegisterAll(this);

            // Debounce for live search
            _searchDebounceTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(350)
            };

            _searchDebounceTimer.Tick += SearchDebounceTimer_Tick;

            TreeGrid.ItemsSourceChanged += TreeGrid_ItemsSourceChanged;
            TreeGridFlat.ItemsSourceChanged += TreeGridFlat_ItemsSourceChanged;
            TreeGridFlat.SizeChanged += TreeGridFlat_SizeChanged;
            TreeGrid.RowDragDropController.DragStart += RowDragDropController_DragStart;
            TreeGrid.RowDragDropController.DragOver += RowDragDropController_DragOver;
            TreeGrid.RowDragDropController.Drop += RowDragDropController_Drop;
            TreeGrid.RowDragDropController.Dropped += RowDragDropController_Dropped;
            TreeGrid.RowDragDropController.CanAutoExpand = true;

            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;

            // PropertyName has to match the MappingName of the sorted column, or the comparer is never
            // consulted and the grid falls back to a plain string sort on the cell value.
            TreeGrid.SortComparers.Clear();
            TreeGrid.SortComparers.Add(new() { Comparer = new FileComparer.Nodes(), PropertyName = "Name" });
            TreeGridFlat.SortComparers.Add(new() { Comparer = new FileComparer.Nodes(), PropertyName = "Name" });
            TreeGridFlat.SortComparers.Add(new() { Comparer = new FileComparer.Paths(), PropertyName = "GameRelativePath" });
            TreeGridFlat.SortComparers.Add(new() { Comparer = new FileComparer.Sizes(), PropertyName = "FileSizeStr" });

            TreeGrid.NodeExpanding += TreeGrid_OnNodeExpanding;
            TreeGrid.NodeExpanded += TreeGrid_OnNodeExpanded;
            TreeGrid.NodeCollapsing += TreeGrid_OnNodeCollapsing;
            TreeGrid.NodeCollapsed += TreeGrid_OnNodeCollapsed;

            TreeGrid.NotificationSubscriptionMode = NotificationSubscriptionMode.CollectionChange;

            // AllowDataShaping makes nodes added at runtime (drag & drop, paste, import, watcher events)
            // land in their sorted position instead of being appended to the end of their parent.
            // Bulk project loading is not affected: it runs inside the DeferRefresh bracket opened by
            // Receive(WillStartLoadingProjectFiles), which suppresses shaping until the load finishes.
            TreeGrid.LiveNodeUpdateMode = LiveNodeUpdateMode.AllowDataShaping;
            TreeGridFlat.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;

            this.WhenActivated(disposables =>
            {
                if (DataContext is ProjectExplorerViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                    vm.OnProjectChanged += ResetUiElements;
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

                Interactions.ShowDeleteOrMoveFilesList = (args) =>
                {
                    var list = args.files.Order(new FileComparer.PathStrings());
                    var dialog = new DeleteOrMoveFilesListDialogView(args.title, list.ToList(), args.currentProject);

                    if (dialog.ShowDialog(Application.Current.MainWindow) != true ||
                        dialog.ViewModel is not DeleteOrMoveFilesListDialogViewModel viewModel)
                    {
                        return ([], null);
                    }

                    return (viewModel.Files, viewModel.MoveToPath);
                };

                Interactions.ShowDictionaryAsCopyableList = (args) =>
                {
                    var comparer = new FileComparer.Paths();
                    var dialog = new ShowDictionaryForCopyDialogView(args);
                    return dialog.ShowDialog(Application.Current.MainWindow) == true;
                };

                Interactions.RenameAndRefactor = input =>
                {
                    var result = ShowRenameDialog(input.currentPath, input.showCheckbox);
                    return new Tuple<string, bool>(result.Text, result.EnableRefactoring);
                };

                Interactions.Rename = input => ShowRenameDialog(input).Text;

                Interactions.AskForTextInput = (args) =>
                {
                    var dialog = new InputDialogView(args.Item1, args.Item2);

                    if (dialog.ViewModel is not InputDialogViewModel innerVm
                        || dialog.ShowDialog(Application.Current.MainWindow) != true)
                    {
                        return "";
                    }

                    return innerVm.Text;
                };

                Interactions.AskForSceneInput = (parameters) =>
                {
                    var dialog = new SceneInputDialogView(parameters);
                    var result = dialog.ShowDialog();
                    return result == true ? (dialog.PrimaryInput, dialog.EnableSecondaryInput, dialog.SecondaryInput, dialog.DropdownValue) : (null, false, null, null);
                };

                Interactions.AskForFolderPathInput = (args) =>
                {
                    var dialog = new FolderPathInputDialogView(args.Item2, args.Item1);

                    if (dialog.ViewModel is not FolderPathInputDialogViewModel innerVm
                        || dialog.ShowDialog(Application.Current.MainWindow) != true)
                    {
                        return "";
                    }

                    return innerVm.Text;
                };

                Interactions.AskForDropdownOption = (args) =>
                {
                    var dialog = new SelectDropdownEntryWindow(args.options, args.title, args.text,
                        args.helpLink ?? "",
                        args.buttonText ?? "",
                        args.showInputBar ?? false);

                    if (dialog.ViewModel is not SelectDropdownEntryDialogViewModel innerVm
                        || dialog.ShowDialog(Application.Current.MainWindow) != true)
                    {
                        return "";
                    }

                    return innerVm.SelectedOption;
                };

                //EventBindings
                Observable
                    .FromEventPattern(TreeGrid, nameof(TreeGrid.CellDoubleTapped))
                    .Subscribe(p => OnCellDoubleTapped(p.Sender, p.EventArgs as TreeGridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);

                Observable
                    .FromEventPattern(TreeGridFlat, nameof(TreeGridFlat.CellDoubleTapped))
                    .Subscribe(p => OnFlatCellDoubleTapped(p.Sender, p.EventArgs as GridCellDoubleTappedEventArgs))
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel.ToggleFlatModeCommand,
                        view => view.ToggleFlatModeButton)
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

                ViewModel.OnToggleFlatMode += OnToggleFlatMode;
                ViewModel.BeginDeferredRefreshContext += BeginDeferredRefreshContext;

            });
        }

        #endregion

        #region Project_Loading

        public void Receive(ChalkboardService.WillStartLoadingProjectFiles msg)
        {
            DispatcherHelper.RunOnMainThread(() =>
            {
                if (TreeGridFlat.View is { } flatView)
                {
                    _disposables.Add(flatView.DeferRefresh());
                }

                if (TreeGrid.View is { } treeView)
                {
                    _disposables.Add(treeView.DeferRefresh(TreeViewRefreshMode.DeferRefresh));
                }
            });
        }

        public void Receive(ChalkboardService.DidFinishLoadingProjectFiles msg) =>
            DispatcherHelper.RunOnMainThread(() =>
            {
                _disposables.ForEach(d => d.Dispose());
                _disposables.Clear();
            });

        #endregion Project_Loading

        #region refresh

        // Run inside Dispatcher to avoid exception on startup
        private void ResetUiElements() => Dispatcher.Invoke(() =>
        {
            // Hide loading text
            LoadingText.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

            _currentFolderQuery = "";
            // Set search bar to empty if it wasn't
            PESearchBar?.SetCurrentValue(System.Windows.Controls.TextBox.TextProperty, "");

            // now handle the grids
            if (TreeGridFlat.View is not null)
            {
                TreeGridFlat.ClearFilters();
                TreeGridFlat.ClearSelections(false);
            }

            if (TreeGrid.View is not null)
            {
                TreeGrid.ClearFilters();
                TreeGrid.ClearSelections(false);
            }
        });

        private async Task BeginDeferredRefreshContext(Func<Task> doBeforeRefresh)
        {
            CompositeDisposable disposables =
            [
                TreeGridFlat.View.DeferRefresh(),
                TreeGrid.View.DeferRefresh(TreeViewRefreshMode.DeferRefresh)
            ];

            using (disposables)
            {
                await doBeforeRefresh();
                DispatcherHelper.PostOnMainThread(() =>
                {
                    TreeGridFlat.View.Filter = IsFileInFlat;
                    TreeGridFlat.View.Refresh();

                    Task.Run(() =>
                    {
                        DispatcherHelper.DelayOnMainThread(() =>
                        {
                            Dispatcher.BeginInvoke(() =>
                            {
                                if (TreeGridFlat.IsVisible)
                                {
                                    RefreshFlatColumnWidths(TreeGridFlat);
                                }

                                PESearchBar.AppendText("");
                            }, DispatcherPriority.ApplicationIdle);
                        }, 10);
                    });
                }, DispatcherPriority.ContextIdle);
            }
        }

        private static void RefreshFlatColumnWidths(SfDataGrid grid)
        {
            if (grid.ActualWidth <= 0)
                return;
            grid.GridColumnSizer?.Refresh();
        }

        #endregion refresh

        #region menus & toggles

        private static (string Text, bool EnableRefactoring) ShowRenameDialog(string input, bool showCheckbox = false)
        {
            var dialog = new RenameDialog(showCheckbox);
            if (dialog.ViewModel is not null)
            {
                dialog.ViewModel.Text = input;
                dialog.ViewModel.Title = "Enter new file name";
            }

            if (dialog.ViewModel is not RenameDialogViewModel innerVm
                || dialog.ShowDialog(Application.Current.MainWindow) != true)
            {
                return (string.Empty, false);
            }

            return (innerVm.Text, innerVm.EnableRefactoring == true);
        }

        // Not sure why the property binding broke, but it did. This fixes it.
        private void OnToggleFlatMode(object sender, EventArgs e)
        {
            if (sender is not ProjectExplorerViewModel model)
            {
                return;
            }

            if (model.IsFlatModeEnabled)
            {
                TreeGrid.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                TreeGridFlat.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            }
            else
            {
                TreeGrid.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                TreeGridFlat.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            }

            ReapplyCurrentSearchFilter(expandAllForSearch: !string.IsNullOrWhiteSpace(_currentFolderQuery));
        }

        private void OnContextMenuOpen(object sender, ContextMenuEventArgs e)
        {
            ViewModel?.ModifierStateService.RefreshModifierStates();
        }

        #endregion

        #region expand/collapse

        private void TreeGrid_OnNodeExpanding(object sender, NodeExpandingEventArgs e)
        {
            if (ViewModel is null || _automatic || !ModifierViewStateService.IsCtrlBeingHeld)
            {
                return;
            }

            _automatic = true;

            ExpandAllNodes(e.Node);

            _automatic = false;
        }

        private void ExpandAllNodes(TreeNode node)
        {
            TreeGrid.ExpandAllNodes(node);
            if (ViewModel != null && string.IsNullOrEmpty(_currentFolderQuery))
            {
                RecursiveStateSave(node.ChildNodes);
            }

            return;

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
            if (ViewModel != null && string.IsNullOrEmpty(_currentFolderQuery))
            {
                RecursiveStateSave(node.ChildNodes);
            }
            TreeGrid.CollapseAllNodes(node);

            return;
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
            if (ViewModel is null
                || _suppressExpansionPersistence
                || !string.IsNullOrEmpty(_currentFolderQuery)
                || e.Node.Item is not FileSystemModel fileSystemModel)
            {
                return;
            }

            ViewModel.SaveNodeExpansionState(fileSystemModel.RawRelativePath, true);
        }

        private void TreeGrid_OnNodeCollapsing(object sender, NodeCollapsingEventArgs e)
        {
            if (ViewModel is null || _automatic)
            {
                return;
            }

            if (ModifierViewStateService.IsCtrlBeingHeld && e.Node.HasChildNodes)
            {
                _automatic = true;
                e.Cancel = true;

                var state = e.Node.ChildNodes[0].IsExpanded;
                foreach (var childNode in e.Node.ChildNodes)
                {
                    if (ModifierViewStateService.IsShiftBeingHeld)
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

            if (!ModifierViewStateService.IsShiftBeingHeld)
            {
                return;
            }

            _automatic = true;

            CollapseAllNodes(e.Node);

            _automatic = false;
        }

        private void TreeGrid_OnNodeCollapsed(object sender, NodeCollapsedEventArgs e)
        {
            if (ViewModel is null
                || _suppressExpansionPersistence
                || !string.IsNullOrEmpty(_currentFolderQuery)
                || e.Node.Item is not FileSystemModel fileSystemModel)
            {
                return;
            }

            ViewModel.SaveNodeExpansionState(fileSystemModel.RawRelativePath, false);
        }

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

        private void RestoreExpansionRecursive(IEnumerable<TreeNode> nodes)
        {
            if (ViewModel is null || nodes is null)
            {
                return;
            }

            foreach (var node in nodes)
            {
                if (node.Item is not FileSystemModel { IsDirectory: true } model)
                {
                    continue;
                }

                // Depth-first: fix children before this node so collapsing a parent
                // does not leave child model/view state inconsistent.
                if (node.ChildNodes is { Count: > 0 })
                {
                    RestoreExpansionRecursive(node.ChildNodes);
                }

                // Paths never recorded stay collapsed after search (search may have opened them).
                var desired = ViewModel.GetExpansionStateOrNull(model.RawRelativePath) is true;

                if (desired)
                {
                    if (!node.IsExpanded)
                    {
                        TreeGrid.ExpandNode(node);
                    }
                }
                else if (node.IsExpanded)
                {
                    TreeGrid.CollapseNode(node);
                }
            }
        }

        private void ExpandParent(TreeNode activeFileNode)
        {
            if (activeFileNode.ParentNode is null)
            {
                TreeGrid?.ExpandNode(activeFileNode);
                return;
            }

            ExpandParent(activeFileNode.ParentNode);
            TreeGrid?.ExpandNode(activeFileNode.ParentNode);
        }

        #endregion expand/collapse

        #region grid responders

        private void ScrollToOpenFile_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel?.GetActiveEditorFile() is not IDocumentViewModel activeFile)
            {
                return;
            }

            var activeFileNode =
                TreeGrid.View.Nodes.FirstOrDefault(node => node.Item is FileSystemModel model && model.FullName == activeFile.FilePath);
            activeFileNode ??= GetTreeNode(activeFile.FilePath, TreeGrid.View.Nodes.FirstOrDefault());

            if (activeFileNode is null)
            {
                return;
            }

            ExpandParent(activeFileNode);

            TreeGrid.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SfGridBase.SelectedItemProperty, activeFileNode);

            ViewModel.SelectedItem = activeFileNode.Item as FileSystemModel;

            var rowIndex = TreeGrid.ResolveToRowIndex(activeFileNode);
            var columnIndex = TreeGrid.ResolveToStartColumnIndex();
            TreeGrid.ScrollInView(new RowColumnIndex(rowIndex, columnIndex));
            TreeGrid.View.MoveCurrentToPosition(rowIndex);
        }

        private static TreeNode GetTreeNode(string filePath, TreeNode node)
        {
            if (node.Item is FileSystemModel model && model.FullName == filePath)
            {
                return node;
            }

            return node.ChildNodes.Aggregate<TreeNode, TreeNode>(null,
                (current, nodeChildNode) => current ?? GetTreeNode(filePath, nodeChildNode));
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

            if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems is not null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is not TreeNode { Item: FileSystemModel { IsDirectory: true } fileSystemModel } treeNode)
                    {
                        continue;
                    }

                    if (ViewModel.GetExpansionStateOrNull(fileSystemModel.RawRelativePath) is true or null)
                    {
                        TreeGrid.ExpandNode(treeNode);
                    }
                }
            }

            if (e.Action != NotifyCollectionChangedAction.Remove || e.OldItems == null || !string.IsNullOrEmpty(_currentFolderQuery))
            {
                return;
            }

            foreach (var item in e.OldItems)
            {
                if (item is not TreeNode { Item: FileSystemModel { IsDirectory: true } fileSystemModel })
                {
                    continue;
                }

                ViewModel.ExpansionStateDictionary.Remove(fileSystemModel.RawRelativePath);
            }
        }

        private void TreeGridFlat_ItemsSourceChanged(object sender, GridItemsSourceChangedEventArgs e)
        {
            if (TreeGridFlat?.View is null)
            {
                return;
            }

            TreeGridFlat.View.Filter = IsFileInFlat;
            TreeGridFlat.View.RefreshFilter();
        }

        private void TreeGridFlat_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (TreeGridFlat.IsVisible)
            {
                RefreshFlatColumnWidths(TreeGridFlat);
            }
        }

        private void OnCellDoubleTapped(object sender, TreeGridCellDoubleTappedEventArgs e)
        {
            if (e?.Node?.Item is not FileSystemModel model)
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

        private void OnFlatCellDoubleTapped(object sender, GridCellDoubleTappedEventArgs e)
        {
            if (e?.Record is not FileSystemModel model || model.IsDirectory)
            {
                return;
            }

            ViewModel?.GetAppViewModel().OpenFileCommand.SafeExecute(model);
        }

        private void TreeIcon_Loaded(object sender, RoutedEventArgs e)
        {
            // NOTE: Margin="0" is not applied using XAML. This is likely due
            //       to the use of virtualization and DataTemplate. This
            //       workaround to define expected values after view is loaded.
            var view = sender as IconBox;

            view.SetCurrentValue(IconBox.MarginProperty, new Thickness(0));
            view.SetResourceReference(IconBox.SizeProperty, "WolvenKitIconNano");
        }

        #endregion grid responders

        #region search/filter

        private bool IsFileIn(object o)
        {
            if (tabControl == null || o is not FileSystemModel fm)
            {
                return false;
            }

            // Search filter: keep the node if it is a match or an ancestor of a match.
            // Without this, matching leaves under non-matching folders are unreachable.
            if (_searchVisiblePaths is not null
                && !_searchVisiblePaths.Contains(fm.RawRelativePath))
            {
                return false;
            }

            return tabControl.SelectedIndex switch
            {
                0 => true,
                1 => IsFileInInternal("archive"),
                2 => IsFileInInternal("raw"),
                3 => IsFileInInternal("resources"),
                _ => true
            };

            bool IsFileInInternal(string folder)
            {
                return fm.RawRelativePath == folder ||
                       fm.RawRelativePath.StartsWith($"{folder}{Path.DirectorySeparatorChar}");
            }
        }

        private bool MatchesSearchQuery(FileSystemModel fm)
        {
            if (string.IsNullOrWhiteSpace(_currentFolderQuery))
            {
                return true;
            }

            return fm.Name.Contains(_currentFolderQuery, StringComparison.OrdinalIgnoreCase)
                   || fm.RawRelativePath.Contains(_currentFolderQuery, StringComparison.OrdinalIgnoreCase);
        }

        private void RebuildSearchVisiblePaths()
        {
            if (string.IsNullOrWhiteSpace(_currentFolderQuery) || ViewModel is null)
            {
                _searchVisiblePaths = null;
                return;
            }

            var visible = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var fm in ViewModel.FileList)
            {
                if (!MatchesSearchQuery(fm))
                {
                    continue;
                }

                for (var p = fm; p is not null; p = p.Parent)
                {
                    // Once an ancestor is already present, higher ones are too — stop walking.
                    if (!visible.Add(p.RawRelativePath))
                    {
                        break;
                    }
                }
            }

            _searchVisiblePaths = visible;
        }

        private bool IsFileInFlat(object o) => tabControl != null && o is FileSystemModel fm && IsFileIn(o) && !fm.IsDirectory;

        private void TabControl_SelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
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

        private void SearchDebounceTimer_Tick(object sender, EventArgs e)
        {
            _searchDebounceTimer.Stop();

            if (PESearchBar == null)
                return;

            _currentFolderQuery = PESearchBar.Text ?? string.Empty;
            ReapplyCurrentSearchFilter(expandAllForSearch: !string.IsNullOrWhiteSpace(_currentFolderQuery));
        }

        private void PESearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PESearchBar == null)
                return;

            _searchDebounceTimer.Stop();
            _searchDebounceTimer.Start();
        }

        private void ReapplyCurrentSearchFilter(bool expandAllForSearch)
        {
            bool searchBarHadFocus = PESearchBar != null && PESearchBar.IsKeyboardFocused;
            var hasQuery = !string.IsNullOrWhiteSpace(_currentFolderQuery);

            // Must run before RefreshFilter so IsFileIn sees the up-to-date ancestor set.
            RebuildSearchVisiblePaths();

            if (TreeGridFlat?.View is not null)
            {
                TreeGridFlat.View.Filter = IsFileInFlat;
                TreeGridFlat.View.RefreshFilter();
            }

            if (TreeGrid?.View is not null)
            {
                TreeGrid.View.Filter = IsFileIn;
                // Filter first so only relevant hierarchy is considered for expand.
                TreeGrid.View.RefreshFilter();

                if (expandAllForSearch && hasQuery)
                {
                    ExpandAncestorsOfSearchMatches();
                }
                else if (!hasQuery && _searchMutatedExpansion)
                {
                    RestoreExpansionStateAfterSearch();
                    _searchMutatedExpansion = false;
                }
            }

            if (searchBarHadFocus)
            {
                DispatcherHelper.RunOnMainThread(() =>
                {
                    if (PESearchBar == null || PESearchBar.IsKeyboardFocused)
                        return;

                    Keyboard.Focus(PESearchBar);
                    PESearchBar.Focus();
                    PESearchBar.CaretIndex = PESearchBar.Text?.Length ?? 0;
                }, DispatcherPriority.ContextIdle);
            }
        }

        /// <summary>
        /// Expands only directory ancestors of nodes that match the current search
        /// (and matching directories themselves). Avoids ExpandAllNodes, which walks the
        /// entire project and storms IsExpanded / expansion persistence.
        /// </summary>
        private void ExpandAncestorsOfSearchMatches()
        {
            if (ViewModel is null || TreeGrid?.View is null || string.IsNullOrWhiteSpace(_currentFolderQuery))
            {
                return;
            }

            // Collect unique directory models that must be expanded for hits to be visible.
            var parentsToExpand = new HashSet<FileSystemModel>();

            foreach (var fm in ViewModel.FileList)
            {
                // Only actual matches — ancestors are already in the visible set via RebuildSearchVisiblePaths.
                if (!MatchesSearchQuery(fm))
                {
                    continue;
                }

                // Matching directories need to be open so filtered children can show.
                for (var p = fm.IsDirectory ? fm : fm.Parent; p != null; p = p.Parent)
                {
                    parentsToExpand.Add(p);
                }
            }

            if (parentsToExpand.Count == 0)
            {
                return;
            }

            _suppressExpansionPersistence = true;

            try
            {
                foreach (var dir in parentsToExpand
                             .OrderBy(d => d.RawRelativePath.Length)
                             .ThenBy(d => d.RawRelativePath, StringComparer.OrdinalIgnoreCase))
                {
                    var node = FindNodeIgnoringFilter(dir);
                    if (node is { IsExpanded: false })
                    {
                        TreeGrid.ExpandNode(node);
                    }
                }

                _searchMutatedExpansion = true;
            }
            finally
            {
                _suppressExpansionPersistence = false;
            }
        }

        /// <summary>
        /// Resolves the TreeNode for a model by walking parent-to-child from the root nodes.
        /// <see cref="TreeNodeCollection.GetNode"/> only returns visible (unfiltered) nodes,
        /// so right after a full view rebuild — where every recreated node starts out
        /// filtered — it returns null for everything and no ancestor chain can be expanded.
        /// Expanding shallowest-first keeps each parent's ChildNodes populated before its
        /// children are looked up.
        /// </summary>
        private TreeNode FindNodeIgnoringFilter(FileSystemModel model)
        {
            var chain = new Stack<FileSystemModel>();
            for (var p = model; p is not null; p = p.Parent)
            {
                chain.Push(p);
            }

            var level = TreeGrid.View.Nodes.RootNodes;
            TreeNode node = null;
            while (chain.Count > 0)
            {
                var check = chain.Pop();

                // If we hit "source" directory then keep going.
                if (check.Name == FileSystemModel.ProjectDirName)
                {
                    continue;
                }

                node = level.GetNode(check);

                if (node is null)
                {
                    return null;
                }

                level = node.ChildNodes;
            }

            return node;
        }

        /// <summary>
        /// After clearing search, put expansion back to ExpansionStateDictionary so
        /// folders that were only opened to reveal hits do not stay permanently open.
        /// </summary>
        private void RestoreExpansionStateAfterSearch()
        {
            if (ViewModel is null || TreeGrid?.View is null)
            {
                return;
            }

            _suppressExpansionPersistence = true;
            try
            {
                RestoreExpansionRecursive(TreeGrid.View.Nodes);
            }
            finally
            {
                _suppressExpansionPersistence = false;
            }
        }

        #endregion search/filter

        #region drag & drop

        private void RowDragDropController_DragStart(object sender, TreeGridRowDragStartEventArgs e)
        {
            _isDragging = true;

            if (ViewModel is not { } vm)
            {
                return;
            }

            vm.IsDragging = true;

            var draggingItems = e.DraggingNodes.Select(x => x.Item as FileSystemModel).ToList();

            if (vm.SelectedItems is { } selectedItems
                && draggingItems.Select(x => !selectedItems.Contains(x)).ToList().Count > 0)
            {
                vm.SelectedItems.Clear();
                vm.SelectedItems.AddRange(draggingItems);

                if (draggingItems.Count == 1)
                {
                    vm.SelectedItem = draggingItems[0];
                }

                return;
            }

            if (vm.SelectedItem is { } selectedItem && draggingItems.FirstOrDefault() is { } draggingItem)
            {
                if (selectedItem.RawRelativePath != draggingItem.RawRelativePath)
                {
                    vm.SelectedItem = draggingItem;
                }
            }
        }

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
            // this should all be somewhere else, right?
            try
            {
                e.Handled = _isDragging; // which should be true at this point
                if (e.TargetNode.Item is not FileSystemModel targetFile || ViewModel is not ProjectExplorerViewModel vm)
                {
                    e.Handled = true;
                    return;
                }

                var selectedFilePaths =
                    vm.SelectedItems?.OfType<FileSystemModel>().Select(fsm => fsm.FullName).ToList() ?? [];

                var files = new List<string>();

                if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                    e.Data.GetData(DataFormats.FileDrop) is string[] fileDropData
                   )
                {
                    files.AddRange(fileDropData);
                }
                else if (e.Data.GetDataPresent("Nodes") &&
                         e.Data.GetData("Nodes") is ObservableCollection<TreeNode> treeNodes)
                {
                    files.AddRange(treeNodes.Select(n => n.Item).OfType<FileSystemModel>().Select(fsm => fsm.FullName));
                }

                // If items are selected: ignore anything that isn't
                if (selectedFilePaths.Count > 0)
                {
                    files = files.Where(p => selectedFilePaths.Contains(p, StringComparer.OrdinalIgnoreCase)).ToList();
                }

                // if dragged on file, use file's parent directory as target dir
                var targetDirectory = Directory.Exists(targetFile.FullName)
                    ? targetFile.FullName
                    : Path.GetDirectoryName(targetFile.FullName);

                // 1146: addresses "prevent self-drag-and-drop"
                if (files.Count == 0 || files[0] == targetDirectory)
                {
                    e.Handled = true;
                    return;
                }

                await vm.ProcessFileAction(files, targetDirectory);
            }
            catch (Exception error)
            {
                e.Handled = true;
                Console.WriteLine(error.Message);
            }
        }

        private void RowDragDropController_Dropped(object sender, TreeGridRowDroppedEventArgs e)
        {
            _isDragging = false;

            if (ViewModel is not { } vm)
            {
                return;
            }

            vm.IsDragging = false;
        }

        #endregion drag & drop

        #region keyboard responders

        private void Main_OnKeystateChanged(object sender, KeyEventArgs e) => ViewModel?.OnKeyStateChanged(e);

        /// <summary>
        /// Called from view on key down event. Handles search bar and rename/delete commands.
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (PESearchBar.IsFocused)
            {
                return;
            }
            if (e.Key == Key.F2)
            {
                ViewModel?.RenameFileCommand.SafeExecute(null);
                return;
            }

            if (e.Key == Key.Delete)
            {
                ViewModel?.DeleteFileCommand.SafeExecute(null);
            }
        }

        private void AddKeyUpEvent()
        {
            if (ViewModel is null || ViewModel.IsKeyUpEventAssigned)
            {
                return;
            }

            // register to KeyUp because KeyDown doesn't forward "F2"
            KeyUp += OnKeyUp;
            ViewModel.IsKeyUpEventAssigned = true;
        }

        private void ContextMenu_OnKeyStateChanged(object sender, KeyEventArgs e)
        {
            ViewModel?.ModifierStateService.OnKeystateChanged(e);
            ViewModel?.ModifierStateService.RefreshModifierStates();
        }

        #endregion keyboard responders
    }
}
