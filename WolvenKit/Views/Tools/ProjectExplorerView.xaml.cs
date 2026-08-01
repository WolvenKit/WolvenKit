using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using DynamicData;
using DynamicData.Binding;
using HandyControl.Data;
using HandyControl.Tools.Extension;
using MahApps.Metro.Controls;
using Octokit;
using ReactiveUI;
using Splat;
using Syncfusion.Data;
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
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
using WolvenKit.Views.Others;
using WolvenKit.Views.Templates;
using RowColumnIndex = Syncfusion.UI.Xaml.ScrollAxis.RowColumnIndex;
using WolvenKit.Helpers;
using Application = System.Windows.Application;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView : ReactiveUserControl<ProjectExplorerViewModel>
    {
        #region fields

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
        private ISettingsManager _settingsManager;
        private readonly CancellableRowDragDropController _rowDragDropController;

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

        private ProjectExplorerViewModel.LoadingMode _loadingMode = ProjectExplorerViewModel.LoadingMode.Ready;

        #endregion fields

        #region Constructor

        public ProjectExplorerView()
        {
            InitializeComponent();

            // Debounce for live search
            _searchDebounceTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(350)
            };
            _searchDebounceTimer.Tick += SearchDebounceTimer_Tick;

            _settingsManager = Locator.Current.GetService<ISettingsManager>()!;

            TreeGrid.ItemsSourceChanged += TreeGrid_ItemsSourceChanged;
            TreeGridFlat.ItemsSourceChanged += TreeGridFlat_ItemsSourceChanged;
            _rowDragDropController = new CancellableRowDragDropController();
            TreeGrid.RowDragDropController = _rowDragDropController;
            TreeGrid.RowDragDropController.DragStart += RowDragDropController_DragStart;
            TreeGrid.RowDragDropController.DragOver += RowDragDropController_DragOver;
            TreeGrid.RowDragDropController.Drop += RowDragDropController_Drop;
            TreeGrid.RowDragDropController.Dropped += RowDragDropController_Dropped;
            TreeGrid.RowDragDropController.CanAutoExpand = true;

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            TreeGrid.SortComparers.Add(new() { Comparer = new FileComparer.Paths(), PropertyName = "GameRelativePath" });
            TreeGridFlat.SortComparers.Add(new() { Comparer = new FileComparer.Paths(), PropertyName = "GameRelativePath" });
            TreeGridFlat.SortComparers.Add(new() { Comparer = new FileComparer.Sizes(), PropertyName = "FileSizeStr" });

            TreeGrid.NodeExpanding += TreeGrid_OnNodeExpanding;
            TreeGrid.NodeExpanded += TreeGrid_OnNodeExpanded;
            TreeGrid.NodeCollapsing += TreeGrid_OnNodeCollapsing;
            TreeGrid.NodeCollapsed += TreeGrid_OnNodeCollapsed;

            TreeGrid.NotificationSubscriptionMode = NotificationSubscriptionMode.CollectionChange;

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
                    .Subscribe(p => OnCellDoubleTapped(p.Sender, p.EventArgs as TreeGridCellDoubleTappedEventArgs))
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
                ViewModel.OnSetLoading += SetLoading;
                // Assign, do NOT '+=': WhenActivated re-runs on every re-activation of this view
                ViewModel.BeginDeferredRefreshContext = BeginDeferredRefreshContext;

                ViewModel.OnLiveGridMutationStarting = () =>
                {
                    // Prevents Null Dereferences in FlatView
                    TreeGridFlat.View?.Suspend();
                };

                ViewModel.OnLiveGridMutationCompleted = () =>
                {
                    TreeGridFlat.View?.Resume();
                    RefreshFlatViewIfNeeded(); // no-op while hidden

                    if (!_currentFolderQuery.IsNullOrEmpty())
                    {
                        ReapplyCurrentSearchFilter(expandAllForSearch: true);
                    }
                };

                ViewModel.WhenAnyValue(x => x.FileList)
                    .Subscribe(_ => RefreshFlatViewIfNeeded())
                    .DisposeWith(disposables);
            });

            this.ExecuteWhenLoaded(() => IndicateProjectLoading());
        }

        #endregion

        #region Project_Loading

        private bool ShouldStartLoadingProject(ProjectExplorerViewModel.LoadingMode mode)
        {
            return mode == ProjectExplorerViewModel.LoadingMode.LoadingNewProject
                   || mode == ProjectExplorerViewModel.LoadingMode.ReloadingSameProject;
        }

        private bool ShouldStopLoading(ProjectExplorerViewModel.LoadingMode mode)
        {
            return mode == ProjectExplorerViewModel.LoadingMode.Ready;
        }

        private bool ShouldStopTemporaryLoading(ProjectExplorerViewModel.LoadingMode mode)
        {
            return mode == ProjectExplorerViewModel.LoadingMode.Ready;
        }

        private bool ShouldStartTemporaryLoading(ProjectExplorerViewModel.LoadingMode mode)
        {
            return mode == ProjectExplorerViewModel.LoadingMode.ShowLoadingDuringOperation;
        }

        private bool IsFreshLoad(ProjectExplorerViewModel.LoadingMode mode)
        {
            return mode == ProjectExplorerViewModel.LoadingMode.LoadingNewProject;
        }

        private bool AlreadyLoadingProject()
        {
            return _loadingMode == ProjectExplorerViewModel.LoadingMode.LoadingNewProject
                   || _loadingMode == ProjectExplorerViewModel.LoadingMode.ReloadingSameProject;
        }

        private bool AlreadyTemporaryLoading()
        {
            return _loadingMode == ProjectExplorerViewModel.LoadingMode.ShowLoadingDuringOperation;
        }

        private bool Ready()
        {
            return _loadingMode == ProjectExplorerViewModel.LoadingMode.Ready;
        }

        /// <summary>
        /// Called by the ViewModel when the View should show "Loading" on the file pane.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetLoading(object sender, ProjectExplorerViewModel.LoadingMode mode)
        {
            if (ShouldStartLoadingProject(mode) && Ready())
            {
                ResetCurrentFolderQuerySearchFilter();

                if (IsFreshLoad(mode))
                {
                    IndicateProjectLoading();
                }
            }
            else if (ShouldStopLoading(mode) && AlreadyLoadingProject())
            {
                IndicateProjectNotLoading(ViewModel.IsFlatModeEnabled);
            }
            else if (ShouldStopTemporaryLoading(mode) && AlreadyTemporaryLoading())
            {
                IndicateProjectNotLoading(ViewModel.IsFlatModeEnabled);
            }
            else if (ShouldStartTemporaryLoading(mode) && Ready())
            {
                IndicateProjectLoading();
            }

            _loadingMode = mode;
        }

        private void IndicateProjectLoading() => Dispatcher.Invoke(() =>
        {
            Console.WriteLine("IndicateProjectLoading");

            TreeGrid.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            TreeGridFlat.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            LoadingText.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        });

        private void IndicateProjectNotLoading(bool isFlatModeEnabled)
        {
            Console.WriteLine("IndicateProjectNotLoading");
            LoadingText.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

            if (isFlatModeEnabled)
            {
                TreeGridFlat.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            }
            else
            {
                TreeGrid.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            }
        }

        #endregion Project_Loading

        #region refresh

        private void RefreshFlatViewIfNeeded()
        {
            if (TreeGridFlat.IsVisible)
            {
                TreeGridFlat.View.Filter = IsFileInFlat;
                TreeGridFlat.View.Refresh();
            }
        }

        private void ResetCurrentFolderQuerySearchFilter()
        {
            _currentFolderQuery = "";
            _searchVisiblePaths = null;
            PESearchBar?.SetCurrentValue(System.Windows.Controls.TextBox.TextProperty, "");
        }

        private async Task BeginDeferredRefreshContext(Func<Task> doBeforeRefresh)
        {
            // The refresh below disposes every TreeNode; a pending drag-hover auto-expand
            // would fire on a disposed node afterwards.
            _rowDragDropController.CancelPendingAutoExpand();

            CompositeDisposable disposables =
            [
                TreeGridFlat.View.DeferRefresh(TreeViewRefreshMode.DeferRefresh),
                TreeGrid.View.DeferRefresh(TreeViewRefreshMode.DeferRefresh)
            ];

            using (disposables)
            {
                // Structural mutations only under DeferRefresh.
                // Do not call any methods on views/grids/filters/refreshes here.
                await doBeforeRefresh();
            }

            DispatcherHelper.RunOnMainThread(() =>
            {
                if (!_currentFolderQuery.IsNullOrEmpty())
                {
                    ReapplyCurrentSearchFilter(expandAllForSearch: true);
                }

                InvalidateLayout();

                // We need a second Invalidate here because of AsyncRelay commands like Delete.
                Dispatcher.BeginInvoke(InvalidateLayout, DispatcherPriority.Render);
            });
        }

        private void InvalidateLayout()
        {
            // Always invalidate both grids, not just the visible one.
            InvalidateVirtualizedRows(TreeGrid);
            InvalidateVirtualizedRows(TreeGridFlat);

            // Only update layout on the visible tree.
            if (TreeGrid.IsVisible)
            {
                TreeGrid.UpdateLayout();
            }

            if (TreeGridFlat.IsVisible)
            {
                TreeGridFlat.UpdateLayout();
            }
        }

        /// <summary>
        /// Forces a Syncfusion SfTreeGrid to re-measure its virtualized rows, clearing the "rows drawn
        /// over each other" artifact that appears when the bound data changes while the grid is scrolled.
        /// Safe no-op if the panel isn't in the visual tree yet.
        /// </summary>
        private static void InvalidateVirtualizedRows(DependencyObject grid)
        {
            var panel = FindVisualDescendant<TreeGridPanel>(grid);
            if (panel == null)
            {
                return;
            }

            // Fixes the appearance of a double "ghost table."
            panel.InvalidateMeasureInfo();
            panel.InvalidateMeasure();
            panel.InvalidateArrange();

            return;

            T FindVisualDescendant<T>(DependencyObject root) where T : DependencyObject
            {
                var count = System.Windows.Media.VisualTreeHelper.GetChildrenCount(root);
                for (var i = 0; i < count; i++)
                {
                    var child = System.Windows.Media.VisualTreeHelper.GetChild(root, i);
                    if (child is T match)
                    {
                        return match;
                    }

                    var nested = FindVisualDescendant<T>(child);
                    if (nested != null)
                    {
                        return nested;
                    }
                }

                return default;
            }
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
                RefreshFlatViewIfNeeded();
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

            ViewModel.NotifyDirectoryExpanded(fileSystemModel);
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

            ViewModel.NotifyDirectoryCollapsed(fileSystemModel);
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
                e.Handled = true;
                return;
            }

            var activeFileNode =
                TreeGrid.View.Nodes.FirstOrDefault(node => node.Item is FileSystemModel model && model.FullName == activeFile.FilePath);
            activeFileNode ??= GetTreeNode(activeFile.FilePath, TreeGrid.View.Nodes.FirstOrDefault());

            if (activeFileNode is null)
            {
                e.Handled = true;
                return;
            }

            ExpandParent(activeFileNode);

            TreeGrid.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SfGridBase.SelectedItemProperty, activeFileNode);

            ViewModel.SelectedItem = activeFileNode.Item as FileSystemModel;

            var rowIndex = TreeGrid.ResolveToRowIndex(activeFileNode);
            var columnIndex = TreeGrid.ResolveToStartColumnIndex();
            TreeGrid.ScrollInView(new RowColumnIndex(rowIndex, columnIndex));
            TreeGrid.View.MoveCurrentToPosition(rowIndex);

            TreeNode GetTreeNode(string filePath, TreeNode node)
            {
                if (node.Item is FileSystemModel model && model.FullName == filePath)
                {
                    return node;
                }

                return node.ChildNodes.Aggregate<TreeNode, TreeNode>(null,
                    (current, nodeChildNode) => current ?? GetTreeNode(filePath, nodeChildNode));
            }
        }

        private void TreeGrid_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (TreeGrid?.View is null)
            {
                return;
            }

            TreeGrid.View.NodeCollectionChanged += View_OnNodeCollectionChanged;

            RebuildSearchVisiblePaths();
            TreeGrid.View.Filter = IsFileIn;
            TreeGrid.View.RefreshFilter();
        }

        private void View_OnNodeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            if (e.Action is NotifyCollectionChangedAction.Reset)
            {
                var shouldAutoExpand = _settingsManager.AutoExpandAllFoldersOnLaunch;
                var nodeCount = TreeGrid.View?.Nodes?.Count ?? 0;

                // TODO: Check if this can ever be true here. Otherwise find a way to pass "isFirstLoad" to here.
                var isFreshProject = ViewModel.ExpansionStateDictionary.AreKeysNull();

                if (isFreshProject && nodeCount != 0 && shouldAutoExpand)
                {
                    TreeGrid.ExpandAllNodes();
                }
            }

            if (e.Action is NotifyCollectionChangedAction.Add && e.NewItems is not null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is not TreeNode { Item: FileSystemModel { IsDirectory: true } fileSystemModel } treeNode)
                    {
                        continue;
                    }

                    if (fileSystemModel.IsExpanded || ViewModel.GetExpansionStateOrNull(fileSystemModel.RawRelativePath) is true)
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

        private void TreeGridFlat_ItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
        {
            if (TreeGridFlat?.View is null)
            {
                return;
            }

            RefreshFlatViewIfNeeded();
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

            // if (!string.IsNullOrWhiteSpace(_currentFolderQuery))
            // {
            //     bool matches =
            //         fm.Name.Contains(_currentFolderQuery, StringComparison.OrdinalIgnoreCase) ||
            //         fm.RawRelativePath.Contains(_currentFolderQuery, StringComparison.OrdinalIgnoreCase);
            //
            //     if (!matches)
            //         return false;
            // }

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
            if (ViewModel is not ProjectExplorerViewModel vm)
            {
                return;
            }

            // Don't drag stuff you're not freakin' draggin' choom... gosh.
            var draggedItems = e.DraggingNodes.ToList();
            var selectedItems = vm.SelectedItems?.ToList() ?? [];
            var nonDraggedSelections = selectedItems.Where(x => !draggedItems.Contains(x)).ToList();
            vm.SelectedItems?.RemoveMany(nonDraggedSelections);

            _isDragging = true;
        }

        private void RowDragDropController_DragOver(object sender, TreeGridRowDragOverEventArgs e)
        {
            if (!e.Data.GetDataPresent("Nodes") ||
                e.Data.GetData("Nodes") is not ObservableCollection<TreeNode> treeNodes ||
                treeNodes[0].Item is not FileSystemModel sourceFile ||
                e.TargetNode?.Item is not FileSystemModel targetFile)
            {
                e.Handled = true;
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

        private void RowDragDropController_Drop(object sender, TreeGridRowDropEventArgs e)
        {
            try
            {
                // ProcessOnDrop re-arms the hover auto-expand timer via GetDropPosition after
                // stopping it; kill it here or it fires ExpandNode on a node the deferred
                // refresh has already disposed (NRE in TreeGridNestedView.RequestTreeItems).
                _rowDragDropController.CancelPendingAutoExpand();

                e.Handled = _isDragging;

                if (e.TargetNode?.Item is not FileSystemModel targetFile || ViewModel is not ProjectExplorerViewModel vm)
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
                var targetDirectory = (Directory.Exists(targetFile.FullName)
                    ? targetFile.FullName
                    : Path.GetDirectoryName(targetFile.FullName)) ?? string.Empty;

                if (targetFile.Parent is { } parent && parent.FullName == targetDirectory)
                {
                    e.Handled = true;
                    return;
                }

                // 1146: addresses "prevent self-drag-and-drop"
                if (files.Count == 0 || files[0] == targetDirectory)
                {
                    e.Handled = true;
                    return;
                }

                ViewModel.ProcessFileAction(files, targetDirectory);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        private void RowDragDropController_Dropped(object sender, TreeGridRowDroppedEventArgs e) =>
            _isDragging = false;

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
