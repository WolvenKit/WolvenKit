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
using MWindowInterfacesLib.Interfaces;
using MLib.Interfaces;
using MLib;
using WolvenKit.App.ViewModels;

namespace WolvenKitUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region fields
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

            

            // Register Viewmodels
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewModelLocator.NamingConventions.Add("WolvenKit.App.ViewModels.[VW]ViewModel");

            viewModelLocator.Register(typeof(MainView), typeof(WolvenKitUI.ViewModels.WorkSpaceViewModel));
            viewModelLocator.Register(typeof(RibbonView), typeof(RibbonViewModel));


            
            



            var serviceLocator = ServiceLocator.Default;
            var shellService = serviceLocator.ResolveType<IShellService>();
            shellService.CreateAsync<ShellWindow>();

            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red");

            Log.Info("Calling base.OnStartup");

            base.OnStartup(e);
        }

		

		
	}
}