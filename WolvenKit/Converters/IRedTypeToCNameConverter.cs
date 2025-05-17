using System.Windows.Data;
using System;
using System.Globalization;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters;

public class IRedTypeToCNameConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is IRedType and CName name)
        {
            return name;
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}