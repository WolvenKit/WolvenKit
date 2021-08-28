using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.ViewModels.Wizards
{
    /// <summary>
    /// During the first time setup it tries to automatically determine the missing paths and settings.
    /// </summary>
    public class FirstSetupWizardViewModel : DialogViewModel
    {

        #region Fields

        private const string s_greenBg = "#9600ff00";
        private const string s_redBg = "#96ff0000";
        private const string s_wccSha256 = "fb20d7aa45b95446baac9b376533b06b86add732cbe40fd0620e4a4feffae47b";
        private const string s_wccSha256Patched = "275faa214c6263287deea47ddbcd7afcf6c2503a76ff57f2799bc158f5af7c5d";
        private const string s_wccSha256Patched2 = "104f50142fde883337d332d319d205701e8a302197360f5237e6bb426984212a";

        private readonly ISettingsManager _settingsManager;

        private string _cp77Eexe = "";
        //private string wccLiteexe = "";
        //private string witcherexe = "";

        #endregion Fields

        #region Constructors

        public FirstSetupWizardViewModel(
            ISettingsManager settingsManager
        )
        {
            _settingsManager = settingsManager;

            Title = "Settings";


            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(ExecuteFinish, CanExecute);
            CancelCommand = ReactiveCommand.Create(() => { });

            OpenCP77GamePathCommand = new RelayCommand(ExecuteOpenCP77GamePath, CanOpenGamePath);
            OpenDepotPathCommand = new RelayCommand(ExecuteOpenDepotPath, CanOpenDepotPath);



            //OpenW3GamePathCommand = new RelayCommand(ExecuteOpenGamePath, CanOpenGamePath);
            //OpenWccPathCommand = new RelayCommand(ExecuteOpenWccPath, CanOpenWccPath);
            //OpenModDirectoryCommand = new RelayCommand(ExecuteOpenMod, CanOpenMod);
            //OpenDlcDirectoryCommand = new RelayCommand(ExecuteOpenDlc, CanOpenDlc);


            CheckForUpdates = _settingsManager.CheckForUpdates;
           // W3ExePath = _settingsManager.W3ExecutablePath;
            CP77ExePath = _settingsManager.CP77ExecutablePath;
            //WccLitePath = _settingsManager.WccLitePath;

            MaterialDepotPath = _settingsManager.MaterialRepositoryPath;

            // automatically scan the registry for exe paths for wcc and tw3
            // if either text field is empty
            if (/*string.IsNullOrEmpty(W3ExePath) || string.IsNullOrEmpty(WccLitePath) ||*/ string.IsNullOrEmpty(CP77ExePath))
            {
                exeSearcherSlave_DoWork();
            }

            if (string.IsNullOrEmpty(MaterialDepotPath))
            {
                MaterialDepotPath = Path.Combine(ISettingsManager.GetAppData(), "MaterialDepot");
                if (!Directory.Exists(MaterialDepotPath))
                {
                    Directory.CreateDirectory(MaterialDepotPath);
                }
            }
        }

        #endregion Constructors

        #region Properties

        public sealed override string Title { get; set; }

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


        //private string _wccLitePath;

        [Reactive] public bool CheckForUpdates { get; set; }

        [Reactive] public string CP77ExePath { get; set; }

        // public string ExecutablePathBG => string.IsNullOrEmpty(W3ExePath) ? redBG : greenBG;
        //public bool IsUpdateSystemAvailable { get; private set; }

        //public string W3ExePath { get; set; }

        //public string WccLitePath
        //{
        //    get => _wccLitePath;
        //    set
        //    {
        //        _wccLitePath = value;

        //        RaisePropertyChanged(nameof(WccLitePath));

        //        // get the depot path
        //        if (File.Exists(_wccLitePath) && Path.GetExtension(_wccLitePath) == ".exe" && _wccLitePath.Contains("wcc_lite.exe"))
        //        {
        //            var wccDir = new FileInfo(_wccLitePath).Directory.Parent.Parent;
        //            var wcc_r4data = Path.Combine(wccDir.FullName, "r4data");
        //            if (Directory.Exists(wcc_r4data))
        //            {
        //                _settingsManager.DepotPath = wcc_r4data;
        //            }
        //        }
        //    }
        //}

        //public string WccLitePathBG => string.IsNullOrEmpty(WccLitePath) ? redBG : greenBG;

        #endregion Properties

        #region Commands

        public sealed override ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> OkCommand { get; set; }


        private void ExecuteFinish()
        {

            _settingsManager.CheckForUpdates = CheckForUpdates;
           // _settingsManager.W3ExecutablePath = W3ExePath;
            _settingsManager.CP77ExecutablePath = CP77ExePath;
            //_settingsManager.WccLitePath = WccLitePath;
            _settingsManager.MaterialRepositoryPath = MaterialDepotPath;

            _settingsManager.Save();


        }

        



        public ICommand OpenDepotPathCommand { get; private set; }
        public ICommand OpenCP77GamePathCommand { get; private set; }
        //public ICommand OpenDlcDirectoryCommand { get; private set; }
        //public ICommand OpenModDirectoryCommand { get; private set; }
        //public ICommand OpenW3GamePathCommand { get; private set; }

        //public ICommand OpenWccPathCommand { get; private set; }

        //private bool CanOpenDlc() => true;

        private bool CanOpenGamePath() => true;
        private bool CanOpenDepotPath() => true;

        //private bool CanOpenMod() => true;

        //private bool CanOpenWccPath() => true;

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

        //private void ExecuteOpenDlc()
        //{
        //}

        //private async void ExecuteOpenGamePath()
        //{
        //    var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext
        //    {
        //        Title = "Select Witcher 3 executable.",
        //        Filter = "witcher3.exe|witcher3.exe",
        //        IsMultiSelect = false
        //    });

        //    if (result.Result)
        //    {
        //        W3ExePath = result.FileName;
        //    }
        //}

        //private void ExecuteOpenMod()
        //{
        //}

        //private async void ExecuteOpenWccPath()
        //{
        //    var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext
        //    {
        //        Title = "Select wcc_lite.exe.",
        //        Filter = "wcc_lite.exe|wcc_lite.exe",
        //        IsMultiSelect = false
        //    });

        //    if (result.Result)
        //    {
        //        WccLitePath = result.FileName;
        //    }
        //}

        #endregion Commands

        #region Methods

        private delegate void StrDelegate(string value);

        private void exeSearcherSlave_DoWork()
        {
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            //var w3 = "";
            //var wcc = "";
            var cp77 = "";
            try
            {
                //StrDelegate w3del = msg => witcherexe = msg;
                //StrDelegate wccdel = msg => wccLiteexe = msg;
                StrDelegate cp77del = msg => _cp77Eexe = msg;

                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        //if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        //{
                        //    if (File.Exists(installLocation.ToString()))
                        //    {
                        //        wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe",
                        //            SearchOption.AllDirectories).First();
                        //    }
                        //}

                        //if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                        //    programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        //{
                        //    if (File.Exists(installLocation.ToString()))
                        //    {
                        //        w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                        //            SearchOption.AllDirectories).First();
                        //    }
                        //}

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

                    //w3del.Invoke(w3);
                    //wccdel.Invoke(wcc);
                });
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        //if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        //{
                        //    if (Directory.Exists(installLocation.ToString()))
                        //    {
                        //        wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe",
                        //            SearchOption.AllDirectories).First();
                        //    }
                        //}

                        //if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                        //    programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        //{
                        //    if (Directory.Exists(installLocation.ToString()))
                        //    {
                        //        w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                        //        SearchOption.AllDirectories).First();
                        //    }
                        //}

                        if (programName.ToString().Contains("Cyberpunk 2077"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                            {
                                cp77 = Directory.GetFiles(installLocation.ToString(), "Cyberpunk2077.exe",
                                    SearchOption.AllDirectories).First();
                            }
                        }
                    }

                    //w3del.Invoke(w3);
                    //wccdel.Invoke(wcc);
                    cp77del.Invoke(cp77);
                });
            }
            catch (Exception)
            {
                // TODO: Are we intentionally swallowing this?
            }

            //if (File.Exists(witcherexe))
            //{
            //    W3ExePath = witcherexe;
            //}

            //if (File.Exists(wccLiteexe))
            //{
            //    WccLitePath = wccLiteexe;
            //}

            if (File.Exists(_cp77Eexe))
            {
                CP77ExePath = _cp77Eexe;
            }

            // get the depot path
            // if depot path is empty, get the r4data from wcc_lite
            //if (string.IsNullOrEmpty(_settingsManager.DepotPath) || !Directory.Exists(_settingsManager.DepotPath))
            //{
            //    if (File.Exists(wccLiteexe) && Path.GetExtension(wccLiteexe) == ".exe" && wccLiteexe.Contains("wcc_lite.exe"))
            //    {
            //        var directoryInfo = new FileInfo(wccLiteexe).Directory;
            //        var wccDir = directoryInfo?.Parent?.Parent;
            //        if (wccDir != null)
            //        {
            //            var wccR4data = Path.Combine(wccDir.FullName, "r4data");
            //            if (Directory.Exists(wccR4data))
            //            {
            //                _settingsManager.DepotPath = wccR4data;
            //            }
            //        }
            //    }
            //}
        }

        #endregion Methods
    }
}
