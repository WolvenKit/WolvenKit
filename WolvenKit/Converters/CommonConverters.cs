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
            return value is Logtype type
                ? type switch
                {
                    Logtype.Normal => DependencyProperty.UnsetValue,
                    Logtype.Error => new SolidColorBrush(Colors.Red),
                    Logtype.Important => new SolidColorBrush(Colors.Orange),
                    Logtype.Success => new SolidColorBrush(Colors.GreenYellow),
                    Logtype.Warning => new SolidColorBrush(Colors.Purple),
                    _ => throw new ArgumentOutOfRangeException()
                }
                : DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
