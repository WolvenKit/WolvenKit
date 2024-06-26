using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using DynamicData;
using HandyControl.Data;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Helpers;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Views.Tools
{
    public partial class AssetBrowserView : ReactiveUserControl<AssetBrowserViewModel>
    {
        private string _currentFolderQuery = "";

        // ReSharper disable once MemberCanBePrivate.Global - used in view model
        public bool IsModBrowserEnabled { get; set; } = false;

        public AssetBrowserView()
        {
            InitializeComponent();

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
            if(e.Key == Key.Right)
            {                 
                if(CanNodeExpand())
                { 
                    if(!IsNodeExpanded())
                    { 
                        ExpandNode();
                    }
                    else
                    {
                        // select first child node
                        LeftNavigation.SetCurrentValue(SfGridBase.SelectedIndexProperty, LeftNavigation.SelectedIndex+1);
                    }
                }
            }
            else if (e.Key == Key.Left)
            {
                if(CanNodeExpand() && IsNodeExpanded())
                { 
                    CollapseNode();
                }
                else
                {
                    // select parent node
                    var node = LeftNavigation.GetNodeAtRowIndex(LeftNavigation.SelectedIndex+1);
                    if((node != null) && (node.ParentNode != null))
                    {
                       var newIndex = LeftNavigation.ResolveToRowIndex(node.ParentNode);
                        LeftNavigation.SetCurrentValue(SfGridBase.SelectedIndexProperty, newIndex-1);
                    }
                }
            }
        }

        private void LeftNavigation_OnSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (DataContext is not AssetBrowserViewModel vm)
            {
                return;
            }

            if (!e.AddedItems.Any())
            {
                return;
            }

            if (e.AddedItems.First() is TreeGridRowInfo { RowData: RedFileSystemModel model } rowInfo)
            {
                vm.RightItems.Clear();

                vm.RightItems.AddRange(model.Directories
                    .Select(h => new RedDirectoryViewModel(h.Value))
                    .OrderBy(_ => Regex.Replace(_.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
                vm.RightItems.AddRange(model.Files
                    .Select(h => new RedFileViewModel(h))
                    .OrderBy(_ => Regex.Replace(_.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));

                LeftNavigation.ScrollInView(new RowColumnIndex(rowInfo.RowIndex, 0));
            }
        }

        private void FolderSearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            // expand all
            LeftNavigation.ExpandAllNodes();
            _currentFolderQuery = e.Info;

            // filter programmatially
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

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e) => ExpandAllNodes();

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
                if (item is GridRowInfo info && info.RowData is FileSystemViewModel fsvm)
                {
                    fsvm.IsChecked = true;

                    RightFileView.ScrollInView(new RowColumnIndex(info.RowIndex, 0));
                }
            }

            foreach (var item in e.RemovedItems)
            {
                if (item is GridRowInfo info && info.RowData is FileSystemViewModel fsvm)
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

        //private void AddFromSelectedArchiveItem_Click(object sender, RoutedEventArgs e)
        //{
        //}

        private void RightFileView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var selectedIndex = LeftNavigation.SelectedIndex;
            LeftNavigation.ExpandNode(selectedIndex + 1);
        }

        private void VidPreviewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // not implemented

        }

        #endregion

        private void FileSearchBar_SearchStarted(object sender, FunctionEventArgs<string> e) => ViewModel?.PerformSearch(e.Info);

        private void LeftNavigation_RequestTreeItems(object sender, TreeGridRequestTreeItemsEventArgs args)
        {
            if (args.ParentItem == null)
            {
                args.ChildItems = ViewModel.LeftItems;
            }

            else
            {
                var childFolders = args.ParentItem as RedFileSystemModel;

                if (childFolders is not null)
                {
                    args.ChildItems = childFolders.Directories.Values.OrderBy(x => x.Name).ToList();
                }
            }
        }

        private void ScanModArchivesButton_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.ScanModArchives();
        }
    }
}
