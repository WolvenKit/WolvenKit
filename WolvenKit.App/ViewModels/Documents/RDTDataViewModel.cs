using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.Services;
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
        
        if (SelectedChunk == null && Chunks.Count > 0)
        {
            SelectedChunk = Chunks[0];
            SelectedChunks.Add(Chunks[0]);
        }

        Nodes.Add(new ResourcePathWrapper(this, new ReferenceSocket(Chunks[0].RelativePath), _appViewModel, _chunkViewmodelFactory));
        _nodePaths.Add(Chunks[0].RelativePath);
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

    public virtual ChunkViewModel GenerateChunks() => _chunkViewmodelFactory.ChunkViewModel(_data, this, _appViewModel/*, Parent.IsReadOnly*/);

    [ObservableProperty]
    private bool _isEmbeddedFile;

    [ObservableProperty] private ChunkViewModel? _selectedChunk;

    [ObservableProperty] private ObservableCollection<ChunkViewModel> _selectedChunks = new ObservableCollection<ChunkViewModel>();


    [ObservableProperty] private ChunkViewModel? _rootChunk;

    [ObservableProperty] private ObservableCollection<object> _nodes = new();

    [ObservableProperty] private ObservableCollection<RedReference> _references = new();

    [ObservableProperty] private IRedRef? _selectedImport;

    public bool ShowReferenceGraph => _settingsManager.ShowReferenceGraph;

    public delegate void LayoutNodesDelegate();

    public LayoutNodesDelegate? LayoutNodes;


    #endregion

    #region commands
    
    [RelayCommand]
    private Task OpenImport(ICR2WImport input)
    {
        var depotpath = input.DepotPath;
        var key = FNV1A64HashAlgorithm.HashString(depotpath.ToString().NotNull());

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
    #endregion
}
