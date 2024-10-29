using System;
using System.Linq;
using System.Reactive.Disposables;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using DynamicData;
using HandyControl.Data;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Core.Services;

namespace WolvenKit.Views.Tools
{
    public partial class AssetBrowserView : ReactiveUserControl<AssetBrowserViewModel>
    {
        private string _currentFolderQuery = "";


        private readonly IModifierViewStateService _modifierViewSvc;
        

        // ReSharper disable once MemberCanBePrivate.Global - used in view model
        public bool IsModBrowserEnabled { get; set; } = false;

        public AssetBrowserView()
        {
            InitializeComponent();

            // modifier key state awareness
            _modifierViewSvc = Locator.Current.GetService<IModifierViewStateService>();
            _modifierViewSvc.ModifierStateChanged += OnModifierStateChanged;

            
            this.WhenActivated(disposables =>
            {
                if (DataContext is AssetBrowserViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                this.Bind(ViewModel,
                      viewModel => viewModel.SearchBarText,
                      view => view.FileSearchBar.Text)
                  .DisposeWith(disposables);

                this.Bind(ViewModel,
                        viewModel => viewModel.IsModBrowserEnabled,
                        view => view.IsModBrowserEnabled)
                    .DisposeWith(disposables);

                // left navigation
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.LeftItems,
                        view => view.LeftNavigation.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.LeftSelectedItem,
                        view => view.LeftNavigation.SelectedItem)
                    .DisposeWith(disposables);

                // right file list
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.RightItems,
                        view => view.RightFileView.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.RightSelectedItem,
                        view => view.RightFileView.SelectedItem)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.RightSelectedItems,
                        view => view.RightFileView.SelectedItems)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.FindUsesCommand,
                        view => view.RightContextMenuFindUsesMenuItem)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                      viewModel => viewModel.FindUsingCommand,
                      view => view.RightContextMenuFindUsingMenuItem)
                  .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                      viewModel => viewModel.BrowseToFolderCommand,
                      view => view.RightContextMenuBrowseToFolder)
                  .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                      viewModel => viewModel.CopyRelPathCommand,
                      view => view.RightContextMenuCopyPathMenuItem)
                  .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.CopyRelPathFileNameCommand,
                        view => view.RightContextMenuCopyNameMenuItem)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                      viewModel => viewModel.OpenFileOnlyCommand,
                      view => view.OpenFileOnly)
                  .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                      viewModel => viewModel.AddSelectedCommand,
                      view => view.AddSelected)
                  .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                    viewModel => viewModel.AddFromArchiveCommand,
                    view => view.AddFromArchive);

                LeftNavigation.KeyUp += LeftNavigation_KeyDown;
            });

        }


        #region Methods

        private bool FilterNodes(object o) => o is RedFileSystemModel data && data.Name.Contains(_currentFolderQuery);

        #endregion

        #region leftNavigation

        private void LeftNavigation_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Right when CanNodeExpand():
                {
                    if (!IsNodeExpanded())
                    {
                        ExpandNode();
                    }
                    else
                    {
                        // select first child node
                        LeftNavigation.SetCurrentValue(SfGridBase.SelectedIndexProperty, LeftNavigation.SelectedIndex + 1);
                    }

                    break;
                }
                case Key.Left when CanNodeExpand() && IsNodeExpanded():
                    CollapseNode();
                    break;
                case Key.Left:
                {
                    // select parent node
                    var node = LeftNavigation.GetNodeAtRowIndex(LeftNavigation.SelectedIndex+1);
                    if (node?.ParentNode == null)
                    {
                        return;
                    }

                    var newIndex = LeftNavigation.ResolveToRowIndex(node.ParentNode);
                    LeftNavigation.SetCurrentValue(SfGridBase.SelectedIndexProperty, newIndex - 1);
                    break;
                }
                default:
                    break;
            }
        }

        private void LeftNavigation_OnSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (DataContext is not AssetBrowserViewModel vm)
            {
                return;
            }

            if (e.AddedItems.FirstOrDefault() is not TreeGridRowInfo { RowData: RedFileSystemModel model } rowInfo)
            {
                return;
            }

            vm.RightItems.Clear();

            vm.RightItems.AddRange(model.Directories
                .Select(h => new RedDirectoryViewModel(h.Value))
                .OrderBy(el => Regex.Replace(el.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
            vm.RightItems.AddRange(model.Files
                .Select(h => new RedFileViewModel(h))
                .OrderBy(el => Regex.Replace(el.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));

            LeftNavigation.ScrollInView(new RowColumnIndex(rowInfo.RowIndex, 0));
        }

        private void FolderSearchBar_OnSearchStarted(object _, FunctionEventArgs<string> e)
        {
            // expand all
            LeftNavigation.ExpandAllNodes();
            _currentFolderQuery = e.Info;

            // filter programmatically
            LeftNavigation.View.Filter = FilterNodes;
            LeftNavigation.View.RefreshFilter();
        }

        private void LeftNavigationHomeButton_OnClick(object sender, RoutedEventArgs e) => LeftNavigation.CollapseAllNodes();

        #region expand/collapse

        private void Expand_OnClick(object sender, RoutedEventArgs e) => ExpandNode();

        public void ExpandNode()
        {
            var selectedIndex = LeftNavigation.SelectedIndex;
            LeftNavigation.ExpandNode(selectedIndex + 1);
        }

        private void ExpandAll_OnClick(object _, RoutedEventArgs e) => ExpandAllNodes();

        public void ExpandAllNodes() => LeftNavigation.ExpandAllNodes();

        private void Collapse_OnClick(object sender, RoutedEventArgs e) => CollapseNode();

        public void CollapseNode()
        {
            var selectedItem = LeftNavigation.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }
            var node = LeftNavigation.View.Nodes.GetNode(selectedItem);
            LeftNavigation.CollapseNode(node);
        }

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e) => CollapseAllNodes();

        public void CollapseAllNodes() => LeftNavigation.CollapseAllNodes();

        public bool IsNodeExpanded()
        {
            var selectedIndex = LeftNavigation.SelectedIndex + 1;
            return LeftNavigation.GetNodeAtRowIndex(selectedIndex).IsExpanded;
        }

        public bool CanNodeExpand()
        {
            if (LeftNavigation is null)
            {
                return false;
            }
            var selectedIndex = LeftNavigation.SelectedIndex + 1;
            return LeftNavigation.GetNodeAtRowIndex(selectedIndex).HasChildNodes;
        }

        #endregion

        #endregion

        #region rightFileGrid

        private void RightFileView_OnSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (ViewModel is not { } vm)
            {
                return;
            }

            foreach (var item in e.AddedItems)
            {
                if (item is not GridRowInfo { RowData: FileSystemViewModel fsvm } info)
                {
                    continue;
                }

                fsvm.IsChecked = true;

                RightFileView.ScrollInView(new RowColumnIndex(info.RowIndex, 0));
            }

            foreach (var item in e.RemovedItems)
            {
                if (item is GridRowInfo { RowData: FileSystemViewModel fsvm })
                {
                    fsvm.IsChecked = false;
                }
            }

            if (vm.RightSelectedItems.Count > 0)
            {
                if (vm.RightSelectedItems[^1] is not IFileSystemViewModel fileSystemViewModel)
                {
                    return;
                }

                Locator.Current.GetService<PropertiesViewModel>()?.ExecuteSelectFile(fileSystemViewModel);
            }

            vm.UpdateSearchInArchives();
        }

        private void RightFileView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedIndex = LeftNavigation.SelectedIndex;
            LeftNavigation.ExpandNode(selectedIndex + 1);
        }

        private void VidPreviewMenuItem_Click(object _, RoutedEventArgs e)
        {
            // not implemented

        }

        #endregion

        private void FileSearchBar_SearchStarted(object sender, FunctionEventArgs<string> e) => ViewModel?.PerformSearch(e.Info);

        private void LeftNavigation_RequestTreeItems(object _, TreeGridRequestTreeItemsEventArgs args) =>
            args.ChildItems = args.ParentItem switch
            {
                null => ViewModel?.LeftItems,
                RedFileSystemModel childFolders => childFolders.Directories.Values.OrderBy(x => x.Name).ToList(),
                _ => args.ChildItems
            };


        [GeneratedRegex(@"(?<=archive:)([^><|&]+)")]
        private static partial Regex ArchiveSearchRegex();

        private void ScanModArchivesButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is not AssetBrowserViewModel vm)
            {
                return;
            }

            if (vm.LeftSelectedItem is RedFileSystemModel fs && fs.Name.EndsWith(".archive", StringComparison.OrdinalIgnoreCase))
            {
                vm.ScanModArchives(true, fs.Name);
            }
            else if (vm.SearchBarText is string s && ArchiveSearchRegex().Match(s) is { Success: true } match)
            {
                vm.ScanModArchives(true, match.Value.Trim());
            }
            else
            {
                vm.ScanModArchives(true, null);
            }

            vm.Refresh();
        }

        private void OnModifierStateChanged() => ViewModel?.RefreshModifierStates();

        private bool _isMenuOpen;

        private void ContextMenu_OnOpened(object sender, RoutedEventArgs e)
        {
            _isMenuOpen = true;
            ViewModel?.RefreshModifierStates();
        }

        private void ContextMenu_OnClosed(object sender, RoutedEventArgs e) => _isMenuOpen = false;

        private void ContextMenu_OnKeyChange(object sender, KeyEventArgs e)
        {
            if (_isMenuOpen)
            {
                _modifierViewSvc.OnKeystateChanged(e);
            }
        }

        private void AssetBrowser_OnKeyChange(object sender, KeyEventArgs e)
        {
            if (!_isMenuOpen)
            {
                _modifierViewSvc.OnKeystateChanged(e);
            }
        }
    }
}
