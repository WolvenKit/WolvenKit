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

        private readonly ReadOnlyObservableCollection<ImportExportItemViewModel> _bindGrid;
        

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
            ProcessImportsCommand = new RelayCommand(ExecuteProcessImports, CanProcessImports);
            ProcessExportsCommand = new RelayCommand(ExecuteProcessExports, CanProcessExports);

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsImportable || _.IsExportable)
                .Transform(_ => _.IsExportable ? new ExportableItemViewModel(_)
                    : new ImportableItemViewModel(_) as ImportExportItemViewModel)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _bindGrid)
                .Subscribe();

        }

        #endregion Constructors
        public ReadOnlyObservableCollection<ImportExportItemViewModel> Items => _bindGrid;

        public IEnumerable<ImportableItemViewModel> ImportableFiles => _bindGrid
            .Where(_ => _.ExportState == EExportState.Importable)
            .Cast<ImportableItemViewModel>();
        public IEnumerable<ExportableItemViewModel> ExportableFiles => _bindGrid
            .Where(_ => _.ExportState == EExportState.Exportable)
            .Cast<ExportableItemViewModel>();


        #region Commands

        public ICommand ProcessAllCommand { get; private set; }
        private bool CanProcessAll() => true;

        private void ExecuteProcessAll()
        {
            
        }

        public ICommand ProcessSelectedCommand { get; private set; }
        private bool CanProcessSelected()
        {
            return true;
        }
        private void ExecuteProcessSelected()
        {
            // TODO: Handle command logic here
        }

        public ICommand ProcessExportsCommand { get; private set; }
        private bool CanProcessExports() => true;

        private void ExecuteProcessExports()
        {
            foreach (var exportableFile in ExportableFiles)
            {
                
            }
        }

        public ICommand ProcessImportsCommand { get; private set; }
        private bool CanProcessImports()
        {
            return true;
        }

        private void ExecuteProcessImports()
        {
            // TODO: Handle command logic here
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

    }
    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(FileModel model)
        {
            BaseFile = model;
        }

    }



    public abstract class ImportExportProperties
    {

    }

    public class ImportProperties : ImportExportProperties
    {
    }

    public class ExportProperties : ImportExportProperties
    {
        public bool HasSpecialOptions { get; set; }



        public ExportProperties()
        {

        }
        public void DecideExportType()
        {

        }

        public string test1;
    }
}
