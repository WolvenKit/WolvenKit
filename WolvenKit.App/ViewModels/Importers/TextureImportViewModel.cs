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
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.ViewModels.Importers;

public abstract partial class ImportViewModel : ImportExportViewModel
{
    protected ImportViewModel(IArchiveManager archiveManager, INotificationService notificationService, ISettingsManager settingsManager, string header, string contentId)
        : base(archiveManager, notificationService, settingsManager, header, contentId)
    {
    }
}

public partial class TextureImportViewModel : ImportViewModel
{
    private ILoggerService _loggerService;
    private INotificationService _notificationService;
    private ISettingsManager _settingsManager;
    private IWatcherService _watcherService;
    private IProgressService<double> _progressService;
    private readonly Red4ParserService _parserService;
    private IProjectManager _projectManager;
    private IGameControllerFactory _gameController;
    private IArchiveManager _archiveManager;
    private IPluginService _pluginService;
    private IModTools _modTools;


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
        IProgressService<double> progressService,
        Red4ParserService parserService) : base(archiveManager, notificationService, settingsManager, "Import Tool", "Import Tool")
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
        _parserService = parserService;

        LoadFiles();

        PropertyChanged += TextureExportViewModel_PropertyChanged;
    }
    private void TextureExportViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IsActive))
        {
            if (IsActive)
            {
                LoadFiles();
            }
        }
    }

    #region Commands

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]  // notify in TextureImportView.xaml.cs
    private void DefaultSettings()
    {
        foreach (var item in Items.Where(x => x.IsChecked))
        {
            if (item.Properties is not XbmImportArgs xbmImportArgs)
            {
                continue;
            }

            // set default settings from filename
            item.Properties = ImportableItemViewModel.LoadXbmDefaultSettings(item.BaseFile);
            _loggerService?.Info($"Loaded settings for \"{item.Name}\": Parsed filename");
        }
    }

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]  // notify in TextureImportView.xaml.cs
    private void ImportSettings()
    {
        foreach (var item in Items.Where(x => x.IsChecked))
        {
            if (item.Properties is not XbmImportArgs xbmImportArgs)
            {
                continue;
            }

            // import settings from vanilla
            item.Properties = ImportableItemViewModel.LoadXbmSettingsFromGame(item.BaseFile, _archiveManager, _projectManager, _parserService);
            _loggerService?.Info($"Loaded settings for \"{item.Name}\": Parsed game file");
        }
    }

    #endregion

    protected override async Task ExecuteProcessBulk(bool all = false)
    {
        if (!Items.Any())
        {
            return;
        }

        IsProcessing = true;
        _watcherService.IsSuspended = true;
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
            if (await Task.Run(() => ImportSingleTask(item)))
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

        _watcherService.IsSuspended = false;
        await _watcherService.RefreshAsync(_projectManager.ActiveProject);
        _progressService.IsIndeterminate = false;

        if (sucessful > 0)
        {
            _notificationService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");
            _loggerService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");
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
            OpusTools opusTools = new(proj.ModDirectory, proj.RawDirectory, _archiveManager, true);

            return Task.Run(() => opusTools.ImportWavs(wavs.ToArray()));
        }

        return Task.FromResult(false);
    }

    private async Task<bool> ImportSingleTask(ImportableItemViewModel item)
    {
        if (_gameController.GetController() is not RED4Controller)
        {
            return false;
        }

        var proj = _projectManager.ActiveProject;
        if (proj is null)
        {
            return false;
        }

        var fi = new FileInfo(item.BaseFile);
        if (!fi.Exists)
        {
            return false;

        }

        if (item.Properties is not ImportArgs prop)
        {
            throw new ArgumentException("incorrect type, expected ImportArgs", nameof(item));
        }

        if (item.Properties is GltfImportArgs gltfImportArgs)
        {
            gltfImportArgs.Archives = _archiveManager.Archives.Items.Cast<ICyberGameArchive>().ToList();
            gltfImportArgs.Archives.Insert(0, new FileSystemArchive(proj.ModDirectory));
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


        var settings = new GlobalImportArgs().Register(prop);
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

        return false;
    }

    protected override void LoadFiles()
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        var files = Directory.GetFiles(_projectManager.ActiveProject.RawDirectory, "*", SearchOption.AllDirectories)
            .Where(CanImport)
            .Select(x => new ImportableItemViewModel(x, _archiveManager, _projectManager, _parserService));

        Items.Clear();
        Items = new(files);

        ProcessAllCommand.NotifyCanExecuteChanged();
    }

    private static bool CanImport(string x) => Enum.TryParse<ERawFileFormat>(Path.GetExtension(x).TrimStart('.'), out var _);

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
