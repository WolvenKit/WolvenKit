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
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Functionality.Helpers;

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
                        _modTools.Import(fi, item.TextureGroup);
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
                        _modTools.Export(fi, item.UncookExtension, item.Flip);
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
                        _modTools.Import(fi, item.TextureGroup);
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
                        _modTools.Export(fi, item.UncookExtension, item.Flip);
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
    public abstract class ImportExportItemViewModel
    {
        protected FileModel BaseFile { get; set; }

        public ImportExportProperties Properties { get; set; }

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
        }

        // data
        public object TextureGroup { get; internal set; }


    }
    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(FileModel model)
        {
            BaseFile = model;

            ExportTaskIdentifier = DecideDefaultExport(model);
        }

        public string ExportTaskIdentifier { get; set; }



        // make this data
        public EUncookExtension UncookExtension { get; set; }
        public bool Flip { get; set; }


        private string DecideDefaultExport(FileModel input)
        {
            var ie = input.Extension;
            var deftext = "Default - ";
            if (ie == ".morphtarget")
            {
                return deftext + "GLTF/GLB";
            }
            if (ie == ".mesh")
            {
                return deftext + "GLTF/GLB";
            }
            if (ie == ".XBM")
            {
                return deftext + "DDS";
            }
            if (ie == ".wem")
            {
                return deftext + "WAV";
            }
            return "";
        }
    }



    public abstract class ImportExportProperties
    {
    }







}
