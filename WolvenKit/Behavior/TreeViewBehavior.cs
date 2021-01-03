using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.Behavior
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
                case ViewModels.ProjectExplorerViewModel projvm:
                    projvm.SelectedItem = tv.SelectedItem as Model.FileSystemInfoModel;
                    break;
                case ViewModels.DocumentViewModel docvm:
                    docvm.SelectedChunk = tv.SelectedItem as Common.Model.ChunkViewModel;
                    break;
            }
        }
    }
}
