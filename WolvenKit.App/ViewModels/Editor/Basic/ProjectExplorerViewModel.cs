using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using DynamicData;
using DynamicData.Binding;
using Orc.FileSystem;
using WolvenKit.Functionality.Services;
using ReactiveUI;
using WolvenKit.Models;
using WolvenKit.ViewModels.Editor.Basic;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.MVVM.Model;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenManager.App.Services;

namespace WolvenKit.ViewModels.Editor
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

        private readonly ICommandManager _commandManager;
        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;
        private readonly IWatcherService _watcherService;

        private EditorProject ActiveMod => _projectManager.ActiveProject;


        private readonly ReadOnlyObservableCollection<FileViewModel> _bindOut;
        public ReadOnlyObservableCollection<FileViewModel> BindingModel => _bindOut;


        #endregion fields

        #region constructors

        public ProjectExplorerViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService,
            IWatcherService watcherService,
            ICommandManager commandManager
            ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => watcherService);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _commandManager = commandManager;
            _watcherService = watcherService;
 

            SetupCommands();
            SetupToolDefaults();

            _watcherService.Connect()
                .SubscribeOnDispatcher()
                .Bind(out _bindOut)
                .Subscribe();
        }



        

        #endregion constructors

        #region properties

        public FileViewModel SelectedItem { get; set; }

        

        #endregion properties

        #region commands

        #region general commands

        /// <summary>
        /// Collapses all nodes in the treeview.
        /// </summary>
        public ICommand CollapseAllCommand { get; private set; }

        /// <summary>
        /// Collapses all children of the selected node.
        /// </summary>
        public ICommand CollapseCommand { get; private set; }

        /// <summary>
        /// Copies selected node to the clipboard.
        /// </summary>
        public ICommand CopyFileCommand { get; private set; }

        /// <summary>
        /// Copies relative path of node.
        /// </summary>
        public ICommand CopyRelPathCommand { get; private set; }

        /// <summary>
        /// Cuts selected node to the clipboard.
        /// </summary>
        public ICommand CutFileCommand { get; private set; }

        /// <summary>
        /// Delets selected node.
        /// </summary>
        public ICommand DeleteFileCommand { get; private set; }

        /// <summary>
        /// Expands all nodes in the treeview.
        /// </summary>
        public ICommand ExpandAllCommand { get; private set; }

        /// <summary>
        /// Expands all children of the selected node.
        /// </summary>
        public ICommand ExpandCommand { get; private set; }

        /// <summary>
        /// Opens selected node in File Explorer.
        /// </summary>
        public ICommand OpenInFileExplorerCommand { get; private set; }

        /// <summary>
        /// Pastes a file from the clipboard into selected node.
        /// </summary>
        public ICommand PasteFileCommand { get; private set; }

        /// <summary>
        /// Renames selected node.
        /// </summary>
        public ICommand RenameFileCommand { get; private set; }

        private bool CanCollapse() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;

        private bool CanCollapseAll() => _projectManager.ActiveProject is EditorProject;

        private bool CanCopyFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;

        private bool CanCopyRelPath() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;

        private bool CanCutFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;

        private bool CanDeleteFile()
        {
            var b = _projectManager.ActiveProject is EditorProject && SelectedItem != null;
            if (!b)
            {
                return false;
            }

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

        private bool CanExpand() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;

        private bool CanExpandAll() => _projectManager.ActiveProject is EditorProject;

        private bool CanOpenInFileExplorer() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;

        private bool CanPasteFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null && Clipboard.ContainsText();

        private bool CanRenameFile() => _projectManager.ActiveProject is EditorProject && SelectedItem != null;

        private void CopyFile() => Clipboard.SetText(SelectedItem.FullName);

        //private void ExecuteCollapse() => SelectedItem.CollapseChildren(true);

        private void ExecuteCollapseAll()
        {
            //foreach (var node in Treenodes)
            //{
            //    node.CollapseChildren(true);
            //}
        }

        private void ExecuteCopyRelPath()
        {
            if (!SelectedItem.IsDirectory)
            {
                Clipboard.SetText(GetArchivePath(SelectedItem.FullName));
            }

            string GetArchivePath(string s)
            {
                if (s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Length > 2)
                {
                    var relpath = s[(ActiveMod.FileDirectory.Length + 1)..];
                    return string.Join(Path.DirectorySeparatorChar.ToString(), relpath.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(2).ToArray());
                }
                else
                {
                    return s;
                }
            }
        }

        private void ExecuteCutFile() =>
            // TODO: Handle command logic here
            throw new NotImplementedException();

        private async void ExecuteDeleteFile()
        {
            //// TODO: close open documents

            if (await _messageService.ShowAsync(
                    "Are you sure you want to delete this?", "Are you sure?", MessageButton.YesNo) !=
                MessageResult.Yes)
            {
                return;
            }

            // Delete from file structure
            var fullpath = SelectedItem.FullName;
            try
            {
                // TODO
                var fileService = ServiceLocator.Default.ResolveType<IFileService>();
                var directoryService = ServiceLocator.Default.ResolveType<IDirectoryService>();

                if (SelectedItem.IsDirectory)
                {
                    directoryService.Delete(fullpath);
                    //Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(fullpath
                    //    , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                    //    , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
                else
                {
                    fileService.Delete(fullpath);
                    //Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(fullpath
                    //    , Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs
                    //    , Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                }
            }
            catch (Exception)
            {
                MainController.LogString("Failed to delete " + fullpath + ".\r\n", Common.Services.Logtype.Error);
            }
            finally
            {
                //SelectedItem.RaiseRequestRefresh();
            }
        }

        private void ExecuteCollapse() => SelectedItem.CollapseChildren(true);
        private void ExecuteExpand() => SelectedItem.ExpandChildren(true);

        private void ExecuteExpandAll()
        {
            //foreach (var node in Treenodes)
            //{
            //    node.ExpandChildren(true);
            //}
        }

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

        private async void ExecuteRenameFile() // Is not MVVM ?
        {
            var filename = SelectedItem.FullName;

            var visualizerService = ServiceLocator.Default.ResolveType<IUIVisualizerService>();
            var viewModel = new InputDialogViewModel() { Text = filename };
            await visualizerService.ShowDialogAsync(viewModel, delegate (object sender, UICompletedEventArgs args)
            {
                if (args.Result != true)
                {
                    return;
                }

                if (args.DataContext is not Dialogs.InputDialogViewModel vm)
                {
                    return;
                }

                var newfullpath = Path.Combine(ActiveMod.FileDirectory, vm.Text);

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
                finally
                {
                    //SelectedItem.RaiseRequestRefresh();
                }
            });
        }

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

        #endregion general commands

        #region Tw3 Commands

        /// <summary>
        /// Adds all dependencies (imports) of selected node from the game.
        /// </summary>
        public ICommand AddAllImportsCommand { get; private set; }

        public ICommand CookCommand { get; private set; }

        /// <summary>
        /// Exports selected file to Json.
        /// </summary>
        public ICommand ExportJsonCommand { get; private set; }

        /// <summary>
        /// Exports selected node with wcc.
        /// </summary>
        public ICommand ExportMeshCommand { get; private set; }

        /// <summary>
        ///  Opens the fast render Window for selected file
        /// </summary>
        public ICommand FastRenderCommand { get; private set; }

        /// <summary>
        /// Opens selected node in asset browser.
        /// </summary>
        public ICommand OpenInAssetBrowserCommand { get; private set; }


        private async void AddAllImports() => await WccHelper.AddAllImportsAsync(SelectedItem.FullName, true);

        private bool CanAddAllImports() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null && !SelectedItem.IsDirectory;

        // legacy
        private bool CanCook() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null;

        private bool CanExportJson() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null
            && !SelectedItem.IsDirectory;

        private bool CanExportMesh() => _projectManager.ActiveProject is EditorProject && SelectedItem != null
            && !SelectedItem.IsDirectory && SelectedItem.Extension == ".w2mesh";

        private bool CanFastRender() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null
            && !SelectedItem.IsDirectory && SelectedItem.Extension == ".w2mesh";

        private bool CanOpenInAssetBrowser() => _projectManager.ActiveProject is Tw3Project && SelectedItem != null;

        private void Cook() => RequestFileCook(this, new RequestFileOpenArgs { File = SelectedItem.FullName });

        private void ExecuteExportJson()
        {
            // TODO: Handle command logic here
        }

        private void ExecuteFastRender()
        {
            // TODO: Handle command logic here
        }

        private void ExecuteOpenInAssetBrowser()
        {
            // TODO: Handle command logic here
        }

        private async void ExportMesh() => await Task.Run(() => WccHelper.ExportFileToMod(SelectedItem.FullName));

        #endregion Tw3 Commands

        #endregion commands

        #region Methods

        protected override async Task CloseAsync()
        {
            //_projectManager.ProjectActivatedAsync -= OnProjectActivatedAsync;

            await base.CloseAsync();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            var commandManager = ServiceLocator.Default.ResolveType<ICommandManager>();
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.ExpandAll, ExpandAllCommand, this);
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.CollapseAll, CollapseAllCommand, this);
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.Expand, ExpandCommand, this);
            commandManager.RegisterCommand(AppCommands.ProjectExplorer.Collapse, CollapseCommand, this);

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
            var reldir = dir[(ActiveMod.FileDirectory.Length + 1)..];

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
                reldir = reldir[EProjectFolders.Cooked.ToString().Length..];
            }

            if (reldir.StartsWith(EProjectFolders.Uncooked.ToString()))
            {
                reldir = reldir[EProjectFolders.Uncooked.ToString().Length..];
            }

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
        }

        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;


        #endregion Methods
    }
}
