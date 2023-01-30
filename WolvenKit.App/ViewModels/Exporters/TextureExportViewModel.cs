using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using WolvenKit.App.Controllers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.ViewModels.Exporters;

public record class CallbackArguments(ImportExportArgs Arg, string PropertyName);

public abstract partial class ExportViewModel : ImportExportViewModel
{
    protected ExportViewModel(IArchiveManager archiveManager, INotificationService notificationService, ISettingsManager settingsManager, string header, string contentId)
        : base(archiveManager, notificationService, settingsManager, header, contentId)
    {
    }
}

public partial class TextureExportViewModel : ExportViewModel
{
    private ILoggerService _loggerService;
    private INotificationService _notificationService;
    private ISettingsManager _settingsManager;
    private IWatcherService _watcherService;
    private IProgressService<double> _progressService;
    private IProjectManager _projectManager;
    private IGameControllerFactory _gameController;
    private IArchiveManager _archiveManager;
    private IPluginService _pluginService;
    private IModTools _modTools;


    public TextureExportViewModel(
        IGameControllerFactory gameController,
        ISettingsManager settingsManager,
        IWatcherService watcherService,
        ILoggerService loggerService,
        IProjectManager projectManager,
        INotificationService notificationService,
        IArchiveManager archiveManager,
        IPluginService pluginService,
        IModTools modTools,
        IProgressService<double> progressService) : base(archiveManager, notificationService, settingsManager, "Export Tool", "Export Tool")
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

