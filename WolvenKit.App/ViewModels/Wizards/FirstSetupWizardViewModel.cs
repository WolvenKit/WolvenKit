using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.ViewModels.Wizards
{
    /// <summary>
    /// During the first time setup it tries to automatically determine the missing paths and settings.
    /// </summary>
    public class FirstSetupWizardViewModel : DialogViewModel
    {
        private readonly ISettingsManager _settingsManager;
        private readonly ILoggerService _loggerService;
        private string _cp77Eexe = "";

        public FirstSetupWizardViewModel(
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

            MaterialDepotPath = Path.Combine(ISettingsManager.GetAppData(), "MaterialDepot");
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
        public ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public ReactiveCommand<Unit, Unit> OkCommand { get; set; }


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

        private void TryToFindCP77ExecutableAutomatically()
        {
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";

            var cp77 = "";
            try
            {
                void cp77del(string msg) => _cp77Eexe = msg;

                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {

                        if (programName.ToString().Contains("Cyberpunk 2077"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                            {
                                if (File.Exists(installLocation.ToString()))
                                {
                                    cp77 = Directory.GetFiles(installLocation.ToString(), "Cyberpunk2077.exe",
                                        SearchOption.AllDirectories).First();
                                }
                            }
                        }
                    }
                });
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("Cyberpunk 2077"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                            {
                                cp77 = Directory.GetFiles(installLocation.ToString(), "Cyberpunk2077.exe",
                                    SearchOption.AllDirectories).First();
                            }
                        }
                    }
                    cp77del(cp77);
                });
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex);
            }

            if (File.Exists(_cp77Eexe))
            {
                CP77ExePath = _cp77Eexe;
            }
        }

        #endregion Methods
    }
}
