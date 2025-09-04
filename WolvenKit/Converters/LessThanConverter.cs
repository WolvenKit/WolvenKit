using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Runs condition `Value < Parameter` where `Parameter` can be:
    /// - a number as a double
    /// - a resource as a string (as found in App.Sizes.xaml)
    /// </summary>
    [ValueConversion(typeof(double), typeof(bool))]
    public sealed class LessThanConverter : IValueConverter
    {
        public static readonly LessThanConverter Default = new();

        public object Convert(object rawValue, Type targetType, object parameter, CultureInfo culture)
        {
            if (rawValue is double value)
            {
                if (double.TryParse(parameter as string, out var threshold))
                {
                    return value < threshold;
                }
                else
                {
                    var resources = Application.Current.Resources;
                    return value < (double)resources[parameter as string]!;
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
