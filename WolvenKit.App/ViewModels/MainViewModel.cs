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
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;
using System.Xml.Serialization;
using WolvenKit.App;
using WolvenKit.App.Commands;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Wwise.Wwise;

namespace WolvenKit.App.ViewModels
{
    public class MainViewModel : ViewModel
    {
        #region Properties
        #region Title
        private string _title;
        public virtual string Title
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
        private ObservableCollection<DocumentViewModel> _openDocuments;
        public ObservableCollection<DocumentViewModel> OpenDocuments
        {
            get => _openDocuments;
            set
            {
                if (_openDocuments != value)
                {
                    _openDocuments = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        //#region Active Document
        //private DocumentViewModel _activeDocument;
        //public DocumentViewModel ActiveDocument
        //{
        //    get => _activeDocument;
        //    set
        //    {
        //        if (_activeDocument != value)
        //        {
        //            _activeDocument = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}
        //#endregion


        #endregion

        #region Fields
        private const bool COOKINPLACE = false;
        public readonly LoggerService Logger;
        public W3Mod ActiveMod
        {
            get => MainController.Get().ActiveMod;
            set => MainController.Get().ActiveMod = value;
        }
        #endregion

        public MainViewModel()
        {
            Title = "WolvenKit";

            Logger = MainController.Get().Logger;
            OpenDocuments = new ObservableCollection<DocumentViewModel>();
        }

        #region Helper Methods
        public void ScanAndRegisterCustomClasses()
        {
            if (ActiveMod == null)
                return;

            foreach (var wsfile in ActiveMod.ModFiles.Where(_ => Path.GetExtension(_) == ".ws"))
            {
                string fullpath = Path.Combine(ActiveMod.ModDirectory, wsfile);
                var lines = File.ReadAllLines(fullpath);
                foreach (var line in lines)
                {
                    var reg = new Regex(@"^.*(?:class)\s+(\w+)\s*(.*)");
                    var match = reg.Match(line);
                    if (match.Success)
                    {
                        // check for extends
                        string classname = match.Groups[1].Value;
                        string extends = match.Groups[2].Value;
                        if (!string.IsNullOrEmpty(extends))
                        {
                            var ireg = new Regex(@"^.*(?:extends)\s+(\w+)");
                            var imatch = ireg.Match(extends);
                            if (imatch.Success)
                            {
                                string parent = imatch.Groups[1].Value;
                                if (!CR2WTypeManager.Get().AvailableTypes.Contains(classname))
                                {
                                    CR2WTypeManager.Get().RegisterAs(classname, parent);
                                    Logger.LogString($"Registering custom class {classname} as {parent}.\r\n", Logtype.Success);
                                }
                            }
                            else
                            {
                                if (!CR2WTypeManager.Get().AvailableTypes.Contains(classname))
                                {
                                    CR2WTypeManager.Get().Register(classname, new CVector(null));
                                    Logger.LogString($"Registering custom class {classname} as CVector.\r\n", Logtype.Success);
                                }
                            }
                        }
                        else
                        {
                            if (!CR2WTypeManager.Get().AvailableTypes.Contains(classname))
                            {
                                CR2WTypeManager.Get().Register(classname, new CVector(null));
                                Logger.LogString($"Registering custom class {classname} as CVector.\r\n", Logtype.Success);
                            }
                        }
                    }
                }
            }
        }
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

        #region WCC TASKS
        public async Task DumpFile(string folder, string outfolder)
        {
            try
            {
                var cmd = new Wcc_lite.dumpfile()
                {
                    Dir = folder,
                    Out = outfolder
                };
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(cmd));
            }
            catch (Exception ex)
            {
                Logger.LogString(ex.ToString() + "\n", Logtype.Error);
            }

            MainController.Get().ProjectStatus = "File dumped succesfully!";

        }

        /// <summary>
        /// Deprecated. Use ImportUtility instead.
        /// Imports a given file (w2mesh or redcloth to the mod project.
        /// </summary>
        /// <param name="infile"></param>
        /// <param name="outfile"></param>
        /// <returns></returns>
        public async Task ImportFile(string infile, string outfile)
        {
            try
            {
                var importwdir = Path.GetFullPath(MainController.WorkDir);
                if (Directory.Exists(importwdir))
                    Directory.Delete(importwdir, true);
                Directory.CreateDirectory(importwdir);

                File.Copy(infile, Path.Combine(importwdir, Path.GetFileName(infile)));

                MainController.Get().ProjectStatus = "Importing file";
                if (!Directory.Exists(Path.GetDirectoryName(outfile)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(outfile));
                }

                var import = new Wcc_lite.import()
                {
                    Depot = MainController.Get().Configuration.DepotPath,
                    File = Path.Combine(importwdir, Path.GetFileName(infile)),
                    Out = outfile
                };
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(import));
            }
            catch (Exception ex)
            {
                Logger.LogString(ex.ToString() + "\n", Logtype.Error);
            }

            MainController.Get().ProjectStatus = "File imported succesfully!";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="newpath"></param>
        /// <returns></returns>
        public async Task<int> UncookFileToMod(string relativePath, string newpath, string indir)
        {
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
            var wccuncook = new Wcc_lite.uncook()
            {
                InputDirectory = indir,
                OutputDirectory = outdir,
                TargetDirectory = relativeParentDir,
                Imgfmt = imgfmt,
                //UncookExtensions = Path.GetExtension(newpath).TrimStart('.'),
            };
            await Task.Run(() => MainController.Get().WccHelper.RunCommand(wccuncook));

            // move uncooked file to mod project
            int uncookedFilesCount = 0;
            int addedFilesCount = 0;
            var fis = di.GetFiles("*", SearchOption.AllDirectories);
            foreach (var f in fis)
            {
                if (f.Name.Contains(Path.GetFileName(relativePath)))
                {
                    
                    try
                    {
                        if (File.Exists(newpath))
                        {
                            File.Delete(newpath);
                        }

                        f.CopyToAndCreate(newpath);

                        uncookedFilesCount++;
                    }
                    catch (Exception ex)
                    {
                        Logger.LogString($"Unable to move uncooked file to ModProject, perhaps a file of that name is cuurrently open in Wkit.", Logtype.Error);
                    }
                }
                
                // move all other files to depot
                if (MainController.Get().Configuration.OverflowEnabled)
                {
                    string frelativePath = f.FullName.Substring(outdir.Length + 1);
                    string depotdir = MainController.Get().Configuration.DepotPath;

                    f.CopyToAndCreate(Path.Combine(depotdir, frelativePath), true);
                    addedFilesCount++;
                }
            }

            // Logging
            Logger.LogString($"Moved {addedFilesCount} files to depot.", Logtype.Important);
            if (uncookedFilesCount > 0)
                Logger.LogString($"Successfully uncooked {uncookedFilesCount} files.", Logtype.Success);
            else
                Logger.LogString($"Wcc_lite is unable to uncook this file.", Logtype.Error);
            

            return uncookedFilesCount;
        }

        /// <summary>
        /// Unbundles a file with the given relativepath from either the Game or the Mod BundleManager
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="addAsDLC"></param>
        /// <param name="loadmods"></param>
        /// <returns></returns>
        public int UnbundleFileToMod(string relativePath, bool addAsDLC, bool loadmods = false)
        {
            string extension = Path.GetExtension(relativePath);
            string filename = Path.GetFileName(relativePath);
            IWitcherArchive manager = MainController.Get().GetManagers(loadmods).FirstOrDefault(_ => _.TypeName == EBundleType.Bundle);

            if (manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath)))
            {
                var archives = manager.FileList.Where(x => x.Name == relativePath).Select(y => new KeyValuePair<string, IWitcherFile>(y.Bundle.FileName, y));
                string newpath;

                // Generte filepaths
                // Texture and Collision Caches go into Raw (except for pngs, jpgs, and dds)
                if (archives.First().Value.Bundle.TypeName == EBundleType.CollisionCache
                    || archives.First().Value.Bundle.TypeName == EBundleType.TextureCache)
                {
                    // add pngs, jpgs and dds directly to TextureCache (not Raw, since they don't get imported)
                    if (extension == ".png" || extension == ".jpg" || extension == ".dds")
                    {
                        newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                            ? Path.Combine("DLC", archives.First().Value.Bundle.TypeName.ToString(), "dlc", ActiveMod.Name, relativePath)
                            : Path.Combine("Mod", archives.First().Value.Bundle.TypeName.ToString(), relativePath));
                    }
                    // all other textures and collision stuff goes into Raw (since they have to be imported first)
                    else
                        newpath = Path.Combine(ActiveMod.RawDirectory, addAsDLC
                            ? Path.Combine("DLC", /*archives.First().Value.Bundle.TypeName.ToString(),*/ "dlc", ActiveMod.Name, relativePath)
                            : Path.Combine("Mod", /*archives.First().Value.Bundle.TypeName.ToString(),*/ relativePath));
                }
                // Bundles
                else
                {
                    newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                        ? Path.Combine("DLC", archives.First().Value.Bundle.TypeName.ToString(), "dlc", ActiveMod.Name, relativePath)
                        : Path.Combine("Mod", archives.First().Value.Bundle.TypeName.ToString(), relativePath));
                }

