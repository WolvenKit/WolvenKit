using System;
using System.Windows;
using System.Windows.Data;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters;

[ValueConversion(typeof(CFloat), typeof(double))]
public sealed class CFloatDoubleConverter : IValueConverter
{
    /// <summary> Gets the default instance </summary>
    public static readonly CFloatDoubleConverter Default = new CFloatDoubleConverter();

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is CFloat cfloat)
        {
            return (double)cfloat;
        }

        return DependencyProperty.UnsetValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is double d)
        {
            return (float)d;
        }

        return DependencyProperty.UnsetValue;
    }
}
