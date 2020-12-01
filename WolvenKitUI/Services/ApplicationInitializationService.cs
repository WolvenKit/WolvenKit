using Catel;
using Catel.IoC;
using Catel.Logging;
using Catel.MVVM;
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
using Settings = WolvenKit.App.Settings;
using WolvenKit.App.Model.ProjectManagement;
using System.Windows.Media;

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
            InitializeFonts();
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

        private void InitializeFonts()
        {
            Orc.Theming.FontImage.RegisterFont("FontAwesome", new FontFamily(new Uri("pack://application:,,,/WolvenKitUI;component/Resources/Fonts/", UriKind.RelativeOrAbsolute), "./#FontAwesome"));
            Orc.Theming.FontImage.DefaultFontFamily = "FontAwesome";
            Orc.Theming.FontImage.DefaultBrush = new SolidColorBrush(Color.FromArgb(255, 87, 87, 87));
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

            _commandManager.CreateCommand(nameof(AppCommands.Application.OpenFile));
            _commandManager.CreateCommand(nameof(AppCommands.Application.NewFile));
            _commandManager.CreateCommand(nameof(AppCommands.Application.PackMod));
            _commandManager.CreateCommand(nameof(AppCommands.Application.BackupMod));

        }

        private void RegisterTypes()
        {



            // project management
            _serviceLocator.RegisterType<IProjectSerializerSelector, ProjectSerializerSelector>();  //TODO: not needed?
            //_serviceLocator.RegisterType<IMainWindowTitleService, MainWindowTitleService>();      //TODO: 
            //_serviceLocator.RegisterType<IProjectValidator, WkitProjectValidator>();
            _serviceLocator.RegisterType<ISaveProjectChangesService, SaveProjectChangesService>();
            _serviceLocator.RegisterType<IInitialProjectLocationService, WolvenKit.App.Model.ProjectManagement.InitialProjectLocationService>();

            _serviceLocator.RegisterType<IProjectInitializer, FileProjectInitializer>();


            _serviceLocator.RegisterTypeAndInstantiate<ProjectManagementCloseApplicationWatcher>();


            // Orchestra
            _serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();


            // Wkit
            _serviceLocator.RegisterType<ILoggerService, LoggerService>();

            var config = SettingsManager.Load();
            _serviceLocator.RegisterInstance(typeof(ISettingsManager), config);
        }

        private void InitializeWatchers()
        {
            _serviceLocator.RegisterTypeAndInstantiate<RecentlyUsedItemsProjectWatcher>();
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
