using System.Windows;
using System.Windows.Controls;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Converters
{
    public class RedDocumentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MainTemplate { get; set; }
        public DataTemplate BufferTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is RedDocumentTabViewModel vm)
            {
                return vm.DocumentItemType switch
                {
                    ERedDocumentItemType.MainFile => MainTemplate,
                    ERedDocumentItemType.W2rcBuffer => BufferTemplate,
                    _ => null,
                };
            }
            else
            {
                return null;
            }
        }
    }
}
