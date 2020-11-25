using Catel.IoC;
using Catel.Logging;
using Catel.Reflection;
using Catel.Windows;
using Orchestra.Services;
using Orchestra.Views;
using System.Windows;
using WolvenKitUI.Views;
using Catel.MVVM;
using WolvenKitUI.ViewModels;
using MLibTest.Models;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using WolvenKitUI.Models;
using Settings.UserProfile;
using Settings.Interfaces;
using MWindowInterfacesLib.Interfaces;
using MLib.Interfaces;
using MLib;
using Settings;

namespace WolvenKitUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region fields
        private readonly AppViewModel _appVM;
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
            _appVM = new AppViewModel(new AppLifeCycleViewModel());
            LayoutLoaded = new LayoutLoader(@".\AvalonDock.Layout.config");
        }
        #endregion constructors

        /// <summary>
		/// Gets an object that loads the AvalonDock Xml layout string
		/// in an aysnchronous background task.
		/// </summary>
		internal LayoutLoader LayoutLoaded { get; set; }

        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        protected override void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif

            Log.Info("Starting application");

            // Want to improve performance? Uncomment the lines below. Note though that this will disable
            // some features. 
            //
            // For more information, see http://docs.catelproject.com/vnext/faq/performance-considerations/

            // Log.Info("Improving performance");
            // Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            // Catel.Windows.Controls.UserControl.DefaultSkipSearchingForInfoBarMessageControlValue = true;

            // TODO: Register custom types in the ServiceLocator
            //Log.Info("Registering custom types");
            //var serviceLocator = ServiceLocator.Default;
            //serviceLocator.RegisterType<IMyInterface, IMyClass>();

            // To auto-forward styles, check out Orchestra (see https://github.com/wildgums/orchestra)
            // StyleHelper.CreateStyleForwardersForDefaultStyles();
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewModelLocator.NamingConventions.Add("WolvenKit.App.ViewModels.[VW]ViewModel");

            //viewModelLocator.Register(typeof(MainView), typeof(WolvenKit.App.ViewModels.MainViewModel));
            viewModelLocator.Register(typeof(RibbonView), typeof(WolvenKit.App.ViewModels.MainViewModel));
            viewModelLocator.Register(typeof(StatusBarView), typeof(WolvenKit.App.ViewModels.StatusBarViewModel));


            var serviceLocator = ServiceLocator.Default;
            

            var appearanceinstance = AppearanceManager.GetInstance();
            var settingsinstance = SettingsManager.GetInstance(appearanceinstance.CreateThemeInfos());

            serviceLocator.RegisterInstance(typeof(ISettingsManager), settingsinstance);
            serviceLocator.RegisterInstance(typeof(IAppearanceManager), appearanceinstance);






            var settings = serviceLocator.ResolveType<ISettingsManager>(); // add the default themes
            var appearance = serviceLocator.ResolveType<IAppearanceManager>();









            var shellService = serviceLocator.ResolveType<IShellService>();
            shellService.CreateAsync<ShellWindow>();







            














			Log.Info("Calling base.OnStartup");

            base.OnStartup(e);
        }

		

		
	}
}