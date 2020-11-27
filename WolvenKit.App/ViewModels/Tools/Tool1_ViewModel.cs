namespace WolvenKit.App.ViewModels
{
    using System;
    using System.Windows.Media.Imaging;
    using System.Windows.Media;
    using System.Windows.Input;
    using WolvenKit.App.Commands;
    using Catel.IoC;
    using MLib.Interfaces;
    using WolvenKit.App.Services;
    using Catel;


    /// <summary>
    /// Implements the viewmodel that drives a sample tool window view.
    /// </summary>
    public class Tool1_ViewModel : ToolViewModel
    {
        #region fields
        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "Tool1_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Tool 1";

        private IWorkSpaceViewModel _workSpaceViewModel = null;
        //private readonly ISettingsManager _settingsManager;

        #endregion fields

        #region constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="workSpaceViewModel">Is the link to the application's viewmodel
        /// to enable (event based) communication between this viewmodel and the application.</param>
        public Tool1_ViewModel(
            IWorkSpaceViewModel workSpaceViewModel
            //ISettingsManager settingsManager
            )
            : base(ToolTitle)
        {
            //Argument.IsNotNull(() => settingsManager);

            //_settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();


            _workSpaceViewModel = workSpaceViewModel;

            SetupADToolDefaults();
            SetupToolDefaults();
        }

        /// <summary>
        /// Hidden default class constructor
        /// </summary>
        protected Tool1_ViewModel()
          : base(ToolTitle)
        {
            SetupADToolDefaults();
            SetupToolDefaults();
        }
        #endregion constructors

        #region properties
        
        #endregion properties

        #region methods
        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupADToolDefaults()
        {
            ContentId = ToolContentId;           // Define a unique contentid for this toolwindow

            //BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow
            //bi.BeginInit();
            //bi.UriSource = new Uri("pack://application:,,,/WolvenKitUI;component/Resources/Images/git.png");
            //bi.EndInit();
            //IconSource = bi;
        }

        /// <summary>
        /// Initialize non-Avalondock defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults()
        {
            //SelectedBackgroundColor = Color.FromArgb(255, 0, 0, 0);
            //SelectedAccentColor = Color.FromArgb(128, 0, 180, 0);
        }
        #endregion methods
    }
}