using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Options;
using WolvenKit.App.Factories;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public enum ERedDocumentItemType
{
    MainFile,
    W2rcBuffer,
    Buffer,
    Editor
}

public partial class RedDocumentViewModel : DocumentViewModel
{
    private readonly IDocumentTabViewmodelFactory _documentTabViewmodelFactory;
    private readonly IChunkViewmodelFactory _chunkViewmodelFactory;
    private readonly IProjectManager _projectManager;
    private readonly ILoggerService _loggerService;
    private readonly IOptions<Globals> _globals;
    private readonly Red4ParserService _parserService;
    private readonly IWatcherService _watcherService;
    private readonly IArchiveManager _archiveManager;
    private readonly IHookService _hookService;
    private readonly INodeWrapperFactory _nodeWrapperFactory;

    private readonly AppViewModel _appViewModel;

    protected readonly HashSet<string> _embedHashSet;

    private readonly string _path;

    public RedDocumentViewModel(CR2WFile file, string path, AppViewModel appViewModel,
        IDocumentTabViewmodelFactory documentTabViewmodelFactory,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IProjectManager projectManager,
        ILoggerService loggerService,
        IOptions<Globals> globals,
        Red4ParserService parserService,
        IWatcherService watcherService,
        IArchiveManager archiveManager,
        IHookService hookService,
        INodeWrapperFactory nodeWrapperFactory,
        bool isReadyOnly = false) : base(path)
    {
        _documentTabViewmodelFactory = documentTabViewmodelFactory;
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _projectManager = projectManager;
        _loggerService = loggerService;
        _globals = globals;
        _parserService = parserService;
        _watcherService = watcherService;
        _archiveManager = archiveManager;
        _hookService = hookService;
        _nodeWrapperFactory = nodeWrapperFactory;

        _appViewModel = appViewModel;
        _embedHashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "yaml",
            "yml",
            "xl"
        };

        _path = path;


        _extension = Path.GetExtension(path) != "" ? Path.GetExtension(path)[1..] : "";

