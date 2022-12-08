using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Converters;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Tools;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.App.ViewModels.Importers;
public partial class TextureImportViewModel : FloatingPaneViewModel
{
    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;
    private readonly ISettingsManager _settingsManager;
    private readonly IWatcherService _watcherService;
    private readonly IProgressService<double> _progressService;
    private readonly IProjectManager _projectManager;
    private readonly Red4ParserService _parserService;
    private readonly IGameControllerFactory _gameController;
    private readonly IArchiveManager _archiveManager;
    private readonly IPluginService _pluginService;
    private readonly IModTools _modTools;

    public TextureImportViewModel(
        Red4ParserService parserService,
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
        _parserService = parserService;
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
        CopyArgumentsTemplateToCommand = new DelegateCommand<string>(ExecuteCopyArgumentsTemplateTo, CanCopyArgumentsTemplateTo);

        LoadFiles();

        Header = Name;

        this.WhenAnyValue(x => x._projectManager.IsProjectLoaded)
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(_ => ImportSettingsCommand.NotifyCanExecuteChanged());
    }

    public override string Name => "Texture Importer";

    /// <summary>
    /// Selected object , returns a Importable/Exportable ItemVM based on "IsImportsSelected"
    /// </summary>
    [Reactive] public ImportableItemViewModel SelectedObject { get; set; }

    [Reactive] public ObservableCollection<ImportableItemViewModel> ImportableItems { get; set; }

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



    public ICommand CopyArgumentsTemplateToCommand { get; private set; }

    private bool CanCopyArgumentsTemplateTo(string param) => true;

    private void ExecuteCopyArgumentsTemplateTo(string param)
    {
        //var current = SelectedObject.Properties;


        //if (current is not ImportArgs importArgs)
        //{
        //    return;
        //}

        //var json = SerializeArgs(importArgs);

        //var results = param switch
        //{
        //    s_selectedInGrid => ImportableItems.Where(_ => _.IsChecked),
        //    _ => ImportableItems
        //};

        //foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
        //{
        //    item.Properties = (ImportArgs)json.Deserialize(importArgs.GetType(), s_jsonSerializerSettings);
        //}



        //SaveSettings();
        //_notificationService.Success($"Template has been copied to the selected items.");
    }

    public bool HasActiveProject => _projectManager != null && _projectManager.IsProjectLoaded;

    [RelayCommand(CanExecute = nameof(HasActiveProject))]
    private void ImportSettings()
    {
        var gammaRegex = new Regex(".*_[de][0-9]*$");

        foreach (var importableItem in ImportableItems)
        {
            if (!importableItem.IsChecked)
            {
                continue;
            }

            if (importableItem.Properties is not XbmImportArgs xbmImportArgs)
            {
                continue;
            }

            if (_parserService != null)
            {
                if (GetModFile(importableItem, "xbm") is { } modFile)
                {
                    using var fs = File.OpenRead(modFile);

                    if (_parserService.TryReadRed4File(fs, out var cr2w) && cr2w.RootChunk is CBitmapTexture bitmap)
                    {
                        xbmImportArgs.RawFormat = Enum.Parse<ETextureRawFormat>(bitmap.Setup.RawFormat.ToString());
                        xbmImportArgs.Compression = Enum.Parse<ETextureCompression>(bitmap.Setup.Compression.ToString());
                        xbmImportArgs.IsGamma = bitmap.Setup.IsGamma;
                        xbmImportArgs.TextureGroup = bitmap.Setup.Group;
                        xbmImportArgs.GenerateMipMaps = bitmap.Setup.HasMipchain;

                        _loggerService?.Info($"Load settings for \"{importableItem.Name}\": Loaded from project file");

                        continue;
                    }

                    _loggerService?.Warning($"Load settings for \"{importableItem.Name}\": Project file couldn't be read");
                }

                if (GetArchiveFile(importableItem, "xbm") is { } archiveFile)
                {
                    using var ms = new MemoryStream();
                    archiveFile.Extract(ms);

                    if (_parserService.TryReadRed4File(ms, out var cr2w) && cr2w.RootChunk is CBitmapTexture bitmap)
                    {
                        xbmImportArgs.RawFormat = Enum.Parse<ETextureRawFormat>(bitmap.Setup.RawFormat.ToString());
                        xbmImportArgs.Compression = Enum.Parse<ETextureCompression>(bitmap.Setup.Compression.ToString());
                        xbmImportArgs.GenerateMipMaps = bitmap.Setup.HasMipchain;
                        xbmImportArgs.IsGamma = bitmap.Setup.IsGamma;
                        xbmImportArgs.TextureGroup = bitmap.Setup.Group;

                        _loggerService?.Info($"Load settings for \"{importableItem.Name}\": Loaded from archive file");

                        continue;
                    }

                    _loggerService?.Warning($"Load settings for \"{importableItem.Name}\": Archive file couldn't be read");
                }
            }

            xbmImportArgs.IsGamma = gammaRegex.IsMatch(Path.GetFileNameWithoutExtension(importableItem.Name));

            _loggerService?.Info($"Load settings for \"{importableItem.Name}\": Parsed filename");
        }

        SaveSettings();
    }

