using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;

namespace WolvenKit.App.ViewModels
{
    public class ImportViewModel : ViewModel
    {
        

        public ImportViewModel()
        {
            Logger = MainController.Get().Logger;


            UseLocalResourcesCommand = new RelayCommand(UseLocalResources, CanUseLocalResources);
            OpenFolderCommand = new RelayCommand(OpenFolder, CanOpenFolder);
            TryGetTextureGroupsCommand = new RelayCommand(TryGetTextureGroups, CanTryGetTextureGroups);
            ImportCommand = new RelayCommand(Import, CanImport);

            Importableobjects = new BindingList<ImportableFile>();
            Importableobjects.ListChanged += new ListChangedEventHandler(Importableobjects_ListChanged);

            // on start use mod files
            UseLocalResourcesCommand.SafeExecute();
            // and auto-gen texture groups
            TryGetTextureGroupsCommand.SafeExecute();
        }

        #region Fields
        private readonly List<string> importableexts = Enum.GetNames(typeof(EImportable)).Select(_ => $".{_}".ToLower()).ToList();
        private readonly LoggerService Logger;
        
        private DirectoryInfo importdepot;
        #endregion

        void Importableobjects_ListChanged(object sender, ListChangedEventArgs e) => OnPropertyChanged(nameof(Importableobjects));

        #region Properties
        #region SelectedItem
        private BindingList<ImportableFile> _importableobjects = null;
        public BindingList<ImportableFile> Importableobjects
        {
            get => _importableobjects;
            set
            {
                if (_importableobjects != value)
                {
                    _importableobjects = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #endregion

        #region Commands
        public ICommand UseLocalResourcesCommand { get; }
        public ICommand OpenFolderCommand { get; }
        public ICommand TryGetTextureGroupsCommand { get; }
        public ICommand ImportCommand { get; }
        #endregion

        #region Commands Implementation
        protected bool CanUseLocalResources() => MainController.Get().ActiveMod != null;
        protected void UseLocalResources()
        {
            var importablefiles = new List<string>();
            foreach (var file in MainController.Get().ActiveMod.Files)
            {
                var lowerExt = Path.GetExtension(file).ToLower();
                if (importableexts.Contains(lowerExt))
                {
                    // rename file first because wcc can't handle uppercase file extensions
                    var oldpath = Path.Combine(MainController.Get().ActiveMod.FileDirectory, file);
                    var newpath = Path.ChangeExtension(oldpath, lowerExt);
                    File.Move(oldpath, newpath);

                    importablefiles.Add(Path.ChangeExtension(file, lowerExt));
                }

            }
            AddObjects(importablefiles, MainController.Get().ActiveMod.FileDirectory);
        }

        protected bool CanOpenFolder() => MainController.Get().ActiveMod != null;
        protected void OpenFolder()
        {
            
        }

        protected bool CanTryGetTextureGroups() => Importableobjects != null;
        protected void TryGetTextureGroups()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, MainController.XBMDumpPath);
            using (var fr = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fr))
            using (var csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<XBMDump>();
                var recordsl = csv.GetRecords<XBMDump>().ToList();

                foreach (var importable in Importableobjects)
                {
                    // check for non-texture files
                    if (importable.GetImportableType() != EImportable.bmp &&
                        //importable.GetImportableType() != EImportable.dds &&
                        importable.GetImportableType() != EImportable.jpg &&
                        importable.GetImportableType() != EImportable.png &&
                        importable.GetImportableType() != EImportable.tga
                        )
                        continue;

                    // try getting texture group from vanilla files
                    try
                    {
                        string xbmfullpath = Path.ChangeExtension(importable.GetRelativePath(), "xbm");
                        var xpath = xbmfullpath.Split(Path.DirectorySeparatorChar).Last();

                        var foundrecords = recordsl.FirstOrDefault(_ => _.RedName.Contains(xpath));
                        if (foundrecords != null)
                        {
                            string stxtgroup = foundrecords.TextureGroup;
                            ETextureGroup etxtgroup = (ETextureGroup)Enum.Parse(typeof(ETextureGroup), stxtgroup);
                            importable.TextureGroup = etxtgroup;

                            importable.SetState(ImportableFile.EObjectState.Ready);
                            importable.IsSelected = true;
                        }
                        else
                            importable.SetState(ImportableFile.EObjectState.NoTextureGroup);
                    }
                    catch (Exception)
                    {
                        importable.SetState(ImportableFile.EObjectState.Error);
                    }
                }
            }
        }

        protected bool CanImport() => Importableobjects != null;
        protected async void Import()
        {
            var filesToImport = Importableobjects.Where(_ => _.IsSelected).ToList();
            var ActiveMod = MainController.Get().ActiveMod;

            foreach (var file in filesToImport)
            {
                if (file.GetState() != ImportableFile.EObjectState.Ready)
                    continue;

                var fullpath = Path.Combine(importdepot.FullName, file.GetRelativePath());
                if (!File.Exists(fullpath))
                    return;

                try
                {
                    await StartImport(file);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            async Task StartImport(ImportableFile file)
            {
                var relPath = file.GetRelativePath();
                string importext = $".{file.ImportType:G}";
                string rawext = $".{file.GetImportableType():G}";
                var filepath = Path.Combine(importdepot.FullName, relPath);
                string type = REDTypes.RawExtensionToCacheType(rawext);

                // make new path
                // first, trim Raw from the path
                if (relPath.Substring(0, 3) == "Raw" )
                    relPath = relPath.Substring(4);
                // then, trim Mod or dlc from the path
                bool isDLC = false;
                if (relPath.Substring(0, 3) == "Mod")
                {
                    relPath = relPath.Substring(4);
                }
                if (relPath.Substring(0, 3) == "DLC")
                {
                    isDLC = true;
                    relPath = relPath.Substring(4);
                }

                // new path with new extension
                relPath = Path.ChangeExtension(relPath, importext);

                var newpath = "";
                if (relPath.Substring(0, type.Length) == type)
                {
                    newpath = isDLC ? Path.Combine(ActiveMod.DlcDirectory, relPath) : Path.Combine(ActiveMod.ModDirectory, relPath);
                }
                else
                {
                    newpath = isDLC ? Path.Combine(ActiveMod.DlcDirectory, type, relPath) : Path.Combine(ActiveMod.ModDirectory, type, relPath);
                }

                var import = new Wcc_lite.import()
                {
                    File = filepath,
                    Out = newpath,
                    Depot = MainController.Get().Configuration.DepotPath,
                    texturegroup = file.TextureGroup
                };
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(import));
            }
        }
        #endregion

        #region Methods
        public void AddObjects(List<string> importablefiles, string dirpath)
        {
            Importableobjects.Clear();
            importdepot = new DirectoryInfo(dirpath);

            foreach (var f in importablefiles)
            {
                string ext = Path.GetExtension(f);
                EImportable type = (EImportable)Enum.Parse(typeof(EImportable), ext.TrimStart('.').ToLower());

                var importableobj = new ImportableFile(
                    f,
                    type,
                    REDTypes.RawExtensionToEnum(ext)
                    );

                // non-texture imports are ready by default (no texture group must be set)
                if (importableobj.GetImportableType() == EImportable.apb ||
                    importableobj.GetImportableType() == EImportable.fbx ||
                    importableobj.GetImportableType() == EImportable.nxs
                    )
                {
                    importableobj.SetState(ImportableFile.EObjectState.Ready);
                    importableobj.IsSelected = true;
                }

                Importableobjects.Add(importableobj);
            }

            //objectListView.SetObjects(Importableobjects);


        }
        #endregion

    }
}
