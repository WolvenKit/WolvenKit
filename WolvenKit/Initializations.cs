using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Helpers;
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
            //var themeResources = new HandyControl.Themes.ThemeResources { AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3") };
            var themeSettings = new MaterialDarkThemeSettings
            {
                PrimaryBackground = new SolidColorBrush(settingsManager.GetThemeAccent()),
                BodyFontSize = 11,
                HeaderFontSize = 14,
                SubHeaderFontSize = 13,
                TitleFontSize = 13,
                SubTitleFontSize = 12,
                BodyAltFontSize = 11,
                FontFamily = new FontFamily("Segoe UI")
            };
            SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
            SfSkinManager.ApplyStylesOnApplication = true;
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
            //const string v_20_4_0 = "MTAyOTE5MEAzMjMwMmUzNDJlMzBIUHZua0RGUW5HZmIxekNYR1ZFY2lOOFFQSVBQam1sbWkxSXJLa3NWN1hFPQ==";
            const string v_23_2_6 = "Mjk2MTEyNUAzMjMzMmUzMDJlMzBDN1VPNTlPRExWZERrWGR5SzFXS1lSa2NPNlZ2YXByVGN0eGlqZ3hDVDd3PQ==";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(v_23_2_6);
        }

        public static /*async Task*/ void InitializeShell(ISettingsManager settings)
        {
            // Set service locator.
            var mainWindow = Locator.Current.GetService<IViewFor<AppViewModel>>();
            if (mainWindow is MainView window)
            {
                window.Show();
            }

            if (WolvenDBG.EnableTheming)
            {
                ThemeInnerInit(settings);
            }
        }

        private static void ThemeInnerInit(ISettingsManager settings)
        {
            var themeSettings = new MaterialDarkThemeSettings
            {
                PrimaryBackground = new SolidColorBrush(settings.GetThemeAccent()),
                BodyFontSize = 11,
                HeaderFontSize = 14,
                SubHeaderFontSize = 13,
                TitleFontSize = 13,
                SubTitleFontSize = 12,
                BodyAltFontSize = 11,
                FontFamily = new FontFamily("Segoe UI")
            };

            SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
            //  SfSkinManager.SetTheme(StaticReferences.GlobalShell, new FluentTheme() { ThemeName = "MaterialDark", ShowAcrylicBackground = true });
        }
    }
}
