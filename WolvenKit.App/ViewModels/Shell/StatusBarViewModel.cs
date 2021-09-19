using System;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.ViewModels.Shell
{
    public class StatusBarViewModel : ReactiveObject
    {
        #region Fields

        private const string s_noProjectLoaded =
            "No project loaded, create or load an project to be able to view the game files...";

        private readonly ISettingsManager _settingsManager;
        //private readonly AppViewModel _appViewModel;
        private readonly IProjectManager _projectManager;

        #endregion Fields

        #region Constructors

        public StatusBarViewModel(
            ISettingsManager settingsManager,
            IProjectManager projectManager
            //AppViewModel appViewModel
            )
        {
            _settingsManager = settingsManager;
            //_appViewModel = appViewModel;
            _projectManager = projectManager;


            //var connected = HandyControl.Tools.ApplicationHelper.IsConnectedToInternet();
            //if (connected)
            //{
            //    InternetConnected = "Connected";
            //}

            IsLoading = false;
            LoadingString = "";

            _projectManager
                .WhenAnyValue(
                    x => x.ActiveProject,
                    project => project != null ? project.Name : s_noProjectLoaded)
                .ToProperty(
                    this,
                    x => x.CurrentProject,
                    out _currentProject);


        }

        #endregion Constructors

        #region Properties




        //[Reactive] public int FileCount { get; set; } = 0;
        //public int Column { get; private set; }
        //public string Heading { get; private set; }
        public string InternetConnected { get; private set; }
        public bool IsLoading { get; set; }
        //public bool IsUpdatedInstalled { get; private set; }
        //public int Line { get; private set; }
        public string LoadingString { get; set; }
        //public string ReceivingAutomaticUpdates { get; private set; }

        readonly ObservableAsPropertyHelper<string> _currentProject;
        public string CurrentProject => _currentProject.Value;

        [Reactive] public string Status { get; set; } = "Ready";

        public object VersionNumber => _settingsManager.GetVersionNumber();

        //[Reactive] public string SelectedFilename { get; set; }

        #endregion Properties
    }
}
