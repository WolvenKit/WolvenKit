using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using Syncfusion.UI.Xaml.TreeView.Engine;
using Syncfusion.Windows.Shared;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Functionality.Controllers;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTDataViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();

        protected readonly IRedType _data;

        public bool IsEmbeddedFile { get; set; }

        public RDTDataViewModel(IRedType data, RedDocumentViewModel file)
        {
            File = file;
            _data = data;
            Header = _data.GetType().Name;

            this.WhenActivated((CompositeDisposable disposables) =>
            {
                OnDemandLoadingCommand = new DelegateCommand<TreeViewNode>(ExecuteOnDemandLoading, CanExecuteOnDemandLoading);
                OpenImportCommand = new DelegateCommand<ICR2WImport>(ExecuteOpenImport);

                if (SelectedChunk == null)
                {
                    SelectedChunk = Chunks[0];
                    SelectedChunks.Add(Chunks[0]);
                }

                //ExportChunkCommand = new DelegateCommand<ChunkViewModel>((p) => ExecuteExportChunk(p), (p) => CanExportChunk(p));

                //this.HandleActivation()
            });

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

        public RedBaseClass GetData() => (RedBaseClass)_data;

        public RDTDataViewModel(string header, IRedType data, RedDocumentViewModel file) : this(data, file)
        {
            Header = header;
        }


        #region properties

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

        //[Reactive] public ObservableCollection<ChunkPropertyViewModel> ChunkProperties { get; set; } = new();

        //public IReadOnlyList<IRedRef> Imports => _file is CR2WFile cr2w ? cr2w.Imports : new ReadOnlyCollection<IRedRef>(new List<IRedRef>());

        //public List<ICR2WBuffer> Buffers => _file.Buffers;

        private List<ChunkViewModel> _chunks;

        public List<ChunkViewModel> Chunks
        {
            get
            {
                if (_chunks == null || _chunks.Count == 0)
                {
                    _chunks = new List<ChunkViewModel>
                    {
                        GenerateChunks()
                    };
                    //SelectedChunk = _chunks[0];
                }
                return _chunks;
            }
            set => _chunks = value;
        }

        public virtual ChunkViewModel GenerateChunks() => new(_data, this);

        [Reactive] public ChunkViewModel SelectedChunk { get; set; }

        [Reactive] public ObservableCollection<ChunkViewModel> SelectedChunks { get; set; } = new ObservableCollection<ChunkViewModel>();


        [Reactive] public ChunkViewModel RootChunk { get; set; }

        [Reactive] public IRedRef SelectedImport { get; set; }

        #endregion

        #region commands

        public ICommand OnDemandLoadingCommand { get; private set; }

        private bool CanExecuteOnDemandLoading(TreeViewNode node)
        {
            if (node.Content is GroupedChunkViewModel)
            {
                return true;
            }

            if (node.Content is ChunkViewModel cvm && cvm.HasChildren())
            {
                return true;
            }

            return false;
        }

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

        public ICommand OpenImportCommand { get; private set; }
        private void ExecuteOpenImport(ICR2WImport input)
        {
            var depotpath = input.DepotPath;
            var key = FNV1A64HashAlgorithm.HashString(depotpath);

            var _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            var _archiveManager = Locator.Current.GetService<IArchiveManager>();

            if (_archiveManager.Lookup(key).HasValue)
            {
                _gameControllerFactory.GetController().AddToMod(key);
            }
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

        //public Red4File GetFile() => _file;

        #endregion
    }
}
