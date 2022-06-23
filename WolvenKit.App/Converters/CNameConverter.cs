using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Converters
{
    /// <summary>
    /// Source: http://stackoverflow.com/questions/534575/how-do-i-invert-booleantovisibilityconverter
    ///
    /// Implements a Boolean to Visibility converter
    /// Use ConverterParameter=true to negate the visibility - boolean interpretation.
    /// </summary>

    [ValueConversion(typeof(CName), typeof(string))]
    public sealed class CNameConverter : IValueConverter
    {
        /// <summary>
        /// Converts a <seealso cref="CBool"/> value
        /// into a <seealso cref="bool"/> value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CName c)
            {
                return (string)c;
            }
            return "";
        }

        /// <summary>
        /// Converts a <seealso cref="bool"/> value
        /// into a <seealso cref="CBool"/> value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (CName)value.ToString();
        }
    }
}
