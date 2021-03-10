using System;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.Functionality.Converters
{
    [ValueConversion(typeof(System.Drawing.Color), typeof(SolidColorBrush))]
    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        #region Methods

        public object
            Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) =>
            value is System.Drawing.Color color
                ? new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B))
                : new SolidColorBrush();

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (value is SolidColorBrush brush)
            {
                var mcolor = brush.Color;
                return System.Drawing.Color.FromArgb(mcolor.A, mcolor.R, mcolor.G, mcolor.B);
            }
            else
            {
                return new System.Drawing.Color();
            }
        }

        #endregion Methods
    }
}
