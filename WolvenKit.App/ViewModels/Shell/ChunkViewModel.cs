using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkViewModel : ISelectableTreeViewItemModel
    {
        #region Fields

        private readonly ICR2WExport _export;

        #endregion Fields

        #region Constructors

        public ChunkViewModel(ICR2WExport export)
        {
            _export = export;

            var disposable = Data.ChildrEditableVariables
                .AsObservableChangeSet()
                .Transform(_ => new ChunkPropertyViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _children)
                .Subscribe();
        }

        #endregion Constructors

        #region Properties

        public List<ChunkViewModel> Children => _export.VirtualChildrenChunks.Select(_ => new ChunkViewModel(_)).ToList();

        private readonly ReadOnlyObservableCollection<ChunkPropertyViewModel> _children;
        public ReadOnlyObservableCollection<ChunkPropertyViewModel> ChildrenProperties => _children;


        public IEditableVariable Data => _export.Data;

        public bool IsSelected { get; set; }
        public bool IsExpanded { get; set; }
        public string Name => _export.REDName;

        #endregion Properties
    }
}
