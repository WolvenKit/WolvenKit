using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.Nodify;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.Documents;

public partial class SocketViewModel : ObservableObject, INodeSocket
{
    [ObservableProperty] private string _title;

    [ObservableProperty] private bool _isConnected;

    [ObservableProperty] private Point _anchor;

    [ObservableProperty] private NodeViewModel? _node;

    [ObservableProperty] private ConnectorShape _shape;

    [ObservableProperty] private Brush _color = WkitBrushes.Cyan;

    public ConnectorFlow Flow { get; private set; }

    public int MaxConnections { get; set; } = 10;

    public ObservableCollection<ConnectionViewModel> Connections { get; } = new();

    public SocketViewModel(string title)
    {
        _title = title;

        Connections.CollectionChanged += (sender, e) =>
        {
            if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems is not null)
            {
                foreach (ConnectionViewModel item in e.NewItems)
                {
                    // shouldn't this be conditional?
                    if (item.Source != null)
                    {
                        item.Source.IsConnected = true;
                    }
                    if (item.Destination != null)
                    {
                        item.Destination.IsConnected = true;
                    }
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove && e.OldItems is not null)
            {
                foreach (ConnectionViewModel item in e.OldItems)
                {
                    if (item.Source is not null && item.Source.Connections.Count == 0)
                    {
                        item.Source.IsConnected = false;
                    }
                    if (item.Destination is not null && item.Destination.Connections.Count == 0)
                    {
                        item.Destination.IsConnected = false;
                    }
                }
            }
        };
    }

    public SocketViewModel(graphGraphSocketDefinition socket) : this(socket.Name)
    {
    }

    protected virtual void OnNodeChanged()
    {
        if (Node is NodeViewModel flow)
        {
            Flow = flow.Inputs.Contains(this) ? ConnectorFlow.Input : ConnectorFlow.Output;
        }
        //else if (Node is KnotNodeViewModel knot)
        //{
        //    Flow = knot.Flow;
        //}
    }

    public bool IsConnectedTo(SocketViewModel con)
        => Connections.Any(c => c.Source == con || c.Destination == con);

    public virtual bool AllowsNewConnections()
        => Connections.Count < MaxConnections;

    public void Disconnect() { }
    //    => Node.Graph.Schema.DisconnectConnector(this);
}
