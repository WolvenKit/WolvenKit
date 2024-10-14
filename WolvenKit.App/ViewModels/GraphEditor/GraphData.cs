using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Nodify;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class GraphData(string title, GraphContext context)
{
    public string Title { get; } = title;
    public NodeViewModel? Root { get; set; }
    public ObservableCollection<NodeViewModel> Nodes { get; } = [];
    public ObservableCollection<ConnectionViewModel> Connections { get; } = [];
    public PendingConnectionViewModel PendingConnection { get; } = new();
    public NodifyEditor? Editor { get; set; }
    public string StateParents { get; set; } = "";
    public GraphContext Context { get; } = context;

    public RelayCommand? ConnectCommand { get; set; }
    public RelayCommand<BaseConnectorViewModel>? DisconnectCommand { get; set; }
    public RelayCommand? ItemsDragCompletedCommand { get; set; }
}