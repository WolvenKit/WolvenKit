using System;
using System.Globalization;
using System.Windows.Data;

namespace WolvenKit.Converters;

/// <summary>
/// Converts abstract HeightMultiplier to pixel height for XAML binding.
/// </summary>
public class HeightMultiplierToPixelsConverter : IValueConverter
{
    private const double BaseRowHeight = 56.0;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is double multiplier)
        {
            return multiplier * BaseRowHeight;
        }
        return BaseRowHeight;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
