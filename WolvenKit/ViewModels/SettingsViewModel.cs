// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsViewModel.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System.Linq;
using System.Windows.Input;
using Microsoft.Win32;
using WolvenKit.Commands;

namespace WolvenKit.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Catel;
    using Catel.MVVM;
    using Catel.Services;
    using Orc.Squirrel;
    using Services;

    public class SettingsViewModel : ViewModelBase
    {
        #region Fields
        private readonly ISettingsManager _settingsManager;
        private readonly IUpdateService _updateService;
        private readonly IOpenFileService _openFileService;

        private string witcherexe = "";
        private string wccLiteexe = "";
        private string cp77eexe = "";
        

        private const string wcc_sha256 = "fb20d7aa45b95446baac9b376533b06b86add732cbe40fd0620e4a4feffae47b";
        private const string wcc_sha256_patched = "275faa214c6263287deea47ddbcd7afcf6c2503a76ff57f2799bc158f5af7c5d";
        private const string wcc_sha256_patched2 = "104f50142fde883337d332d319d205701e8a302197360f5237e6bb426984212a";

        private const string redBG = "#96ff0000";
        private const string greenBG = "#9600ff00";
        #endregion

        #region Constructors
        public SettingsViewModel(ISettingsManager settingsManager, IUpdateService updateService, IOpenFileService openFileService)
        {
            Argument.IsNotNull(() => settingsManager);
            Argument.IsNotNull(() => updateService);
            Argument.IsNotNull(() => openFileService);

            _settingsManager = settingsManager;
            _updateService = updateService;
            _openFileService = openFileService;

            OpenGamePathCommand = new RelayCommand(ExecuteOpenGamePath, CanOpenGamePath);
            OpenWccPathCommand = new RelayCommand(ExecuteOpenWccPath, CanOpenWccPath);
            OpenModDirectoryCommand = new RelayCommand(ExecuteOpenMod, CanOpenMod);
            OpenDlcDirectoryCommand = new RelayCommand(ExecuteOpenDlc, CanOpenDlc);

            Title = "Settings";


            CheckForUpdates = _settingsManager.CheckForUpdates;
            W3ExePath = _settingsManager.W3ExecutablePath;
            CP77ExePath = _settingsManager.CP77ExecutablePath;
            WccLitePath = _settingsManager.WccLitePath;
            

            // automatically scan the registry for exe paths for wcc and tw3
            // if either text field is empty
            if (string.IsNullOrEmpty(W3ExePath) || string.IsNullOrEmpty(WccLitePath) || string.IsNullOrEmpty(CP77ExePath))
            {
                exeSearcherSlave_DoWork();
            }

            //TODO: handle this case!
            if (!TryCopyOodleLib())
                throw new NotImplementedException();

        }
        #endregion

        #region Properties
        public bool IsUpdateSystemAvailable { get; private set; }
        public bool CheckForUpdates { get; set; }

        public string W3ExePath { get; set; }
        public string CP77ExePath { get; set; }
        public string ExecutablePathBG => string.IsNullOrEmpty(W3ExePath) ? redBG : greenBG;

        private string _wccLitePath;
        public string WccLitePath
        {
            get => _wccLitePath;
            set{
                _wccLitePath = value;

                RaisePropertyChanged(nameof(WccLitePath));

                // get the depot path
                if (File.Exists(_wccLitePath) && Path.GetExtension(_wccLitePath) == ".exe" && _wccLitePath.Contains("wcc_lite.exe"))
                {
                    DirectoryInfo wccDir = new FileInfo(_wccLitePath).Directory.Parent.Parent;
                    string wcc_r4data = Path.Combine(wccDir.FullName, "r4data");
                    if (Directory.Exists(wcc_r4data))
                    {
                        _settingsManager.DepotPath = wcc_r4data;
                    }
                }
            }
        }
        public string WccLitePathBG => string.IsNullOrEmpty(WccLitePath) ? redBG : greenBG;


        public List<UpdateChannel> AvailableUpdateChannels { get; private set; }
        public UpdateChannel UpdateChannel { get; set; }


        #endregion

        #region Commands
        public ICommand OpenGamePathCommand { get; private set; }

        private bool CanOpenGamePath() => true;

        private async void ExecuteOpenGamePath()
        {
            var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext
            {
                Title = "Select Witcher 3 Executable.",
                Filter = "witcher3.exe|witcher3.exe",
                IsMultiSelect = false
            });

            if (result.Result)
            {
                W3ExePath = result.FileName;
            }
        }

        public ICommand OpenWccPathCommand { get; private set; }

        private bool CanOpenWccPath() => true;

        private async void ExecuteOpenWccPath()
        {
            var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext
            {
                Title = "Select wcc_lite.exe.",
                Filter = "wcc_lite.exe|wcc_lite.exe",
                IsMultiSelect = false
            });

            if (result.Result)
            {
                WccLitePath = result.FileName;
            }
        }

        public ICommand OpenModDirectoryCommand { get; private set; }

        private bool CanOpenMod() => true;

        private void ExecuteOpenMod()
        {
        }

        public ICommand OpenDlcDirectoryCommand { get; private set; }

        private bool CanOpenDlc() => true;

        private void ExecuteOpenDlc()
        {
            
        }
        #endregion

        #region Methods
        private bool TryCopyOodleLib()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var dir = Path.GetDirectoryName(path);

            if (dir == null) return false;

            var destFileName = Path.Combine(dir, "oo2ext_7_win64.dll");
            if (File.Exists(destFileName))
                return true;

            var directory = new FileInfo(CP77ExePath).Directory;
            if (directory == null)
                return false;
            var cp77BinDir = directory.FullName;
            if (string.IsNullOrEmpty(cp77BinDir))
                return false;

            // copy oodle dll
            var oodleInfo = new FileInfo(Path.Combine(cp77BinDir, "oo2ext_7_win64.dll"));
            if (!oodleInfo.Exists)
                return false;

            if (!File.Exists(destFileName))
                oodleInfo.CopyTo(destFileName);

            return true;
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            IsUpdateSystemAvailable = _updateService.IsUpdateSystemAvailable;
            _settingsManager.CheckForUpdates = _updateService.CheckForUpdates;
            AvailableUpdateChannels = new List<UpdateChannel>(_updateService.AvailableChannels);
            UpdateChannel = _updateService.CurrentChannel;

            
        }
        
        protected override async Task<bool> SaveAsync()
        {
            //var cansave = 
            //    //(File.Exists(WccLitePath) && Path.GetExtension(WccLitePath) == ".exe" && WccLitePath.Contains("wcc_lite.exe")) &&
            //    (File.Exists(ExecutablePath) && Path.GetExtension(ExecutablePath) == ".exe" && ExecutablePath.Contains("witcher3.exe"));
            //if (!cansave) return false;


            //_updateService.CheckForUpdates = _settingsManager.CheckForUpdates;
            //_updateService.CurrentChannel = UpdateChannel;

            _settingsManager.CheckForUpdates = CheckForUpdates;
            _settingsManager.W3ExecutablePath = W3ExePath;
            _settingsManager.CP77ExecutablePath = CP77ExePath;
            _settingsManager.WccLitePath = WccLitePath;

            _settingsManager.Save();

            return await base.SaveAsync();
        }


        private delegate void StrDelegate(string value);

        private void exeSearcherSlave_DoWork()
        {
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            var w3 = "";
            var wcc = "";
            var cp77 = "";
            try
            {
                StrDelegate w3del = msg => witcherexe = msg;
                StrDelegate wccdel = msg => wccLiteexe = msg;
                StrDelegate cp77del = msg => cp77eexe = msg;

                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        {
                            wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe",
                                SearchOption.AllDirectories).First();
                        }

                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                            programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                                SearchOption.AllDirectories).First();
                        }

                        if (programName.ToString().Contains("Cyberpunk 2077"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                cp77 = Directory.GetFiles(installLocation.ToString(), "Cyberpunk2077.exe",
                                    SearchOption.AllDirectories).First();
                        }
                    }

                    w3del.Invoke(w3);
                    wccdel.Invoke(wcc);
                });
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe",
                                    SearchOption.AllDirectories).First();
                        }

                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                            programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                                SearchOption.AllDirectories).First();
                        }

                        if (programName.ToString().Contains("Cyberpunk 2077"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                cp77 = Directory.GetFiles(installLocation.ToString(), "Cyberpunk2077.exe",
                                    SearchOption.AllDirectories).First();
                        }
                    }

                    w3del.Invoke(w3);
                    wccdel.Invoke(wcc);
                    cp77del.Invoke(cp77);
                });
            }
            catch (Exception)
            {
                // TODO: Are we intentionally swallowing this?
            }

            if (File.Exists(witcherexe))
                W3ExePath = witcherexe;
            if (File.Exists(wccLiteexe))
                WccLitePath = wccLiteexe;
            if (File.Exists(cp77eexe))
                CP77ExePath = cp77eexe;


            // get the depot path
            // if depot path is empty, get the r4data from wcc_lite
            if (string.IsNullOrEmpty(_settingsManager.DepotPath) || !Directory.Exists(_settingsManager.DepotPath))
            {
                if (File.Exists(wccLiteexe) && Path.GetExtension(wccLiteexe) == ".exe" && wccLiteexe.Contains("wcc_lite.exe"))
                {
                    var directoryInfo = new FileInfo(wccLiteexe).Directory;
                    var wccDir = directoryInfo?.Parent?.Parent;
                    if (wccDir != null)
                    {
                        string wccR4data = Path.Combine(wccDir.FullName, "r4data");
                        if (Directory.Exists(wccR4data))
                        {
                            _settingsManager.DepotPath = wccR4data;
                        }
                    }
                }
            }

            // if custom mod folder is empty or incorrect in the configuration, get the game mod dir and dlc dir
            //SetDefaultModDir();
            //SetDefaultDlcDir();
        }

        #endregion
    }
}
