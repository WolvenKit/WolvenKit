using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Common.Conversion;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace WolvenKit.ViewModels.Documents
{
    public class W2rcFileViewModel : RedDocumentItemViewModel
    {
        protected readonly IRedClass _data;

        public RedDocumentViewModel File;

        public W2rcFileViewModel(IRedClass data, RedDocumentViewModel file)
        {

            OpenImportCommand = new DelegateCommand<ICR2WImport>(ExecuteOpenImport);
            //ExportChunkCommand = new DelegateCommand<ChunkViewModel>((p) => ExecuteExportChunk(p), (p) => CanExportChunk(p));

            File = file;
            _data = data;
            Header = _data.GetType().Name;

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
                    _chunks = new List<ChunkViewModel>();
                    _chunks.Add(GenerateChunks());
                }
                return _chunks;
            }
            set
            {
                _chunks = value;
            }
        }

        public virtual ChunkViewModel GenerateChunks()
        {
            return new ChunkViewModel(_data, this);
        }

        [Reactive] public ChunkViewModel SelectedChunk { get; set; }

        [Reactive] public ChunkViewModel RootChunk { get; set; }

        [Reactive] public IRedRef SelectedImport { get; set; }

        #endregion

        #region commands

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
