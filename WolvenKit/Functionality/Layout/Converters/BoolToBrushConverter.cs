using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.Functionality.Layout.Converters
{
    [ValueConversion(typeof(bool), typeof(SolidColorBrush))]
    public class BoolToBrushConverter : IValueConverter
    {
        public object
            Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Setting default values
            SolidColorBrush color;
            var colorIfTrue = Colors.DarkOliveGreen;
            var colorIfFalse = Colors.Transparent;

            // Creating Color Brush
            if (value != null && (bool)value)
            {
                color = new SolidColorBrush(colorIfTrue);
            }
            else
            {
                color = new SolidColorBrush(colorIfFalse);
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture) =>
            throw new NotImplementedException();
    }
}
