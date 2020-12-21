using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.Common.Model;

namespace WolvenKitUI.Behavior
{
    public class TreeViewBehavior : Behavior<TreeView>
    {
        protected override void OnAttached()
        {
            AssociatedObject.SelectedItemChanged += AssociatedObject_SelectedItemChanged;
        }

        private void AssociatedObject_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var tv = sender as TreeView;


            switch (tv?.DataContext)
            {
                case ProjectExplorerViewModel projvm:
                    projvm.SelectedItem = tv.SelectedItem as FileSystemInfoModel;
                    break;
                case DocumentViewModel docvm:
                    docvm.SelectedChunk = tv.SelectedItem as ChunkViewModel;
                    break;
            }
        }
    }
}