        LoadFiles();
    }

    #region Commands

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))] // notify in TextureImportView.xaml.cs
    private void ImportSettings()
    {
        foreach (var item in Items.Where(x => x.IsChecked))
        {
            if (item.Properties is not ExportArgs args)
            {
                continue;
            }

            if (Activator.CreateInstance(item.Properties.GetType()) is ImportExportArgs a)
            {
                item.Properties = a;
            }
        }
    }

    #endregion

    protected override async Task ExecuteProcessBulk(bool all = false)
    {
        IsProcessing = true;
        _watcherService.IsSuspended = true;
        var progress = 0;
        _progressService.Report(0.1);

        var total = 0;
        var sucessful = 0;

        //prepare a list of failed items
        var failedItems = new List<string>();

        var toBeExported = Items
            .Where(_ => all || _.IsChecked)
            .Cast<ExportableItemViewModel>()
            .ToList();
        total = toBeExported.Count;
        foreach (var item in toBeExported)
        {
            if (await Task.Run(() => ExportSingle(item)))
            {
                sucessful++;
            }
            else
            {
                failedItems.Add(item.BaseFile);
            }

            Interlocked.Increment(ref progress);
            _progressService.Report(progress / (float)total);
        }

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

    private bool ExportSingle(ExportableItemViewModel item)
    {
        var proj = _projectManager.ActiveProject;
        if (proj == null)
        {
            return false;
        }

        var fi = new FileInfo(item.BaseFile);
        if (fi.Exists)
        {
            if (item.Properties is MeshExportArgs meshExportArgs)
            {
                meshExportArgs.Archives.Clear();
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    meshExportArgs.Archives.AddRange(_archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList());
                }

                meshExportArgs.Archives.Insert(0, new FileSystemArchive(proj.ModDirectory));

                meshExportArgs.MaterialRepo = _settingsManager.MaterialRepositoryPath;
            }
            if (item.Properties is MorphTargetExportArgs morphTargetExportArgs)
            {
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    morphTargetExportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
                morphTargetExportArgs.ModFolderPath = proj.ModDirectory;
            }
            if (item.Properties is OpusExportArgs opusExportArgs)
            {
                opusExportArgs.RawFolderPath = proj.RawDirectory;
                opusExportArgs.ModFolderPath = proj.ModDirectory;
            }
            if (item.Properties is EntityExportArgs entExportArgs)
            {
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    entExportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
            }
            if (item.Properties is AnimationExportArgs animationExportArgs)
            {
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    animationExportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
            }

            if (item.Properties is not ExportArgs e)
            {
                throw new NotImplementedException();
            }

            var settings = new GlobalExportArgs().Register(e);
            return _modTools.Export(fi, settings, new DirectoryInfo(proj.ModDirectory), new DirectoryInfo(proj.RawDirectory));
        }

        return false;
    }

    protected override void LoadFiles()
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        var files = Directory.GetFiles(_projectManager.ActiveProject.ModDirectory, "*", SearchOption.AllDirectories)
            .Where(CanExport)
            .Select(x => new ExportableItemViewModel(x));

        Items.Clear();
        Items = new(files);

        ProcessAllCommand.NotifyCanExecuteChanged();
    }

    private static bool CanExport(string x) => Enum.TryParse<ECookedFileFormat>(Path.GetExtension(x).TrimStart('.'), out var _);

    public async Task InitCollectionEditor(CallbackArguments args)
    {
        if (args.Arg is not ExportArgs exportArgs)
        {
            return;
        }

        switch (exportArgs)
        {
            case MeshExportArgs meshExportArgs:
            {
                await InitMeshCollectionEditor(args, meshExportArgs);
                break;
            }
            case OpusExportArgs opusExportArgs:
            {
                await InitOpusCollectionEditor(args, opusExportArgs);
                break;
            }

            default:
                break;
        }
    }

    private async Task InitOpusCollectionEditor(CallbackArguments args, OpusExportArgs opusExportArgs)
    {
        List<uint> selectedEntries = new();
        switch (args.PropertyName)
        {
            case nameof(OpusExportArgs.SelectedForExport):
                selectedEntries = opusExportArgs.SelectedForExport;
                break;
            default:
                break;
        }
        // TODO init collectionEditor with this
        List<CollectionItemViewModel<uint>> selectedItems = new();
        if (selectedEntries is not null)
        {
            selectedItems = selectedEntries.Select(x => new CollectionItemViewModel<uint>(x)).ToList();
        }


        OpusTools opusTools = new(_projectManager.ActiveProject.NotNull().ModDirectory, _projectManager.ActiveProject.RawDirectory, _archiveManager, opusExportArgs.UseMod);
        var availableItems = opusTools.Info.OpusHashes.Select(x => new CollectionItemViewModel<uint>(x));

        // open dialogue
        var result = await Interactions.ShowCollectionView.Handle((availableItems, selectedItems));
        if (result is not null)
        {
            switch (args.PropertyName)
            {
                case nameof(OpusExportArgs.SelectedForExport):
                    opusExportArgs.SelectedForExport =
                        new List<uint>(result.Cast<CollectionItemViewModel<uint>>().Select(_ => _.Model));
                    _notificationService.Success($"Selected opus items were added.");
                    break;
                default:
                    break;
            }

        }
    }

    private async Task InitMeshCollectionEditor(CallbackArguments args, MeshExportArgs meshExportArgs)
    {
        var fetchExtension = ERedExtension.mesh;
        List<FileEntry> selectedEntries = new();
        switch (args.PropertyName)
        {
            case nameof(MeshExportArgs.MultiMeshMeshes):
                selectedEntries = meshExportArgs.MultiMeshMeshes;
                fetchExtension = ERedExtension.mesh;
                break;

            case nameof(MeshExportArgs.MultiMeshRigs):
                selectedEntries = meshExportArgs.MultiMeshRigs;
                fetchExtension = ERedExtension.rig;
                break;

            case nameof(MeshExportArgs.Rig):
                selectedEntries = meshExportArgs.Rig;
                fetchExtension = ERedExtension.rig;
                break;

            default:
                break;
        }

        IEnumerable<CollectionItemViewModel<FileEntry>>? selectedItems = null;
        if (selectedEntries is not null)
        {
            selectedItems = selectedEntries.Select(_ => new CollectionItemViewModel<FileEntry>(_));
        }

        var availableItems = _archiveManager
            .GetGroupedFiles()[$".{fetchExtension}"]
            .Cast<FileEntry>()
            .Select(_ => new CollectionItemViewModel<FileEntry>(_)).GroupBy(x => x.Name)
            .Select(x => x.First());

        // open dialogue
        var result = await Interactions.ShowCollectionView.Handle((availableItems, selectedItems));
        if (result is not null)
        {
            switch (args.PropertyName)
            {
                case nameof(MeshExportArgs.MultiMeshMeshes):
                    meshExportArgs.MultiMeshMeshes = result.Cast<CollectionItemViewModel<FileEntry>>().Select(_ => _.Model).ToList();
                    _notificationService.Success($"Selected Meshes were added to MultiMesh arguments.");
                    meshExportArgs.meshExportType = MeshExportType.Multimesh;
                    break;

                case nameof(MeshExportArgs.MultiMeshRigs):
                    meshExportArgs.MultiMeshRigs = result.Cast<CollectionItemViewModel<FileEntry>>().Select(_ => _.Model).ToList();
                    _notificationService.Success($"Selected Rigs were added to MultiMesh arguments.");
                    meshExportArgs.meshExportType = MeshExportType.Multimesh;
                    break;

                case nameof(MeshExportArgs.Rig):
                    var rig = result.Cast<CollectionItemViewModel<FileEntry>>().Select(_ => _.Model).FirstOrDefault();
                    if (rig is not null)
                    {
                        meshExportArgs.Rig = new List<FileEntry>() { rig };
                        _notificationService.Success($"Selected Rigs were added to WithRig arguments.");
                    }
                    meshExportArgs.meshExportType = MeshExportType.WithRig;
                    break;

                default:
                    break;
            }
        }
    }
}
