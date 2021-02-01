//using SymbolicLinkSupport;
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
using System.Windows.Input;
using System.Globalization;
using System.Reflection;
using Catel;

namespace WolvenKit.ViewModels
{
    using Cache;
    using Common;
    using Common.Extensions;
    using Common.Model;
    using Common.Services;
    using Common.Wcc;
    using CR2W;
    using Wwise.Wwise;
    using Common.WinFormsEnums;
    using Model;
    using Commands;
    using CR2W.Reflection;
    using CR2W.Types;
    using Wwise;

    /// <summary>
    /// 
    /// </summary>
    public sealed class MainViewModel : ViewModel
    {

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }

        #region Properties
        public bool IsToolStripBtnPackEnabled { get; private set; }

        #region Title
        private string _title;
        public new string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    var oldValue = _title;
                    _title = value;
                    RaisePropertyChanged(() => Title, oldValue, value);
                }
            }
        }
        #endregion

        #region Open Documents

        private readonly Dictionary<string, Old_IDocumentViewModel> _openDocuments;
        public Dictionary<string, Old_IDocumentViewModel> GetOpenDocuments() => _openDocuments;

        

        #endregion

        #region Active Document
        private Old_IDocumentViewModel _activeDocument;
        public Old_IDocumentViewModel ActiveDocument
        {
            get => _activeDocument;
            set
            {
                if (_activeDocument != value)
                {
                    var oldValue = _activeDocument;
                    _activeDocument = value;
                    RaisePropertyChanged(() => ActiveDocument, oldValue, value);
                }
            }
        }
        #endregion

        #endregion

        #region Fields
        private static Task _packer;
        private static LoggerService Logger => MainController.Get().Logger;
        private static EditorProjectData ActiveMod => MainController.Get().ActiveMod;
        
        #endregion

        public MainViewModel()
        {
            Title = "WolvenKit";

            _openDocuments = new Dictionary<string, Old_IDocumentViewModel>();
            

            DdsToCacheCommand = new RelayCommand(DdsToCache, CanDdsToCacheCommand);
            CreateCr2wFileCommand = new DelegateCommand<bool>(CreateCr2w, CanCreateCr2w);
            BackupProjectCommand = new RelayCommand(BackupProject, CanBackupProject);
            Command1 = new RelayCommand(RunCommand1, CanRunCommand1);
        }


        #region Commands
        public ICommand DdsToCacheCommand { get; }
        public ICommand CreateCr2wFileCommand { get; }
        public ICommand BackupProjectCommand { get; }
        public ICommand Command1 { get; }
        #endregion

        #region CommandsImplementation
        private bool CanRunCommand1() => true;
        private void RunCommand1()
        {
        }

        private bool CanDdsToCacheCommand() => true;
        private void DdsToCache()
        {
            // Creation
            var txc = new TextureCache();
            txc.LoadFiles(((W3Mod)ActiveMod).RawModDirectory, MainController.Get().Logger);
            txc.Write(Path.Combine(ActiveMod.PackedModDirectory, "texture.cache"), MainController.Get().Logger);

            MainController.LogString($@"Finished creating texture.cache.", Logtype.Success);

            // Installing
            InstallMod();
        }

        private bool CanCreateCr2w(bool b) => MainController.Get().ActiveMod != null;
        private void CreateCr2w(bool b) => CreateCustomCr2wFile(b);

        private bool CanBackupProject() => MainController.Get().ActiveMod != null;

        private async void BackupProject()
        {
            // check if there is a mod project loaded
            if (ActiveMod == null)
            {
                MainController.LogString($"No mod project loaded.", Common.Services.Logtype.Error);
                return;
            }

            // check if git is in PATH
            var mpath = System.Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            var upath = System.Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            if (mpath == null && upath == null)
                return;

            if ((mpath != null && !mpath.Split(';').Any(_ => _.Contains("\\Git\\")))
                && ((upath != null && !upath.Split(';').Any(_ => _.Contains("\\Git\\")))))
            {
                MainController.LogString(
                    "Git was not found in your PATH environmental variables, it may not be installed on your machine. " +
                    "Please install git to use the backup feature for WolvenKit.", Logtype.Error);
            }

            // check if git version errors
            var trygetgit = await ProcessHelper.RunCommandLineAsync(Logger, "", "git --version");
            if (trygetgit != 0)
            {
                MainController.LogString($"Git is not installed, or is installed improperly. Aborting.", Common.Services.Logtype.Error);
                return;
            }

            MainController.Get().ProjectStatus = EProjectStatus.Busy;
            MainController.Get().StatusProgress = 0;
            MainController.LogString($"Backing up mod project. Please wait...", Common.Services.Logtype.Important);

            // create git repo - rerunning git init is safe
            //MainController.LogString($"Running git init command...", Logtype.Important);
            string templatedir = Path.Combine(AppContext.BaseDirectory, "Resources/GitTemplateDir");
            var resultInit = await GitHelper.InitRepository(Logger, ActiveMod.ProjectDirectory, templatedir, ActiveMod.Author, ActiveMod.Email);
            if (resultInit)
            {
                MainController.Get().StatusProgress = 25;
                //MainController.LogString($"Created git repository for project ({ActiveMod.Name}) at {ActiveMod.ProjectDirectory}.", Logtype.Success);
            }
            else
            {
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.Get().StatusProgress = 100;
                MainController.LogString($"Error creating git repository for project {ActiveMod.Name}.", Common.Services.Logtype.Error);
                return;
            }

            string sysFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("/", "-");
            string commitMessage = ActiveMod.Name + "_" + DateTime.Now.ToString(sysFormat + "_HH-mm-ss");
            string archiveName = commitMessage + ".zip";
            string archivePath = Path.Combine(ActiveMod.BackupDirectory, archiveName);


            // commit new files
            MainController.LogString($"Running git commit command...", Common.Services.Logtype.Important);
            var resultCommit = await GitHelper.Commit(Logger, ActiveMod.ProjectDirectory, commitMessage);
            if (resultCommit)
            {
                MainController.Get().StatusProgress = 50;
                MainController.LogString($"Successfully commited git repo for project {ActiveMod.Name}.",
                    Common.Services.Logtype.Success);
            }
            else
            {
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.Get().StatusProgress = 100;
                MainController.LogString($"Git repo failed to commit for project {ActiveMod.Name}.", Common.Services.Logtype.Error);
                return;
            }

            // git archive zip to ./_backups
            MainController.LogString($"Running git archive command...", Common.Services.Logtype.Important);
            var resultArchive = await GitHelper.Archive(Logger, ActiveMod.ProjectDirectory, archivePath);
            if (resultArchive)
            {
                MainController.Get().StatusProgress = 100;
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.LogString($"Successfully created git archive for project ({ActiveMod.Name}) at {archivePath}.", Common.Services.Logtype.Success);
            }
            else
            {
                MainController.Get().StatusProgress = 100;
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.LogString($"Error creating git archive for project {ActiveMod.Name}.", Common.Services.Logtype.Error);
                return;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Start Game with custom arguments
        /// </summary>
        /// <param name="args"></param>
        public static async void ExecuteGame(string args = "")
        {
            if (ActiveMod == null)
                return;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                Logger.LogString(@"Game is already running!", Logtype.Error);
                return;
            }
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.W3ExePath)
            {
                WorkingDirectory = Path.GetDirectoryName(config.W3ExePath),
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

        /// <summary>
        /// Start redirecting script log output from the game
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        private static async Task RedirectScriptlogOutput(Process process)
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


        
        private CR2WFile CreateCustomCr2wFile(bool isDlc)
        {
            // ask user for type
            List<string> availableTypes = CR2WManager.GetAvailableTypes("CResource").Select(_ => _.Name).ToList();
            if (availableTypes.Count <= 0) return null;
            // remove abstract classes

            availableTypes = availableTypes
                .Select(_ => $"{REDReflection.GetREDExtensionFromREDType(_)} ({_})")
                .Where(_ => _.Split(' ').First() != "")
                .ToList();

            string result = m_windowFactory.ShowAddChunkFormModal(availableTypes);

            var newChunktypename = result.Split(' ').Last().TrimStart("(").TrimEnd(')');
            var redextension = result.Split(' ').First();

            

            if (string.IsNullOrEmpty(redextension)) return null;

            // create cr2wfile
            var cr2w = new CR2WFile();
            var obj = CR2WTypeManager.Create(newChunktypename, newChunktypename, cr2w, null);
            if (!(obj is CResource resource)) return null;
            cr2w.FromCResource(resource);

            // write cr2wfile
            var initialDir = isDlc
                ? ActiveMod.DlcUncookedDirectory
                : ActiveMod.ModUncookedDirectory;

            if (string.IsNullOrEmpty(redextension)) return null;

            var filepath = Path.Combine(initialDir, $"{newChunktypename}.{redextension}");
            var newfilepath = m_windowFactory.ShowRenameForm(filepath);
            if (string.IsNullOrEmpty(newfilepath))
                return null;


            // create directory
            newfilepath.EnsureFolderExists();
            using (var fs = new FileStream(newfilepath, FileMode.Create, FileAccess.ReadWrite))
            using (var writer = new BinaryWriter(fs))
            {
                cr2w.Write(writer);
                MainController.LogString($"Succesfully created file {newfilepath}.", Common.Services.Logtype.Success);
            }

            return cr2w;
        }
        #endregion

        #region Mod
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
        private static void InstallMod()
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

                var packedmoddir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "Mods");
                if (Directory.Exists(packedmoddir))
                    fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, MainController.Get().Configuration.GameModDir, true));

                var packeddlcdir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "DLC");
                if (Directory.Exists(packeddlcdir))
                    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, MainController.Get().Configuration.GameDlcDir, true));
                
                
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
        /// 
        /// </summary>
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="install"></param>
        /// <returns></returns>
        public async Task<bool> PackAndInstallMod()
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
                MainController.Get().StatusProgress = 0;

                IsToolStripBtnPackEnabled = false;

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
                WccHelper.CleanupDirectories();

                // Create Virtial Links
                WccHelper.CreateVirtualLinks();

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
                                WccHelper.CreateFallBackSeedFile(seedfile);
                            }
                        }
                        else
                        {
                            Logger.LogString("No reddlc found, creating fallback seedfiles. \n", Logtype.Error);
                            WccHelper.CreateFallBackSeedFile(seedfile);
                        }
                    }
                }
                #endregion
                MainController.Get().StatusProgress = 5;

                //------------------------- COOKING -------------------------------------//
                #region Cooking
                int statusCook = -1;

                // cook uncooked files
                var taskCookCol = Task.Run(() => WccHelper.Cook());
                await taskCookCol.ContinueWith(antecedent =>
                {
                    //Logger.LogString($"Cooking Collision ended with status: {antecedent.Result}", Logtype.Important);
                    statusCook = antecedent.Result;
                });
                if (statusCook == 0)
                    Logger.LogString("Cooking collision finished with errors. \n", Logtype.Error);

                #endregion
                MainController.Get().StatusProgress = 15;

                //------------------------- POST COOKING --------------------------------//
                #region Copy Cooked Files
                // copy mod files from Archive (cooked files) to \cooked
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

                // copy dlc files from Archive (cooked files) to \cooked
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
                MainController.Get().StatusProgress = 20;

                //------------------------- PACKING -------------------------------------//
                #region Packing
                int statusPack = -1;

                //Handle bundle packing.
                if (packsettings.PackBundles.Item1 || packsettings.PackBundles.Item2)
                {
                    // packing
                    //if (statusCookCol * statusCookTex != 0)
                    {
                        var t = Task.Run(() => WccHelper.Pack(packsettings.PackBundles.Item1, packsettings.PackBundles.Item2));
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
                MainController.Get().StatusProgress = 40;

                //------------------------ METADATA -------------------------------------//
                #region Metadata
                //Handle metadata generation.
                int statusMetaData = -1;

                if (packsettings.GenMetadata.Item1 || packsettings.GenMetadata.Item2)
                {
                    if (statusPack == 1)
                    {
                        var t = Task.Run(() => WccHelper.CreateMetaData(packsettings.GenMetadata.Item1, packsettings.GenMetadata.Item2));
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
                MainController.Get().StatusProgress = 50;

                //------------------------ POST COOKING ---------------------------------//

                //---------------------------- CACHES -----------------------------------//
                #region Buildcache
                int statusCol = -1;
                int statusTex = -1;

                //Generate collision cache
                if (packsettings.GenCollCache.Item1 || packsettings.GenCollCache.Item2)
                {
                    var t = Task.Run(() => WccHelper.GenerateCache(EArchiveType.CollisionCache, packsettings.GenCollCache.Item1, packsettings.GenCollCache.Item2));
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
                    var t = Task.Run(() => WccHelper.GenerateCache(EArchiveType.TextureCache, packsettings.GenTexCache.Item1, packsettings.GenTexCache.Item2));
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
                        var soundmoddir = Path.Combine(ActiveMod.ModDirectory, EArchiveType.SoundCache.ToString());

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
                                        //TODO: Fix this somehow
                                        //var bytes = MainController.ImportFile(bnk.Path, MainController.Get().SoundManager);
                                        //File.WriteAllBytes(Path.Combine(soundmoddir, bnk.Path), bytes[0].ToArray());
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
                        var sounddlcdir = Path.Combine(ActiveMod.DlcDirectory, EArchiveType.SoundCache.ToString());

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
                MainController.Get().StatusProgress = 60;

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
                MainController.Get().StatusProgress = 80;

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
                MainController.Get().StatusProgress = 90;

                //---------------------------- FINALIZE ---------------------------------//


                //Install the mod
                if (!MainController.Get().Configuration.IsAutoInstallModsDisabled)
                    InstallMod();

                //Report that we are done
                MainController.Get().StatusProgress = 100;
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
        public void AddToMod(string relativePath, IGameArchiveManager manager, List<string> prioritizedBundles, bool addAsDLC,
            bool uncook = false, bool export = false)
        {
            string extension = Path.GetExtension(relativePath);
            string filename = Path.GetFileName(relativePath);


            // always uncook xbms, w2mesh, redcloth and redapex in Archive
            //if ((extension == ".xbm" /*|| Enum.GetNames(typeof(EExportable)).Contains(extension.TrimStart('.'))*/) && manager.TypeName == EBundleType.Archive)
            //    uncook = true;

            #region Check Existing Files in Working Dir
            // if uncooking check first if the file isn't already in the working depot or the r4depot
            if (uncook)
            {
                var cnewpath = "";
                // Working Depot
                var fi = new FileInfo(Path.Combine(Path.GetFullPath(MainController.WorkDir), relativePath));
                if (fi.Exists)
                {
                    // copy to uncooked folder in mod project
                    cnewpath = addAsDLC
                        ? Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath)
                        : Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);

                    fi.CopyToAndCreate(cnewpath, true);
                    Logger.LogString($"Added {filename} from depot.", Logtype.Success);

                    // Optionally Export 
                    if (export && File.Exists(cnewpath))
                    {
                        var task = Task.Run(() => WccHelper.ExportFileToMod(cnewpath));
                        Task.WaitAll(task);
                    }

                    return;
                }
            }
            #endregion

            // file is in no manager return, should never happen
            if (!(manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath))))
                return;

            // get archives with that file in them
            // <BundlePath, File>
            var files = manager.FileList
                .Where(x => x.Name == relativePath);
            var archives = new Dictionary<string, IGameFile>();
            foreach (var witcherFile in files)
            {
                string key = witcherFile.Archive.ArchiveAbsolutePath;
                if (!archives.ContainsKey(key))
                    archives.Add(key, witcherFile);
            }

            #region Get new Filename
            var bundletype = archives.First().Value.Archive.TypeName;
            var bundletypestr = bundletype.ToString();
            string newpath = "";
            switch (bundletype)
            {
                // extract files from bundle to Cooked
                case EArchiveType.Bundle:
                    {
                        newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                            ? Path.Combine("DLC", EProjectFolders.Cooked.ToString(), $"dlc{ActiveMod.Name}",
                                NormalizeDlcPath(relativePath))
                            : Path.Combine("Mod", EProjectFolders.Cooked.ToString(), relativePath));
                    }
                    break;
                // extract files from Collision and Texture caches to Raw (except for pngs etc)
                case EArchiveType.CollisionCache:
                case EArchiveType.TextureCache:
                    {
                        // add pngs, jpgs and dds directly to Uncooked
                        // (not Raw, since they don't get imported)
                        if (extension == ".png" || extension == ".jpg" || extension == ".dds")
                        {
                            newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                ? Path.Combine("DLC", EProjectFolders.Uncooked.ToString(), $"dlc{ActiveMod.Name}",
                                    NormalizeDlcPath(relativePath))
                                : Path.Combine("Mod", EProjectFolders.Uncooked.ToString(), relativePath));
                        }
                        // all other textures and collision stuff goes into Raw (since they have to be imported first)
                        else
                            newpath = Path.Combine(ActiveMod.RawDirectory, addAsDLC
                                ? Path.Combine("DLC", $"dlc{ActiveMod.Name}", NormalizeDlcPath(relativePath))
                                : Path.Combine("Mod", relativePath));
                    }
                    break;
                // some special cases
                case EArchiveType.SoundCache:
                case EArchiveType.Speech:
                case EArchiveType.Shader:
                    {
                        newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                            ? Path.Combine("DLC", bundletypestr,
                                $"dlc{ActiveMod.Name}", NormalizeDlcPath(relativePath))
                            : Path.Combine("Mod", bundletypestr, relativePath));
                    }
                    break;
                case EArchiveType.ANY:
                default:
                    throw new NotImplementedException();
            }
            #endregion

            // more than one archive
            if (archives.Count() > 1)
            {
                // check against saved priority bundles
                // if any of the prioritized bundles is in the archivesdict
                // we select the first??
                var priokeys = new List<string>();
                IGameFile selectedFile;
                foreach (var priokey in prioritizedBundles)
                {
                    if (archives.ContainsKey(priokey))
                        priokeys.Add(priokey);
                }

                if (priokeys.Count > 0)
                {
                    selectedFile = archives[priokeys.First()];
                }
                else
                {
                    var a = archives.Select(x => x.Value).ToList();
                    bool onlyusethisbundle;
                    (onlyusethisbundle, selectedFile) = m_windowFactory.ResolveExtractAmbigious(a);
                    if (selectedFile == null)
                        return;
                    if (onlyusethisbundle)
                    {
                        prioritizedBundles.Add(selectedFile.Archive.ArchiveAbsolutePath);
                    }
                }
                
                
                #region Uncooking
                if (uncook)
                {
                    var result = UncookInner(selectedFile);
                    if (result)
                        return;
                }
                #endregion

                #region Unbundling
                ExtractInner(selectedFile);
                #endregion
            }
            else
            {
                #region Uncooking
                if (uncook)
                {
                    var result = UncookInner(archives.FirstOrDefault().Value);
                    if (result)
                        return;
                }
                #endregion


                #region Unbundling
                ExtractInner(archives.FirstOrDefault().Value);
                #endregion
            }

            return;

            void ExtractInner(IGameFile file)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(newpath));
                if (File.Exists(newpath))
                {
                    File.Delete(newpath);
                }

                file.Extract(new BundleFileExtractArgs(newpath, MainController.Get().Configuration.UncookExtension));

                Logger.LogString($"Succesfully extracted {filename}.", Logtype.Success);
            }

            bool UncookInner(IGameFile file)
            {
                var basedir = Path.GetDirectoryName(file.Archive.ArchiveAbsolutePath);

                // copy to uncooked folder in mod project
                var uncookTask = Task.Run(() => WccHelper.UncookFileToPath(basedir, relativePath, addAsDLC));

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
                        var exportTask = Task.Run(() => WccHelper.ExportFileToMod(_newpath));
                        Task.WaitAll(exportTask);
                    }

                    return true;
                }
                else
                    Logger.LogString($"Could not uncook {filename}, trying to extract file instead of uncooking.", Logtype.Important);

                return false;
            }

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

        #region Documents
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
        
        public void AddOpenDocument(Old_IDocumentViewModel document)
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

        public void SaveActiveFile() => ActiveDocument?.SaveFile();
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
