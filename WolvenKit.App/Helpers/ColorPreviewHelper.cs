using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

/// <summary>
/// Colors shown next to values in the file editor where the file only stores numbers: CColor / HDRColor values,
/// color parameters of materials, gradients (hair profiles, .gradient files) and light temperatures.
/// </summary>
public static class ColorPreviewHelper
{
    // Vector4 material parameters that hold colors under names that don't say so
    private static readonly string[] s_vectorColorParameters = ["BaseColorScale", "HSV_Mod", "TintColor"];

    // ... and those that aren't RGB (HSV): edited with the color editor, but no swatch
    private static readonly string[] s_notRgbParameters = ["HSV_Mod"];

    /// <summary>
    /// Whether a Vector4 material parameter is a color: the known names, and names ending in Color / Colour /
    /// Tint (also with a number or underscore after it, e.g. TintColor_2, LayerColor1).
    /// </summary>
    public static bool IsColorParameter(string? name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return false;
        }

        if (s_vectorColorParameters.Contains(name))
        {
            return true;
        }

        var stem = name.TrimEnd('_', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
        return stem.EndsWith("Color", StringComparison.OrdinalIgnoreCase) ||
               stem.EndsWith("Colour", StringComparison.OrdinalIgnoreCase) ||
               stem.EndsWith("Tint", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>A color parameter whose X, Y, Z are red, green, blue.</summary>
    public static bool IsRgbColorParameter(string? name) => IsColorParameter(name) && !s_notRgbParameters.Contains(name);

    public static Color FromCColor(CColor color) => Color.FromRgb(color.Red, color.Green, color.Blue);

    /// <summary>
    /// Channels as stored (0..1). HDR colors brighter than 1 are scaled down to their brightest channel, so the
    /// swatch shows their hue instead of white.
    /// </summary>
    public static Color FromChannels(float r, float g, float b)
    {
        var max = Math.Max(r, Math.Max(g, b));
        if (float.IsFinite(max) && max > 1f)
        {
            r /= max;
            g /= max;
            b /= max;
        }

        return MultilayerPalette.ToColor(r, g, b);
    }

    /// <summary>
    /// The color of a light temperature in kelvin (Tanner Helland's approximation of the black body color,
    /// 1000 K .. 40000 K); null for temperatures that aren't set (the game uses -1).
    /// </summary>
    public static Color? FromKelvin(float kelvin)
    {
        if (!float.IsFinite(kelvin) || kelvin <= 0f)
        {
            return null;
        }

        var t = Math.Clamp(kelvin, 1000.0, 40000.0) / 100.0;

        var r = t <= 66 ? 255 : 329.698727446 * Math.Pow(t - 60, -0.1332047592);
        var g = t <= 66 ? 99.4708025861 * Math.Log(t) - 161.1195681661 : 288.1221695283 * Math.Pow(t - 60, -0.0755148492);
        var b = t >= 66 ? 255 : t <= 19 ? 0 : 138.5177312231 * Math.Log(t - 10) - 305.0447927307;

        return Color.FromRgb(ToByte(r), ToByte(g), ToByte(b));

        static byte ToByte(double value) => (byte)Math.Clamp(Math.Round(value), 0, 255);
    }

    /// <summary>A left-to-right brush of gradient stops (position 0..1, color); null without stops.</summary>
    public static Brush? ToGradientBrush(IEnumerable<(float Position, Color Color)> stops)
    {
        var ordered = stops
            .Where(s => float.IsFinite(s.Position))
            .OrderBy(s => s.Position)
            .ToList();

        if (ordered.Count == 0)
        {
            return null;
        }

        Brush brush = ordered.Count == 1
            ? new SolidColorBrush(ordered[0].Color)
            : new LinearGradientBrush(
                new GradientStopCollection(ordered.Select(s => new GradientStop(s.Color, Math.Clamp(s.Position, 0f, 1f)))),
                0.0);
        brush.Freeze();
        return brush;
    }

    /// <summary>The stops of a gradient array (hair profiles, .gradient files); null for other arrays.</summary>
    public static IEnumerable<(float Position, Color Color)>? GetGradientStops(IRedType? data) => data switch
    {
        CArray<rendGradientEntry> entries => entries.Select(e => ((float)e.Value, FromCColor(e.Color))),
        CArray<rendHairProfileGradientEntry> entries => entries.Select(e => ((float)e.Value, FromCColor(e.Color))),
        _ => null,
    };
}
