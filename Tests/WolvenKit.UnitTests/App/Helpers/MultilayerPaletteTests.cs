using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// The palette of a multilayer template's colorScale overrides: grouping and order after the Blender add-on
/// (reference values from its cp77_step_sort and Python's colorsys), and the colour of stored channels.
/// </summary>
public class MultilayerPaletteTests
{
    private static MultilayerPaletteColor C(string name, float r, float g, float b) => new(name, r, g, b);

    [Fact]
    public void GroupIntoRows_GroupsByPrefix_BaseFirst_OrderedByBaseColour()
    {
        var colors = new[]
        {
            C("aaa_1", 0.8f, 0.2f, 0.2f), C("aaa_null", 0.9f, 0.1f, 0.1f),
            C("ccc_null", 0.2f, 0.6f, 0.9f), C("ccc_1", 0.1f, 0.5f, 0.8f),
            C("bbb_1", 0.4f, 0.4f, 0.4f), C("bbb_null", 0.5f, 0.5f, 0.5f),
            C("eee_1", 0.3f, 0.3f, 0.0f), // no base colour
            C("ddd_null", 0.1f, 0.8f, 0.2f),
        };

        var rows = MultilayerPalette.GroupIntoRows(colors);

        // as the add-on: gray first, then by hue step (red 0, green 2, blue 4); groups without a base last
        Assert.Equal(new[] { "bbb", "aaa", "ddd", "ccc", "eee" }, rows.Select(r => r[0].Name.Split('_')[0]));
        Assert.Equal(new[] { "aaa_null", "aaa_1" }, rows[1].Select(c => c.Name));
        Assert.Equal(new[] { "ccc_null", "ccc_1" }, rows[3].Select(c => c.Name));
        Assert.Equal(colors.Length, rows.Sum(r => r.Count));
    }

    [Fact]
    public void GroupIntoGrid_OneRowPerSuffix_BaseOnTop_SaturatedBeforeGrey()
    {
        var colors = new[]
        {
            C("aaa_null", 0.9f, 0.1f, 0.1f), C("aaa_grey", 0.5f, 0.45f, 0.45f), C("aaa_sat", 0.8f, 0.2f, 0.2f),
            C("ccc_null", 0.2f, 0.6f, 0.9f), C("ccc_sat", 0.1f, 0.5f, 0.8f),
        };

        var grid = MultilayerPalette.GroupIntoGrid(colors);

        // "grey" is only the red group's: no row of its own, below the rows
        Assert.Equal(new[] { "null", "sat" }, grid.RowSuffixes);
        Assert.Equal(2, grid.Columns.Count);
        Assert.Equal(new[] { "aaa_null", "aaa_sat", "aaa_grey" }, grid.Columns[0].Cells.Select(c => c?.Name));
        // the blue group has nothing below the rows: an empty cell
        Assert.Equal(new[] { "ccc_null", "ccc_sat", null }, grid.Columns[1].Cells.Select(c => c?.Name));
        Assert.Equal(0, grid.Columns[0].HueStep);
        Assert.Equal(4, grid.Columns[1].HueStep);
    }

    [Fact]
    public void GroupIntoGrid_ColumnsByHueStep_LightToDarkInEachStep_GreysFirst()
    {
        var colors = new[]
        {
            C("orange_null", 1.0f, 0.6f, 0.2f), // same hue step as red, lighter: before it
            C("blue_null", 0.2f, 0.4f, 0.9f),
            C("red_null", 0.9f, 0.1f, 0.1f),
            C("dark_null", 0.2f, 0.2f, 0.2f),
            C("green_null", 0.1f, 0.8f, 0.2f),
            C("light_null", 0.8f, 0.8f, 0.8f),
            C("darkred_null", 0.5f, 0.05f, 0.05f),
        };

        var grid = MultilayerPalette.GroupIntoGrid(colors);

        Assert.Equal(new[] { "light", "dark", "orange", "red", "darkred", "green", "blue" },
            grid.Columns.Select(c => c.Cells[0]!.Name.Split('_')[0]));
    }

