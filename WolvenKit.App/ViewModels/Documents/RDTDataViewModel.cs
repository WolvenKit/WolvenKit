using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Commands;
using ReactiveUI;
using Splat;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Documents
{
    public partial class CNameWrapper : ObservableObject, INode<ReferenceSocket>
    {
        public CName CName => Socket.File;

        [ObservableProperty] private System.Windows.Point _location;

        public double Width { get; set; }

        public double Height { get; set; }

        [ObservableProperty] private ReferenceSocket _socket;

        public IList<ReferenceSocket> Inputs
        {
            get => new List<ReferenceSocket>(new ReferenceSocket[] { Socket });
            set
            {
                ;
            }
        }

        public IList<ReferenceSocket> Outputs { get; set; } = new List<ReferenceSocket>();

        public RDTDataViewModel DataViewModel { get; set; }

        public CNameWrapper(RDTDataViewModel vm, ReferenceSocket socket)
        {
            DataViewModel = vm;
            _socket = socket;
            OpenRefCommand = new DelegateCommand(ExecuteOpenRef, CanOpenRef);
            LoadRefCommand = new DelegateCommand(ExecuteLoadRef, CanLoadRef);
        }

        public ICommand OpenRefCommand { get; private set; }
        private bool CanOpenRef() => CName != CName.Empty && DataViewModel.File.RelativePath != CName;
        private void ExecuteOpenRef() => Locator.Current.GetService<AppViewModel>().NotNull().OpenFileFromDepotPath(CName);

        public ICommand LoadRefCommand { get; private set; }
        private bool CanLoadRef() => CName != CName.Empty;
        private void ExecuteLoadRef()
        {
            var cr2w = DataViewModel.File.GetFileFromDepotPathOrCache(CName);
            if (cr2w != null && cr2w.RootChunk != null)
            {
                var chunk = new ChunkViewModel(cr2w.RootChunk, Socket)
                {
                    Location = Location
                };
                DataViewModel.Nodes.Remove(this);
                DataViewModel.Nodes.Add(chunk);
                DataViewModel.LookForReferences(chunk);
            }
        }
    }

    public partial class RDTDataViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {
        private readonly ISettingsManager _settingsManager;

        public ViewModelActivator Activator { get; } = new();

        protected IRedType _data;

        public bool IsEmbeddedFile { get; set; }

        public RDTDataViewModel(IRedType data, RedDocumentViewModel parent) : base(parent, data.GetType().Name)
        {
            _settingsManager = Locator.Current.GetService<ISettingsManager>().NotNull();

            _data = data;

            // set header
            //if (data is null && parent is TweakXLDocumentViewModel)
            //{
            //    var ext = Path.GetExtension(parent.FilePath).ToLower();
            //    Header = ext switch
            //    {
            //        ".yaml" => "TweakXL",
            //        ".yml" => "TweakXL",
            //        ".xl" => "TweakXL",
            //        _ => throw new NotImplementedException(),
            //    };
            //}
            //else
            //{
            //    Header = _data.GetType().Name;
            //}

            //OnDemandLoadingCommand = new DelegateCommand<TreeViewNode>(ExecuteOnDemandLoading, CanExecuteOnDemandLoading);
            OpenImportCommand = new DelegateCommand<ICR2WImport>(async (i) => await ExecuteOpenImport(i));

            this.WhenActivated((CompositeDisposable disposables) =>
            {


                if (SelectedChunk == null && Chunks.Count > 0)
                {
                    SelectedChunk = Chunks[0];
                    SelectedChunks.Add(Chunks[0]);
                }
            });


            //if (!Nodes.Contains(Chunks[0]))
            //{
            //    Nodes.Add(Chunks[0]);
            //    _nodePaths.Add(Chunks[0].RelativePath);
            //}
            //LookForReferences(Chunks[0]);


            Nodes.Add(new CNameWrapper(this, new ReferenceSocket(Chunks[0].RelativePath)));
            _nodePaths.Add(Chunks[0].RelativePath);

            //var refCopy = References.ToList();

            //foreach (var reference in refCopy)
            //{
            //    if (Nodes.Where(x => x is ChunkViewModel cvm && cvm.RelativePath == reference.Input.File).Count() == 0)
            //    {
            //        var cr2w = File.GetFileFromDepotPathOrCache(reference.Input.File);
            //        if (cr2w != null && cr2w.RootChunk != null)
            //        {
            //            var chunk = new ChunkViewModel(cr2w.RootChunk, reference.Input);
            //            Nodes.Add(chunk);
            //            LookForReferences(chunk, cr2w.RootChunk);
            //        }
            //    }
            //}

            //refCopy = References.ToList();

            //foreach (var reference in refCopy)
            //{
            //    if (Nodes.Where(x => x is ChunkViewModel cvm && cvm.RelativePath == reference.Input.File).Count() == 0)
            //    {
            //        var cr2w = File.GetFileFromDepotPathOrCache(reference.Input.File);
            //        if (cr2w != null && cr2w.RootChunk != null)
            //        {
            //            var chunk = new ChunkViewModel(cr2w.RootChunk, reference.Input);
            //            Nodes.Add(chunk);
            //            LookForReferences(chunk, cr2w.RootChunk);
            //        }
            //    }
            //}

            //RootChunk = Chunks[0];

            //if (Chunks != null)
            //{
            //    foreach (ChunkViewModel item in Chunks)
            //    {
            //        item.WhenAnyValue(x => x.IsDirty).Subscribe(x => IsDirty |= x);
            //    }
            //}
            //_file.WhenAnyValue(x => x).Subscribe(x => IsDirty |= true);
        }

        public IRedType GetData() => _data;
        public RDTDataViewModel(string header, IRedType data, RedDocumentViewModel file) : this(data, file) => Header = header;

        #region properties

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;


        private List<ChunkViewModel> _chunks = new();

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

        public virtual ChunkViewModel GenerateChunks() => new(_data, this);

        [ObservableProperty] private ChunkViewModel? _selectedChunk;

        [ObservableProperty] private ObservableCollection<ChunkViewModel> _selectedChunks = new ObservableCollection<ChunkViewModel>();


        [ObservableProperty] private ChunkViewModel? _rootChunk;

        [ObservableProperty] private ObservableCollection<object> _nodes = new();

        [ObservableProperty] private ObservableCollection<RedReference> _references = new();

        [ObservableProperty] private IRedRef? _selectedImport;

        public bool ShowReferenceGraph => _settingsManager.ShowReferenceGraph;

        public delegate void LayoutNodesDelegate();

        public LayoutNodesDelegate? LayoutNodes;

        private List<CName> _nodePaths = new();

        #endregion

        #region commands
        /*
        public ICommand OnDemandLoadingCommand { get; private set; }

        private bool CanExecuteOnDemandLoading(TreeViewNode node) => node.Content is GroupedChunkViewModel || (node.Content is ChunkViewModel cvm && cvm.HasChildren());

        private void ExecuteOnDemandLoading(TreeViewNode node)
        {
            if (node.ChildNodes.Count > 0)
            {
                node.IsExpanded = true;
                return;
            }

            node.ShowExpanderAnimation = true;

            if (node.Content is GroupedChunkViewModel gcvm)
            {
                Application.Current.MainWindow.Dispatcher.BeginInvoke(DispatcherPriority.Background,
                    new Action(() =>
                    {
                        node.PopulateChildNodes(gcvm.TVProperties);
                        if (gcvm.TVProperties.Count > 0)
                        {
                            node.IsExpanded = true;
                        }

                        node.ShowExpanderAnimation = false;
                    }));
            }

            if (node.Content is ChunkViewModel cvm)
            {
                Application.Current.MainWindow.Dispatcher.BeginInvoke(DispatcherPriority.Background,
                    new Action(() =>
                    {
                        cvm.CalculateProperties();
                        node.PopulateChildNodes(cvm.TVProperties);
                        if (cvm.TVProperties.Count > 0)
                        {
                            node.IsExpanded = true;
                        }

                        node.ShowExpanderAnimation = false;
                    }));
            }
        }
        */

        public ICommand OpenImportCommand { get; private set; }
        private Task ExecuteOpenImport(ICR2WImport input)
        {
            var depotpath = input.DepotPath;
            var key = FNV1A64HashAlgorithm.HashString(depotpath);

            var _gameController = Locator.Current.GetService<IGameControllerFactory>().NotNull();
            return _gameController.GetController().AddFileToModModal(key);
        }

        //public ICommand ExportChunkCommand { get; private set; }
        //private bool CanExportChunk(ChunkViewModel cvm) => cvm.Properties.Count > 0;
        //private void ExecuteExportChunk(ChunkViewModel cvm)
        //{
        //    Stream myStream;
        //    var saveFileDialog = new SaveFileDialog();

        //    saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
        //    saveFileDialog.FilterIndex = 2;
        //    saveFileDialog.FileName = cvm.Type + ".json";
        //    saveFileDialog.RestoreDirectory = true;

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        if ((myStream = saveFileDialog.OpenFile()) != null)
        //        {
        //            var dto = new RedClassDto(cvm.Data);
        //            var json = JsonConvert.SerializeObject(dto, Formatting.Indented);

        //            if (string.IsNullOrEmpty(json))
        //            {
        //                throw new SerializationException();
        //            }

        //            myStream.Write(json.ToCharArray().Select(c => (byte)c).ToArray());
        //            myStream.Close();
        //        }
        //    }
        //}

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
                    if (reference.Destination.File != CName.Empty)
                    {
                        Nodes.Add(new CNameWrapper(this, reference.Destination));
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
                    var res = (IRedRef)data.GetProperty(pi.RedName);
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

        //public Red4File GetFile() => _file;
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
            //        Locator.Current.GetService<ILoggerService>().NotNull().Error(ex);
            //    }
            //}
        }
        #endregion
    }

    public partial class RedReference : ObservableObject, INodeConnection<ReferenceSocket>
    {
        [ObservableProperty] private RDTDataViewModel _graph;

        [ObservableProperty] private ReferenceSocket _destination;

        [ObservableProperty] private ReferenceSocket _source;

        public RedReference(RDTDataViewModel graph, ReferenceSocket source, ReferenceSocket destination)
        {
            _graph = graph;
            _source = source;
            _destination = destination;
        }

        //public ConnectionViewModel(RDTGraphViewModel graph, graphGraphConnectionDefinition connection)
        //{
        //    Graph = graph;
        //    Input = Graph.SocketLookup[connection.Source.Chunk.GetHashCode()];
        //    Input.Connections.Add(this);
        //    Output = Graph.SocketLookup[connection.Destination.Chunk.GetHashCode()];
        //    Output.Connections.Add(this);
        //}
    }

    public partial class ReferenceSocket : ObservableObject, INodeSocket<WolvenKit.Functionality.Interfaces.INode>
    {
        public WolvenKit.Functionality.Interfaces.INode? Node { get; set; }

        [ObservableProperty] private CName _file;

        [ObservableProperty] private string _property = "";

        [ObservableProperty] private System.Windows.Point _anchor;

        [ObservableProperty] private bool _isConnected;

        [ObservableProperty] private string _type = "";

        public ReferenceSocket(CName file, string property = "", string type = "")
        {
            _file = file;
            _property = property;
            _type = type;
        }
    }
}
