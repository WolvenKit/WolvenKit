using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.Common;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.ViewModels.Components.Tools;

namespace WolvenKit.MVVM.Views.Components.Tools
{
    public partial class AssetBrowserView : INotifyPropertyChanged
    {
        #region Constructors

        public AssetBrowserView()
        {
            InitializeComponent();
            NotifyPropertyChanged();
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
            }
        }

        #endregion Methods

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            StaticReferences.GlobalPropertiesView.ExplorerBind.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            StaticReferences.GlobalPropertiesView.AssetsBind.SetCurrentValue(VisibilityProperty, Visibility.Visible);


            StaticReferences.GlobalPropertiesView.fish.SetValue(Panel.DataContextProperty, DataContext);

        }
    }
}
