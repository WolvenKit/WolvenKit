using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WolvenKit.RED4.Types;
using System.Windows.Media;

namespace WolvenKit.Functionality.Converters
{
    [ValueConversion(typeof(HDRColor), typeof(Color))]
    public sealed class HDRColorConverter : IValueConverter
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
            if (value is HDRColor hdr)
            {
                return Color.FromArgb((byte)(hdr.Alpha * 255), (byte)(hdr.Red * 255), (byte)(hdr.Green * 255), (byte)(hdr.Blue * 255));
            } else
            {
                return null;
            }
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
            if (value is Color color)
            {
                return new HDRColor()
                {
                    Red = color.R / 255F,
                    Green = color.G / 255F,
                    Blue = color.B / 255F,
                    Alpha = color.A / 255F
                };
            }
            else
            {
                return null;
            }
        }
    }
}
