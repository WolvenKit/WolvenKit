using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.Converters
{
    public class CellStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var input = (bool)value;

            return input ? new SolidColorBrush(Colors.LightBlue) : DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => throw new NotImplementedException();
    }
}
