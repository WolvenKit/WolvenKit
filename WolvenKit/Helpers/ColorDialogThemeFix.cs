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
    /// When such a window or editor is shown, its large neutral (gray) surfaces are replaced with theme backgrounds:
    /// light ones with ContentBackground, and, in the window itself, dark ones with ContentBackgroundAlt2.
    /// </summary>
    public static class ColorDialogThemeFix
    {
        private const string s_lightSurfaceKey = "ContentBackground";
        private const string s_darkSurfaceKey = "ContentBackgroundAlt2";

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
            if (IsSyncfusionWindow(window))
            {
                RecolorDeferred(window, true);
            }
            else
            {
                RecolorDeferred(edit, false);
            }
        }

        private static void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is not Window window || !IsSyncfusionWindow(window))
            {
                return;
            }

            RecolorDeferred(window, true);

            // Tab content (Standard / Custom) is rebuilt when switching tabs.
            window.AddHandler(Selector.SelectionChangedEvent, new SelectionChangedEventHandler((_, _) => RecolorDeferred(window, true)));
        }

        private static bool IsSyncfusionWindow(Window window) =>
            window?.GetType().Namespace?.StartsWith("Syncfusion", StringComparison.Ordinal) == true;

        private static void RecolorDeferred(DependencyObject root, bool includeDark) =>
            root.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action(() => Recolor(root, includeDark)));

        private static void Recolor(DependencyObject node, bool includeDark)
        {
            if (node is FrameworkElement element)
            {
                switch (element)
                {
                    case Panel:
                        Fix(element, Panel.BackgroundProperty, includeDark);
                        break;
                    case Border:
                        Fix(element, Border.BackgroundProperty, includeDark);
                        break;
                    case Control:
                        Fix(element, Control.BackgroundProperty, includeDark);
                        break;
                }
            }

            var count = VisualTreeHelper.GetChildrenCount(node);
            for (var i = 0; i < count; i++)
            {
                Recolor(VisualTreeHelper.GetChild(node, i), includeDark);
            }
        }

        private static void Fix(FrameworkElement element, DependencyProperty property, bool includeDark)
        {
            if (element.ActualWidth < s_minWidth || element.ActualHeight < s_minHeight)
            {
                return;
            }

            if (element.GetValue(property) is not SolidColorBrush brush || !IsOpaqueNeutral(brush.Color, out var isLight))
            {
                return;
            }

            if (!isLight && !includeDark)
            {
                return;
            }

            // Bound or resource-referenced backgrounds (the picked color, already themed brushes); leave them alone.
            if (DependencyPropertyHelper.GetValueSource(element, property).IsExpression)
            {
                return;
            }

            element.SetResourceReference(property, isLight ? s_lightSurfaceKey : s_darkSurfaceKey);
        }

        private static bool IsOpaqueNeutral(Color color, out bool isLight)
        {
            isLight = false;
            if (color.A < 200)
            {
                return false;
            }

            var max = Math.Max(color.R, Math.Max(color.G, color.B));
            var min = Math.Min(color.R, Math.Min(color.G, color.B));
            if (max - min > 24)
            {
                return false;
            }

            isLight = min >= 0xC0;
            return true;
        }
    }
}
