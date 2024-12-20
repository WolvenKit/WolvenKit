using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels.Shell;

public partial class GroupedChunkViewModel : ObservableObject, ISelectableTreeViewItemModel
{
    //public string Name { get; }
    public string DisplayName { get; }
    //public List<ChunkViewModel> TVProperties { get; }

    public GroupedChunkViewModel(string range)
    {
        //Name = range;
        DisplayName = range;
        //TVProperties = new List<ChunkViewModel>(chunkViewModels);
    }

    [ObservableProperty] private bool _isExpanded;
    [ObservableProperty] private bool _isSelected;
}
