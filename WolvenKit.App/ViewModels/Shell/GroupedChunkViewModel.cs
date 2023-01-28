using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Shell;

public partial class GroupedChunkViewModel : ObservableObject, ISelectableTreeViewItemModel
{
    public string Name { get; }
    public ObservableCollection<ChunkViewModel> TVProperties { get; }

    public GroupedChunkViewModel(string range, IEnumerable<ChunkViewModel> chunkViewModels)
    {
        Name = range;
        TVProperties = new ObservableCollection<ChunkViewModel>(chunkViewModels);
    }

    [ObservableProperty] private bool _isExpanded;
    [ObservableProperty] private bool _isSelected;
}
