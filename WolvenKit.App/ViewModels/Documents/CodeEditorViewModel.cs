using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using ReactiveUI.Fody.Helpers;
using Syncfusion.Windows.Edit;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Tools
{
    public class CodeEditorViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "CodeEditor_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Code Editor";

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;

        #endregion Fields

        #region Constructors

        public CodeEditorViewModel(
           IProjectManager projectManager,
           ILoggerService loggerService) : base(ToolTitle)
        {

            _projectManager = projectManager;
            _loggerService = loggerService;
            SetupToolDefaults();

            SelectedFont = new FontFamily("Verdana");
            IsChecked = false;
            Language = Languages.C;
            sampleCommand = new DelegateCommand<object>(ExecuteSampleCommand);
        }

        #endregion Constructors

        #region Properties

        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;

        #endregion Properties

        #region Methods

        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion Methods

        /// <summary>
        /// Maintains the command for code samples
        /// </summary>
        private ICommand sampleCommand;

        /// <summary>
        /// Initializes the instance of the <see cref="SyntaxHighlightingViewModel"/> class
        /// </summary>
      

        /// <summary>
        /// Gets or sets the command for code sample 1 in menu items
        /// </summary>
        public ICommand SampleCommand
        {
            get
            {
                return sampleCommand;
            }
        }

        /// <summary>
        /// Gets or sets the command for code sample for checked property.
        /// </summary>
        [Reactive] public bool IsChecked { get; set; }

        /// <summary>
        /// Gets or sets the document source of the edit control
        /// </summary>
        [Reactive] public string DocumentSource { get; set; }

        /// <summary>
        /// Gets or sets the langugae of the content to be displayed in the edit control
        /// </summary>
        [Reactive] public Languages Language { get; set; }

        /// <summary>
        /// Gets or sets the font family for the content to  be displayed in the edit control
        /// </summary>
        [Reactive] public FontFamily SelectedFont { get; set; }

        /// <summary>
        /// Method toe execute code samples
        /// </summary>
        /// <param name="param">Speicfies the object paramter</param>
        private void ExecuteSampleCommand(object param)
        {
            string choice = (param as ComboBoxAdv).SelectedItem.ToString();
            if (choice == "C")
            {
                Language = Languages.C;
            }
            else if (choice == "CSharp")
            {
                Language = Languages.CSharp;
            }
            else if (choice == "Delphi")
            {
                Language = Languages.Delphi;
            }
            else if (choice == "HTML")
            {
                Language = Languages.HTML;
            }
            else if (choice == "Java")
            {
                Language = Languages.Java;
            }
            else if (choice == "JScript")
            {
                Language = Languages.JScript;
            }
            else if (choice == "PowerShell")
            {
                Language = Languages.PowerShell;
            }
            else if (choice == "SQL")
            {
                Language = Languages.SQL;
            }
            else if (choice == "VBScript")
            {
                Language = Languages.VBScript;
            }
            else if (choice == "VisualBasic")
            {
                Language = Languages.VisualBasic;
            }
            else if (choice == "XAML")
            {
                Language = Languages.XAML;
            }
            else
            {
                Language = Languages.XML;
            }
        }

    }
}
