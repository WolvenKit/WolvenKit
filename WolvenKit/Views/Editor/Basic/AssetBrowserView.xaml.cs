using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.Common;
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
                    vm.CurrentNode = TreeNavSF.DrillDownItem.Header as GameFileTreeNode;
                    vm.CurrentNodeFiles = (TreeNavSF.DrillDownItem.Header as GameFileTreeNode)?.ToAssetBrowserData();
                    TreeNavSF.GoBack();
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
    }
}
