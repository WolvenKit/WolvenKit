using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Model
{
    using Common;
    using Common.Extensions;
    using Common.Model;
    using Common.Services;
    using Common.Wcc;
    using CR2W;
    public static class WccHelper
    {
        private static LoggerService Logger => MainController.Get().Logger;
        private static W3Mod ActiveMod => (W3Mod)MainController.Get().ActiveMod;

        private const string db_dlcfiles = "db_dlcfiles";
        private const string db_dlctextures = "db_dlctextures";
        private const string db_modfiles = "db_modfiles";
        private const string db_modtextures = "db_modtextures";

        /// <summary>
        /// Always call this first to clean the directories.
        /// </summary>
        public static void CleanupDirectories()
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
        public static async Task<int> Cook()
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
        public static async Task<int> Pack(bool packmod, bool packdlc)
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
                    Logger.LogString($"{type} Archive directory not found. Bundles will not be packed for {type}. \n", Logtype.Important);
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
        public static async Task<int> CreateMetaData(bool packmod, bool dlcmod)
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
        public static async Task<int> GenerateCache(EArchiveType cachetype, bool packmod, bool packdlc)
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
                case EArchiveType.TextureCache:
                    {
                        cbuilder = cachebuilder.textures;
                        filename = "texture.cache";
                    }
                    break;
                case EArchiveType.CollisionCache:
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
        public static void CreateFallBackSeedFile(string seedfile)
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
        public static void CreateVirtualLinks()
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

        #region Wcc Tasks
        /// <summary>
        /// Deprecated, Use the Modkit instead
        /// Kept for a neat hack tricking wcc_lite into dumping individual files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static async void RequestWccliteFileDumpfile(object sender, RequestFileOpenArgs e)
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
        public static async Task DumpFile(string folder, string outfolder, string file = "")
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
        public static async Task<int> UncookFileToPath(string basedir, string relativePath, bool isDLC, string alternateOutDirectory = "")
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
            // check if mod or vanilla file
            var indir = isDLC
                ? Path.GetFullPath(MainController.Get().Configuration.GameDlcDir)
                : Path.GetFullPath(MainController.Get().Configuration.W3ExePath);
            if (basedir.Contains(Path.GetFullPath(MainController.Get().Configuration.GameModDir)))
            {
                indir = basedir;
            }


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
        public static string UnbundleFile(string relativePath, bool isDlc, EProjectFolders projectFolder, EArchiveType bundleType = EArchiveType.Bundle, string alternateOutDirectory = "", bool loadmods = false, bool silent = false)
        {
            string extension = Path.GetExtension(relativePath);
            string filename = Path.GetFileName(relativePath);

            // Jato said not to add textures to an fbx 
            // so I am keeping meshes violet :)
            //if (extension == ".xbm" && bundleType == EBundleType.Archive)
            //{
            //    //var uncookTask = Task.Run(() => UncookFileToPath(relativePath, isDLC, alternateOutDirectory));
            //    //Task.WaitAll(uncookTask);
            //    //return relativePath;
            //    UnbundleFile(relativePath, isDLC, projectFolder, EBundleType.TextureCache, alternateOutDirectory,
            //        loadmods, silent);
            //}
            IGameArchiveManager manager = MainController.Get().GetManagers(loadmods).FirstOrDefault(_ => _.TypeName == bundleType);

            if (manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath)))
            {
                var archives = manager.FileList
                    .Where(x => x.Name == relativePath)
                    .Select(y => new KeyValuePair<string, IGameFile>(y.Archive.ArchiveAbsolutePath, y))
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
                                newpath = Path.Combine(isDlc
                                    ? ActiveMod.DlcCookedDirectory
                                    : ActiveMod.ModCookedDirectory, relativePath);
                                break;
                            case EProjectFolders.Uncooked:
                                newpath = Path.Combine(isDlc
                                    ? ActiveMod.DlcUncookedDirectory
                                    : ActiveMod.ModUncookedDirectory, relativePath);
                                break;
                            case EProjectFolders.Raw:
                                newpath = Path.Combine(isDlc
                                    ? ActiveMod.RawDlcDirectory
                                    : ActiveMod.RawModDirectory, relativePath);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        newpath = Path.Combine(alternateOutDirectory, relativePath);
                    }

                    if (string.IsNullOrWhiteSpace(newpath))
                        return "";

                    // for xbms check if a file with the current export extensions exists
                    if (!File.Exists(newpath) && (extension != ".xbm" || !File.Exists(Path.ChangeExtension(newpath,
                        MainController.Get().Configuration.UncookExtension.ToString()))))
                    {
                        string extractedfile = archive.Extract(new BundleFileExtractArgs(newpath,
                            MainController.Get().Configuration.UncookExtension));
                        if (!silent)
                            Logger.LogString($"Succesfully unbundled {filename}.", Logtype.Success);
                    }
                    //else
                    //    if (!silent) Logger.LogString($"File already exists in mod project: {filename}.", Logtype.Success);
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
        public static async Task ExportFileToMod(string fullpath)
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
        public static async Task AddAllImports(string importfilepath, 
            bool recursive = false, bool silent = false, string alternateOutDirectory = "", bool logonly = false)
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
            foreach (var import in importslist)
            {
                var filename = Path.GetFileName(import.DepotPathStr);
                if (logonly) MainController.LogString(filename, Logtype.Important);

                var path = UnbundleFile(import.DepotPathStr, isDLC, projectFolder, EArchiveType.Bundle, alternateOutDirectory, false, silent);
                // If unbundled file is xbm, also extract tga from texturecache
                if (Path.GetExtension(import.DepotPathStr) == ".xbm")
                {
                    UnbundleFile(import.DepotPathStr, isDLC, EProjectFolders.Raw, EArchiveType.TextureCache, alternateOutDirectory, false, silent);
                }

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

                    var path = UnbundleFile(bufferpath, isDLC, projectFolder, EArchiveType.Bundle, alternateOutDirectory, false, silent);
                    if (string.IsNullOrWhiteSpace(path))
                        Logger.LogString($"Did not unbundle {bufferName}, import is missing.", Logtype.Error);
                }
            }

            //if (success && !silent)
            //    Logger.LogString($"Succesfully imported all dependencies.", Logtype.Success);
        }

        #endregion
    }
}
