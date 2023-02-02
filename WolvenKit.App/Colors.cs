using System.Windows.Media;

namespace WolvenKit.App;

public static class WkitColors
{
    public static Color Red = Color.FromRgb(0xDF, 0x29, 0x35);
    public static Color Cyan = Color.FromRgb(0x52, 0xF1, 0xFF);
    public static Color Yellow = Color.FromRgb(0xFF, 0xEA, 0x0A);
    public static Color Purple = Color.FromRgb(0x57, 0x60, 0xB3);
    public static Color Tan = Color.FromRgb(0xD0, 0xA4, 0x67);
}

public static class WkitBrushes
{
    public static SolidColorBrush Red = new(WkitColors.Red);
    public static SolidColorBrush Cyan = new(WkitColors.Cyan);
    public static SolidColorBrush Yellow = new(WkitColors.Yellow);
    public static SolidColorBrush Purple = new(WkitColors.Purple);
    public static SolidColorBrush Tan = new(WkitColors.Tan);
}
