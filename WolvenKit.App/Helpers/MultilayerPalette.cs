using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace WolvenKit.App.Helpers;

/// <summary>One colorScale override of a multilayer template: its name and v (0..1 per channel, as stored).</summary>
public sealed record MultilayerPaletteColor(string Name, float R, float G, float B);

/// <summary>A color group as a column of the grid: its hue step and one cell per row (null where it has no color).</summary>
public sealed record MultilayerPaletteColumn(int HueStep, IReadOnlyList<MultilayerPaletteColor?> Cells);

/// <summary>The palette as a grid: the variant suffix of each row and the color groups as columns.</summary>
public sealed record MultilayerPaletteGrid(IReadOnlyList<string> RowSuffixes, IReadOnlyList<MultilayerPaletteColumn> Columns);

/// <summary>
/// Layout of a multilayer template's colorScale overrides as a palette, after the palette of the Cyberpunk
/// Blender add-on (materials/blender/multilayer.py): the overrides are grouped by the part of their name before
/// the first '_' ("00cf56_69039f" → "00cf56"), each group is one row that starts with its base color
/// ("00cf56_null"), and the rows are ordered by that base color. The add-on's hand-tuned in-row offsets for
/// some kinds of templates are not copied.
/// </summary>
public static class MultilayerPalette
{
    /// <summary>Hue steps of the ordering, as in the add-on.</summary>
    private const int Repetitions = 8;

    /// <summary>
    /// The color of stored channels, shown as they are (0..1 → 0..255), like the colorScale dropdown and the
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
            // rows with a base color by that color, the others after them in file order
            .OrderBy(g => g.Base is null ? 1 : 0)
            .ThenBy(g => g.Base is null ? default : StepSortKey(g.Base.R, g.Base.G, g.Base.B))
            .ThenBy(g => g.Index)
            .Select(g => g.Row)
            .ToList();
    }

    /// <summary>
    /// The palette as a strip of columns, like CDPR's material browser: the groups as columns in blocks by the hue
    /// step of their base color (grays first, then the add-on's 8 hue steps), light to dark inside every block,
    /// and one row per variant suffix ("00cf56_69039f" → "69039f"), so a row is the same saturation / value step
    /// for every hue. The base color ("_null") is the top row, the other suffixes follow from the most saturated
    /// on average to the grayest. Rows are only for suffixes more than one group has: colors of their own
    /// (a custom variant) follow below the rows, in the group's order. A template whose groups share no suffix
    /// besides the base color keeps each group's own order, top-aligned (no rows: RowSuffixes is empty).
    /// </summary>
    public static MultilayerPaletteGrid GroupIntoGrid(IEnumerable<MultilayerPaletteColor> colors)
    {
        var groups = GroupIntoRows(colors)
            .Select((group, index) => (Group: group, Index: index, Key: HueSortKey(group)))
            .OrderBy(g => g.Key.Kind)
            .ThenBy(g => g.Key.HueStep)
            .ThenByDescending(g => g.Key.Luminance)
            .ThenBy(g => g.Key.Hue)
            .ThenBy(g => g.Index)
            .Select(g => g.Group)
            .ToList();
        if (groups.Count == 0)
        {
            return new MultilayerPaletteGrid([], []);
        }

        var stats = new Dictionary<string, (double Sum, int Count, int First)>(StringComparer.Ordinal);
        var order = 0;
        foreach (var color in groups.SelectMany(g => g))
        {
            var suffix = Suffix(color.Name);
            var (_, s, _) = RgbToHsv(color.R, color.G, color.B);
            stats[suffix] = stats.TryGetValue(suffix, out var st)
                ? (st.Sum + s, st.Count + 1, st.First)
                : (s, 1, order);
            order++;
        }

        // a row only for suffixes more than one group has; one-off colors (a custom "00cf56_my red") would
        // each open a row that is empty everywhere else, so they go below the rows, in the group's own order
        var suffixes = stats
            .Where(p => p.Value.Count > 1)
            .OrderBy(p => p.Key == "null" ? 0 : 1)
            .ThenByDescending(p => p.Value.Sum / p.Value.Count)
            .ThenBy(p => p.Value.First)
            .Select(p => p.Key)
            .ToList();
        if (suffixes.Count < 2)
        {
            // nothing shared besides the base color: each group in its own order, top-aligned
            suffixes = [];
        }

        var rowOf = suffixes.Select((sfx, i) => (sfx, i)).ToDictionary(p => p.sfx, p => p.i, StringComparer.Ordinal);
        var extras = groups.Select(g => g.Where(c => !rowOf.ContainsKey(Suffix(c.Name))).ToList()).ToList();
        var extraRows = extras.Max(e => e.Count);

        var columns = groups
            .Select((group, i) =>
            {
                var baseColor = group.FirstOrDefault(c => Suffix(c.Name) == "null");
                var hue = baseColor is null ? int.MaxValue : StepSortKey(baseColor.R, baseColor.G, baseColor.B).Hue;
                IReadOnlyList<MultilayerPaletteColor?> cells =
                [
                    .. suffixes.Select(sfx => group.FirstOrDefault(c => Suffix(c.Name) == sfx)),
                    .. extras[i],
                    .. Enumerable.Repeat<MultilayerPaletteColor?>(null, extraRows - extras[i].Count),
                ];
                return new MultilayerPaletteColumn(hue, cells);
            })
            .ToList();

        return new MultilayerPaletteGrid(suffixes, columns);
    }

    /// <summary>
    /// Grays (0), colors (1), groups without a base color (2, in palette order); then the hue step (the add-on's
    /// 8 steps), the perceived brightness (the add-on's formula) and the hue. Unlike the add-on's step sort the
    /// brightness runs the same way in every step: the grid's gaps already separate the steps.
    /// </summary>
    private static (int Kind, int HueStep, double Luminance, double Hue) HueSortKey(IReadOnlyList<MultilayerPaletteColor> group)
    {
        if (group.FirstOrDefault(c => Suffix(c.Name) == "null") is not { } baseColor)
        {
            return (2, 0, 0, 0);
        }

        var (h, s, _) = RgbToHsv(baseColor.R, baseColor.G, baseColor.B);
        var luminance = Math.Sqrt((0.241 * baseColor.R) + (0.691 * baseColor.G) + (0.068 * baseColor.B));
        return s < 0.01 ? (0, 0, luminance, 0) : (1, (int)(h * 8), luminance, h);
    }

    private static string Suffix(string name) => name.Split('_', 2) is { Length: 2 } parts ? parts[1] : "";

    private static IReadOnlyList<MultilayerPaletteColor> BaseFirst(List<MultilayerPaletteColor> group, out MultilayerPaletteColor? baseColor)
    {
        var found = group.FirstOrDefault(c => c.Name.EndsWith("_null", StringComparison.Ordinal));
        baseColor = found;
        return found is null ? group : [found, .. group.Where(c => !ReferenceEquals(c, found))];
    }

    /// <summary>
    /// The add-on's cp77_step_sort: hue in steps (grays before all hues), then brightness, with the direction
    /// alternating from one hue step to the next, so neighboring rows change smoothly.
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
