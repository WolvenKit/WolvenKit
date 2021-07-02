using System;
using System.Threading.Tasks;
using Catel.Configuration;
using Catel.MVVM;
using Orc.Squirrel;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.ViewModels.Shell
{
    public class StatusBarViewModel : ViewModelBase
    {
        #region Fields

        private readonly IConfigurationService _configurationService;
        private readonly ISettingsManager _settingsManager;
        private readonly IUpdateService _updateService;

        #endregion Fields

        #region Constructors

        public StatusBarViewModel(
            ISettingsManager settingsManager,
            IConfigurationService configurationService,
            IUpdateService updateService
            )
        {
            _settingsManager = settingsManager;
            _configurationService = configurationService;
            _updateService = updateService;
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

        #endregion Properties

        #region Methods

        protected override async Task CloseAsync()
        {
            _configurationService.ConfigurationChanged -= OnConfigurationChanged;
            _updateService.UpdateInstalled -= OnUpdateInstalled;

            await base.CloseAsync();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            StaticReferencesVM.GlobalStatusBar = this;
            _configurationService.ConfigurationChanged += OnConfigurationChanged;
            _updateService.UpdateInstalled += OnUpdateInstalled;

            IsUpdatedInstalled = _updateService.IsUpdatedInstalled;
            var Connected = HandyControl.Tools.ApplicationHelper.IsConnectedToInternet();
            if (Connected)
            { InternetConnected = "Connected"; }

            IsLoading = false;
            LoadingString = "";
            UpdateAutoUpdateInfo();
        }

        private void OnConfigurationChanged(object sender, ConfigurationChangedEventArgs e)
        {
            if (e.Key.Contains("Updates"))
            {
                UpdateAutoUpdateInfo();
            }
        }

        private void OnUpdateInstalled(object sender, EventArgs e) => IsUpdatedInstalled = _updateService.IsUpdatedInstalled;

        private void UpdateAutoUpdateInfo()
        {
            var updateInfo = string.Empty;

            var checkForUpdates = _updateService.CheckForUpdates;
            if (!_updateService.IsUpdateSystemAvailable || !checkForUpdates)
            {
                updateInfo = "Automatic updates disabled.";
            }
            else
            {
                var channel = _updateService.CurrentChannel.Name;
                updateInfo = string.Format("Automatic updates enabled for {0} versions.", channel.ToLower());
            }

            ReceivingAutomaticUpdates = updateInfo;
        }

        #endregion Methods
    }
}
