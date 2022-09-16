using System;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.ViewModels.Shell
{
    public class MenuBarViewModel : ReactiveObject
    {
        private readonly IProgressService<double> _progressService;
        private readonly IArchiveManager _archiveManager;
        private readonly IModTools _modTools;



        public MenuBarViewModel(
            ISettingsManager settingsManager,
            IProgressService<double> progressService,
            IArchiveManager archiveManager,
            IModTools modTools,
            AppViewModel appViewModel)
        {
            MainViewModel = appViewModel;
            _archiveManager = archiveManager;
            _progressService = progressService;
            _modTools = modTools;
            SettingsManager = settingsManager;

            OpenMaterialRepositoryCommand = ReactiveCommand.Create(() => Commonfunctions.ShowFolderInExplorer(SettingsManager.MaterialRepositoryPath));

            UnbundleGameCommand = ReactiveCommand.CreateFromTask(UnbundleGame);
        }

        public ISettingsManager SettingsManager { get; }
        public AppViewModel MainViewModel { get; }

        public ReactiveCommand<Unit, Unit> OpenMaterialRepositoryCommand { get; }
        public ReactiveCommand<Unit, Unit> UnbundleGameCommand { get; }

        private async Task UnbundleGame()
        {
            var depotPath = new DirectoryInfo(SettingsManager.MaterialRepositoryPath);
            if (depotPath.Exists)
            {
                await Task.Run(() =>
                {
                    var archives = _archiveManager.Archives.KeyValues.Select(x => x.Value).ToList();

                    var total = archives.Count;
                    var progress = 0;
                    _progressService.Report(0);

                    for (var i = 0; i < archives.Count; i++)
                    {
                        var archive = archives[i];
                        _modTools.ExtractAll(archive as Archive, depotPath);

                        progress++;
                        _progressService.Report(i / (float)total);
                    }
                    _progressService.Report(1.0);
                });
            }
        }
    }
}
