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
        public static AppHelper apphelper;
        public static DiscordHelper discordhelper;
        public static GithubHelper GithubHelper;
        public static ThemeHelper themehelper;

        #endregion fields

        #region constructors
        static App()
        {


         



        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public App()
        {

        }
        #endregion constructors



        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        protected override async void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif
            Log.Info("Starting application");
            apphelper = new WKitGlobal.AppHelper();
            discordhelper = new DiscordHelper();
            GithubHelper = new GithubHelper();
            themehelper = new ThemeHelper();

            await apphelper.InitializeMVVM();
            await apphelper.InitializeShell();
            discordhelper.InitDiscordRPC();  



            Log.Info("Calling base.OnStartup");




            base.OnStartup(e); 
            NNViewRegistrar.RegisterSplat();


        }



        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        } 
    }
}