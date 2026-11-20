using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Converters;

/// <summary>
/// Background brush → black or white text, whichever is more readable on it.
/// Used where the background is a theme color that may be light or dark.
/// Transparent backgrounds sit on WolvenKit's dark panels, so they get white text.
/// </summary>
public class ContrastForegroundConverter : IValueConverter
{
    private static readonly Brush s_dark = Freeze(new SolidColorBrush(Colors.Black));
    private static readonly Brush s_light = Freeze(new SolidColorBrush(Colors.White));

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not SolidColorBrush { Color: var color } || color.A < 0x80)
        {
            return s_light;
        }

        return ThemeEditorViewModel.ContrastRatio(Colors.Black, color) > ThemeEditorViewModel.ContrastRatio(Colors.White, color)
            ? s_dark
            : s_light;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotSupportedException();

    private static Brush Freeze(Brush brush)
    {
        brush.Freeze();
        return brush;
    }
}
