using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace WolvenKit
{
    using Bundles;
    using Cache;
    using CR2W;
    using CR2W.Editors;
    using CR2W.Types;
    using W3Strings;
    using Common;
    using Common.Services;
    using WolvenKit.Common.Wcc;
    using Render;
    using System.Security.RightsManagement;

    public enum EColorThemes
    {
        VS2015Light = 0,
        VS2015Dark = 1,
        VS2015Blue = 2,
    }

    public class MainController : IVariableEditor, ILocalizedStringSource, INotifyPropertyChanged
    {
        private static MainController mainController;
        public Configuration Configuration { get; private set; }
        public frmMain Window { get; private set; }
        public W3Mod ActiveMod { get; set; }

        public WccHelper WccHelper { get; set; }
        public LoggerService Logger { get; set; }

        public const string ManagerCacheDir = "ManagerCache";
        public string VLCLibDir = "C:\\Program Files\\VideoLAN\\VLC";
        public string InitialModProject = "";
        public string InitialWKP = "";

        // Color Themes
        public VisualStudioToolStripExtender ToolStripExtender { get; set; }
        private readonly List<ThemeBase> _themesList = new List<ThemeBase>() { new VS2015LightTheme(), new VS2015DarkTheme(), new VS2015BlueTheme() };
        public ThemeBase GetTheme() => _themesList[(int)Configuration.ColorTheme];
       
        public event PropertyChangedEventHandler PropertyChanged;

        private string _projectstatus = "Idle";
        public string ProjectStatus
        {
            get => _projectstatus;
            set => SetField(ref _projectstatus, value, nameof(ProjectStatus));
        }

        private string _loadstatus = "Loading...";
        public string loadStatus
        {
            get => _loadstatus;
            set => SetField(ref _loadstatus, value, nameof(loadStatus));
        }

        private bool _loaded = false;
        public bool Loaded
        {
            get => _loaded;
            set => SetField(ref _loaded, value, nameof(Loaded));
        }


        private KeyValuePair<string,Logtype> _logMessage = new KeyValuePair<string, Logtype>("",Logtype.Normal);
        public KeyValuePair<string, Logtype> LogMessage
        {
            get => _logMessage;
            set => SetField(ref _logMessage, value, nameof(LogMessage));
        }

        /// <summary>
        /// Shows wheteher there are unsaved changes in the project.
        /// </summary>
        public bool ProjectUnsaved = false;

        private MainController()  {  }

        #region Archive Managers
        private SoundManager soundManager;
        private SoundManager modsoundmanager;
        private BundleManager bundleManager;
        private BundleManager modbundleManager;
        private TextureManager textureManager;
        private CollisionManager collisionManager;
        private TextureManager modTextureManager;
        private W3StringManager w3StringManager;

        //Public getters
        public W3StringManager W3StringManager => w3StringManager;

      

        public BundleManager BundleManager => bundleManager;
        public BundleManager ModBundleManager => modbundleManager;
        public SoundManager SoundManager => soundManager;
        public SoundManager ModSoundManager => modsoundmanager;
        public TextureManager TextureManager => textureManager;
        public TextureManager ModTextureManager => modTextureManager;
        public CollisionManager CollisionManager => collisionManager;

        #endregion

        /// <summary>
        /// Useful function for blindly importing a file.
        /// </summary>
        /// <param name="name">The name of the file.</param>
        /// <param name="archive">The manager to search for the file in.</param>
        /// <returns></returns>
        public static List<byte[]> ImportFile(string name,IWitcherArchive archive)
        {
            List<byte[]> ret = new List<byte[]>();
            archive.FileList.ToList().Where(x => x.Name.Contains(name)).ToList().ForEach(x =>
            {
                using (var ms = new MemoryStream())
                {
                    x.Extract(ms);
                    ret.Add(ms.ToArray());
                }
            });
            return ret;
        }

        /// <summary>
        /// Here we setup stuff we need in every form. Borders etc can be done here in the future.
        /// </summary>
        /// <param name="form">The form to initialize.</param>
        public static void InitForm(Form form)
        {
            Bitmap bmp = WolvenKit.Properties.Resources.Logo_wkit;
            form.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        /// <summary>
        /// Queues a string for logging in the main window.
        /// </summary>
        /// <param name="msg">The message to log.</param>
        /// <param name="type">The type of the log. Not needed.</param>
        public void QueueLog(string msg, Logtype type = Logtype.Normal)
        {
            LogMessage = new KeyValuePair<string, Logtype>(msg, type);
        }

        public string GetLocalizedString(uint val)
        {
            return W3StringManager.GetString(val);
        }

        internal void UpdateWccHelper(string wccLite)
        {
            WccHelper.UpdatePath(wccLite);
        }

        public void CreateVariableEditor(CVariable editvar, EVariableEditorAction action)
        {
            switch (action)
            {
                case EVariableEditorAction.Export:
                    ExportBytes(editvar);
                    break;
                case EVariableEditorAction.Import:
                    ImportBytes(editvar);
                    break;
                case EVariableEditorAction.Open:
                    OpenEditorFor(editvar);
                    break;
            }
        }

        public static MainController Get()
        {
            if (mainController == null)
            {
                mainController = new MainController();
                mainController.Configuration = Configuration.Load();
                mainController.Window = new frmMain();
            }
            return mainController;
        }

        /// <summary>
        /// Initializes the archive managers in an async thread
        /// </summary>
        /// <returns></returns>
        public async Task Initialize()
        {
            try
            {
                loadStatus = "Loading string manager";
                #region Load string manager
                var sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                if (w3StringManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "string_cache.bin")) && new FileInfo(Path.Combine(ManagerCacheDir, "string_cache.bin")).Length > 0)
                        {
                            using (var file = File.Open(Path.Combine(ManagerCacheDir, "string_cache.bin"),FileMode.Open))
                            {
                                w3StringManager = ProtoBuf.Serializer.Deserialize<W3StringManager>(file);
                            }
                        }
                        else
                        {
                            w3StringManager = new W3StringManager();
                            w3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                            Directory.CreateDirectory(ManagerCacheDir);
                            using (var file = File.Open(Path.Combine(ManagerCacheDir, "string_cache.bin"),FileMode.Create))
                            {
                                ProtoBuf.Serializer.Serialize(file,w3StringManager);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "string_cache.bin")))
                            File.Delete(Path.Combine(ManagerCacheDir, "string_cache.bin"));
                        w3StringManager = new W3StringManager();
                        w3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }

                var i = sw.ElapsedMilliseconds;
                sw.Stop();
                #endregion

                loadStatus = "Loading bundle manager!";
                #region Load bundle manager
                if (bundleManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "bundle_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "bundle_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                bundleManager = (BundleManager)serializer.Deserialize(file, typeof(BundleManager));
                            }
                        }
                        else
                        {
                            bundleManager = new BundleManager();
                            bundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "bundle_cache.json"), JsonConvert.SerializeObject(bundleManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "bundle_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "bundle_cache.json"));
                        bundleManager = new BundleManager();
                        bundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion
                loadStatus = "Loading mod bundle manager!";
                #region Load mod bundle manager
                if (modbundleManager == null)
                {
                    modbundleManager = new BundleManager();
                    modbundleManager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                #endregion

                loadStatus = "Loading texture manager!";
                #region Load texture manager
                if (textureManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "texture_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "texture_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                textureManager = (TextureManager)serializer.Deserialize(file, typeof(TextureManager));
                            }
                        }
                        else
                        {
                            textureManager = new TextureManager();
                            textureManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "texture_cache.json"), JsonConvert.SerializeObject(textureManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "texture_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "texture_cache.json"));
                        textureManager = new TextureManager();
                        textureManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion

                loadStatus = "Loading collision manager!";
                #region Load collision manager
                if (collisionManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "collision_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "collision_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                collisionManager = (CollisionManager)serializer.Deserialize(file, typeof(CollisionManager));
                            }
                        }
                        else
                        {
                            collisionManager = new CollisionManager();
                            collisionManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "collision_cache.json"), JsonConvert.SerializeObject(collisionManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "collision_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "collision_cache.json"));
                        collisionManager = new CollisionManager();
                        collisionManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion

                loadStatus = "Loading mod texure manager!";
                #region Load mod texture manager
                if (modTextureManager == null)
                {
                    modTextureManager = new TextureManager();
                    modTextureManager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                #endregion

                loadStatus = "Loading sound manager!";
                #region Load sound manager
                if (soundManager == null)
                {
                    try
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "sound_cache.json")))
                        {
                            using (StreamReader file = File.OpenText(Path.Combine(ManagerCacheDir, "sound_cache.json")))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                soundManager = (SoundManager)serializer.Deserialize(file, typeof(SoundManager));
                            }
                        }
                        else
                        {
                            soundManager = new SoundManager();
                            soundManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText(Path.Combine(ManagerCacheDir, "sound_cache.json"), JsonConvert.SerializeObject(soundManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists(Path.Combine(ManagerCacheDir, "sound_cache.json")))
                            File.Delete(Path.Combine(ManagerCacheDir, "sound_cache.json"));
                        soundManager = new SoundManager();
                        soundManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                #endregion
                loadStatus = "Loading mod sound manager!";
                #region Load mod sound manager
                if (modsoundmanager == null)
                {
                    modsoundmanager = new SoundManager();
                    modsoundmanager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                #endregion
                loadStatus = "Loaded";

                Logger = new LoggerService();
                WccHelper = new WccHelper(MainController.Get().Configuration.WccLite, Logger);

                mainController.Loaded = true;
            }
            catch (Exception e)
            {
                mainController.Loaded = false;
                System.Console.WriteLine(e.Message);
            }
        }

        public frmCR2WDocument LoadDocument(string filename, bool suppressErrors = false)
        {
            return Window.LoadDocument(filename, null, suppressErrors);
        }

        public frmCR2WDocument LoadDocument(string filename, MemoryStream memoryStream, bool suppressErrors = false)
        {
            return Window.LoadDocument(filename, memoryStream, suppressErrors);
        }

        public void ReloadStringManager()
        {
            W3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath), true);
        }

        private void ImportBytes(CVariable editvar)
        {
            var dlg = new OpenFileDialog() { InitialDirectory = Get().Configuration.InitialExportDirectory };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

                using (var fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(fs))
                    {
                        var bytes = ImportExportUtility.GetImportBytes(reader);
                        editvar.SetValue(bytes);
                    }
                }
            }
        }

        private void ExportBytes(CVariable editvar)
        {
            var dlg = new SaveFileDialog();
            byte[] bytes = null;

            if (editvar is IByteSource)
            {
                bytes = ((IByteSource) editvar).Bytes;
            }

            dlg.Filter = string.Join("|", ImportExportUtility.GetPossibleExtensions(bytes, editvar.Name));
            dlg.InitialDirectory = Get().Configuration.InitialExportDirectory;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

                using (var fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    using (var writer = new BinaryWriter(fs))
                    {
                        bytes = ImportExportUtility.GetExportBytes(bytes, Path.GetExtension(dlg.FileName));
                        writer.Write(bytes);
                    }
                }
            }
        }

        private void OpenHexEditorFor(CVariable editvar)
        {
            var editor = new frmHexEditorView() { File = editvar.cr2w };

            if (editvar is IByteSource)
            {
                editor.Bytes = ((IByteSource) editvar).Bytes;
            }

            editor.Text = "Hex Viewer [" + editvar.FullName + "]";
            editor.Show();
        }

        private void OpenEditorFor(CVariable editvar)
        {
            byte[] bytes = null;

            if (editvar is IByteSource)
            {
                bytes = ((IByteSource) editvar).Bytes;
            }

            if (bytes != null)
            {
                var doc = LoadDocument(editvar.cr2w.FileName + ":" + editvar.FullName, new MemoryStream(bytes), true);
                if (doc != null)
                {
                    doc.OnFileSaved += OnVariableEditorSave;
                    doc.SaveTarget = editvar;
                }
                else
                {
                    OpenHexEditorFor(editvar);
                }
            }
        }

        private void OnVariableEditorSave(object sender, FileSavedEventArgs args)
        {
            if (args.Stream is MemoryStream)
            {
                var doc = (frmCR2WDocument) sender;
                var editvar = (CVariable) doc.SaveTarget;
                editvar.SetValue(((MemoryStream) args.Stream).ToArray());
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}