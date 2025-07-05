using System;
using System.Windows;

namespace WolvenKit.App.Extensions;

public static class ThicknessExtensions
{
    public static Thickness Mul(this Thickness a, double b) => new(a.Left * b, a.Top * b, a.Right * b, a.Bottom * b);
    public static Thickness Round(this Thickness a) => new(Math.Round(a.Left), Math.Round(a.Top), Math.Round(a.Right), Math.Round(a.Bottom));
}

public static class CornerRadiusExtensions
{
    public static CornerRadius Mul(this CornerRadius a, double b) => new(a.TopLeft * b, a.TopRight * b, a.BottomRight * b, a.BottomLeft * b);
    public static CornerRadius Round(this CornerRadius a) => new(Math.Round(a.TopLeft), Math.Round(a.TopRight), Math.Round(
        a.BottomRight), Math.Round(a.BottomLeft));
}

public static class GridLengthExtensions
{
    public static GridLength Mul(this GridLength a, double b) => new(a.Value * b, a.GridUnitType);
    public static GridLength Round(this GridLength a) => new(Math.Round(a.Value), a.GridUnitType);
}

public static class RectExtensions
{
    public static Rect Mul(this Rect a, double b) => new(a.X, a.Y, a.Width * b, a.Height * b);
    public static Rect Round(this Rect a) => new(Math.Round(a.X), Math.Round(a.Y), Math.Round(a.Width), Math.Round(a.Height));
}