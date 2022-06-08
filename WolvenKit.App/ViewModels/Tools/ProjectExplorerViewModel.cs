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
using AsyncAwaitBestPractices.MVVM;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Commands.Base;
using WolvenKit.App.Controllers;
using WolvenKit.App.Functionality.ProjectManagement.Project;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.ViewModels.Tools
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

        private EditorProject ActiveMod => _projectManager.ActiveProject;
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

            SetupCommands();
            SetupToolDefaults();

            _ = _watcherService.Files
                .Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .BindToObservableList(out _observableList)
                .Subscribe(OnNext);

            ExpandAll = ReactiveCommand.Create(() => { });
            CollapseAll = ReactiveCommand.Create(() => { });
            CollapseChildren = ReactiveCommand.Create(() => { });
            ExpandChildren = ReactiveCommand.Create(() => { });

            _ = this.WhenAnyValue(x => x.SelectedItem).Subscribe(model =>
            {
                if (model != null)
                {
                    Locator.Current.GetService<AppViewModel>().FileSelectedCommand.SafeExecute(model);
                }
            });

        }


        #endregion constructors

        #region properties

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

        public ICommand OpenRootFolderCommand { get; private set; }
        private bool CanOpenRootFolder() => _projectManager.ActiveProject != null;
        private void ExecuteOpenRootFolder()
        {
            if (_projectManager.ActiveProject is Cp77Project project)
            {
                switch (SelectedTabIndex)
                {
                    case 0:
                        Commonfunctions.ShowFolderInExplorer(project.FileDirectory);
                        break;
                    case 1:
                        Commonfunctions.ShowFolderInExplorer(project.ModDirectory);
                        break;
                    case 2:
                        Commonfunctions.ShowFolderInExplorer(project.RawDirectory);
                        break;
                    case 3:
                        Commonfunctions.ShowFolderInExplorer(project.ScriptDirectory);
                        break;
                    case 4:
                        Commonfunctions.ShowFolderInExplorer(project.TweakDirectory);
                        break;
                    case 5:
                        Commonfunctions.ShowFolderInExplorer(project.PackedRootDirectory);
                        break;
                    default:
                        break;
                }
            }
        }

        public ICommand OpenFileCommand { get; private set; }
        private bool CanOpenFile() => true;
        private void ExecuteOpenFile() =>
            // TODO: Handle command logic here
            Locator.Current.GetService<AppViewModel>().OpenFileAsyncCommand.SafeExecute(SelectedItem);

        /// <summary>
        /// Copies selected node to the clipboard.
        /// </summary>
        public ICommand CopyFileCommand { get; private set; }
        private bool CanCopyFile() => _projectManager.ActiveProject != null && SelectedItem != null;
        private void CopyFile() => Clipboard.SetDataObject(SelectedItem.FullName);

        /// <summary>
        /// Copies relative path of node.
        /// </summary>
        public ICommand CopyRelPathCommand { get; private set; }
        private bool CanCopyRelPath() => _projectManager.ActiveProject != null && SelectedItem != null;
        private void ExecuteCopyRelPath() => Clipboard.SetDataObject(FileModel.GetRelativeName(SelectedItem.FullName, ActiveMod));

        /// <summary>
        /// Reimports the game file to replace the current one
        /// </summary>
        public ICommand ReimportFileCommand { get; private set; }
        private bool CanReimportFile() => _projectManager.ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
        private void ExecuteReimportFile() => Task.Run(() => _gameController.GetController().AddToMod(SelectedItem.Hash));

        /// <summary>
        /// Cuts selected node to the clipboard.
        /// </summary>
        public ICommand CutFileCommand { get; private set; }
        private bool CanCutFile() => _projectManager.ActiveProject != null && SelectedItem != null;
        private void ExecuteCutFile()
        {
        }

        /// <summary>
        /// Delets selected node.
        /// </summary>
        public ICommand DeleteFileCommand { get; private set; }
        private bool CanDeleteFile()
        {
            var b = _projectManager.ActiveProject != null && SelectedItem != null;
            if (!b)
            {
                return false;
            }

            //if (ActiveMod is Tw3Project tw3Project)
            //{
            //    var item = SelectedItem.FullName;
            //    b &= !(item == tw3Project.ModDirectory
            //           || item == tw3Project.DlcDirectory
            //           || item == tw3Project.RawDirectory
            //           || item == tw3Project.RadishDirectory
            //           || item == tw3Project.ModCookedDirectory
            //           || item == tw3Project.ModUncookedDirectory
            //           || item == tw3Project.DlcCookedDirectory
            //           || item == tw3Project.DlcUncookedDirectory
            //        );
            //}

            return b;
        }
        /*
                /// <summary>
                /// Test stuff selected node.
                /// </summary>
                public ICommand TeststuffCommand { get; private set; }

                private async void Teststuff()
                {
                    var selected = SelectedItems.OfType<FileModel>().ToList();
                    var delete = await Interactions.DeleteFiles.Handle(selected.Select(_ => _.Name));
                    if (!delete)
                    {
                        return;
                    }
                }*/

        private async void ExecuteDeleteFile()
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
        private bool CanOpenInFileExplorer() => _projectManager.ActiveProject != null && SelectedItem != null;
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
        private bool CanPasteFile() => _projectManager.ActiveProject != null && SelectedItem != null && Clipboard.ContainsText();
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
        private bool CanRenameFile() => _projectManager.ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
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
                _ = Directory.CreateDirectory(Path.GetDirectoryName(newfullpath));
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
            var b = model.FullName.Contains(ActiveMod.RawDirectory);

            return b;
        }

        public ICommand Bk2ImportCommand { get; private set; }
        private bool CanBk2Import() => SelectedItem != null && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("avi");
        private void ExecuteBk2Import()
        {
            var modpath = Path.Combine(ActiveMod.ModDirectory, FileModel.GetRelativeName(SelectedItem.FullName, ActiveMod));
            modpath = Path.ChangeExtension(modpath, ".bk2");
            var directoryName = Path.GetDirectoryName(modpath);
            _ = Directory.CreateDirectory(directoryName);

            var args = $"\"{SelectedItem.FullName}\" \"{modpath}\" /o /#";
            var procInfo =
                new ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"))
                {
                    Arguments = args,
                    WorkingDirectory = ISettingsManager.GetWorkDir()
                };

            var process = Process.Start(procInfo);
            _ = (process?.WaitForInputIdle());
        }
        public ICommand Bk2ExportCommand { get; private set; }
        private bool CanBk2Export() => SelectedItem != null && !IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("bk2");
        private void ExecuteBk2Export()
        {
            var rawpath = Path.Combine(ActiveMod.RawDirectory, FileModel.GetRelativeName(SelectedItem.FullName, ActiveMod));
            rawpath = Path.ChangeExtension(rawpath, ".avi");
            var directoryName = Path.GetDirectoryName(rawpath);
            _ = Directory.CreateDirectory(directoryName);

            var args = $"\"{SelectedItem.FullName}\" \"{rawpath}\" /o /#";
            var procInfo =
                new ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(),
                    "testconv.exe"))
                {
                    Arguments = args,
                    WorkingDirectory = ISettingsManager.GetWorkDir()
                };

            var process = Process.Start(procInfo);
            _ = (process?.WaitForInputIdle());
        }

        public AsyncAwaitBestPractices.MVVM.IAsyncCommand ConvertToJsonCommand { get; private set; }
        public AsyncAwaitBestPractices.MVVM.IAsyncCommand ConvertToXmlCommand { get; private set; }

        private bool CanConvertTo(object arg) => SelectedItem != null
                && !IsInRawFolder(SelectedItem)
                //&& Enum.GetNames<ERedExtension>().Contains(SelectedItem.Extension.ToLower())
                ;

        private async Task ExecuteConvertToJsonAsync() => await ExecuteConvertToAsync(ETextConvertFormat.json);
        private async Task ExecuteConvertToXmlAsync() => await ExecuteConvertToAsync(ETextConvertFormat.xml);
        private async Task ExecuteConvertToAsync(ETextConvertFormat fmt)
        {
            if (SelectedItem.IsDirectory)
            {
                var progress = 0;
                _progressService.Report(0);

                var files = Directory.GetFiles(SelectedItem.FullName, "*", SearchOption.AllDirectories)
                    .ToList();
                foreach (var file in files)
                {
                    await ConvertTo(file, fmt);

                    progress++;
                    _progressService.Report(progress / (float)files.Count);
                }
            }
            else
            {
                var inpath = SelectedItem.FullName;
                await ConvertTo(inpath, fmt);
            }
        }

        private async Task ConvertTo(string file, ETextConvertFormat fmt)
        {
            if (!File.Exists(file))
            {
                return;
            }
            if (!Enum.GetNames<ERedExtension>().Contains(Path.GetExtension(file).TrimStart('.').ToLower()))
            {
                return;
            }

            var rawOutPath = Path.Combine(ActiveMod.RawDirectory, FileModel.GetRelativeName(file, ActiveMod));
            var outDirectoryPath = Path.GetDirectoryName(rawOutPath);
            if (outDirectoryPath != null)
            {
                _ = Directory.CreateDirectory(outDirectoryPath);

                _ = await Task.Run(() => _modTools.ConvertToAndWrite(fmt, file, new DirectoryInfo(outDirectoryPath)));
            }
        }


        public ICommand ConvertFromJsonCommand { get; private set; }
        private bool CanConvertFromJson() => SelectedItem != null
            && IsInRawFolder(SelectedItem)
            && SelectedItem.Extension.ToLower().Equals(ETextConvertFormat.json.ToString(), StringComparison.Ordinal);
        private void ExecuteConvertFromJson()
        {
            var inpath = SelectedItem.FullName;
            var modPath = Path.Combine(ActiveMod.ModDirectory, FileModel.GetRelativeName(SelectedItem.FullName, ActiveMod));
            var outDirectoryPath = Path.GetDirectoryName(modPath);
            if (outDirectoryPath != null)
            {
                _ = Directory.CreateDirectory(outDirectoryPath);

                _ = _modTools.ConvertFromAndWrite(new FileInfo(inpath), new DirectoryInfo(outDirectoryPath));
            }
        }

        /// <summary>
        /// Opens selected node in asset browser.
        /// </summary>
        public ICommand OpenInAssetBrowserCommand { get; private set; }
        private bool CanOpenInAssetBrowser() => _projectManager.ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
        private void ExecuteOpenInAssetBrowser()
        {
            Locator.Current.GetService<AppViewModel>().AssetBrowserVM.IsVisible = true;
            Locator.Current.GetService<AssetBrowserViewModel>().ShowFile(SelectedItem);
        }

        private static string GetSecondExtension(FileModel model) => Path.GetExtension(Path.ChangeExtension(model.FullName, "").TrimEnd('.')).TrimStart('.');

        public ICommand OpenInMlsbCommand { get; private set; }
        private bool CanOpenInMlsb() => _projectManager.ActiveProject != null
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
                    _ = Process.Start(exe, args);
                }
                catch (Exception ex)
                {
                    _loggerService.Error(ex);
                }
            }
        }

        #endregion

        #region Tw3 Commands

        ///// <summary>
        ///// Adds all dependencies (imports) of selected node from the game.
        ///// </summary>
        //public ICommand AddAllImportsCommand { get; private set; }

        //public ICommand CookCommand { get; private set; }

        ///// <summary>
        ///// Exports selected file to Json.
        ///// </summary>
        //public ICommand ExportJsonCommand { get; private set; }

        ///// <summary>
        ///// Exports selected node with wcc.
        ///// </summary>
        //public ICommand ExportMeshCommand { get; private set; }

        ///// <summary>
        /////  Opens the fast render Window for selected file
        ///// </summary>
        //public ICommand FastRenderCommand { get; private set; }


        //private async void AddAllImports() => await _tw3Controller.AddAllImportsAsync(SelectedItem.FullName, true);

        //private bool CanAddAllImports() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null && !SelectedItem.IsDirectory;

        //// legacy
        //private bool CanCook() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null;

        //private bool CanExportJson() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null
        //    && !SelectedItem.IsDirectory;

        //private bool CanExportMesh() => _projectManager.ActiveProject is EditorProject && SelectedItem != null
        //    && !SelectedItem.IsDirectory && SelectedItem.GetExtension() == ERedExtension.w2mesh.ToString();

        //private bool CanFastRender() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null
        //    && !SelectedItem.IsDirectory && SelectedItem.GetExtension() == ERedExtension.w2mesh.ToString();


        //private void Cook() => RequestFileCook(this, new RequestFileOpenArgs { File = SelectedItem.FullName });

        //private void ExecuteExportJson()
        //{
        //    // TODO: Handle command logic here
        //}

        //private void ExecuteFastRender()
        //{
        //    // TODO: Handle command logic here
        //}


        //public ICommand PESearchStartedCommand { get; private set; }

        //private bool CanPESearchStartedCommand(object arg) => true;

        //private void ExecutePESearchStartedCommand(object arg)
        //{
        //    if (arg is FunctionEventArgs<string> e)
        //    {
        //        PerformSearch(e.Info);
        //    }
        //}

        //private void PerformSearch(string query)
        //{
        //    // ??
        //}

        //private async void ExportMesh() => await Task.Run(() => _tw3Controller.ExportFileToMod(SelectedItem.FullName));

        #endregion Tw3 Commands

        #endregion commands

        #region Methods

        private void OnNext(IChangeSet<FileModel, ulong> obj) => BindGrid1 = new ObservableCollection<FileModel>(_observableList.Items);


        /// <summary>
        /// Initialize commands for this window.
        /// </summary>
        private void SetupCommands()
        {
            OpenFileCommand = new RelayCommand(ExecuteOpenFile, CanOpenFile);
            CutFileCommand = new RelayCommand(ExecuteCutFile, CanCutFile);
            CopyFileCommand = new RelayCommand(CopyFile, CanCopyFile);
            PasteFileCommand = new RelayCommand(PasteFile, CanPasteFile);
            DeleteFileCommand = new RelayCommand(ExecuteDeleteFile, CanDeleteFile);
            //TeststuffCommand = new RelayCommand(Teststuff, CanDeleteFile);
            RenameFileCommand = new RelayCommand(ExecuteRenameFile, CanRenameFile);
            CopyRelPathCommand = new RelayCommand(ExecuteCopyRelPath, CanCopyRelPath);
            ReimportFileCommand = new RelayCommand(ExecuteReimportFile, CanReimportFile);
            OpenInFileExplorerCommand = new RelayCommand(ExecuteOpenInFileExplorer, CanOpenInFileExplorer);

            OpenRootFolderCommand = new RelayCommand(ExecuteOpenRootFolder, CanOpenRootFolder);

            Bk2ImportCommand = new RelayCommand(ExecuteBk2Import, CanBk2Import);
            Bk2ExportCommand = new RelayCommand(ExecuteBk2Export, CanBk2Export);

            //CountUrlBytesCommand = new AsyncCommand(async () =>
            //{
            //    ByteCount = await MyService.DownloadAndCountBytesAsync(Url);
            //});
            ConvertToJsonCommand = new AsyncCommand(ExecuteConvertToJsonAsync, CanConvertTo);
            ConvertToXmlCommand = new AsyncCommand(ExecuteConvertToXmlAsync, CanConvertTo);
            ConvertFromJsonCommand = new RelayCommand(ExecuteConvertFromJson, CanConvertFromJson);

            //PESearchStartedCommand = new DelegateCommand<object>(ExecutePESearchStartedCommand, CanPESearchStartedCommand);

            //CookCommand = new RelayCommand(Cook, CanCook);
            //FastRenderCommand = new RelayCommand(ExecuteFastRender, CanFastRender);
            //ExportMeshCommand = new RelayCommand(ExportMesh, CanExportMesh);
            //AddAllImportsCommand = new RelayCommand(AddAllImports, CanAddAllImports);
            //ExportJsonCommand = new RelayCommand(ExecuteExportJson, CanExportJson);
            OpenInAssetBrowserCommand = new RelayCommand(ExecuteOpenInAssetBrowser, CanOpenInAssetBrowser);
            OpenInMlsbCommand = new RelayCommand(ExecuteOpenInMlsb, CanOpenInMlsb);
        }

        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;


        //private async void RequestFileCook(object sender, RequestFileOpenArgs e)
        //{
        //    if (ActiveMod is not Tw3Project tw3mod)
        //    {
        //        return;
        //    }

        //    var filename = e.File;
        //    var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
        //    if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
        //    {
        //        return;
        //    }

        //    var dir = File.Exists(fullpath) ? Path.GetDirectoryName(fullpath) : fullpath;
        //    var reldir = dir[(ActiveMod.FileDirectory.Length + 1)..];

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
