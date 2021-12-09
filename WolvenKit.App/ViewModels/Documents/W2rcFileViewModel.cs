using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
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

namespace WolvenKit.ViewModels.Documents
{
    public class W2rcFileViewModel : RedDocumentItemViewModel
    {
        private readonly Red4File _file;

        public W2rcFileViewModel(Red4File file)
        {

            OpenImportCommand = new DelegateCommand<ICR2WImport>(ExecuteOpenImport);

            //this.WhenAnyValue(x => x.SelectedChunk).Subscribe(chunk =>
            //{
            //    //if (chunk != null)
            //    //{
            //    //    ChunkProperties = new ObservableCollection<ChunkPropertyViewModel>(
            //    //        SelectedChunk.GetData()
            //    //            .ChildrEditableVariables
            //    //            .Select(x => new ChunkPropertyViewModel(x)));

            //    //}
            //});
            _file = file;
        }

        #region properties

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

        //[Reactive] public ObservableCollection<ChunkPropertyViewModel> ChunkProperties { get; set; } = new();

        public IReadOnlyList<IRedRef> Imports => _file is CR2WFile cr2w ? cr2w.Imports : new ReadOnlyCollection<IRedRef>(new List<IRedRef>());

        //public List<ICR2WBuffer> Buffers => _file.Buffers;

        public List<ChunkViewModel> Chunks => _file.Chunks
            //.Where(_ => _.VirtualParentChunk == null)
            .Select(_ => new ChunkViewModel(_)).ToList();

        [Reactive] public ChunkViewModel SelectedChunk { get; set; }

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

        #endregion

        #region methods

        public Red4File GetFile() => _file;

        public override string ToString() => "Main File";

        #endregion
    }
}
