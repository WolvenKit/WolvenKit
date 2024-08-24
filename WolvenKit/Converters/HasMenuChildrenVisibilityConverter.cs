using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WolvenKit.Converters
{
    public class HasMenuChildrenVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MenuItem parentMenuItem)
            {
                return parentMenuItem.Items.OfType<MenuItem>().Any(child => child.Visibility == Visibility.Visible)
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}