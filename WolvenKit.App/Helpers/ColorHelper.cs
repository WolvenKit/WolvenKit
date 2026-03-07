using System;
using System.Text.RegularExpressions;
using System.Windows.Media;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.App.Helpers;

public partial class ColorHelper
{
    private static readonly Random s_rnd = new();

    /// <returns>A <see cref="Color"/> with a random color value.</returns>
    public static Color GetRandomColor()
    {
        return Color.FromRgb((byte)s_rnd.Next(0, 256), (byte)s_rnd.Next(0, 256),
            (byte)s_rnd.Next(0, 256));
    }

    /// <param name="clampBrightness">Color must have a brightness value of at least x</param>
    /// <returns>A <see cref="Color"/> with a random color value and a brightness >= the parameter value.</returns>
    public static Color GetRandomColor(double clampBrightness)
    {
        var color = GetRandomColor();

        while (System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B).GetBrightness() < clampBrightness)
        {
            color = GetRandomColor();
        }

        return color;
    }

    // https://stackoverflow.com/a/1636354/5825537 - this will capture ARGB and RGB hex colors
    [GeneratedRegex("^#(?:[0-9a-fA-F]{3,4}){1,2}$")]
    private static partial Regex s_hexColorRegexARGB();

    /// <summary>
    /// Will create a color from a hex code string.
    /// </summary>
    /// <param name="hex">A hex string. Must start with # and contain either 3, 4, 6 or 8 characters.</param>
    /// <returns>A <see cref="Color"/> object</returns>
    /// <exception cref="ArgumentException">if the string can't be parsed.
    /// For an exception-safe fallback, please use <see cref="CreateFromHexOrRandom"/></exception>
    public static Color CreateFromHex(string hex)
    {
        ArgumentNullException.ThrowIfNull(hex);

        if (!s_hexColorRegexARGB().IsMatch(hex))
        {
            throw new ArgumentException(
                $"String {hex} is not a valid hex color code. Must start with # and be 3, 4, 6 or 8 characters long.");
        }

        if (ColorConverter.ConvertFromString(hex) is Color color)
        {
            return color;
        }

        throw new WolvenKitException(0x5002, $"String {hex} could not be parsed to a color.");
    }

    /// <summary>
    /// Will create a color if the parameter is a valid hex code, otherwise return null.
    /// </summary>
    public static Color? CreateFromHexOrNull(string? hex)
    {
        if (IsHexColorCode(hex))
        {
            return CreateFromHex(hex!);
        }

        return null;
    }

    public static bool IsHexColorCode(string? s) => s is not null && s_hexColorRegexARGB().IsMatch(s);
}