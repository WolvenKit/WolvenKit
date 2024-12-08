using CommunityToolkit.Mvvm.Input;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WolvenKit.Converters;

public class RelayCommandToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
        value is IRelayCommand command && command.CanExecute(null) ? Visibility.Visible : Visibility.Hidden;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}