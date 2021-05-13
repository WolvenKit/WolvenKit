using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Catel.IoC;
using Catel.Logging;
using Catel.Messaging;
using FFmpeg.AutoGen;
using HandyControl.Tools;
using NodeNetwork;
using Orchestra.Services;
using Unosquare.FFME;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views;
using WolvenKit.Views.ViewModels;

namespace WolvenKit
{
    public partial class App : Application
    {
        // Static ref to RootVM.
        public static RootViewModel ViewModel => Current.Resources[nameof(ViewModel)] as RootViewModel;

        // Static ref to MainWindow.
        public static MainWindow MainX;

        // Determines if the application is in design mode.
        public static bool IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;

        // Get instance of the logger.
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();


        // Constructor #1
        static App() { }

        // Constructor #2
        public App()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
            // Set FFMPEG Properties.
            Library.FFmpegLoadModeFlags = FFmpegLoadMode.FullFeatures;
            Library.EnableWpfMultiThreadedVideo = false;
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
#endif

            Log.Info("Starting application");

            Log.Info("Initializing MVVM");
            await Initializations.InitializeMVVM();

            Log.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();

            Log.Info("Initializing Shell");
            await Initializations.InitializeShell();
            AppHelper.ShowFirstTimeSetup();

            Log.Info("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            Log.Info("Initializing Github API");
            Initializations.InitializeGitHub();

            Log.Info("Calling base.OnStartup");
            base.OnStartup(e); // Some things can only be initialized after base.OnStartup(e);

            Log.Info("Initializing NodeNetwork.");
            NNViewRegistrar.RegisterSplat();

            Log.Info("Initializing Notifications.");
            NotificationHelper.InitializeNotificationHelper();

            Log.Info("Initializing FFME");
            Initializations.InitializeFFME();

            // Temp Fix for MainViewModel.OnClosing
            if (MainWindow != null)
            { MainWindow.Closing += OnClosing; }

            Log.Info("Check for new updates");
            AppHelper.CheckForUpdates();
            Directory.CreateDirectory(@"C:\WebViewData");


            var mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
            mediator.Register<int>(this, onmessage);
            await Task.Run(async () =>
            {
                try
                {
                    // Pre-load FFmpeg
                    await Library.LoadFFmpegAsync();
                }
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

        private void onmessage(int obj)
        {
            if (obj == 0)
            {
                if (MainX == null)
                {
                    MainX = new MainWindow();

                    Current.MainWindow = MainX;
                    Current.MainWindow.Loaded += (snd, eva) => ViewModel.OnApplicationLoaded();
                    Current.MainWindow.SetCurrentValue(UIElement.VisibilityProperty, Visibility.Hidden);

                    Current.MainWindow.Show();
                }


            }
        }

        // TODO: add closing logic here for now since MainViewModel.OnClosing isn't realiable. Investigate this
        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e) => StaticReferences.MainView.OnSaveLayout();
    }
}