                // Extract
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(newpath));
                    if (File.Exists(newpath))
                    {
                        File.Delete(newpath);
                    }

                    // if more than one archive get the last
                    archives.LastOrDefault().Value.Extract(new BundleFileExtractArgs(newpath, MainController.Get().Configuration.UncookExtension));

                    return 1;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString(), Logtype.Error);

                    return 0;
                }
            }

            return 0;
        }

        /// <summary>
        /// Exports and existing file in the ModProject (w2mesh, redcloth) to the modProject
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public async Task ExportFileToMod(string fullpath)
        {
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
            var relativePath = fullpath.Substring(ActiveMod.FileDirectory.Length + 1);
            bool isDLC = false;
            if (relativePath.StartsWith("DLC\\"))
                isDLC = true;
            else if (relativePath.StartsWith("Mod\\"))
                isDLC = false;
            else
            {
                Logger.LogString($"File can only be exported from the Uncooked Directories.", Logtype.Error);
                return;
            }


            relativePath = relativePath.Substring(4);
            if (relativePath.StartsWith(EBundleType.Bundle.ToString()))
                relativePath = relativePath.Substring(EBundleType.Bundle.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.TextureCache.ToString()))
                relativePath = relativePath.Substring(EBundleType.TextureCache.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.CollisionCache.ToString()))
                relativePath = relativePath.Substring(EBundleType.CollisionCache.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.SoundCache.ToString()))
                relativePath = relativePath.Substring(EBundleType.SoundCache.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.Speech.ToString()))
                relativePath = relativePath.Substring(EBundleType.Speech.ToString().Length + 1);


            var exportpath = isDLC ? Path.Combine(ActiveMod.RawDirectory, "DLC", relativePath) : Path.Combine(ActiveMod.RawDirectory, "Mod", relativePath);
            exportpath = Path.ChangeExtension(exportpath, exportedExtension.ToString());

            // check imports
            await AddAllImportsToMod(fullpath);

            // copy the w2mesh and all imports to the depot if it doesn't already exist
            var depotInfo = new FileInfo(Path.Combine(MainController.Get().Configuration.DepotPath, relativePath));
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
                    Depot = MainController.Get().Configuration.DepotPath
                };
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(export));

                if (File.Exists(exportpath))
                    Logger.LogString($"Successfully exported {relativePath}.", Logtype.Success);
                else
                    Logger.LogString($"Did not export {relativePath}.", Logtype.Error);
            }
        }

        public async Task AddAllImportsToMod(string fullpath)
        {
            if (!File.Exists(fullpath))
                return;

            List<CR2WImportWrapper> importslist = new List<CR2WImportWrapper>();
            using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                var cr2w = new CR2WFile();
                importslist = cr2w.ReadImports(reader);
            }
            foreach (CR2WImportWrapper import in importslist)
            {
                var relativepath = import.DepotPathStr;
                var depotpath = Path.Combine(MainController.Get().Configuration.DepotPath, relativepath);

                // if import is not in depot, uncook to depot
                if (!File.Exists(depotpath))
                {
                    //Logger.LogString($"Missing import {depotpath}! ", Logtype.Error);
                    Logger.LogString($"Uncooking missing import {relativepath} and adding to depot ...", Logtype.Important);
                    bool success = await Task.Run(() => UncookFileToMod(relativepath, depotpath, Path.GetFullPath(MainController.Get().Configuration.GameRootDir))) > 0;

                    if (!success)
                    {
                        Logger.LogString($"Did not uncook file, trying to extract file instead of uncooking.", Logtype.Important);

                        success = UnbundleFileToMod(relativepath, false) > 0;
                        if (!success)
                        {
                            Logger.LogString($"Did not unbundle file, import is missing.", Logtype.Error);
                        }
                    }
                }
            }
        }

        #endregion

        #region Mod
        /// <summary>
        /// Saves a W3ModProject
        /// </summary>
        public void SaveMod()
        {
            if (ActiveMod != null)
            {
                if (ActiveMod.LastOpenedFiles != null)
                    ActiveMod.LastOpenedFiles = OpenDocuments.Select(x => x.FileName).ToList();
                var ser = new XmlSerializer(typeof(W3Mod));
                var modfile = new FileStream(ActiveMod.FileName, FileMode.Create, FileAccess.Write);
                ser.Serialize(modfile, ActiveMod);
                modfile.Close();
            }
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
                XDocument installlog = new XDocument(new XElement("InstalLog", new XAttribute("Project", ActiveMod.Name), new XAttribute("Build_date", DateTime.Now.ToString())));
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
        

        /// <summary>
        /// Always call this first to clean the directories.
        /// </summary>
        public void CleanupDirectories()
        {
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");

            CleanupInner(modpackDir);
            CleanupInner(DlcpackDir);
            CleanupInner(cookedModDir);
            CleanupInner(cookedDLCDir);

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
        /// IN: \TextureCache, OUT: \Bundle OR \cooked
        /// </summary>
        /// <param name="cachetype"></param>
        /// <returns></returns>
        public async Task<int> Cook(EBundleType cachetype)
        {
            if (cachetype == EBundleType.Bundle && COOKINPLACE)
                return 1;

            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            if (COOKINPLACE)
            {
                cookedModDir = Path.Combine(ActiveMod.ModDirectory, EBundleType.Bundle.ToString());
                cookedDLCDir = Path.Combine(ActiveMod.DlcDirectory, EBundleType.Bundle.ToString());
            }
            var modcachedir = Path.Combine(ActiveMod.ModDirectory, cachetype.ToString());
            var dlccachedir = Path.Combine(ActiveMod.DlcDirectory, cachetype.ToString());

            int finished = 1;

            finished *= await Task.Run(() => CookInternal(modcachedir, cookedModDir));
            finished *= await Task.Run(() => CookInternal(dlccachedir, cookedDLCDir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> CookInternal(string cachedir, string outdir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";

                try
                {
                    if (Directory.Exists(cachedir) && Directory.GetFiles(cachedir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Cooking {type} {cachetype}";
                        if (!Directory.Exists(outdir))
                        {
                            Directory.CreateDirectory(outdir);
                        }
                        
                        var cook = new Wcc_lite.cook()
                        {
                            Platform = platform.pc,
                            mod = cachedir,
                            basedir = cachedir,
                            outdir = outdir
                        };
                        return await Task.Run(() => MainController.Get().WccHelper.RunCommand(cook));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    Logger.LogString($"{type} {cachetype} folder not found. {type} won't be cooked. \n", Logtype.Important);
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
        /// IN: \Bundles, OUT: packed\Mods\mod
        /// </summary>
        public async Task<int> Pack()
        {
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            
            if (COOKINPLACE)
            {
                cookedModDir = Path.Combine(ActiveMod.ModDirectory, EBundleType.Bundle.ToString());
                cookedDLCDir = Path.Combine(ActiveMod.DlcDirectory, EBundleType.Bundle.ToString());
            }
            int finished = 1;

            finished *= await Task.Run(() => PackBundleInternal(cookedModDir, modpackDir));
            finished *= await Task.Run(() => PackBundleInternal(cookedDLCDir, dlcpackDir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> PackBundleInternal(string inputDir, string outputDir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";
                try
                {
                    if (Directory.Exists(inputDir) && Directory.GetFiles(inputDir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Packing {type} bundles";

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
        /// Create Metadata
        /// IN: packed\Mods\mod, OUT: same dir
        /// </summary>
        /// <returns></returns>
        public async Task<int> CreateMetaData()
        {
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var modDir = Path.Combine(ActiveMod.ModDirectory, EBundleType.Bundle.ToString());
            var dlcDir = Path.Combine(ActiveMod.DlcDirectory, EBundleType.Bundle.ToString());
            int finished = 1;

            finished *= await Task.Run(() => CreateMetaDataInternal(modDir, modpackDir));
            finished *= await Task.Run(() => CreateMetaDataInternal(dlcDir, dlcpackDir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> CreateMetaDataInternal(string dir, string outDir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";

                try
                {
                    //We only pack this if we have bundles.
                    if (Directory.GetFiles(dir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Packing {type} metadata";
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
        /// IN: \CollisionCache, cooked\Mods\mod\cook.db, OUT: packed\Mods\mod
        /// </summary>
        /// <param name="cachetype"></param>
        /// <returns></returns>
        public async Task<int> GenerateCache(EBundleType cachetype)
        {
            // cooked to \cooked
            var moddbfileDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcdbfileDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            if (COOKINPLACE)
            {
                moddbfileDir = Path.Combine(ActiveMod.ModDirectory, EBundleType.Bundle.ToString());
                dlcdbfileDir = Path.Combine(ActiveMod.DlcDirectory, EBundleType.Bundle.ToString());
            }

            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var modcachedir = Path.Combine(ActiveMod.ModDirectory, cachetype.ToString());
            var dlccachedir = Path.Combine(ActiveMod.DlcDirectory, cachetype.ToString());

            #region Buildcache settings
            cachebuilder cbuilder = cachebuilder.textures;
            string filename = "";
            if (cachetype == EBundleType.TextureCache)
            {
                cbuilder = cachebuilder.textures;
                filename = "texture.cache";
            }
            else if (cachetype == EBundleType.CollisionCache)
            {
                cbuilder = cachebuilder.physics;
                filename = "collision.cache";
            }
            else
            {
                cbuilder = cachebuilder.shaders;
                filename = "shader.cache";
            }
            #endregion

            int finished = 1;

            finished *= await Task.Run(() => GenerateCacheInternal(modpackDir, moddbfileDir, modcachedir));
            finished *= await Task.Run(() => GenerateCacheInternal(dlcpackDir, dlcdbfileDir, dlccachedir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> GenerateCacheInternal(string packDir, string dbfile, string cachedir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";
                try
                {

                    if (Directory.Exists(cachedir) && Directory.GetFiles(cachedir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Generating {type} {cachetype} cache";

                        var buildcache = new Wcc_lite.buildcache()
                        {
                            Platform = platform.pc,
                            builder = cbuilder,
                            basedir = cachedir,
                            DataBase = $"{ dbfile }\\cook.db",
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

        #endregion

        #region Documents
        public void SaveAllFiles()
        {
            foreach (var d in OpenDocuments.Where(d => d.SaveTarget != null))
            {
                SaveFile(d);
            }

            foreach (var d in OpenDocuments.Where(d => d.SaveTarget == null))
            {
                SaveFile(d);
            }
            Logger.LogString("All files saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = "Item(s) Saved";
            MainController.Get().ProjectUnsaved = false;
        }
        public void SaveFile(DocumentViewModel d)
        {
            d.SaveFile();
            Logger.LogString(d.FileName + " saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = "Saved";
        }
        #endregion
    }
}
