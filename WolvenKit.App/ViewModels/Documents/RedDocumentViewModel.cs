using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Options;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
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
    private readonly IArchiveManager _archiveManager;
    private readonly IHookService _hookService;
    private readonly INodeWrapperFactory _nodeWrapperFactory;
    private readonly Cr2WTools _cr2WTools;


    private readonly AppViewModel _appViewModel;

    protected readonly HashSet<string> _embedHashSet;

    private readonly string _path;
    private bool _suppressNextReload;

    public RedDocumentViewModel(CR2WFile file, string path, AppViewModel appViewModel,
        IDocumentTabViewmodelFactory documentTabViewmodelFactory,
        IChunkViewmodelFactory chunkViewmodelFactory,
        IProjectManager projectManager,
        ILoggerService loggerService,
        IOptions<Globals> globals,
        Red4ParserService parserService,
        IArchiveManager archiveManager,
        IHookService hookService,
        INodeWrapperFactory nodeWrapperFactory,
        Cr2WTools cr2WTools,
        ISettingsManager settingsManager,
        bool isReadyOnly = false) : base(path)
    {
        _documentTabViewmodelFactory = documentTabViewmodelFactory;
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _projectManager = projectManager;
        _loggerService = loggerService;
        _globals = globals;
        _parserService = parserService;
        _archiveManager = archiveManager;
        _hookService = hookService;
        _nodeWrapperFactory = nodeWrapperFactory;
        _cr2WTools = cr2WTools;

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

    public event EventHandler? OnSaveCompleted;

    [ObservableProperty] private ObservableCollection<RedDocumentTabViewModel> _tabItemViewModels = new();

    [ObservableProperty] private int _selectedIndex;

    [ObservableProperty] private RedDocumentTabViewModel? _selectedTabItemViewModel;

    partial void OnSelectedTabItemViewModelChanged(RedDocumentTabViewModel? value)
    {
        // Communicate index of selected world node across tabs
        switch (value)
        {
            case RDTDataViewModel model:
                if (_selectedWorldNodeIndex is not null)
                {
                    int.TryParse(_selectedWorldNodeIndex, out var worldNodeIndex);
                    model.AddToSelection(model.FindWorldNode(worldNodeIndex));
                }
                model.OnReloadRequired += OnReloadTabs;
                break;
            case RDTMeshViewModel meshViewModel:
                meshViewModel.SelectedNodeIndex = _selectedWorldNodeIndex;
                break;
        }


        ShowMenuToolbar = value?.FilePath.EndsWith(".mesh") == true;
        value?.OnSelected();
    }

    private void OnReloadTabs(object? sender, EventArgs e)
    {
        PopulateItems(true);
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

    [ObservableProperty] private bool _showMenuToolbar;

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

    public Cp77Project? GetActiveProject() => _projectManager.ActiveProject;

    public ILoggerService GetLoggerService() => _loggerService;

    public override async Task Save(object? parameter)
    {
        SaveSync(parameter);
        await Task.CompletedTask;
    }

    protected override void SaveAs(SaveAsParameters saveParams)
    {
        var cr2W = Cr2wFile;
        if (!saveParams.SkipOnSaveHook && _hookService is AppHookService appHookService &&
            !appHookService.OnSave(FilePath, ref cr2W))
        {
            _loggerService.Error($"Error while processing onSave hooks");
        }

        if (!SaveSync(saveParams.OriginalObject, saveParams.AbsoluteFilePath))
        {
            throw new Exception($"Failed to save {saveParams.AbsoluteFilePath}");
        }
    }

    public bool SaveSync(object? _, string? filePath = null)
    {
        filePath ??= FilePath;
        var cr2w = Cr2wFile;

        if (_hookService is AppHookService appHookService && !appHookService.OnSave(FilePath, ref cr2w))
        {
            _loggerService.Error($"Error while processing onSave hooks");
            return false;
        }

        _suppressNextReload = true;

        if (GetMainFile() is null || !_cr2WTools.WriteCr2W(cr2w, filePath))
        {
            _suppressNextReload = false; // Clear on failure
            return false;
        }

        LastWriteTime = File.GetLastWriteTime(filePath);
        SetIsDirty(false);
        OnSaveCompleted?.Invoke(this, EventArgs.Empty);
        return true;
    }


    public override bool Reload(bool force)
    {
        if (_suppressNextReload)
        {
            _suppressNextReload = false; // Consume the flag
            // This reload was triggered by our own save.
            // We just need to update the timestamp and dirty state, not rebuild the UI.
            SetIsDirty(false);
            LastWriteTime = File.GetLastWriteTime(FilePath);
            return true;
        }

        if (!File.Exists(FilePath) || (!force && IsDirty))
        {
            return false;
        }

        // If we got here, it means the files were different, or an error occurred during comparison.
        // Proceed with the original, destructive reload.
        try
        {
            var cr2WFile = _cr2WTools.ReadCr2W(FilePath);
            Cr2wFile = cr2WFile;
        }
        catch (Exception)
        {
            return false;
        }
        PopulateItems();

        SetIsDirty(false);
        LastWriteTime = File.GetLastWriteTime(FilePath);

        return true;
    }

    public RedDocumentTabViewModel? GetMainFile()
    {
        return TabItemViewModels
            .OfType<RDTDataViewModel>()
            .FirstOrDefault(x => x.DocumentItemType == ERedDocumentItemType.MainFile);
    }

    protected void AddTabForRedType(RedBaseClass cls)
    {
        if (cls is CBitmapTexture xbm)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTTextureViewModel(xbm, this));
        }
        if (cls is CCubeTexture cube)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTTextureViewModel(cube, this));
        }
        if (cls is CTextureArray texa)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTLayeredPreviewViewModel(texa, this));
        }
        if (cls is CMesh mesh && mesh.RenderResourceBlob != null && mesh.RenderResourceBlob.GetValue() is rendRenderTextureBlobPC)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTTextureViewModel(mesh, this));
        }
        if (cls is CReflectionProbeDataResource probe && probe.TextureData.RenderResourceBlobPC.GetValue() is rendRenderTextureBlobPC)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTLayeredPreviewViewModel(probe, this));
        }
        if (cls is Multilayer_Mask mlmask)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTLayeredPreviewViewModel(mlmask, this));
        }
        if (cls is inkTextureAtlas atlas)
        {
            var tab = _documentTabViewmodelFactory.RDTInkTextureAtlasViewModel(atlas, this);
            tab.ChangeEvent += OnPartNameChanged;
            TabItemViewModels.Add(tab);
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
            var tab = _documentTabViewmodelFactory.RDTMeshViewModel(wss, this);
            tab.OnSectorNodeSelected += OnSectorNodeSelected;
            TabItemViewModels.Add(tab);
        }
        if (cls is worldStreamingBlock wsb)
        {
            TabItemViewModels.Add(_documentTabViewmodelFactory.RDTMeshViewModel(wsb, this));
        }
        if (cls is scnSceneResource sceneResource)
        {
            var combinedSceneTab = new SceneGraphViewModel(sceneResource, this, _chunkViewmodelFactory, _nodeWrapperFactory);
            TabItemViewModels.Insert(0, combinedSceneTab);

            if (_globals.Value.ENABLE_NODE_EDITOR)
            {
                TabItemViewModels.Add(new RDTGraphViewModel2(sceneResource, this, _nodeWrapperFactory));
            }

            return;
        }

        if (cls is questQuestPhaseResource questPhaseResource)
        {
            var combinedQuestPhaseTab = new QuestPhaseGraphViewModel(questPhaseResource, this, _chunkViewmodelFactory, _nodeWrapperFactory);
            TabItemViewModels.Insert(0, combinedQuestPhaseTab);

            if (_globals.Value.ENABLE_NODE_EDITOR)
            {
                TabItemViewModels.Add(new RDTGraphViewModel2(questPhaseResource, this, _nodeWrapperFactory));
            }

            return;
        }

        if (_globals.Value.ENABLE_NODE_EDITOR && cls is graphGraphResource)
        {
            TabItemViewModels.Add(new RDTGraphViewModel2(cls, this, _nodeWrapperFactory));
        }
    }

    private string? _selectedWorldNodeIndex;

    private void OnSectorNodeSelected(object? sender, string? e) => _selectedWorldNodeIndex = e;

    private void OnPartNameChanged(object sender, EventArgs e)
    {
        if (GetMainFile() is not RDTDataViewModel m || m.Chunks.Count == 0 || m.Chunks[0] is not { ResolvedData: inkTextureAtlas } cvm ||
            cvm.Properties.FirstOrDefault((p) => p.Name == "slots") is not ChunkViewModel child)
        {
            return;
        }

        foreach (var chunkViewModel in child.Properties.Where(p => p.ResolvedData is inkTextureSlot).ToList())
        {
            m.DirtyChunks.Add(chunkViewModel);
        }

        SetIsDirty(m.DirtyChunks.Count > 0);
    }


    public void PopulateItems(bool keepRootTab = false)
    {
        foreach (var tab in TabItemViewModels)
        {
            switch (tab)
            {
                case RDTInkTextureAtlasViewModel inkTextureTab:
                    inkTextureTab.ChangeEvent -= OnPartNameChanged;
                    break;
                case RDTMeshViewModel meshTab:
                    meshTab.OnSectorNodeSelected -= OnSectorNodeSelected;
                    break;
                case RDTDataViewModel dataViewModel when !keepRootTab:
                    dataViewModel.OnSectorNodeSelected -= OnSectorNodeSelected;
                    break;
                default:
                    break;
            }
        }

        RDTDataViewModel rootTab;
        if (keepRootTab)
        {
            rootTab = TabItemViewModels.OfType<RDTDataViewModel>().First();
        }
        else
        {
            rootTab = _documentTabViewmodelFactory.RDTDataViewModel(Cr2wFile.RootChunk, this, _appViewModel, _chunkViewmodelFactory);
            rootTab.OnSectorNodeSelected += OnSectorNodeSelected;
        }

        TabItemViewModels.Clear();

        TabItemViewModels.Add(rootTab);
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
        if (depotPath == ResourcePath.Empty)
        {
            return null;
        }

        var existingPath = depotPath.GetResolvedText();
        if (existingPath?.StartsWith('*') is true)
        {
            existingPath = ArchiveXlHelper.GetFirstExistingPath(existingPath);
        }

        if (string.IsNullOrEmpty(existingPath))
        {
            return null;
        }

        lock (Files)
        {
            if (!Files.ContainsKey(existingPath))
            {
                var file = GetFileFromDepotPath(existingPath, false);
                Files[existingPath] = file;
            }

            if (Files[existingPath] != null)
            {
                foreach (var res in Files[existingPath]!.EmbeddedFiles)
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

        return Files[existingPath];
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

        var existingPath = depotPath.GetResolvedText();
        if (existingPath?.StartsWith('*') is true)
        {
            existingPath = ArchiveXlHelper.GetFirstExistingPath(existingPath);
        }

        if (null == existingPath)
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
                    if (!string.IsNullOrEmpty(existingPath))
                    {
                        path = Path.Combine(_projectManager.ActiveProject.ModDirectory, existingPath);
                        // If it's not a mod file, read from game files
                        if (!File.Exists(path))
                        {
                            path = Path.Combine(_projectManager.ActiveProject.FileDirectory, existingPath);
                        }
                    }
                    else
                    {
                        foreach (var file in Directory.GetFiles(_projectManager.ActiveProject.ModDirectory, "*", SearchOption.AllDirectories))
                        {
                            var relativePath = _projectManager.ActiveProject.GetRelativePath(file);
                            if (depotPath.GetRedHash() == ResourcePath.CalculateHash(relativePath))
                            {
                                path = file;
                                break;
                            }
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
                if (file is { HasValue: true, Value: FileEntry fe })
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

