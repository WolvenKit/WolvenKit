using System.Linq;
using System.Windows.Media;
using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;
using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// Colors shown next to values stored as numbers: which material parameters count as colors, HDR colors,
/// light temperatures and gradient strips.
/// </summary>
public class ColorPreviewHelperTests
{
    [Theory]
    [InlineData("BaseColorScale", true)]
    [InlineData("HSV_Mod", true)]
    [InlineData("TintColor", true)]
    [InlineData("EmissiveColor", true)]
    [InlineData("LayerColor1", true)]
    [InlineData("TintColor_2", true)]
    [InlineData("DirtTint", true)]
    [InlineData("ColorMaskLevelsIn", false)]
    [InlineData("Roughness", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void IsColorParameter(string? name, bool expected) =>
        Assert.Equal(expected, ColorPreviewHelper.IsColorParameter(name));

    [Fact]
    public void HsvParameter_IsNoRgbColor() =>
        Assert.False(ColorPreviewHelper.IsRgbColorParameter("HSV_Mod"));

    [Fact]
    public void FromChannels_HdrScaledToBrightestChannel()
    {
        Assert.Equal(Color.FromRgb(255, 128, 0), ColorPreviewHelper.FromChannels(4f, 2f, 0f));
        Assert.Equal(Color.FromRgb(128, 64, 0), ColorPreviewHelper.FromChannels(0.5f, 0.25f, 0f));
    }

    [Fact]
    public void FromKelvin_UnsetIsNull_WarmAndCool()
    {
        Assert.Null(ColorPreviewHelper.FromKelvin(-1f));
        Assert.Null(ColorPreviewHelper.FromKelvin(0f));

        var warm = ColorPreviewHelper.FromKelvin(2700f)!.Value;
        Assert.Equal(255, warm.R);
        Assert.True(warm.B < warm.G);

        var daylight = ColorPreviewHelper.FromKelvin(6500f)!.Value;
        Assert.True(daylight.R > 240 && daylight.G > 240 && daylight.B > 240);

        var cool = ColorPreviewHelper.FromKelvin(12000f)!.Value;
        Assert.True(cool.B > cool.R);
    }

    [Fact]
    public void GradientStrip_StopsOrderedByPosition()
    {
        var entries = new CArray<rendGradientEntry>
        {
            new() { Value = 1f, Color = new CColor { Red = (byte)0, Green = (byte)0, Blue = (byte)255, Alpha = (byte)255 } },
            new() { Value = 0f, Color = new CColor { Red = (byte)255, Green = (byte)0, Blue = (byte)0, Alpha = (byte)255 } },
        };

        var brush = Assert.IsType<LinearGradientBrush>(
            ColorPreviewHelper.ToGradientBrush(ColorPreviewHelper.GetGradientStops(entries)!));

        Assert.Equal(new[] { 0.0, 1.0 }, brush.GradientStops.Select(s => s.Offset));
        Assert.Equal(Colors.Red, brush.GradientStops[0].Color);
        Assert.Equal(Colors.Blue, brush.GradientStops[1].Color);
    }

    [Fact]
    public void GradientStops_OnlyForGradientArrays()
    {
        Assert.Null(ColorPreviewHelper.GetGradientStops(new CArray<CFloat>()));
        Assert.Null(ColorPreviewHelper.ToGradientBrush([]));
    }
}
