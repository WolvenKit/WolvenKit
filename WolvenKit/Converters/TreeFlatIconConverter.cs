using System;
using System.Globalization;
using System.Windows.Data;

namespace WolvenKit.Converters;

public sealed class TreeFlatIconConverter : IValueConverter
{
    public static readonly TreeFlatIconConverter Default = new();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool isFlatModeEnabled)
        {
            return isFlatModeEnabled ? "FileTree" : "ViewList";
        }

        return "ViewList";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}