    [Fact]
    public void GroupIntoGrid_CustomColours_BelowTheRows_NotRowsOfTheirOwn()
    {
        var colors = new[]
        {
            C("aaa_null", 0.9f, 0.1f, 0.1f), C("aaa_v1", 0.8f, 0.3f, 0.3f), C("aaa_my blue", 0.0f, 0.0f, 1.0f),
            C("ccc_null", 0.2f, 0.6f, 0.9f), C("ccc_v1", 0.3f, 0.6f, 0.8f),
            C("ddd_null", 0.1f, 0.8f, 0.2f), C("ddd_v1", 0.3f, 0.7f, 0.4f), C("ddd_my red", 0.7f, 0.2f, 0.2f),
        };

        var grid = MultilayerPalette.GroupIntoGrid(colors);

        Assert.Equal(new[] { "null", "v1" }, grid.RowSuffixes);
        Assert.Equal(new[] { "aaa_null", "aaa_v1", "aaa_my blue" }, grid.Columns[0].Cells.Select(c => c?.Name));
        Assert.Equal(new[] { "ddd_null", "ddd_v1", "ddd_my red" }, grid.Columns[1].Cells.Select(c => c?.Name));
        Assert.Equal(new[] { "ccc_null", "ccc_v1", null }, grid.Columns[2].Cells.Select(c => c?.Name));
    }

    [Fact]
    public void GroupIntoGrid_UnsharedSuffixes_KeepEachGroupsOrder()
    {
        var colors = new[]
        {
            C("aaa_null", 0.9f, 0.1f, 0.1f), C("aaa_x1", 0.8f, 0.2f, 0.2f),
            C("ccc_null", 0.2f, 0.6f, 0.9f), C("ccc_y1", 0.1f, 0.5f, 0.8f),
            C("ddd_null", 0.1f, 0.8f, 0.2f), C("ddd_z1", 0.1f, 0.7f, 0.2f),
        };

        var grid = MultilayerPalette.GroupIntoGrid(colors);

        // four suffixes for groups of two: not aligned, each column top-aligned in its own order
        Assert.Empty(grid.RowSuffixes);
        Assert.All(grid.Columns, c => Assert.Equal(2, c.Cells.Count));
        Assert.Equal(new[] { "aaa_null", "aaa_x1" }, grid.Columns[0].Cells.Select(c => c?.Name));
    }

    [Theory]
    [InlineData(0.9f, 0.1f, 0.1f, 0, 0.5411, 7)]
    [InlineData(0.5f, 0.5f, 0.5f, -1, 7.2929, 4)]   // gray: hue -1, odd in Python, so reversed
    [InlineData(0.2f, 0.6f, 0.9f, 4, 0.7239, 7)]
    [InlineData(0.1f, 0.8f, 0.2f, 2, 0.7684, 6)]
    public void StepSortKey_MatchesTheAddOn(float r, float g, float b, int hue, double luminance, int value)
    {
        var key = MultilayerPalette.StepSortKey(r, g, b);

        Assert.Equal(hue, key.Hue);
        Assert.Equal(luminance, key.Luminance, 3);
        Assert.Equal(value, key.Value);
    }

    [Fact]
    public void RgbToHsv_MatchesColorsys()
    {
        var (h, s, v) = MultilayerPalette.RgbToHsv(0.2, 0.6, 0.9);

        Assert.Equal(0.571428, h, 5);
        Assert.Equal(0.777778, s, 5);
        Assert.Equal(0.9, v, 5);
        Assert.Equal((0.0, 0.0, 0.5), MultilayerPalette.RgbToHsv(0.5, 0.5, 0.5));
    }

    [Fact]
    public void ToColor_ShowsStoredChannels_Clamped()
    {
        Assert.Equal(Color.FromRgb(177, 99, 70), MultilayerPalette.ToColor(0.695f, 0.389f, 0.273f));
        Assert.Equal(Color.FromRgb(255, 0, 0), MultilayerPalette.ToColor(1.5f, -0.2f, float.NaN));
    }

    [Fact]
    public void SuggestColorName_GameFormat_NewGroupsAndVariants()
    {
        var taken = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "a1b2c3_null", "a1b2c3_48e702" };
        var random = new Random(81);

        for (var i = 0; i < 50; i++)
        {
            var group = ChunkViewModel.SuggestColorName(null, taken, random);
            Assert.Matches("^[0-9a-f]{6}_null$", group);
            Assert.DoesNotContain(taken, name => name.StartsWith(group[..6] + "_", StringComparison.OrdinalIgnoreCase));

            var basis = new Multilayer_LayerTemplateOverridesColor { N = "a1b2c3_null" };
            var variant = ChunkViewModel.SuggestColorName(basis, taken, random);
            Assert.Matches("^a1b2c3_[0-9a-f]{6}$", variant);
            Assert.DoesNotContain(variant, taken);

            taken.Add(group);
            taken.Add(variant);
        }
    }
}
