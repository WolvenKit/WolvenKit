using Catel;
using Catel.IoC;
using Catel.Logging;
using Catel.MVVM;
using MLib;
using MLib.Interfaces;
using Orchestra.Models;
using Orchestra.Services;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Catel.Services;
using Orc.ProjectManagement;
using Orc.Squirrel;
using WolvenKit.App;
using WolvenKit.App.Services;
using WolvenKit.Common.Services;
using WolvenKitUI.Model;
using Settings = WolvenKit.App.Settings;

namespace WolvenKitUI.Services
{
    public class ApplicationInitializationService : ApplicationInitializationServiceBase
    {
        #region fields

        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        private readonly IServiceLocator _serviceLocator;
        private readonly ICommandManager _commandManager;
        private readonly IPleaseWaitService _pleaseWaitService;

        public override bool ShowSplashScreen => true;
        public override bool ShowShell => true;

        #endregion

        #region constructors

        public ApplicationInitializationService(IServiceLocator serviceLocator, ICommandManager commandManager,
            IPleaseWaitService pleaseWaitService)
        {
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => pleaseWaitService);

            _serviceLocator = serviceLocator;
            _commandManager = commandManager;
            _pleaseWaitService = pleaseWaitService;
        }

        #endregion

        #region events

        public override async Task InitializeBeforeCreatingShellAsync()
        {
            // Non-async first
            RegisterTypes();
            InitializeCommands();
            InitializeWatchers();

            // async
            await RunAndWaitAsync(new Func<Task>[]
            {
                InitializePerformanceAsync,
                CheckForUpdatesAsync
            });
        }

        public override async Task InitializeAfterCreatingShellAsync()
        {
            // TODO: update main window title?
        }

        public override async Task InitializeAfterShowingShellAsync()
        {
            await base.InitializeAfterShowingShellAsync();

            await LoadProjectAsync();
        }

        #endregion

        #region methods
        private async Task InitializePerformanceAsync()
        {
            Log.Info("Improving performance");

            Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            Catel.Windows.Controls.UserControl.DefaultSkipSearchingForInfoBarMessageControlValue = true;
        }

        private void InitializeCommands()
        {
            // global commands
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Exit));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.About));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Options));

            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.NewProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenProject));

            // application-wide commands that viewmodels can subscribe to
            _commandManager.CreateCommand(nameof(AppCommands.Application.ShowLog));
            _commandManager.CreateCommand(nameof(AppCommands.Application.ShowProjectExplorer));
            _commandManager.CreateCommand(nameof(AppCommands.Application.ShowImportUtility));

        }

        private void RegisterTypes()
        {
            

            // project management
            _serviceLocator.RegisterType<IProjectSerializerSelector, ProjectSerializerSelector>();  //TODO: not needed?
            //_serviceLocator.RegisterType<IMainWindowTitleService, MainWindowTitleService>();      //TODO: 
            //_serviceLocator.RegisterType<IProjectValidator, WkitProjectValidator>();
            _serviceLocator.RegisterType<ISaveProjectChangesService, SaveProjectChangesService>();
            _serviceLocator.RegisterType<IInitialProjectLocationService, Model.InitialProjectLocationService>();

            _serviceLocator.RegisterType<IProjectInitializer, FileProjectInitializer>();


            _serviceLocator.RegisterTypeAndInstantiate<ProjectManagementCloseApplicationWatcher>();


            // Orchestra
            _serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();


            // Wkit
            _serviceLocator.RegisterType<ILoggerService, LoggerService>();
            _serviceLocator.RegisterType<ISettingsManager, SettingsManager>();
        }

        private void InitializeWatchers()
        {
            
        }

        private async Task CheckForUpdatesAsync()
        {
            //TODO: enable
//            Log.Info("Checking for updates");

//            var updateService = _serviceLocator.ResolveType<IUpdateService>();
//            updateService.Initialize(Settings.Application.AutomaticUpdates.AvailableChannels, Settings.Application.AutomaticUpdates.DefaultChannel,
//                Settings.Application.AutomaticUpdates.CheckForUpdatesDefaultValue);

//#pragma warning disable 4014
//            // Not dot await, it's a background thread
//            updateService.InstallAvailableUpdatesAsync(new SquirrelContext());
//#pragma warning restore 4014
        }

        private async Task LoadProjectAsync()
        {
            using (_pleaseWaitService.PushInScope())
            {
                var projectManager = _serviceLocator.ResolveType<IProjectManager>();
                if (projectManager == null)
                {
                    const string error = "Failed to resolve project manager";
                    Log.Error(error);
                    throw new Exception(error);
                }

                await projectManager.InitializeAsync();
            }
        }
        #endregion

    }
}
