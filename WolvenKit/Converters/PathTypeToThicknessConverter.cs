using System;
using System.Globalization;
using System.Windows.Data;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Converter to map a path type to connection thickness.
    /// PathType 1 is Dead End (thin), PathType 2 is Live Path (thick)
    /// </summary>
    public sealed class PathTypeToThicknessConverter : IValueConverter
    {
        public double ThinThickness { get; set; } = 1.5;
        public double ThickThickness { get; set; } = 3.0;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // PathType 1 is Dead End, 2 is Live Path
            return (value is int pathType && pathType == 1) ? ThinThickness : ThickThickness;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
} 