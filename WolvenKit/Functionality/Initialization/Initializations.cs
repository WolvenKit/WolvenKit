using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Catel.IoC;
using Catel.Logging;
using Catel.MVVM;
using FFmpeg.AutoGen;
using Microsoft.Web.WebView2.Core;
using Octokit;
using Orc.Squirrel;
using Orchestra.Services;
using Orchestra.Views;
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using Unosquare.FFME;
using WolvenKit.Controls;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Editor.Tools;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Shell;

namespace WolvenKit.Functionality.Initialization
{
    public static class Initializations
    {
        /// <summary>
        /// Initialize FFME Libraries.
        /// </summary>
        public static void InitializeFFME()
        {
            var m_FFmpegDirectory = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "FFME");
            Library.FFmpegDirectory = m_FFmpegDirectory;
            Library.FFmpegLoadModeFlags = FFmpegLoadMode.FullFeatures;
            Library.EnableWpfMultiThreadedVideo = false;
        }

        /// <summary>
        /// Initialize Github "OctoClient".
        /// </summary>
        public static void InitializeGitHub() => StaticReferences.Githubclient = new GitHubClient(new ProductHeaderValue("WolvenKit")) { Credentials = Github_Helpers.GhubAuth("wolvenbot", "botwolven1") };

        /// <summary>
        /// Initialize Licenses.
        /// </summary>
        public static void InitializeLicenses()
        {
            Ab3d.Licensing.PowerToys.LicenseHelper.SetLicense(licenseOwner: "WolvenKit", licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense", license: "9E18-4A3E-3951-8E9C-3686-ACE4-685B-6145-5799-42A9-F82C-C195-5495-5907-4F8D-38B7-661D-386C-5461-9B7C-70AE-46DC-F3CA-1B12");
            Ab3d.Licensing.DXEngine.LicenseHelper.SetLicense(licenseOwner: "WolvenKit", licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense", license: "F564-4078-3E78-F218-D27F-B191-4A32-AD76-2002-F1B1-EE27-7B15-5316-4CEA-5281-FF84-5B56-BECD-12CA-F307-E847-E014-7378-032C");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1MDYwQDMxMzkyZTMxMmUzMGNBRjJJdnZoVnJjaklqMTVNL0FNR0JJR3dqR0Fac21YalpQOVEyTkd6bms9");
        }

        /// <summary>
        /// Initialize CATEL MvvM
        /// </summary>
        /// <returns></returns>
        public static async Task InitializeMVVM()
        {
            var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Media/Images/git.png");

            await SquirrelHelper.HandleSquirrelAutomaticallyAsync();

            // Register Viewmodels & Views
            var m_viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            var m_viewLocator = ServiceLocator.Default.ResolveType<IViewLocator>();

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.HomePage.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.HomePage.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.HomePage.Pages.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.HomePage.Pages.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.AudioTool.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.AudioTool.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.AudioTool.Radio.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.AudioTool.Radio.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Editor.VisualEditor.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Editor.VisualEditor.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Dialogs.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Dialogs.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Others.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Others.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Shared.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Shared.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Shell.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Shell.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.BugReportWizard.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.BugReportWizard.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.FeedbackWizard.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.FeedbackWizard.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.FirstSetupWizard.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.ProjectWizard.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.ProjectWizard.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.ProjectWizard.[VM]TypeView");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.ProjectWizard.[VW]TypeViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.PublishWizard.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.PublishWizard.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Wizards.WizardPages.UserWizard.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Wizards.UserWizard.[VW]ViewModel");

            m_viewLocator.NamingConventions.Add("WolvenKit.Views.Others.PropertyGridEditors.[VM]View");
            m_viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels.Others.PropertyGridEditors.[VW]ViewModel");

            m_viewModelLocator.Register(typeof(MainView), typeof(WorkSpaceViewModel));
            m_viewModelLocator.Register(typeof(RecentProjectView), typeof(RecentlyUsedItemsViewModel));
            m_viewModelLocator.Register(typeof(WelcomePageView), typeof(RecentlyUsedItemsViewModel));
            m_viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.FinalizeSetupView), typeof(ViewModels.Wizards.ProjectWizard.FinalizeSetupViewModel));
            m_viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.PublishWizard.FinalizeSetupViewModel));
            m_viewModelLocator.Register(typeof(AddPathDialogView), typeof(AddPathDialogViewModel));

            // Fixes
            // Custom Registrations

            m_viewModelLocator.Register(typeof(MainView), typeof(WorkSpaceViewModel));
            m_viewModelLocator.Register(typeof(RecentProjectView), typeof(RecentlyUsedItemsViewModel));
            m_viewModelLocator.Register(typeof(WelcomePageView), typeof(RecentlyUsedItemsViewModel));
            m_viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.FinalizeSetupView), typeof(ViewModels.Wizards.ProjectWizard.FinalizeSetupViewModel));
            m_viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.PublishWizard.FinalizeSetupViewModel));
        }

        /// <summary>
        /// Initialize Shell
        /// </summary>
        /// <returns></returns>
        public static async Task InitializeShell()
        {
            await ShellInnerInit();
            ThemeInnerInit();
        }

        /// <summary>
        /// Initialize ThemeHelper
        /// </summary>
        public static void InitializeThemeHelper()
        {
            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            var m_ThemeResources = new HandyControl.Themes.ThemeResources { AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3") };
            var m_ThemeSettings = new MaterialDarkThemeSettings
            {
                PrimaryBackground = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3"),
                BodyFontSize = 11,
                HeaderFontSize = 14,
                SubHeaderFontSize = 13,
                TitleFontSize = 13,
                SubTitleFontSize = 12,
                BodyAltFontSize = 11,
                FontFamily = new FontFamily("Segoe UI")
            };
            SfSkinManager.RegisterThemeSettings("MaterialDark", m_ThemeSettings);
            SfSkinManager.ApplyStylesOnApplication = true;
        }

        /// <summary>
        /// Initialize webview2.
        /// </summary>
        public async static void InitializeWebview2() => Helpers.Helpers.objCoreWebView2Environment = await CoreWebView2Environment.CreateAsync(null, @"C:\WebViewData", null);

        /// <summary>
        /// Theme Inner Innit.
        /// </summary>
        public static void ThemeInnerInit()
        {
            var m_SettingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            MaterialDarkThemeSettings m_ThemeSettings;
            if (m_SettingsManager.ThemeAccent != default)
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(System.Windows.Application.Current,
                    ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", m_SettingsManager.ThemeAccent, false));

                m_ThemeSettings = new MaterialDarkThemeSettings
                {
                    PrimaryBackground = new SolidColorBrush(m_SettingsManager.ThemeAccent),
                    BodyFontSize = 11,
                    HeaderFontSize = 14,
                    SubHeaderFontSize = 13,
                    TitleFontSize = 13,
                    SubTitleFontSize = 12,
                    BodyAltFontSize = 11,
                    FontFamily = new FontFamily("Segoe UI")
                };
            }
            else
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(System.Windows.Application.Current,
                    ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", (Color)ColorConverter.ConvertFromString("#DF2935"), false));

                m_ThemeSettings = new MaterialDarkThemeSettings
                {
                    PrimaryBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DF2935")),
                    BodyFontSize = 11,
                    HeaderFontSize = 14,
                    SubHeaderFontSize = 13,
                    TitleFontSize = 13,
                    SubTitleFontSize = 12,
                    BodyAltFontSize = 11,
                    FontFamily = new FontFamily("Segoe UI")
                };
            }
            SfSkinManager.RegisterThemeSettings("MaterialDark", m_ThemeSettings);
            SfSkinManager.SetTheme(StaticReferences.GlobalShell, new FluentTheme() { ThemeName = "MaterialDark", ShowAcrylicBackground = true });
        }

        /// <summary>
        /// Shell Closed Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Sh_Closed(object sender, EventArgs e) => Environment.Exit(0);

        /// <summary>
        /// Shell Inner Innit
        /// </summary>
        /// <returns></returns>
        private static async Task ShellInnerInit()
        {
            HandyControl.Tools.ConfigHelper.Instance.SetLang("en");
            var m_ShellService = ServiceLocator.Default.ResolveType<IShellService>();

            await m_ShellService.CreateAsync<ShellWindow>();
            var m_Shell = (ShellWindow)m_ShellService.Shell;
            StaticReferences.GlobalShell = m_Shell;
            m_Shell.MinWidth = 1;
            m_Shell.MinHeight = 1;
            m_Shell.WindowState = WindowState.Maximized;
            m_Shell.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            var ws = new Binding
            {
                Source = HomePageViewModel.GlobalHomePageVM,
                Path = new PropertyPath("CurrentWindowState"),
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(m_Shell, ShellWindow.WindowStateProperty, ws);
            m_Shell.Closed += Sh_Closed;
            StaticReferences.GlobalShell.SetCurrentValue(MahApps.Metro.Controls.MetroWindow.TitleBarHeightProperty, 25);
            StaticReferences.GlobalShell.SetCurrentValue(Window.TitleProperty, "");
        }
    }
}
