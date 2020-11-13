using SymbolicLinkSupport;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W;
using WolvenKit.Wwise.Wwise;
using WolvenKit.Common.WinFormsEnums;

namespace WolvenKit.App.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class MainViewModel : ViewModel
    {
        #region Properties
        #region Title
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Open Documents

        private readonly Dictionary<string, IDocumentViewModel> _openDocuments;
        public Dictionary<string, IDocumentViewModel> GetOpenDocuments() => _openDocuments;

        public void AddOpenDocument(IDocumentViewModel document)
        {
            if (_openDocuments.ContainsKey(document.FileName))
                throw new NullReferenceException();
            _openDocuments.Add(document.FileName, document);
        }
        public void RemoveOpenDocument(string key)
        {
            if (!_openDocuments.ContainsKey(key))
                throw new NullReferenceException();
            _openDocuments.Remove(key);
            // update Active Document
            if (ActiveDocument.FileName == key)
                ActiveDocument = null;
        }

        #endregion

        #region Active Document
        private IDocumentViewModel _activeDocument;
        public IDocumentViewModel ActiveDocument
        {
            get => _activeDocument;
            set
            {
                if (_activeDocument != value)
                {
                    _activeDocument = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #endregion

        #region Fields
        private static Task _packer;
        public readonly LoggerService Logger;
        public W3Mod ActiveMod
        {
            get => MainController.Get().ActiveMod;
            set => MainController.Get().ActiveMod = value;
        }
        #endregion

        public MainViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            Title = "WolvenKit";

            Logger = MainController.Get().Logger;
            _openDocuments = new Dictionary<string, IDocumentViewModel>();
        }

        #region Helper Methods
        
        public async void executeGame(string args = "")
        {
            if (ActiveMod == null)
                return;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                Logger.LogString(@"Game is already running!", Logtype.Error);
                return;
            }
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.ExecutablePath)
            {
                WorkingDirectory = Path.GetDirectoryName(config.ExecutablePath),
                Arguments = args == "" ? "-net -debugscripts" : args,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };


            Logger.LogString("Executing " + proc.FileName + " " + proc.Arguments + "\n");

            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            if (File.Exists(scriptlog))
                File.Delete(scriptlog);

            using (var process = Process.Start(proc))
            {
                await Task.Run(() => RedirectScriptlogOutput(process));
            }
        }
        public async Task RedirectScriptlogOutput(Process process)
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            using (var fs = new FileStream(scriptlog, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var fsr = new StreamReader(fs))
                {
                    while (!process.HasExited)
                    {
                        var result = await fsr.ReadToEndAsync();

                        Logger.LogString(result);

                        //Application.DoEvents();
                    }
                }
                fs.Close();
            }
        }
        #endregion

        #region Wcc Tasks
        /// <summary>
        /// Deprecated, Use the Modkit instead
        /// Kept for a neat hack tricking wcc_lite into dumping individual files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RequestWccliteFileDumpfile(object sender, RequestFileOpenArgs e)
        {
            var filename = e.File;
            if (!File.Exists(filename) && !Directory.Exists(filename))
                return;
            // We dump an individual file with wcclite dumpfile
            if (File.Exists(filename))
            {
                // '\\?\' is a neutral win32 path prefix. It hacks wcc_lite into dumping individual files.
                // This string will get input again, further down the line, in wcc_command.GetVariables
                // Windows paths and string management... This one is more than stupid, it is an horror. \\FIXME if you can.
                await DumpFile("", @"\\?\", filename);
            }
            //Wcclite recursively dumps CR2Ws in a directory.
            else if (Directory.Exists(filename))
            {
                string dir = filename;
                await DumpFile(dir, dir);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="outfolder"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        private async Task DumpFile(string folder, string outfolder, string file = "")
        {
            MainController.Get().ProjectStatus = EProjectStatus.Busy;
            WCC_Command cmd = null;
            try
            {
                if (file == "")
                {
                    cmd = new Wcc_lite.dumpfile()
                    {
                        Dir = folder,
                        Out = outfolder
                    };
                }
                else
                {
                    cmd = new Wcc_lite.dumpfile()
                    {
                        File = file,
                        Out = outfolder
                    };
                }
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(cmd));
            }
            catch (Exception ex)
            {
                Logger.LogString(ex.ToString() + "\n", Logtype.Error);
            }

            MainController.Get().ProjectStatus = EProjectStatus.Ready;

        }


        /// <summary>
        /// Uncooks a single file to a temp directory
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="newpath"></param>
        /// <param name="indir"></param>
        /// <returns></returns>
        public async Task<int> UncookFileToPath(string relativePath, bool isDLC, string alternateOutDirectory = "")
        {
            #region Unbundle relative file directory to temp dir
            // create temporary uncooked directory
            string outdir = Path.GetFullPath(MainController.WorkDir);
            if (Directory.Exists(outdir))
                Directory.Delete(outdir, true);
            Directory.CreateDirectory(outdir);

            var di = new DirectoryInfo(outdir);

            // try get uncook extension from settings
            imageformat imgfmt = imageformat.tga;
            try
            {
                imgfmt = (imageformat)Enum.Parse(typeof(imageformat), MainController.Get().Configuration.UncookExtension.ToString());
            }
            catch (Exception)
            {
            }

            string relativeParentDir = Path.GetDirectoryName(relativePath);

            // uncook the folder with wcc
            
            // TODO: this will run over mods :(
            var indir = isDLC 
                ? Path.GetFullPath(MainController.Get().Configuration.GameDlcDir)
                : Path.GetFullPath(MainController.Get().Configuration.GameContentDir);


            var wccuncook = new Wcc_lite.uncook()
            {
                InputDirectory = indir,
                OutputDirectory = outdir,
                TargetDirectory = relativeParentDir,
                Imgfmt = imgfmt,
                //UncookExtensions = Path.GetExtension(newpath).TrimStart('.'),
            };
            await Task.Run(() => MainController.Get().WccHelper.RunCommand(wccuncook));
            #endregion

            #region Move file to outdir
            // move uncooked file to mod project
            string newpath = "";
            // if an alternative dir is set, move there
            // otherwise move to mod
            if (string.IsNullOrWhiteSpace(alternateOutDirectory))
            {
                newpath = isDLC 
                    ? Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath) 
                    : Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);
            }
            else
            {
                newpath = Path.Combine(alternateOutDirectory, relativePath);
            }

            if (string.IsNullOrWhiteSpace(newpath)) return 0;

            int addedFilesCount = 0;
            var fis = di.GetFiles("*", SearchOption.AllDirectories);
            foreach (var f in fis)
            {
                if (f.Name != Path.GetFileName(relativePath))
                    continue;

                try
                {
                    if (File.Exists(newpath))
                    {
                        File.Delete(newpath);
                    }

                    f.CopyToAndCreate(newpath);

                    addedFilesCount++;
                }
                catch (Exception ex)
                {
                    Logger.LogString($"Unable to move uncooked file to ModProject, perhaps a file of that name is cuurrently open in Wkit.", Logtype.Error);
                }
            }
            #endregion


            // Logging
            Logger.LogString($"Moved {addedFilesCount} files to project.", Logtype.Important);
            if (addedFilesCount > 0)
                Logger.LogString($"Successfully uncooked {addedFilesCount} files.", Logtype.Success);
            else
                Logger.LogString($"Wcc_lite is unable to uncook this file.", Logtype.Error);


            return addedFilesCount;
        }

        /// <summary>
        /// Unbundles a file with the given relativepath from either the Game or the Mod BundleManager
        /// and adds it to the depot, optionally copying to the project
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="isDLC"></param>
        /// <param name="projectFolder"></param>
        /// <param name="bundleType"></param>
        /// <param name="alternateOutDirectory"></param>
        /// <param name="loadmods"></param>
        /// <param name="silent"></param>
        /// <returns></returns>
        private string UnbundleFile(string relativePath, bool isDLC, EProjectFolders projectFolder, EBundleType bundleType = EBundleType.Bundle, string alternateOutDirectory = "", bool loadmods = false, bool silent = false)
        {
            string extension = Path.GetExtension(relativePath);
            string filename = Path.GetFileName(relativePath);

            // Jato said not to add textures to an fbx 
            // so I am keeping meshes violet :)
            //if (extension == ".xbm" && bundleType == EBundleType.Bundle)
            //{
            //    //var uncookTask = Task.Run(() => UncookFileToPath(relativePath, isDLC, alternateOutDirectory));
            //    //Task.WaitAll(uncookTask);
            //    //return relativePath;
            //    UnbundleFile(relativePath, isDLC, projectFolder, EBundleType.TextureCache, alternateOutDirectory,
            //        loadmods, silent);
            //}
            IWitcherArchiveManager manager = MainController.Get().GetManagers(loadmods).FirstOrDefault(_ => _.TypeName == bundleType);

            if (manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath)))
            {
                var archives = manager.FileList
                    .Where(x => x.Name == relativePath)
                    .Select(y => new KeyValuePair<string, IWitcherFile>(y.Bundle.ArchiveAbsolutePath, y))
                    .ToList();


                // Extract
                try
                {
                    // if more than one archive get the last
                    var archive = archives.Last().Value;

                    string newpath = "";
                    if (string.IsNullOrWhiteSpace(alternateOutDirectory))
                    {
                        switch (projectFolder)
                        {
                            case EProjectFolders.Cooked:
                                newpath = Path.Combine(isDLC
                                    ? ActiveMod.DlcCookedDirectory
                                    : ActiveMod.ModCookedDirectory, relativePath);
                                break;
                            case EProjectFolders.Uncooked:
                                newpath = Path.Combine(isDLC
                                    ? ActiveMod.DlcUncookedDirectory
                                    : ActiveMod.ModUncookedDirectory, relativePath);
                                break;
                            case EProjectFolders.Raw:
                            default:
                                break;
                        }
                    }
                    else
                    {
                        newpath = Path.Combine(alternateOutDirectory, relativePath);
                    }

                    if (string.IsNullOrWhiteSpace(newpath)) return "";
                    
                    if (!(extension == ".xbm" && bundleType == EBundleType.Bundle) || !File.Exists(newpath))
                    {
                        string extractedfile = archive.Extract(new BundleFileExtractArgs(newpath, MainController.Get().Configuration.UncookExtension));
                        if (!silent) Logger.LogString($"Succesfully unbundled {filename}.", Logtype.Success);
                    }
                    else
                        if (!silent) Logger.LogString($"File already exists in mod project: {filename}.", Logtype.Success);
                    return newpath;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString(), Logtype.Error);
                    return "";
                }
            }

            return "";
        }

        /// <summary>
        /// Exports an existing file in the ModProject (w2mesh, redcloth) to the modProject
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public async Task ExportFileToMod(string fullpath)
        {
            string workDir = Path.GetFullPath($"{MainController.WorkDir}_export");
            if (!Directory.Exists(workDir))
                Directory.CreateDirectory(workDir);
            Directory.Delete(workDir, true);

            // check if physical file exists
            if (!File.Exists(fullpath))
            {
                Logger.LogString($"File to export does not exist {fullpath}.", Logtype.Error);
                return;
            }

            // check if the extension matches an exportable format
            string importedExtension = Path.GetExtension(fullpath).TrimStart('.');
            EImportable exportedExtension;
            try
            {
                exportedExtension = REDTypes.ExportExtensionToRawExtension((EExportable)Enum.Parse(typeof(EExportable), importedExtension));
            }
            catch (Exception ex)
            {
                Logger.LogString($"Not an exportable filetype: {importedExtension}.", Logtype.Error);
                return;
            }

            // get relative path
            (string relativePath, bool isDLC, EProjectFolders projectFolder) = fullpath.GetModRelativePath(ActiveMod.FileDirectory);
            var exportpath = isDLC 
                ? Path.Combine(ActiveMod.RawDirectory, "DLC", relativePath) 
                : Path.Combine(ActiveMod.RawDirectory, "Mod", relativePath);
            exportpath = Path.ChangeExtension(exportpath, exportedExtension.ToString());

            // add all imports to 
            
            //string workDir = "";                                            // add to mod
            //string workDir = MainController.Get().Configuration.DepotPath;  // r4depot

            AddAllImports(fullpath, true, true, workDir);

            // copy the w2mesh and all imports to the depot
            var depotInfo = new FileInfo(Path.Combine(workDir, relativePath));
            var uncookedInfo = new FileInfo(fullpath);
            uncookedInfo.CopyToAndCreate(depotInfo.FullName, true);



            // export with wcc_lite
            if (!string.IsNullOrEmpty(relativePath) && !string.IsNullOrEmpty(exportpath))
            {
                // uncook the folder
                var export = new Wcc_lite.export()
                {
                    File = relativePath,
                    Out = exportpath,
                    Depot = workDir
                };
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(export));

                if (File.Exists(exportpath))
                    Logger.LogString($"Successfully exported {relativePath}.", Logtype.Success);
                else
                    Logger.LogString($"Did not export {relativePath}.", Logtype.Error);
            }
        }

       /// <summary>
       /// Adds all file dependencies (cr2w imports) to a specified folder
       /// retaining relative paths
       /// </summary>
       /// <param name="importfilepath"></param>
       /// <param name="recursive"></param>
       /// <param name="silent"></param>
       /// <param name="alternateOutDirectory"></param>
       /// <returns></returns>
        public async Task AddAllImports(string importfilepath, bool recursive = false, bool silent = false, string alternateOutDirectory = "", bool logonly = false)
        {
            if (!File.Exists(importfilepath))
                return;

            string relativepath = "";
            bool isDLC = false;
            EProjectFolders projectFolder = EProjectFolders.Uncooked;
            if (string.IsNullOrWhiteSpace(alternateOutDirectory))
                (relativepath, isDLC, projectFolder) = importfilepath.GetModRelativePath(ActiveMod.FileDirectory);
            else
            {
                relativepath = importfilepath.Substring(alternateOutDirectory.Length + 1);
            }

            List<CR2WImportWrapper> importslist = new List<CR2WImportWrapper>();
            List<CR2WBufferWrapper> bufferlist = new List<CR2WBufferWrapper>();
            bool hasinternalBuffer;

            using (var fs = new FileStream(importfilepath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                var cr2w = new CR2WFile();
                (importslist, hasinternalBuffer, bufferlist) = cr2w.ReadImportsAndBuffers(reader);
            }

            bool success = true;
            // add imports
            foreach (CR2WImportWrapper import in importslist)
            {
                var filename = Path.GetFileName(import.DepotPathStr);
                if (logonly) MainController.LogString(filename, Logtype.Important);

                var path = UnbundleFile(import.DepotPathStr, isDLC, projectFolder, EBundleType.Bundle, alternateOutDirectory, false, silent);
                if (string.IsNullOrWhiteSpace(path))
                    Logger.LogString($"Did not unbundle {filename}, import is missing.", Logtype.Error);
                else
                {
                    // recursively add all 1st order dependencies :Gp:
                    if (recursive)
                        AddAllImports(path, true, silent, alternateOutDirectory, logonly);
                }
            }

            // add buffers
            if (hasinternalBuffer)
            {
                Logger.LogString($"{Path.GetFileName(importfilepath)} has internal buffers. If you need external buffers, unbundle them manually.", Logtype.Important);
            }
            else
            {
                // unbundle external buffers
                foreach (CR2WBufferWrapper buffer in bufferlist)
                {
                    var index = buffer.Buffer.index;
                    string bufferpath = $"{relativepath}.{index}.buffer";
                    var bufferName = $"{Path.GetFileName(relativepath)}.{index}.buffer";

                    var path = UnbundleFile(bufferpath, isDLC, projectFolder, EBundleType.Bundle, alternateOutDirectory, false, silent);
                    if (string.IsNullOrWhiteSpace(path))
                        Logger.LogString($"Did not unbundle {bufferName}, import is missing.", Logtype.Error);
                }
            }

            if (success && !silent)
                Logger.LogString($"Succesfully imported all dependencies.", Logtype.Success);
        }

        #endregion

        #region Mod Tasks
        /// <summary>
        /// Saves a W3ModProject
        /// </summary>
        public void SaveMod()
        {
            if (ActiveMod == null) return;

            if (ActiveMod.LastOpenedFiles != null)
                ActiveMod.LastOpenedFiles = GetOpenDocuments().Keys.ToList();

            var ser = new XmlSerializer(typeof(W3Mod));
            var modfile = new FileStream(ActiveMod.FileName, FileMode.Create, FileAccess.Write);
            ser.Serialize(modfile, ActiveMod);
            modfile.Close();
        }

        /// <summary>
        /// Installs the project from the packed folder of the project to the game
        /// </summary>
        public void InstallMod()
        {
            try
            {
                //Check if we have installed this mod before. If so do a little cleanup.
                if (File.Exists(ActiveMod.ProjectDirectory + "\\install_log.xml"))
                {
                    XDocument log = XDocument.Load(ActiveMod.ProjectDirectory + "\\install_log.xml");
                    var dirs = log.Root.Element("Files")?.Descendants("Directory");
                    if (dirs != null)
                    {
                        //Loop throught dirs and delete the old files in them.
                        foreach (var d in dirs)
                        {
                            foreach (var f in d.Elements("file"))
                            {
                                if (File.Exists(f.Value))
                                {
                                    File.Delete(f.Value);
                                    Debug.WriteLine("File delete: " + f.Value);
                                }
                            }
                        }
                        //Delete the empty directories.
                        foreach (var d in dirs)
                        {
                            if (d.Attribute("Path") != null)
                            {
                                if (Directory.Exists(d.Attribute("Path").Value))
                                {
                                    if (!(Directory.GetFiles(d.Attribute("Path").Value, "*", SearchOption.AllDirectories).Any()))
                                    {
                                        Directory.Delete(d.Attribute("Path").Value, true);
                                        Debug.WriteLine("Directory delete: " + d.Attribute("Path").Value);
                                    }
                                }
                            }
                        }
                    }
                    //Delete the old install log. We will make a new one so this is not needed anymore.
                    File.Delete(ActiveMod.ProjectDirectory + "\\install_log.xml");
                }
                var installlog = new XDocument(new XElement("InstalLog", new XAttribute("Project", ActiveMod.Name), new XAttribute("Build_date", DateTime.Now.ToString())));
                var fileroot = new XElement("Files");
                //Copy and log the files.
                if (!Directory.Exists(Path.Combine(ActiveMod.ProjectDirectory, "packed")))
                {
                    Logger.LogString("Failed to install the mod! The packed directory doesn't exist! You forgot to tick any of the packing options?", Logtype.Important);
                    return;
                }
                fileroot.Add(Commonfunctions.DirectoryCopy(Path.Combine(ActiveMod.ProjectDirectory, "packed"), MainController.Get().Configuration.GameRootDir, true));
                installlog.Root.Add(fileroot);
                //Save the log.
                installlog.Save(ActiveMod.ProjectDirectory + "\\install_log.xml");
                Logger.LogString(ActiveMod.Name + " installed!" + "\n", Logtype.Success);
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                Logger.LogString(ex.ToString() + "\n", Logtype.Error);
            }
        }

        const string db_dlcfiles = "db_dlcfiles";
        const string db_dlctextures = "db_dlctextures";
        const string db_modfiles = "db_modfiles";
        const string db_modtextures = "db_modtextures";

        /// <summary>
        /// Always call this first to clean the directories.
        /// </summary>
        public void CleanupDirectories()
        {
            // cleanup packed folders
            CleanupInner(Path.Combine(ActiveMod.ProjectDirectory, "packed"));

            // cleanup cooked folders
            CleanupInner(Path.Combine(ActiveMod.ProjectDirectory, "cooked"));


            

            // delete existing cook dbs
            string dlc_files_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_dlcfiles);
            string dlc_tex_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_dlctextures);
            string mod_files_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_modfiles);
            string mod_tex_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_modtextures);
            if (Directory.Exists(dlc_files_db))
                Directory.Delete(dlc_files_db, true);
            Directory.CreateDirectory(dlc_files_db);
            if (Directory.Exists(dlc_tex_db))
                Directory.Delete(dlc_tex_db, true);
            Directory.CreateDirectory(dlc_tex_db);
            if (Directory.Exists(mod_files_db))
                Directory.Delete(mod_files_db, true);
            Directory.CreateDirectory(mod_files_db);
            if (Directory.Exists(mod_tex_db))
                Directory.Delete(mod_tex_db, true);
            Directory.CreateDirectory(mod_tex_db);

            #region Directory cleanup
            void CleanupInner(string path)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    var di = new DirectoryInfo(path);
                    foreach (var file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (var dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// Cooks Files in the ModProject's folders (Bunde, TextureCache etc...)
        /// </summary>
        /// <returns></returns>
        public async Task<int> Cook()
        {
            var cfg = MainController.Get().Configuration;
            string dlc_files_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_dlcfiles);
            //string dlc_tex_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_dlctextures);
            string mod_files_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_modfiles);
            //string mod_tex_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), db_modtextures);

            int finished = 1;

            // Cook Mod files

            



            if (Directory.Exists(ActiveMod.ModUncookedDirectory) && Directory.GetFiles(ActiveMod.ModUncookedDirectory, "*", SearchOption.AllDirectories).Any()
                && !string.IsNullOrEmpty(ActiveMod.CookedModDirectory))
            {
                finished *= await Task.Run(() => CookInternal(ActiveMod.ModUncookedDirectory, ActiveMod.CookedModDirectory));

                if (!string.IsNullOrEmpty(ActiveMod.CookedModDirectory))
                {
                    var moddb = new FileInfo(Path.Combine(ActiveMod.CookedModDirectory, "cook.db"));
                    if (moddb.Exists)
                    {
                        moddb.MoveTo(Path.Combine(mod_files_db, "cook.db"));
                    }
                }
            }

            // Cook DLC files
            if (Directory.Exists(ActiveMod.DlcUncookedDirectory) && Directory.GetFiles(ActiveMod.DlcUncookedDirectory, "*", SearchOption.AllDirectories).Any()
                && !string.IsNullOrEmpty(ActiveMod.CookedDlcDirectory))
            {
                finished *= await Task.Run(() => CookInternal(ActiveMod.DlcUncookedDirectory, ActiveMod.CookedDlcDirectory, true));

                if (!string.IsNullOrEmpty(ActiveMod.CookedDlcDirectory))
                {
                    var dlcdb = new FileInfo(Path.Combine(ActiveMod.CookedDlcDirectory, "cook.db"));
                    if (dlcdb.Exists)
                    {
                        dlcdb.MoveTo(Path.Combine(dlc_files_db, "cook.db"));
                    }
                }
            }


            return finished == 0 ? 0 : 1;

            async Task<int> CookInternal(string dir_uncooked, string dir_cooked, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";

                try
                {
                    if (Directory.Exists(dir_uncooked) && Directory.GetFiles(dir_uncooked, "*", SearchOption.AllDirectories).Any())
                    {
                        Logger.LogString($"======== Cooking {type} ======== \n", Logtype.Important);
                        //MainController.Get().ProjectStatus = $"Cooking {type}";

                        if (!Directory.Exists(dir_cooked))
                        {
                            Directory.CreateDirectory(dir_cooked);
                        }

                        Wcc_lite.cook cook = new Wcc_lite.cook()
                        {
                            Platform = platform.pc,
                            outdir = dir_cooked,
                        };


                        if (dlc)
                        {
                            cook.trimdir = $"dlc\\{ActiveMod.GetDlcName()}";
                            var seeddir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked", $"seed_dlc{ActiveMod.Name}.files");
                            cook.seed = seeddir;
                        }
                        else
                        {
                            cook.mod = dir_uncooked;
                            cook.basedir = dir_uncooked; //cfg.DepotPath?
                        }

                        return await Task.Run(() => MainController.Get().WccHelper.RunCommand(cook));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    Logger.LogString($"{type} folder not found. {type} won't be cooked. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Packs the bundles for the DLC and the Mod. 
        /// </summary>
        /// <param name="packmod"></param>
        /// <param name="packdlc"></param>
        /// <returns></returns>
        public async Task<int> Pack(bool packmod, bool packdlc)
        {

            int finished = 1;

            if (packmod && Directory.Exists(ActiveMod.CookedModDirectory) && Directory.Exists(ActiveMod.PackedModDirectory))
                finished *= await Task.Run(() => PackBundleInternal(ActiveMod.CookedModDirectory, ActiveMod.PackedModDirectory));
            if (packdlc && Directory.Exists(ActiveMod.CookedDlcDirectory) && Directory.Exists(ActiveMod.PackedDlcDirectory))
                finished *= await Task.Run(() => PackBundleInternal(ActiveMod.CookedDlcDirectory, ActiveMod.PackedDlcDirectory, true));

            return finished == 0 ? 0 : 1;

            async Task<int> PackBundleInternal(string inputDir, string outputDir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";
                try
                {
                    if (Directory.Exists(inputDir) && Directory.GetFiles(inputDir, "*", SearchOption.AllDirectories).Any())
                    {
                        Logger.LogString($"======== Packing {type} bundles ======== \n", Logtype.Important);
                        //MainController.Get().ProjectStatus = $"Packing {type} bundles";

                        var pack = new Wcc_lite.pack()
                        {
                            Directory = inputDir,
                            Outdir = outputDir
                        };
                        return await Task.Run(() => MainController.Get().WccHelper.RunCommand(pack));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    Logger.LogString($"{type} Bundle directory not found. Bundles will not be packed for {type}. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Create metadata.store file
        /// </summary>
        /// <param name="packmod"></param>
        /// <param name="dlcmod"></param>
        /// <returns></returns>
        public async Task<int> CreateMetaData(bool packmod, bool dlcmod)
        {
            int finished = 1;

            if (packmod && Directory.Exists(ActiveMod.PackedModDirectory))
                finished *= await Task.Run(() => CreateMetaDataInternal(ActiveMod.PackedModDirectory));
            if (dlcmod && Directory.Exists(ActiveMod.PackedDlcDirectory))
                finished *= await Task.Run(() => CreateMetaDataInternal(ActiveMod.PackedDlcDirectory, true));

            return finished == 0 ? 0 : 1;

            async Task<int> CreateMetaDataInternal(string outDir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";

                try
                {
                    //We only pack this if we have bundles.
                    if (Directory.GetFiles(outDir, "*.bundle", SearchOption.AllDirectories).Any())
                    {
                        Logger.LogString($"======== Packing {type} metadata ======== \n", Logtype.Important);
                        //MainController.Get().ProjectStatus = $"Packing {type} metadata";

                        var metadata = new Wcc_lite.metadatastore()
                        {
                            Directory = outDir
                        };

                        return await Task.Run(() => MainController.Get().WccHelper.RunCommand(metadata));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    //AddOutput($"{type} wasn't bundled. Metadata won't be generated. \n", Logtype.Important);
                    Logger.LogString($"{type} wasn't bundled. Metadata won't be generated. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    //AddOutput(ex.ToString() + "\n", Logtype.Error);
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Call wcc buildcache over the uncooked directories 
        /// IN: \\CollisionCache, cooked\\Mods\\mod\\cook.db, OUT: packed\\Mods\\mod
        /// </summary>
        /// <param name="cachetype"></param>
        /// <param name="packmod"></param>
        /// <param name="packdlc"></param>
        /// <returns></returns>
        public async Task<int> GenerateCache(EBundleType cachetype, bool packmod, bool packdlc)
        {
            //const string db_dlcfiles = "db_dlcfiles";
            //const string db_dlctextures = "db_dlctextures";
            //const string db_modfiles = "db_modfiles";
            //const string db_modtextures = "db_modtextures";

            string dlc_files_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), "db_dlcfiles");
            string mod_files_db = Path.Combine(Path.GetFullPath(MainController.Get().ActiveMod.ProjectDirectory), "db_modfiles");
            string moddbfile = Path.Combine(mod_files_db, "cook.db");
            string dlcdbfile = Path.Combine(dlc_files_db, "cook.db");
            string modbasedir = ActiveMod.ModUncookedDirectory;
            string dlcbasedir = MainController.Get().Configuration.DepotPath;


            cachebuilder cbuilder = cachebuilder.textures;
            string filename = "";

            switch (cachetype)
            {
                case EBundleType.TextureCache:
                    {
                        cbuilder = cachebuilder.textures;
                        filename = "texture.cache";
                    }
                    break;
                case EBundleType.CollisionCache:
                    {
                        cbuilder = cachebuilder.physics;
                        filename = "collision.cache";
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }

            int finished = 1;

            if (packmod)
                finished *= await Task.Run(() => GenerateCacheInternal(ActiveMod.PackedModDirectory, moddbfile, modbasedir));
            if (packdlc)
                finished *= await Task.Run(() => GenerateCacheInternal(ActiveMod.PackedDlcDirectory, dlcdbfile, dlcbasedir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> GenerateCacheInternal(string packDir, string dbfile, string basedir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";
                try
                {
                    // check if a cook.db exists for that
                    if (File.Exists(dbfile))
                    {
                        Logger.LogString($"======== Generating {type} {cachetype} cache ======== \n", Logtype.Important);
                        //MainController.Get().ProjectStatus = $"Generating {type} {cachetype} cache";

                        var buildcache = new Wcc_lite.buildcache()
                        {
                            Platform = platform.pc,
                            builder = cbuilder,
                            basedir = basedir,
                            DataBase = dbfile,
                            Out = $"{packDir}\\{filename}"
                        };
                        return await Task.Run(() => MainController.Get().WccHelper.RunCommand(buildcache));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    Logger.LogString($"{type} {cachetype} folder not found. {type} {cachetype} won't be generated. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Manually creates a seedfile for cooking
        /// </summary>
        /// <param name="seedfile"></param>
        public void CreateFallBackSeedFile(string seedfile)
        {

            if (File.Exists(seedfile))
                File.Delete(seedfile);

            var uncookeddlcdir = new DirectoryInfo(ActiveMod.DlcUncookedDirectory);
            if (uncookeddlcdir.Exists)
            {
                using (var fs = new FileStream(seedfile, FileMode.Create, FileAccess.Write))
                using (var sr = new StreamWriter(fs, Encoding.Default))
                {
                    sr.WriteLine("{");
                    sr.WriteLine("\t\"files\": [");

                    FileInfo[] files = uncookeddlcdir.GetFiles("*", SearchOption.AllDirectories);
                    for (int i = 0; i < files.Length; i++)
                    {
                        var file = files[i];
                        var relpath = $"{file.FullName.Substring(uncookeddlcdir.FullName.Length + 1)}";
                        if (!relpath.StartsWith("dlc\\"))
                        {
                            relpath = $"dlc\\{relpath}";
                        }

                        relpath = relpath.Replace("\\", "\\\\");
                        sr.WriteLine("\t\t{");
                        sr.WriteLine($"\t\t\t\"path\": \"{relpath}\",");
                        sr.WriteLine($"\t\t\t\"bundle\": \"blob\"");
                        if (i < files.Length - 1)
                            sr.WriteLine("\t\t},");
                        else
                            sr.WriteLine("\t\t}");
                    }

                    sr.WriteLine("\t]");
                    sr.WriteLine("}");
                }
                Logger.LogString($"Fallback seedfile created: {seedfile}. \n", Logtype.Success);
            }
        }

        /// <summary>
        /// Creates virtual links (mklink junction) between the project dlc folder
        /// and the modkit r4Data/dlc folder
        /// </summary>
        public void CreateVirtualLinks()
        {
            if (string.IsNullOrEmpty(ActiveMod.GetDlcName()))
                return;
            if (string.IsNullOrEmpty(ActiveMod.GetDlcUncookedRelativePath()))
                return;

            // hack to determine if older project
            string r4link = Path.Combine(MainController.Get().Configuration.DepotPath, "dlc", ActiveMod.GetDlcName());
            string projlink = Path.Combine(ActiveMod.DlcUncookedDirectory, ActiveMod.GetDlcUncookedRelativePath());
            if (new DirectoryInfo(ActiveMod.DlcUncookedDirectory).GetDirectories().Any(_ => _.Name == "dlc"))
            {
                projlink = Path.Combine(ActiveMod.DlcUncookedDirectory, "dlc", ActiveMod.GetDlcUncookedRelativePath());
            }

            if (Directory.Exists(r4link))
            {
                Directory.Delete(r4link);
            }
            if (!Directory.Exists(r4link))
            {
                string args = $"/c mklink /J \"{r4link}\" \"{projlink}\"";
                var startInfo = new ProcessStartInfo("cmd.exe", args)
                {
                    WindowStyle = ProcessWindowStyle.Minimized
                };
                Process.Start(startInfo);

                Logger.LogString($"Links {r4link} <<==>> {projlink} succesfully created.", Logtype.Success);
            }
        }
        #endregion

        #region Methods
        public bool CloseAllDocuments()
        {
            //if (ActiveMod == null) return false;
            if (GetOpenDocuments().Count <= 0) return true;

            bool saveall;
            switch (m_windowFactory.ShowMessageBox(
                "This will close all open documents. You will loose any unsaved progress in open files. " +
                "Press Yes to save all open documents or No to continue without saving.",
                "Save Open Documents",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                default:
                    return false;
                case DialogResult.Yes:
                {
                    saveall = true;
                    break;
                }
                case DialogResult.No:
                {
                    saveall = false;
                    break;
                }
                case DialogResult.Cancel:
                {
                    return false;
                }
            }

            // close ViewModels and let the event close the Views
            foreach (var t in GetOpenDocuments().Values.ToList())
            {
                if (saveall)
                    t.SaveFile();
                t.Close();
            }

            // close the Views directly
            //var opendocs = dockPanel.Documents
            //    .Where(_ => _.GetType() == typeof(frmCR2WDocument))
            //    .Cast<frmCR2WDocument>()
            //    .ToList();

            //foreach (var frmCr2WDocument in opendocs)
            //{
            //    if (saveall)
            //        frmCr2WDocument.GetViewModel().SaveFile();
            //    frmCr2WDocument.Close();
            //}

            return true;
        }

        public void SaveActiveFile() => ActiveDocument?.SaveFile();
        

        

        

        #region Mod Utility
        public void PackProject()
        {
            if (ActiveMod == null)
            {
                m_windowFactory.ShowMessageBox(@"Please create a new mod project."
                    , "Missing Mod Project"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }
            if (_packer != null && (_packer.Status == TaskStatus.Running || _packer.Status == TaskStatus.WaitingToRun || _packer.Status == TaskStatus.WaitingForActivation))
            {
                m_windowFactory.ShowMessageBox("Packing task already running. Please wait!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                _packer = PackAndInstallMod();
        }
        
        public async Task<bool> PackAndInstallMod(bool install = true)
        {
            if (ActiveMod == null)
                return false;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                Logger.LogString("Please close The Witcher 3 before tinkering with the files!", Logtype.Error);
                return false;
            }

            var packsettings = m_windowFactory.ShowPackSettings();
            if (packsettings != null)
            {
                MainController.Get().ProjectStatus = EProjectStatus.Busy;

                //toolStripBtnPack.Enabled = false;
                IsToolStripBtnPackEnabled = false;
                //ShowConsole();
                //ShowOutput();
                //ClearOutput();

                m_windowFactory.ShowConsole();


                SaveAllFiles();

                //Create the dirs. So script only mods don't die.
                Directory.CreateDirectory(ActiveMod.PackedModDirectory);
                if (!string.IsNullOrEmpty(ActiveMod.GetDlcName()))
                    Directory.CreateDirectory(ActiveMod.PackedDlcDirectory);


                //------------------------PRE COOKING------------------------------------//
                // have a check if somehow users forget to add a dlc folder in their dlc :(
                // but have files inform them that it just not gonna work
                bool initialDlcCheck = true;
                if (ActiveMod.DLCFiles.Any() && string.IsNullOrEmpty(ActiveMod.GetDlcName()))
                {
                    Logger.LogString("Files in your dlc directory need to have the following structure: dlc\\DLCNAME\\files. Dlc will not be packed.", Logtype.Error);
                    initialDlcCheck = false;
                }

                #region Pre Cooking
                //Handle strings.
                if (packsettings.Strings.Item1 || packsettings.Strings.Item2)
                {
                    m_windowFactory.RequestStringsGUI();
                }

                // Cleanup Directories
                CleanupDirectories();

                // Create Virtial Links
                CreateVirtualLinks();

                // analyze files in dlc
                int statusanalyzedlc = -1;

                var seedfile = Path.Combine(ActiveMod.ProjectDirectory, @"cooked", $"seed_dlc{ActiveMod.Name}.files");

                if (initialDlcCheck)
                {
                    if (Directory.GetFiles(ActiveMod.DlcDirectory, "*", SearchOption.AllDirectories).Any())
                    {
                        Logger.LogString($"======== Analyzing dlc files ======== \n", Logtype.Important);
                        if (Directory.GetFiles(ActiveMod.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).Any())
                        {
                            var reddlcfile = Directory.GetFiles(ActiveMod.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).FirstOrDefault();
                            var analyze = new Wcc_lite.analyze()
                            {
                                Analyzer = analyzers.r4dlc,
                                Out = seedfile,
                                reddlc = reddlcfile
                            };
                            statusanalyzedlc *= await Task.Run(() => MainController.Get().WccHelper.RunCommand(analyze));

                            if (statusanalyzedlc == 0)
                            {
                                Logger.LogString("Analyzing dlc failed, creating fallback seedfiles. \n", Logtype.Error);
                                CreateFallBackSeedFile(seedfile);
                            }
                        }
                        else
                        {
                            Logger.LogString("No reddlc found, creating fallback seedfiles. \n", Logtype.Error);
                            CreateFallBackSeedFile(seedfile);
                        }
                    }
                }
                #endregion

                //------------------------- COOKING -------------------------------------//
                #region Cooking
                int statusCook = -1;

                // cook uncooked files
                var taskCookCol = Task.Run(() => Cook());
                await taskCookCol.ContinueWith(antecedent =>
                {
                    //Logger.LogString($"Cooking Collision ended with status: {antecedent.Result}", Logtype.Important);
                    statusCook = antecedent.Result;
                });
                if (statusCook == 0)
                    Logger.LogString("Cooking collision finished with errors. \n", Logtype.Error);

                #endregion

                //------------------------- POST COOKING --------------------------------//
                #region Copy Cooked Files
                // copy mod files from Bundle (cooked files) to \cooked
                if (Directory.GetFiles(ActiveMod.ModCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    Logger.LogString($"======== Adding cooked mod files ======== \n", Logtype.Important);
                    try
                    {
                        var di = new DirectoryInfo(ActiveMod.ModCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        Logger.LogString($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            string relpath = fi.FullName.Substring(ActiveMod.ModCookedDirectory.Length + 1);
                            string newpath = Path.Combine(ActiveMod.CookedModDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                Logger.LogString($"Duplicate cooked file found {newpath}. Overwriting. \n", Logtype.Important);
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            Logger.LogString($"Copied file to cooked directory: {fi.FullName}. \n", Logtype.Normal);
                        }
                    }
                    catch (Exception)
                    {
                        Logger.LogString("Copying cooked mod files finished with errors. \n", Logtype.Error);
                    }
                    finally
                    {
                        Logger.LogString("Finished succesfully. \n", Logtype.Success);
                    }
                }

                // copy dlc files from Bundle (cooked files) to \cooked
                if (Directory.GetFiles(ActiveMod.DlcCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    Logger.LogString($"======== Adding cooked dlc files ======== \n", Logtype.Important);
                    try
                    {
                        var di = new DirectoryInfo(ActiveMod.DlcCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        Logger.LogString($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            string relpath = fi.FullName.Substring(ActiveMod.DlcCookedDirectory.Length + 1);
                            string newpath = Path.Combine(ActiveMod.CookedDlcDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                Logger.LogString($"Duplicate cooked file found {newpath}. Overwriting. \n", Logtype.Important);
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            Logger.LogString($"Copied file to cooked directory: {fi.FullName}. \n", Logtype.Normal);
                        }
                    }
                    catch (Exception)
                    {
                        Logger.LogString("Copying cooked dlc files finished with errors. \n", Logtype.Error);
                    }
                    finally
                    {
                        Logger.LogString("Finished succesfully. \n", Logtype.Success);
                    }
                }
                #endregion

                //------------------------- PACKING -------------------------------------//
                #region Packing
                int statusPack = -1;

                //Handle bundle packing.
                if (packsettings.PackBundles.Item1 || packsettings.PackBundles.Item2)
                {
                    // packing
                    //if (statusCookCol * statusCookTex != 0)
                    {
                        var t = Task.Run(() => Pack(packsettings.PackBundles.Item1, packsettings.PackBundles.Item2));
                        await t.ContinueWith(antecedent =>
                        {
                            //Logger.LogString($"Packing Bundles ended with status: {antecedent.Result}", Logtype.Important);
                            statusPack = antecedent.Result;
                        });
                        if (statusPack == 0)
                            Logger.LogString("Packing bundles finished with errors. \n", Logtype.Error);
                    }
                    //else
                    //    Logger.LogString("Cooking assets failed. No bundles will be packed!\n", Logtype.Error);
                }
                #endregion

                //------------------------ METADATA -------------------------------------//
                #region Metadata
                //Handle metadata generation.
                int statusMetaData = -1;

                if (packsettings.GenMetadata.Item1 || packsettings.GenMetadata.Item2)
                {
                    if (statusPack == 1)
                    {
                        var t = Task.Run(() => CreateMetaData(packsettings.GenMetadata.Item1, packsettings.GenMetadata.Item2));
                        await t.ContinueWith(antecedent =>
                        {
                            statusMetaData = antecedent.Result;
                            //Logger.LogString($"Creating metadata ended with status: {statusMetaData}", Logtype.Important);
                        });
                        if (statusMetaData == 0)
                            Logger.LogString("Creating metadata finished with errors. \n", Logtype.Error);
                    }
                    else
                        Logger.LogString("Packing bundles failed. No metadata will be created!\n", Logtype.Error);
                }
                #endregion

                //------------------------ POST COOKING ---------------------------------//

                //---------------------------- CACHES -----------------------------------//
                #region Buildcache
                int statusCol = -1;
                int statusTex = -1;

                //Generate collision cache
                if (packsettings.GenCollCache.Item1 || packsettings.GenCollCache.Item2)
                {
                    var t = Task.Run(() => GenerateCache(EBundleType.CollisionCache, packsettings.GenCollCache.Item1, packsettings.GenCollCache.Item2));
                    await t.ContinueWith(antecedent =>
                    {
                        statusCol = antecedent.Result;
                        //Logger.LogString($"Building collision cache ended with status: {statusCol}", Logtype.Important);
                    });
                    if (statusCol == 0)
                        Logger.LogString("Building collision cache finished with errors. \n", Logtype.Error);
                }

                //Handle texture caching
                if (packsettings.GenTexCache.Item1 || packsettings.GenTexCache.Item2)
                {
                    var t = Task.Run(() => GenerateCache(EBundleType.TextureCache, packsettings.GenTexCache.Item1, packsettings.GenTexCache.Item2));
                    await t.ContinueWith(antecedent =>
                    {
                        statusTex = antecedent.Result;
                        //Logger.LogString($"Building texture cache ended with status: {statusTex}", Logtype.Important);
                    });
                    if (statusTex == 0)
                        Logger.LogString("Building texture cache finished with errors. \n", Logtype.Error);
                }


                //Handle sound caching
                if (packsettings.Sound.Item1 || packsettings.Sound.Item2)
                {
                    if (packsettings.Sound.Item1)
                    {
                        var soundmoddir = Path.Combine(ActiveMod.ModDirectory, EBundleType.SoundCache.ToString());

                        // We need to have the original soundcache's so we can rebuild them when packing the mod
                        foreach (var wem in Directory.GetFiles(soundmoddir, "*.wem", SearchOption.AllDirectories))
                        {
                            // Get the file id so we can search for the parent soundcache
                            var id = Path.GetFileNameWithoutExtension(SoundCache.GetIDFromPath(wem));

                            // Find the parent bank
                            foreach (var bnk in SoundCache.info.Banks)
                            {
                                if (bnk.IncludedFullFiles.Any(x => x.Id == id) || bnk.IncludedPrefetchFiles.Any(x => x.Id == id))
                                {
                                    if (!File.Exists(Path.Combine(soundmoddir, bnk.Path)))
                                    {
                                        var bytes = MainController.ImportFile(bnk.Path, MainController.Get().SoundManager);
                                        File.WriteAllBytes(Path.Combine(soundmoddir, bnk.Path), bytes[0].ToArray());
                                        MainController.Get().Logger.LogString("Imported " + bnk.Path + " for rebuilding with the modded wem files!");
                                    }
                                    break;
                                }
                            }
                        }

                        foreach (var bnk in Directory.GetFiles(soundmoddir, "*.bnk", SearchOption.AllDirectories))
                        {
                            Soundbank bank = new Soundbank(bnk);
                            bank.readFile();
                            bank.read_wems(soundmoddir);
                            bank.rebuild_data();
                            File.Delete(bnk);
                            bank.build_bnk(bnk);
                            Logger.LogString("Rebuilt modded bnk " + bnk, Logtype.Success);
                        }

                        //Create mod soundspc.cache
                        if (Directory.Exists(soundmoddir) &&
                        new DirectoryInfo(soundmoddir)
                        .GetFiles("*.*", SearchOption.AllDirectories)
                        .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                        {
                            SoundCache.Write(
                                new DirectoryInfo(soundmoddir)
                                    .GetFiles("*.*", SearchOption.AllDirectories)
                                    .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk"))
                                    .ToList().Select(x => x.FullName).ToList(),
                                    Path.Combine(ActiveMod.PackedModDirectory, @"soundspc.cache"));
                            Logger.LogString("Mod soundcache generated!\n", Logtype.Important);
                        }
                        else
                        {
                            Logger.LogString("Mod soundcache wasn't generated!\n", Logtype.Important);
                        }
                    }

                    if (packsettings.Sound.Item2)
                    {
                        var sounddlcdir = Path.Combine(ActiveMod.DlcDirectory, EBundleType.SoundCache.ToString());

                        //Create dlc soundspc.cache
                        if (Directory.Exists(sounddlcdir) && new DirectoryInfo(sounddlcdir)
                            .GetFiles("*.*", SearchOption.AllDirectories).Any(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")))
                        {
                            SoundCache.Write(
                                new DirectoryInfo(sounddlcdir)
                                    .GetFiles("*.*", SearchOption.AllDirectories)
                                    .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).ToList().Select(x => x.FullName).ToList(),
                                Path.Combine(ActiveMod.PackedDlcDirectory, @"soundspc.cache"));
                            Logger.LogString("DLC soundcache generated!\n", Logtype.Important);
                        }
                        else
                        {
                            Logger.LogString("DLC soundcache wasn't generated!\n", Logtype.Important);
                        }
                    }
                }
                #endregion

                //---------------------------- SCRIPTS ----------------------------------//
                #region Scripts
                (bool packscriptsMod, bool packscriptsdlc) = packsettings.Scripts;
                //Handle mod scripts
                if (packscriptsMod && Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")))
                        Directory.CreateDirectory(Path.Combine(ActiveMod.ModDirectory, "scripts"));
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.ModDirectory, "scripts"), Path.Combine(ActiveMod.PackedModDirectory, "scripts")));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.ModDirectory, "scripts"), Path.Combine(ActiveMod.PackedModDirectory, "scripts")), true);
                }

                //Handle the DLC scripts
                if (packscriptsdlc && Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")))
                        Directory.CreateDirectory(Path.Combine(ActiveMod.DlcDirectory, "scripts"));
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(ActiveMod.PackedDlcDirectory, "scripts")));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(ActiveMod.PackedDlcDirectory, "scripts")), true);
                }
                #endregion

                //---------------------------- STRINGS ----------------------------------//
                #region Strings
                //Copy the generated w3strings
                if (packsettings.Strings.Item1 || packsettings.Strings.Item2)
                {
                    var files = Directory.GetFiles((ActiveMod.ProjectDirectory + "\\strings")).Where(s => Path.GetExtension(s) == ".w3strings").ToList();

                    if (packsettings.Strings.Item1)
                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.PackedDlcDirectory, Path.GetFileName(x))));
                    if (packsettings.Strings.Item2)
                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.PackedModDirectory, Path.GetFileName(x))));
                }
                #endregion

                //---------------------------- FINALIZE ---------------------------------//


                //Install the mod
                if (install)
                    InstallMod();

                //Report that we are done
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                //toolStripBtnPack.Enabled = true;
                IsToolStripBtnPackEnabled = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsToolStripBtnPackEnabled { get; private set; }


        


        /// <summary>
        /// Scans the depot and the given archivemanagers for a file. If found, extracts it to the project.
        /// Supports Uncooking and exporting with wcc_lite
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="manager"></param>
        /// <param name="skipping"></param>
        /// <param name="addAsDLC"></param>
        /// <param name="uncook"></param>
        /// <param name="export"></param>
        /// <returns></returns>
        public bool AddToMod(string relativePath, IWitcherArchiveManager manager, bool skipping, bool addAsDLC, bool uncook = false, bool export = false)
        {
            bool skip = skipping;
            string extension = Path.GetExtension(relativePath);
            string filename = Path.GetFileName(relativePath);


            // always uncook xbms, w2mesh, redcloth and redapex in Bundle
            //if ((extension == ".xbm" /*|| Enum.GetNames(typeof(EExportable)).Contains(extension.TrimStart('.'))*/) && manager.TypeName == EBundleType.Bundle)
            //    uncook = true;

            #region Check Existing Files in Working Dir
            // if uncooking check first if the file isn't already in the working depot or the r4depot
            if (uncook)
            {
                var newpath = "";
                // Working Depot
                var fi = new FileInfo(Path.Combine(Path.GetFullPath(MainController.WorkDir), relativePath));
                if (fi.Exists)
                {
                    // copy to uncooked folder in mod project
                    newpath = addAsDLC
                        ? Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath)
                        : Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);

                    fi.CopyToAndCreate(newpath, true);
                    Logger.LogString($"Added {filename} from depot.", Logtype.Success);

                    // Optionally Export 
                    if (export && File.Exists(newpath))
                    {
                        var task = Task.Run(() => ExportFileToMod(newpath));
                        Task.WaitAll(task);
                    }

                    return skip;
                }
            }
            #endregion


            if (manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath)))
            {
                IEnumerable<KeyValuePair<string, IWitcherFile>> archives = manager.FileList
                    .Where(x => x.Name == relativePath)
                    .Select(y => new KeyValuePair<string, IWitcherFile>(y.Bundle.ArchiveAbsolutePath, y));
                //string newpath = "";


                #region Uncooking
                // Uncooked files go into the uncooked folders
                if (uncook)
                {
                    // copy to uncooked folder in mod project
                    var uncookTask = Task.Run(() => UncookFileToPath(relativePath, addAsDLC));

                    Task.WaitAll(uncookTask);

                    var uncookedFilesCount = uncookTask.Result;

                    // return if any files have been uncooked, continue to extract otherwise
                    if (uncookedFilesCount > 0)
                    {
                        // Optionally Export 
                        string _newpath = addAsDLC
                            ? Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath)
                            : Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);
                        if (export && File.Exists(_newpath))
                        {
                            var exportTask = Task.Run(() => ExportFileToMod(_newpath));
                            Task.WaitAll(exportTask);
                        }

                        return skip;
                    }
                    else
                        Logger.LogString($"Could not uncook {filename}, trying to extract file instead of uncooking.", Logtype.Important);
                }
                #endregion

                #region Unbundling
                var bundletype = archives.First().Value.Bundle.TypeName;
                string newpath = "";
                switch (bundletype)
                {
                    // extract files from bundle to Cooked
                    case EBundleType.Bundle:
                        {
                            newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                ? Path.Combine("DLC", EProjectFolders.Cooked.ToString(), $"dlc{ActiveMod.Name}",
                                    NormalizeDlcPath(relativePath))
                                : Path.Combine("Mod", EProjectFolders.Cooked.ToString(), relativePath));
                        }
                        break;
                    // extract files from Collision and Texture caches to Raw (except for pngs etc)
                    case EBundleType.CollisionCache:
                    case EBundleType.TextureCache:
                        {
                            // add pngs, jpgs and dds directly to Cooked
                            // (not Raw, since they don't get imported, and not uncooked, since they don't get cooked)
                            if (extension == ".png" || extension == ".jpg" || extension == ".dds")
                            {
                                newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                    ? Path.Combine("DLC", EProjectFolders.Cooked.ToString(), $"dlc{ActiveMod.Name}",
                                        NormalizeDlcPath(relativePath))
                                    : Path.Combine("Mod", EProjectFolders.Cooked.ToString(), relativePath));
                            }
                            // all other textures and collision stuff goes into Raw (since they have to be imported first)
                            else
                                newpath = Path.Combine(ActiveMod.RawDirectory, addAsDLC
                                    ? Path.Combine("DLC", $"dlc{ActiveMod.Name}", NormalizeDlcPath(relativePath))
                                    : Path.Combine("Mod", relativePath));
                        }
                        break;
                    // some special cases
                    case EBundleType.SoundCache:
                    case EBundleType.Speech:
                    case EBundleType.Shader:
                        {
                            newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                ? Path.Combine("DLC", archives.First().Value.Bundle.TypeName.ToString(),
                                    $"dlc{ActiveMod.Name}", NormalizeDlcPath(relativePath))
                                : Path.Combine("Mod", archives.First().Value.Bundle.TypeName.ToString(), relativePath));
                        }
                        break;
                    case EBundleType.ANY:
                    default:
                        throw new NotImplementedException();
                        break;
                }


                // more than one archive
                if (archives.Count() > 1)
                {
                    var a = archives.Select(x => x.Value).ToList();
                    var (s, selectedBundle) = m_windowFactory.ResolveExtractAmbigious(skip, a);
                    if (selectedBundle == null)
                        return skip;
                    else
                        skip = s;

                    Directory.CreateDirectory(Path.GetDirectoryName(newpath));
                    if (File.Exists(newpath))
                    {
                        File.Delete(newpath);
                    }

                    selectedBundle.Extract(new BundleFileExtractArgs(newpath,
                        MainController.Get().Configuration.UncookExtension));

                    return skip;
                }

                // Extract
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(newpath));
                    if (File.Exists(newpath))
                    {
                        File.Delete(newpath);
                    }

                    archives.FirstOrDefault().Value.Extract(new BundleFileExtractArgs(newpath, MainController.Get().Configuration.UncookExtension));

                    Logger.LogString($"Succesfully extracted {filename}.", Logtype.Success);
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString(), Logtype.Error);
                }
                #endregion

                return skip;
            }

            return skip;

            string NormalizeDlcPath(string path)
            {
                // trim off 2 folders from dlc paths for jato
                if (addAsDLC && path.StartsWith("dlc"))
                {
                    var splits = path.Split(Path.DirectorySeparatorChar).ToList();
                    if (splits.Count > 2)
                        path = string.Join(Path.DirectorySeparatorChar.ToString(), splits.Skip(2));
                }
                return path;
            }

        }

        

        #endregion

        #endregion

        #region Documents
        public void SaveAllFiles()
        {
            if (GetOpenDocuments().Count <= 0) return;
            MainController.Get().ProjectStatus = EProjectStatus.Busy;

            foreach (var d in GetOpenDocuments().Values.Where(d => d.SaveTarget != null))
            {
                d.SaveFile();
            }

            foreach (var d in GetOpenDocuments().Values.Where(d => d.SaveTarget == null))
            {
                d.SaveFile();
            }
            Logger.LogString("All files saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = EProjectStatus.Ready;
            MainController.Get().ProjectUnsaved = false;
        }
        
        #endregion
    }
}
