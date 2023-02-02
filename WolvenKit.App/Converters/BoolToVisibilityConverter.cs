using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WolvenKit.App.Converters;

/// <summary>
/// Source: http://stackoverflow.com/questions/534575/how-do-i-invert-booleantovisibilityconverter
///
/// Implements a Boolean to Visibility converter
/// Use ConverterParameter=true to negate the visibility - boolean interpretation.
/// </summary>

[ValueConversion(typeof(bool), typeof(Visibility))]
public sealed class BoolToVisibilityConverter : IValueConverter
{
    /// <summary>
    /// Converts a <seealso cref="bool"/> value
    /// into a <seealso cref="Visibility"/> value.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Visibility visibility)
        {
            return visibility == Visibility.Visible;
        }

        return false;
    }

    /// <summary>
    /// Converts a <seealso cref="Visibility"/> value
    /// into a <seealso cref="bool"/> value.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var flag = false;
        if (value is bool boolean)
        {
            flag = boolean;
        }
        else if (value is bool?)
        {
            var nullable = (bool?)value;
            flag = nullable.GetValueOrDefault();
        }

        if (flag)
        {
            return Visibility.Visible;
        }
        else
        {
            return Visibility.Collapsed;
        }
    }
}
