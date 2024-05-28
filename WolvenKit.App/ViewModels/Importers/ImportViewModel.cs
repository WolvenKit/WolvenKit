using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.ViewModels.Importers;

public partial class ImportViewModel : AbstractImportViewModel
{
    private readonly AppViewModel _appViewModel;
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IProgressService<double> _progressService;
    private readonly IGameControllerFactory _gameController;
    private readonly Red4ParserService _parserService;
    private readonly ImportExportHelper _importExportHelper;

    public ImportViewModel(
        AppViewModel appViewModel,
        IAppArchiveManager archiveManager, 
        INotificationService notificationService, 
        ISettingsManager settingsManager,
        ILoggerService loggerService,
        IProjectManager projectManager,
        IProgressService<double> progressService,
        IGameControllerFactory gameController,
        Red4ParserService parserService,
        ImportExportHelper importExportHelper) : base(archiveManager, notificationService, settingsManager, "Import Tool", "Import Tool")
    {
        _appViewModel = appViewModel;
        _loggerService = loggerService;
        _projectManager = projectManager;
        _progressService = progressService;
        _gameController = gameController;
        _parserService = parserService;
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

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]  // notify in ImportView.xaml.cs
    private void DefaultSettings()
    {
        foreach (var item in Items.Where(x => x.IsChecked))
        {
            if (item.Properties is not XbmImportArgs xbmImportArgs)
            {
                continue;
            }

            // set default settings from filename
            item.SetProperties(ImportableItemViewModel.LoadXbmDefaultSettings(item.BaseFile));
            _loggerService?.Info($"Loaded settings for \"{item.Name}\": Parsed filename");
        }
    }

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]  // notify in ImportView.xaml.cs
    private void ImportSettings()
    {
        foreach (var item in Items.Where(x => x.IsChecked))
        {
            if (item.Properties is not XbmImportArgs xbmImportArgs)
            {
                continue;
            }

            // import settings from vanilla
            if (ImportableItemViewModel.TryLoadXbmSettingsFromGame(item.BaseFile, _archiveManager, _projectManager, _parserService, out var args))
            {
                item.SetProperties(args);
                _loggerService?.Info($"Loaded settings for \"{item.Name}\": Parsed game file");
            }
            else
            {
                // fall back to default settings
                item.SetProperties(ImportableItemViewModel.LoadXbmDefaultSettings(item.BaseFile));
                _loggerService?.Warning($"Could not load settings for \"{item.Name}\" from game");
            }
        }
    }

    #endregion

    protected override async Task ExecuteProcessBulk(bool all = false)
    {
        if (_gameController.GetController() is not RED4Controller)
        {
            return;
        }

        if (_archiveManager.ProjectArchive is not FileSystemArchive projectArchive)
        {
            _loggerService.Error("No project loaded!");
            return;
        }

        if (!Items.Any())
        {
            return;
        }

        IsProcessing = true;
        var progress = 0;
        _progressService.Report(0.1);

        var total = 0;
        var sucessful = 0;

        //prepare a list of failed items
        var failedItems = new List<string>();

        var toBeImported = Items
            .Where(_ => all || _.IsChecked)
            .Where(x => !x.Extension.Equals(ERawFileFormat.wav.ToString()))
            .Cast<ImportableItemViewModel>()
            .ToList();

        total = toBeImported.Count;
        foreach (var item in toBeImported)
        {
            if (await ImportSingleAsync(item, projectArchive))
            {
                sucessful++;
            }
            else // not successful
            {
                failedItems.Add(item.BaseFile);
            }

            Interlocked.Increment(ref progress);
            _progressService.Report(progress / (float)total);
        }

        await ImportWavs(Items.Where(_ => all || _.IsChecked)
            .Where(x => x.Extension.Equals(ERawFileFormat.wav.ToString()))
            .Select(x => x.BaseFile)
            .ToList()
            );

        IsProcessing = false;

        _progressService.IsIndeterminate = false;

        if (sucessful > 0)
        {
            _notificationService.Success(
                $"{sucessful}/{total} files have been processed and are available in the Project Explorer's 'archive' section");
            _loggerService.Success(
                $"{sucessful}/{total} files have been processed and are available in the Project Explorer's 'archive' section");
        }

        //We format the list of failed export/import items here
        if (failedItems.Count > 0)
        {
            var failedItemsErrorString = $"The following items failed:\n{string.Join("\n", failedItems)}";
            _notificationService.Error(failedItemsErrorString); //notify once only 
            _loggerService.Error(failedItemsErrorString);
        }

        _progressService.Completed();

        _appViewModel.ReloadChangedFiles();
    }

    private Task<bool> ImportWavs(List<string> wavs)
    {
        if (wavs.Count == 0)
        {
            return Task.FromResult(true);
        }

        var proj = _projectManager.ActiveProject;
        if (proj is null)
        {
            return Task.FromResult(false);
        }

        if (_gameController.GetController() is RED4Controller cp77Controller)
        {
            return Task.Run(() => OpusTools.ImportWavs(_archiveManager, wavs, new DirectoryInfo(proj.RawDirectory), new DirectoryInfo(proj.ModDirectory)));
        }

        return Task.FromResult(false);
    }

    private async Task<bool> ImportSingleAsync(ImportableItemViewModel item, FileSystemArchive projectArchive)
    {
        var fi = new FileInfo(item.BaseFile);
        if (!fi.Exists)
        {
            return false;

        }

        if (item.Properties is not ImportArgs prop)
        {
            throw new ArgumentException("incorrect type, expected ImportArgs", nameof(item));
        }

        var settings = new GlobalImportArgs().Register(prop);
        if (!_importExportHelper.Finalize(prop, settings))
        {
            return false;
        }

        var rawDir = new DirectoryInfo(projectArchive.Project.RawDirectory);
        var redrelative = new RedRelativePath(rawDir, fi.GetRelativePath(rawDir));

        try
        {
            return await _importExportHelper.Import(redrelative, settings, new DirectoryInfo(projectArchive.Project.ModDirectory));
        }
        catch (Exception e)
        {
            _loggerService.Error($"Could not import {item.Name}");
            _loggerService.Error(e);
        }

        return false;
    }


    protected override async Task LoadFilesAsync()
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        var files = Directory.GetFiles(_projectManager.ActiveProject.RawDirectory, "*", SearchOption.AllDirectories)
            .Where(CanImport);

        // do not refresh if the files are the same
        if(Enumerable.SequenceEqual( Items.Select(x => x.BaseFile), files))
        {
            return;
        }

        _progressService.IsIndeterminate = true;

        Items.Clear();
        foreach (var filePath in files)
        {
            if (!Items.Any(x => x.BaseFile.Equals(filePath)))
            {
                var vm = await Task.Run(() => new ImportableItemViewModel(filePath, _archiveManager, _projectManager, _parserService));
                Items.Add(vm);
            }
        }

        ProcessAllCommand.NotifyCanExecuteChanged();
        _progressService.IsIndeterminate = false;
    }

    // for checking if a dds file is part of a morphtarget
    [GeneratedRegex("\\d+\\.dds$")]
    private static partial Regex NumberedDdsFileRegex();

    private static bool CanImport(string filePath)
    {
        var fileExtension = Path.GetExtension(filePath).TrimStart('.');
        if (!Enum.TryParse<ERawFileFormat>(fileExtension, out var _))
        {
            return false;
        }

        switch (fileExtension)
        {
            // masklist items
            case "png":
                var masklistPath = (Path.GetDirectoryName(filePath) ?? "").Replace("_layers", ".masklist");
                return !File.Exists(masklistPath);
            // morphtarget texturesF
            case "dds":
                var parentDirName = new DirectoryInfo(Path.GetDirectoryName(filePath) ?? string.Empty).Name;
                var morphtargetFolderName = NumberedDdsFileRegex().Replace(Path.GetFileName(filePath), "textures");
                return parentDirName != morphtargetFolderName;
            default:
                return true;
        }
    }

    public Task InitCollectionEditor(CallbackArguments args)
    {
        if (args.Arg is not ImportArgs importArgs)
        {
            return Task.CompletedTask;
        }

        switch (importArgs)
        {
            case GltfImportArgs gltfimport:
            {
                InitGltfCollectionEditor(args, gltfimport);
                break;
            }
            default:
                break;
        }

        return Task.CompletedTask;
    }

    private void InitGltfCollectionEditor(CallbackArguments args, GltfImportArgs gltfImportArgs)
    {
        var fetchExtension = ERedExtension.mesh;
        List<FileEntry> selectedEntries = new();
        switch (args.PropertyName)
        {
            case nameof(GltfImportArgs.Rig):
                selectedEntries = gltfImportArgs.Rig;
                fetchExtension = ERedExtension.rig;
                break;
            case nameof(GltfImportArgs.BaseMesh):
                selectedEntries = gltfImportArgs.BaseMesh;
                fetchExtension = ERedExtension.mesh;
                break;
            default:
                break;
        }

        List<IDisplayable> selectedItems = new();
        if (selectedEntries is not null)
        {
            selectedItems = selectedEntries
                .Select(_ => new CollectionItemViewModel<FileEntry>(_))
                .Cast<IDisplayable>()
                .ToList();
        }

        var availableItems = _archiveManager
            .GetGroupedFiles()[$".{fetchExtension}"]
            .Select(x => new CollectionItemViewModel<FileEntry>((FileEntry)x))
            .GroupBy(x => x.Name)
            .Select(x => x.First())
            .Cast<IDisplayable>()
            .ToList();

        // open dialogue
        if ((availableItems, selectedItems) is not (IEnumerable<IDisplayable>, IEnumerable<IDisplayable>) a)
        {
            throw new NotImplementedException();
        }

        var result = Interactions.ShowCollectionView(a);
        if (result is not null)
        {
            switch (args.PropertyName)
            {
                case nameof(GltfImportArgs.Rig):
                    var rig = result.Cast<CollectionItemViewModel<FileEntry>>().Select(x => x.Model).FirstOrDefault();
                    if (rig is not null)
                    {
                        gltfImportArgs.Rig = new List<FileEntry>() { rig };
                        _notificationService.Success($"Selected Rigs were added to WithRig arguments.");
                    }

                    gltfImportArgs.ImportFormat = GltfImportAsFormat.MeshWithRig;
                    break;

                case nameof(GltfImportArgs.BaseMesh):
                    var mesh = result.Cast<CollectionItemViewModel<FileEntry>>().Select(x => x.Model).FirstOrDefault();
                    if (mesh is not null)
                    {
                        gltfImportArgs.BaseMesh = new List<FileEntry>() { };
                        _notificationService.Success($"Selected Mesh was added to Mesh arguments.");
                    }

                    gltfImportArgs.ImportFormat = GltfImportAsFormat.Mesh;
                    break;

                default:
                    break;
            }
        }
    }

}
