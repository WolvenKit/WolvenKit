using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Events;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;


public partial class RDTDataViewModel : RedDocumentTabViewModel
{
    private readonly ISettingsManager _settingsManager;
    private readonly IGameControllerFactory _gameController;
    private readonly IChunkViewmodelFactory _chunkViewmodelFactory;

    private readonly AppViewModel _appViewModel;

    protected IRedType _data;
    
    private List<ResourcePath> _nodePaths = new();

    private List<ChunkViewModel> _chunks = new();


    public RDTDataViewModel(IRedType data, RedDocumentViewModel parent, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController) : base(parent, data.GetType().Name)
    {
        _settingsManager = settingsManager;
        _gameController = gameController;
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _appViewModel = appViewModel;

        _data = data;

        EditorDifficultyLevel = Parent.EditorDifficultyLevel;

        Nodes.Add(new ResourcePathWrapper(this, new ReferenceSocket(Chunks[0].RelativePath), _appViewModel, _chunkViewmodelFactory));
        _nodePaths.Add(Chunks[0].RelativePath);

        SubscribeToChunkPropertyChanges();
        
        if (SelectedChunk == null && Chunks.Count > 0)
        {
            SelectedChunk = Chunks[0];
            if (SelectedChunks is IList lst)
            {
                lst.Add(Chunks[0]);
            }
        }

        parent.PropertyChanged += RDTDataViewModel_PropertyChanged;
    }

    private void SubscribeToChunkPropertyChanges()
    {
        if (GetRootChunk() is not ChunkViewModel cvm || cvm.ResolvedData is not inkTextureAtlas ||
            cvm.GetPropertyChild("slots", "0") is not ChunkViewModel firstSlot || firstSlot.ResolvedData is not inkTextureSlot slot ||
            slot.Texture.DepotPath != ResourcePath.Empty)
        {
            return;
        }

        firstSlot.PropertyChanged += WaitForTexturePath;
    }

    public event EventHandler? OnReloadRequired;

    private void WaitForTexturePath(object? sender, PropertyChangedEventArgs evt)
    {
        if (sender is not ChunkViewModel cvm || evt.PropertyName != nameof(cvm.Value) || string.IsNullOrEmpty(cvm.Value))
        {
            return;
        }

        cvm.PropertyChanged -= WaitForTexturePath;
        OnReloadRequired?.Invoke(this, EventArgs.Empty);
    }

    public ChunkViewModel? GetRootChunk() => Chunks.FirstOrDefault();

    public override RedDocumentItemType GetContentType() => GetRootChunk()?.ResolvedData switch
        {
            CMesh => RedDocumentItemType.Mesh,
            appearanceAppearanceResource => RedDocumentItemType.App,
            entEntityTemplate => RedDocumentItemType.Ent,
            CMaterialInstance => RedDocumentItemType.Mi,
            _ => base.GetContentType()
        };

