using System.Windows;
using HandyControl.Controls;
using WolvenKit.Common.Services;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    public class CollectionEditor : PropertyEditorBase, ICollectionEditor
    {
        public override FrameworkElement CreateElement(PropertyItem propertyItem) => new ListEditorView();

        public override DependencyProperty GetDependencyProperty() => ListEditorView.ItemsSourceProperty;
    }
}
