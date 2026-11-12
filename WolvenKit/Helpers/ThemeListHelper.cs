using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.App.Services.Themes;

namespace WolvenKit.Helpers
{
    /// <summary>
    /// Shared presentation of the theme list (View → Theme menu, settings dropdown):
    /// grouped into dark, light and the user's own themes, with a small color swatch per theme.
    /// </summary>
    public static class ThemeListHelper
    {
        public const string DarkGroup = "Dark";
        public const string LightGroup = "Light";
        public const string UserGroup = "My themes";

        /// <summary>
        /// Groups in display order: built-in dark, built-in light, user themes. The default theme comes first,
        /// everything else alphabetically. Light / dark is decided by the brightness of the background color.
        /// </summary>
        public static IReadOnlyList<(string Group, IReadOnlyList<ThemeDto> Themes)> Group(IThemeService service)
        {
            static IReadOnlyList<ThemeDto> Sort(IEnumerable<ThemeDto> themes) =>
                themes.OrderByDescending(t => t.IsDefault)
                    .ThenBy(t => t.DisplayName, StringComparer.CurrentCultureIgnoreCase)
                    .ToList();

            var builtIn = service.Themes.Where(t => t.IsBuiltIn).ToList();
            var light = builtIn.Where(t => IsLight(service, t)).ToList();

            var groups = new List<(string, IReadOnlyList<ThemeDto>)>
            {
                (DarkGroup, Sort(builtIn.Except(light))),
                (LightGroup, Sort(light)),
                (UserGroup, Sort(service.Themes.Where(t => !t.IsBuiltIn)))
            };
            return groups.Where(g => g.Item2.Count > 0).ToList();
        }

        public static bool IsLight(IThemeService service, ThemeDto theme)
        {
            var background = GetBackground(service, theme);
            var luminance = ((0.2126 * background.R) + (0.7152 * background.G) + (0.0722 * background.B)) / 255.0;
            return luminance > 0.5;
        }

        /// <summary>A small square in the theme's background color with a strip of its accent.</summary>
        public static FrameworkElement CreateSwatch(IThemeService service, ThemeDto theme)
        {
            var accent = new Border
            {
                Height = 4,
                VerticalAlignment = VerticalAlignment.Bottom,
                Background = Frozen(service.ResolveAccent(theme))
            };

            var swatch = new Border
            {
                Width = 16,
                Height = 16,
                BorderThickness = new Thickness(1),
                Background = Frozen(GetBackground(service, theme)),
                Child = accent,
                SnapsToDevicePixels = true
            };
            swatch.SetResourceReference(Border.BorderBrushProperty, "ForegroundColor_Grey_Dark");
            return swatch;
        }

        private static Color GetBackground(IThemeService service, ThemeDto theme) =>
            service.ResolveEffectiveColors(theme).TryGetValue("ContentBackground", out var color)
                ? color
                : service.GetDefaultColor("ContentBackground") ?? Colors.Black;

        private static SolidColorBrush Frozen(Color color)
        {
            var brush = new SolidColorBrush(color);
            brush.Freeze();
            return brush;
        }
    }
}
