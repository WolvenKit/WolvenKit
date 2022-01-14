using System.Windows;
using System.Windows.Controls;
using Syncfusion.UI.Xaml.TreeView.Engine;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Converters
{
    class TreeViewItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PropertyTemplate { get; set; }
        public DataTemplate ArrayTemplate { get; set; }
        public DataTemplate HandleTemplate { get; set; }
        public DataTemplate RefTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is TreeViewNode tvn)
            {
                if (tvn.Content is ChunkViewModel vm)
                {
                    if (vm.PropertyType == null)
                    {
                        return PropertyTemplate;
                    }
                    else if (vm.PropertyType.IsAssignableTo(typeof(IRedArray)))
                    {
                        return ArrayTemplate;
                    }
                    else if (vm.PropertyType.IsAssignableTo(typeof(IRedHandle)))
                    {
                        return HandleTemplate;
                    }
                    else if (vm.PropertyType.IsAssignableTo(typeof(IRedRef)))
                    {
                        return RefTemplate;
                    }
                    else
                    {
                        return PropertyTemplate;
                    }
                }
            }
            return null;
        }
    }
}
