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
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Extensions;
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
    public partial class ProjectExplorerViewModel : ToolViewModel
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

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
        private IPluginService _pluginService;

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
                    Locator.Current.GetService<AppViewModel>().NotNull().SelectFileCommand.SafeExecute(model);
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

        public bool IsKeyUpEventAssigned { get; set; }

        public AppViewModel MainViewModel => Locator.Current.GetService<AppViewModel>().NotNull();

        public ReactiveCommand<Unit, Unit> ExpandAll { get; private set; }

        public ReactiveCommand<Unit, Unit> CollapseAll { get; private set; }

        public ReactiveCommand<Unit, Unit> CollapseChildren { get; private set; }

        public ReactiveCommand<Unit, Unit> ExpandChildren { get; private set; }

        [ObservableProperty] private ObservableCollection<FileModel> _bindGrid1 = new();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RefreshCommand))]
        [NotifyCanExecuteChangedFor(nameof(OpenRootFolderCommand))]
        [NotifyCanExecuteChangedFor(nameof(CopyFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
        [NotifyCanExecuteChangedFor(nameof(ReimportFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(CutFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(OpenInFileExplorerCommand))]
        [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(Bk2ImportCommand))]
        [NotifyCanExecuteChangedFor(nameof(Bk2ExportCommand))]
        [NotifyCanExecuteChangedFor(nameof(ConvertToCommand))]
        [NotifyCanExecuteChangedFor(nameof(ConvertFromCommand))]
        [NotifyCanExecuteChangedFor(nameof(OpenInAssetBrowserCommand))]
        [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
        private Cp77Project? _activeProject;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CopyFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
        [NotifyCanExecuteChangedFor(nameof(ReimportFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(CutFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(OpenInFileExplorerCommand))]
        [NotifyCanExecuteChangedFor(nameof(PasteFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(RenameFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(Bk2ImportCommand))]
        [NotifyCanExecuteChangedFor(nameof(Bk2ExportCommand))]
        [NotifyCanExecuteChangedFor(nameof(ConvertToCommand))]
        [NotifyCanExecuteChangedFor(nameof(ConvertFromCommand))]
        [NotifyCanExecuteChangedFor(nameof(OpenInAssetBrowserCommand))]
        [NotifyCanExecuteChangedFor(nameof(OpenInMlsbCommand))]
        private FileModel? _selectedItem;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteFileCommand))]
        private ObservableCollection<object>? _selectedItems = new();

        [ObservableProperty] private bool _isFlatModeEnabled;

        [ObservableProperty] private int _selectedTabIndex;

        public FileModel? LastSelected => _watcherService.LastSelect;

        #endregion properties

        #region commands

        #region general commands

        /// <summary>
        /// Refreshes all files in the Grid
        /// </summary>
        private bool CanRefresh() => ActiveProject != null;
        [RelayCommand(CanExecute =nameof(CanRefresh))]
        private Task Refresh() => _watcherService.RefreshAsync(ActiveProject.NotNull());

        /// <summary>
        /// Opens the currently selected folder in the tab
        /// </summary>
        private bool CanOpenRootFolder() => ActiveProject != null;
        [RelayCommand(CanExecute = nameof(CanOpenRootFolder))]
        private void OpenRootFolder()
        {
            switch (SelectedTabIndex)
            {
                case 0:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().FileDirectory);
                    break;
                case 1:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().ModDirectory);
                    break;
                case 2:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().RawDirectory);
                    break;
                case 3:
                    Commonfunctions.ShowFolderInExplorer(ActiveProject.NotNull().ResourcesDirectory);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Copies selected node to the clipboard.
        /// </summary>
        private bool CanCopyFile() => ActiveProject != null && SelectedItem != null;
        [RelayCommand(CanExecute = nameof(CanCopyFile))]
        private void CopyFile() => Clipboard.SetDataObject(SelectedItem.NotNull().FullName);

        /// <summary>
        /// Copies relative path of node.
        /// </summary>
        private bool CanCopyRelPath() => ActiveProject != null && SelectedItem != null;
        [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
        private void CopyRelPath() => Clipboard.SetDataObject(FileModel.GetRelativeName(SelectedItem.NotNull().FullName, ActiveProject.NotNull()));

        /// <summary>
        /// Reimports the game file to replace the current one
        /// </summary>
        private bool CanReimportFile() => ActiveProject != null && SelectedItem != null && !IsInRawFolder(SelectedItem);
        [RelayCommand(CanExecute = nameof(CanReimportFile))]
        private async Task ReimportFile()
        {
            if (SelectedItem.NotNull().IsDirectory)
            {
                _watcherService.IsSuspended = true;

                var progress = 0;
                _progressService.Report(0);

                var files = Directory.GetFiles(SelectedItem.FullName, "*", SearchOption.AllDirectories).ToList();
                foreach (var file in files)
                {
                    var relPath = FileModel.GetRelativeName(file, ActiveProject.NotNull());
                    var hash = FNV1A64HashAlgorithm.HashString(relPath);
                    await Task.Run(() => _gameController.GetController().AddToMod(hash));

                    progress++;
                    _progressService.Report(progress / (float)files.Count);
                }

                _watcherService.IsSuspended = false;
                await _watcherService.RefreshAsync(ActiveProject.NotNull());

                _progressService.Completed();
            }
            else
            {
                _gameController.GetController().AddToMod(SelectedItem.Hash);
            }
        }

        /// <summary>
        /// Cuts selected node to the clipboard.
        /// </summary>
        private bool CanCutFile() => ActiveProject != null && SelectedItem != null;
        [RelayCommand(CanExecute = nameof(CanCutFile))]
        private void CutFile() => throw new NotImplementedException();

        /// <summary>
        /// Delets selected node.
        /// </summary>
        private bool CanDeleteFile() => ActiveProject != null && SelectedItems != null;
        [RelayCommand(CanExecute = nameof(CanDeleteFile))]
        public async void DeleteFile()
        {
            var selected = SelectedItems.NotNull().OfType<FileModel>().ToList();
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
        private bool CanOpenInFileExplorer() => ActiveProject != null && SelectedItem != null;
        [RelayCommand(CanExecute = nameof(CanOpenInFileExplorer))]
        private void OpenInFileExplorer()
        {
            if (SelectedItem.NotNull().IsDirectory)
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
        private bool CanPasteFile() => ActiveProject != null && SelectedItem != null && Clipboard.ContainsText();
        [RelayCommand(CanExecute = nameof(CanPasteFile))]
        private void PasteFile()
        {
            if (File.Exists(Clipboard.GetText()))
            {
                var attr = File.GetAttributes(SelectedItem.NotNull().FullName);
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

                var dir = Path.GetDirectoryName(path).NotNull();
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
        private bool CanRenameFile() => ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
        [RelayCommand(CanExecute = nameof(CanRenameFile))]
        private async void RenameFile()
        {
            var filename = SelectedItem.NotNull().FullName;
            var newfilename = await Interactions.Rename.Handle(filename);

            if (string.IsNullOrEmpty(newfilename))
            {
                return;
            }

            var newfullpath = Path.Combine(Path.GetDirectoryName(filename).NotNull(), newfilename);

            if (File.Exists(newfullpath))
            {
                return;
            }

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(newfullpath).NotNull());
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

        private bool IsInRawFolder(FileModel model) => ActiveProject is not null && model.FullName.Contains(ActiveProject.RawDirectory);

        private bool CanBk2Import() => SelectedItem != null && IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("avi") && ActiveProject is not null;
        [RelayCommand(CanExecute = nameof(CanBk2Import))]
        private void Bk2Import()
        {
            var modpath = Path.Combine(ActiveProject.NotNull().ModDirectory, FileModel.GetRelativeName(SelectedItem.NotNull().FullName, ActiveProject));
            modpath = Path.ChangeExtension(modpath, ".bk2");
            var directoryName = Path.GetDirectoryName(modpath).NotNull();
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

        private bool CanBk2Export() => SelectedItem != null && !IsInRawFolder(SelectedItem) && SelectedItem.Extension.ToLower().Contains("bk2") && ActiveProject is not null;
        [RelayCommand(CanExecute = nameof(CanBk2Export))]
        private void Bk2Export()
        {
            var rawpath = Path.Combine(ActiveProject.NotNull().RawDirectory, FileModel.GetRelativeName(SelectedItem.NotNull().FullName, ActiveProject));
            rawpath = Path.ChangeExtension(rawpath, ".avi");
            var directoryName = Path.GetDirectoryName(rawpath).NotNull();
            Directory.CreateDirectory(directoryName);

            var args = $"\"{SelectedItem.FullName}\" \"{rawpath}\" /o /#";
            var procInfo =
                new ProcessStartInfo(Path.Combine(ISettingsManager.GetWorkDir(),
                    "testconv.exe"))
                {
                    Arguments = args,
                    WorkingDirectory = ISettingsManager.GetWorkDir()
                };

            var process = Process.Start(procInfo);
            process?.WaitForInputIdle();
        }

        private bool CanConvertTo() => SelectedItem != null && !IsInRawFolder(SelectedItem) && ActiveProject is not null;
        [RelayCommand(CanExecute = nameof(CanConvertTo))]
        private async Task ConvertToAsync()
        {
            if (SelectedItem.NotNull().IsDirectory)
            {
                _watcherService.IsSuspended = true;

                var progress = 0;
                _progressService.Report(0);

                var files = Directory.GetFiles(SelectedItem.FullName, "*", SearchOption.AllDirectories).ToList();
                foreach (var file in files)
                {
                    await ConvertToTask(file);

                    progress++;
                    _progressService.Report(progress / (float)files.Count);
                }

                _watcherService.IsSuspended = false;
                await _watcherService.RefreshAsync(ActiveProject.NotNull());

                _progressService.Completed();
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

            var rawOutPath = Path.Combine(ActiveProject.NotNull().RawDirectory, FileModel.GetRelativeName(file, ActiveProject));
            var outDirectoryPath = Path.GetDirectoryName(rawOutPath);
            if (outDirectoryPath != null)
            {
                Directory.CreateDirectory(outDirectoryPath);

                return Task.Run(() => _modTools.ConvertToAndWrite(ETextConvertFormat.json, file, new DirectoryInfo(outDirectoryPath)));
            }

            return Task.CompletedTask;
        }


        private bool CanConvertFromJson() => SelectedItem != null && IsInRawFolder(SelectedItem) && ActiveProject is not null;
        [RelayCommand(CanExecute = nameof(CanConvertFromJson))]
        private async Task ConvertFromAsync()
        {
            if (SelectedItem.NotNull().IsDirectory)
            {
                _watcherService.IsSuspended = true;

                var progress = 0;
                _progressService.Report(0);

                var files = Directory.GetFiles(SelectedItem.FullName, "*.json", SearchOption.AllDirectories).Where(name => !name.EndsWith(".Material.json")).ToList();
                foreach (var file in files)
                {
                    await ConvertFromTask(file);

                    progress++;
                    _progressService.Report(progress / (float)files.Count);
                }

                _watcherService.IsSuspended = false;
                await _watcherService.RefreshAsync(ActiveProject.NotNull());

                _progressService.Completed();
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

            var modPath = Path.Combine(ActiveProject.NotNull().ModDirectory, FileModel.GetRelativeName(file, ActiveProject));
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
        private bool CanOpenInAssetBrowser() => ActiveProject != null && SelectedItem != null && !SelectedItem.IsDirectory;
        [RelayCommand(CanExecute = nameof(CanOpenInAssetBrowser))]
        private void OpenInAssetBrowser()
        {
            Locator.Current.GetService<AppViewModel>().NotNull().AssetBrowserViewModel.IsVisible = true;
            Locator.Current.GetService<AssetBrowserViewModel>().NotNull().ShowFile(SelectedItem.NotNull());
        }

        private static string GetSecondExtension(FileModel model) => Path.GetExtension(Path.ChangeExtension(model.FullName, "").TrimEnd('.')).TrimStart('.');

        private bool CanOpenInMlsb()
        {
            return ActiveProject != null
            && SelectedItem != null
            && !SelectedItem.IsDirectory
            && IsInRawFolder(SelectedItem)
            && SelectedItem.Extension.ToLower().Equals(ETextConvertFormat.json.ToString(), StringComparison.Ordinal)
            && GetSecondExtension(SelectedItem).Equals(ERedExtension.mlsetup.ToString(), StringComparison.Ordinal)
            && PluginService.IsInstalled(EPlugin.mlsetupbuilder);
        }

        [RelayCommand(CanExecute = nameof(CanOpenInMlsb))]
        private void OpenInMlsb()
        {
            if (PluginService.TryGetInstallPath(EPlugin.mlsetupbuilder, out var path))
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

                var filepath = SelectedItem.NotNull().FullName;
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

        public event EventHandler? BeforeDataSourceUpdate;
        public event EventHandler? AfterDataSourceUpdate;

        private void OnNext(IChangeSet<FileModel, ulong> obj)
        {
            BeforeDataSourceUpdate?.Invoke(this, EventArgs.Empty);

            BindGrid1 = new ObservableCollection<FileModel>(_observableList.Items);

            AfterDataSourceUpdate?.Invoke(this, EventArgs.Empty);
        }

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
