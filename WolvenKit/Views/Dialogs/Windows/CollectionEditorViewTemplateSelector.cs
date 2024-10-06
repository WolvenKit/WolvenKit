using System.Windows;
using System.Windows.Controls;
using static WolvenKit.Views.Dialogs.Windows.CollectionEditorView;

namespace WolvenKit.Views.Dialogs.Windows;

public class CollectionEditorViewTemplateSelector : DataTemplateSelector
{
    public DataTemplate TextTemplate { get; set; }
    public DataTemplate IntTemplate { get; set; }
    public DataTemplate DoubleTemplate { get; set; }
    public DataTemplate BoolTemplate { get; set; }

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        if (item is not ValueWrapper valueWrapper)
        {
            return base.SelectTemplate(item, container);
        }

        if (valueWrapper.TargetType == typeof(string))
        {
            return TextTemplate;
        }

        if (valueWrapper.TargetType == typeof(int))
        {
            return IntTemplate;
        }

        if (valueWrapper.TargetType == typeof(double))
        {
            return DoubleTemplate;
        }

        if (valueWrapper.TargetType == typeof(bool))
        {
            return BoolTemplate;
        }

        return TextTemplate;
    }
}