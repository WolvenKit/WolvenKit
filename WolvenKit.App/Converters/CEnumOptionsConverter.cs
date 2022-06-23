using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WolvenKit.RED4.Types;
using System.Windows.Media;
using System.Collections.Generic;

namespace WolvenKit.Functionality.Converters
{
    [ValueConversion(typeof(CEnum), typeof(List<string>))]
    public sealed class CEnumOptionsConverter : IValueConverter
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
            var list = new List<string>();
            if (value.GetType().IsGenericType)
            {
                var type = value.GetType().GenericTypeArguments[0];
                foreach (var v in type.GetEnumValues())
                {
                    list.Add(v.ToString());
                }
            }
            return list;
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
