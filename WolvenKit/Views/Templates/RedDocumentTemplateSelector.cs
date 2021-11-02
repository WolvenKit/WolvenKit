using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows;
using WolvenKit.ViewModels.Documents;
using WolvenKit.Views.Documents;

namespace WolvenKit.Views.Templates
{
    public class RedDocumentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MainTemplate { get; set; }
        public DataTemplate BufferTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is RedDocumentItemViewModel vm)
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
