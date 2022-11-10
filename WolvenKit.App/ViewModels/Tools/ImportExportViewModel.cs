using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using DynamicData.Binding;
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
using WolvenKit.Models.Docking;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Tools
{
    public partial class ImportExportViewModel : ToolViewModel
    {
        #region fields

        private const string s_selectedInGrid = "Selected in Grid";

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "ImportExport_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Import Export Tool";

        /// <summary>
        /// Private Readonly ModTools
        /// </summary>
        private readonly IModTools _modTools;

        private readonly ILoggerService _loggerService;
        private readonly INotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly IProgressService<double> _progressService;
        private readonly IWatcherService _watcherService;
        private readonly IGameControllerFactory _gameController;
        private readonly ISettingsManager _settingsManager;
        private readonly IArchiveManager _archiveManager;
        private readonly IPluginService _pluginService;
        private readonly Red4ParserService _parserService;


        /// <summary>
        /// Private Last Selected Item, Used for Selection Lock.
        /// </summary>
        private ImportExportItemViewModel _lastselected;

        private readonly ReadOnlyObservableCollection<ImportableItemViewModel> _importableItems;

        private readonly ReadOnlyObservableCollection<ExportableItemViewModel> _exportableItems;

        private Dictionary<string, Dictionary<string, JsonObject>> _loadedSettings;

        private static JsonSerializerOptions s_jsonSerializerSettings = new()
        {
            Converters =
            {
                new JsonFileEntryConverter(),
                new JsonArchiveConverter()
            },
            WriteIndented = true
        };

        #endregion fields

        /// <summary>
        /// Import Export ViewModel Constructor
        /// </summary>
        /// <param name="projectManager"></param>
        /// <param name="loggerService"></param>
        /// <param name="messageService"></param>
        /// <param name="watcherService"></param>
        /// <param name="gameController"></param>
        /// <param name="modTools"></param>
        public ImportExportViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IProgressService<double> progressService,
            IWatcherService watcherService,
            INotificationService notificationService,
            IGameControllerFactory gameController,
            ISettingsManager settingsManager,
            IModTools modTools,
            IArchiveManager archiveManager,
            IPluginService pluginService,
            Red4ParserService parserService) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _progressService = progressService;
            _watcherService = watcherService;
            _modTools = modTools;
            _gameController = gameController;
            _notificationService = notificationService;
            _settingsManager = settingsManager;
            _archiveManager = archiveManager;
            _pluginService = pluginService;
            _parserService = parserService;

            SetupToolDefaults();
            SideInDockedMode = DockSide.Tabbed;

            ProcessAllCommand = ReactiveCommand.CreateFromTask(ExecuteProcessAll);
            ProcessSelectedCommand = ReactiveCommand.CreateFromTask(ExecuteProcessSelected);
            CopyArgumentsTemplateToCommand = new DelegateCommand<string>(ExecuteCopyArgumentsTemplateTo, CanCopyArgumentsTemplateTo);
            SetCollectionCommand = new DelegateCommand<string>(ExecuteSetCollection, CanSetCollection);
            ConfirmCollectionCommand = new DelegateCommand<string>(ExecuteConfirmCollection, CanConfirmCollection);

            AddItemsCommand = new DelegateCommand<ObservableCollection<object>>(ExecuteAddItems, CanAddItems);
            RemoveItemsCommand = new DelegateCommand<ObservableCollection<object>>(ExecuteRemoveItems, CanRemoveItems);

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsImportable)
                .Filter(_ => _.FullName.Contains(_projectManager.ActiveProject.RawDirectory))
                .Filter(x => CheckForMultiImport(x))
                .Transform(_ => new ImportableItemViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _importableItems)
                .Subscribe();

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsExportable)
                .Filter(_ => _.FullName.Contains(_projectManager.ActiveProject.ModDirectory))
                .Transform(_ => new ExportableItemViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _exportableItems)
                .Subscribe();

            this.WhenAnyValue(x => x._projectManager.ActiveProject)
                .Subscribe(project =>
                {
                    _loadedSettings = null;
                    if (project != null)
                    {
                        LoadSettings();
                    }
                });

            ImportableItems.ObserveCollectionChanges()
                .Subscribe(item => SetSetting("import", item));

            ExportableItems.ObserveCollectionChanges()
                .Subscribe(item => SetSetting("export", item));

            this.WhenAnyValue(x => x.SelectedExport, x => x.IsExportsSelected, y => y.SelectedImport, y => y.IsImportsSelected)
                .Subscribe(b =>
                {
                    var x = b.Item1;
                    var y = b.Item2;

                    SelectedObject = IsImportsSelected ? SelectedImport : SelectedExport;
                });

            this
                .WhenAnyValue(x => x._projectManager.IsProjectLoaded)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(
                    _ => ImportSettingsCommand.NotifyCanExecuteChanged());

            this.WhenAnyValue(x => x._settingsManager.ShowAdvancedOptions)
                .Subscribe(_ => ShowAdvancedOptions = _settingsManager.ShowAdvancedOptions);
        }

        private static bool CheckForMultiImport(Models.FileModel file)
        {
            // add more raw extensions here
            // example: if a masklist exists in the filelist, ignore all files in the subdirectory
            // named the same as masklist but with extension mlmask
            var directory = new FileInfo(file.FullName).Directory;
            return !directory.Name.Contains($".{ERedExtension.mlmask}");
        }

        #region properties

        [Reactive] public ObservableCollection<CollectionItemViewModel> CollectionAvailableItems { get; set; } = new();
        [Reactive] public ObservableCollection<CollectionItemViewModel> CollectionSelectedItems { get; set; } = new();

        /// <summary>
        /// Public Importable Items
        /// </summary>
        public ReadOnlyObservableCollection<ImportableItemViewModel> ImportableItems => _importableItems;

        /// <summary>
        /// Public Exportable items.
        /// </summary>
        public ReadOnlyObservableCollection<ExportableItemViewModel> ExportableItems => _exportableItems;

        /// <summary>
        /// Selected Export Item
        /// </summary>
        [Reactive] public ExportableItemViewModel SelectedExport { get; set; }

        /// <summary>
        /// Selected Import Item
        /// </summary>
        [Reactive] public ImportableItemViewModel SelectedImport { get; set; }

        /// <summary>
        /// Selected object , returns a Importable/Exportable ItemVM based on "IsImportsSelected"
        /// </summary>
        [Reactive] public ImportExportItemViewModel SelectedObject { get; set; }

        /// <summary>
        /// Lock Selection of items in grid.
        /// </summary>
        [Reactive] public bool SelectionLocked { get; set; } = false;

        [Reactive] public bool ShowAdvancedOptions { get; set; }

        /// <summary>
        /// Private NameOf Selected Item in Grid.
        /// </summary>
        private string _currentSelectionInGridName;

        /// <summary>
        /// Returns the name of current selected object in Import/Export Grid.
        /// </summary>
        public string CurrentSelectedInGridName
        {
            get
            {
                if (SelectedObject is not null)
                {
                    if (!SelectionLocked)
                    {
                        _lastselected = SelectedObject;
                        return SelectedObject.Name;
                    }
                    else
                    {
                        return _lastselected == null ? "" : _lastselected.Name;
                    }
                }
                else
                { return ""; }
            }
            set => _currentSelectionInGridName = value;
        }

        /// <summary>
        /// Is Import Selected, if false Export is default.
        /// </summary>
        [Reactive] public bool IsImportsSelected { get; set; }

        [Reactive] public bool IsExportsSelected { get; set; } = true;

        #endregion properties

        public ICommand AddItemsCommand { get; private set; }

        public ICommand RemoveItemsCommand { get; private set; }

        private bool CanAddItems(ObservableCollection<object> items) => true;

        private void ExecuteAddItems(ObservableCollection<object> items)
        {
            foreach (var item in items)
            {
                var newitem = item as CollectionItemViewModel;
                if (!CollectionSelectedItems.Contains(newitem))
                {
                    CollectionSelectedItems.Add(newitem);
                }
            }
        }

        private bool CanRemoveItems(ObservableCollection<object> items) => true;

        private void ExecuteRemoveItems(ObservableCollection<object> items)
        {
            var x = new List<CollectionItemViewModel>();
            foreach (var item in items)
            {
                var newitem = item as CollectionItemViewModel;
                x.Add(newitem);
            }
            CollectionSelectedItems.RemoveMany(x);
        }

        public ICommand ConfirmCollectionCommand { get; private set; }

        private bool CanConfirmCollection(string v) => true;

        private void ExecuteConfirmCollection(string v)
        {
            switch (SelectedObject)
            {
                case { Properties: MeshExportArgs meshExportArgs }:
                    switch (v)
                    {
                        case nameof(MeshExportArgs.MultiMeshMeshes):
                            meshExportArgs.MultiMeshMeshes =
                                CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().ToList();
                            _notificationService.Success($"Selected Meshes were added to MultiMesh arguments.");
                            meshExportArgs.meshExportType = MeshExportType.Multimesh;
                            break;

                        case nameof(MeshExportArgs.MultiMeshRigs):
                            meshExportArgs.MultiMeshRigs =
                                CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().ToList();
                            _notificationService.Success($"Selected Rigs were added to MultiMesh arguments.");
                            meshExportArgs.meshExportType = MeshExportType.Multimesh;
                            break;

                        case nameof(MeshExportArgs.Rig):
                            meshExportArgs.Rig = new List<FileEntry>() { CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().FirstOrDefault() };
                            _notificationService.Success($"Selected Rigs were added to WithRig arguments.");
                            meshExportArgs.meshExportType = MeshExportType.WithRig;
                            break;
                    }
                    break;

                case { Properties: GltfImportArgs gltfImportArgs }:
                    switch (v)
                    {
                        case nameof(GltfImportArgs.Rig):
                            gltfImportArgs.Rig = new List<FileEntry>() { CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().FirstOrDefault() };
                            _notificationService.Success($"Selected Rigs were added to WithRig arguments.");
                            gltfImportArgs.importFormat = GltfImportAsFormat.MeshWithRig;
                            break;

                        case nameof(GltfImportArgs.BaseMesh):
                            gltfImportArgs.BaseMesh = new List<FileEntry>() { CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().FirstOrDefault() };
                            _notificationService.Success($"Selected Mesh was added to Mesh arguments.");
                            gltfImportArgs.importFormat = GltfImportAsFormat.Mesh;
                            break;
                    }
                    break;


                case { Properties: OpusExportArgs opusExportArgs }:
                    switch (v)
                    {
                        case nameof(OpusExportArgs.SelectedForExport):
                            opusExportArgs.SelectedForExport =
                                new List<uint>(CollectionSelectedItems.Select(_ => _.Model).Cast<uint>());
                            _notificationService.Success($"Selected opus items were added.");
                            break;
                    }
                    break;

                default:
                    Trace.WriteLine("failed to confirm");
                    break;
            }
        }

        public ICommand SetCollectionCommand { get; private set; }

        private bool CanSetCollection(string selectedType) => true;

        private void ExecuteSetCollection(string argType)
        {
            switch (SelectedObject)
            {
                case { Properties: GltfImportArgs gltfImportArgs }:
                    InitCollectionEditorForMesh(argType, gltfImportArgs);
                    break;

                case { Properties: MeshExportArgs meshExportArgs }:
                    InitCollectionEditorForMesh(argType, meshExportArgs);
                    break;

                case { Properties: OpusExportArgs opusExportArgs }:
                    InitCollectionEditorForOpus(argType, opusExportArgs);
                    Trace.WriteLine(opusExportArgs.ModFolderPath + opusExportArgs.RawFolderPath);
                    break;
            }
        }

        private void InitCollectionEditorForMesh(string argType, ImportExportArgs args)
        {
            if (_gameController.GetController() is not RED4Controller cp77Controller)
            {
                return;
            }

            var fetchExtension = ERedExtension.mesh;
            List<FileEntry> selectedEntries = new();
            if (args is MeshExportArgs meshExportArgs)
            {
                switch (argType)
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
            }

            if (args is GltfImportArgs gltfImportArgs)
            {
                switch (argType)
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
            }

            // set selected types
            if (CollectionSelectedItems is not null)
            {
                CollectionSelectedItems.Clear();
                if (selectedEntries is not null)
                {
                    CollectionSelectedItems.AddRange(selectedEntries.Select(_ => new CollectionItemViewModel(_)));
                }
            }

            // set available types
            if (CollectionAvailableItems.Any() && CollectionAvailableItems.First().Model is FileEntry entry &&
                entry.Extension.TrimStart('.').Equals(fetchExtension.ToString()))
            {
                return;
            }

            CollectionAvailableItems.Clear();
            if (_archiveManager is not null)
            {
                CollectionAvailableItems.AddRange(_archiveManager
                    .GetGroupedFiles()[$".{fetchExtension}"]
                    .Select(_ => new CollectionItemViewModel(_))
                    .GroupBy(x => x.Name)
                    .Select(x => x.First())
                );
            }
        }

        private void InitCollectionEditorForOpus(string argType, OpusExportArgs opusExportArgs)
        {
            var proj = _projectManager.ActiveProject;

            OpusTools opusTools = new(
                proj.ModDirectory,
                proj.RawDirectory,
                opusExportArgs.UseMod);

            List<uint> selectedEntries = new();
            switch (argType)
            {
                case nameof(OpusExportArgs.SelectedForExport):
                    selectedEntries = opusExportArgs.SelectedForExport;
                    break;

                default:
                    break;
            }

            // set selected types
            if (CollectionSelectedItems is not null)
            {
                CollectionSelectedItems.Clear();
                if (selectedEntries is not null)
                {
                    CollectionSelectedItems.AddRange(selectedEntries.Select(_ => new CollectionItemViewModel(_)));
                }
            }

            // set available types
            if (CollectionAvailableItems.Any() && CollectionAvailableItems.First().Model is uint entry)
            {
                return;
            }

            CollectionAvailableItems.Clear();
            CollectionAvailableItems.AddRange(opusTools.Info.OpusHashes.Select(_ => new CollectionItemViewModel(_)));
        }

        public ICommand CopyArgumentsTemplateToCommand { get; private set; }

        private bool CanCopyArgumentsTemplateTo(string param) => true;

        private void ExecuteCopyArgumentsTemplateTo(string param)
        {
            var current = SelectedObject.Properties;

            if (IsImportsSelected)
            {
                if (current is not ImportArgs importArgs)
                {
                    return;
                }

                var json = SerializeArgs(importArgs);

                var results = param switch
                {
                    s_selectedInGrid => ImportableItems.Where(_ => _.IsChecked),
                    _ => ImportableItems
                };

                foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
                {
                    item.Properties = (ImportArgs)json.Deserialize(importArgs.GetType(), s_jsonSerializerSettings);
                }
            }
            if (IsExportsSelected)
            {
                if (current is not ExportArgs exportArgs)
                {
                    return;
                }

                var json = SerializeArgs(exportArgs);

                var results = param switch
                {
                    s_selectedInGrid => ExportableItems.Where(_ => _.IsChecked),
                    _ => ExportableItems
                };

                foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
                {
                    item.Properties = (ExportArgs)json.Deserialize(exportArgs.GetType(), s_jsonSerializerSettings);
                }
            }

            SaveSettings();
            _notificationService.Success($"Template has been copied to the selected items.");
        }

        [Reactive] public bool IsProcessing { get; set; } = false;

        /// <summary>
        /// Process all in Import / Export Grid Command.
        /// </summary>
        public ReactiveCommand<Unit, Unit> ProcessAllCommand { get; private set; }



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

            if (IsImportsSelected)
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

            if (IsExportsSelected)
            {
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
            }

            IsProcessing = false;

            _watcherService.IsSuspended = false;
            await _watcherService.RefreshAsync(_projectManager.ActiveProject).ContinueWith((result) => _progressService.IsIndeterminate = false);

            _notificationService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");
            _loggerService.Success($"{sucessful}/{total} files have been processed and are available in the Project Explorer");

            //We format the list of failed export/import items here
            if (failedItems.Count > 0)
            {
                var failedItemsErrorString = $"The following items failed:\n{String.Join("\n", failedItems)}";
                _notificationService.Error(failedItemsErrorString); //notify once only 
                _loggerService.Error(failedItemsErrorString);
            }

            _progressService.Completed();
        }

        /// <summary>
        /// Execute Process all in Import / Export Grid Command.
        /// Uses ExecuteProcessBulk
        /// </summary>
        private async Task ExecuteProcessAll()
        {
            await ExecuteProcessBulk(true); //the all parameter is set to true
        }

        /// <summary>
        /// Execute Process Selected in Import / Export Grid Command.
        /// Uses ExecuteProcessBulk
        /// </summary>
        private async Task ExecuteProcessSelected()
        {
            await ExecuteProcessBulk(); //the all parameter's default is false
        }

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
        private Task<bool> ImportSingleTask(ImportableItemViewModel item)
        {
            if (_gameController.GetController() is not RED4Controller cp77Controller)
            {
                return Task.FromResult(false);
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
                        return Task.FromResult(false);
                    }

                    reImportArgs.Depot = proj.ModDirectory;
                    reImportArgs.RedMod = Path.Combine(_settingsManager.GetRED4GameRootDir(), "tools", "redmod", "bin", "redMod.exe");
                }

                var settings = new GlobalImportArgs().Register(item.Properties as ImportArgs);
                var rawDir = new DirectoryInfo(proj.RawDirectory);
                var redrelative = new RedRelativePath(rawDir, fi.GetRelativePath(rawDir));

                return _modTools.Import(redrelative, settings, new DirectoryInfo(proj.ModDirectory));
            }

            return Task.FromResult(false);
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

        /// <summary>
        /// Process selected in Import / Export Grid Command
        /// </summary>
        public ICommand ProcessSelectedCommand { get; private set; }


        /// <summary>
        /// Setup Tool defaults for tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;

        public bool HasActiveProject => _projectManager != null
            && _projectManager.IsProjectLoaded;

        #region Commands

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
                    if (importableItem.GetModFile("xbm") is { } modFile)
                    {
                        using var fs = File.OpenRead(modFile);

                        if (_parserService.TryReadRed4File(fs, out var cr2w) && cr2w.RootChunk is CBitmapTexture bitmap)
                        {
                            xbmImportArgs.RawFormat = Enum.Parse<SupportedRawFormats>(bitmap.Setup.RawFormat.ToString());
                            xbmImportArgs.Compression = Enum.Parse<SupportedCompressionFormats>(bitmap.Setup.Compression.ToString());
                            xbmImportArgs.HasMipchain = bitmap.Setup.HasMipchain;
                            xbmImportArgs.IsGamma = bitmap.Setup.IsGamma;
                            xbmImportArgs.TextureGroup = bitmap.Setup.Group;
                            xbmImportArgs.IsStreamable = bitmap.Setup.IsStreamable;
                            xbmImportArgs.PlatformMipBiasPC = bitmap.Setup.PlatformMipBiasPC;
                            xbmImportArgs.PlatformMipBiasConsole = bitmap.Setup.PlatformMipBiasConsole;
                            xbmImportArgs.AllowTextureDowngrade = bitmap.Setup.AllowTextureDowngrade;
                            xbmImportArgs.AlphaToCoverageThreshold = bitmap.Setup.AlphaToCoverageThreshold;

                            _loggerService?.Info($"Load settings for \"{importableItem.Name}\": Loaded from project file");

                            continue;
                        }

                        _loggerService?.Warning($"Load settings for \"{importableItem.Name}\": Project file couldn't be read");
                    }

                    if (importableItem.GetArchiveFile("xbm") is { } archiveFile)
                    {
                        using var ms = new MemoryStream();
                        archiveFile.Extract(ms);

                        if (_parserService.TryReadRed4File(ms, out var cr2w) && cr2w.RootChunk is CBitmapTexture bitmap)
                        {
                            xbmImportArgs.RawFormat = Enum.Parse<SupportedRawFormats>(bitmap.Setup.RawFormat.ToString());
                            xbmImportArgs.Compression = Enum.Parse<SupportedCompressionFormats>(bitmap.Setup.Compression.ToString());
                            xbmImportArgs.HasMipchain = bitmap.Setup.HasMipchain;
                            xbmImportArgs.IsGamma = bitmap.Setup.IsGamma;
                            xbmImportArgs.TextureGroup = bitmap.Setup.Group;
                            xbmImportArgs.IsStreamable = bitmap.Setup.IsStreamable;
                            xbmImportArgs.PlatformMipBiasPC = bitmap.Setup.PlatformMipBiasPC;
                            xbmImportArgs.PlatformMipBiasConsole = bitmap.Setup.PlatformMipBiasConsole;
                            xbmImportArgs.AllowTextureDowngrade = bitmap.Setup.AllowTextureDowngrade;
                            xbmImportArgs.AlphaToCoverageThreshold = bitmap.Setup.AlphaToCoverageThreshold;

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
        private void ToggleAdvancedOptions() => _settingsManager.ShowAdvancedOptions = !_settingsManager.ShowAdvancedOptions;

        #endregion Commands

        public void LoadSettings()
        {
            var fileName = Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "ImportExportSettings.json");
            if (!File.Exists(fileName))
            {
                return;
            }

            var json = File.ReadAllText(fileName);
            _loadedSettings = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, JsonObject>>>(json, s_jsonSerializerSettings);
        }

        private void SetSetting(string type, IEventPattern<object, NotifyCollectionChangedEventArgs> item)
        {
            if (_loadedSettings == null)
            {
                return;
            }

            if (item.EventArgs.Action == NotifyCollectionChangedAction.Reset && item.Sender is IList list)
            {
                foreach (var entry in list)
                {
                    if (entry is ImportExportItemViewModel vm && _loadedSettings[type].TryGetValue(vm.GetBaseFile().RelativePath, out var args))
                    {
                        vm.Properties = (ImportExportArgs)args.Deserialize(vm.Properties.GetType(), s_jsonSerializerSettings);
                    }
                }
            }

            if (item.EventArgs.Action == NotifyCollectionChangedAction.Add && item.EventArgs.NewItems[0] is ImportExportItemViewModel vm2)
            {
                if (_loadedSettings[type].TryGetValue(vm2.GetBaseFile().RelativePath, out var args))
                {
                    vm2.Properties = (ImportExportArgs)args.Deserialize(vm2.Properties.GetType(), s_jsonSerializerSettings);
                }
            }
        }

        public void SaveSettings()
        {
            var importSettings = ImportableItems.ToDictionary(importableItem => importableItem.GetBaseFile().RelativePath, SerializeArgs);
            var exportSettings = ExportableItems.ToDictionary(exportableItem => exportableItem.GetBaseFile().RelativePath, SerializeArgs);

            var settings = new Dictionary<string, Dictionary<string, JsonObject>>
            {
                { "import", importSettings },
                { "export", exportSettings },
            };

            var json = JsonSerializer.Serialize(settings, s_jsonSerializerSettings);
            File.WriteAllText(Path.Combine(_projectManager.ActiveProject.ProjectDirectory, "ImportExportSettings.json"), json);
        }

        private JsonObject SerializeArgs(ImportExportItemViewModel vm) => SerializeArgs(vm.Properties);
        private JsonObject SerializeArgs(ImportExportArgs args)
        {
            var node = (JsonObject)JsonSerializer.SerializeToNode(args, args.GetType(), s_jsonSerializerSettings);

            node.Remove("Changing");
            node.Remove("Changed");
            node.Remove("ThrownExceptions");

            return node;
        }
    }
}
