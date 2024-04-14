// TruncatingTextBox.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WolvenKit.Views.Templates;

#pragma warning disable WPF0132
[TemplatePart(Name = nameof(DisplayTextBox), Type = typeof(TextBox))]
[TemplatePart(Name = nameof(EditTextBox), Type = typeof(TextBox))]
#pragma warning restore WPF0132
public partial class TruncatingTextBox : UserControl
{
    public static readonly DependencyProperty EditTextProperty = DependencyProperty.Register(
        nameof(EditText), typeof(string), typeof(TruncatingTextBox),
        new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnEditTextChanged));

    private TextBox DisplayTextBox;
    private TextBox EditTextBox;

    public TruncatingTextBox()
    {
    }

    public string EditText
    {
        get => (string)GetValue(EditTextProperty);
        set => SetValue(EditTextProperty, value);
    }

    private void UpdateDisplayText()
    {
        // Called too early
        if (DisplayTextBox is null)
        {
            return;
        }

        var typeface = new Typeface(DisplayTextBox.FontFamily, DisplayTextBox.FontStyle, DisplayTextBox.FontWeight,
            DisplayTextBox.FontStretch);
        var dpi = VisualTreeHelper.GetDpi(DisplayTextBox);
        var formattedText = new FormattedText(
            EditText,
            System.Globalization.CultureInfo.CurrentCulture,
            FlowDirection.LeftToRight,
            typeface,
            DisplayTextBox.FontSize,
            DisplayTextBox.Foreground,
            dpi.PixelsPerDip); // Use PixelsPerDip for DPI settings

        var maxWidth = DisplayTextBox.ActualWidth + 6;

        if (formattedText.Width < maxWidth)
        {
            SetCurrentValue(DisplayTextProperty, EditText);
            return;
        }

        var truncatedText = EditText;

        while (formattedText.Width > maxWidth && truncatedText.Length > 0)
        {
            truncatedText = truncatedText.Substring(0, truncatedText.Length - 1);
            formattedText = new FormattedText(
                truncatedText,
                System.Globalization.CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                typeface,
                DisplayTextBox.FontSize,
                DisplayTextBox.Foreground,
                dpi.PixelsPerDip); // Use PixelsPerDip for DPI settings
        }

        SetCurrentValue(DisplayTextProperty, truncatedText);
    }

    public static readonly DependencyProperty DisplayTextProperty = DependencyProperty.Register(
        nameof(DisplayText), typeof(string), typeof(TruncatingTextBox), new PropertyMetadata(default(string)));

    public string DisplayText
    {
        get => (string)GetValue(DisplayTextProperty);
        set => SetValue(DisplayTextProperty, value);
    }

    static TruncatingTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(TruncatingTextBox), new FrameworkPropertyMetadata(typeof(TruncatingTextBox)));
    }

    private static void OnEditTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TruncatingTextBox view)
        {
            return;
        }

        // if (!view.onChangeEvent)
        // {
        //     if (view._editTextBox is not null)
        //     {
        //         view._editTextBox.LostFocus += view.OnEditFocusLost;
        //     }
        //
        //     if (view._displayTextBox is not null)
        //     {
        //         view._displayTextBox.GotFocus += view.OnDisplayFocusGained;
        //     }
        // }

        view.EditText = (string)e.NewValue;
        view.UpdateDisplayText();
    }


    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        DisplayTextBox = GetTemplateChild("DisplayTextBox") as TextBox;
        EditTextBox = GetTemplateChild("EditTextBox") as TextBox;

        if (DisplayTextBox is not null)
        {
            DisplayTextBox.GotFocus += OnFocusGained;
            DisplayTextBox.LostFocus += OnFocusLost;
        }

        if (EditTextBox is not null)
        {
            EditTextBox.GotFocus += OnFocusGained;
            EditTextBox.LostFocus += OnFocusLost;
        }
    }

    public event EventHandler HasFocusChanged;

    private bool _hasFocus;

    public bool HasFocus
    {
        get => _hasFocus;
        set
        {
            if (_hasFocus == value)
            {
                return;
            }

            _hasFocus = value;
            OnHasFocusChanged();
        }
    }

    protected virtual void OnHasFocusChanged() => HasFocusChanged?.Invoke(this, EventArgs.Empty);

    private void OnFocusLost(object sender, RoutedEventArgs e) => HasFocus = false;

    private void OnFocusGained(object sender, RoutedEventArgs e) => HasFocus = true;
}