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
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
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
        private readonly bool COOKINPLACE = true;
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
        public async Task ImportFile(string infile, string outfile)
        {
            try
            {
                var importwdir = Path.Combine(Path.GetDirectoryName(MainController.Get().Configuration.WccLite), "WolvenKitWorkingDir");
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
        public async Task UncookFile(string relativePath, string newpath)
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
                InputDirectory = Path.GetFullPath(MainController.Get().Configuration.GameRootDir),
                OutputDirectory = outdir,
                TargetDirectory = relativeParentDir,
                Imgfmt = imgfmt,
                UncookExtensions = Path.GetExtension(newpath).TrimStart('.'),
            };
            await Task.Run(() => MainController.Get().WccHelper.RunCommand(wccuncook));

            // move uncooked file
            int uncookedFilesCount = 0;
            var fis = di.GetFiles("*", SearchOption.AllDirectories);
            foreach (var f in fis)
            {
                if (f.Name.Contains(Path.GetFileName(relativePath)))
                {
                    uncookedFilesCount++;
                    try
                    {
                        if (File.Exists(newpath))
                        {
                            File.Delete(newpath);
                        }
                        f.MoveTo(newpath);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogString($"Unable to move uncooked file to ModProject, perhaps a file of that name is cuurrently open in Wkit.", Logtype.Error);
                    }
                }
                // delete all other files
                else
                    f.Delete();
            }

            // Logging
            if (uncookedFilesCount > 0)
                Logger.LogString($"Uncooked {uncookedFilesCount} files.", Logtype.Success);
            else
                Logger.LogString($"Uncooked {uncookedFilesCount} files. Wcc_lite is unable to uncook this file.", Logtype.Error);
        }
        #endregion

        #region Mod
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

            #region Directory cleanup
            if (!Directory.Exists(modpackDir))
            {
                Directory.CreateDirectory(modpackDir);
            }
            else
            {
                var di = new DirectoryInfo(modpackDir);
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            if (!Directory.Exists(DlcpackDir))
            {
                Directory.CreateDirectory(DlcpackDir);
            }
            else
            {
                var di = new DirectoryInfo(DlcpackDir);
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            #endregion
        }

        /// <summary>
        /// Packs the bundles for the DLC and the Mod. IN: \Bundles, OUT: packed\Mods\mod
        /// </summary>
        public async Task<int> PackBundles()
        {
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var modDir = Path.Combine(ActiveMod.ModDirectory, EBundleType.Bundle.ToString());
            var dlcDir = Path.Combine(ActiveMod.DlcDirectory, EBundleType.Bundle.ToString());
            int finished = 1;

            finished *= await Task.Run(() => PackBundleInternal(modDir, modpackDir));
            finished *= await Task.Run(() => PackBundleInternal(dlcDir, dlcpackDir, true));

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

        public async Task<int> CreateMetaData()  //IN: packed\Mods\mod, OUT: same dir
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

        public async Task<int> Cook(EBundleType cachetype)    //IN: \TextureCache, OUT: \Bundle
        {
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
                        else
                        {
                            if (!COOKINPLACE)
                            {
                                var di = new DirectoryInfo(outdir);
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

        public async Task<int> GenerateCache(EBundleType cachetype) //IN: \CollisionCache, cooked\Mods\mod\cook.db, OUT: packed\Mods\mod
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



        #endregion // Mod Pack

    }
}
