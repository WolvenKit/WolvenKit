using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Documents;

public partial class PendingConnectionViewModel : ObservableObject
{
    public PendingConnectionViewModel(RDTGraphViewModel graph) => _graph = graph;


    [ObservableProperty] private RDTGraphViewModel _graph;

    [ObservableProperty] private SocketViewModel? _source;

    [ObservableProperty] private object? _previewTarge;

    [ObservableProperty] private string _previewText = "Drop on connector";
}
