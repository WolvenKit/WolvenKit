using System;
using System.Windows;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.GraphEditor;

public partial class GraphCommentViewModel : ObservableObject
{
    private const double MinWidth = 180;
    private const double MinHeight = 120;
    private const double MaxWidth = 4000;
    private const double MaxHeight = 2600;
    public const string DefaultAccentColor = "#FFAAAAAA";
    public const double DefaultWidth = 360;
    public const double DefaultHeight = 220;

    public string Id { get; init; } = Guid.NewGuid().ToString("N");

    public int ZIndex => -1000;

    public double MaximumWidth => MaxWidth;

    public double MaximumHeight => MaxHeight;

    [ObservableProperty]
    private string _text = "Comment";

    [ObservableProperty]
    private bool _isEditing;

    [ObservableProperty]
    private string _accentColor = DefaultAccentColor;

    [ObservableProperty]
    private Point _location;

    private double _width = DefaultWidth;
    public double Width
    {
        get => _width;
        set => SetProperty(ref _width, ClampDimension(value, MinWidth, MaxWidth));
    }

    private double _height = DefaultHeight;
    public double Height
    {
        get => _height;
        set => SetProperty(ref _height, ClampDimension(value, MinHeight, MaxHeight));
    }

    public Size Size
    {
        get => new(Width, Height);
        set { }
    }

    public Brush BorderBrush => CreateBrush(AccentColor, 0xFF);

    public Brush HeaderBrush => CreateBrush(AccentColor, 0xDD);

    public Brush BackgroundBrush => CreateBrush(AccentColor, 0x22);

    public void ResetSize()
    {
        Width = DefaultWidth;
        Height = DefaultHeight;
    }

    private static double ClampDimension(double value, double min, double max)
    {
        if (double.IsNaN(value))
        {
            return min;
        }

        if (double.IsInfinity(value))
        {
            return max;
        }

        return Math.Clamp(value, min, max);
    }

    partial void OnAccentColorChanged(string value)
    {
        OnPropertyChanged(nameof(BorderBrush));
        OnPropertyChanged(nameof(HeaderBrush));
        OnPropertyChanged(nameof(BackgroundBrush));
    }

    private static Brush CreateBrush(string colorValue, byte alpha)
    {
        var color = ParseColor(colorValue);
        color.A = alpha;

        var brush = new SolidColorBrush(color);
        brush.Freeze();
        return brush;
    }

    private static Color ParseColor(string colorValue)
    {
        try
        {
            if (ColorConverter.ConvertFromString(colorValue) is Color color)
            {
                return color;
            }
        }
        catch (FormatException)
        {
        }

        return Colors.Gold;
    }
}
