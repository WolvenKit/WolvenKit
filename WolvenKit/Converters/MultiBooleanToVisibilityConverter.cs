using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace WolvenKit.Converters;

// TODO: This only works if I set a menu item's DataContext - but then MenuItem.Visibility doesn't work anymore. 
class MultiBooleanToVisibilityConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (values.Length == 0 || values.All(v => v == DependencyProperty.UnsetValue))
        {
            return Binding.DoNothing;
        }

        var result = values.Where(t => t != null && t != DependencyProperty.UnsetValue)
            .Aggregate(false, (current, t) => current && System.Convert.ToBoolean(t));

        return result ? Visibility.Visible : Visibility.Collapsed;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}