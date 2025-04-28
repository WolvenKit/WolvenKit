using System;
using System.Windows.Data;

namespace WolvenKit.Converters;

public class NullMoreInfoStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value == null ? "" : "More Info";
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException("NullMoreInfoStringConverter is a one way converter.");
    }
}