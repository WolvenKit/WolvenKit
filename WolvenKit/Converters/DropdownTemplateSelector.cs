using System.Collections.Generic;
using System.Windows.Media;
using WolvenKit.Views.Editors;

namespace WolvenKit.Converters;

using System.Windows;
using System.Windows.Controls;

public class DropdownTemplateSelector : DataTemplateSelector
{
    public DataTemplate DefaultTemplate { get; set; }
    public DataTemplate ColorTemplate { get; set; }

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        if (item is KeyValuePair<string, string> kvp && StringToBrushConverter.RegexRgbPercent.IsMatch(kvp.Key))
        {
            return ColorTemplate;
        }

        return DefaultTemplate;
    }
}