using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using Syncfusion.UI.Xaml.TreeView.Engine;
using Syncfusion.Windows.Shared;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Models;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;
using YamlDotNet.Serialization;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTDataViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();

        protected IRedType _data;

        public bool IsEmbeddedFile { get; set; }

        public RDTDataViewModel(IRedType data, RedDocumentViewModel file)
        {
            File = file;
            _data = data;

            // set header
            if (data is null && file is TweakXLDocumentViewModel)
            {
                var ext = Path.GetExtension(file.FilePath).ToLower();
                Header = ext switch
                {
                    ".yaml" => "TweakXL",
                    ".yml" => "TweakXL",
                    ".xl" => "TweakXL",
                    _ => throw new NotImplementedException(),
                };
            }
            else
            {
                Header = _data.GetType().Name;
            }

            this.WhenActivated((CompositeDisposable disposables) =>
            {
                OnDemandLoadingCommand = new DelegateCommand<TreeViewNode>(ExecuteOnDemandLoading, CanExecuteOnDemandLoading);
                OpenImportCommand = new DelegateCommand<ICR2WImport>(async (i) => await ExecuteOpenImport(i));

                if (SelectedChunk == null && Chunks.Count > 0)
                {
                    SelectedChunk = Chunks[0];
                    SelectedChunks.Add(Chunks[0]);
                }
            });
        }

        public IRedType GetData()
        {
            return _data;
        }

        public RDTDataViewModel(string header, IRedType data, RedDocumentViewModel file) : this(data, file) => Header = header;

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;


        private List<ChunkViewModel> _chunks;

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

        [Reactive] public ChunkViewModel SelectedChunk { get; set; }

        [Reactive] public ObservableCollection<ChunkViewModel> SelectedChunks { get; set; } = new ObservableCollection<ChunkViewModel>();


        [Reactive] public ChunkViewModel RootChunk { get; set; }

        [Reactive] public IRedRef SelectedImport { get; set; }

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

        public ICommand OpenImportCommand { get; private set; }
        private Task ExecuteOpenImport(ICR2WImport input)
        {
            var depotpath = input.DepotPath;
            var key = FNV1A64HashAlgorithm.HashString(depotpath);

            var _gameController = Locator.Current.GetService<IGameControllerFactory>();
            return _gameController.GetController().AddFileToModModal(key);
        }
        public override void OnSelected()
        {
            // if tweak file, deserialize from text
            // read tweakXL file
            if (File is TweakXLDocumentViewModel tweakFile)
            {
                try
                {
                    // get text tab
                    var tab = tweakFile.TabItemViewModels.OfType<RDTTextViewModel>().FirstOrDefault();
                    var text = tab.GetText();

                    using var reader = new StringReader(text);
                    var deserializer = new DeserializerBuilder()
                        .WithTypeConverter(new TweakXLYamlTypeConverter())
                        .Build();
                    var file = deserializer.Deserialize<TweakXLFile>(reader);
                    _data = file;
                    // refresh
                    _chunks = null;
                    _ = Chunks;
                }
                catch (Exception ex)
                {
                    Locator.Current.GetService<ILoggerService>().Error(ex);
                }
            }
        }
    }
}
