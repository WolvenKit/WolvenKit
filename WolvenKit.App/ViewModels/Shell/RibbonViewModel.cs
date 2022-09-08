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
using WolvenKit.RED4.Archive;

namespace WolvenKit.ViewModels.Shell
{ // #MVVM
    // #SortNameSpace
    public class RibbonViewModel : ReactiveObject
    {
        #region fields

        private readonly IProgressService<double> _progressService;
        private readonly IArchiveManager _archiveManager;
        private readonly IModTools _modTools;
        public ISettingsManager SettingsManager { get; }
        public AppViewModel MainViewModel { get; }

        #endregion fields

        #region constructors

        public RibbonViewModel(
            ISettingsManager settingsManager,
            IProgressService<double> progressService,
            IArchiveManager archiveManager,
            IModTools modTools,
            AppViewModel appViewModel
        )
        {
            MainViewModel = appViewModel;

            _archiveManager = archiveManager;
            _progressService = progressService;
            _modTools = modTools;
            SettingsManager = settingsManager;

            //ViewSelectedCommand = new DelegateCommand<object>(ExecuteViewSelected, CanViewSelected);
            //AssetBrowserAddCommand = new RelayCommand(ExecuteAssetBrowserAdd, CanAssetBrowserAdd);
            //AssetBrowserOpenFileLocation = new RelayCommand(ExecuteAssetBrowserOpenFileLocation, CanAssetBrowserOpenFileLocation);

            OpenProjectCommand = ReactiveCommand.Create<string>(s => MainViewModel.OpenProjectCommand.Execute(s).Subscribe());
            //NewProjectCommand = ReactiveCommand.Create(() => _mainViewModel.NewProjectCommand.Execute().Subscribe());
            PackProjectCommand = ReactiveCommand.Create(() => MainViewModel.PackModCommand.SafeExecute());
            PackInstallProjectCommand = ReactiveCommand.Create(() => MainViewModel.PackInstallModCommand.SafeExecute());

            NewFileCommand = ReactiveCommand.Create(() => MainViewModel.NewFileCommand.SafeExecute(null));
            SaveFileCommand = ReactiveCommand.Create(() => MainViewModel.SaveFileCommand.SafeExecute());
            SaveAsCommand = ReactiveCommand.Create(() => MainViewModel.SaveAsCommand.SafeExecute());
            SaveAllCommand = ReactiveCommand.Create(() => MainViewModel.SaveAllCommand.SafeExecute());

            ViewProjectExplorerCommand = ReactiveCommand.Create(() => MainViewModel.ShowProjectExplorerCommand.SafeExecute());
            ViewAssetBrowserCommand = ReactiveCommand.Create(() => MainViewModel.ShowAssetsCommand.SafeExecute());
            ViewPropertiesCommand = ReactiveCommand.Create(() => MainViewModel.ShowPropertiesCommand.SafeExecute());
            ViewLogCommand = ReactiveCommand.Create(() => MainViewModel.ShowLogCommand.SafeExecute());
            //ViewCodeEditorCommand = ReactiveCommand.Create(() => _mainViewModel.ShowCodeEditorCommand.SafeExecute());
            ShowImportExportToolCommand = ReactiveCommand.Create(() => MainViewModel.ShowImportExportToolCommand.SafeExecute());

            ShowSoundModdingToolCommand = ReactiveCommand.Create(() => MainViewModel.ShowSoundModdingToolCommand.SafeExecute());
            ShowModsViewCommand = ReactiveCommand.Create(() => MainViewModel.ShowModsViewCommand.SafeExecute());

            ShowPluginToolCommand = ReactiveCommand.Create(() => MainViewModel.ShowPluginCommand.SafeExecute());
            OpenMaterialRepositoryCommand = ReactiveCommand.Create(() => Commonfunctions.ShowFolderInExplorer(SettingsManager.MaterialRepositoryPath));

            UnbundleGameCommand = ReactiveCommand.CreateFromTask(UnbundleGame);


        }

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

        #endregion constructors

        #region commands

        public ReactiveCommand<string, Unit> OpenProjectCommand { get; }
        //public ReactiveCommand<Unit, Unit> NewProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> PackProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> PackInstallProjectCommand { get; }

        public ReactiveCommand<Unit, Unit> NewFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAsCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAllCommand { get; }

        public ReactiveCommand<Unit, Unit> ViewProjectExplorerCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewAssetBrowserCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewPropertiesCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewLogCommand { get; }
        public ReactiveCommand<Unit, Unit> ViewCodeEditorCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowImportExportToolCommand { get; }

        public ReactiveCommand<Unit, Unit> ShowPluginToolCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowSoundModdingToolCommand { get; }

        public ReactiveCommand<Unit, Unit> ShowModsViewCommand { get; }

        public ReactiveCommand<Unit, Unit> OpenMaterialRepositoryCommand { get; }
        public ReactiveCommand<Unit, Unit> UnbundleGameCommand { get; }

        #endregion

        #region properties

        #endregion properties

    }
}
