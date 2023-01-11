using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Converters;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Exporters;

public record class CallbackArguments(ExportArgs arg, string propertyName);

public abstract partial class ExportViewModel : ImportExportViewModel
{

}

public partial class TextureExportViewModel : ExportViewModel
{
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

        LoadFiles();

        Header = Name;
    }

    public override string Name => "Export Tool";

    #region Commands

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private void ImportSettings()
    {
        foreach (var item in Items.Where(x => x.IsChecked))
        {
            if (item.Properties is not ExportArgs args)
            {
                continue;
            }

            item.Properties = (ImportExportArgs)System.Activator.CreateInstance(item.Properties.GetType());
        }
    }

    #endregion

    protected override async Task ExecuteProcessBulk(bool all = false)
    {
        IsProcessing = true;
        _watcherService.IsSuspended = true;
        var progress = 0;
        _progressService.Report(0);

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
                failedItems.Add(item.FullName);
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
        var fi = new FileInfo(item.FullName);
        if (fi.Exists)
        {
            if (item.Properties is MeshExportArgs meshExportArgs)
            {
                meshExportArgs.Archives.Clear();
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    meshExportArgs.Archives.AddRange(_archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList());
                }

                meshExportArgs.Archives.Insert(0, new FileSystemArchive(_projectManager.ActiveProject.ModDirectory));

                meshExportArgs.MaterialRepo = _settingsManager.MaterialRepositoryPath;
            }
            if (item.Properties is MorphTargetExportArgs morphTargetExportArgs)
            {
                if (_gameController.GetController() is RED4Controller cp77Controller)
                {
                    morphTargetExportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
                }
                morphTargetExportArgs.ModFolderPath = _projectManager.ActiveProject.ModDirectory;
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

            if (proj != null)
            {

            }

            var settings = new GlobalExportArgs().Register(item.Properties as ExportArgs);
            return _modTools.Export(fi, settings,
                new DirectoryInfo(proj.ModDirectory),
                new DirectoryInfo(proj.RawDirectory));
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

    // TODO refactor this mess
    public async Task InitCollectionEditor(CallbackArguments args)
    {
        if (args.arg is not ExportArgs exportArgs)
        {
            return;
        }
        // get initial items
        var fetchExtension = ERedExtension.mesh;

        switch (exportArgs)
        {
            case MeshExportArgs meshExportArgs:
            {
                List<FileEntry> selectedEntries = new();
                switch (args.propertyName)
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

                // TODO init collectionEditor with this
                IEnumerable<CollectionItemViewModel<FileEntry>> selectedItems = null;
                if (selectedEntries is not null)
                {
                    selectedItems = selectedEntries.Select(_ => new CollectionItemViewModel<FileEntry>(_));
                }

                var availableItems = _archiveManager
                    .GetGroupedFiles()[$".{fetchExtension}"]
                    .Select(_ => new CollectionItemViewModel<FileEntry>(_)).GroupBy(x => x.Name)
                    .Select(x => x.First());

                // open dialogue
                var result = await Interactions.ShowCollectionView.Handle((availableItems, selectedItems));
                if (result is not null)
                {
                    switch (args.propertyName)
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
                            meshExportArgs.Rig = new List<FileEntry>() { result.Cast<CollectionItemViewModel<FileEntry>>().Select(_ => _.Model).FirstOrDefault() };
                            _notificationService.Success($"Selected Rigs were added to WithRig arguments.");
                            meshExportArgs.meshExportType = MeshExportType.WithRig;
                            break;

                        default:
                            break;
                    }
                }


                break;
            }

            case OpusExportArgs opusExportArgs:
            {
                List<uint> selectedEntries = new();
                switch (args.propertyName)
                {
                    case nameof(OpusExportArgs.SelectedForExport):
                        selectedEntries = opusExportArgs.SelectedForExport;
                        break;
                }
                // TODO init collectionEditor with this
                IEnumerable<CollectionItemViewModel<uint>> selectedItems = null;
                if (selectedEntries is not null)
                {
                    selectedItems = selectedEntries.Select(x => new CollectionItemViewModel<uint>(x));
                }
                OpusTools opusTools = new(_projectManager.ActiveProject.ModDirectory, _projectManager.ActiveProject.RawDirectory, opusExportArgs.UseMod);
                var availableItems = opusTools.Info.OpusHashes.Select(x => new CollectionItemViewModel<uint>(x));

                // open dialogue
                var result = await Interactions.ShowCollectionView.Handle((availableItems, selectedItems));
                if (result is not null)
                {
                    switch (args.propertyName)
                    {
                        case nameof(OpusExportArgs.SelectedForExport):
                            opusExportArgs.SelectedForExport =
                                new List<uint>(result.Cast<CollectionItemViewModel<uint>>().Select(_ => _.Model));
                            _notificationService.Success($"Selected opus items were added.");
                            break;
                    }

                }


                break;
            }

        }
    }

}
