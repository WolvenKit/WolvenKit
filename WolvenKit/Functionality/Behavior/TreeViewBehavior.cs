using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Model;
using WolvenKit.MVVM.ViewModels.Shell.Editor;
using WolvenKit.MVVM.ViewModels.Shell.Editor.Documents;

namespace WolvenKit.Functionality.Behavior
{
    public class TreeViewBehavior : Behavior<TreeView>
    {
        #region Methods

        protected override void OnAttached() => AssociatedObject.SelectedItemChanged += AssociatedObject_SelectedItemChanged;

        private void AssociatedObject_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var tv = sender as TreeView;

            switch (tv?.DataContext)
            {
                case ProjectExplorerViewModel projvm:
                    projvm.SelectedItem = tv.SelectedItem as FileSystemInfoModel;
                    if (StaticReferences.GlobalPropertiesView != null)
                    {
                        StaticReferences.GlobalPropertiesView.ExplorerBind.SetCurrentValue(Expander.VisibilityProperty, Visibility.Visible);
                        StaticReferences.GlobalPropertiesView.AssetsBind.SetCurrentValue(Expander.VisibilityProperty, Visibility.Collapsed);

                        StaticReferences.GlobalPropertiesView.fish.SetValue(Panel.DataContextProperty, tv.SelectedItem as FileSystemInfoModel);
                    }

                    break;

                case DocumentViewModel docvm:
                    docvm.SelectedChunk = tv.SelectedItem as ChunkViewModel;
                    break;
            }
        }

        #endregion Methods
    }
}
