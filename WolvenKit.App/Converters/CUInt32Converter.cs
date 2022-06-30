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

    [ValueConversion(typeof(CUInt32), typeof(string))]
    public sealed class CUInt32Converter : IValueConverter
    {
        /// <summary>
        /// Converts a <seealso cref="CFloat"/> value
        /// into a <seealso cref="string"/> value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CUInt32 f)
            {
                return ((uint)f).ToString();
            }
            return "0";
        }

        /// <summary>
        /// Converts a <seealso cref="string"/> value
        /// into a <seealso cref="CFloat"/> value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string s)
            {
                return (CUInt32)uint.Parse(s);
            }
            else
            {
                return (CUInt32)0;
            } 
        }
    }
}
