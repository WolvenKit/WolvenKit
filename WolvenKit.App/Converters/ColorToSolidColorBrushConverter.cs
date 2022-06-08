using System;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.App.Converters
{
    [ValueConversion(typeof(System.Drawing.Color), typeof(SolidColorBrush))]
    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        public object
            Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) =>
            value is System.Drawing.Color color
                ? new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B))
                : new SolidColorBrush();

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture) =>
            value is SolidColorBrush brush
                ? System.Drawing.Color.FromArgb(brush.Color.A, brush.Color.R, brush.Color.G, brush.Color.B)
                : new System.Drawing.Color();
    }
}
