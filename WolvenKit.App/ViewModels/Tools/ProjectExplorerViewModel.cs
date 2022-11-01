using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DynamicData;
using DynamicData.Binding;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Archive;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Tools
{
    public class ProjectExplorerViewModel : ToolViewModel
    {
        #region fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "ProjectExplorer_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Project Explorer";

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly IWatcherService _watcherService;
        private readonly IModTools _modTools;
        private readonly IProgressService<double> _progressService;
        private readonly IGameControllerFactory _gameController;
        private readonly IPluginService _pluginService;
        private readonly ISettingsManager _settingsManager;
        private readonly IObservableList<FileModel> _observableList;

        #endregion fields

        #region constructors

        public ProjectExplorerViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IWatcherService watcherService,
            IProgressService<double> progressService,
            IModTools modTools,
            IGameControllerFactory gameController,
            IPluginService pluginService,
            ISettingsManager settingsManager
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _watcherService = watcherService;
            _modTools = modTools;
            _progressService = progressService;
            _gameController = gameController;
            _pluginService = pluginService;
            _settingsManager = settingsManager;

            SideInDockedMode = DockSide.Left;

            CutFileCommand = new DelegateCommand(ExecuteCutFile, CanCutFile).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);
            CopyFileCommand = new DelegateCommand(CopyFile, CanCopyFile).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);
            PasteFileCommand = new DelegateCommand(PasteFile, CanPasteFile).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);

            DeleteFileCommand = new DelegateCommand(ExecuteDeleteFile, CanDeleteFile).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);
            RenameFileCommand = new DelegateCommand(ExecuteRenameFile, CanRenameFile).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);

            CopyRelPathCommand = new DelegateCommand(ExecuteCopyRelPath, CanCopyRelPath).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);
            ReimportFileCommand = new DelegateCommand(async () => await ExecuteReimportFile(), CanReimportFile).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);
            OpenInFileExplorerCommand = new DelegateCommand(ExecuteOpenInFileExplorer, CanOpenInFileExplorer).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);

            OpenRootFolderCommand = new DelegateCommand(ExecuteOpenRootFolder, CanOpenRootFolder).ObservesProperty(() => ActiveProject);
            RefreshCommand = new DelegateCommand(async () => await ExecuteRefresh(), CanRefresh).ObservesProperty(() => ActiveProject);

            Bk2ImportCommand = new DelegateCommand(ExecuteBk2Import, CanBk2Import).ObservesProperty(() => SelectedItem);
            Bk2ExportCommand = new DelegateCommand(ExecuteBk2Export, CanBk2Export).ObservesProperty(() => SelectedItem);

            ConvertToJsonCommand = new DelegateCommand(async () => await ExecuteConvertToAsync(), CanConvertTo).ObservesProperty(() => SelectedItem);
            ConvertFromJsonCommand = new DelegateCommand(async () => await ExecuteConvertFromAsync(), CanConvertFromJson).ObservesProperty(() => SelectedItem);


            OpenInAssetBrowserCommand = new DelegateCommand(ExecuteOpenInAssetBrowser, CanOpenInAssetBrowser).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);
            OpenInMlsbCommand = new DelegateCommand(ExecuteOpenInMlsb, CanOpenInMlsb).ObservesProperty(() => ActiveProject).ObservesProperty(() => SelectedItem);


            SetupToolDefaults();

            _watcherService.Files
                .Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .BindToObservableList(out _observableList)
                .Subscribe(OnNext);

            ExpandAll = ReactiveCommand.Create(() => { });
            CollapseAll = ReactiveCommand.Create(() => { });
            CollapseChildren = ReactiveCommand.Create(() => { });
            ExpandChildren = ReactiveCommand.Create(() => { });

            this.WhenAnyValue(x => x.SelectedItem).Subscribe(model =>
            {
                if (model is not null)
                {
                    Locator.Current.GetService<AppViewModel>().FileSelectedCommand.SafeExecute(model);
                }
            });

            this.WhenAnyValue(x => x._projectManager.ActiveProject).Subscribe(proj =>
            {
                if (proj is not null)
                {
                    ActiveProject = proj;
                }
            });
        }


        #endregion constructors

        #region properties

        public AppViewModel MainViewModel => Locator.Current.GetService<AppViewModel>();
        [Reactive] private Cp77Project ActiveProject { get; set; }

        public ReactiveCommand<Unit, Unit> ExpandAll { get; private set; }
        public ReactiveCommand<Unit, Unit> CollapseAll { get; private set; }
        public ReactiveCommand<Unit, Unit> CollapseChildren { get; private set; }
        public ReactiveCommand<Unit, Unit> ExpandChildren { get; private set; }


        [Reactive] public ObservableCollection<FileModel> BindGrid1 { get; private set; } = new();

        [Reactive] public FileModel SelectedItem { get; set; }

        [Reactive] public ObservableCollection<object> SelectedItems { get; set; } = new();

        [Reactive] public bool IsFlatModeEnabled { get; set; }

        [Reactive] public int SelectedTabIndex { get; set; }

        public FileModel LastSelected => _watcherService.LastSelect;

        #endregion properties

        #region commands

        #region general commands

        /// <summary>
        /// Refreshes all files in the Grid
        /// </summary>
        public ICommand RefreshCommand { get; private set; }
        private bool CanRefresh() => ActiveProject != null;
        private Task ExecuteRefresh() => _watcherService.RefreshAsync(ActiveProject);

        /// <summary>
        /// Opens the currently selected folder in the tab
        /// </summary>
        public ICommand OpenRootFolderCommand { get; private set; }
        private bool CanOpenRootFolder() => ActiveProject != null;
        private void ExecuteOpenRootFolder()
        {
            switch (SelectedTabIndex)
            {
                case 0:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.FileDirectory);
                    break;
                case 1:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.ModDirectory);
                    break;
                case 2:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.RawDirectory);
                    break;
                case 3:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.ResourcesDirectory);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Copies selected node to the clipboard.
        /// </summary>
        public ICommand CopyFileCommand { get; private set; }
        private bool CanCopyFile() => ActiveProject != null && SelectedItem != null;
        private void CopyFile() => Clipboard.SetDataObject(SelectedItem.FullName);

        /// <summary>
        /// Copies relative path of node.
        /// </summary>
        public ICommand CopyRelPathCommand { get; private set; }
        private bool CanCopyRelPath() => ActiveProject != null && SelectedItem != null;
        private void ExecuteCopyRelPath() => Clipboard.SetDataObject(FileModel.GetRelativeName(SelectedItem.FullName, ActiveProject));

        /// <summary>
        /// Reimports the game file to replace the current one
        /// </summary>
        public ICommand ReimportFileCommand { get; private set; }
        private bool CanReimportFile() => ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
        private Task ExecuteReimportFile() => _gameController.GetController().AddFileToModModal(SelectedItem.Hash);

        /// <summary>
        /// Cuts selected node to the clipboard.
        /// </summary>
        public ICommand CutFileCommand { get; private set; }
        private bool CanCutFile() => ActiveProject != null && SelectedItem != null;
        private void ExecuteCutFile()
        {
        }

        /// <summary>
        /// Delets selected node.
        /// </summary>
        public ICommand DeleteFileCommand { get; private set; }
        private bool CanDeleteFile()
        {
            var b = ActiveProject != null && SelectedItem != null;
            return b && b;
        }
        public async void ExecuteDeleteFile()
        {
            var selected = SelectedItems.OfType<FileModel>().ToList();
            var delete = await Interactions.DeleteFiles.Handle(selected.Select(_ => _.Name));
            if (!delete)
            {
                return;
            }

            // Delete from file structure
            foreach (var item in selected)
            {
                var fullpath = item.FullName;
                try
                {
                    if (item.IsDirectory)
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(fullpath
                            , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                            , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                    }
                    else
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(fullpath
                            , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                            , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                    }
                }
                catch (Exception)
                {
                    _loggerService.Error("Failed to delete " + fullpath + ".\r\n");
                }
            }
        }

        /// <summary>
        /// Opens selected node in File Explorer.
        /// </summary>
        public ICommand OpenInFileExplorerCommand { get; private set; }
        private bool CanOpenInFileExplorer() => ActiveProject != null && SelectedItem != null;
        private void ExecuteOpenInFileExplorer()
        {
            if (SelectedItem.IsDirectory)
            {
                Commonfunctions.ShowFolderInExplorer(SelectedItem.FullName);
            }
            else
            {
                Commonfunctions.ShowFileInExplorer(SelectedItem.FullName);
            }
        }

        /// <summary>
        /// Pastes a file from the clipboard into selected node.
        /// </summary>
        public ICommand PasteFileCommand { get; private set; }
        private bool CanPasteFile() => ActiveProject != null && SelectedItem != null && Clipboard.ContainsText();
        private void PasteFile()
        {
            if (File.Exists(Clipboard.GetText()))
            {
                var attr = File.GetAttributes(SelectedItem.FullName);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    SafeCopy(Clipboard.GetText(), SelectedItem.FullName + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
                else
                {
                    SafeCopy(Clipboard.GetText(), Path.GetDirectoryName(SelectedItem.FullName) + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
            }

            static void SafeCopy(string src, string dest)
            {
                foreach (var path in FallbackPaths(dest).Where(path => !File.Exists(path)))
                {
                    File.Copy(src, path);
                    break;
                }
            }

            static IEnumerable<string> FallbackPaths(string path)
            {
                yield return path;

                var dir = Path.GetDirectoryName(path);
                var file = Path.GetFileNameWithoutExtension(path);
                var ext = Path.GetExtension(path);

                yield return Path.Combine(dir, file + " - Copy" + ext);
                for (var i = 2; ; i++)
                {
                    yield return Path.Combine(dir, file + " - Copy " + i + ext);
                }
            }
        }

        /// <summary>
        /// Renames selected node.
        /// </summary>
        public ICommand RenameFileCommand { get; private set; }
        private bool CanRenameFile() => ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
        private async void ExecuteRenameFile()
        {
            var filename = SelectedItem.FullName;
            var newfilename = await Interactions.Rename.Handle(filename);

            if (string.IsNullOrEmpty(newfilename))
            {
                return;
            }

            var newfullpath = Path.Combine(Path.GetDirectoryName(filename), newfilename);

            if (File.Exists(newfullpath))
            {
                return;
            }

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(newfullpath));
                if (SelectedItem.IsDirectory)
                {
                    Directory.Move(filename, newfullpath);
                }
                else
                {
                    File.Move(filename, newfullpath);
                }
            }
            catch
            {
            }


        }

        #endregion general commands

        #region red4

        private bool IsInRawFolder(FileModel model)
        {
            var b = model.FullName.Contains(ActiveProject.RawDirectory);

            return b;
        }

        public ICommand Bk2ImportCommand { get; private set; }
        private bool CanBk2Import() => SelectedItem != null && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("avi");
        private void ExecuteBk2Import()
        {
            var modpath = Path.Combine(ActiveProject.ModDirectory, FileModel.GetRelativeName(SelectedItem.FullName, ActiveProject));
            modpath = Path.ChangeExtension(modpath, ".bk2");
            var directoryName = Path.GetDirectoryName(modpath);
            Directory.CreateDirectory(directoryName);

            var args = $"\"{SelectedItem.FullName}\" \"{modpath}\" /o /#";
            var procInfo =
                new ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"))
                {
                    Arguments = args,
                    WorkingDirectory = ISettingsManager.GetWorkDir()
                };

            var process = Process.Start(procInfo);
            process?.WaitForInputIdle();
        }
        public ICommand Bk2ExportCommand { get; private set; }
        private bool CanBk2Export() => SelectedItem != null && !IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("bk2");
        private void ExecuteBk2Export()
        {
            var rawpath = Path.Combine(ActiveProject.RawDirectory, FileModel.GetRelativeName(SelectedItem.FullName, ActiveProject));
            rawpath = Path.ChangeExtension(rawpath, ".avi");
            var directoryName = Path.GetDirectoryName(rawpath);
            Directory.CreateDirectory(directoryName);

            var args = $"\"{SelectedItem.FullName}\" \"{rawpath}\" /o /#";
            var procInfo =
                new System.Diagnostics.ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(),
                    "testconv.exe"))
                {
                    Arguments = args,
                    WorkingDirectory = ISettingsManager.GetWorkDir()
                };

            var process = Process.Start(procInfo);
            process?.WaitForInputIdle();
        }

        public ICommand ConvertToJsonCommand { get; private set; }
        private bool CanConvertTo() => SelectedItem != null && !IsInRawFolder(SelectedItem);
        private async Task ExecuteConvertToAsync()
        {
            if (SelectedItem.IsDirectory)
            {
                var progress = 0;
                _progressService.Report(0);

                var files = Directory.GetFiles(SelectedItem.FullName, "*", SearchOption.AllDirectories).ToList();
                foreach (var file in files)
                {
                    await ConvertToTask(file);

                    progress++;
                    _progressService.Report(progress / (float)files.Count);
                }
            }
            else
            {
                var inpath = SelectedItem.FullName;
                await ConvertToTask(inpath);
            }
        }
        private Task ConvertToTask(string file)
        {
            if (!File.Exists(file))
            {
                return Task.CompletedTask;
            }

            if (!Enum.GetNames<ERedExtension>().Contains(Path.GetExtension(file).TrimStart('.').ToLower()))
            {
                return Task.CompletedTask;
            }

            var rawOutPath = Path.Combine(ActiveProject.RawDirectory, FileModel.GetRelativeName(file, ActiveProject));
            var outDirectoryPath = Path.GetDirectoryName(rawOutPath);
            if (outDirectoryPath != null)
            {
                Directory.CreateDirectory(outDirectoryPath);

                return Task.Run(() => _modTools.ConvertToAndWrite(ETextConvertFormat.json, file, new DirectoryInfo(outDirectoryPath)));
            }

            return Task.CompletedTask;
        }


        public ICommand ConvertFromJsonCommand { get; private set; }
        private bool CanConvertFromJson() => SelectedItem != null && IsInRawFolder(SelectedItem);
        private async Task ExecuteConvertFromAsync()
        {
            if (SelectedItem.IsDirectory)
            {
                var progress = 0;
                _progressService.Report(0);

                var files = Directory.GetFiles(SelectedItem.FullName, "*", SearchOption.AllDirectories).ToList();
                foreach (var file in files)
                {
                    await ConvertFromTask(file);

                    progress++;
                    _progressService.Report(progress / (float)files.Count);
                }
            }
            else
            {
                var inpath = SelectedItem.FullName;
                await ConvertFromTask(inpath);
            }
        }
        private Task ConvertFromTask(string file)
        {
            if (!File.Exists(file))
            {
                return Task.CompletedTask;
            }

            if (Path.GetExtension(file).TrimStart('.').ToLower() != ETextConvertFormat.json.ToString())
            {
                return Task.CompletedTask;
            }

            var modPath = Path.Combine(ActiveProject.ModDirectory, FileModel.GetRelativeName(SelectedItem.FullName, ActiveProject));
            var outDirectoryPath = Path.GetDirectoryName(modPath);
            if (outDirectoryPath != null)
            {
                Directory.CreateDirectory(outDirectoryPath);

                return Task.Run(() => _modTools.ConvertFromAndWrite(new FileInfo(file), new DirectoryInfo(outDirectoryPath)));
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Opens selected node in asset browser.
        /// </summary>
        public ICommand OpenInAssetBrowserCommand { get; private set; }
        private bool CanOpenInAssetBrowser() => ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
        private void ExecuteOpenInAssetBrowser()
        {
            Locator.Current.GetService<AppViewModel>().AssetBrowserVM.IsVisible = true;
            Locator.Current.GetService<AssetBrowserViewModel>().ShowFile(SelectedItem);
        }

        private static string GetSecondExtension(FileModel model) => Path.GetExtension(Path.ChangeExtension(model.FullName, "").TrimEnd('.')).TrimStart('.');

        public ICommand OpenInMlsbCommand { get; private set; }
        private bool CanOpenInMlsb() => ActiveProject != null
            && SelectedItem != null
            && !SelectedItem.IsDirectory
            && IsInRawFolder(SelectedItem)
            && SelectedItem.Extension.ToLower().Equals(ETextConvertFormat.json.ToString(), StringComparison.Ordinal)
            && GetSecondExtension(SelectedItem).Equals(ERedExtension.mlsetup.ToString(), StringComparison.Ordinal)
            && _pluginService.IsInstalled(EPlugin.mlsetupbuilder);
        private void ExecuteOpenInMlsb()
        {
            if (_pluginService.TryGetInstallPath(EPlugin.mlsetupbuilder, out var path))
            {
                if (!Directory.Exists(path))
                {
                    _loggerService.Error($"Mlsetupbuilder not found: {path}");
                    return;
                }

                var firstFolder = Directory.GetDirectories(path).FirstOrDefault();
                if (firstFolder is null)
                {
                    _loggerService.Error($"Mlsetupbuilder not found: {path}");
                    return;
                }

                var exe = Path.Combine(firstFolder, "MlsetupBuilder.exe");

                if (!File.Exists(exe))
                {
                    _loggerService.Error($"Mlsetupbuilder exe not found: {exe}");
                    return;
                }

                var filepath = SelectedItem.FullName;
                var version = _settingsManager.GetVersionNumber();
                try
                {
                    var args = $"-o=\"{filepath}\" -wkit=\"{version}\"";
                    _loggerService.Info($"executing: {Path.GetFileName(exe)} {args}");
                    Process.Start(exe, args);
                }
                catch (Exception ex)
                {
                    _loggerService.Error(ex);
                }
            }
        }

        #endregion

        #endregion commands

        #region Methods

        private void OnNext(IChangeSet<FileModel, ulong> obj) => BindGrid1 = new ObservableCollection<FileModel>(_observableList.Items);

        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;


        //private async void RequestFileCook(object sender, RequestFileOpenArgs e)
        //{
        //    if (ActiveProject is not Tw3Project tw3mod)
        //    {
        //        return;
        //    }

        //    var filename = e.File;
        //    var fullpath = Path.Combine(ActiveProject.FileDirectory, filename);
        //    if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
        //    {
        //        return;
        //    }

        //    var dir = File.Exists(fullpath) ? Path.GetDirectoryName(fullpath) : fullpath;
        //    var reldir = dir[(ActiveProject.FileDirectory.Length + 1)..];

        //    // Trim working directories in path
        //    var reg = new Regex(@"^(Raw|Mod|DLC)\\(.*)");
        //    var match = reg.Match(reldir);
        //    var isDlc = false;
        //    if (match.Success)
        //    {
        //        reldir = match.Groups[2].Value;
        //        if (match.Groups[1].Value == "Raw")
        //        {
        //            return;
        //        }
        //        else if (match.Groups[1].Value == "DLC")
        //        {
        //            isDlc = true;
        //        }
        //        else if (match.Groups[1].Value == "Mod")
        //        {
        //            isDlc = false;
        //        }
        //    }

        //    if (reldir.StartsWith(EProjectFolders.Cooked.ToString()))
        //    {
        //        reldir = reldir[EProjectFolders.Cooked.ToString().Length..];
        //    }

        //    if (reldir.StartsWith(EProjectFolders.Uncooked.ToString()))
        //    {
        //        reldir = reldir[EProjectFolders.Uncooked.ToString().Length..];
        //    }

        //    reldir = reldir.TrimStart(Path.DirectorySeparatorChar);

        //    // create cooked mod Dir
        //    var cookedtargetDir = isDlc
        //        ? Path.Combine(tw3mod.DlcCookedDirectory, reldir)
        //        : Path.Combine(tw3mod.ModCookedDirectory, reldir);
        //    if (!Directory.Exists(cookedtargetDir))
        //    {
        //        Directory.CreateDirectory(cookedtargetDir);
        //    }

        //    // lazy check for existing files in Active Mod
        //    var filenames = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
        //        .Select(_ => Path.GetFileName(_));
        //    var existingfiles = Directory.GetFiles(cookedtargetDir, "*.*", SearchOption.AllDirectories)
        //        .Select(_ => Path.GetFileName(_));

        //    if (existingfiles.Intersect(filenames).Any())
        //    {
        //        //if (MessageBox.Show(
        //        //     "Some of the files you are about to cook already exist in your mod. These files will be overwritten. Are you sure you want to permanently overwrite them?"
        //        //     , "Confirmation", MessageBoxButtons.YesNo
        //        // ) != DialogResult.Yes)
        //        //{
        //        //    return;
        //        //}
        //    }

        //    try
        //    {
        //        var cook = new Wcc_lite.cook()
        //        {
        //            Platform = platform.pc,
        //            mod = dir,
        //            basedir = dir,
        //            outdir = cookedtargetDir
        //        };
        //        await Task.Run(() => _tw3Controller.RunCommand(cook));
        //    }
        //    catch (Exception)
        //    {
        //        _loggerService.LogString("Error cooking files.", Logtype.Error);
        //    }
        //}

        #endregion Methods
    }
}
