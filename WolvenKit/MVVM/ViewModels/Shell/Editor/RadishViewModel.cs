using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    using Common.Services;
    using Functionality.Commands;
    using Radish.Model;
    using WolvenKit.Functionality.Controllers;

    public class RadishViewModel : ViewModel
    {
        public class FileWrapper
        {
            public FileWrapper(string path)
            {
                File = new FileInfo(path);
            }

            public FileInfo File { get; set; }
            public string Name => File.Name;

            public override string ToString()
            {
                return File.FullName;
            }
        }

        public RadishViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            Logger = MainController.Get().Logger;
            switch (RadishController.Get().CheckSelf())
            {
                case RadishController.ERadishStatus.SettingsError:
                    // load but functions are disabled
                    break;

                case RadishController.ERadishStatus.Healthy:
                    // check if different from settings file
                    RadishController.Get().UpdatdeSelf();
                    break;

                case RadishController.ERadishStatus.NoRadish:
                default:
                    // close the view
                    IsCorrupt = true;
                    return;
            }

            RadishController.Get().Configuration.PropertyChanged += ConfigurationUpdated;

            // load bats
            var batlist = Directory.GetFiles(RadishController.Get().Configuration.RadishProjectPath, "*.bat*", SearchOption.AllDirectories)
                .ToList();
            radishBats = new List<RadishBatFileWrapper>();
            foreach (var path in batlist)
            {
                var bat = new RadishBatFileWrapper(path);
                radishBats.Add(bat);
            }

            LaunchQuestEditorCommand = new RelayCommand(LaunchQuestEditor, CanLaunchQuestEditor);
            FullRebuildCommand = new RelayCommand(FullRebuild, CanFullRebuild);
            RunSelectedCommand = new RelayCommand(RunSelected, CanRunSelected);
            BuildUntilPackCommand = new RelayCommand(BuildUntilPack, CanBuildUntilPack);
            PackCommand = new RelayCommand(Pack, CanPack);
            ReCreateLinksCommand = new RelayCommand(ReCreateLinks, CanReCreateLinks);
            StartGameCommand = new RelayCommand(StartGame, CanStartGame);

            RecreateLinksInternal();

            #region Setup Workflows

            // initialize workflows
            if (!RadishController.GetConfig().Workflows.Any(_ => _.Name == "All"))
                RadishController.GetConfig().Workflows.Add(new RadishWorkflow("All")
                {
                    Cleanup_folder = true,

                    ENCODE_WORLD = true,
                    ENCODE_ENVS = true,
                    ENCODE_SCENES = true,
                    ENCODE_QUEST = true,
                    ENCODE_STRINGS = true,
                    ENCODE_SPEECH = true,
                    ENCODE_HAIRWORKS = true,

                    WCC_IMPORT_MODELS = true,
                    WCC_IMPORT_TEXTURES = true,
                    WCC_COOK = true,
                    WCC_NAVDATA = true,
                    WCC_TEXTURECACHE = true,
                    WCC_COLLISIONCACHE = true,
                    WCC_ANALYZE = true,
                    WCC_ANALYZE_WORLD = true,

                    WCC_REPACK_DLC = true,
                    WCC_REPACK_MOD = true,
                    DEPLOY_SCRIPTS = true,
                    DEPLOY_TMP_SCRIPTS = true,
                });
            if (!RadishController.GetConfig().Workflows.Any(_ => _.Name == "Rebuild until pack"))
                RadishController.GetConfig().Workflows.Add(new RadishWorkflow("Rebuild until pack")
                {
                    Cleanup_folder = true,

                    ENCODE_WORLD = true,
                    ENCODE_ENVS = true,
                    ENCODE_SCENES = true,
                    ENCODE_QUEST = true,
                    ENCODE_STRINGS = true,
                    ENCODE_SPEECH = true,
                    ENCODE_HAIRWORKS = true,

                    WCC_IMPORT_MODELS = true,
                    WCC_IMPORT_TEXTURES = true,
                });
            if (!RadishController.GetConfig().Workflows.Any(_ => _.Name == "Pack"))
                RadishController.GetConfig().Workflows.Add(new RadishWorkflow("Pack")
                {
                    WCC_REPACK_DLC = true,
                    WCC_REPACK_MOD = true,
                    DEPLOY_SCRIPTS = true,
                    DEPLOY_TMP_SCRIPTS = true,
                });

            #endregion Setup Workflows

            CurrentWorkflow = RadishController.Get().Configuration.Workflows.First();
        }

        #region Fields

        private readonly List<RadishBatFileWrapper> radishBats;
        private readonly LoggerService Logger;

        private const string settingsnotfoundmsg = "ERROR! _settings_.bat was not found!\r\n" +
            "1. rename _settings_.bat-template from project template to _settings_.bat\r\n" +
            "2. make sure _settings_.bat is in the root folder of the new project\r\n" +
            "3. adjust the paths in the _settings_.bat\r\n" +
            "4. run this script again";

        #endregion Fields

        #region Properties

        public bool IsCorrupt { get; private set; }

        #region SelectedItem

        private RadishWorkflow _currentWorkflow = null;

        public RadishWorkflow CurrentWorkflow
        {
            get => _currentWorkflow;
            set
            {
                if (_currentWorkflow != value)
                {
                    var oldValue = _currentWorkflow;
                    _currentWorkflow = value;
                    RaisePropertyChanged(() => CurrentWorkflow, oldValue, value);
                }
            }
        }

        #endregion SelectedItem

        #endregion Properties

        #region Commands

        public ICommand LaunchQuestEditorCommand { get; }
        public ICommand FullRebuildCommand { get; }
        public ICommand RunSelectedCommand { get; }
        public ICommand BuildUntilPackCommand { get; }
        public ICommand PackCommand { get; }
        public ICommand ReCreateLinksCommand { get; }
        public ICommand StartGameCommand { get; }

        #endregion Commands

        #region Commands Implementation

        protected bool CanLaunchQuestEditor() => RadishController.Get().IsHealthy();

        protected void LaunchQuestEditor() => TryRunRadishBat("launchQuestEditor.bat");

        protected bool CanFullRebuild() => RadishController.Get().IsHealthy();

        protected void FullRebuild() => TryRunRadishBat("full.rebuild.bat");

        protected bool CanRunSelected() => RadishController.Get().IsHealthy();

        protected void RunSelected()
        {
            // write and call temp bat file
            var settings = CurrentWorkflow;
            string tempbatpath = Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "wkit_radish_temp.bat");
            WriteRadishBat(tempbatpath, settings);
            RunRadishBat(new RadishBatFileWrapper(tempbatpath));
        }

        protected bool CanBuildUntilPack() => RadishController.Get().IsHealthy();

        protected void BuildUntilPack()
        {
            // write temp bat file
            var settings = RadishController.Get().Configuration.Workflows.First(_ => _.Name == "Rebuild until pack");
            string tempbatpath = Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "wkit_radish_temp.bat");
            WriteRadishBat(tempbatpath, settings);

            // call temp bat file
            RunRadishBat(new RadishBatFileWrapper(tempbatpath));
        }

        protected bool CanPack() => RadishController.Get().IsHealthy();

        protected void Pack()
        {
            // write temp bat file
            var settings = RadishController.Get().Configuration.Workflows.First(_ => _.Name == "Pack");
            string tempbatpath = Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "wkit_radish_temp.bat");
            WriteRadishBat(tempbatpath, settings);

            // call temp bat file
            RunRadishBat(new RadishBatFileWrapper(tempbatpath));
        }

        protected bool CanReCreateLinks() => RadishController.Get().IsHealthy();

        protected void ReCreateLinks() => RecreateLinksInternal();

        protected bool CanStartGame()
        {
            return RadishController.Get().IsHealthy() && (MainController.Get().ActiveMod != null) && (Process.GetProcessesByName("Witcher3").Length == 0);
        }

        protected async void StartGame()
        {
            // write and call temp bat file
            //var settings = new RadishWorkflow("_")
            //{
            //    START_GAME = true
            //};
            //string tempbatpath = Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "wkit_radish_temp.bat");
            //WriteRadishBat(tempbatpath, settings);
            //RunRadishBat(new RadishBatFileWrapper(tempbatpath));

            //"%DIR_W3%\bin\x64\"
            var gameexe = Path.Combine(RadishController.GetConfig().DIR_W3, "bin", "x64", "witcher3.exe");
            var proc = new ProcessStartInfo(gameexe)
            {
                WorkingDirectory = Path.GetDirectoryName(gameexe),
                Arguments = "-net -debugscripts",
                UseShellExecute = false,
                RedirectStandardOutput = true
            };

            MainController.LogString("Executing " + proc.FileName + " " + proc.Arguments + "\n", Logtype.Success);

            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            if (File.Exists(scriptlog))
                File.Delete(scriptlog);

            using (var process = Process.Start(proc))
            {
                //await RadishMonitorGame(process);
                await Task.Run(() => RadishMonitorGame(process));
            }
        }

        private bool oldstate = false;
        private string currentLoggedFile = "";

        private enum ERadishLogFilter
        {
            None,
            W2SCENE,
            W2LAYER,
            W2COMMUNITY,
            W3ENV,
            W3FOLIAGE,
            W3NAVMESH,
            W3FUR,
        }

        private async Task RadishMonitorGame(Process process)
        {
            oldstate = false;
            currentLoggedFile = "";

            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            using (var fs = new FileStream(scriptlog, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var fsr = new StreamReader(fs))
                {
                    while (!process.HasExited)
                    {
                        var result = await fsr.ReadToEndAsync();

                        MonitorOutput(result);
                    }
                }
                fs.Close();
            }

            void MonitorOutput(string val)
            {
                // get logtype
                (string text, ERadishLogFilter filter) = GetLogTypeFromString(val);
                // if any of the radish logtypes
                if (filter != ERadishLogFilter.None)
                {
                    // check if begin of file
                    currentLoggedFile += text;
                    MainController.LogString(text, Logtype.Normal);
                    oldstate = true;
                }
                else
                {
                    // file has ended
                    if (oldstate)
                        WriteFile(currentLoggedFile, ERadishLogFilter.W2LAYER);
                    oldstate = false;
                }
            }

            (string, ERadishLogFilter) GetLogTypeFromString(string str)
            {
                if (str.StartsWith("[W2LAYER] "))
                    return ($"{str.Replace("[W2LAYER] ", "")}\r\n", ERadishLogFilter.W2LAYER);
                else if (str.StartsWith("[W2COMMUNITY] "))
                    return ($"{str.Replace("[W2COMMUNITY] ", "")}\r\n", ERadishLogFilter.W2COMMUNITY);
                else if (str.StartsWith("[W2SCENE] "))
                    return ($"{str.Replace("[W2SCENE] ", "")}\r\n", ERadishLogFilter.W2SCENE);
                else if (str.StartsWith("[W3ENV] "))
                    return ($"{str.Replace("[W3ENV] ", "")}\r\n", ERadishLogFilter.W3ENV);
                else if (str.StartsWith("[W3FOLIAGE] "))
                    return ($"{str.Replace("[W3FOLIAGE] ", "")}\r\n", ERadishLogFilter.W3FOLIAGE);
                else if (str.StartsWith("[W3NAVMESH] "))
                    return ($"{str.Replace("[W3NAVMESH] ", "")}\r\n", ERadishLogFilter.W3NAVMESH);
                else if (str.StartsWith("[W3FUR] "))
                    return ($"{str.Replace("[W3FUR] ", "")}\r\n", ERadishLogFilter.W3FUR);
                else
                    return ("", ERadishLogFilter.None);
            }

            void WriteFile(string contents, ERadishLogFilter type)
            {
                var dt = DateTime.Now;
                string idx = RED.CRC32.Crc32Algorithm.Compute(Encoding.ASCII.GetBytes($"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}"))
                    .ToString();
                string filename = $"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}-{idx}";
                switch (type)
                {
                    case ERadishLogFilter.W2SCENE:
                        filename = $"scene.{filename}.yml";
                        break;

                    case ERadishLogFilter.W2LAYER:
                        filename = $"layers.{filename}.yml";
                        break;

                    case ERadishLogFilter.W2COMMUNITY:
                        filename = $"community.{filename}.yml";
                        break;

                    case ERadishLogFilter.W3ENV:
                        filename = $"env.{filename}.yml";
                        break;

                    case ERadishLogFilter.W3FOLIAGE:
                        filename = $"foliage.{filename}.yml";
                        break;

                    case ERadishLogFilter.W3NAVMESH:
                        filename = $"navmesh.{filename}.yml";
                        break;

                    case ERadishLogFilter.W3FUR:
                        filename = $"redfur.{filename}.yml";
                        break;

                    default:
                        break;
                }
                string path = Path.Combine(RadishController.Get().WkitLoggedFiles, filename);
                File.WriteAllText(path, contents);
                MainController.LogString($"Radish File logged {path}", Logtype.Success);
            }
        }

        #endregion Commands Implementation

        #region Methods

        private void ConfigurationUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "modname"
                || e.PropertyName == "idspace"
                || e.PropertyName == "DIR_ENCODER"
                || e.PropertyName == "DIR_MODKIT"
                || e.PropertyName == "DIR_W3"
                )
            {
                if (RadishController.Get().IsHealthy())
                {
                    // if the user updates the modname
                    // we have to recreate links
                    // and delete the old ones
                    if (e.PropertyName == "modname")
                    {
                        // delete old links
                        //"%DIR_MODKIT_DEPOT%\\dlc\\dlc%MODNAME%\"
                        var olddlclink = Path.Combine(RadishController.GetConfig().DIR_MODKIT, "dlc", $"dlc{RadishController.GetConfig().GetOldModname()}");
                        if (Directory.Exists(olddlclink))
                            Directory.Delete(olddlclink);

                        //"%DIR_MODKIT_DEPOT%\\scripts\\dlc%MODNAME%\"
                        var oldscriptslink = Path.Combine(RadishController.GetConfig().DIR_MODKIT, "scripts", $"dlc{RadishController.GetConfig().GetOldModname()}");
                        if (Directory.Exists(oldscriptslink))
                            Directory.Delete(oldscriptslink);

                        // create new links
                        RecreateLinksInternal();
                    }

                    // edit settings.bat
                    RadishController.Get().UpdateSettingsBat();
                }
            }
        }

        private void TryRunRadishBat(string name)
        {
            try
            {
                RunRadishBat(radishBats.First(_ => _.Name == name));
            }
            catch (Exception)
            {
                Logger.LogString($"Bat file not found: {name}", Logtype.Error);
            }
        }

        private void RunRadishBat(RadishBatFileWrapper bat)
        {
            if (bat == null)
                Logger.LogString($"Bat file not found: {bat.Name}", Logtype.Error);

            string path = bat.Path;

            if (bat.Interactive)
            {
                using (Process p = new Process())
                {
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.FileName = path;
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);

                    p.Start();
                }
            }
            else
            {
                using (Process p = new Process())
                {
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;

                    p.StartInfo.FileName = path;
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);

                    p.OutputDataReceived += new DataReceivedEventHandler((s, ev) =>
                    {
                        if (ev.Data != null)
                        {
                            if (ev.Data.StartsWith("WARN"))
                                Logger.LogString(ev.Data, Logtype.Important);
                            else if (ev.Data.StartsWith("ERROR"))
                                Logger.LogString(ev.Data, Logtype.Error);
                            else if (ev.Data.StartsWith("INFO"))
                                Logger.LogString(ev.Data, Logtype.Normal);
                            else
                                Logger.LogString(ev.Data);
                        }
                    });
                    p.ErrorDataReceived += new DataReceivedEventHandler((s, ev) =>
                    {
                        Logger.LogString(ev.Data, Logtype.Error);
                    });

                    p.Start();
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();
                }
            }
        }

        private void RecreateLinksInternal()
        {
            // write and call temp bat file

            #region create new links

            string tempbatpath = Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "wkit_radish_temp.bat");
            WriteLinksBat(tempbatpath);
            RunRadishBat(new RadishBatFileWrapper(tempbatpath));

            #endregion create new links
        }

        private void WriteRadishBat(string tempbatpath, RadishWorkflow radishsettings)
        {
            //gather dependencies
            if (!radishsettings.PATCH_MODE)
                SetDependencies(radishsettings);

            if (File.Exists(tempbatpath))
                File.Delete(tempbatpath);

            using (var fs = new FileStream(tempbatpath, FileMode.Create, FileAccess.Write))
            using (var sr = new StreamWriter(fs, Encoding.Default))
            {
                string header =
                        "@echo off\r\n" +
                        "call _settings_.bat\r\n" +
                        "SET INTERACTIVE_BUILD = 0\r\n" +
                        "SET PATCH_MODE = 1\r\n" +
                        "SET FULL_REBUILD = 0\r\n";
                sr.Write(header);

                if (radishsettings.ENCODE_WORLD)
                    sr.WriteLine($"SET ENCODE_WORLD=1");
                if (radishsettings.ENCODE_ENVS)
                    sr.WriteLine($"SET ENCODE_ENVS=1");
                if (radishsettings.ENCODE_SCENES)
                    sr.WriteLine($"SET ENCODE_SCENES=1");
                if (radishsettings.ENCODE_QUEST)
                    sr.WriteLine($"SET ENCODE_QUEST=1");
                if (radishsettings.ENCODE_STRINGS)
                    sr.WriteLine($"SET ENCODE_STRINGS=1");
                if (radishsettings.ENCODE_SPEECH)
                    sr.WriteLine($"SET ENCODE_SPEECH=1");
                if (radishsettings.ENCODE_HAIRWORKS)
                    sr.WriteLine($"SET ENCODE_HAIRWORKS=1");

                if (radishsettings.WCC_IMPORT_MODELS)
                    sr.WriteLine($"SET WCC_IMPORT_MODELS=1");
                if (radishsettings.WCC_IMPORT_TEXTURES)
                    sr.WriteLine($"SET WCC_IMPORT_TEXTURES=1");
                if (radishsettings.WCC_COOK)
                    sr.WriteLine($"SET WCC_COOK=1");
                if (radishsettings.WCC_NAVDATA)
                    sr.WriteLine($"SET WCC_NAVDATA=1");
                if (radishsettings.WCC_TEXTURECACHE)
                    sr.WriteLine($"SET WCC_TEXTURECACHE=1");
                if (radishsettings.WCC_COLLISIONCACHE)
                    sr.WriteLine($"SET WCC_COLLISIONCACHE=1");

                if (radishsettings.WCC_ANALYZE)
                    sr.WriteLine($"SET WCC_ANALYZE=1");
                if (radishsettings.WCC_ANALYZE_WORLD)
                    sr.WriteLine($"SET WCC_ANALYZE_WORLD=1");

                if (radishsettings.WCC_REPACK_DLC)
                    sr.WriteLine($"SET WCC_REPACK_DLC=1");
                if (radishsettings.WCC_REPACK_MOD)
                    sr.WriteLine($"SET WCC_REPACK_MOD=1");

                if (radishsettings.DEPLOY_SCRIPTS)
                    sr.WriteLine($"SET DEPLOY_SCRIPTS=1");
                if (radishsettings.DEPLOY_TMP_SCRIPTS)
                    sr.WriteLine($"SET DEPLOY_TMP_SCRIPTS=1");
                if (radishsettings.START_GAME)
                    sr.WriteLine($"SET START_GAME=1");

                // hack to call pre-cleanup because build.bat makes this dependent on full-rebuild = true
                // and we do it in patch mode
                if (radishsettings.Cleanup_folder)
                {
                    sr.WriteLine("CALL \"%DIR_PROJECT_BIN%\\_cleanup.folder.bat\"");
                    sr.WriteLine("IF %ERRORLEVEL% NEQ 0 GOTO SomeError");
                }

                sr.WriteLine("call \"%DIR_PROJECT_BIN%\\build.bat\"");
            }

            void SetDependencies(RadishWorkflow settings)
            {
                if (settings.ENCODE_HAIRWORKS)
                {
                    var di = new DirectoryInfo(Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "definition.hairworks"));
                    if (di.GetFiles("fur.*.apx", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.ENCODE_QUEST)
                {
                    var di = new DirectoryInfo(Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "uncooked"));
                    if (di.GetFiles("*.w2quest", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.ENCODE_STRINGS = true;
                        settings.WCC_ANALYZE = true;
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.ENCODE_SCENES)
                {
                    var di = new DirectoryInfo(Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "definition.scenes"));
                    if (di.GetFiles("scene.*.yml", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.ENCODE_STRINGS = true;
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.WCC_IMPORT_MODELS)
                {
                    var di = new DirectoryInfo(Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "definition.world"));
                    if (di.GetFiles("world.*.yml", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_NAVDATA = true;
                    }
                    di = new DirectoryInfo(Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "models"));
                    if (di.GetFiles("model.*.fbx", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_ANALYZE = true;
                        settings.WCC_COLLISIONCACHE = true;
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.ENCODE_WORLD)
                {
                    var di = new DirectoryInfo(Path.Combine(RadishController.Get().Configuration.RadishProjectPath, "definition.world"));
                    if (di.GetFiles("world.*.yml", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_ANALYZE = true;
                        settings.WCC_ANALYZE_WORLD = true;
                        settings.WCC_COOK = true;
                        settings.WCC_NAVDATA = true;
                        settings.WCC_TEXTURECACHE = true;
                        settings.WCC_COLLISIONCACHE = true;
                        settings.WCC_COOK = true;
                    }
                }
            }
        }

        private void WriteLinksBat(string tempbatpath)
        {
            if (File.Exists(tempbatpath))
                File.Delete(tempbatpath);

            using (var fs = new FileStream(tempbatpath, FileMode.Create, FileAccess.Write))
            using (var sr = new StreamWriter(fs, Encoding.Default))
            {
                string header =
                        "@echo off\r\n" +
                        "call _settings_.bat\r\n";
                sr.Write(header);

                //delete old links
                sr.WriteLine("rd /s /q \"%DIR_MODKIT_DEPOT%\\dlc\\dlc%MODNAME%\"");
                sr.WriteLine("rd /s /q \"%DIR_MODKIT_DEPOT%\\scripts\\dlc%MODNAME%\"");
                sr.WriteLine("echo old links successfully deleted.");

                // relink
                sr.WriteLine("mklink / J \"%DIR_MODKIT_DEPOT%\\dlc\\dlc%MODNAME%\" \"%DIR_UNCOOKED%\\dlc\\dlc%MODNAME%\"");
                sr.WriteLine("echo.");

                sr.WriteLine("mklink / J \"%DIR_MODKIT_DEPOT%\\scripts\\dlc%MODNAME%\" \"%DIR_MOD_SCRIPTS%\"");
                sr.WriteLine("echo.");

                sr.WriteLine("echo links successfully created.");
            }
        }

        #endregion Methods
    }
}
