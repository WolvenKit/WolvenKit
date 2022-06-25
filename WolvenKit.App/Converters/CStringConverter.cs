using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Converters
{
    [ValueConversion(typeof(CString), typeof(string))]
    public sealed class CStringConverter : IValueConverter
    {
        /// <summary>
        /// Converts a <seealso cref="CString"/> value
        /// into a <seealso cref="string"/> value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CString c)
            {
                return (string)c;
            }
            return "";
        }

        /// <summary>
        /// Converts a <seealso cref="string"/> value
        /// into a <seealso cref="CString"/> value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (CString)value.ToString();
        }
    }
}