    private void RDTDataViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(RedDocumentViewModel.EditorDifficultyLevel) || EditorDifficultyLevel == Parent.EditorDifficultyLevel)
        {
            return;
        }

        EditorDifficultyLevel = Parent.EditorDifficultyLevel;
    }

    public RDTDataViewModel(string header, IRedType data, RedDocumentViewModel file, AppViewModel appViewModel,
        IChunkViewmodelFactory chunkViewmodelFactory,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController) 
        : this(data, file, appViewModel, chunkViewmodelFactory, settingsManager, gameController) => Header = header;

    #region properties

    public IRedType GetData() => _data;

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

    public List<ChunkViewModel> Chunks
    {
        get
        {
            if (_chunks == null || _chunks.Count == 0)
            {
                _chunks = _data is null ? new() : new List<ChunkViewModel>
                {
                    GenerateChunks()
                };
            }
            return _chunks;
        }
        set => _chunks = value;
    }

    public virtual ChunkViewModel GenerateChunks() =>
        _chunkViewmodelFactory.ChunkViewModel(_data, this, _appViewModel, EditorDifficultyLevel);

    [ObservableProperty]
    private bool _isEmbeddedFile;

    [ObservableProperty] private object? _selectedChunk;

    [ObservableProperty] private object? _selectedChunks;

    [ObservableProperty] private EditorDifficultyLevel _editorDifficultyLevel;

    [ObservableProperty] private ChunkViewModel? _rootChunk;

    [ObservableProperty] private ObservableCollection<object> _nodes = new();

    [ObservableProperty] private ObservableCollection<RedReference> _references = new();

    [ObservableProperty] private IRedRef? _selectedImport;

    [ObservableProperty] private string? _currentSearch;

    public bool ShowReferenceGraph => _settingsManager.ShowReferenceGraph;

    /// <summary>
    /// If this is not empty, force nodes and all of their children to recalculate properties after tab switch
    /// </summary>
    public List<ChunkViewModel> DirtyChunks { get; set; } = [];

    public bool HasActiveSearch { get; set; }

    public int NumSelectedItems => SelectedChunks is ObservableCollection<object> obs ? obs.Count : 0;

    public delegate void LayoutNodesDelegate();

    public LayoutNodesDelegate? LayoutNodes;
    

    #endregion

    #region commands
    
    [RelayCommand]
    private Task OpenImport(ICR2WImport input)
    {
        var depotpath = input.DepotPath;
        var key = FNV1A64HashAlgorithm.HashString(depotpath.GetResolvedText().NotNull());

        return _gameController.GetController().AddFileToModModal(key);
    }

    #endregion

    #region methods

    public void LookForReferences(ChunkViewModel cvm)
    {
        if (cvm.Data is null)
        {
            return;
        }

        LookForReferences(cvm, (RedBaseClass)cvm.Data, "root");

        foreach (var reference in References)
        {
            if (!_nodePaths.Contains(reference.Destination.File))
            {
                if (reference.Destination.File != ResourcePath.Empty)
                {
                    Nodes.Add(new ResourcePathWrapper(this, reference.Destination, _appViewModel, _chunkViewmodelFactory));
                    _nodePaths.Add(reference.Destination.File);
                }
            }
        }

        if (LayoutNodes != null)
        {
            LayoutNodes();
        }
    }

    public void LookForReferences(ChunkViewModel cvm, RedBaseClass data, string xpath)
    {
        foreach (var pi in RedReflection.GetTypeInfo(data.GetType()).PropertyInfos)
        {
            if (pi.Type.IsAssignableTo(typeof(IRedRef)))
            {
                var res = data.GetProperty(pi.RedName.NotNull()) as IRedRef ?? throw new ArgumentException();
                var innerType = res.GetType().GenericTypeArguments[0];
                var sourceSocket = new ReferenceSocket(cvm.RelativePath, xpath + "." + pi.RedName, innerType.Name);
                cvm.Outputs.Add(sourceSocket);

                if (res != null && !string.IsNullOrEmpty(res.DepotPath))
                {
                    sourceSocket.IsConnected = true;
                    ReferenceSocket? destSocket = null;
                    foreach (var reference in References)
                    {
                        if (reference.Destination.File == res.DepotPath)
                        {
                            destSocket = reference.Destination;
                        }
                    }
                    destSocket ??= new ReferenceSocket(res.DepotPath)
                    {
                        IsConnected = true
                    };
                    References.Add(new RedReference(this, sourceSocket, destSocket));
                }
            }
            else
            {
                var name = !string.IsNullOrEmpty(pi.RedName) ? pi.RedName : pi.Name;
                var prop = data.GetProperty(name);
                if (prop is RedBaseClass rbc)
                {
                    LookForReferences(cvm, rbc, xpath + "." + pi.RedName);
                }
                else if (prop is IRedHandle irh)
                {
                    if (irh.GetValue() is RedBaseClass rbc2)
                    {
                        LookForReferences(cvm, rbc2, xpath + "." + pi.RedName);
                    }
                }
                else if (prop is IRedArray ira)
                {
                    var i = 0;
                    foreach (var item in ira)
                    {
                        if (item is RedBaseClass rbc3)
                        {
                            LookForReferences(cvm, rbc3, xpath + "." + pi.RedName + $"[{i}]");
                        }
                        else if (item is IRedHandle irh2)
                        {
                            if (irh2.GetValue() is RedBaseClass rbc4)
                            {
                                LookForReferences(cvm, rbc4, xpath + "." + pi.RedName + $"[{i}]");
                            }
                        }
                        i++;
                    }
                }
                //else if (prop is SerializationDeferredDataBuffer sddb && sddb.Data is Package04 p4)
                //{
                //    var i = 0;
                //    foreach (var item in p4.Chunks)
                //    {
                //        if (item is RedBaseClass rbc5)
                //        {
                //            LookForReferences(cvm, rbc5, xpath + "." + pi.RedName + $"[{i}]");
                //        }
                //        i++;
                //    }
                //}
                //else if (prop is SharedDataBuffer sdb)
                //{
                //    if (sdb.Data is Package04 p42)
                //    {
                //        var i = 0;
                //        foreach (var item in p42.Chunks)
                //        {
                //            if (item is RedBaseClass rbc5)
                //            {
                //                LookForReferences(cvm, rbc5, xpath + "." + pi.RedName + $"[{i}]");
                //            }
                //            i++;
                //        }
                //    }
                //}
                //else if (prop is DataBuffer db)
                //{
                //    if (db.Data is Package04 p42)
                //    {
                //        var i = 0;
                //        foreach (var item in p42.Chunks)
                //        {
                //            if (item is RedBaseClass rbc5)
                //            {
                //                LookForReferences(cvm, rbc5, xpath + "." + pi.RedName + $"[{i}]");
                //            }
                //            i++;
                //        }
                //    }
                //    else if (db.Data is CR2WList cl)
                //    {
                //        var i = 0;
                //        foreach (var item in cl.Files)
                //        {
                //            if (item.RootChunk is RedBaseClass rbc5)
                //            {
                //                LookForReferences(cvm, rbc5, xpath + "." + pi.RedName + $"[{i}]");
                //            }
                //            i++;
                //        }
                //    }
                //}
            }
        }


    }

    public override void OnSelected()
    {
        RefreshDirtyChunks();

        if (SelectedChunk is ChunkViewModel { ResolvedData: worldNode } cvm)
        {
            OnSectorNodeSelected?.Invoke(this, $"{cvm.NodeIdxInParent}");
        }
        
        // if tweak file, deserialize from text
        // read tweakXL file
        // TODO fix TweakXLDocumentViewModel
        //if (File is TweakXLDocumentViewModel tweakFile)
        //{
        //    try
        //    {
        //        // get text tab
        //        var tab = tweakFile.TabItemViewModels.OfType<RDTTextViewModel>().First();
        //        var text = tab.GetText();

        //        using var reader = new StringReader(text);
        //        var deserializer = new DeserializerBuilder()
        //            .WithTypeConverter(new TweakXLYamlTypeConverter())
        //            .Build();
        //        var file = deserializer.Deserialize<TweakXLFile>(reader);
        //        _data = file;
        //        // refresh
        //        _chunks .Clear();
        //        _ = Chunks;
        //    }
        //    catch (Exception ex)
        //    {
        //        _loggerService.Error(ex);
        //    }
        //}
    }

    private void RefreshDirtyChunks()
    {
        if (DirtyChunks.Count == 0)
        {
            return;
        }

        foreach (var chunkViewModel in DirtyChunks)
        {
            foreach (var childProp in chunkViewModel.TVProperties)
            {
                childProp.RecalculateProperties();
            }
            chunkViewModel.RecalculateProperties();
        }

        DirtyChunks.Clear();
        
    }

    public void ClearSelection()
    {
        if (SelectedChunks is IList lst)
        {
            foreach (var obj in lst.OfType<ChunkViewModel>())
            {
                obj.IsSelected = false;
            }

            lst.Clear();
        }

        SelectedChunk = null;
    }

    public void AddToSelection(ChunkViewModel? chunk)
    {
        if (chunk is null)
        {
            return;
        }

        chunk.IsSelected = true;
        if (SelectedChunks is IList lst)
        {
            lst.Add(chunk);
        }

        SelectedChunk = chunk;
    }

    public void RemoveFromSelection(ChunkViewModel? chunk)
    {
        if (chunk is not null)
        {
            chunk.IsSelected = false;
        }

        if (SelectedChunks is IList lst && chunk is not null)
        {
            lst.Remove(chunk);
        }

        SelectedChunk = null;
    }


    public void SetSelection(ChunkViewModel chunk)
    {
        ClearSelection();
        chunk.IsSelected = true;
        SelectedChunk = chunk;
        if (SelectedChunks is IList lst)
        {
            lst.Add(chunk);
        }

        // clear IsSelected property again, because it'll be "stuck" otherwise 
        chunk.IsSelected = false;
        
    }

    public void SetSelection(List<ChunkViewModel> chunks)
    {
        ClearSelection();

        // should never happen, but alas, it's nullable
        if (SelectedChunks is not IList lst)
        {
            return;
        }     

        foreach (var chunkViewModel in chunks)
        {
            lst.Add(chunkViewModel);
            chunkViewModel.IsSelected = true;
            SelectedChunk = chunkViewModel;
        }
    }
    
    public event EventHandler<string>? OnSectorNodeSelected;

    /// <summary>
    /// For .streamingsector files, called when a mesh is selected in the other tab 
    /// </summary>
    /// <param name="selectedIndex"></param>
    /// <returns></returns>
    public ChunkViewModel? FindWorldNode(int? selectedIndex)
    {
        if (selectedIndex is not int idx)
        {
            return null;
        }
        var root = RootChunk;

        if (root is null)
        {
            root = _chunks.FirstOrDefault();
        }

        if (root is not ChunkViewModel)
        {
            return null;
        }

        var worldNodeArray = root.Properties.FirstOrDefault(chunk =>
            chunk is { IsArray: true, Name: "nodes", ResolvedData: CArray<CHandle<worldNode>> });
        if (worldNodeArray is null)
        {
            return null;
        }

        root.IsExpanded = true;
        worldNodeArray.IsExpanded = true;

        return worldNodeArray?.GetChildNode(idx);
    }
    
    #endregion

    private void ExpandParentNodes(ChunkViewModel cvm)
    {
        if (cvm.Parent is null)
        {
            return;
        }

        cvm.Parent.IsExpanded = true;
        ExpandParentNodes(cvm.Parent);
    }

    public void ScrollToNode(ChunkViewModel? selectedNode)
    {
        if (selectedNode is null)
        {
            return;
        }

        ExpandParentNodes(selectedNode);
        SetSelection(selectedNode);
    }

    // A material was renamed
    public void OnCNameValueChanged(ValueChangedEventArgs args)
    {
        if (args.RedType == typeof(CMeshMaterialEntry))
        {
            GetRootChunk()?.OnMaterialNameChange(args.OldValue, args.NewValue);
        }
    }

    public void OnSearchChanged(string searchBoxText)
    {
        HasActiveSearch = !string.IsNullOrEmpty(searchBoxText);
        foreach (var chunkViewModel in Chunks)
        {
            if (_chunks.Count <= 20)
            {
                chunkViewModel.CalculatePropertiesRecursive();
            }
            chunkViewModel.SetVisibilityStatusBySearchString(searchBoxText);
        }

        CurrentSearch = searchBoxText;

        if (string.IsNullOrEmpty(searchBoxText) && SelectedChunk is ChunkViewModel selectedChunk)
        {
            ScrollToNode(selectedChunk);
        }
    }
}
