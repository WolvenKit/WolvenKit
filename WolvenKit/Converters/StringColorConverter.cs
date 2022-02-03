using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.Converters
{
    [ValueConversion(typeof(Color), typeof(string))]
    public sealed class StringColorConverter : IValueConverter
    {
        public static readonly StringColorConverter Default = new StringColorConverter();

        // convert color to string
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string strValue)
            {
                try
                {
                    var color = (Color)ColorConverter.ConvertFromString(strValue);
                    return color;
                }
                catch (FormatException)
                {
                    return DependencyProperty.UnsetValue;
                }
            }
            return DependencyProperty.UnsetValue;
        }

        // convert string to color or unsetvalue
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color color)
            {
                return color.ToString();
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
