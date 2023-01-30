using System;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Nodify;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.Documents;

public partial class ConnectionViewModel : ObservableObject, INodeConnection<SocketViewModel>
{
    [ObservableProperty] private RDTGraphViewModel _graph;

    [ObservableProperty] private SocketViewModel _destination;

    [ObservableProperty] private SocketViewModel _source;

    public ConnectionViewModel(RDTGraphViewModel graph, graphGraphConnectionDefinition connection)
    {
        _graph = graph;
        var hash = connection.Destination.Chunk.GetHashCode();

        if (Graph.SocketLookup.ContainsKey(hash))
        {
            _destination = Graph.SocketLookup[connection.Destination.Chunk.GetHashCode()];
            Destination.Connections.Add(this);
            _source = Graph.SocketLookup[connection.Source.Chunk.GetHashCode()];
            Source.Connections.Add(this);
        }
        else
        {
            throw new NotImplementedException();
            // TODO why is this happening?
        }
    }

    public void Split(Point point) { }
    //    => Graph.Schema.SplitConnection(this, point);

    public void Remove() { }
    //=> Graph.Connections.Remove(this);
}
