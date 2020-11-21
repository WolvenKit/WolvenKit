namespace WolvenKit.UI.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Catel;
    using Catel.IoC;
    using Catel.Logging;
    using Catel.MVVM;
    using Orchestra.Models;
    using Orchestra.Services;
    using InputGesture = Catel.Windows.Input.InputGesture;

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

            commandManager.CreateCommandWithGesture(typeof(Commands.Application), nameof(Commands.Application.Exit));
            commandManager.CreateCommandWithGesture(typeof(Commands.Application), nameof(Commands.Application.About));

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

            //throw new Exception("this is a test exception");
        }
    }
}
