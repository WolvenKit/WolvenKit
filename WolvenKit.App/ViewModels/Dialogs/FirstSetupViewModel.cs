using System;
using System.Diagnostics;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    /// <summary>
    /// During the first time setup it tries to automatically determine the missing paths and settings.
    /// </summary>
    public class FirstSetupViewModel : DialogViewModel
    {
        private readonly ISettingsManager _settingsManager;
        private readonly ILoggerService _loggerService;

        public FirstSetupViewModel(
            ISettingsManager settingsManager,
            ILoggerService loggerService
        )
        {
            _settingsManager = settingsManager;
            _loggerService = loggerService;

            Title = "Settings";

            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(ExecuteFinish, CanExecute);
            CancelCommand = ReactiveCommand.Create(() => { });

            OpenCP77GamePathCommand = new DelegateCommand(ExecuteOpenCP77GamePath, CanOpenGamePath);
            OpenDepotPathCommand = new DelegateCommand(ExecuteOpenDepotPath, CanOpenDepotPath);

            TryToFindCP77ExecutableAutomatically();

            MaterialDepotPath = Path.Combine(ISettingsManager.GetAppData(), "Depot");
            if (!Directory.Exists(MaterialDepotPath))
            {
                Directory.CreateDirectory(MaterialDepotPath);
            }
        }

        #region Properties

        public string Title { get; set; }

        //public string Author { get; set; }
        //public string Email { get; set; }
        //public string DonateLink { get; set; }
        //public string Description { get; set; }
        [Reactive] public string MaterialDepotPath { get; set; }

        [Reactive] public bool AllFieldsValid { get; set; }
        private IObservable<bool> CanExecute =>
            this.WhenAnyValue(
                x => x.AllFieldsValid,
                (b) => b == true
            );


        [Reactive] public bool CheckForUpdates { get; set; }

        [Reactive] public string CP77ExePath { get; set; }

        public string WikiHelpLink = "https://wiki.redmodding.org/wolvenkit/getting-started/setup";

        public readonly ReactiveCommand<string, Unit> OpenLinkCommand = ReactiveCommand.Create<string>(
            link =>
            {
                var ps = new ProcessStartInfo(link)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            });

        #endregion Properties

        #region Commands

        public ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public override ReactiveCommand<Unit, Unit> CancelCommand { get; }
        public override ReactiveCommand<Unit, Unit> OkCommand { get; }


        private void ExecuteFinish()
        {
            _settingsManager.CP77ExecutablePath = CP77ExePath;
            _settingsManager.MaterialRepositoryPath = MaterialDepotPath;
            _settingsManager.Bounce();
        }


        public ICommand OpenDepotPathCommand { get; private set; }
        public ICommand OpenCP77GamePathCommand { get; private set; }


        private bool CanOpenGamePath() => true;
        private bool CanOpenDepotPath() => true;

        private void ExecuteOpenCP77GamePath()
        {
            var dlg = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = false,
                Multiselect = false,
                IsFolderPicker = false,
                Title = "Select Cyberpunk 2077 executable."
            };

            dlg.Filters.Add(new CommonFileDialogFilter("Cyberpunk2077.exe", "*.exe"));

            if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var result = dlg.FileName;
            if (string.IsNullOrEmpty(result))
            {
                return;
            }

            CP77ExePath = result;
        }

        private void ExecuteOpenDepotPath()
        {
            var dlg = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = false,
                Multiselect = false,
                IsFolderPicker = true,
                Title = "Select Material Depot folder"
            };

            if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var result = dlg.FileName;
            if (string.IsNullOrEmpty(result))
            {
                return;
            }

            MaterialDepotPath = result;
        }

        #endregion Commands

        #region Methods

        private delegate void StrDelegate(string value);

        private const string _steamCommonInstallLocation = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Cyberpunk 2077\\bin\\x64\\Cyberpunk2077.exe";
        private const string _uninstallKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
        private const string _uninstallKey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";

        private void TryToFindCP77ExecutableAutomatically()
        {
            // Try Steam Default
            if (File.Exists(_steamCommonInstallLocation))
            {
                CP77ExePath = _steamCommonInstallLocation;
                return;
            }

            // Parallel Lookup through Registry Uninstall SubKeys.
            var fileNamePath = "";
            var subKeys = Registry.LocalMachine.OpenSubKey(_uninstallKey)?.GetSubKeyNames();
            if (subKeys?.Length > 0)
            {
                Parallel.ForEach(
                    subKeys,
                    (subKeyName, state) =>
                    {
                        try
                        {
                            if (subKeyName is null)
                            { return; }

                            fileNamePath = RegistryHelpers.GetFileNamePathFromRegistrySubKey(
                                _uninstallKey + subKeyName,
                                "Cyberpunk",
                                "Cyberpunk2077.exe");

                            if (!string.IsNullOrWhiteSpace(fileNamePath))
                            { state.Break(); } // Stop the parallel loop.
                        }
                        catch (Exception ex)
                        { _loggerService.Error(ex); }
                    });
            }

            // Keep Looking
            if (string.IsNullOrWhiteSpace(fileNamePath))
            {
                subKeys = Registry.LocalMachine.OpenSubKey(_uninstallKey2)?.GetSubKeyNames();
                if (subKeys?.Length > 0)
                {
                    Parallel.ForEach(
                        subKeys,
                        (subKeyName, state) =>
                        {
                            try
                            {
                                if (subKeyName is null)
                                { return; }

                                fileNamePath = RegistryHelpers.GetFileNamePathFromRegistrySubKey(
                                    _uninstallKey2 + subKeyName,
                                    "Cyberpunk",
                                    "Cyberpunk2077.exe");

                                if (!string.IsNullOrWhiteSpace(fileNamePath))
                                { state.Break(); } // Stop the parallel loop.
                            }
                            catch (Exception ex)
                            { _loggerService.Error(ex); }
                        });
                }
            }

            if (File.Exists(fileNamePath))
            {
                CP77ExePath = fileNamePath;
            }
        }

        #endregion Methods
    }
}
