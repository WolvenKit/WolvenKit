// TruncatingTextBox.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WolvenKit.Views.Templates;

#pragma warning disable WPF0132
[TemplatePart(Name = nameof(DisplayTextBox), Type = typeof(TextBox))]
[TemplatePart(Name = nameof(EditTextBox), Type = typeof(TextBox))]
#pragma warning restore WPF0132
public partial class TruncatingTextBox : UserControl
{
    private bool _displayTextBoxChangeDetection = false;
    private bool _editTextBoxChangeDetection = false;
    private bool _initialized = false;

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        DisplayTextBox = GetTemplateChild("DisplayTextBox") as TextBox;
        EditTextBox = GetTemplateChild("EditTextBox") as TextBox;

        if (DisplayTextBox is not null && !_displayTextBoxChangeDetection)
        {
            DisplayTextBox.MouseUp += OnDisplayBoxClicked;
            DisplayTextBox.GotFocus += OnFocusGained;
            _displayTextBoxChangeDetection = true;
        }

        if (EditTextBox is not null && !_editTextBoxChangeDetection)
        {
            EditTextBox.GotFocus += OnEditBoxFocusGained;
            EditTextBox.LostFocus += OnFocusLost;
            _editTextBoxChangeDetection = true;
        }

        if (!_initialized)
        {
            SetCurrentValue(HasNoFocusProperty, true);
            _initialized = true;
        }

        SizeChanged += TruncatingTextBox_SizeChanged;
    }

    // ReSharper disable once InconsistentNaming
#pragma warning disable IDE1006
    private TextBox DisplayTextBox;

    // ReSharper disable once InconsistentNaming
    private TextBox EditTextBox;
#pragma warning restore IDE1006

    /// <summary>Identifies the <see cref="EditText"/> dependency property. This will be written back to parent.</summary>
    public static readonly DependencyProperty EditTextProperty = DependencyProperty.Register(
        nameof(EditText), typeof(string), typeof(TruncatingTextBox),
        new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnEditTextChanged));

    /// <summary>Identifies the <see cref="DisplayText"/> dependency property. This is only for display purposes</summary>
    public static readonly DependencyProperty DisplayTextProperty = DependencyProperty.Register(
        nameof(DisplayText), typeof(string), typeof(TruncatingTextBox),
        new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnDisplayTextChanged));

    private int _numTruncatedChars = 0;
    
    public string EditText
    {
        get => (string)GetValue(EditTextProperty);
        set => SetValue(EditTextProperty, value);
    }

    public string DisplayText
    {
        get => (string)GetValue(DisplayTextProperty);
        set => SetValue(DisplayTextProperty, TruncateText(value));
    }


    public static readonly DependencyProperty HasFocusProperty = DependencyProperty.Register(
        nameof(HasFocus), typeof(bool), typeof(TruncatingTextBox),
        new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnHasFocusChanged));

    public bool HasFocus
    {
        get => (bool)GetValue(HasFocusProperty);
        set => SetValue(HasFocusProperty, value);
    }


    public static readonly DependencyProperty HasNoFocusProperty = DependencyProperty.Register(
        nameof(HasNoFocus), typeof(bool), typeof(TruncatingTextBox),
        new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnHasNoFocusChanged));

    public bool HasNoFocus
    {
        get => (bool)GetValue(HasNoFocusProperty);
        set => SetValue(HasNoFocusProperty, value);
    }

    private string TruncateText(string value)
    {
        if (value is null)
        {
            return "";
        }

        if (value.StartsWith('…'))
        {
            return value;
        }
        
        var typeface = new Typeface(DisplayTextBox.FontFamily, DisplayTextBox.FontStyle, DisplayTextBox.FontWeight,
            DisplayTextBox.FontStretch);
        var dpi = VisualTreeHelper.GetDpi(DisplayTextBox);
        var formattedText = new FormattedText(
            value,
            System.Globalization.CultureInfo.CurrentCulture,
            FlowDirection.LeftToRight,
            typeface,
            DisplayTextBox.FontSize,
            DisplayTextBox.Foreground,
            dpi.PixelsPerDip); // Use PixelsPerDip for DPI settings

        var maxWidth = DisplayTextBox.ActualWidth * 0.95;

        if (formattedText.Width < maxWidth)
        {
            return value; 
        }

        var truncatedText = value;

        _numTruncatedChars = 0;

        while (formattedText.Width > maxWidth && truncatedText.Length > 0)
        {
            _numTruncatedChars += 1;
            truncatedText = truncatedText[1..];
            formattedText = new FormattedText(
                truncatedText,
                System.Globalization.CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                typeface,
                DisplayTextBox.FontSize,
                DisplayTextBox.Foreground,
                dpi.PixelsPerDip); // Use PixelsPerDip for DPI settings
        }

        // DisplayTextBox.TextAlignment = TextAlignment.Right;
        return $"…{truncatedText}";
    }

    static TruncatingTextBox() =>
        DefaultStyleKeyProperty.OverrideMetadata(typeof(TruncatingTextBox), new FrameworkPropertyMetadata(typeof(TruncatingTextBox)));

    private static void OnEditTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TruncatingTextBox view)
        {
            return;
        }

        Console.WriteLine($"OnEditTextChanged to {e.NewValue}");
        view.EditText = (string)e.NewValue;
        view.DisplayText = view.TruncateText((string)e.NewValue);
    }

    private static void OnDisplayTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TruncatingTextBox view)
        {
            return;
        }

        view.DisplayText = view.TruncateText((string)e.NewValue);
    }


    // Recalculate the value of the textboxes
    private void TruncatingTextBox_SizeChanged(object sender, SizeChangedEventArgs e) =>
        SetCurrentValue(DisplayTextProperty, TruncateText(EditText));


    private void OnFocusLost(object sender, RoutedEventArgs e)
    {
        SetCurrentValue(HasFocusProperty, (bool)false);
    }

    // This will not focus the display text box at the first click. Don't ask me why, it's UI stuff
    private void OnDisplayBoxClicked(object sender, MouseButtonEventArgs e)
    {
        DisplayTextBox.Focus();
    }

    private void OnFocusGained(object sender, RoutedEventArgs e)
    {
        SetCurrentValue(HasFocusProperty, (bool)true);
        EditTextBox.Focus();
    }

    /// <summary>
    /// On focusing the display box, transfer caret position and -selection to edit box. If caret pos is 0, set to end of text. 
    /// </summary>
    private void OnEditBoxFocusGained(object sender, RoutedEventArgs e)
    {
        EditText ??= "";

        if (EditTextBox is null || DisplayTextBox is null || DisplayTextBox.CaretIndex == 0)
        {
            return;
        }

        EditTextBox.CaretIndex = Math.Min(EditText.Length, DisplayTextBox.CaretIndex + _numTruncatedChars);

        if (DisplayTextBox.SelectionLength > 0)
        {
            EditTextBox.Select(EditTextBox.CaretIndex,
                Math.Min(EditTextBox.CaretIndex + DisplayTextBox.SelectionLength, DisplayText.Length));
        }
    }

    private static void OnHasFocusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TruncatingTextBox view)
        {
            return;
        }

        view.DisplayText = view.EditText;
        view.HasFocus = (bool)e.NewValue;
    }

    private static void OnHasNoFocusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TruncatingTextBox view)
        {
            return;
        }

        view.HasNoFocus = (bool)e.NewValue;
    }

}