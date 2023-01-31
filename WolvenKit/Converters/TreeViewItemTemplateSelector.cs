using System.Collections;
using System.Windows;
using System.Windows.Controls;
using Syncfusion.UI.Xaml.TreeView.Engine;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters
{
    internal class TreeViewItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate GroupedTemplate { get; set; }
        public DataTemplate PropertyTemplate { get; set; }
        public DataTemplate ArrayTemplate { get; set; }
        public DataTemplate HandleTemplate { get; set; }
        public DataTemplate RefTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is TreeViewNode tvn)
            {
                if (tvn.Content is GroupedChunkViewModel gvm)
                {
                    return GroupedTemplate;
                }

                if (tvn.Content is ChunkViewModel vm)
                {
                    if (vm.PropertyType == null)
                    {
                        return PropertyTemplate;
                    }
                    else if (vm.PropertyType.IsAssignableTo(typeof(IList)))
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
