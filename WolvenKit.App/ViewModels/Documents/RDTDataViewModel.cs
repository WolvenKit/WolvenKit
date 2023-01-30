using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Documents
{

    public partial class RDTDataViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {

        public ViewModelActivator Activator { get; } = new();

        protected IRedType _data;

        public bool IsEmbeddedFile { get; set; }

        public RDTDataViewModel(IRedType data, RedDocumentViewModel parent) : base(parent, data.GetType().Name)
        {
           

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

        [RelayCommand]
        private Task OpenImport(ICR2WImport input)
        {
            var depotpath = input.DepotPath;
            var key = FNV1A64HashAlgorithm.HashString(depotpath);
            
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
            //        _loggerService.Error(ex);
            //    }
            //}
        }
        #endregion
    }
}
