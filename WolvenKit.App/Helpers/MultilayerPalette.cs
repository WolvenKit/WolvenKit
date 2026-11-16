using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace WolvenKit.App.Helpers;

/// <summary>One colorScale override of a multilayer template: its name and v (0..1 per channel, as stored).</summary>
public sealed record MultilayerPaletteColor(string Name, float R, float G, float B);

/// <summary>
/// Layout of a multilayer template's colorScale overrides as a palette, after the palette of the Cyberpunk
/// Blender add-on (materials/blender/multilayer.py): the overrides are grouped by the part of their name before
/// the first '_' ("00cf56_69039f" → "00cf56"), each group is one row that starts with its base colour
/// ("00cf56_null"), and the rows are ordered by that base colour. The add-on's hand-tuned in-row offsets for
/// some kinds of templates are not copied.
/// </summary>
public static class MultilayerPalette
{
    /// <summary>Hue steps of the ordering, as in the add-on.</summary>
    private const int Repetitions = 8;

    /// <summary>
    /// The colour of stored channels, shown as they are (0..1 → 0..255), like the colorScale dropdown and the
    /// add-on's palette; values outside 0..1 are clamped.
    /// </summary>
    public static Color ToColor(float r, float g, float b) => Color.FromRgb(ToByte(r), ToByte(g), ToByte(b));

    public static Color ToColor(MultilayerPaletteColor color) => ToColor(color.R, color.G, color.B);

    private static byte ToByte(float value) =>
        float.IsFinite(value) ? (byte)Math.Clamp(Math.Round(value * 255.0), 0, 255) : (byte)0;

    public static IReadOnlyList<IReadOnlyList<MultilayerPaletteColor>> GroupIntoRows(IEnumerable<MultilayerPaletteColor> colors)
    {
        var groups = new List<List<MultilayerPaletteColor>>();
        var byPrefix = new Dictionary<string, List<MultilayerPaletteColor>>(StringComparer.Ordinal);
        foreach (var color in colors)
        {
            var prefix = color.Name.Split('_', 2)[0];
            if (!byPrefix.TryGetValue(prefix, out var group))
            {
                byPrefix[prefix] = group = [];
                groups.Add(group);
            }

            group.Add(color);
        }

        return groups
            .Select((group, index) => (Row: BaseFirst(group, out var baseColor), Base: baseColor, Index: index))
            // rows with a base colour by that colour, the others after them in file order
            .OrderBy(g => g.Base is null ? 1 : 0)
            .ThenBy(g => g.Base is null ? default : StepSortKey(g.Base.R, g.Base.G, g.Base.B))
            .ThenBy(g => g.Index)
            .Select(g => g.Row)
            .ToList();
    }

    private static IReadOnlyList<MultilayerPaletteColor> BaseFirst(List<MultilayerPaletteColor> group, out MultilayerPaletteColor? baseColor)
    {
        var found = group.FirstOrDefault(c => c.Name.EndsWith("_null", StringComparison.Ordinal));
        baseColor = found;
        return found is null ? group : [found, .. group.Where(c => !ReferenceEquals(c, found))];
    }

    /// <summary>
    /// The add-on's cp77_step_sort: hue in steps (grays before all hues), then brightness, with the direction
    /// alternating from one hue step to the next, so neighbouring rows change smoothly.
    /// </summary>
    internal static (int Hue, double Luminance, int Value) StepSortKey(float r, float g, float b)
    {
        var luminance = Math.Sqrt(Math.Max(0.0, (0.241 * r) + (0.691 * g) + (0.068 * b)));
        var (h, s, v) = RgbToHsv(r, g, b);
        var hue = s < 0.01 ? -1 : (int)(h * Repetitions);
        var value = (int)(v * Repetitions);

        // Python's modulo: -1 % 2 is 1 there, so grays take the alternate direction too
        if (((hue % 2) + 2) % 2 == 1)
        {
            value = Repetitions - value;
            luminance = Repetitions - luminance;
        }

        return (hue, luminance, value);
    }

    /// <summary>Python's colorsys.rgb_to_hsv (hue 0..1).</summary>
    internal static (double H, double S, double V) RgbToHsv(double r, double g, double b)
    {
        var max = Math.Max(r, Math.Max(g, b));
        var min = Math.Min(r, Math.Min(g, b));
        if (min == max)
        {
            return (0, 0, max);
        }

        var s = (max - min) / max;
        var rc = (max - r) / (max - min);
        var gc = (max - g) / (max - min);
        var bc = (max - b) / (max - min);
        double h;
        if (r == max)
        {
            h = bc - gc;
        }
        else if (g == max)
        {
            h = 2.0 + rc - bc;
        }
        else
        {
            h = 4.0 + gc - rc;
        }

        h /= 6.0;
        return (h - Math.Floor(h), s, max);
    }
}
