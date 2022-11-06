using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using Microsoft.Web.WebView2.Core;
using ReactiveUI;
using Splat;
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Shell;

namespace WolvenKit
{
    public static class Initializations
    {
        [DllImport("WebView2Loader.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetAvailableCoreWebView2BrowserVersionString(string browserExecutableFolder, out string version);

        public static bool IsMissingWebView2() => GetAvailableCoreWebView2BrowserVersionString(null, out var edgeVersion) != 0 || edgeVersion == null;

        public static async Task InitializeWebview2(ILoggerService _loggerService)
        {
            // check prerequisites
            // check Webview2
            //var keyName = @"SOFTWARE\Wow6432Node\Microsoft\EdgeUpdate\ClientState\{F3017226-FE2A-4295-8BDF-00C3A9A7E4C5}";
            //var keyvalue = "pv";
            //StaticReferences.IsWebView2Enabled = Models.Commonfunctions.RegistryValueExists(Microsoft.Win32.RegistryHive.LocalMachine, keyName, keyvalue);
            StaticReferences.IsWebView2Enabled = !IsMissingWebView2();

            if (!StaticReferences.IsWebView2Enabled)
            {
                try
                {
                    var bootstrapperLink = @"https://go.microsoft.com/fwlink/p/?LinkId=2124703";

                    var host = new Uri(bootstrapperLink).Host;
                    var reply = new Ping().Send(host, 3000);
                    if (reply.Status != IPStatus.Success)
                    {
                        return;
                    }

                    var bootstrapper = Path.Combine(Path.GetTempPath(), "MicrosoftEdgeWebview2Setup.exe");
                    if (!File.Exists(bootstrapper))
                    {
                        // download
                        HttpClient client = new();
                        var response = await client.GetAsync(new Uri(bootstrapperLink));
                        response.EnsureSuccessStatusCode();

                        await using var fs = new FileStream(bootstrapper, System.IO.FileMode.Create);
                        await response.Content.CopyToAsync(fs);
                    }

                    var result = AdonisUI.Controls.MessageBox.Show(
                        "This App requires the Microsoft Webview 2 runtime to properly work.\r\nClick OK to run the 'WebView2 Runtime installer' and close the app. Please restart afterwards.",
                        "Microsoft Webview 2 runtime not installed",
                        AdonisUI.Controls.MessageBoxButton.OKCancel,
                        AdonisUI.Controls.MessageBoxImage.Error,
                        AdonisUI.Controls.MessageBoxResult.OK);
                    if (result == AdonisUI.Controls.MessageBoxResult.OK)
                    {
                        // install runtime with MicrosoftEdgeWebview2Setup.exe /silent /install
                        var psi = new ProcessStartInfo
                        {
                            FileName = bootstrapper,
                            //Arguments = $"/silent /install"
                        };
                        var p = Process.Start(psi);

                        //System.Windows.Forms.Application.Restart();
                        System.Windows.Application.Current.Shutdown();
                    }
                }
                catch (Exception ex)
                {
                    _loggerService.Error(ex);
                    return;
                }
            }

            var webViewData = ISettingsManager.GetWebViewDataPath();
            Directory.CreateDirectory(webViewData);
            WebView2Helper.objCoreWebView2Environment = await CoreWebView2Environment.CreateAsync(null, webViewData, null);
        }

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
            // Load our custom highlighting definition
            IHighlightingDefinition customHighlighting;
            using (var s = Assembly.GetExecutingAssembly().GetManifestResourceStream("WolvenKit.Resources.SyntaxHighlighting.JavaScript-DarkMode.xshd")) {
                if (s == null)
                    throw new InvalidOperationException("Could not find embedded resource");
                using (XmlReader reader = new XmlTextReader(s)) {
                    customHighlighting = ICSharpCode.AvalonEdit.Highlighting.Xshd.
                        HighlightingLoader.Load(reader, HighlightingManager.Instance);
                }
            }
            // and register it in the HighlightingManager
            HighlightingManager.Instance.RegisterHighlighting("JavaScript DarkMode", new string[] { ".wscript" }, customHighlighting);
        }

        public static void InitializeLicenses() => Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1MDYwQDMxMzkyZTMxMmUzMGNBRjJJdnZoVnJjaklqMTVNL0FNR0JJR3dqR0Fac21YalpQOVEyTkd6bms9");

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
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(System.Windows.Application.Current,
                ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", settings.GetThemeAccent(), false));
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
