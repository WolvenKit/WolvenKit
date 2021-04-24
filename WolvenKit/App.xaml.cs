using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Catel.IoC;
using Catel.Logging;
using Catel.Messaging;
using FFmpeg.AutoGen;
using NodeNetwork;
using Orchestra.Services;
using Syncfusion.SfSkinManager;
using Unosquare.FFME;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views;
using WolvenKit.Views.ViewModels;

namespace WolvenKit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region constructors

        // Main Constructor
        static App()
        {
        }

        // Alternative Constructor
        public App()
        {

            // FreeNonCommercial license for WolvenKit:

            Ab3d.Licensing.PowerToys.LicenseHelper.SetLicense(licenseOwner: "WolvenKit",
                                                  licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense",
                                                  license: "9E18-4A3E-3951-8E9C-3686-ACE4-685B-6145-5799-42A9-F82C-C195-5495-5907-4F8D-38B7-661D-386C-5461-9B7C-70AE-46DC-F3CA-1B12");

            Ab3d.Licensing.DXEngine.LicenseHelper.SetLicense(licenseOwner: "WolvenKit",
                                                             licenseType: "FreeNonCommercialLicense-TeamDeveloperLicense",
                                                             license: "F564-4078-3E78-F218-D27F-B191-4A32-AD76-2002-F1B1-EE27-7B15-5316-4CEA-5281-FF84-5B56-BECD-12CA-F307-E847-E014-7378-032C");

            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM1MDYwQDMxMzkyZTMxMmUzMGNBRjJJdnZoVnJjaklqMTVNL0FNR0JJR3dqR0Fac21YalpQOVEyTkd6bms9");





            // Change the default location of the ffmpeg binaries (same directory as application)
            // You can get the 64-bit binaries here: https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-full-shared.7z
            // Library.FFmpegDirectory = @"c:\ffmpeg";

            // You can pick which FFmpeg binaries are loaded. See issue #28
            // For more specific control (issue #414) you can set Library.FFmpegLoadModeFlags to:
            // FFmpegLoadMode.LibraryFlags["avcodec"] | FFmpegLoadMode.LibraryFlags["avfilter"] | ... etc.
            // Full Features is already the default.
            Library.FFmpegLoadModeFlags = FFmpegLoadMode.FullFeatures;

            // Multi-threaded video enables the creation of independent
            // dispatcher threads to render video frames. This is an experimental feature
            // and might become deprecated in the future as no real performance enhancements
            // have been detected.
            Library.EnableWpfMultiThreadedVideo = false; // !System.Diagnostics.Debugger.IsAttached; // test with true and false
        }
        public static RootViewModel ViewModel => Current.Resources[nameof(ViewModel)] as RootViewModel;
        public static string GetCaptureFilePath(string mediaPrefix, string extension)
        {
            var date = DateTime.UtcNow;
            var dateString = $"{date.Year:0000}-{date.Month:00}-{date.Day:00} {date.Hour:00}-{date.Minute:00}-{date.Second:00}.{date.Millisecond:000}";
            var targetFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                "ffmeplay");

            if (Directory.Exists(targetFolder) == false)
                Directory.CreateDirectory(targetFolder);

            var targetFilePath = Path.Combine(targetFolder, $"{mediaPrefix} {dateString}.{extension}");
            if (File.Exists(targetFilePath))
                File.Delete(targetFilePath);

            return targetFilePath;
        }
        /// <summary>
        /// Determines if the Application is in design mode.
        /// </summary>
        public static bool IsInDesignMode => !(Current is App) ||
            (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;
        #endregion constructors

        // Get Logger.
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();
        public static MainWindow MainX;
        protected override async void OnStartup(StartupEventArgs e)
        {
            var serviceLocator = ServiceLocator.Default;
            //ShellService.GivenPoop = new StartupViewer();

            serviceLocator.RegisterType<IRibbonService, RibbonService>();

#if DEBUG
            LogManager.AddDebugListener(false);
#endif
            Log.Info("Starting application");
            Log.Info("Initializing MVVM");
            await AppHelper.InitializeMVVM();
            Log.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();
            Log.Info("Initializing Shell");
            await AppHelper.InitializeShell();
            AppHelper.ShowFirstTimeSetup();
            Log.Info("Initializing Discord RPC");
            DiscordHelper.InitializeDiscordRPC();
            Log.Info("Initializing Github");
            Initializations.InitializeGitHub();
            Log.Info("Calling base.OnStartup");
            base.OnStartup(e);
            Log.Info("Initializing NodeNetwork");
            NNViewRegistrar.RegisterSplat();

            NotificationHelper.InitializeNotificationHelper();

            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            Unosquare.FFME.Library.FFmpegDirectory = path + "FFME";
            Library.FFmpegLoadModeFlags = FFmpegLoadMode.FullFeatures;
            Library.EnableWpfMultiThreadedVideo = false; // !
            // Temp Fix for MainViewModel.OnClosing
            if (MainWindow != null)
            {
                MainWindow.Closing += OnClosing;
            }


            SfSkinManager.ApplyStylesOnApplication = true;

            Log.Info("Check for new updates");
            AppHelper.CheckForUpdates();
            Directory.CreateDirectory(@"C:\WolvenKitData");

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
