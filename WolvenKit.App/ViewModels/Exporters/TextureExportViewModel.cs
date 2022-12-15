using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Converters;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Exporters;

public partial class TextureExportViewModel : FloatingPaneViewModel
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

    private (JsonObject, Type) currentSettings;
    private static readonly JsonSerializerOptions s_jsonSerializerSettings = new()
    {
        Converters =
            {
                new JsonFileEntryConverter(),
                new JsonArchiveConverter()
            },
        WriteIndented = true
    };

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

    public override string Name => "Texture Exporter";

    [Reactive] public ExportableItemViewModel SelectedObject { get; set; }

    public ObservableCollection<ExportableItemViewModel> ExportableItems { get; set; }
    public ObservableCollection<object> SelectedItems { get; set; }

    [Reactive] public bool IsProcessing { get; set; } = false;

    #region Commands

    [RelayCommand(CanExecute = nameof(IsAnyFile))]
    private async Task ProcessAll() => await ExecuteProcessBulk(true);

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private async Task ProcessSelected() => await ExecuteProcessBulk();

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private void CopyArgumentsTemplateTo(string param)
    {
        if (SelectedObject.Properties is not ImportExportArgs args)
        {
            return;
        }

        currentSettings = (SerializeArgs(args), args.GetType());
    }

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private void PasteArgumentsTemplateTo()
    {
        var results = ExportableItems.Where(x => x.IsChecked);
        var count = 0;

        foreach (var item in results)
        {
            var (settings, type) = currentSettings;

            if (item.Properties.GetType() != type)
            {
                continue;
            }

            item.Properties = (ImportExportArgs)settings.Deserialize(type, s_jsonSerializerSettings);
            count++;
        }

        if (count > 0)
        {
            _notificationService.Success($"Template has been copied to the selected items.");
        }
    }

    [RelayCommand(CanExecute = nameof(IsAnyFileSelected))]
    private void ImportSettings()
    {
        foreach (var item in ExportableItems.Where(x => x.IsChecked))
        {
            if (item.Properties is not ExportArgs args)
            {
                continue;
            }

            item.Properties = (ImportExportArgs)System.Activator.CreateInstance(item.Properties.GetType());
        }
    }

    [RelayCommand]
    private void Refresh() => LoadFiles();

    [RelayCommand]
    private void ToggleAdvancedOptions() => _settingsManager.ShowAdvancedOptions = !_settingsManager.ShowAdvancedOptions;


    #endregion

    public bool IsAnyFileSelected => ExportableItems.Where(x => x.IsChecked).Any();

    private bool IsAnyFile() => ExportableItems.Any();

    private JsonObject SerializeArgs(ImportExportArgs args)
    {
        var node = (JsonObject)JsonSerializer.SerializeToNode(args, args.GetType(), s_jsonSerializerSettings);

        node.Remove("Changing");
        node.Remove("Changed");
        node.Remove("ThrownExceptions");

        return node;
    }

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

        var toBeExported = ExportableItems.Where(_ => all || _.IsChecked).ToList();
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

    /// <summary>
    /// Export Single Item
    /// </summary>
    /// <param name="item"></param>
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

    private void LoadFiles()
    {
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        var files = Directory.GetFiles(_projectManager.ActiveProject.ModDirectory, "*", SearchOption.AllDirectories)
            .Where(CanExport)
            .Select(x => new ExportableItemViewModel(x));

        ExportableItems = new(files);
    }

    private static bool CanExport(string x)
    {
        var ext = Path.GetExtension(x).TrimStart('.');

        if (!Enum.TryParse<ECookedFileFormat>(ext, out var _))
        {
            return false;
        }

        return true;
    }
}
