using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Syncfusion.Windows.PropertyGrid;
using Splat;
using WolvenKit.App.Services.Themes;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Helpers
{
    /// <summary>
    /// Syncfusion control styles resolve their brushes with StaticResource, so a control that was templated
    /// before a theme switch keeps the old colors. A fresh copy of a Syncfusion style dictionary, with its
    /// Brushes.xaml swapped for the application's recolored one, builds its styles with the current colors.
    /// </summary>
    public static class SyncfusionFreshStyles
    {
        private const string ThemeAssembly = "pack://application:,,,/Syncfusion.Themes.MaterialDark.WPF;component/";

        public const string DockingManagerStyles = ThemeAssembly + "DockingManager/DockingManager.xaml";
        public const string PropertyGridStyles = ThemeAssembly + "PropertyGrid/PropertyGrid.xaml";

        /// <summary>A new instance of the Syncfusion style dictionary at <paramref name="uri"/>, or null.</summary>
        public static ResourceDictionary Load(string uri, ILoggerService logger)
        {
            try
            {
                if (FindSyncfusionBrushes(Application.Current.Resources) is not { } brushes)
                {
                    logger?.Debug("Themes: Syncfusion Brushes.xaml not found in the application resources.");
                    return null;
                }

                var fresh = new ResourceDictionary { Source = new Uri(uri, UriKind.Absolute) };
                ReplaceSyncfusionBrushes(fresh, brushes);
                return fresh;
            }
            catch (Exception e)
            {
                logger?.Warning($"Themes: could not load {uri}: {e.Message}");
                return null;
            }
        }

        /// <summary>
        /// Gives every Syncfusion PropertyGrid on screen (windows and popups) a freshly built style. Grids that
        /// are not loaded right now (hidden panels) keep the old colors until restart.
        /// </summary>
        public static void RefreshPropertyGrids(ILoggerService logger)
        {
            var grids = new List<PropertyGrid>();
            foreach (var source in PresentationSource.CurrentSources.OfType<PresentationSource>().ToList())
            {
                if (source.RootVisual is { } root)
                {
                    Collect(root, grids);
                }
            }

            if (grids.Count == 0)
            {
                return;
            }

            if (Load(PropertyGridStyles, logger) is not { } fresh)
            {
                return;
            }

            // the grid styles define colors of their own besides Brushes.xaml; give them the theme's
            var patched = Locator.Current.GetService<IThemeService>()?.Patch(fresh) ?? 0;

            foreach (var grid in grids)
            {
                try
                {
                    // Only the grid's own style. Merging the fresh dictionary into the grid's resources (for the
                    // styles of its parts) throws inside WPF (NullReferenceException): the copy shares the
                    // application's Brushes.xaml with the application resources.
                    if (fresh[typeof(PropertyGrid)] is Style style)
                    {
                        grid.Style = style;
                    }
                }
                catch (Exception e)
                {
                    logger?.Warning($"Themes: could not restyle a property grid: {e.Message}");
                }
            }

            logger?.Debug($"Themes: {grids.Count} property grid(s) restyled ({patched} colors of their styles patched).");
        }

        private static void Collect(DependencyObject element, List<PropertyGrid> grids)
        {
            if (element is PropertyGrid grid)
            {
                // nested grids (editors inside a grid) follow their parent's resources
                grids.Add(grid);
                return;
            }

            var count = VisualTreeHelper.GetChildrenCount(element);
            for (var i = 0; i < count; i++)
            {
                Collect(VisualTreeHelper.GetChild(element, i), grids);
            }
        }

        private static bool IsSyncfusionBrushes(ResourceDictionary dictionary) =>
            dictionary.Source?.OriginalString.EndsWith("/Common/Brushes.xaml", StringComparison.OrdinalIgnoreCase) == true;

        private static ResourceDictionary FindSyncfusionBrushes(ResourceDictionary dictionary)
        {
            foreach (var merged in dictionary.MergedDictionaries)
            {
                if (IsSyncfusionBrushes(merged))
                {
                    return merged;
                }
                if (FindSyncfusionBrushes(merged) is { } found)
                {
                    return found;
                }
            }
            return null;
        }

        private static void ReplaceSyncfusionBrushes(ResourceDictionary dictionary, ResourceDictionary brushes)
        {
            for (var i = 0; i < dictionary.MergedDictionaries.Count; i++)
            {
                var merged = dictionary.MergedDictionaries[i];
                if (IsSyncfusionBrushes(merged))
                {
                    dictionary.MergedDictionaries[i] = brushes;
                }
                else
                {
                    ReplaceSyncfusionBrushes(merged, brushes);
                }
            }
        }
    }
}
