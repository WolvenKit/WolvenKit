using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Catel.IoC;
using Catel.MVVM;
using FFmpeg.AutoGen;
using Octokit;
using Orc.Squirrel;
using Orchestra.Services;
using Orchestra.Views;
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
using Unosquare.FFME;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Shell;

namespace WolvenKit.Functionality.Initialization
{
    public static class Initializations
    {

        // Initialize Github RPC
        public static async void InitializeGitHub()
        {
            GithubHelper.GhubClient = new GitHubClient(new ProductHeaderValue("WolvenKit")) { Credentials = GithubHelper.GhubAuth("wolvenbot", "botwolven1") };
            await GithubHelper.GhubLastReleaseAsync();
        }


        // Initialize everything related to Theming.
        public static void InitializeThemeHelper()
        {
            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            var tr = new HandyControl.Themes.ThemeResources { AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3") };

            MaterialDarkThemeSettings themeSettings = new MaterialDarkThemeSettings();
            themeSettings.PrimaryBackground = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3");
            themeSettings.BodyFontSize = 11;
            themeSettings.HeaderFontSize = 14;
            themeSettings.SubHeaderFontSize = 13;
            themeSettings.TitleFontSize = 13;
            themeSettings.SubTitleFontSize = 12;
            themeSettings.BodyAltFontSize = 11;
            themeSettings.FontFamily = new FontFamily("Segoe UI");
            SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
            SfSkinManager.ApplyStylesOnApplication = true;

        }

        // Initialize FFME
        public static void InitializeFFME()
        {

            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            Unosquare.FFME.Library.FFmpegDirectory = path + "FFME";
            Library.FFmpegLoadModeFlags = FFmpegLoadMode.FullFeatures;
            Library.EnableWpfMultiThreadedVideo = false; // !

        }

        // Initialize Licenses
        public static void InitializeLicenses()
        {            //ShellService.GivenPoop = new StartupViewer();

            // FreeNonCommercial license for WolvenKit:
            Ab3d.Licensing.PowerToys.LicenseHelper.SetLicense(licenseOwner: "WolvenKit",
                                                  licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense",
                                                  license: "9E18-4A3E-3951-8E9C-3686-ACE4-685B-6145-5799-42A9-F82C-C195-5495-5907-4F8D-38B7-661D-386C-5461-9B7C-70AE-46DC-F3CA-1B12");
            Ab3d.Licensing.DXEngine.LicenseHelper.SetLicense(licenseOwner: "WolvenKit",
                                                             licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense",
                                                             license: "F564-4078-3E78-F218-D27F-B191-4A32-AD76-2002-F1B1-EE27-7B15-5316-4CEA-5281-FF84-5B56-BECD-12CA-F307-E847-E014-7378-032C");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1MDYwQDMxMzkyZTMxMmUzMGNBRjJJdnZoVnJjaklqMTVNL0FNR0JJR3dqR0Fac21YalpQOVEyTkd6bms9");

        }

        // Initialize Shell
        public static async Task InitializeShell()
        {
            await ShellInnerInit();
            ThemeInnerInit();
        }

        // Initialize MVVM (Catel)
        public static async Task InitializeMVVM()
        {

            var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Media/Images/git.png");

            await SquirrelHelper.HandleSquirrelAutomaticallyAsync();

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
            viewModelLocator.Register(typeof(RecentProjectView), typeof(RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(WelcomePageView), typeof(RecentlyUsedItemsViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.FinalizeSetupView), typeof(ViewModels.Wizards.ProjectWizard.FinalizeSetupViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.PublishWizard.FinalizeSetupViewModel));
        }






        private static async Task ShellInnerInit()
        {
            HandyControl.Tools.ConfigHelper.Instance.SetLang("en");
            var shellService = ServiceLocator.Default.ResolveType<IShellService>();

            await shellService.CreateAsync<ShellWindow>();
            var sh = (ShellWindow)shellService.Shell;
            StaticReferences.GlobalShell = sh;
            sh.MinWidth = 1;
            sh.MinHeight = 1;

            sh.WindowState = WindowState.Maximized;
            sh.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Binding ws = new Binding();
            ws.Source = HomePageViewModel.GlobalHomePageVM;
            ws.Path = new PropertyPath("CurrentWindowState");
            ws.Mode = BindingMode.TwoWay;
            ws.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(sh, ShellWindow.WindowStateProperty, ws);
            sh.Closed += Sh_Closed;

            StaticReferences.GlobalShell.SetCurrentValue(MahApps.Metro.Controls.MetroWindow.TitleBarHeightProperty, 25);
            StaticReferences.GlobalShell.SetCurrentValue(Window.TitleProperty, "");
        }

        private static void Sh_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }







        public static void ThemeInnerInit()
        {
            var SettingsManag = ServiceLocator.Default.ResolveType<ISettingsManager>();
            if (SettingsManag.ThemeAccent != default)
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(System.Windows.Application.Current,
                    ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark",
                        SettingsManag.ThemeAccent, false));


                MaterialDarkThemeSettings themeSettings = new MaterialDarkThemeSettings();
                themeSettings.PrimaryBackground = new SolidColorBrush(SettingsManag.ThemeAccent);
                themeSettings.BodyFontSize = 11;
                themeSettings.HeaderFontSize = 14;
                themeSettings.SubHeaderFontSize = 13;
                themeSettings.TitleFontSize = 13;
                themeSettings.SubTitleFontSize = 12;
                themeSettings.BodyAltFontSize = 11;
                themeSettings.FontFamily = new FontFamily("Segoe UI");
                SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);
                SfSkinManager.SetTheme(StaticReferences.GlobalShell, new FluentTheme() { ThemeName = "MaterialDark", ShowAcrylicBackground = true });


            }
            else
            {
                ControlzEx.Theming.ThemeManager.Current.ChangeTheme(System.Windows.Application.Current,
                    ControlzEx.Theming.RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark",
                        (Color)ColorConverter.ConvertFromString("#DF2935"), false));

                MaterialDarkThemeSettings themeSettings = new MaterialDarkThemeSettings();
                themeSettings.PrimaryBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DF2935"));
                themeSettings.BodyFontSize = 11;
                themeSettings.HeaderFontSize = 14;
                themeSettings.SubHeaderFontSize = 13;
                themeSettings.TitleFontSize = 13;
                themeSettings.SubTitleFontSize = 12;
                themeSettings.BodyAltFontSize = 11;
                themeSettings.FontFamily = new FontFamily("Segoe UI");
                SfSkinManager.RegisterThemeSettings("MaterialDark", themeSettings);

                SfSkinManager.SetTheme(StaticReferences.GlobalShell, new FluentTheme() { ThemeName = "MaterialDark", ShowAcrylicBackground = true });
            }
        }

    }
}
