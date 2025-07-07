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

        Nodes.Add(new ResourcePathWrapper(this, new ReferenceSocket(Chunks[0].RelativePath), _appViewModel, _chunkViewmodelFactory));
        _nodePaths.Add(Chunks[0].RelativePath);

        SubscribeToChunkPropertyChanges();
        
        if (SelectedChunk == null && Chunks.Count > 0)
        {
            SelectedChunk = Chunks[0];
            SelectedChunks.Add(Chunks[0]);
        }
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

    public override RedDocumentItemType GetContentType()
    {
        return GetRootChunk()?.ResolvedData switch
        {
            CMesh => RedDocumentItemType.Mesh,
            appearanceAppearanceResource => RedDocumentItemType.App,
            entEntityTemplate => RedDocumentItemType.Ent,
            CMaterialInstance => RedDocumentItemType.Mi,
            _ => base.GetContentType()
        };
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
            if (_chunks.Count == 0 && _data is not RedDummy)
            {
                _chunks.Add(GenerateChunks());
            }
            return _chunks;
        }
        set => _chunks = value;
    }

    public virtual ChunkViewModel GenerateChunks() => _chunkViewmodelFactory.ChunkViewModel(_data, this, _appViewModel);

    [ObservableProperty]
    private bool _isEmbeddedFile;

    [ObservableProperty] private ChunkViewModel? _selectedChunk;

    [ObservableProperty] private ObservableCollection<object> _selectedChunks = new();

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

    public int NumSelectedItems => SelectedChunks.OfType<ChunkViewModel>().Count();

    public delegate void LayoutNodesDelegate();

    public LayoutNodesDelegate? LayoutNodes;
    

    #endregion

    #region commands
    
    [RelayCommand]
    private async Task OpenImport(ICR2WImport input)
    {
        var depotpath = input.DepotPath;
        var key = FNV1A64HashAlgorithm.HashString(depotpath.GetResolvedText().NotNull());

        await _gameController.GetController().AddFileToModModalAsync(key);
    }

    #endregion

    #region methods

    public void LookForReferences(ChunkViewModel cvm)
    {
        if (cvm.Data is RedDummy)
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

        LayoutNodes?.Invoke();
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
        base.OnSelected();
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
        foreach (var cvm in SelectedChunks.OfType<ChunkViewModel>())
        {
            cvm.IsSelected = false;
        }

        SelectedChunks.Clear();
        SelectedChunk = null;
    }

    
    public void AddToSelection(ChunkViewModel? chunk)
    {
        var selectedChunks = SelectedChunks.OfType<ChunkViewModel>().ToList();
        
        ClearSelection();
        if (chunk is null)
        {
            return;
        }

        ExpandParentNodes(chunk);
        chunk.IsSelected = true;

        selectedChunks.Add(chunk);
        foreach (var cvm in selectedChunks)
        {
            SelectedChunks.Add(cvm);
        }
        SelectedChunk = chunk;
    }

    public void RemoveFromSelection(ChunkViewModel? chunk)
    {
        if (chunk is not null)
        {
            chunk.IsSelected = false;
            SelectedChunks.Remove(chunk);
        }
        
        SelectedChunk = null;
    }

    public void SetSelection(ChunkViewModel chunk, bool addToPrevious = false)
    {
        var previousSelection = addToPrevious ? SelectedChunks.OfType<ChunkViewModel>().ToList() : new List<ChunkViewModel>();
        ClearSelection();

        ExpandParentNodes(chunk);
        chunk.IsSelected = true;

        if (!previousSelection.Contains(chunk))
        {
            previousSelection.Add(chunk);
        }

        foreach (var cvm in previousSelection)
        {
            SelectedChunks.Add(cvm);
        }

        SelectedChunk = chunk;
    }


    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        // Suppress property change notifications during batch operations
        if (_suppressPropertyChanges && e.PropertyName == nameof(SelectedChunks))
        {
            return;
        }
        
        base.OnPropertyChanged(e);
    }

    private bool _suppressPropertyChanges = false;
    
    public void SetSelection(List<ChunkViewModel> chunks)
    {
        try
        {
            _suppressPropertyChanges = true;
            
            ClearSelection();
            if (chunks.Count == 0)
            {
                return;
            }
            
            // remove duplicates
            var uniqueChunks = new HashSet<ChunkViewModel>(chunks);
            
            foreach (var cvm in uniqueChunks)
            {
                cvm.IsSelected = true;
                ExpandParentNodes(cvm);
                
                if (!SelectedChunks.Contains(cvm))
                {
                    SelectedChunks.Add(cvm);
                }
            }

            SelectedChunk ??= uniqueChunks.LastOrDefault();
        }
        finally
        {
            _suppressPropertyChanges = false;
            // Fire a single property changed event for SelectedChunks to sync everything at once
            OnPropertyChanged(nameof(SelectedChunks));
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

        var root = RootChunk ?? _chunks.FirstOrDefault();

        // ReSharper disable once UseNullPropagation this does not help readability
        if (root is null)
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

    private static void ExpandParentNodes(ChunkViewModel cvm)
    {
        if (cvm.Parent is null)
        {
            return;
        }

        cvm.Parent.IsExpanded = true;
        ExpandParentNodes(cvm.Parent);
    }

    public void ScrollToNode(ChunkViewModel? selectedNode, bool addToSelection = false)
    {
        if (selectedNode is null)
        {
            return;
        }

        SetSelection(selectedNode, addToSelection);
    }

    // A material was renamed
    public void OnCNameValueChanged(ValueChangedEventArgs args)
    {
        if (args.RedType == typeof(CMeshMaterialEntry))
        {
            GetRootChunk()?.OnMaterialNameChange(args.OldValue, args.NewValue);
        }
    }

    public static event EventHandler<List<ChunkViewModel>>? OnSearchStringChanged;
    public void OnSearchChanged(string searchBoxText)
    {
        HasActiveSearch = !string.IsNullOrEmpty(searchBoxText);
        foreach (var chunkViewModel in Chunks)
        {
            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                chunkViewModel.CalculatePropertiesRecursive(0, 1024);
            }
            chunkViewModel.SetVisibilityStatusBySearchString(searchBoxText);
        }

        CurrentSearch = searchBoxText;

        OnSearchStringChanged?.Invoke(this, Chunks);
        if (string.IsNullOrEmpty(searchBoxText) && SelectedChunk is ChunkViewModel selectedChunk)
        {
            ScrollToNode(selectedChunk);
        }
    }
}
