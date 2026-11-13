using System;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace WolvenKit.Helpers
{
    /// <summary>
    /// Library controls with their own fixed colors that the WolvenKit themes don't reach:
    /// AdonisUI (message boxes such as "unsaved changes", the settings page; ComponentResourceKeys) and the
    /// MahApps toggle switch (off state). This copies the current theme colors into the application resources
    /// under the library keys; call it after a theme was applied.
    /// </summary>
    public static class AdonisThemeBridge
    {
        private static readonly string[] s_toggleOffKeys =
        [
            "MahApps.Brushes.ToggleSwitch.StrokeOff",
            "MahApps.Brushes.ToggleSwitch.StrokeOffPointerOver",
            "MahApps.Brushes.ToggleSwitch.StrokeOffPressed",
            "MahApps.Brushes.ToggleSwitch.KnobFillOff",
            "MahApps.Brushes.ToggleSwitch.KnobFillOffPointerOver",
            "MahApps.Brushes.ToggleSwitch.KnobFillOffPressed",
        ];

        /// <summary>The library colors, merged last into the application resources and replaced as a whole.</summary>
        private static ResourceDictionary s_dictionary;

        public static void Apply()
        {
            if (Application.Current is not { } app)
            {
                return;
            }

            // Every write into the application resources makes WPF re-evaluate the resource references of all
            // windows. Fill a new dictionary and swap it in once instead of writing the keys one by one.
            var resources = new ResourceDictionary();

            if (app.TryFindResource("WolvenKitToggleOff") is SolidColorBrush toggleOff)
            {
                foreach (var key in s_toggleOffKeys)
                {
                    var brush = new SolidColorBrush(toggleOff.Color);
                    brush.Freeze();
                    resources[key] = brush;
                }
            }

            // AdonisUI exposes its keys as static properties (older versions: fields)
            var members = typeof(AdonisUI.Brushes).GetMembers(BindingFlags.Public | BindingFlags.Static);
            foreach (var member in members)
            {
                var value = member switch
                {
                    PropertyInfo property when property.GetIndexParameters().Length == 0 => property.GetValue(null),
                    FieldInfo field => field.GetValue(null),
                    _ => null
                };
                if (value is not ComponentResourceKey key
                    || GetThemeKey(member.Name) is not { } themeKey
                    || app.TryFindResource(themeKey) is not SolidColorBrush source)
                {
                    continue;
                }

                var brush = new SolidColorBrush(source.Color);
                brush.Freeze();
                resources[key] = brush;
            }

            var merged = app.Resources.MergedDictionaries;
            var index = s_dictionary is null ? -1 : merged.IndexOf(s_dictionary);
            if (index >= 0)
            {
                merged[index] = resources;
            }
            else
            {
                // after the AdonisUI and MahApps dictionaries, so these values win
                merged.Add(resources);
            }
            s_dictionary = resources;
        }

        /// <summary>WolvenKit theme key for an AdonisUI brush (by its field name), or null to keep the AdonisUI color.</summary>
        private static string GetThemeKey(string name)
        {
            if (name.Contains("Foreground", StringComparison.Ordinal))
            {
                if (name.Contains("Disabled", StringComparison.Ordinal))
                {
                    return "ForegroundColor_Grey_Inactive";
                }
                return name.StartsWith("Accent", StringComparison.Ordinal) ? "WolvenKitAccentForeground" : "ContentForeground";
            }

            if (name.StartsWith("Accent", StringComparison.Ordinal))
            {
                return name.Contains("Highlight", StringComparison.Ordinal) || name.Contains("Interaction", StringComparison.Ordinal)
                    ? "WolvenKitAccentShadow"
                    : "WolvenKitAccent";
            }

            if (name.StartsWith("Layer", StringComparison.Ordinal))
            {
                if (name.Contains("Border", StringComparison.Ordinal))
                {
                    return "BorderAlt";
                }
                if (name.Contains("IntenseHighlight", StringComparison.Ordinal))
                {
                    return "ContentBackgroundAlt5";
                }
                if (name.Contains("Highlight", StringComparison.Ordinal) || name.Contains("Interaction", StringComparison.Ordinal))
                {
                    return "ContentBackgroundAlt4";
                }
                if (name.Contains("Background", StringComparison.Ordinal))
                {
                    return name switch
                    {
                        _ when name.StartsWith("Layer0", StringComparison.Ordinal) => "ContentBackground",
                        _ when name.StartsWith("Layer1", StringComparison.Ordinal) => "ContentBackgroundAlt2",
                        _ when name.StartsWith("Layer2", StringComparison.Ordinal) => "ContentBackgroundAlt3",
                        _ when name.StartsWith("Layer3", StringComparison.Ordinal) => "ContentBackgroundAlt4",
                        _ => "ContentBackgroundAlt5"
                    };
                }
                return null;
            }

            return name switch
            {
                "ErrorBrush" => "WolvenKitRed",
                "AlertBrush" => "WolvenKitYellow",
                "SuccessBrush" => "WolvenKitGreen",
                "HyperlinkBrush" => "WolvenKitCyan",
                _ when name.StartsWith("Window", StringComparison.Ordinal) && name.Contains("Background", StringComparison.Ordinal) => "ContentBackgroundAlt2",
                _ => null
            };
        }
    }
}