        Cr2wFile = file;
        IsReadOnly = isReadyOnly;
        _isInitialized = true;
        PopulateItems();
    }

    #region properties

    public CR2WFile Cr2wFile { get; set; }

    [ObservableProperty] private ObservableCollection<RedDocumentTabViewModel> _tabItemViewModels = new();

    [ObservableProperty] private int _selectedIndex;

    [ObservableProperty] private RedDocumentTabViewModel? _selectedTabItemViewModel;

    partial void OnSelectedTabItemViewModelChanged(RedDocumentTabViewModel? value)
    {
        value?.OnSelected();
    }

    // assume files that don't exist are relative paths
    public string RelativePath
    {
        get
        {
            return File.Exists(_path)
                ? Path.GetRelativePath(_projectManager.ActiveProject.NotNull().ModDirectory, _path)
                : _path;
        }
    }

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(NewEmbeddedFileCommand))]
    private string _extension;

    #endregion

    #region commands

    private bool CanExecuteNewEmbeddedFile() => !_embedHashSet.Contains(Extension);
    [RelayCommand(CanExecute = nameof(CanExecuteNewEmbeddedFile))]
    private async Task NewEmbeddedFile()
    {
        var types = FileTypeHelper.FileTypes
            .OrderBy(x => x.Extension)
            .Select(fileType => new TypeEntry(fileType.Extension.ToString(), fileType.Description, fileType.RootType))
            .ToList();

        await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
        {
            DialogHandler = HandleEmbeddedFile
        });
    }

    #endregion

    #region methods

    public ILoggerService GetLoggerService() => _loggerService;

    public override async Task Save(object? parameter)
    {
        var ms = new MemoryStream();
        var file = GetMainFile();

        try
        {
            // if we're in a text view, use a normal StreamWriter, else use the CR2W one
            if (file is RDTTextViewModel textViewModel)
            {
                using var tw = new StreamWriter(ms, null, -1, true);
                var text = textViewModel.Text;
                tw.Write(text);
            }
            else if (file is not null && Cr2wFile != null)
            {
                var cr2w = Cr2wFile;
                if (_hookService is AppHookService appHookService && !appHookService.OnSave(FilePath, ref cr2w))
                {
                    _loggerService.Error($"Error while processing onSave hooks");
                    return;
                }

                using var writer = new CR2WWriter(ms, Encoding.UTF8, true) { LoggerService = _loggerService };
                writer.WriteFile(cr2w);
            }
        }
        catch (Exception e)
        {
            _loggerService.Error($"Error while saving {FilePath}");
            _loggerService.Error(e);

            return;
        }

        if (FileHelper.SafeWrite(ms, FilePath, _loggerService))
        {
            LastWriteTime = File.GetLastWriteTime(FilePath);
        }

        SetIsDirty(false);
        _loggerService.Success($"Saved file {FilePath}");

        await Task.CompletedTask;
    }

    public override void SaveAs(object parameter) => throw new NotImplementedException();

    public override bool Reload(bool force)
    {
        if (!File.Exists(FilePath))
        {
            return false;
        }

        if (!force && IsDirty)
        {
            return false;
        }

        using var fs = File.Open(FilePath, FileMode.Open);
        if (_parserService.TryReadRed4File(fs, out var cr2wFile))
        {
            Cr2wFile = cr2wFile;
            PopulateItems();
            
            SetIsDirty(false);
            LastWriteTime = File.GetLastWriteTime(FilePath);

            return true;
        }

        return false;
    }

    public RedDocumentTabViewModel? GetMainFile()
    {
        if (SelectedTabItemViewModel is RDTTextViewModel textVM)
        {
            return textVM;
        }

        return TabItemViewModels
            .OfType<RDTDataViewModel>()
            .FirstOrDefault(x => x.DocumentItemType == ERedDocumentItemType.MainFile);
    }

    protected void AddTabForRedType(RedBaseClass cls)
    {
        if (cls is CBitmapTexture xbm)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory. RDTTextureViewModel(xbm, this));
        }
        if (cls is CCubeTexture cube)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTTextureViewModel(cube, this));
        }
        if (cls is CTextureArray texa)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTTextureViewModel(texa, this));
        }
        if (cls is CMesh mesh && mesh.RenderResourceBlob != null && mesh.RenderResourceBlob.GetValue() is rendRenderTextureBlobPC)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTTextureViewModel(mesh, this));
        }
        if (cls is CReflectionProbeDataResource probe && probe.TextureData.RenderResourceBlobPC.GetValue() is rendRenderTextureBlobPC)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTTextureViewModel(probe, this));
        }
        if (cls is Multilayer_Mask mlmask)
        {
            // maybe it makes more sense to put these all into one tab?
            ModTools.ConvertMultilayerMaskToDdsStreams(mlmask, out var streams);
            for (var i = 0; i < streams.Count; i++)
            {
                var tab = _documentTabViewmodelFactory.RDTTextureViewModel(streams[i], this);
                tab.Header = $"MultiLayer {i}";
                TabItemViewModels.Add(tab);
            }
        }
        if (cls is inkTextureAtlas atlas)
        {
            var slot = atlas.Slots[0];
            if (slot != null)
            {
                var file = GetFileFromDepotPath(slot.Texture.DepotPath);
                if (file != null)
                {
                    TabItemViewModels.Add(_documentTabViewmodelFactory.RDTInkTextureAtlasViewModel(atlas, (CBitmapTexture)file.RootChunk, this));
                }
            }
        }
        if (cls is inkWidgetLibraryResource library)
        {
            TabItemViewModels.Add(new RDTWidgetViewModel(library, this));
        }
        if (cls is CMesh mesh2)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTMeshViewModel(mesh2, this));
        }
        if (cls is entEntityTemplate ent)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTMeshViewModel(ent, this));
        }
        if (cls is worldStreamingSector wss)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTMeshViewModel(wss, this));
        }
        if (cls is worldStreamingBlock wsb)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTMeshViewModel(wsb, this));
        }
        if (_globals.Value.ENABLE_NODE_EDITOR && cls is graphGraphResource or scnSceneResource)
        {
            TabItemViewModels.Add(new RDTGraphViewModel2(cls, this, _nodeWrapperFactory));
        }
    }

    public void PopulateItems()
    {
        TabItemViewModels.Clear();

        var root = _documentTabViewmodelFactory.RDTDataViewModel(Cr2wFile.RootChunk, this, _appViewModel, _chunkViewmodelFactory);
        root.FilePath = "(root)";
        TabItemViewModels.Add(root);
        AddTabForRedType(Cr2wFile.RootChunk);

        foreach (var file in Cr2wFile.EmbeddedFiles)
        {
            if (file.Content != null)
            {
                var vm = _documentTabViewmodelFactory.RDTDataViewModel(file.Content, this, _appViewModel, _chunkViewmodelFactory);
                vm.FilePath = file.FileName.GetResolvedText()!;
                vm.IsEmbeddedFile = true;

                TabItemViewModels.Add(vm);
                AddTabForRedType(file.Content);
            }
        }

        SelectedIndex = 0;

        SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
    }

    public Dictionary<ResourcePath, CR2WFile?> Files { get; set; } = new();

    public CR2WFile? GetFileFromDepotPathOrCache(ResourcePath depotPath)
    {
        lock (Files)
        {
            if (!Files.ContainsKey(depotPath))
            {
                var file = GetFileFromDepotPath(depotPath);
                Files[depotPath] = file;
            }

            if (Files[depotPath] != null)
            {
                foreach (var res in Files[depotPath]!.EmbeddedFiles)
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

    public void HandleEmbeddedFile(DialogViewModel? sender)
    {
        if (Cr2wFile is null)
        {
            return;
        }

        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
        {
            var instance = RedTypeManager.Create(selectedType);

            var file = new CR2WEmbedded
            {
                Content = instance,
                FileName = "unnamed." + FileTypeHelper.GetFileExtensionsFromRootName(instance.GetType().Name)[0]
            };

            Cr2wFile.EmbeddedFiles.Add(file);
            IsDirty = true;

            var vm = _documentTabViewmodelFactory.RDTDataViewModel(file.Content, this, _appViewModel, _chunkViewmodelFactory);
            vm.FilePath = file.FileName.GetResolvedText()!;
            vm.IsEmbeddedFile = true;

            TabItemViewModels.Add(vm);
            AddTabForRedType(file.Content);
        }
    }

    public CR2WFile? GetFileFromDepotPath(ResourcePath depotPath, bool original = false)
    {
        if (depotPath == ResourcePath.Empty)
        {
            return null;
        }

        try
        {
            CR2WFile? cr2wFile = null;

            if (!original)
            {
                if (_projectManager.ActiveProject != null)
                {
                    string? path = null;
                    if (!string.IsNullOrEmpty(depotPath))
                    {
                        path = Path.Combine(_projectManager.ActiveProject.ModDirectory, depotPath.GetString().NotNull());
                    }
                    else
                    {
                        var fm = _watcherService.GetFileModelFromHash(depotPath.GetRedHash());
                        if (fm != null)
                        {
                            path = fm.FullName;
                        }
                    }

                    if (path != null && File.Exists(path))
                    {
                        using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using var reader = new BinaryReader(stream);
                        cr2wFile = _parserService.ReadRed4File(reader);
                    }
                }
            }

            if (cr2wFile == null)
            {
                var file = _archiveManager.Lookup(depotPath.GetRedHash());
                if (file.HasValue && file.Value is FileEntry fe)
                {
                    using var stream = new MemoryStream();
                    fe.Extract(stream);

                    cr2wFile = _parserService.ReadRed4File(stream);
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

    public RedDocumentTabViewModel? OpenRefAsTab(string path)
    {
        var tab = OpenRefAsTab(FNV1A64HashAlgorithm.HashString(path));
        if (tab is null)
        {
            return null;
        }

        tab.Header = Path.GetFileName(path);
        tab.FilePath = path;
        return tab;
    }

    public RedDocumentTabViewModel? OpenRefAsTab(ulong hash)
    {
        var file = GetFileFromDepotPath(hash);
        if (file == null)
        {
            return null;
        }

        var tab = _documentTabViewmodelFactory.RDTDataViewModel(hash.ToString(), file.RootChunk, this, _appViewModel, _chunkViewmodelFactory);
        TabItemViewModels.Add(tab);
        return tab;
    }


    #endregion

}

