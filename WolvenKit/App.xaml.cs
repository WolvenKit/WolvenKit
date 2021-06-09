using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Catel.IoC;
using Catel.Logging;
using Catel.Messaging;
using FFmpeg.AutoGen;
using HandyControl.Tools;
using NodeNetwork;
using Orchestra.Services;
using Unosquare.FFME;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Initialization;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views;
using WolvenKit.Views.HomePage;
using WolvenKit.Views.ViewModels;

namespace WolvenKit
{
    #region Application
    /// <summary>
    /// Main App
    /// </summary>
    public partial class App : Application
    {
        #region Properties
        /// <summary>
        /// Statice Reference To RootViewModel
        /// </summary>
        public static RootViewModel c_RootViewModel => Current.Resources[nameof(c_RootViewModel)] as RootViewModel;

        /// <summary>
        /// Statice Reference To MainWindow
        /// </summary>
        public static MainWindow c_MainWindow;

        /// <summary>
        /// Statice Bool if Application is in design Mode.
        /// </summary>
        public static bool c_IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;
        #endregion

        #region Application Constructors
        /// <summary>
        /// Application Constructor #1 (Static).
        /// </summary>
        static App() { }

        /// <summary>
        /// Application Constructor #2 (Public).
        /// </summary>
        public App()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
            // Set FFMPEG Properties.
            Library.FFmpegLoadModeFlags = FFmpegLoadMode.FullFeatures;
            Library.EnableWpfMultiThreadedVideo = false;
        }
        #endregion

        #region Events (OnStartup + OnMessage)
        /// <summary>
        /// Application OnStartup Override.
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            // Enable debug or not, this can only be done here in code.
            Helpers.DBG_Enable();







            // Startup speed boosting (HC)
            ApplicationHelper.StartProfileOptimization();

            // Set service locator.
            var serviceLocator = ServiceLocator.Default;
            serviceLocator.RegisterType<IRibbonService, RibbonService>();

#if DEBUG
            LogManager.AddDebugListener(false);
#endif

            StaticReferences.Logger.Info("Starting application");

            StaticReferences.Logger.Info("Initializing MVVM");
            await Initializations.InitializeMVVM();

            StaticReferences.Logger.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();

            StaticReferences.Logger.Info("Initializing Shell");
            await Initializations.InitializeShell();
            Helpers.ShowFirstTimeSetup();

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





            // Create WebView Data Folder.
            Directory.CreateDirectory(@"C:\WebViewData");
            // Message system for video tool.
            var m_mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
            m_mediator.Register<int>(this, onmessage);
            // Init FFMPEG libraries.
            await Task.Run(async () =>
            {
                try{await Library.LoadFFmpegAsync();}
                catch (Exception ex)
                {
                    var dispatcher = Current?.Dispatcher;
                    if (dispatcher != null)
                    {
                        await dispatcher.BeginInvoke(new Action(() =>
                        {
                            MessageBox.Show(MainWindow,
                                $"Unable to Load FFmpeg Libraries from path:\r\n    {Library.FFmpegDirectory}" +
                                $"\r\nMake sure the above folder contains FFmpeg shared binaries (dll files) for the " +
                                $"applicantion's architecture ({(Environment.Is64BitProcess ? "64-bit" : "32-bit")})" +
                                $"\r\nTIP: You can download builds from https://ffmpeg.org/download.html" +
                                $"\r\n{ex.GetType().Name}: {ex.Message}\r\n\r\nApplication will exit.",
                                "FFmpeg Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);

                            Current?.Shutdown();
                        }));
                    }
                }
            });
        }

        /// <summary>
        /// Sets the VideTool as current main window on demand.
        /// </summary>
        /// <param name="obj"></param>
        private void onmessage(int obj)
        {
            if (obj == 0)
            {
                if (c_MainWindow == null)
                {
                    c_MainWindow = new MainWindow();
                    Current.MainWindow = c_MainWindow;
                    Current.MainWindow.Loaded += (snd, eva) => c_RootViewModel.OnApplicationLoaded();
                    Current.MainWindow.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Hidden);
                    Current.MainWindow.Show();
                }
            }
        }
        #endregion
    }
    #endregion
}
