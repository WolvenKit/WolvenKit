using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels.Shell;

public class GroupedChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
{
    public string Name { get; }
    public ObservableCollection<ChunkViewModel> TVProperties { get; }

    public GroupedChunkViewModel(string range, IEnumerable<ChunkViewModel> chunkViewModels)
    {
        Name = range;
        TVProperties = new ObservableCollection<ChunkViewModel>(chunkViewModels);
    }

    [Reactive] public bool IsExpanded { get; set; }
    [Reactive] public bool IsSelected { get; set; }
}
