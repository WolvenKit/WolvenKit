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
using WolvenKit.App;
using WolvenKit.App.Services;
using WolvenKit.Common.Services;
using InputGesture = Catel.Windows.Input.InputGesture;

namespace WolvenKitUI.Services
{
    public class ApplicationInitializationService : ApplicationInitializationServiceBase
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        private readonly IServiceLocator _serviceLocator;

        public override bool ShowSplashScreen => true;

        public override bool ShowShell => true;

        public ApplicationInitializationService(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            _serviceLocator = serviceLocator;
        }

        public override async Task InitializeBeforeCreatingShellAsync()
        {
            // Non-async first
            await RegisterTypesAsync();
            await InitializeCommandsAsync();

            await RunAndWaitAsync(new Func<Task>[]
            {
                InitializePerformanceAsync
            });
        }

        private async Task InitializeCommandsAsync()
        {
            var commandManager = ServiceLocator.Default.ResolveType<ICommandManager>();

            // global commands
            commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Exit));
            commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.About));
            commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Options));

            commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.NewProject));
            commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenProject));

            // application-wide commands that viewmodels can subscribe to
            commandManager.CreateCommand(nameof(AppCommands.Application.ShowLog));
            commandManager.CreateCommand(nameof(AppCommands.Application.ShowProjectExplorer));
            commandManager.CreateCommand(nameof(AppCommands.Application.ShowImportUtility));



            var keyboardMappingsService = _serviceLocator.ResolveType<IKeyboardMappingsService>();
            keyboardMappingsService.AdditionalKeyboardMappings.Add(new KeyboardMapping("MyGroup.Zoom", "Mousewheel", ModifierKeys.Control));
        }

        public override async Task InitializeAfterCreatingShellAsync()
        {
            Log.Info("Delay to show the splash screen");

            Thread.Sleep(2500);
        }

        private async Task InitializePerformanceAsync()
        {
            Log.Info("Improving performance");

            Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            Catel.Windows.Controls.UserControl.DefaultSkipSearchingForInfoBarMessageControlValue = true;
        }

        private async Task RegisterTypesAsync()
        {
            var serviceLocator = _serviceLocator;

            serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();
            serviceLocator.RegisterType<ILoggerService, LoggerService>();


            serviceLocator.RegisterType<ISettingsManager, SettingsManager>();
            
        }
    }
}
