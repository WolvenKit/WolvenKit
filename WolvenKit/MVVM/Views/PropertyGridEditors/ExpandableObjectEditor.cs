using System.Windows;
using System.Windows.Controls;
using HandyControl.Controls;
using WolvenKit.Common.Services;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    public class ExpandableObjectEditor : PropertyEditorBase, IExpandableObjectEditor
    {
        public override FrameworkElement CreateElement(PropertyItem propertyItem)
        {
            var tree = new TreeView();
            var treeviewitem = new TreeViewItem();
            treeviewitem.Items.Add(new PropertyGrid());
            tree.Items.Add(treeviewitem);
            return tree;
        }
        public override DependencyProperty GetDependencyProperty() => PropertyGrid.SelectedObjectProperty;
    }
}
