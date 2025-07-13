using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.Converters;

public partial class StringToBrushConverter : IValueConverter
{
    // Regex to match RGB values in the format "(11%, 25%, 3%)"
    public static readonly Regex RegexRgbPercent = PercentRgbRegex();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not string colorString || string.IsNullOrWhiteSpace(colorString))
        {
            return Brushes.Transparent;
        }

        var match = RegexRgbPercent.Match(colorString);
        if (match.Success)
        {
            if (int.TryParse(match.Groups[1].Value, out var r) &&
                int.TryParse(match.Groups[2].Value, out var g) &&
                int.TryParse(match.Groups[3].Value, out var b))
            {
                var rb = (byte)Math.Clamp(r * 255 / 100, 0, 255);
                var gb = (byte)Math.Clamp(g * 255 / 100, 0, 255);
                var bb = (byte)Math.Clamp(b * 255 / 100, 0, 255);
                return new SolidColorBrush(Color.FromRgb(rb, gb, bb));
            }
        }

        if (ColorConverter.ConvertFromString(colorString) is Color col)
        {
            return new SolidColorBrush(col);
        }

        return Brushes.Transparent;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotImplementedException();

    [GeneratedRegex(@"\(\s*(\d+)%\s*,\s*(\d+)%\s*,\s*(\d+)%\s*\)", RegexOptions.Compiled)]
    private static partial Regex PercentRgbRegex();
}