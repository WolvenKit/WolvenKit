using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WolvenKit.RED4.Types;
using System.Windows.Media;
using System.Collections.Generic;

namespace WolvenKit.Functionality.Converters
{
    [ValueConversion(typeof(IRedEnum), typeof(uint))]
    public sealed class CEnumConverter : IValueConverter
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
            if (value is IRedEnum ire)
            {
                return ire.GetEnumValue();
            }
            return 0;
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
            if (targetType.IsGenericType)
            {
                return CEnum.Parse(targetType.GenericTypeArguments[0], value.ToString());
            } else
            {
                return null;
            }
        }
    }
}
