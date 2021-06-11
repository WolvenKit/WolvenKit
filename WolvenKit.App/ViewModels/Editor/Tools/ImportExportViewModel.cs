using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Linq;
using Catel;
using Catel.Services;
using CP77.CR2W;
using DynamicData;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.CR2W.Archive;
using ModTools = WolvenKit.Modkit.RED4.ModTools;
using ObservableObject = Catel.Data.ObservableObject;

namespace WolvenKit.ViewModels.Editor
{
    public class ImportExportViewModel : ToolViewModel
    {
        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "ImportExport_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Import Export Tool";

        /// <summary>
        /// Private Importable Items
        /// </summary>
        private readonly ReadOnlyObservableCollection<ImportableItemViewModel> _importableItems;

        /// <summary>
        /// Public Importable Items
        /// </summary>
        public ReadOnlyObservableCollection<ImportableItemViewModel> ImportableItems => _importableItems;

        /// <summary>
        /// Private Exportable Items
        /// </summary>
        private readonly ReadOnlyObservableCollection<ExportableItemViewModel> _exportableItems;

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
        /// Private NameOf Selected Item in Grid.
        /// </summary>
        private string _CurrentSelectionInGridName;

        /// <summary>
        /// Private Last Selected Item, Used for Selection Lock.
        /// </summary>
        private ImportExportItemViewModel lastselected;

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
            set { _CurrentSelectionInGridName = value; }
        }

        /// <summary>
        /// Private Readonly ModTools
        /// </summary>
        private readonly ModTools _modTools;

        /// <summary>
        /// Private Logger Service
        /// </summary>
        private readonly ILoggerService _loggerService;

        /// <summary>
        /// Private Message Service
        /// </summary>
        private readonly IMessageService _messageService;

        /// <summary>
        /// Private Project Manager
        /// </summary>
        private readonly IProjectManager _projectManager;

        /// <summary>
        /// Private WatcherService
        /// </summary>
        private readonly IWatcherService _watcherService;

        /// <summary>
        /// Private GameController
        /// </summary>
        private readonly IGameControllerFactory _gameController;

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

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _watcherService = watcherService;
            _modTools = modTools;
            _gameController = gameController;

            SetupToolDefaults();

            ProcessAllCommand = new RelayCommand(ExecuteProcessAll, CanProcessAll);
            ProcessSelectedCommand = new RelayCommand(ExecuteProcessSelected, CanProcessSelected);

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

        /// <summary>
        /// Is Import Selected, if false Export is default.
        /// </summary>
        public bool IsImportsSelected { get; set; }

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
        private void ExecuteProcessAll()
        {
            if (IsImportsSelected)
            {
                foreach (var item in ImportableItems)
                {
                    ImportSingle(item);
                }
            }
            else
            {
                foreach (var item in ExportableItems)
                {
                    ExportSingle(item);
                }
            }
        }

        /// <summary>
        /// Import Single item
        /// </summary>
        /// <param name="item"></param>
        private void ImportSingle(ImportableItemViewModel item)
        {
            var proj = _projectManager.ActiveProject;
            var fi = new FileInfo(item.FullName);
            if (fi.Exists)
            {
                var settings = new GlobalImportArgs().Register(item.Properties as ImportArgs);
                _modTools.Import(fi, settings, new DirectoryInfo(proj.ModDirectory));
            }
        }

        /// <summary>
        /// Export Single Item
        /// </summary>
        /// <param name="item"></param>
        private void ExportSingle(ExportableItemViewModel item)
        {
            var proj = _projectManager.ActiveProject;
            var fi = new FileInfo(item.FullName);
            if (fi.Exists)
            {
                if (item.Properties is MeshExportArgs meshExportArgs)
                {
                    var cp77controller = _gameController.GetController() as Cp77Controller;
                    var archivemanager = cp77controller.GetArchiveManagersManagers(false).First() as ArchiveManager;
                    meshExportArgs.Archives = archivemanager.Archives.Values.Cast<Archive>().ToList();
                }

                var settings = new GlobalExportArgs().Register(item.Properties as ExportArgs);
                _modTools.Export(fi, settings, new DirectoryInfo(proj.ModDirectory), new DirectoryInfo(proj.RawDirectory));
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
        private void ExecuteProcessSelected()
        {
            if (IsImportsSelected)
            {
                foreach (var item in ImportableItems.Where(_ => _.IsChecked))
                {
                    ImportSingle(item);
                }
            }
            else
            {
                foreach (var item in ExportableItems.Where(_ => _.IsChecked))
                {
                    ExportSingle(item);
                }
            }
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

    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ObservableObject
    {
        /// <summary>
        /// BaseFile "FileModel"
        /// </summary>
        protected FileModel BaseFile { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        public ImportExportArgs Properties
        {
            get => _properties;
            set
            {
                if (_properties != value)
                {
                    var oldValue = _properties;
                    _properties = value;
                    RaisePropertyChanged(() => Properties, oldValue, value);
                    RaisePropertyChanged(() => ExportTaskIdentifier);
                }
            }
        }

        private ImportExportArgs _properties;

        public string ExportTaskIdentifier => Properties.ToString();

        public string Extension => BaseFile.GetExtension();
        public string FullName => BaseFile.FullName;
        public string Name => BaseFile.Name;

        public bool IsChecked { get; set; }

        public EExportState ExportState => BaseFile.IsImportable ? EExportState.Importable : EExportState.Exportable;
    }

    public class ImportableItemViewModel : ImportExportItemViewModel
    {
        public ImportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideImportOptions(model);
        }

        private ImportArgs DecideImportOptions(FileModel model)
        {
            _ = Enum.TryParse(model.GetExtension(), out ERawFileFormat rawFileFormat);

            return rawFileFormat switch
            {
                ERawFileFormat.tga => new XbmImportArgs(),
                ERawFileFormat.dds => new XbmImportArgs(),
                ERawFileFormat.fbx => new CommonImportArgs(),
                ERawFileFormat.glb => new MeshImportArgs(),
                ERawFileFormat.gltf => new MeshImportArgs(),
                _ => new CommonImportArgs()
            };
        }
    }

    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideExportOptions(model);
        }

        private ExportArgs DecideExportOptions(FileModel model)
        {
            _ = Enum.TryParse(model.GetExtension(), out ECookedFileFormat fileFormat);

            return fileFormat switch
            {
                ECookedFileFormat.mesh => new MeshExportArgs(),
                ECookedFileFormat.xbm => new XbmExportArgs(),
                ECookedFileFormat.wem => new WemExportArgs(),
                ECookedFileFormat.csv => new CommonExportArgs(),
                //ECookedFileFormat.json => new CommonExportArgs(),
                ECookedFileFormat.mlmask => new CommonExportArgs(),
                ECookedFileFormat.cubemap => new CommonExportArgs(),
                ECookedFileFormat.envprobe => new CommonExportArgs(),
                ECookedFileFormat.texarray => new CommonExportArgs(),
                ECookedFileFormat.morphtarget => new MorphTargetExportArgs(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
