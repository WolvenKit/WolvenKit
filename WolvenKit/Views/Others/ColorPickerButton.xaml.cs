using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.App.Helpers;

namespace WolvenKit.Views.Others;

public class ColorChangedEventArgs : EventArgs
{
    public Color OldColor { get; }
    public Color NewColor { get; }

    public ColorChangedEventArgs(Color oldColor, Color newColor)
    {
        OldColor = oldColor;
        NewColor = newColor;
    }
}

public partial class ColorPickerButton : UserControl, IDisposable
{
    public ColorPickerButton()
    {
        InitializeComponent();

        // force color picker to update because Syncfusion I guess
        var color = Color;
        ColorPickerControl.Color = Color.FromRgb(0, 0, 0);
        ColorPickerControl.Color = color;
    }

    public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
        nameof(Color),
        typeof(Color),
        typeof(ColorPickerButton),
        new PropertyMetadata(ColorHelper.GetRandomColor()));


    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }

    private void ColorPickerControl_OnChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var oldValue = Color;
        SetCurrentValue(ColorProperty, ColorPickerControl.Color);
    }

    public void Dispose() => ColorPickerControl?.Dispose();
}