using System;
using System.Globalization;
using System.Windows.Data;

namespace WolvenKit.Converters;

public class ValueToDoubleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int iValue)
        {
            return (double)iValue;
        }

        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => value;
}