using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WolvenKit.RED4.Types;

namespace WolvenKit.Functionality.Converters
{
    [ValueConversion(typeof(object), typeof(string))]
    public sealed class TypeNameConverter : IValueConverter
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
            return value.GetType().Name;
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
            return null;
        }
    }
}
