using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using ReactiveUI;
using Splat;
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Helpers;
using WolvenKit.Views.Shell;

namespace WolvenKit
{
    public static class Initializations
    {
        /// <summary>
        /// Initialize everything related to Theming.
        /// </summary>
        public static void InitializeThemeHelper()
        {
            var settingsManager = Locator.Current.GetService<ISettingsManager>();

            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            if (settingsManager.UiScale == 0)
            {
                settingsManager.UiScale = (int)(100.0 * ComputeScaleFromResolution(SystemParameters.PrimaryScreenHeight));
            }
            RegisterTheme(settingsManager);
        }

        public static void InitializeSyntaxHighlighting()
        {
            var customHighlightNames = new string[] { "JavaScript-DarkMode", "YAML" };

            foreach (var customHighlightName in customHighlightNames)
            {
                // Load our custom highlighting definition
                IHighlightingDefinition customHighlighting;
                using var s = Assembly.GetExecutingAssembly().GetManifestResourceStream($"WolvenKit.Resources.SyntaxHighlighting.{customHighlightName}.xshd");
                if (s == null)
                {
                    throw new InvalidOperationException("Could not find embedded resource");
                }

                using XmlReader reader = new XmlTextReader(s);
                var hlXshdDef = HighlightingLoader.LoadXshd(reader);
                customHighlighting = HighlightingLoader.Load(hlXshdDef, HighlightingManager.Instance);

                // and register it in the HighlightingManager
                HighlightingManager.Instance.RegisterHighlighting(hlXshdDef.Name, hlXshdDef.Extensions.ToArray(), customHighlighting);
            }
        }

        public static void InitializeLicenses()
        {
            const string v_28_1_37 =
                "MzY1NDE3MkAzMjM4MmUzMDJlMzBWTW0zT1RINnoxU1hvQU1BeElmM2JtNWdHaVJVMlFsSm1idVE1aFB4cTZZPQ==";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(v_28_1_37);
        }

        public static void InitializeShell(ISettingsManager settingsManager)
        {
            // Set service locator.
            var mainWindow = Locator.Current.GetService<IViewFor<AppViewModel>>();

            GcHelper.CleanupMemory();

            if (mainWindow is MainView window)
            {
                window.Show();
            }

            if (WolvenDBG.EnableTheming)
            {
                RegisterTheme(settingsManager);
            }
        }

        private static void RegisterTheme(ISettingsManager settingsManager)
        {
            var themeSettings = BuildTheme(settingsManager);

            SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
            SfSkinManager.ApplyStylesOnApplication = true;
        }

        // NOTE: used for debug environment
        public static void UpdateTheme(ISettingsManager settingsManager)
        {
            var window = Application.Current.MainWindow;
            // NOTE: trick SfSkinManager to unregister current ThemeSettings.
            var theme = SfSkinManager.GetTheme(window);

            theme.ThemeName = "";
            var themeSettings = BuildTheme(settingsManager);

            SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
            SfSkinManager.ApplyStylesOnApplication = true;
            SfSkinManager.SetTheme(window, new Theme("MaterialDark"));
            window.InvalidateVisual();
            window.UpdateLayout();
            window.Visibility = Visibility.Collapsed;

            Task.Delay(1000).ContinueWith(_ =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    window.InvalidateVisual();
                    window.UpdateLayout();
                    window.Visibility = Visibility.Visible;
                });
            });
        }

        private static IThemeSetting BuildTheme(ISettingsManager settingsManager)
        {
            return new MaterialDarkThemeSettings
            {
                PrimaryBackground = new SolidColorBrush(settingsManager.GetThemeAccent()),
                BodyFontSize = 11 * settingsManager.UiScalePercentage,
                HeaderFontSize = 14 * settingsManager.UiScalePercentage,
                SubHeaderFontSize = 13 * settingsManager.UiScalePercentage,
                TitleFontSize = 13 * settingsManager.UiScalePercentage,
                SubTitleFontSize = 12 * settingsManager.UiScalePercentage,
                BodyAltFontSize = 11 * settingsManager.UiScalePercentage,
                FontFamily = new FontFamily("Segoe UI")
            };
        }

        private static double ComputeScaleFromResolution(double height)
        {
            var scale = height / 1080.0;

            scale = Math.Clamp(scale, 1.0, 4.0);
            return scale;
        }
    }
}
