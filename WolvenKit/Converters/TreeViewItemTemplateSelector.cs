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
            if (item is not TreeViewNode tvn)
            {
                return null;
            }

            return tvn.Content switch
            {
                GroupedChunkViewModel gvm => GroupedTemplate,
                ChunkViewModel vm when vm.PropertyType.IsAssignableTo(typeof(IList)) => ArrayTemplate,
                ChunkViewModel vm when vm.PropertyType.IsAssignableTo(typeof(IRedHandle)) => HandleTemplate,
                ChunkViewModel vm when vm.PropertyType.IsAssignableTo(typeof(IRedRef)) => RefTemplate,
                ChunkViewModel vm => PropertyTemplate,
                _ => null
            };
        }
    }
}
