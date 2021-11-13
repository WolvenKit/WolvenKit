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
    public class ChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
    {
        #region Fields

        private readonly ICR2WExport _export;

        #endregion Fields

        #region Constructors

        public ChunkViewModel(ICR2WExport export)
        {
            _export = export;
        }

        #endregion Constructors

        #region Properties

        public IEditableVariable GetData() => _export.Data;

        public IEditableVariable Data => _export.Data;

        public string Name => _export.REDName;

        [Reactive] public bool IsSelected { get; set; }

        [Reactive] public bool IsExpanded { get; set; }

        #endregion Properties
    }
}
