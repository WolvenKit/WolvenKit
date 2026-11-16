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
