using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Linq;
using Catel;
using Catel.MVVM;
using Catel.Services;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Models.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.CR2W.Archive;
using ModTools = WolvenKit.Modkit.RED4.ModTools;
using Orchestra.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using System.Collections.Generic;
using System.Diagnostics;
using WolvenKit.Common.Extensions;
using WolvenKit.Modkit.RED4.Opus;

namespace WolvenKit.ViewModels.Editor
{
    public class ImportExportViewModel : ToolViewModel
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
        private readonly ModTools _modTools;

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IGrowlNotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly IWatcherService _watcherService;
        private readonly IGameControllerFactory _gameController;

        /// <summary>
        /// Private NameOf Selected Item in Grid.
        /// </summary>
        private string _CurrentSelectionInGridName;

        /// <summary>
        /// Private Last Selected Item, Used for Selection Lock.
        /// </summary>
        private ImportExportItemViewModel lastselected;

        /// <summary>
        /// Private Importable Items
        /// </summary>
        private readonly ReadOnlyObservableCollection<ImportableItemViewModel> _importableItems;

        /// <summary>
        /// Private Exportable Items
        /// </summary>
        private readonly ReadOnlyObservableCollection<ExportableItemViewModel> _exportableItems;

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
           IMessageService messageService,
           IWatcherService watcherService,
           IGrowlNotificationService notificationService,
           IGameControllerFactory gameController,
           ModTools modTools
           ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => watcherService);
            Argument.IsNotNull(() => modTools);
            Argument.IsNotNull(() => gameController);
            Argument.IsNotNull(() => notificationService);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _watcherService = watcherService;
            _modTools = modTools;
            _gameController = gameController;
            _notificationService = notificationService;

            SetupToolDefaults();

            ProcessAllCommand = new TaskCommand(ExecuteProcessAll, CanProcessAll);
            ProcessSelectedCommand = new TaskCommand(ExecuteProcessSelected, CanProcessSelected);
            CopyArgumentsTemplateToCommand = new DelegateCommand<string>(ExecuteCopyArgumentsTemplateTo, CanCopyArgumentsTemplateTo);
            SetCollectionCommand = new DelegateCommand<string>(ExecuteSetCollection, CanSetCollection);
            ConfirmMeshCollectionCommand = new DelegateCommand<string>(ExecuteConfirmMeshCollection, CanConfirmMeshCollection);

            AddItemsCommand = new DelegateCommand<ObservableCollection<object>>(ExecuteAddItems, CanAddItems);
            RemoveItemsCommand = new DelegateCommand<ObservableCollection<object>>(ExecuteRemoveItems, CanRemoveItems);

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsImportable)
                .Filter(_ => _.FullName.Contains(_projectManager.ActiveProject.RawDirectory))
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
        }

        #region properties

        public ObservableCollection<CollectionItemViewModel> CollectionAvailableItems { get; set; } = new();
        public ObservableCollection<CollectionItemViewModel> CollectionSelectedItems { get; set; } = new();

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
        public ExportableItemViewModel SelectedExport { get; set; }

        /// <summary>
        /// Selected Import Item
        /// </summary>
        public ImportableItemViewModel SelectedImport { get; set; }

        /// <summary>
        /// Selected object , returns a Importable/Exportable ItemVM based on "IsImportsSelected"
        /// </summary>
        public ImportExportItemViewModel SelectedObject => IsImportsSelected ? SelectedImport : SelectedExport;

        public bool? IsHeaderChecked { get; set; }

        /// <summary>
        /// Lock Selection of items in grid.
        /// </summary>
        public bool SelectionLocked { get; set; } = false;

        /// <summary>
        /// Returns the name of current selected object in Import/Export Grid.
        /// </summary>
        public string CurrentSelectedInGridName
        {
            get
            {
                if (SelectedObject != null)
                {
                    if (!SelectionLocked)
                    {
                        lastselected = SelectedObject;
                        return SelectedObject.Name;
                    }
                    else
                    {
                        if (lastselected == null)
                        { return ""; }
                        else
                        {
                            return lastselected.Name;
                        }
                    }
                }
                else
                { return ""; }
            }
            set => _CurrentSelectionInGridName = value;
        }

        /// <summary>
        /// Is Import Selected, if false Export is default.
        /// </summary>
        public bool IsImportsSelected { get; set; }

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

        public ICommand ConfirmMeshCollectionCommand { get; private set; }

        private bool CanConfirmMeshCollection(string v) => true;

        private void ExecuteConfirmMeshCollection(string v)
        {
            if (SelectedExport is not { Properties: MeshExportArgs meshExportArgs } ||
                _gameController.GetController() is not Cp77Controller cp77Controller)
            {
                Trace.WriteLine("failed to confirm");

                return;
            }

            // set mesh props
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

                default:
                    break;
            }
        }

        public ICommand SetCollectionCommand { get; private set; }

        private bool CanSetCollection(string selectedType) => true;

        private void InitCollectionEditorForMesh(string argType, MeshExportArgs meshExportArgs)
        {
            if (_gameController.GetController() is not Cp77Controller cp77Controller)
            {
                return;
            }

            var fetchExtension = ERedExtension.rig;
            List<FileEntry> selectedEntries = new();
            switch (argType)
            {
                case nameof(MeshExportArgs.MultiMeshMeshes):
                    fetchExtension = ERedExtension.mesh;
                    selectedEntries = meshExportArgs.MultiMeshMeshes;
                    break;

                case nameof(MeshExportArgs.MultiMeshRigs):
                    selectedEntries = meshExportArgs.MultiMeshRigs;
                    break;

                case nameof(MeshExportArgs.Rig):
                    selectedEntries = meshExportArgs.Rig;
                    break;

                default:
                    break;
            }

            // set selected types
            if (CollectionSelectedItems != null)
            {
                CollectionSelectedItems.Clear();
                if (selectedEntries != null)
                {
                    CollectionSelectedItems.AddRange(selectedEntries.Select(_ => new CollectionItemViewModel(_)));
                }
            }

            //// set available types

            //if (CollectionAvailableItems.Any() && CollectionAvailableItems.FirstOrDefault().Extension.TrimStart('.').Equals(fetchExtension.ToString()))
            //{
            //    return;
            //}

            var archivemanager = cp77Controller.GetArchiveManagersManagers(false).First() as ArchiveManager;
            CollectionAvailableItems.Clear();
            if (archivemanager != null)
            {
                CollectionAvailableItems.AddRange(archivemanager.GroupedFiles[$".{fetchExtension}"].Select(_ => new CollectionItemViewModel(_)));
            }
        }

        private void InitCollectionEditorForOpus(string argType, OpusExportArgs opusExportArgs)
        {
            var proj = _projectManager.ActiveProject;

            if (_gameController.GetController() is Cp77Controller cp77Controller)
            {
                var archivemanager = cp77Controller.GetArchiveManagersManagers(false).First() as ArchiveManager;
                opusExportArgs.SoundbanksArchive = archivemanager.Archives.Values
                    .Cast<Archive>()
                    .FirstOrDefault(_ => _.Name.Equals("audio_2_soundbanks.archive"));
            }

            OpusTools opusTools = new(
                opusExportArgs.SoundbanksArchive,
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
            if (CollectionSelectedItems != null)
            {
                CollectionSelectedItems.Clear();
                if (selectedEntries != null)
                {
                    CollectionSelectedItems.AddRange(selectedEntries.Select(_ => new CollectionItemViewModel(_)));
                }
            }

            CollectionAvailableItems.AddRange(opusTools._info.OpusHashes.Select(_ => new CollectionItemViewModel(_)));
        }

        private void ExecuteSetCollection(string argType)
        {
            switch (SelectedExport)
            {
                case { Properties: MeshExportArgs meshExportArgs }:
                    InitCollectionEditorForMesh(argType, meshExportArgs);

                    break;

                case { Properties: OpusExportArgs opusExportArgs }:
                    InitCollectionEditorForOpus(argType, opusExportArgs);
                    Trace.WriteLine(opusExportArgs.ModFolderPath + opusExportArgs.RawFolderPath);
                    break;
            }
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

                var results = param switch
                {
                    s_selectedInGrid => ImportableItems.Where(_ => _.IsChecked),
                    _ => ImportableItems
                };

                foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
                {
                    item.Properties = importArgs;
                }
            }
            else
            {
                if (current is not ExportArgs exportArgs)
                {
                    return;
                }

                var results = param switch
                {
                    s_selectedInGrid => ExportableItems.Where(_ => _.IsChecked),
                    _ => ExportableItems
                };

                foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
                {
                    item.Properties = exportArgs;
                }
            }
            _notificationService.Success($"Template has been copied to the selected items.");
        }

        public bool IsProcessing { get; set; } = false;

        /// <summary>
        /// Process all in Import / Export Grid Command.
        /// </summary>
        public ICommand ProcessAllCommand { get; private set; }

        /// <summary>
        /// Can Process all Bool
        /// </summary>
        /// <returns>bool</returns>
        private bool CanProcessAll() => true;

        /// <summary>
        /// Execute Process all in Import / Export Grid Command.
        /// </summary>
        private async Task ExecuteProcessAll()
        {
            IsProcessing = true;

            if (IsImportsSelected)
            {
                foreach (var item in ImportableItems)
                {
                    await ImportSingle(item);
                }
            }
            else
            {
                foreach (var item in ExportableItems)
                {
                    await ExportSingle(item);
                }
            }
            IsProcessing = false;
            _notificationService.Success($"Files have been processed and are available in the Project Explorer");
        }

        /// <summary>
        /// Import Single item
        /// </summary>
        /// <param name="item"></param>
        private async Task ImportSingle(ImportableItemViewModel item)
        {
            var proj = _projectManager.ActiveProject;
            var fi = new FileInfo(item.FullName);
            if (fi.Exists)
            {
                if (item.Properties is MeshImportArgs meshImportArgs)
                {
                    if (_gameController.GetController() is Cp77Controller cp77Controller)
                    {
                        var archivemanager = cp77Controller.GetArchiveManagersManagers(false).First() as ArchiveManager;
                        var archives = archivemanager.Archives.Values.Cast<Archive>().ToList();
                        foreach (var ar in archives)
                        {
                            var name = Path.GetFileNameWithoutExtension(ar.ArchiveAbsolutePath);
                            if (name == "basegame_4_gamedata")
                            {
                                meshImportArgs.archive = ar;
                                break;
                            }
                        }
                    }
                }
                var settings = new GlobalImportArgs().Register(item.Properties as ImportArgs);
                var rawDir = new DirectoryInfo(proj.RawDirectory);
                var redrelative = new RedRelativePath(rawDir, fi.GetRelativePath(rawDir));
                await Task.Run(() => _modTools.Import(redrelative, settings, new DirectoryInfo(proj.ModDirectory)));
            }
        }

        /// <summary>
        /// Export Single Item
        /// </summary>
        /// <param name="item"></param>
        private async Task ExportSingle(ExportableItemViewModel item)
        {
            var proj = _projectManager.ActiveProject;
            var fi = new FileInfo(item.FullName);
            if (fi.Exists)
            {
                if (item.Properties is MeshExportArgs meshExportArgs)
                {
                    if (_gameController.GetController() is Cp77Controller cp77Controller)
                    {
                        var archivemanager = cp77Controller.GetArchiveManagersManagers(false).First() as ArchiveManager;
                        meshExportArgs.Archives = archivemanager.Archives.Values.Cast<Archive>().ToList();
                    }
                }
                if (item.Properties is OpusExportArgs opusExportArgs)
                {
                    if (_gameController.GetController() is Cp77Controller cp77Controller)
                    {
                        var archivemanager = cp77Controller.GetArchiveManagersManagers(false).First() as ArchiveManager;
                        opusExportArgs.SoundbanksArchive = archivemanager.Archives.Values
                            .Cast<Archive>()
                            .FirstOrDefault(_ => _.Name.Equals("audio_2_soundbanks.archive"));
                    }

                    opusExportArgs.RawFolderPath = proj.RawDirectory;
                    opusExportArgs.ModFolderPath = proj.ModDirectory;
                }

                var settings = new GlobalExportArgs().Register(item.Properties as ExportArgs);
                await Task.Run(() => _modTools.Export(fi, settings,
                    new DirectoryInfo(proj.ModDirectory),
                    new DirectoryInfo(proj.RawDirectory)));
            }
        }

        /// <summary>
        /// Process selected in Import / Export Grid Command
        /// </summary>
        public ICommand ProcessSelectedCommand { get; private set; }

        /// <summary>
        /// Can Process Selected Bool.
        /// </summary>
        /// <returns>bool</returns>
        private bool CanProcessSelected() => true;

        /// <summary>
        /// Execute Process selected in Import / Export Grid Command
        /// </summary>
        private async Task ExecuteProcessSelected()
        {
            IsProcessing = true;
            if (IsImportsSelected)
            {
                foreach (var item in ImportableItems.Where(_ => _.IsChecked))
                {
                    await ImportSingle(item);
                }
            }
            else
            {
                foreach (var item in ExportableItems.Where(_ => _.IsChecked))
                {
                    await ExportSingle(item);
                }
            }
            IsProcessing = false;
            _notificationService.Success($"Files have been processed and are available in the Project Explorer");
        }

        /// <summary>
        /// Close Async
        /// </summary>
        /// <returns></returns>
        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events
            base.CloseAsync();

        /// <summary>
        /// Initialize Async
        /// </summary>
        /// <returns></returns>
        protected override async Task InitializeAsync() =>
            // TODO: Write initialization code here and subscribe to events
            await base.InitializeAsync();

        /// <summary>
        /// Setup Tool defaults for tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;
    }

    public class CollectionItemViewModel : ObservableObject
    {
        public string Info =>
            Model switch
            {
                FileEntry fe => fe.Name,
                _ => ""
            };

        public string Name =>
            Model switch
            {
                FileEntry fe => fe.ShortName,
                _ => Model.ToString()
            };

        public CollectionItemViewModel(object model)
        {
            Model = model;
        }

        public object Model { get; set; }
    }
}
