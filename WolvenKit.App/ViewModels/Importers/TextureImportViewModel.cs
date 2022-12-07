using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Importers;
public class TextureImportViewModel : DialogViewModel
{
    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;
    private readonly ISettingsManager _settingsManager;
    private readonly IWatcherService _watcherService;
    private readonly IProgressService<double> _progressService;
    private readonly IProjectManager _projectManager;
    private readonly IGameControllerFactory _gameController;
    private readonly IArchiveManager _archiveManager;
    private readonly IPluginService _pluginService;
    private readonly IModTools _modTools;

    public TextureImportViewModel(
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IWatcherService watcherService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        INotificationService notificationService,
        IArchiveManager archiveManager,
        IPluginService pluginService,
        IModTools modTools,
        IProgressService<double> progressService)
    {
        _gameController = gameController;
        _settingsManager = settingsManager;
        _watcherService = watcherService;
        _loggerService = loggerService;
        _projectManager = projectManager;
        _notificationService = notificationService;
        _archiveManager = archiveManager;
        _pluginService = pluginService;
        _modTools = modTools;
        _progressService = progressService;

        ProcessAllCommand = ReactiveCommand.CreateFromTask(ExecuteProcessAll);
        ProcessSelectedCommand = ReactiveCommand.CreateFromTask(ExecuteProcessSelected);
    }

    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }
    public override ReactiveCommand<Unit, Unit> OkCommand { get; }

    /// <summary>
    /// Selected object , returns a Importable/Exportable ItemVM based on "IsImportsSelected"
    /// </summary>
    [Reactive] public ImportExportItemViewModel SelectedObject { get; set; }

    [Reactive] public ReadOnlyObservableCollection<ImportableItemViewModel> ImportableItems { get; set; }




    [Reactive] public bool IsProcessing { get; set; } = false;




    /// <summary>
    /// Process all in Import / Export Grid Command.
    /// </summary>
    public ReactiveCommand<Unit, Unit> ProcessAllCommand { get; private set; }
    /// <summary>
    /// Process selected in Import / Export Grid Command
    /// </summary>
    public ICommand ProcessSelectedCommand { get; private set; }


    /// <summary>
    /// Helper Task to Execute Bulk Processing in Import / Export Grid Command
    /// 
    /// </summary>
    private async Task ExecuteProcessBulk(bool all = false)
    {
        IsProcessing = true;
        _watcherService.IsSuspended = true;
        var progress = 0;
        _progressService.Report(0);

        var total = 0;
        var sucessful = 0;

        //prepare a list of failed items
        var failedItems = new List<string>();

        //if (IsImportsSelected)
        {
            var toBeImported = ImportableItems.Where(_ => all || _.IsChecked).Where(x => !x.Extension.Equals(ERawFileFormat.wav.ToString())).ToList();
            total = toBeImported.Count;
            foreach (var item in toBeImported)
            {
                if (await Task.Run(() => ImportSingleTask(item)))
                {
                    sucessful++;
                }
                else // not successful
                {
                    failedItems.Add(item.FullName);
                }

                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)total);
            }

            await ImportWavs(ImportableItems.Where(_ => all || _.IsChecked)
                .Where(x => x.Extension.Equals(ERawFileFormat.wav.ToString()))
                .Select(x => x.FullName)
                .ToList()
                );
        }

        //if (IsExportsSelected)
        //{
        //    var toBeExported = ExportableItems.Where(_ => all || _.IsChecked).ToList();
        //    total = toBeExported.Count;
        //    foreach (var item in toBeExported)
        //    {
        //        if (await Task.Run(() => ExportSingle(item)))
        //        {
        //            sucessful++;
        //        }
        //        else
        //        {
        //            failedItems.Add(item.FullName);
        //        }

        //        Interlocked.Increment(ref progress);
        //        _progressService.Report(progress / (float)total);
        //    }
        //}

        IsProcessing = false;

        _watcherService.IsSuspended = false;
        await _watcherService.RefreshAsync(_projectManager.ActiveProject);
        _progressService.IsIndeterminate = false;

        _notificationService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");
        _loggerService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");

        //We format the list of failed export/import items here
        if (failedItems.Count > 0)
        {
            var failedItemsErrorString = $"The following items failed:\n{string.Join("\n", failedItems)}";
            _notificationService.Error(failedItemsErrorString); //notify once only 
            _loggerService.Error(failedItemsErrorString);
        }

        _progressService.Completed();
    }

    /// <summary>
    /// Execute Process all in Import / Export Grid Command.
    /// Uses ExecuteProcessBulk
    /// </summary>
    private async Task ExecuteProcessAll() => await ExecuteProcessBulk(true); //the all parameter is set to true

    /// <summary>
    /// Execute Process Selected in Import / Export Grid Command.
    /// Uses ExecuteProcessBulk
    /// </summary>
    private async Task ExecuteProcessSelected() => await ExecuteProcessBulk(); //the all parameter's default is false

    private Task<bool> ImportWavs(List<string> wavs)
    {
        var proj = _projectManager.ActiveProject;
        if (_gameController.GetController() is RED4Controller cp77Controller)
        {
            OpusTools opusTools = new(
                proj.ModDirectory,
                proj.RawDirectory,
                true);

            return Task.Run(() => opusTools.ImportWavs(wavs.ToArray()));
        }

        return Task.FromResult(false);
    }

    /// <summary>
    /// Import Single item
    /// </summary>
    /// <param name="item"></param>
    private async Task<bool> ImportSingleTask(ImportableItemViewModel item)
    {
        if (_gameController.GetController() is not RED4Controller)
        {
            return false;
        }

        var proj = _projectManager.ActiveProject;
        var fi = new FileInfo(item.FullName);
        if (fi.Exists)
        {
            if (item.Properties is GltfImportArgs gltfImportArgs)
            {
                gltfImportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                gltfImportArgs.Archives.Insert(0, new FileSystemArchive(_projectManager.ActiveProject.ModDirectory));
            }

            if (item.Properties is ReImportArgs reImportArgs)
            {
                if (!_pluginService.IsInstalled(EPlugin.redmod))
                {
                    _loggerService.Error("Redmod plugin needs to be installed to import animations");
                    return false;
                }

                reImportArgs.Depot = proj.ModDirectory;
                reImportArgs.RedMod = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
            }

            var settings = new GlobalImportArgs().Register(item.Properties as ImportArgs);
            var rawDir = new DirectoryInfo(proj.RawDirectory);
            var redrelative = new RedRelativePath(rawDir, fi.GetRelativePath(rawDir));

            try
            {
                return await _modTools.Import(redrelative, settings, new DirectoryInfo(proj.ModDirectory));
            }
            catch (Exception e)
            {
                _loggerService.Error($"Could not import {item.Name}");
                _loggerService.Error(e);
            }

        }

        return false;
    }





}
