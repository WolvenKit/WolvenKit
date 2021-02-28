using Catel.IoC;
using Catel.Logging;
using Catel.Reflection;
using Catel.Windows;
using Orc.Squirrel;
using Orchestra.Services;
using Orchestra.Views;
using System.Windows;
using WolvenKit.Views;
using Catel.MVVM;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using WolvenKit.ViewModels;
using WolvenKit.Views.Dialogs;
using NodeNetwork;
using System.Windows.Media;
using MLib.Interfaces;
using HandyControl.Controls.SplashWindow;
using System.Windows.Media.Imaging;
using ControlzEx.Theming;
using System.Windows.Media.Effects;
using Fluent;
using MahApps.Metro.Controls.Dialogs;
using WolvenKit.WKitGlobal;

namespace WolvenKit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region fields
        #endregion fields

        #region constructors
        // Main Constructor
        static App()
        {

        }

        // Alternative Constructor
        public App()
        {

        }
        #endregion constructors

        // Get Logger.
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();



        protected override async void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif
            Log.Info("Starting application");
            Log.Info("Initializing MVVM");
            await AppHelper.InitializeMVVM();
            Log.Info("Initializing Theme Helper");
            ThemeHelper.InitializeThemeHelper();
            Log.Info("Initializing Shell");
            await AppHelper.InitializeShell();
            AppHelper.ShowFirstTimeSetup();
            Log.Info("Initializing Discord RPC");
            DiscordHelper.InitializeDiscordRPC();
            Log.Info("Calling base.OnStartup");
            base.OnStartup(e);
            Log.Info("Initializing NodeNetwork");
            NNViewRegistrar.RegisterSplat();
            NotificationHelper.InitializeNotificationHelper();



            // Temp Fix for MainViewModel.OnClosing
            if (MainWindow != null)
            {
                MainWindow.Closing += OnClosing;
            }

        }

        // TODO: add closing logic here for now since MainViewModel.OnClosing isn't realiable. Investigate this
        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e) => AppHelper.MainView.OnSaveLayout();
    }
}
