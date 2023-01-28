using System.Windows.Input;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Commands;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Tools
{
    public partial class CodeEditorViewModel : ToolViewModel
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

        public CodeEditorViewModel(IProjectManager projectManager, ILoggerService loggerService) : base(ToolTitle)
        {

            _projectManager = projectManager;
            _loggerService = loggerService;
            SetupToolDefaults();

            _selectedFont = new FontFamily("Verdana");
            IsChecked = false;
            //Language = Languages.C;
            SampleCommand = new DelegateCommand<object>(ExecuteSampleCommand);
        }

        #endregion Constructors

        #region Methods

        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion Methods

        /// <summary>
        /// Maintains the command for code samples
        /// </summary>

        /// <summary>
        /// Initializes the instance of the <see cref="SyntaxHighlightingViewModel"/> class
        /// </summary>


        /// <summary>
        /// Gets or sets the command for code sample 1 in menu items
        /// </summary>
        public ICommand SampleCommand { get; }

        /// <summary>
        /// Gets or sets the command for code sample for checked property.
        /// </summary>
        [ObservableProperty] private bool _isChecked;

        /// <summary>
        /// Gets or sets the document source of the edit control
        /// </summary>
        [ObservableProperty] private string? _documentSource;

        ///// <summary>
        ///// Gets or sets the langugae of the content to be displayed in the edit control
        ///// </summary>
        // [ObservableProperty] private Languages _language;

        /// <summary>
        /// Gets or sets the font family for the content to  be displayed in the edit control
        /// </summary>
        [ObservableProperty] private FontFamily _selectedFont;

        /// <summary>
        /// Method toe execute code samples
        /// </summary>
        /// <param name="param">Speicfies the object paramter</param>
        private void ExecuteSampleCommand(object param)
        {
            //string choice = (param as ComboBoxAdv).SelectedItem.ToString();
            //if (choice == "C")
            //{
            //    Language = Languages.C;
            //}
            //else if (choice == "CSharp")
            //{
            //    Language = Languages.CSharp;
            //}
            //else if (choice == "Delphi")
            //{
            //    Language = Languages.Delphi;
            //}
            //else if (choice == "HTML")
            //{
            //    Language = Languages.HTML;
            //}
            //else if (choice == "Java")
            //{
            //    Language = Languages.Java;
            //}
            //else if (choice == "JScript")
            //{
            //    Language = Languages.JScript;
            //}
            //else if (choice == "PowerShell")
            //{
            //    Language = Languages.PowerShell;
            //}
            //else if (choice == "SQL")
            //{
            //    Language = Languages.SQL;
            //}
            //else if (choice == "VBScript")
            //{
            //    Language = Languages.VBScript;
            //}
            //else if (choice == "VisualBasic")
            //{
            //    Language = Languages.VisualBasic;
            //}
            //else if (choice == "XAML")
            //{
            //    Language = Languages.XAML;
            //}
            //else
            //{
            //    Language = Languages.XML;
            //}
        }

    }
}
