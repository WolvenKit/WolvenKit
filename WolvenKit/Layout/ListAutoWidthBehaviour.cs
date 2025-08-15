using System;

namespace WolvenKit.Layout;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

public static class ListAutoWidthBehaviour
{
    public static readonly DependencyProperty AutoWidthToLongestItemProperty =
        DependencyProperty.RegisterAttached(
            "AutoWidthToLongestItem",
            typeof(bool),
            typeof(ListAutoWidthBehaviour),
            new PropertyMetadata(false, OnAutoWidthToLongestItemChanged));

    public static void SetAutoWidthToLongestItem(DependencyObject element, bool value)
        => element.SetValue(AutoWidthToLongestItemProperty, value);

    public static bool GetAutoWidthToLongestItem(DependencyObject element)
        => (bool)element.GetValue(AutoWidthToLongestItemProperty);

    private static void OnAutoWidthToLongestItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is ListBox listBox && (bool)e.NewValue)
        {
            listBox.Loaded += (s, args) =>
            {
                double maxWidth = 0;
                foreach (var item in listBox.Items)
                {
                    var container = new ListBoxItem { Content = item };
                    container.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                    maxWidth = Math.Max(maxWidth, container.DesiredSize.Width);
                }

                listBox.MinWidth = maxWidth * 1.1; // Add some padding
            };
        }
    }
}