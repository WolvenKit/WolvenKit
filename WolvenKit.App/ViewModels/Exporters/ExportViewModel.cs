using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.ViewModels.Exporters;

public partial class ExportViewModel : AbstractExportViewModel
{
    private readonly AppViewModel _appViewModel;
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IProgressService<double> _progressService;
    private readonly ImportExportHelper _importExportHelper;

    public ExportViewModel(
        AppViewModel appViewModel,
        IAppArchiveManager archiveManager,
        INotificationService notificationService,
        ISettingsManager settingsManager,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IProgressService<double> progressService,
        ImportExportHelper importExportHelper) : base(archiveManager, notificationService, settingsManager, "Export Tool", "Export Tool")
    {
        _appViewModel = appViewModel;
        _loggerService = loggerService;
        _projectManager = projectManager;
        _progressService = progressService;
        _importExportHelper = importExportHelper;

        PropertyChanged += ExportViewModel_PropertyChanged;
    }



    private async void ExportViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IsActive))
        {
            if (IsActive)
            {
                if (_refreshtask is null || (_refreshtask is not null && _refreshtask.IsCompleted))
                {
                    _refreshtask = LoadFilesAsync();
                    await _refreshtask;
                }
            }
        }
    }

    #region Commands

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))] // notify in ImportView.xaml.cs
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
                item.SetProperties(a);
            }
        }
    }

    #endregion

    protected override async Task ExecuteProcessBulk(bool all = false)
    {
        if (_archiveManager.ProjectArchive is not FileSystemArchive projectArchive)
        {
            _loggerService.Error("No project loaded!");
            return;
        }

        IsProcessing = true;
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
            _appViewModel.SaveFile(item.BaseFile);
            if (await ExportSingleAsync(item, projectArchive))
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

        _progressService.IsIndeterminate = false;

        if (sucessful > 0)
        {
            _notificationService.Success(
                $"{sucessful}/{total} files have been processed and are available in the Project Explorer's 'raw' section");
            _loggerService.Success(
                $"{sucessful}/{total} files have been processed and are available in the Project Explorer's 'raw' section");
        }

        //We format the list of failed export/import items here
        if (failedItems.Count > 0)
        {
            var failedItemsErrorString = $"The following items failed:\n{string.Join("\n", failedItems)}";
            _notificationService.Error(failedItemsErrorString); //notify once only 
            _loggerService.Error(failedItemsErrorString);
        }

        _progressService.Completed();
    }

    private async Task<bool> ExportSingleAsync(ExportableItemViewModel item, FileSystemArchive projectArchive)
    {
        var fi = new FileInfo(item.BaseFile);
        if (!fi.Exists)
        {
            return false;
        }

        if (item.Properties is not ExportArgs e)
        {
            throw new NotImplementedException();
        }

        var settings = new GlobalExportArgs().Register(e);
        if (!_importExportHelper.Finalize(settings))
        {
            return false;
        }

        return await _importExportHelper.Export(fi, settings, new DirectoryInfo(projectArchive.Project.ModDirectory), new DirectoryInfo(projectArchive.Project.RawDirectory));
    }

    protected override async Task LoadFilesAsync()
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        var files = Directory.GetFiles(_projectManager.ActiveProject.ModDirectory, "*", SearchOption.AllDirectories).Where(CanExport);

        // do not refresh if the files are the same
        if (Enumerable.SequenceEqual(Items.Select(x => x.BaseFile), files))
        {
            return;
        }

        _progressService.IsIndeterminate = true;

        Items.Clear();
        foreach (var filePath in files)
        {
            if (!Items.Any(x => x.BaseFile.Equals(filePath)))
            {
                var vm = await Task.Run(() => new ExportableItemViewModel(filePath));
                Items.Add(vm);
            }
        }

        ProcessAllCommand.NotifyCanExecuteChanged();
        _progressService.IsIndeterminate = false;
    }

    private static bool CanExport(string x) => Enum.TryParse<ECookedFileFormat>(Path.GetExtension(x).TrimStart('.'), out var _);

    public Task InitCollectionEditor(CallbackArguments args)
    {
        if (args.Arg is not ExportArgs exportArgs)
        {
            return Task.CompletedTask;
        }

        switch (exportArgs)
        {
            case MeshExportArgs meshExportArgs:
            {
                InitMeshCollectionEditor(args, meshExportArgs);
                break;
            }
            case OpusExportArgs opusExportArgs:
            {
                InitOpusCollectionEditor(args, opusExportArgs);
                break;
            }

            default:
                break;
        }

        return Task.CompletedTask;
    }

    private void InitOpusCollectionEditor(CallbackArguments args, OpusExportArgs opusExportArgs)
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


        var info = OpusTools.GetOpusInfo(_archiveManager, opusExportArgs.UseMod);
        if (info == null)
        {
            return;
        }

        var availableItems = info.OpusHashes.Select(x => new CollectionItemViewModel<uint>(x));

        // open dialogue
        var result = Interactions.ShowCollectionView((availableItems, selectedItems));
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

    private void InitMeshCollectionEditor(CallbackArguments args, MeshExportArgs meshExportArgs)
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
        var result = Interactions.ShowCollectionView((availableItems, selectedItems));
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
