using System;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Catel.IoC;
using Catel.Logging;
using Catel.Messaging;
using HandyControl.Tools;
using NodeNetwork;
using Orchestra.Services;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Initialization;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views;

namespace WolvenKit
{
    public partial class App : Application
    {
        // Determines if the application is in design mode.
        public static bool IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;

        // Constructor #1
        static App() { }

        // Constructor #2
        public App()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
        }

        // Application OnStartup Override.
        protected override async void OnStartup(StartupEventArgs e)
        {
            // Startup speed boosting (HC)
            ApplicationHelper.StartProfileOptimization();

            // Set service locator.
            var serviceLocator = ServiceLocator.Default;

            serviceLocator.RegisterType<IRibbonService, RibbonService>();

#if DEBUG
            LogManager.AddDebugListener(false);
            VMHelpers.InDebug = true;
#endif

            StaticReferences.Logger.Info("Starting application");

            Initializations.InitializeWebview2();

            StaticReferences.Logger.Info("Initializing MVVM");
            await Initializations.InitializeMVVM();

            StaticReferences.Logger.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();

            StaticReferences.Logger.Info("Initializing Shell");
            await Initializations.InitializeShell();
            var growl = ServiceLocator.Default.ResolveType<IGrowlNotificationService>();
            var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            Helpers.ShowFirstTimeSetup(settings, growl);

            StaticReferences.Logger.Info("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            StaticReferences.Logger.Info("Initializing Github API");
            Initializations.InitializeGitHub();

            StaticReferences.Logger.Info("Calling base.OnStartup");
            base.OnStartup(e); // Some things can only be initialized after base.OnStartup(e);

            StaticReferences.Logger.Info("Initializing NodeNetwork.");
            NNViewRegistrar.RegisterSplat();

            StaticReferences.Logger.Info("Initializing Notifications.");
            NotificationHelper.InitializeNotificationHelper();

            StaticReferences.Logger.Info("Initializing FFME");
            Initializations.InitializeFFME();

            StaticReferences.Logger.Info("Check for new updates");
            Helpers.CheckForUpdates();

            //Window window = new Window();
            //window.AllowsTransparency = true;
            //window.Background = new SolidColorBrush(Colors.Transparent);
            //window.Content = new HomePageView();
            //window.WindowStyle = WindowStyle.None;
            //window.Show();

            // Create WebView Data Folder.
            //Directory.CreateDirectory(@"C:\WebViewData");
            // Message system for video tool.

            // Init FFMPEG libraries.
            if (ApplicationHelper.IsConnectedToInternet())
            {

                if (!File.Exists(@"Resources\Media\test.exe"))
                {
                    try
                    {
                        var uri = new Uri("https://filebin.net/9nrr98uwas3k1auo/binkpl64.exe");
                        var client = new HttpClient();
                        var response = await client.GetAsync(uri);
                        using var fs = new FileStream(@"Resources\Media\test.exe",
                            FileMode.CreateNew);
                        await response.Content.CopyToAsync(fs);

                        if (File.Exists(@"Resources\Media\test.exe"))
                        {
                            StaticReferences.AllowVideoPreview = true;
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    StaticReferences.AllowVideoPreview = true;
                }
            }
            else
            {
                StaticReferences.AllowVideoPreview = false;
            }
        }
    }
}
