using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.App.Models.Nodify;

public partial class RedReference : ObservableObject, INodeConnection<ReferenceSocket>
{
    //[ObservableProperty] private RDTDataViewModel _graph;

    [ObservableProperty] private ReferenceSocket _destination;

    [ObservableProperty] private ReferenceSocket _source;

    public RedReference(/*RDTDataViewModel graph, */ReferenceSocket source, ReferenceSocket destination)
    {
        //_graph = graph;
        _source = source;
        _destination = destination;
    }

    //public ConnectionViewModel(RDTGraphViewModel graph, graphGraphConnectionDefinition connection)
    //{
    //    Graph = graph;
    //    Input = Graph.SocketLookup[connection.Source.Chunk.GetHashCode()];
    //    Input.Connections.Add(this);
    //    Output = Graph.SocketLookup[connection.Destination.Chunk.GetHashCode()];
    //    Output.Connections.Add(this);
    //}
}
