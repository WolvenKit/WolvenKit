using System;
using System.Collections.Generic;
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
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Functionality.Helpers;
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



        public ExportableItemViewModel SelectedExport { get; set; }

        public ImportableItemViewModel SelectedImport { get; set; }

        public ImportExportItemViewModel SelectedObject => IsImportsSelected
            ? SelectedImport
            : SelectedExport;


        public string CurrentSelectedInGridName { get; set; }


        /// <summary>
        /// Private Logger service.
        /// </summary>
        private readonly ILoggerService _loggerService;

        /// <summary>
        /// Private Message Service
        /// </summary>
        private readonly IMessageService _messageService;

        /// <summary>
        /// Private Project Manager Service
        /// </summary>
        private readonly IProjectManager _projectManager;

        /// <summary>
        /// Private Watcher Service
        /// </summary>
        private readonly IWatcherService _watcherService;

        /// <summary>
        /// Private Readonly ModTools
        /// </summary>
        private readonly ModTools _modTools;

        /// <summary>
        /// Import Export ViewModel Constructor
        /// </summary>
        /// <param name="projectManager"></param>
        /// <param name="loggerService"></param>
        /// <param name="messageService"></param>
        /// <param name="watcherService"></param>
        /// <param name="modTools"></param>
        public ImportExportViewModel(
           IProjectManager projectManager,
           ILoggerService loggerService,
           IMessageService messageService,
           IWatcherService watcherService,
           ModTools modTools
           ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => watcherService);
            Argument.IsNotNull(() => modTools);


            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _watcherService = watcherService;
            _modTools = modTools;

            SetupToolDefaults();


            ProcessAllCommand = new RelayCommand(ExecuteProcessAll, CanProcessAll);
            ProcessSelectedCommand = new RelayCommand(ExecuteProcessSelected, CanProcessSelected);

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsImportable)
                .Transform(_ => new ImportableItemViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _importableItems)
                .Subscribe();

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsExportable)
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
                    var fi = new FileInfo(item.FullName);
                    if (fi.Exists)
                    {
                        _modTools.Import(fi, item.Properties as ImportArgs);
                    }
                }
            }
            else
            {
                foreach (var item in ExportableItems)
                {
                    var fi = new FileInfo(item.FullName);
                    if (fi.Exists)
                    {
                        _modTools.Export(fi, item.Properties as ExportArgs);
                    }
                }

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
                    var fi = new FileInfo(item.FullName);
                    if (fi.Exists)
                    {
                        _modTools.Import(fi, item.Properties as ImportArgs);
                    }
                }
            }
            else
            {
                foreach (var item in ExportableItems.Where(_ => _.IsChecked))
                {
                    var fi = new FileInfo(item.FullName);
                    if (fi.Exists)
                    {
                        _modTools.Export(fi, item.Properties as ExportArgs);
                    }
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



        // Define a unique contentid for this toolwindow
        //BitmapImage bi = new BitmapImage();
        // Define an icon for this toolwindow
        //bi.BeginInit();
        //bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");
        //bi.EndInit();
        //IconSource = bi;

    }



    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ObservableObject
    {
        protected FileModel BaseFile { get; set; }

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

        public string Extension => BaseFile.Extension;
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

            _ = Enum.TryParse(model.Extension.TrimStart('.'), out ERawFileFormat Extension);

            switch (Extension)
            {
                case ERawFileFormat.tga:
                case ERawFileFormat.dds:
                    return new XbmImportArgs();
                case ERawFileFormat.fbx:
                    return new CommonImportArgs();
                default:
                    throw new ArgumentOutOfRangeException();
            }
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

            _ = Enum.TryParse(model.Extension.TrimStart('.'), out ECookedFileFormat Extension);

            switch (Extension)
            {
                case ECookedFileFormat.mesh:
                    return new MeshExportArgs();
                case ECookedFileFormat.xbm:
                    return new XbmExportArgs();
                case ECookedFileFormat.wem:
                    return new WemExportArgs();
                case ECookedFileFormat.csv:
                case ECookedFileFormat.json:
                case ECookedFileFormat.mlmask:
                case ECookedFileFormat.cubemap:
                case ECookedFileFormat.envprobe:
                case ECookedFileFormat.texarray:
                    return new CommonExportArgs();
                case ECookedFileFormat.morphtarget:
                    return new MorphTargetExportArgs();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }



}
