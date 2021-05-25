using System.ComponentModel;
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


        public static AssetBrowserView GlobalABView;
        public AssetBrowserView()
        {
            InitializeComponent();
            NotifyPropertyChanged();
            TreeNavSF.DrillDownItems.CollectionChanged += DrillDownItems_CollectionChanged;
            VisibleBackButton.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
            GlobalABView = this;


        }

        protected override void OnViewModelChanged()
        {
            if (ViewModel is AssetBrowserViewModel vm)
            {
                vm.SelectItemInTreeNavSF += (obj) =>
                {
                    TreeNavSF.SetCurrentValue(Syncfusion.Windows.Controls.Navigation.SfTreeNavigator.SelectedItemProperty, obj);
                };
                vm.GoBackInTreeNavSF += () =>
                {
                    TreeNavSF.GoBack();
                    if (TreeNavSF.DrillDownItem.Header as string == "Depot")
                    {
                        VisibleBackButton.SetCurrentValue(VisibilityProperty, Visibility.Hidden);

                    }
                };
                vm.GoToRootInTreeNavSF += () =>
                {
                    // ? :)
                };
            }
        }

        private void DrillDownItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Asset Browser");
            }
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => base.OnMouseLeftButtonDown(e);

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DataContext is AssetBrowserViewModel vm)
            {
                vm.CurrentNode = e.NewValue as GameFileTreeNode;
                vm.CurrentNodeFiles = (e.NewValue as GameFileTreeNode)?.ToAssetBrowserData();
                //vm.NavigateTo(vm.CurrentNode.FullPath);
            }
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (StaticReferences.GlobalPropertiesView != null)
            {

                StaticReferences.GlobalPropertiesView.ExplorerBind.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                StaticReferences.GlobalPropertiesView.AssetsBind.SetCurrentValue(VisibilityProperty, Visibility.Visible);

                StaticReferences.GlobalPropertiesView.fish.SetValue(Panel.DataContextProperty, DataContext);
            }
        }


        private void SfTreeNavigator_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is AssetBrowserViewModel vm)
            {
                if (TreeNavSF.DrillDownItem.Header as string != "Depot")
                {
                    VisibleBackButton.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                }

                vm.CurrentNode = TreeNavSF.SelectedItem as GameFileTreeNode;
                vm.CurrentNodeFiles = (TreeNavSF.SelectedItem as GameFileTreeNode)?.ToAssetBrowserData();
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
                    TreeNavSF.GoBack();
                    if (TreeNavSF.DrillDownItem.Header as string == "Depot")
                    {
                        vm.CurrentNode = vm.RootNode;
                        vm.CurrentNodeFiles = vm.RootNode.ToAssetBrowserData();
                        VisibleBackButton.SetCurrentValue(VisibilityProperty, Visibility.Hidden);
                    }
                    else
                    {
                        vm.CurrentNode = TreeNavSF.DrillDownItem.Header as GameFileTreeNode;
                        vm.CurrentNodeFiles = (TreeNavSF.DrillDownItem.Header as GameFileTreeNode)?.ToAssetBrowserData();
                    }
                }
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

        public void RevampedImport()
        {

            var vm = ViewModel as AssetBrowserViewModel;
            if (vm != null)
            {
                idx = 0;
                foreach (var selectedItem in InnerList.SelectedItems)
                {
                    var selectedData = selectedItem as Common.Model.AssetBrowserData;
                    if (selectedData == null)
                        continue;
                    executeFile(vm, selectedData);
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
