using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using Catel.Threading;
using Orc.FileSystem;
using Orc.ProjectManagement;
using WolvenKit.Functionality.Commands;
using WolvenKit.Model;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.Model.ProjectManagement;
using Open.ChannelExtensions;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.ViewModels
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
        public const string ToolTitle = "ProjectExplorer";

        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly ICommandManager _commandManager;
        private readonly IProjectRefresherSelector _refresherSelector;


        private EditorProject ActiveMod => _projectManager.ActiveProject as EditorProject;
        private readonly ConcurrentDictionary<ulong, FileSystemInfoModel> _flatNodeDictionary;

        #endregion

        #region constructors

        public ProjectExplorerViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService,
            ICommandManager commandManager,
            IProjectRefresherSelector refresherSelector
            ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => refresherSelector);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _commandManager = commandManager;
            _refresherSelector = refresherSelector;
            if (_refresherSelector is MyProjectRefresherSelector myrefresher)
            {
                myrefresher.ProjectRefresherUpdatedAsync += OnProjectRefresherUpdatedAsync;
            }

            SetupCommands();
            SetupToolDefaults();

            _flatNodeDictionary = new ConcurrentDictionary<ulong, FileSystemInfoModel>();
            Treenodes = new BindingList<FileSystemInfoModel>();
            Treenodes.ListChanged += new ListChangedEventHandler(Treenodes_ListChanged);

        }

        

        #endregion constructors

        #region properties

        

        private BindingList<FileSystemInfoModel> _treenodes = null;
        public BindingList<FileSystemInfoModel> Treenodes
        {
            get => _treenodes;
            set
            {
                if (_treenodes != value)
                {
                    var oldValue = _treenodes;
                    _treenodes = value;
                    RaisePropertyChanged(() => Treenodes, oldValue, value);
                }
            }
        }

        private FileSystemInfoModel _selectedItem;
        public FileSystemInfoModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    var oldValue = _selectedItem;
                    _selectedItem = value;
                    RaisePropertyChanged(() => SelectedItem, oldValue, value);
                }
            }
        }

        #endregion

        #region commands

        /// <summary>
        /// Refresh a node in the ProjectExplorer tree with a given physical path
        /// </summary>
        public ICommand RefreshNodeCommand { get; private set; }
        private bool CanRefreshNode(string path) => true;
        private void ExecuteRefreshNode(string path)
        {
            var dir = new DirectoryInfo(path);
            var fi = new FileInfo(path);
            if (string.IsNullOrEmpty(path))
                return;
            if (fi.Exists)
                dir = fi.Directory;
            if (!dir.Exists)
                return;

            // get parents
            var dirlist = new List<DirectoryInfo>();
            var currentdir = dir;
            while (currentdir.Parent != null && currentdir.FullName != ActiveMod.FileDirectory)
            {
                dirlist.Add(currentdir);
                currentdir = currentdir.Parent;
            }
            dirlist.Reverse();

            if (dirlist.Count < 1)
            {
                return;
            }

            // descend down and update last
            var m = Treenodes.FirstOrDefault(_ => _.IsDirectory && _.FullName == dirlist.First().FullName);
            if (m == null)
            {
                return;
            }

            m.IsExpanded = true;
            for (var i = 1; i < dirlist.Count; i++)
            {
                var node = dirlist[i];
                var x = m.Children.FirstOrDefault(_ => _.IsDirectory && _.FullName == node.FullName);
                if (x == null)
                {
                    if (i < dirlist.Count - 1)
                    {
                        //TODO: make this better
                        m.ReloadSync();
                        x = m.Children.FirstOrDefault(_ => _.IsDirectory && _.FullName == node.FullName);
                        if (x == null)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                m = x;
                if (!m.IsExpanded)
                {
                    m.IsExpanded = true;
                }
            }

            m?.RaiseRequestRefresh();
        }

        #region general commands

        /// <summary>
        /// Copies relative path of node.
        /// </summary>
        public ICommand CopyRelPathCommand { get; private set; }
        private bool CanCopyRelPath() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;
        private void ExecuteCopyRelPath()
        {
            if (SelectedItem.IsFile)
                Clipboard.SetText(GetArchivePath(SelectedItem.FullName));

            string GetArchivePath(string s)
            {
                if (s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Length > 2)
                {
                    var relpath = s.Substring(ActiveMod.FileDirectory.Length + 1);
                    return string.Join(Path.DirectorySeparatorChar.ToString(), relpath.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(2).ToArray());
                }
                else
                    return s;
            }
        }

        /// <summary>
        /// Opens selected node in File Explorer.
        /// </summary>
        public ICommand OpenInFileExplorerCommand { get; private set; }
        private bool CanOpenInFileExplorer() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;
        private void ExecuteOpenInFileExplorer()
        {
            if (SelectedItem.IsDirectory)
                Commonfunctions.ShowFolderInExplorer(SelectedItem.FullName);
            else
                Commonfunctions.ShowFileInExplorer(SelectedItem.FullName);
        }

        /// <summary>
        /// Expands all nodes in the treeview.
        /// </summary>
        public ICommand ExpandAllCommand { get; private set; }
        private bool CanExpandAll() => _projectManager.ActiveProject is EditorProject;
        private void ExecuteExpandAll()
        {
            foreach (var node in Treenodes) node.ExpandChildren(true);
        }

        /// <summary>
        /// Collapses all nodes in the treeview.
        /// </summary>
        public ICommand CollapseAllCommand { get; private set; }
        private bool CanCollapseAll() => _projectManager.ActiveProject is EditorProject;
        private void ExecuteCollapseAll()
        {
            foreach (var node in Treenodes) node.CollapseChildren(true);
        }

        /// <summary>
        /// Expands all children of the selected node.
        /// </summary>
        public ICommand ExpandCommand { get; private set; }
        private bool CanExpand() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;
        private void ExecuteExpand() => SelectedItem.ExpandChildren(true);

        /// <summary>
        /// Collapses all children of the selected node.
        /// </summary>
        public ICommand CollapseCommand { get; private set; }
        private bool CanCollapse() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;
        private void ExecuteCollapse() => SelectedItem.CollapseChildren(true);

        /// <summary>
        /// Delets selected node.
        /// </summary>
        public ICommand DeleteFileCommand { get; private set; }
        private bool CanDeleteFile()
        {
            var b = _projectManager.ActiveProject is EditorProject && SelectedItem != null;
            if (!b)
                return false;

            if (ActiveMod is Tw3Project tw3Project)
            {
                var item = SelectedItem.FullName;
                b &= !(item == tw3Project.ModDirectory
                       || item == tw3Project.DlcDirectory
                       || item == tw3Project.RawDirectory
                       || item == tw3Project.RadishDirectory
                       || item == tw3Project.ModCookedDirectory
                       || item == tw3Project.ModUncookedDirectory
                       || item == tw3Project.DlcCookedDirectory
                       || item == tw3Project.DlcUncookedDirectory
                    );
            }


            
            return b;
        }
        private async void ExecuteDeleteFile()
        {
            //// TODO: close open documents

            if (await _messageService.ShowAsync(
                    "Are you sure you want to delete this?", "Are you sure?", MessageButton.YesNo) !=
                MessageResult.Yes) return;

            // Delete from file structure
            var fullpath = SelectedItem.FullName;
            try
            {
                // TODO
                var _fileService = ServiceLocator.Default.ResolveType<IFileService>();
                var _directoryService = ServiceLocator.Default.ResolveType<IDirectoryService>();

                if (SelectedItem.IsDirectory)
                {
                    _directoryService.Delete(fullpath);
                    //Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(fullpath
                    //    , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                    //    , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
                else
                {
                    _fileService.Delete(fullpath);
                    //Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(fullpath
                    //    , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                    //    , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
            }
            catch (Exception)
            {
                MainController.LogString("Failed to delete " + fullpath + "!\r\n", Common.Services.Logtype.Error);
            }
            finally
            {
                //SelectedItem.RaiseRequestRefresh();
            }
        }

        /// <summary>
        /// Renames selected node. 
        /// </summary>
        public ICommand RenameFileCommand { get; private set; }
        private bool CanRenameFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;
        private async void ExecuteRenameFile()
        {
            var filename = SelectedItem.FullName;
            
            var visualizerService = ServiceLocator.Default.ResolveType<IUIVisualizerService>();
            var viewModel = new Dialogs.InputDialogViewModel() {Text = filename};
            await visualizerService.ShowDialogAsync(viewModel, delegate(object sender, UICompletedEventArgs args)
            {
                if (args.Result != true)
                    return;
                if (args.DataContext is not Dialogs.InputDialogViewModel vm)
                    return;
                var newfullpath = Path.Combine(ActiveMod.FileDirectory, vm.Text);

                if (File.Exists(newfullpath))
                    return;

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
                finally
                {
                    //SelectedItem.RaiseRequestRefresh();
                }
                
            });
        }

        /// <summary>
        /// Cuts selected node to the clipboard.
        /// </summary>
        public ICommand CutFileCommand { get; private set; }
        private bool CanCutFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;
        private void ExecuteCutFile()
        {
            // TODO: Handle command logic here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Copies selected node to the clipboard.
        /// </summary>
        public ICommand CopyFileCommand { get; private set; }
        private bool CanCopyFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;
        private void CopyFile() => Clipboard.SetText(SelectedItem.FullName);

        /// <summary>
        /// Pastes a file from the clipboard into selected node.
        /// </summary>
        public ICommand PasteFileCommand { get; private set; }
        private bool CanPasteFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null && Clipboard.ContainsText();
        private void PasteFile()
        {
            if (File.Exists(Clipboard.GetText()))
            {
                FileAttributes attr = File.GetAttributes(SelectedItem.FullName);
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

        #endregion

        #region Tw3 Commands

        /// <summary>
        /// Opens selected node in asset browser.
        /// </summary>
        public ICommand OpenInAssetBrowserCommand { get; private set; }
        private bool CanOpenInAssetBrowser() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null;
        private void ExecuteOpenInAssetBrowser()
        {
            // TODO: Handle command logic here
        }

        /// <summary>
        /// Exports selected file to Json.
        /// </summary>
        public ICommand ExportJsonCommand { get; private set; }
        private bool CanExportJson() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null
            && SelectedItem.IsFile;
        private void ExecuteExportJson()
        {
            // TODO: Handle command logic here
        }

        /// <summary>
        ///  Opens the fast render Window for selected file
        /// </summary>
        public ICommand FastRenderCommand { get; private set; }
        private bool CanFastRender() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null 
            && SelectedItem.IsFile && SelectedItem.Extension == ".w2mesh";
        private void ExecuteFastRender()
        {
            // TODO: Handle command logic here
        }

        /// <summary>
        /// Exports selected node with wcc.
        /// </summary>
        public ICommand ExportMeshCommand { get; private set; }
        private bool CanExportMesh() => _projectManager.ActiveProject is EditorProject && SelectedItem != null 
            && SelectedItem.IsFile && SelectedItem.Extension == ".w2mesh";
        private async void ExportMesh() => await Task.Run(() => WccHelper.ExportFileToMod(SelectedItem.FullName));

        /// <summary>
        /// Adds all dependencies (imports) of selected node from the game.
        /// </summary>
        public ICommand AddAllImportsCommand { get; private set; }
        private bool CanAddAllImports() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null && SelectedItem.IsFile;
        private async void AddAllImports() => await WccHelper.AddAllImportsAsync(SelectedItem.FullName, true);


        // legacy

        public ICommand CookCommand { get; private set; }
        private bool CanCook() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null;
        private void Cook() => RequestFileCook(this, new RequestFileOpenArgs { File = SelectedItem.FullName });

        #endregion

        #endregion

        #region Methods

        private void RepopulateTreeView()
        {
            if (ActiveMod == null)
            {
                return;
            }

            Treenodes.Clear();
            var fileDirectoryInfo = new DirectoryInfo(ActiveMod.FileDirectory);
            foreach (var fileSystemInfo in fileDirectoryInfo.GetFileSystemInfos("*", SearchOption.TopDirectoryOnly))
            {
                Treenodes.Add(new FileSystemInfoModel(fileSystemInfo, null));
            }
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            var commandManager = ServiceLocator.Default.ResolveType<ICommandManager>();
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.ExpandAll, ExpandAllCommand, this);
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.CollapseAll, CollapseAllCommand, this);
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.Expand, ExpandCommand, this);
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.Collapse, CollapseCommand, this);

            _projectManager.ProjectRefreshRequiredAsync += ProjectManagerOnProjectRefreshRequiredAsync;
            _projectManager.ProjectActivatedAsync += OnProjectActivatedAsync;
        }

        private Task ProjectManagerOnProjectRefreshRequiredAsync(object sender, ProjectEventArgs e)
        {
            return Task.CompletedTask;
        }

        private Task OnProjectActivatedAsync(object sender, ProjectUpdatedEventArgs args)
        {
            var activeProject = args.NewProject;
            if (activeProject == null)
            {
                return TaskHelper.Completed;
            }

            RepopulateTreeView();

            return TaskHelper.Completed;
        }

        /// <summary>
        /// Is raised when the PorjectRefresher registers a filesytem change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async Task OnProjectRefresherUpdatedAsync(object sender, ProjectEventArgs e)
        {
            if (e is ProjectFileSystemEventArgs args)
            {
                await Channel
                    .CreateBounded<string>(50000)
                    .Source(args.FileNames)
                    .ReadAllAsync(async path =>
                    {
                        await Task.Run(() => RefreshNodeCommand.SafeExecute(path));
                    });
            }
        }

        /// <summary>
        /// Initialize commands for this window.
        /// </summary>
        private void SetupCommands()
        {
            CutFileCommand = new RelayCommand(ExecuteCutFile, CanCutFile);
            CopyFileCommand = new RelayCommand(CopyFile, CanCopyFile);
            PasteFileCommand = new RelayCommand(PasteFile, CanPasteFile);
            DeleteFileCommand = new RelayCommand(ExecuteDeleteFile, CanDeleteFile);
            RenameFileCommand = new RelayCommand(ExecuteRenameFile, CanRenameFile);
            CopyRelPathCommand = new RelayCommand(ExecuteCopyRelPath, CanCopyRelPath);
            OpenInFileExplorerCommand = new RelayCommand(ExecuteOpenInFileExplorer, CanOpenInFileExplorer);

            CookCommand = new RelayCommand(Cook, CanCook);
            FastRenderCommand = new RelayCommand(ExecuteFastRender, CanFastRender);
            ExportMeshCommand = new RelayCommand(ExportMesh, CanExportMesh);
            AddAllImportsCommand = new RelayCommand(AddAllImports, CanAddAllImports);
            ExportJsonCommand = new RelayCommand(ExecuteExportJson, CanExportJson);
            OpenInAssetBrowserCommand = new RelayCommand(ExecuteOpenInAssetBrowser, CanOpenInAssetBrowser);

            // global commands
            ExpandAllCommand = new RelayCommand(ExecuteExpandAll, CanExpandAll);
            CollapseAllCommand = new RelayCommand(ExecuteCollapseAll, CanCollapseAll);
            ExpandCommand = new RelayCommand(ExecuteExpand, CanExpand);
            CollapseCommand = new RelayCommand(ExecuteCollapse, CanCollapse);

            RefreshNodeCommand = new DelegateCommand<string>(ExecuteRefreshNode, CanRefreshNode);
            _commandManager.RegisterCommand(AppCommands.ProjectExplorer.Refresh, RefreshNodeCommand, this);
        }

        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;           // Define a unique contentid for this toolwindow

            //BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow
            //bi.BeginInit();
            //bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");
            //bi.EndInit();
            //IconSource = bi;
        }

        

        protected override async Task CloseAsync()
        {
            _projectManager.ProjectActivatedAsync -= OnProjectActivatedAsync;

            await base.CloseAsync();
        }

        void Treenodes_ListChanged(object sender, ListChangedEventArgs e)
        {
            //RaisePropertyChanged(nameof(Treenodes));
        }

        private async void RequestFileCook(object sender, RequestFileOpenArgs e)
        {
            if (ActiveMod is not Tw3Project tw3mod)
            {
                return;
            }

            var filename = e.File;
            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
            {
                return;
            }

            var dir = File.Exists(fullpath) ? Path.GetDirectoryName(fullpath) : fullpath;
            var reldir = dir.Substring(ActiveMod.FileDirectory.Length + 1);

            // Trim working directories in path
            var reg = new Regex(@"^(Raw|Mod|DLC)\\(.*)");
            var match = reg.Match(reldir);
            var isDlc = false;
            if (match.Success)
            {
                reldir = match.Groups[2].Value;
                if (match.Groups[1].Value == "Raw")
                {
                    return;
                }
                else if (match.Groups[1].Value == "DLC")
                {
                    isDlc = true;
                }
                else if (match.Groups[1].Value == "Mod")
                {
                    isDlc = false;
                }
            }

            if (reldir.StartsWith(EProjectFolders.Cooked.ToString()))
            {
                reldir = reldir.Substring(EProjectFolders.Cooked.ToString().Length);
            }

            if (reldir.StartsWith(EProjectFolders.Uncooked.ToString()))
                reldir = reldir.Substring(EProjectFolders.Uncooked.ToString().Length);
            
            reldir = reldir.TrimStart(Path.DirectorySeparatorChar);

            // create cooked mod Dir
            var cookedtargetDir = isDlc 
                ? Path.Combine(tw3mod.DlcCookedDirectory, reldir) 
                : Path.Combine(tw3mod.ModCookedDirectory, reldir);
            if (!Directory.Exists(cookedtargetDir))
            {
                Directory.CreateDirectory(cookedtargetDir);
            }

            // lazy check for existing files in Active Mod
            var filenames = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
                .Select(_ => Path.GetFileName(_));
            var existingfiles = Directory.GetFiles(cookedtargetDir, "*.*", SearchOption.AllDirectories)
                .Select(_ => Path.GetFileName(_));

            if (existingfiles.Intersect(filenames).Any())
            {
                //if (MessageBox.Show(
                //     "Some of the files you are about to cook already exist in your mod. These files will be overwritten. Are you sure you want to permanently overwrite them?"
                //     , "Confirmation", MessageBoxButtons.YesNo
                // ) != DialogResult.Yes)
                //{
                //    return;
                //}
            }

            try
            {
                var cook = new Wcc_lite.cook()
                {
                    Platform = platform.pc,
                    mod = dir,
                    basedir = dir,
                    outdir = cookedtargetDir
                };
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(cook));
            }

            catch (Exception)
            {
                MainController.LogString("Error cooking files.", Logtype.Error);
            }
        }
        
        #endregion

    }
}
