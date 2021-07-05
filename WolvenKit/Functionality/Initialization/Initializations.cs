using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Catel.IoC;
using Catel.Logging;
using Catel.MVVM;
using Catel.Services;
using Microsoft.Web.WebView2.Core;
using Octokit;
using Orchestra.Services;
using Orchestra.Views;
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Shell;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Functionality.Initialization
{
    public static class Initializations
    {
        public static void InitializeBk()
        {
            var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();

            string[] binkhelpers = { @"Resources\Media\t1.kark", @"Resources\Media\t2.kark", @"Resources\Media\t3.kark", @"Resources\Media\t4.kark", @"Resources\Media\t5.kark" };

            if (string.IsNullOrEmpty(settings.GetRED4GameRootDir()))
            {
                Trace.WriteLine("That worked to cancel Loading oodle! :D");
                return;
            }

            var oodlePath = settings.GetRED4OodleDll();

            if (File.Exists(settings.GetRED4OodleDll()))
            {
                OodleLoadLib.Load(oodlePath);

                foreach (string path in binkhelpers)
                {
                    switch (path)
                    {
                        case @"Resources\Media\t1.kark":
                            if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "test.exe")))
                            { }
                            else
                            { var q = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "test.exe"), true, false); }
                            break;

                        case @"Resources\Media\t2.kark":
                            if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe")))
                            { }
                            else
                            { var q = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"), true, false); }
                            break;

                        case @"Resources\Media\t3.kark":
                            if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe")))
                            { }
                            else
                            { var q = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"), true, false); }
                            break;

                        case @"Resources\Media\t4.kark":
                            if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll")))
                            { }
                            else
                            { var q = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll"), true, false); }
                            break;

                        case @"Resources\Media\t5.kark":
                            if (File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll")))
                            { }
                            else
                            { var q = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll"), true, false); }
                            break;
                    }
                }
            }
        }

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

        /// <summary>
        /// Initialize webview2
        /// </summary>
        public async static void InitializeWebview2()
        {
            string WebViewData = ISettingsManager.GetWebViewDataPath();
            Directory.CreateDirectory(WebViewData);
            Helpers.Helpers.objCoreWebView2Environment = await CoreWebView2Environment.CreateAsync(null, WebViewData, null);
        }

        // Initialize Github RPC
        public static void InitializeGitHub()
        {
            try
            {
                StaticReferences.Githubclient = new GitHubClient(new ProductHeaderValue("WolvenKit")) { Credentials = Github_Helpers.GhubAuth("wolvenbot", "botwolven1") };
            }
            catch (Exception e)
            {
                StaticReferences.Logger.Error(e);
            }
        }

        // Initialize everything related to Theming.
        public static void InitializeThemeHelper()
        {
            try
            {
                var SettingsManag = ServiceLocator.Default.ResolveType<ISettingsManager>();

                HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
                var themeResources = new HandyControl.Themes.ThemeResources { AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3") };
                var themeSettings = new MaterialDarkThemeSettings
                {
                    PrimaryBackground = new SolidColorBrush(SettingsManag.GetThemeAccent()),
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
            catch (Exception e)
            {
                StaticReferences.Logger.Error(e);
            }
        }

        // Initialize Licenses
        public static void InitializeLicenses()
        {
            try
            {
                Ab3d.Licensing.PowerToys.LicenseHelper.SetLicense(licenseOwner: "WolvenKit", licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense", license: "9E18-4A3E-3951-8E9C-3686-ACE4-685B-6145-5799-42A9-F82C-C195-5495-5907-4F8D-38B7-661D-386C-5461-9B7C-70AE-46DC-F3CA-1B12");
                Ab3d.Licensing.DXEngine.LicenseHelper.SetLicense(licenseOwner: "WolvenKit", licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense", license: "F564-4078-3E78-F218-D27F-B191-4A32-AD76-2002-F1B1-EE27-7B15-5316-4CEA-5281-FF84-5B56-BECD-12CA-F307-E847-E014-7378-032C");
                Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1MDYwQDMxMzkyZTMxMmUzMGNBRjJJdnZoVnJjaklqMTVNL0FNR0JJR3dqR0Fac21YalpQOVEyTkd6bms9");
            }
            catch (Exception e)
            {
                StaticReferences.Logger.Error(e);
            }
        }

        // Initialize Shell
        public static async Task InitializeShell()
        {
            if (!WolvenDBG.EnableTheming)
            {
                ThemeInnerInit();
                await ShellInnerInit();
            }
            else
            {
                await ShellInnerInit();
                ThemeInnerInit();
            }
        }

        // Initialize MVVM (Catel)
        public static void InitializeMVVM()
        {
            try
            {
                var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Media/Images/git.png");

                // Register Viewmodels & Views
                var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
                var viewLocator = ServiceLocator.Default.ResolveType<IViewLocator>();

                viewLocator.NamingConventions.Add("WolvenKit.Views.HomePage.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.HomePage.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.HomePage.Pages.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.HomePage.Pages.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.AudioTool.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.AudioTool.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.AudioTool.Radio.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.AudioTool.Radio.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.VisualEditor.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.VisualEditor.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Dialogs.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Dialogs.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Others.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Others.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Shared.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Shared.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Shell.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Shell.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.BugReportWizard.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.BugReportWizard.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.FeedbackWizard.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.FeedbackWizard.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.FirstSetupWizard.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.ProjectWizard.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.ProjectWizard.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.ProjectWizard.[VM]TypeView");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.ProjectWizard.[VW]TypeViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.PublishWizard.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.PublishWizard.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.UserWizard.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.UserWizard.[VW]ViewModel");

                viewLocator.NamingConventions.Add("WolvenKit.Views.Others.PropertyGridEditors.[VM]View");
                viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Others.PropertyGridEditors.[VW]ViewModel");

               // Fixes
                // Custom Registrations

                viewModelLocator.Register(typeof(MainView), typeof(WorkSpaceViewModel));
                viewModelLocator.Register(typeof(WelcomePageView), typeof(RecentlyUsedItemsViewModel));
                viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.PublishWizard.FinalizeSetupViewModel));

                viewLocator.Register(typeof(ProjectWizardViewModel), typeof(ProjectWizardView));
                viewModelLocator.Register(typeof(Views.Wizards.ProjectWizardView), typeof(ViewModels.Wizards.ProjectWizardViewModel));


            }
            catch (Exception e)
            {
                StaticReferences.Logger.Error(e);
            }
        }

        private static async Task ShellInnerInit()
        {
            try
            {
                HandyControl.Tools.ConfigHelper.Instance.SetLang("en");
                var shellService = ServiceLocator.Default.ResolveType<IShellService>();

                await shellService.CreateAsync<ShellWindow>();
                var sh = (ShellWindow)shellService.Shell;
                sh.TitleTextAlignment = System.Windows.HorizontalAlignment.Right;
                sh.ShowIcon = false;
                sh.Icon = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Media\\Images\\Icons\\Application\\TaskBarIcon.ico"));
                StaticReferences.GlobalShell = sh;
                sh.BringIntoView();
                //sh.MinWidth = 1;
                //sh.MinHeight = 1;
                // sh.WindowState = WindowState.Maximized;
                // sh.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                var ws = new Binding
                {
                    Source = HomePageViewModel.GlobalHomePageVM,
                    Path = new PropertyPath("CurrentWindowState"),
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };
                BindingOperations.SetBinding(sh, ShellWindow.WindowStateProperty, ws);
                sh.Closed += Sh_Closed;

                //StaticReferences.GlobalShell.SetCurrentValue(MahApps.Metro.Controls.MetroWindow.TitleBarHeightProperty, 25);
                //StaticReferences.GlobalShell.SetCurrentValue(Window.TitleProperty, "");
            }
            catch (Exception e)
            {
                StaticReferences.Logger.Error(e);
            }
        }

        private static void Sh_Closed(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                StaticReferences.Logger.Error(ex);
            }
        }

        public static void ThemeInnerInit()
        {
            var SettingsManag = ServiceLocator.Default.ResolveType<ISettingsManager>();

            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(System.Windows.Application.Current,
                ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", SettingsManag.GetThemeAccent(), false));
            MaterialDarkThemeSettings themeSettings = new MaterialDarkThemeSettings
            {
                PrimaryBackground = new SolidColorBrush(SettingsManag.GetThemeAccent()),
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
