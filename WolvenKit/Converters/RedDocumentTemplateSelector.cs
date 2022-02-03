using System.Windows;
using System.Windows.Controls;
using WolvenKit.ViewModels.Documents;

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
                switch (vm.DocumentItemType)
                {
                    case ERedDocumentItemType.MainFile:
                        return MainTemplate;
                    case ERedDocumentItemType.W2rcBuffer:
                        return BufferTemplate;
                    case ERedDocumentItemType.Editor:
                    default:
                        return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
