using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Shell;

public class GroupedChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
{
    private bool _isLoaded;

    public string Name { get; }
    public ObservableCollection<ChunkViewModel> TVProperties { get; }

    public GroupedChunkViewModel(string range, IEnumerable<ChunkViewModel> chunkViewModels)
    {
        Name = range;
        TVProperties = new ObservableCollection<ChunkViewModel>(chunkViewModels);

        this.WhenAnyValue(x => x.IsExpanded)
            .Subscribe(OnExpand);
    }

    private void OnExpand(bool val)
    {
        if (val && !_isLoaded)
        {
            foreach (var cvm in TVProperties)
            {
                cvm.DoSubscribe();
            }

            _isLoaded = true;
        }
    }

    [Reactive] public bool IsExpanded { get; set; }
    [Reactive] public bool IsSelected { get; set; }
}
