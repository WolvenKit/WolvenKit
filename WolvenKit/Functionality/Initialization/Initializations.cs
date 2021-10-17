using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reactive.Linq;
using System.Windows.Media;
using Microsoft.Web.WebView2.Core;
using Octokit;
using ReactiveUI;
using Splat;
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Shell;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WolvenKit.Functionality.Initialization
{
    public static class Initializations
    {
        public static void InitializeBk(ISettingsManager settings)
        {
            string[] binkhelpers = { @"Resources\Media\t1.kark", @"Resources\Media\t2.kark", @"Resources\Media\t3.kark", @"Resources\Media\t4.kark", @"Resources\Media\t5.kark" };

            if (string.IsNullOrEmpty(settings.GetRED4GameRootDir()))
            {
                Trace.WriteLine("That worked to cancel Loading oodle! :D");
                return;
            }

            var oodlePath = settings.GetRED4OodleDll();

            if (!File.Exists(settings.GetRED4OodleDll()))
            {
                return;
            }

            OodleLoadLib.Load(oodlePath);

            foreach (var path in binkhelpers)
            {
                switch (path)
                {
                    case @"Resources\Media\t1.kark":
                        if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "test.exe")))
                        {
                        }
                        else
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "test.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t2.kark":
                        if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe")))
                        {
                        }
                        else
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t3.kark":
                        if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe")))
                        {
                        }
                        else
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t4.kark":
                        if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll")))
                        {
                        }
                        else
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t5.kark":
                        if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll")))
                        {
                        }
                        else
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll"), true,
                                false);
                        }

                        break;
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="path"></param>
        /// <param name="outpath"></param>
        /// <param name="decompress"></param>
        /// <param name="compress"></param>
        /// <returns></returns>
        private static int OodleTask(string path, string outpath, bool decompress, bool compress)
        {
            if (string.IsNullOrEmpty(path))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(outpath))
            {
                outpath = Path.ChangeExtension(path, ".kark");
            }

            if (decompress)
            {
                var file = File.ReadAllBytes(path);
                using var ms = new MemoryStream(file);
                using var br = new BinaryReader(ms);

                var oodleCompression = br.ReadBytes(4);
                if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                {
                    throw new NotImplementedException();
                }

                var size = br.ReadUInt32();

                var buffer = br.ReadBytes(file.Length - 8);

                byte[] unpacked = new byte[size];
                long unpackedSize = OodleHelper.Decompress(buffer, unpacked);

                using var msout = new MemoryStream();
                using var bw = new BinaryWriter(msout);
                bw.Write(unpacked);

                File.WriteAllBytes($"{outpath}", msout.ToArray());
            }

            if (compress)
            {
                var inbuffer = File.ReadAllBytes(path);
                IEnumerable<byte> outBuffer = new List<byte>();

                var r = OodleHelper.Compress(
                    inbuffer,
                    inbuffer.Length,
                    ref outBuffer,
                    OodleNative.OodleLZ_Compressor.Kraken,
                    OodleNative.OodleLZ_Compression.Normal,
                    true);

                File.WriteAllBytes(outpath, outBuffer.ToArray());
            }

            return 1;
        }

        [DllImport("WebView2Loader.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int GetAvailableCoreWebView2BrowserVersionString(string browserExecutableFolder, out string version);

        public static bool IsMissingWebView2() => (GetAvailableCoreWebView2BrowserVersionString(null, out string edgeVersion) != 0) || (edgeVersion == null);

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
                        using var wc = new WebClient();
                        wc.DownloadFile(new Uri(bootstrapperLink), bootstrapper);
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
            Helpers.Helpers.objCoreWebView2Environment = await CoreWebView2Environment.CreateAsync(null, webViewData, null);
        }

        public static void InitializeRedDB()
        {
            var resourcePath = Path.GetFullPath(Path.Combine("Resources", "red.kark"));
            var destinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "red.db");
            var settings = Splat.Locator.Current.GetService<ISettingsManager>();

            if (!File.Exists(destinationPath))
            {
                OodleTask(resourcePath, destinationPath, true, false);
            }
        }

        /// <summary>
        /// Initialize Github RPC
        /// </summary>
        public static void InitializeGitHub() =>
            StaticReferences.Githubclient =
                new GitHubClient(new ProductHeaderValue("WolvenKit"))
                {
                    Credentials = Github_Helpers.GhubAuth("wolvenbot", "botwolven1")
                };

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

        public static void InitializeLicenses()
        {
            Ab3d.Licensing.PowerToys.LicenseHelper.SetLicense(licenseOwner: "WolvenKit", licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense", license: "9E18-4A3E-3951-8E9C-3686-ACE4-685B-6145-5799-42A9-F82C-C195-5495-5907-4F8D-38B7-661D-386C-5461-9B7C-70AE-46DC-F3CA-1B12");
            Ab3d.Licensing.DXEngine.LicenseHelper.SetLicense(licenseOwner: "WolvenKit", licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense", license: "F564-4078-3E78-F218-D27F-B191-4A32-AD76-2002-F1B1-EE27-7B15-5316-4CEA-5281-FF84-5B56-BECD-12CA-F307-E847-E014-7378-032C");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1MDYwQDMxMzkyZTMxMmUzMGNBRjJJdnZoVnJjaklqMTVNL0FNR0JJR3dqR0Fac21YalpQOVEyTkd6bms9");
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
