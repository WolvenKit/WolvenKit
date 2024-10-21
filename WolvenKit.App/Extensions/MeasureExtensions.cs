using System.Windows;

namespace WolvenKit.App.Extensions;

public static class ThicknessExtensions
{
    public static Thickness Mul(this Thickness a, double b) => new Thickness(a.Left * b, a.Top * b, a.Right * b, a.Bottom * b);
}

public static class CornerRadiusExtensions
{
    public static CornerRadius Mul(this CornerRadius a, double b) => new CornerRadius(a.TopLeft * b, a.TopRight * b, a.BottomRight * b, a.BottomLeft * b);
}

public static class GridLengthExtensions
{
    public static GridLength Mul(this GridLength a, double b) => new GridLength(a.Value * b, a.GridUnitType);
}

public static class RectExtensions
{
    public static Rect Mul(this Rect a, double b) => new Rect(a.X, a.Y, a.Width * b, a.Height * b);
}