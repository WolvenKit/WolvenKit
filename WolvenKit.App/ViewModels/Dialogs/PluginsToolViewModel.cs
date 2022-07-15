using System;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Dialogs
{


    public class PluginsToolViewModel : DialogViewModel
    {
        private readonly ILoggerService _logger;
        [Reactive] public IPluginService _pluginService { get; set; }


        public delegate Task ReturnHandler(NewFileViewModel file);
        public ReturnHandler FileHandler;

        public PluginsToolViewModel()
        {
            _logger = Locator.Current.GetService<ILoggerService>();
            _pluginService = Locator.Current.GetService<IPluginService>();

            CancelCommand = ReactiveCommand.Create(() => FileHandler(null));
            SyncCommand = ReactiveCommand.Create(SyncAsync);

            _pluginService.Init();
        }


        [Reactive] public PluginViewModel SelectedPlugin { get; set; }


        public ICommand CancelCommand { get; private set; }

        //public ICommand StartCommand { get; private set; }
        public ICommand SyncCommand { get; private set; }
        public async Task SyncAsync()
        {
            await Task.Delay(1);

            // TODO

            _logger.Info("Check for updates finished");
        }


    }


}
