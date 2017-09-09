using System.IO;
using System.Windows.Forms;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;
using WolvenKit.W3Strings;
using WolvenKit.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WolvenKit
{
    public class MainController : IVariableEditor, ILocalizedStringSource, INotifyPropertyChanged
    {
        private static MainController mainController;

        public event PropertyChangedEventHandler PropertyChanged;

        private string projectstatus = "Idle";
        public string ProjectStatus
        {
            get { return projectstatus; }
            set { SetField(ref projectstatus, value, "ProjectStatus"); }
        }

        /// <summary>
        /// Shows wheteher there are unsaved changes in the project.
        /// </summary>
        public bool ProjectUnsaved = false;

        private MainController()
        {
        }

#region Archive Managers
        private SoundManager soundManager;
        private SoundManager modsoundmanager;
        private BundleManager bundleManager;
        private BundleManager modbundleManager;
        private TextureManager textureManager;
        private TextureManager modTextureManager;
        private W3StringManager w3StringManager;

        public W3StringManager W3StringManager
        {
            get
            {
                if (w3StringManager == null)
                {
                    try
                    {
                        if (File.Exists("string_cache.json"))
                        {
                            using (StreamReader file = File.OpenText(@"string_cache.json"))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                                serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                                serializer.TypeNameHandling = TypeNameHandling.Auto;
                                w3StringManager = (W3StringManager)serializer.Deserialize(file, typeof(W3StringManager));
                            }
                        }
                        else
                        {
                            w3StringManager = new W3StringManager();
                            w3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                            File.WriteAllText("string_cache.json", JsonConvert.SerializeObject(W3StringManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists("string_cache.json"))
                            File.Delete("string_cache.json");
                        w3StringManager = new W3StringManager();
                        w3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }

                return w3StringManager;
            }
        }

        public BundleManager BundleManager
        {
            get
            {
                if (bundleManager == null)
                {
                    try
                    {
                        if (File.Exists("bundle_cache.json"))
                        {
                            using (StreamReader file = File.OpenText(@"bundle_cache.json"))
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
                            File.WriteAllText("bundle_cache.json", JsonConvert.SerializeObject(bundleManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists("bundle_cache.json"))
                            File.Delete("bundle_cache.json");
                        bundleManager = new BundleManager();
                        bundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                return bundleManager;
            }
        }

        public BundleManager ModBundleManager
        {
            get
            {
                if (modbundleManager == null)
                {
                    modbundleManager = new BundleManager();
                    modbundleManager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                return modbundleManager;
            }
        }

        public SoundManager SoundManager
        {
            get
            {
                if (soundManager == null)
                {
                    try
                    {
                        if (File.Exists("sound_cache.json"))
                        {
                            using (StreamReader file = File.OpenText(@"sound_cache.json"))
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
                            File.WriteAllText("sound_cache.json", JsonConvert.SerializeObject(soundManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists("sound_cache.json"))
                            File.Delete("sound_cache.json");
                        soundManager = new SoundManager();
                        soundManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                return soundManager;
            }
        }

        public SoundManager ModSoundManager
        {
            get
            {
                if (modsoundmanager == null)
                {
                    modsoundmanager = new SoundManager();
                    modsoundmanager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                return modsoundmanager;
            }
        }

        public TextureManager TextureManager
        {
            get
            {
                if (textureManager == null)
                {
                    try
                    {
                        if (File.Exists("texture_cache.json"))
                        {
                            using (StreamReader file = File.OpenText(@"texture_cache.json"))
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
                            File.WriteAllText("texture_cache.json", JsonConvert.SerializeObject(textureManager, Formatting.None, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                                TypeNameHandling = TypeNameHandling.Auto
                            }));
                        }
                    }
                    catch (System.Exception)
                    {
                        if (File.Exists("texture_cache.json"))
                            File.Delete("texture_cache.json");
                        textureManager = new TextureManager();
                        textureManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                    }
                }
                return textureManager;
            }
        }

        public TextureManager ModTextureManager
        {
            get
            {
                if (modTextureManager == null)
                {
                    modTextureManager = new TextureManager();
                    modTextureManager.LoadModsBundles(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                return modTextureManager;
            }
        }
#endregion

        public Configuration Configuration { get; private set; }
        public frmMain Window { get; private set; }

        /// <summary>
        /// Usefull function for blindly importing a file.
        /// </summary>
        /// <param name="name">The name of the file.</param>
        /// <param name="archive">The manager to search for the file in.</param>
        /// <returns></returns>
        public List<byte[]> ImportFile(string name,IWitcherArchive archive)
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

        public string GetLocalizedString(uint val)
        {
            return W3StringManager.GetString(val);
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
                mainController.Initialize();
            }

            return mainController;
        }

        public void Initialize()
        {
            Configuration = Configuration.Load();
            Window = new frmMain();
            ReloadStringManager();
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

            dlg.Filter = string.Join("|", ImportExportUtility.GetPossibleExtensions(bytes));
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