    [RelayCommand]
    private void ResetSettings()
    {
        foreach (var importableItem in ImportableItems)
        {
            if (!importableItem.IsChecked)
            {
                continue;
            }

            importableItem.Properties = (ImportExportArgs)System.Activator.CreateInstance(importableItem.Properties.GetType());
        }

        SaveSettings();
    }

    public string GetModFile(ImportableItemViewModel importableItem, string extension)
    {
        if (_projectManager is { ActiveProject: Cp77Project project })
        {
            var tmp = Path.ChangeExtension(FileModel.GetRelativeName(importableItem.FullName, _projectManager.ActiveProject), extension);

            foreach (var modFile in _projectManager.ActiveProject.ModFiles)
            {
                if (modFile == tmp)
                {
                    return Path.Combine(project.ModDirectory, modFile);
                }
            }
        }

        return null;
    }

    public IGameFile GetArchiveFile(ImportableItemViewModel importableItem, string extension)
    {
        if (_archiveManager != null)
        {
            var hash = FNV1A64HashAlgorithm.HashString(Path.ChangeExtension(FileModel.GetRelativeName(importableItem.FullName, _projectManager.ActiveProject), extension));

            var archiveFile = _archiveManager.Lookup(hash);
            if (archiveFile.HasValue)
            {
                return archiveFile.Value;
            }
        }

        return null;
    }


    private static readonly JsonSerializerOptions s_jsonSerializerSettings = new()
    {
        Converters =
            {
                new JsonFileEntryConverter(),
                new JsonArchiveConverter()
            },
        WriteIndented = true
    };
    private JsonObject SerializeArgs(ImportExportItemViewModel vm) => SerializeArgs(vm.Properties);
    private JsonObject SerializeArgs(ImportExportArgs args)
    {
        var node = (JsonObject)JsonSerializer.SerializeToNode(args, args.GetType(), s_jsonSerializerSettings);

        node.Remove("Changing");
        node.Remove("Changed");
        node.Remove("ThrownExceptions");

        return node;
    }

    private Dictionary<string, Dictionary<string, JsonObject>> _loadedSettings;
    public void SaveSettings()
    {
        var importSettings = ImportableItems.ToDictionary(importableItem => FileModel.GetRelativeName(importableItem.FullName, _projectManager.ActiveProject), SerializeArgs);
        //var exportSettings = ExportableItems.ToDictionary(exportableItem => FileModel.GetRelativeName(exportableItem.FullName, _projectManager.ActiveProject), SerializeArgs);

        _loadedSettings = new Dictionary<string, Dictionary<string, JsonObject>>
            {
                { "import", importSettings },
                //{ "export", exportSettings },
            };

        var json = JsonSerializer.Serialize(_loadedSettings, s_jsonSerializerSettings);
        File.WriteAllText(Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "ImportExportSettings.json"), json);
    }

    private void LoadFiles()
    {
        var files = Directory.GetFiles(_projectManager.ActiveProject.RawDirectory, "*", SearchOption.AllDirectories)
            .Where(CanImport)
            .Select(x => new ImportableItemViewModel(x));

        ImportableItems = new(files);
    }

    private static bool CanImport(string x)
    {
        var ext = Path.GetExtension(x).TrimStart('.');

        if (!Enum.TryParse<ERawFileFormat>(ext, out var _))
        {
            return false;
        }

        var dbg_disabled = new List<string>()
                {
                    "bmp",
                    "jpg",
                    //"png",
                    //"tga",
                    "tiff",
                };

        return !dbg_disabled.Contains(ext);
    }
}
