using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
    {
        private readonly IRedType _data;

        #region Constructors

        public ChunkViewModel(IRedType export)
        {
            _data = export;
            Name = _data.GetType().Name;
        }

        #endregion Constructors

        #region Properties

        public IRedType Data => _data;

        [Reactive] public bool IsSelected { get; set; }

        [Reactive] public bool IsExpanded { get; set; }

        public string Name { get; }

        #endregion Properties
    }
}
