using System;
using System.Globalization;
using System.Windows.Data;

namespace WolvenKit.Functionality.Converters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class StringPathToItemStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = (string)value;
            var x = path.Split('\\');
            return x[x.Length - 1];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
