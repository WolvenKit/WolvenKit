using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Catel;
using Catel.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Editor
{
    public class ImportExportViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "ImportExport_Tool";
        public ObservableCollection<FileModel> BindGrid1 { get; set; } = new();


        public ObservableCollection<ImportFile> ImportCollection { get; set; } = new();
        public ObservableCollection<ExportFile> ExportCollection { get; set; } = new();

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Import Export Tool";

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;

        #endregion Fields

        #region Constructors

        public ImportExportViewModel(
           IProjectManager projectManager,
           ILoggerService loggerService,
           IMessageService messageService) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            SetupToolDefaults();
        }

        #endregion Constructors

        #region Properties

        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        #endregion Properties

        #region Methods

        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events

            base.CloseAsync();

        protected override async Task InitializeAsync() => await base.InitializeAsync();// TODO: Write initialization code here and subscribe to events

        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion Methods
    }



    public class ImportFile
    {
        public FileModel BaseFile { get; set; }
        public FileImportProperties ImportProperties { get; set; }

    }

    public class FileImportProperties
    {
    }

    public class ExportFile
    {
        public FileModel BaseFile { get; set; }
        public FileExportProperties ExportProperties { get; set; }
    }

    public class FileExportProperties
    {
        public bool HasSpecialOptions { get; set; }



        public FileExportProperties()
        {

        }
        public void DecideExportType()
        {

        }

        public string test1;
    }
}
