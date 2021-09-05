using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Input;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
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
        //private readonly Tw3Controller _tw3Controller;
        //private readonly AppViewModel _appViewModel;

        private EditorProject ActiveMod => _projectManager.ActiveProject;
        private readonly IObservableList<FileModel> _observableList;

        #endregion fields

        #region constructors

        public ProjectExplorerViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IWatcherService watcherService
            //Tw3Controller tw3Controller
            //IAppViewModel appViewModel
            ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _watcherService = watcherService;
            //_tw3Controller = tw3Controller;

            SetupCommands();
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


        public FileModel LastSelected => _watcherService.LastSelect;

        #endregion properties

        #region commands

        #region general commands

        public ICommand OpenFileCommand { get; private set; }

        private bool CanOpenFile() => true;

        private void ExecuteOpenFile()
        {
            // TODO: Handle command logic here
            Locator.Current.GetService<AppViewModel>().OpenFileCommand.SafeExecute(SelectedItem);




        }

        


        /// <summary>
        /// Copies selected node to the clipboard.
        /// </summary>
        public ICommand CopyFileCommand { get; private set; }

        private bool CanCopyFile() => _projectManager.ActiveProject != null && SelectedItem != null;

        private void ExecuteCopyRelPath() => Clipboard.SetText(SelectedItem.Name);

        /// <summary>
        /// Copies relative path of node.
        /// </summary>
        public ICommand CopyRelPathCommand { get; private set; }

        private bool CanCopyRelPath() => _projectManager.ActiveProject != null && SelectedItem != null;

        private void CopyFile() => Clipboard.SetText(SelectedItem.FullName);

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
                    _loggerService.LogString("Failed to delete " + fullpath + ".\r\n", Logtype.Error);
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

        public ICommand Bk2ImportCommand { get; private set; }

        private bool CanBk2Import() => SelectedItem.Extension.ToLower().Contains("avi");

        private void ExecuteBk2Import()
        {
            var modpath = Path.Combine(ActiveMod.ModDirectory, SelectedItem.GetRelativeName(ActiveMod));
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

        private bool CanBk2Export() => SelectedItem.Extension.ToLower().Contains("bk2");

        private void ExecuteBk2Export()
        {
            var rawpath = Path.Combine(ActiveMod.RawDirectory, SelectedItem.GetRelativeName(ActiveMod));
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

        ///// <summary>
        ///// Opens selected node in asset browser.
        ///// </summary>
        //public ICommand OpenInAssetBrowserCommand { get; private set; }

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

        //private bool CanOpenInAssetBrowser() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null;

        //private void Cook() => RequestFileCook(this, new RequestFileOpenArgs { File = SelectedItem.FullName });

        //private void ExecuteExportJson()
        //{
        //    // TODO: Handle command logic here
        //}

        //private void ExecuteFastRender()
        //{
        //    // TODO: Handle command logic here
        //}

        //private void ExecuteOpenInAssetBrowser()
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

        private void OnNext(IChangeSet<FileModel, ulong> obj)
        {
            BindGrid1 = new ObservableCollection<FileModel>(_observableList.Items);
        }


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
            RenameFileCommand = new RelayCommand(ExecuteRenameFile, CanRenameFile);
            CopyRelPathCommand = new RelayCommand(ExecuteCopyRelPath, CanCopyRelPath);
            OpenInFileExplorerCommand = new RelayCommand(ExecuteOpenInFileExplorer, CanOpenInFileExplorer);

            Bk2ImportCommand = new RelayCommand(ExecuteBk2Import, CanBk2Import);
            Bk2ExportCommand = new RelayCommand(ExecuteBk2Export, CanBk2Export);

            //PESearchStartedCommand = new DelegateCommand<object>(ExecutePESearchStartedCommand, CanPESearchStartedCommand);

            //CookCommand = new RelayCommand(Cook, CanCook);
            //FastRenderCommand = new RelayCommand(ExecuteFastRender, CanFastRender);
            //ExportMeshCommand = new RelayCommand(ExportMesh, CanExportMesh);
            //AddAllImportsCommand = new RelayCommand(AddAllImports, CanAddAllImports);
            //ExportJsonCommand = new RelayCommand(ExecuteExportJson, CanExportJson);
            //OpenInAssetBrowserCommand = new RelayCommand(ExecuteOpenInAssetBrowser, CanOpenInAssetBrowser);
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
