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

namespace WolvenKit.ViewModels.Editor
{
    public class ImportExportViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "ImportExport_Tool";

        private readonly ReadOnlyObservableCollection<ImportableItemViewModel> _importableItems;
        public ReadOnlyObservableCollection<ImportableItemViewModel> ImportableItems => _importableItems;

        private readonly ReadOnlyObservableCollection<ExportableItemViewModel> _exportableItems;
        public ReadOnlyObservableCollection<ExportableItemViewModel> ExportableItems => _exportableItems;


        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Import Export Tool";

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;
        private readonly IWatcherService _watcherService;
        private readonly ModTools _modTools;

        #endregion Fields

        #region Constructors

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

        #endregion Constructors

        public bool IsImportsSelected { get; set; }

        #region Commands

        public ICommand ProcessAllCommand { get; private set; }
        private bool CanProcessAll() => true;

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

        public ICommand ProcessSelectedCommand { get; private set; }
        private bool CanProcessSelected() => true;

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


        #endregion Properties

        #region Methods

        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events

            base.CloseAsync();

        protected override async Task InitializeAsync() => await base.InitializeAsync();// TODO: Write initialization code here and subscribe to events

        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion Methods
    }



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
        }





        // make this data
        public EUncookExtension UncookExtension { get; set; }
        public bool Flip { get; set; }
    }



    public abstract class ImportExportProperties
    {
        public ImportExportType ImportExportType {get;set;}
    }

    public class ExportMeshWithoutRigPGModel
    {
        public MeshExportOption MeshExportOption { get; set; }
    }


    public enum ImportExportType
    {
        Simple,
        Advanced
    }

    public enum MeshExportOption
    {
        WithPlaceHolderRig,
        WithoutRig,
        MultiMeshWithRig,
        MeshWithRig,
        MultiMeshWithoutRigh,
        MeshWithMaterials
    }
}
