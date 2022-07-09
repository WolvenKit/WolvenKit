using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DynamicData.Kernel;
using Prism.Commands;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Documents
{
    public enum ERedDocumentItemType
    {
        MainFile,
        W2rcBuffer,
        Buffer,
        Editor
    }

    public class RedDocumentViewModel : DocumentViewModel
    {
        protected readonly ILoggerService _loggerService;
        protected readonly Red4ParserService _parser;
        protected readonly IHashService _hashService;
        protected readonly IProjectManager _projectManager;
        public CR2WFile Cr2wFile;

        public RedDocumentViewModel(string path) : base(path)
        {
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _parser = Locator.Current.GetService<Red4ParserService>();
            _hashService = Locator.Current.GetService<IHashService>();
            _projectManager = Locator.Current.GetService<IProjectManager>();
            if (_projectManager.ActiveProject != null)
            {
                // assume files that don't exist are relative paths
                if (File.Exists(path))
                {
                    RelativePath = Path.GetRelativePath(_projectManager.ActiveProject.ModDirectory, path);
                }
                else
                {
                    RelativePath = path;
                }
            }

            Extension = Path.GetExtension(path) != "" ? Path.GetExtension(path)[1..] : "";
            NewEmbeddedFileCommand = new DelegateCommand(ExecuteNewEmbeddedFile);
        }

        #region properties

        [Reactive] public ObservableCollection<RedDocumentTabViewModel> TabItemViewModels { get; set; } = new();

        [Reactive] public int SelectedIndex { get; set; }

        [Reactive] public RedDocumentTabViewModel SelectedTabItemViewModel { get; set; }

        [Reactive] public string RelativePath { get; set; }

        [Reactive] public string Extension { get; set; }

        #endregion


        #region methods

        public override Task OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            var file = GetMainFile();
            if (file.HasValue)
            {
                var resource = Cr2wFile;
                if (resource is CR2WFile cr2w)
                {
                    using var writer = new CR2WWriter(fs);
                    writer.WriteFile(cr2w);

                    SetIsDirty(false);
                    _loggerService.Success($"Saved file {FilePath}");
                }
            }

            return Task.CompletedTask;
        }

        public bool OpenStream(Stream stream, string path)
        {
            using var reader = new BinaryReader(stream);

            if (!_parser.TryReadRed4File(reader, out Cr2wFile))
            {
                _loggerService.Error($"Failed to read cr2w file {path}");
                return false;
            }
            //cr2w.FileName = path;

            // already set by base()?
            //ContentId = path;
            FilePath = path;
            _isInitialized = true;

            PopulateItems();
            return true;
        }

        public override bool OpenFile(string path)
        {
            _isInitialized = false;

            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    OpenStream(stream, path);
                }

                return true;
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                // Not processing this catch in any other way than rejecting to initialize this
                _isInitialized = false;
            }

            return false;
        }

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            try
            {
                await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    OpenStream(stream, path);
                }

                return true;
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                // Not processing this catch in any other way than rejecting to initialize this
                _isInitialized = false;
            }

            return false;
        }

        public Optional<RDTDataViewModel> GetMainFile() => Optional<RDTDataViewModel>.ToOptional(TabItemViewModels
            .OfType<RDTDataViewModel>()
            .Where(x => x.DocumentItemType == ERedDocumentItemType.MainFile)
            .FirstOrDefault());

        protected void AddTabForRedType(RedBaseClass cls)
        {
            if (cls is CBitmapTexture xbm)
            {
                TabItemViewModels.Add(new RDTTextureViewModel(xbm, this));
            }
            if (cls is CMesh mesh && mesh.RenderResourceBlob != null && mesh.RenderResourceBlob.GetValue() is rendRenderTextureBlobPC)
            {
                TabItemViewModels.Add(new RDTTextureViewModel(mesh, this));
            }
            if (cls is CReflectionProbeDataResource probe && probe.TextureData.RenderResourceBlobPC.GetValue() is rendRenderTextureBlobPC)
            {
                TabItemViewModels.Add(new RDTTextureViewModel(probe, this));
            }
            if (cls is Multilayer_Mask mlmask)
            {
                // maybe it makes more sense to put these all into one tab?
                ModTools.ConvertMultilayerMaskToDdsStreams(mlmask, out var streams);
                for (var i = 0; i < streams.Count; i++)
                {
                    var tab = new RDTTextureViewModel(streams[i], this)
                    {
                        Header = $"MultiLayer {i}"
                    };
                    TabItemViewModels.Add(tab);
                }
            }
            if (cls is inkTextureAtlas atlas)
            {
                var file = GetFileFromDepotPath(atlas.Slots[0].Texture.DepotPath);
                if (file != null)
                {
                    TabItemViewModels.Add(new RDTInkTextureAtlasViewModel(atlas, (CBitmapTexture)file.RootChunk, this));
                }
            }
            if (cls is inkWidgetLibraryResource library)
            {
                TabItemViewModels.Add(new RDTWidgetViewModel(library, this));
            }
            if (cls is CMesh mesh2)
            {
                TabItemViewModels.Add(new RDTMeshViewModel(mesh2, this));
            }
            if (cls is entEntityTemplate ent)
            {
                TabItemViewModels.Add(new RDTMeshViewModel(ent, this));
            }
            if (cls is worldStreamingSector wss)
            {
                TabItemViewModels.Add(new RDTMeshViewModel(wss, this));
            }
            if (cls is worldStreamingBlock wsb)
            {
                TabItemViewModels.Add(new RDTMeshViewModel(wsb, this));
            }
            if (cls is graphGraphResource ggr)
            {
                TabItemViewModels.Add(new RDTGraphViewModel(ggr, this));
            }
            if (cls is scnSceneResource ssr)
            {
                TabItemViewModels.Add(new RDTGraphViewModel(ssr, this));
            }
        }

        private void PopulateItems()
        {
            var root = new RDTDataViewModel(Cr2wFile.RootChunk, this)
            {
                FilePath = "(root)"
            };
            TabItemViewModels.Add(root);
            AddTabForRedType(Cr2wFile.RootChunk);

            foreach (var file in Cr2wFile.EmbeddedFiles)
            {
                if (file.Content != null)
                {
                    var vm = new RDTDataViewModel(file.Content, this)
                    {
                        FilePath = file.FileName,
                        IsEmbeddedFile = true
                    };
                    TabItemViewModels.Add(vm);
                    AddTabForRedType(file.Content);
                }
            }

            SelectedIndex = 0;

            SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
        }

        public Dictionary<CName, CR2WFile> Files { get; set; } = new();

        public CR2WFile GetFileFromDepotPathOrCache(CName depotPath)
        {
            lock (Files)
            {
                if (!Files.ContainsKey(depotPath))
                {
                    Files[depotPath] = GetFileFromDepotPath(depotPath);
                }

                if (Files[depotPath] != null)
                {
                    foreach (var res in Files[depotPath].EmbeddedFiles)
                    {
                        if (!Files.ContainsKey(res.FileName))
                        {
                            Files.Add(res.FileName, new CR2WFile()
                            {
                                RootChunk = res.Content
                            });
                        }
                    }
                }
            }
            return Files[depotPath];
        }

        public ICommand NewEmbeddedFileCommand { get; private set; }
        private void ExecuteNewEmbeddedFile()
        {
            var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.IsAssignableTo(typeof(CResource)) && p.IsClass)
                .Select(x => x.Name));

            var app = Locator.Current.GetService<AppViewModel>();
            app.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
            {
                DialogHandler = HandleEmbeddedFile
            });
        }

        public void HandleEmbeddedFile(DialogViewModel sender)
        {
            var app = Locator.Current.GetService<AppViewModel>();
            app.CloseDialogCommand.Execute(null);
            if (sender is not null && sender is CreateClassDialogViewModel dvm)
            {
                var instance = RedTypeManager.Create(dvm.SelectedClass);

                var file = new CR2WEmbedded
                {
                    Content = instance,
                    FileName = "unnamed." + FileTypeHelper.GetFileExtensionsFromRootName(instance.GetType().Name)[0]
                };

                Cr2wFile.EmbeddedFiles.Add(file);
                IsDirty = true;

                var vm = new RDTDataViewModel(file.Content, this)
                {
                    FilePath = file.FileName,
                    IsEmbeddedFile = true
                };
                TabItemViewModels.Add(vm);
                AddTabForRedType(file.Content);
            }
        }

        public CR2WFile GetFileFromDepotPath(CName depotPath, bool original = false)
        {
            try
            {
                CR2WFile cr2wFile = null;

                if (!original)
                {
                    var projectManager = Locator.Current.GetService<IProjectManager>();
                    if (projectManager.ActiveProject != null)
                    {
                        string path = null;
                        if (!string.IsNullOrEmpty(depotPath))
                        {
                            path = Path.Combine(projectManager.ActiveProject.ModDirectory, (string)depotPath);
                        }
                        else
                        {
                            var fm = Locator.Current.GetService<IWatcherService>().GetFileModelFromHash(depotPath.GetRedHash());
                            if (fm != null)
                            {
                                path = fm.FullName;
                            }
                        }

                        if (path != null && File.Exists(path))
                        {
                            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                            using var reader = new BinaryReader(stream);
                            cr2wFile = _parser.ReadRed4File(reader);
                        }
                    }
                }

                if (cr2wFile == null)
                {
                    var _archiveManager = Locator.Current.GetService<IArchiveManager>();
                    var file = _archiveManager.Lookup(depotPath.GetRedHash());
                    if (file.HasValue && file.Value is FileEntry fe)
                    {
                        using var stream = new MemoryStream();
                        fe.Extract(stream);

                        cr2wFile = _parser.ReadRed4File(stream);
                    }
                }

                if (cr2wFile != null)
                {
                    if (!string.IsNullOrEmpty(depotPath))
                    {
                        cr2wFile.MetaData.FileName = depotPath;
                    }

                    lock (Files)
                    {
                        foreach (var res in cr2wFile.EmbeddedFiles)
                        {
                            if (!Files.ContainsKey(res.FileName))
                            {
                                Files.Add(res.FileName, new CR2WFile()
                                {
                                    RootChunk = res.Content
                                });
                            }
                        }
                    }

                    return cr2wFile;
                }
            }
            catch (Exception)
            {
                // ignore
            }

            return null;
        }

        public RedDocumentTabViewModel OpenRefAsTab(string path)
        {
            var tab = OpenRefAsTab(FNV1A64HashAlgorithm.HashString(path));
            tab.Header = Path.GetFileName(path);
            tab.FilePath = path;
            return tab;
        }

        public RedDocumentTabViewModel OpenRefAsTab(ulong hash)
        {
            var file = GetFileFromDepotPath(hash);
            if (file != null)
            {
                var tab = new RDTDataViewModel(hash.ToString(), file.RootChunk, this);
                TabItemViewModels.Add(tab);
                return tab;
            }
            return null;
        }

        #endregion

    }
}

