using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using WolvenKit.Common;

namespace WolvenKit.Converters
{
    public class ValueConverterGroup : List<IValueConverter>, IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => this.Aggregate(value, (current, converter) => converter.Convert(current, targetType, parameter, culture));

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

        #endregion Methods
    }

    public class LogColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is LogType type
                ? type switch
                {
                    LogType.Normal => DependencyProperty.UnsetValue,
                    LogType.Error => new SolidColorBrush(Colors.Red),
                    LogType.Important => new SolidColorBrush(Colors.Orange),
                    LogType.Success => new SolidColorBrush(Colors.GreenYellow),
                    LogType.Warning => new SolidColorBrush(Colors.Purple),
                    LogType.Debug => DependencyProperty.UnsetValue,
                    _ => throw new ArgumentOutOfRangeException()
                }
                : DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
