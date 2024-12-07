// (c) Copyright Jacob Johnston.
// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.App.Helpers;

public static class UIHelper
{
    #region Methods

    public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp) => Bind(dataSource, sourcePath, destinationObject, dp, null, BindingMode.Default, null);

    public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, BindingMode bindingMode) => Bind(dataSource, sourcePath, destinationObject, dp, null, bindingMode, null);

    public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, string stringFormat) => Bind(dataSource, sourcePath, destinationObject, dp, stringFormat, BindingMode.Default, null);

    public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, string stringFormat, BindingMode bindingMode) => Bind(dataSource, sourcePath, destinationObject, dp, stringFormat, bindingMode, null);

    public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, string? stringFormat, BindingMode bindingMode, IValueConverter? converter)
    {
        var binding = new Binding
        {
            Source = dataSource,
            UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
            Mode = bindingMode,
            Path = new PropertyPath(sourcePath),
            StringFormat = stringFormat,
            Converter = converter
        };
        destinationObject.SetBinding(dp, binding);
    }

    //public static T FindParent<T>(this DependencyObject child) where T : DependencyObject
    //{
    //    var parent = VisualTreeHelper.GetParent(child);
    //    do
    //    {
    //        var matchedParent = parent as T;
    //        if (matchedParent != null)
    //        {
    //            return matchedParent;
    //        }

    //        parent = VisualTreeHelper.GetParent(parent);
    //    }
    //    while (parent != null);

    //    return null;
    //}

    private static readonly Typeface s_arial = new("Arial");
    private static readonly Typeface s_segoeUi = new("Segoe UI");

    /// <summary>
    /// Creates a formatted text object and returns the width.
    /// </summary>
    /// <param name="text">Text to compute the width for</param>
    /// <param name="fontSize">Font size to compute the width for, default 13.0</param>
    /// <param name="font">Font to compute the width for, default "Segoe UI"</param>
    /// <returns>Computed width as DIP</returns>
    public static int GetTextWidth(string text, double fontSize = 13, Typeface? font = null)
    {
        font ??= s_segoeUi;
        return Convert.ToInt32(new FormattedText(text,
            System.Globalization.CultureInfo.CurrentCulture,
            FlowDirection.LeftToRight,
            font,
            fontSize,
            Brushes.Black,
            pixelsPerDip: 96D).Width);
    }

    public static void SetMaxHeightToScreenHeight(Window window) => window.MaxHeight = SystemParameters.PrimaryScreenHeight * 0.9;

    #endregion Methods
}
