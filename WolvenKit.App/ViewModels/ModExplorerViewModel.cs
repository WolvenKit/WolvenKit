using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W;

namespace WolvenKit.App.ViewModels
{
    public class ModExplorerViewModel : ViewModel
    {
        private readonly MainViewModel MainVM;

        public ModExplorerViewModel(IWindowFactory windowFactory, MainViewModel mainViewModel) : base(windowFactory)
        {
            MainVM = mainViewModel;
            LastChange = DateTime.Now;


            CookCommand = new RelayCommand(Cook, CanCook);
            //DeleteFilesCommand = new RelayCommand(DeleteFiles, CanDeleteFiles);
            CopyFileCommand = new RelayCommand(CopyFile, CanCopyFile);
            PasteFileCommand = new RelayCommand(PasteFile, CanPasteFile);

            ExportMeshCommand = new RelayCommand(ExportMesh, CanExportMesh);
            AddAllImportsCommand = new RelayCommand(AddAllImports, CanAddAllImports);


            Treenodes = new BindingList<FileSystemInfo>();
            Treenodes.ListChanged += new ListChangedEventHandler(Treenodes_ListChanged);

            ExpandedNodesDict = new Dictionary<string, List<string>>();
        }

        #region Fields
        void Treenodes_ListChanged(object sender, ListChangedEventArgs e)
        {
            RaisePropertyChanged(nameof(Treenodes));
        }


        public bool IsTreeview { get; set; } = true;
        public Dictionary<string, List<string>> ExpandedNodesDict { get; set; }

        public static DateTime LastChange;
        public static TimeSpan mindiff = TimeSpan.FromMilliseconds(500);
        #endregion

        #region Properties

        public W3Mod ActiveMod
        {
            get => MainController.Get().ActiveMod;
            set => MainController.Get().ActiveMod = value;
        }
        #region ModelList
        private BindingList<FileSystemInfo> _treenodes = null;
        public BindingList<FileSystemInfo> Treenodes
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
        #endregion
        #region SelectedItem
        private List<FileSystemInfo> _selectedItems = null;
        public List<FileSystemInfo> SelectedItems
        {
            get => _selectedItems;
            set
            {
                if (_selectedItems != value)
                {
                    var oldValue = _selectedItems;
                    _selectedItems = value;
                    RaisePropertyChanged(() => SelectedItems, oldValue, value);
                }
            }
        }
        #endregion
        #endregion

        #region Commands
        public ICommand CookCommand { get; }
        //public ICommand DeleteFilesCommand { get; }
        public ICommand ExportMeshCommand { get; }
        public ICommand CopyFileCommand { get; }
        public ICommand PasteFileCommand { get; }
        public ICommand AddAllImportsCommand { get; }
        
        #endregion

        #region Commands Implementation
        protected bool CanCook() => SelectedItems != null;
        protected void Cook()
        {
            RequestFileCook(this, new RequestFileOpenArgs { File = SelectedItems.First().FullName });
        }


        protected bool CanExportMesh() => SelectedItems != null;
        protected async void ExportMesh()
        {
            var fullpath = SelectedItems.First().FullName;
            await Task.Run(() => WccHelper.ExportFileToMod(fullpath));

        }

        protected bool CanCopyFile() => SelectedItems != null;
        protected void CopyFile()
        {
            Clipboard.SetText(SelectedItems.First().FullName);
        }
        protected bool CanPasteFile() => SelectedItems != null;
        protected void PasteFile()
        {
            if (File.Exists(Clipboard.GetText()))
            {
                FileAttributes attr = File.GetAttributes(SelectedItems.First().FullName);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    SafeCopy(Clipboard.GetText(), SelectedItems.First().FullName + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
                else
                {
                    SafeCopy(Clipboard.GetText(), Path.GetDirectoryName(SelectedItems.First().FullName) + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
            }
        }



        protected bool CanAddAllImports() => SelectedItems != null;
        protected async void AddAllImports() => await WccHelper.AddAllImports(SelectedItems.First().FullName, true);


        #endregion



        #region Methods

        public void RepopulateTreeView()
        {
            if (MainController.Get().ActiveMod == null)
                return;
            var di = new DirectoryInfo(MainController.Get().ActiveMod.FileDirectory);

            if (IsTreeview)
            {
                Treenodes = new BindingList<FileSystemInfo>(di.GetFileSystemInfos("*", SearchOption.TopDirectoryOnly)
                    .Where(_ => _.Extension != ".bat")
                    .ToList());
                
            }
            else
            {
                Treenodes = new BindingList<FileSystemInfo>(di.GetFileSystemInfos("*", SearchOption.AllDirectories)
                    .Where(_ => _.Extension != ".bat")
                    .ToList());
            }
            
        }
        public static IEnumerable<string> FallbackPaths(string path)
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
        public static void SafeCopy(string src, string dest)
        {
            foreach (var path in FallbackPaths(dest).Where(path => !File.Exists(path)))
            {
                File.Copy(src, path);
                break;
            }
        }

        private async void RequestFileCook(object sender, RequestFileOpenArgs e)
        {
            var filename = e.File;
            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
                return;
            string dir;
            if (File.Exists(fullpath))
                dir = Path.GetDirectoryName(fullpath);
            else
                dir = fullpath;
            string reldir = dir.Substring(ActiveMod.FileDirectory.Length + 1);

            // Trim working directories in path
            var reg = new Regex(@"^(Raw|Mod|DLC)\\(.*)");
            var match = reg.Match(reldir);
            bool isDlc = false;
            if (match.Success)
            {
                reldir = match.Groups[2].Value;
                if (match.Groups[1].Value == "Raw")
                    return;
                else if (match.Groups[1].Value == "DLC")
                    isDlc = true;
                else if (match.Groups[1].Value == "Mod")
                    isDlc = false;
            }

            if (reldir.StartsWith(EProjectFolders.Cooked.ToString()))
                reldir = reldir.Substring(EProjectFolders.Cooked.ToString().Length);
            if (reldir.StartsWith(EProjectFolders.Uncooked.ToString()))
                reldir = reldir.Substring(EProjectFolders.Uncooked.ToString().Length);
            
            reldir = reldir.TrimStart(Path.DirectorySeparatorChar);

            // create cooked mod Dir
            var cookedtargetDir = isDlc 
                ? Path.Combine(ActiveMod.DlcCookedDirectory, reldir) 
                : Path.Combine(ActiveMod.ModCookedDirectory, reldir);
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
#pragma warning disable CS0169 // ~~~[[maybe_unused]] c++ compiler attribute
#pragma warning disable CS0168
#pragma warning disable IDE0051
            catch (Exception ex)
#pragma warning restore CS0169 // ~~~[[maybe_unused]] c++ compiler attribute
#pragma warning restore CS0168
#pragma warning restore IDE0051
            {
                MainController.LogString("Error cooking files.", Logtype.Error);
            }
        }
        
        #endregion


        // debug
        public async void DBG_logdependencies()
        {
            string workDir = Path.GetFullPath($"{MainController.WorkDir}_export");
            await WccHelper.AddAllImports(SelectedItems.First().FullName, true, true, workDir, true);
        }

    }
}
