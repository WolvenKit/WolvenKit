// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StatusBarViewModel.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Catel;
using Catel.Configuration;
using Catel.IoC;
using Catel.MVVM;
using Catel.Threading;
using Orc.ProjectManagement;
using Orc.Squirrel;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    public class StatusBarViewModel : ViewModelBase
    {
        #region Fields

        private readonly IProjectManager _projectManager;
        private readonly IServiceLocator _serviceLocator;
        private readonly IConfigurationService _configurationService;
        private readonly IUpdateService _updateService;

        #endregion Fields

        #region Constructors

        public StatusBarViewModel(IProjectManager projectManager, IServiceLocator serviceLocator, IConfigurationService configurationService,
            IUpdateService updateService)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => configurationService);
            Argument.IsNotNull(() => updateService);

            _projectManager = projectManager;
            _serviceLocator = serviceLocator;
            _configurationService = configurationService;
            _updateService = updateService;
        }

        #endregion Constructors

        #region Properties

        public string ReceivingAutomaticUpdates { get; private set; }
        public bool IsUpdatedInstalled { get; private set; }
        public string Version { get; private set; }
        public int Column { get; private set; }
        public string Heading { get; private set; }
        public int Line { get; private set; }
        public string InternetConnected { get; private set; }
        public string LoadingString { get; set; }
        public bool IsLoading { get; set; }

        #endregion Properties

        #region Methods

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            StaticReferences.GlobalStatusBar = this;
            _configurationService.ConfigurationChanged += OnConfigurationChanged;
            _updateService.UpdateInstalled += OnUpdateInstalled;
            _projectManager.ProjectActivatedAsync += OnProjectActivatedAsync;

            IsUpdatedInstalled = _updateService.IsUpdatedInstalled;
            //Version = VersionHelper.GetCurrentVersion(); //TODO
            Version = "Version 0.8.1"; // TempFix
            bool Connected = InternetHelper.IsConnectedToInternet();
            if (Connected)
            { InternetConnected = "Connected"; }

            IsLoading = false;
            LoadingString = "";
            UpdateAutoUpdateInfo();
        }

        protected override async Task CloseAsync()
        {
            _configurationService.ConfigurationChanged -= OnConfigurationChanged;
            _updateService.UpdateInstalled -= OnUpdateInstalled;
            _projectManager.ProjectActivatedAsync -= OnProjectActivatedAsync;

            await base.CloseAsync();
        }

        private void OnConfigurationChanged(object sender, ConfigurationChangedEventArgs e)
        {
            if (e.Key.Contains("Updates"))
            {
                UpdateAutoUpdateInfo();
            }
        }

        private void OnUpdateInstalled(object sender, EventArgs e)
        {
            IsUpdatedInstalled = _updateService.IsUpdatedInstalled;
        }

        private void UpdateAutoUpdateInfo()
        {
            string updateInfo = string.Empty;

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

        private Task OnProjectActivatedAsync(object sender, ProjectUpdatedEventArgs args)
        {
            var activeProject = args.NewProject;
            if (activeProject == null)
            {
                return TaskHelper.Completed;
            }

            return TaskHelper.Completed;
        }

        #endregion Methods
    }
}
