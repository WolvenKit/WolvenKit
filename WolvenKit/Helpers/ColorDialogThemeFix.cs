using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;
using ColorEdit = Syncfusion.Windows.Shared.ColorEdit;

namespace WolvenKit.Helpers
{
    /// <summary>
    /// The "More colors" window of Syncfusion's ColorPickerPalette (and its ColorEdit) keeps light, hardcoded
    /// surfaces that the MaterialDark theme does not recolor, so the theme text color becomes unreadable on them.
    /// When such a window or editor is shown, large light-gray surfaces are replaced with the theme background.
    /// </summary>
    public static class ColorDialogThemeFix
    {
        private const string s_backgroundKey = "ContentBackground";

        // Only large containers are recolored, so color swatches (including white/gray ones) stay untouched.
        private const double s_minWidth = 80;
        private const double s_minHeight = 40;

        private static bool s_registered;

        public static void Register()
        {
            if (s_registered)
            {
                return;
            }

            s_registered = true;
            EventManager.RegisterClassHandler(typeof(ColorEdit), FrameworkElement.LoadedEvent, new RoutedEventHandler(OnColorEditLoaded));
            EventManager.RegisterClassHandler(typeof(Window), FrameworkElement.LoadedEvent, new RoutedEventHandler(OnWindowLoaded));
        }

        private static void OnColorEditLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is not ColorEdit edit)
            {
                return;
            }

            var window = Window.GetWindow(edit);
            RecolorDeferred(IsSyncfusionWindow(window) ? window : edit);
        }

        private static void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is not Window window || !IsSyncfusionWindow(window))
            {
                return;
            }

            RecolorDeferred(window);

            // Tab content (Standard / Custom) is rebuilt when switching tabs.
            window.AddHandler(Selector.SelectionChangedEvent, new SelectionChangedEventHandler((_, _) => RecolorDeferred(window)));
        }

        private static bool IsSyncfusionWindow(Window window) =>
            window?.GetType().Namespace?.StartsWith("Syncfusion", StringComparison.Ordinal) == true;

        private static void RecolorDeferred(DependencyObject root) =>
            root.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action(() => Recolor(root)));

        private static void Recolor(DependencyObject node)
        {
            if (node is FrameworkElement element)
            {
                switch (element)
                {
                    case Panel:
                        Fix(element, Panel.BackgroundProperty);
                        break;
                    case Border:
                        Fix(element, Border.BackgroundProperty);
                        break;
                    case Control:
                        Fix(element, Control.BackgroundProperty);
                        break;
                }
            }

            var count = VisualTreeHelper.GetChildrenCount(node);
            for (var i = 0; i < count; i++)
            {
                Recolor(VisualTreeHelper.GetChild(node, i));
            }
        }

        private static void Fix(FrameworkElement element, DependencyProperty property)
        {
            if (element.ActualWidth < s_minWidth || element.ActualHeight < s_minHeight)
            {
                return;
            }

            if (element.GetValue(property) is not SolidColorBrush brush || !IsLightNeutral(brush.Color))
            {
                return;
            }

            // Bound backgrounds show the picked color; leave them alone.
            if (DependencyPropertyHelper.GetValueSource(element, property).IsExpression)
            {
                return;
            }

            element.SetResourceReference(property, s_backgroundKey);
        }

        private static bool IsLightNeutral(Color color)
        {
            if (color.A < 200)
            {
                return false;
            }

            var max = Math.Max(color.R, Math.Max(color.G, color.B));
            var min = Math.Min(color.R, Math.Min(color.G, color.B));
            return min >= 0xC0 && max - min <= 24;
        }
    }
}
