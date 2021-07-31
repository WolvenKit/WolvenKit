using System;
using System.Threading.Tasks;
using ReactiveUI;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.ViewModels.Shell
{
    public class StatusBarViewModel : ReactiveObject
    {
        #region Fields

        private readonly ISettingsManager _settingsManager;
        private readonly WorkSpaceViewModel _workSpaceViewModel;

        
        


        #endregion Fields

        #region Constructors

        public StatusBarViewModel(
            ISettingsManager settingsManager,
            WorkSpaceViewModel workSpaceViewModel
            )
        {
            _settingsManager = settingsManager;
            _workSpaceViewModel = workSpaceViewModel;

            CurrentProject = "No project loaded, create or load an project to be able to view the game files...";


            var Connected = HandyControl.Tools.ApplicationHelper.IsConnectedToInternet();
            if (Connected)
            { InternetConnected = "Connected"; }

            IsLoading = false;
            LoadingString = "";
        }

        #endregion Constructors

        #region Properties




        public int FileCount { get; set; } = 0;
        public int Column { get; private set; }
        public string Heading { get; private set; }
        public string InternetConnected { get; private set; }
        public bool IsLoading { get; set; }
        public bool IsUpdatedInstalled { get; private set; }
        public int Line { get; private set; }
        public string LoadingString { get; set; }
        public string ReceivingAutomaticUpdates { get; private set; }
        public string CurrentProject { get; set; }

        public object VersionNumber => _settingsManager.GetVersionNumber();

        public string SelectedFilename { get; set; }

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
