using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.Common;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Views.Editor
{
    public partial class AssetBrowserView : INotifyPropertyChanged
    {
        #region Constructors

        public AssetBrowserView()
        {
            InitializeComponent();
            NotifyPropertyChanged();
            TreeNavSF.DrillDownItems.CollectionChanged += DrillDownItems_CollectionChanged;
            VisibleBackButton.SetCurrentValue(VisibilityProperty, Visibility.Hidden);


        }

        private void DrillDownItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion Constructors

        #region Events

        public new event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Methods

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Asset Browser");
            }
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => base.OnMouseLeftButtonDown(e);

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // Begin dragging the window//this.DragMove();
        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DataContext is AssetBrowserViewModel vm)
            {
                vm.CurrentNode = e.NewValue as GameFileTreeNode;
                vm.CurrentNodeFiles = (e.NewValue as GameFileTreeNode)?.ToAssetBrowserData();
                //vm.NavigateTo(vm.CurrentNode.FullPath);
            }
        }

        #endregion Methods

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (StaticReferences.GlobalPropertiesView != null)
            {

                StaticReferences.GlobalPropertiesView.ExplorerBind.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                StaticReferences.GlobalPropertiesView.AssetsBind.SetCurrentValue(VisibilityProperty, Visibility.Visible);

                StaticReferences.GlobalPropertiesView.fish.SetValue(Panel.DataContextProperty, DataContext);
            }
        }

        //private object PreviousItem;

        private void SfTreeNavigator_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is AssetBrowserViewModel vm)
            {
                if (TreeNavSF.DrillDownItem.Header as string != "Depot")
                {
                    VisibleBackButton.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                }

                // var x = TreeNavSF.DrillDownItem.Header as GameFileTreeNode;

                // Trace.WriteLine(x.Name);
                vm.CurrentNode = TreeNavSF.SelectedItem as GameFileTreeNode;
                vm.CurrentNodeFiles = (TreeNavSF.SelectedItem as GameFileTreeNode)?.ToAssetBrowserData();


                //vm.NavigateTo(vm.CurrentNode.FullPath);
            }
        }



        private void Border_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is AssetBrowserViewModel vm)
            {
                if (TreeNavSF.DrillDownItem.Header as string != "Depot")
                {

                    var x = TreeNavSF.DrillDownItem.Header as GameFileTreeNode;

                    Trace.WriteLine(x.Name);
                    TreeNavSF.GoBack();
                    vm.CurrentNode = TreeNavSF.DrillDownItem.Header as GameFileTreeNode;
                    vm.CurrentNodeFiles = (TreeNavSF.DrillDownItem.Header as GameFileTreeNode)?.ToAssetBrowserData();
                    if (TreeNavSF.DrillDownItem.Header as string == "Depot")
                    {
                        VisibleBackButton.SetCurrentValue(VisibilityProperty, Visibility.Hidden);

                    }
                }
                else
                {
                }




                //vm.NavigateTo(vm.CurrentNode.FullPath);
            }
        }

        private void SearchBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (string.Equals(SBBar.Text, "Search", System.StringComparison.OrdinalIgnoreCase))
            {
                SBBar.SetCurrentValue(TextBox.TextProperty, "");
            }
        }

        private void SBBar_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (string.Equals(SBBar.Text, "Search", System.StringComparison.OrdinalIgnoreCase))
            {
                SBBar.SetCurrentValue(TextBox.TextProperty, "");
            }
        }

        static readonly int FileImportLimit = 100;
        static int idx = 0;

        private void executeFile(AssetBrowserViewModel vm, Common.Model.AssetBrowserData selectedData)
        {
            switch (selectedData.Type)
            {
                case Common.Model.EntryType.Directory:
                {
                    foreach (var data in selectedData.Children.ToAssetBrowserData())
                    {
                        executeFile(vm, data);
                    }
                    break;
                }
                case Common.Model.EntryType.File:
                {
                    if (idx >= FileImportLimit)
                        return;
                    idx++;
                    vm.SelectedNode = selectedData;
                    vm.ImportFileCommand.Execute(selectedData);
                    break;
                }
            }
        }

        private void MenuItem_ImportSelected_Click(object sender, RoutedEventArgs e)
        {
            var mi = sender as MenuItem;
            var gridRecordContextMenuInfo = mi?.DataContext as Syncfusion.UI.Xaml.Grid.GridRecordContextMenuInfo;
            var vm = ViewModel as AssetBrowserViewModel;
            if (gridRecordContextMenuInfo != null && vm != null)
            {
                idx = 0;
                foreach (var selectedItem in gridRecordContextMenuInfo.DataGrid.SelectedItems)
                {
                    var selectedData = selectedItem as Common.Model.AssetBrowserData;
                    if (selectedData == null)
                        continue;
                    executeFile(vm, selectedData);
                }
            }
        }
    }
}
