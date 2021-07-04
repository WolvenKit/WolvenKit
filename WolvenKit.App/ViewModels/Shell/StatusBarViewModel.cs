using System;
using System.Threading.Tasks;
using Catel.Configuration;
using Catel.MVVM;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.ViewModels.Shell
{
    public class StatusBarViewModel : ViewModelBase
    {
        #region Fields

        private readonly IConfigurationService _configurationService;
        private readonly ISettingsManager _settingsManager;

        #endregion Fields

        #region Constructors

        public StatusBarViewModel(
            ISettingsManager settingsManager,
            IConfigurationService configurationService
            )
        {
            _settingsManager = settingsManager;
            _configurationService = configurationService;
            StaticReferencesVM.GlobalStatusBar = this;

            CurrentProject = "No project loaded, create or load an project to be able to view the game files...";
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

        protected override async Task CloseAsync()
        {
            _configurationService.ConfigurationChanged -= OnConfigurationChanged;

            await base.CloseAsync();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            StaticReferencesVM.GlobalStatusBar = this;
            _configurationService.ConfigurationChanged += OnConfigurationChanged;

            var Connected = HandyControl.Tools.ApplicationHelper.IsConnectedToInternet();
            if (Connected)
            { InternetConnected = "Connected"; }

            IsLoading = false;
            LoadingString = "";
        }

        private void OnConfigurationChanged(object sender, ConfigurationChangedEventArgs e)
        {
            
        }

        #endregion Methods
    }
}
