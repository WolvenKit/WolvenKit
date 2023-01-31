using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Layout.Layered;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTGraphViewModel : RedDocumentTabViewModel
{
    public RDTGraphViewModel(IRedType data, RedDocumentViewModel file) : base(file, "Graph Editor")
    {
        _data = data;

        PendingConnection = new PendingConnectionViewModel(this);

        if (data is graphGraphResource ggr)
        {
            RenderNodes(ggr.Graph.Chunk.Nodes);
        }
        else if (data is scnSceneResource ssr)
        {
            RenderNodes(ssr.SceneGraph.Chunk.Graph);
        }

        //SelectedNodes.CollectionChanged += (object? sender, NotifyCollectionChangedEventArgs e) =>
        //{
        //    if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems is not null && e.NewItems[0] is NodeViewModel fnvm)
        //    {
        //        //SelectedChunk = new ChunkViewModel(fnvm.RedNode, (RDTDataViewModel)File.TabItemViewModels[0]);
        //    }
        //};
    }

    protected readonly IRedType _data;

    public Dictionary<int, NodeViewModel> NodeLookup = new();

    public List<NodeViewModel> Nodes => NodeLookup.Values.ToList();

    public Dictionary<int, ConnectionViewModel> ConnectionLookup = new();

    public List<ConnectionViewModel> Connections => ConnectionLookup.Values.ToList();

    public Dictionary<int, SocketViewModel> SocketLookup = new();

    public List<SocketViewModel> Sockets => SocketLookup.Values.ToList();

    public PendingConnectionViewModel PendingConnection { get; }

   
    public GeometryGraph RenderNodes(CArray<CHandle<scnSceneGraphNode>> nodes)
    {
        var graph = new GeometryGraph();

        //foreach (var node in nodes)
        //{
        //    node.Chunk.OutputSockets
        //}

        return graph;
    }

    [RelayCommand]
    private void CreateConnection()
    {

    }

    public GeometryGraph RenderNodes(CArray<CHandle<graphGraphNodeDefinition>> nodes, graphGraphNodeDefinition? parent = null)
    {
        var graph = new GeometryGraph();
        var connections = new Dictionary<int, graphGraphConnectionDefinition>();
        var msaglNodes = new Dictionary<int, Node>();
        var socketNodeLookup = new Dictionary<int, int>();
        foreach (var node in nodes)
        {
            foreach (var socket in node.Chunk.Sockets)
            {
                socketNodeLookup.Add(socket.Chunk.GetHashCode(), node.Chunk.GetHashCode());
                foreach (var connection in socket.Chunk.Connections)
                {
                    if (!connections.ContainsKey(connection.Chunk.GetHashCode()))
                    {
                        connections.Add(connection.Chunk.GetHashCode(), connection.Chunk);
                    }
                }
            }

            NodeViewModel nvm;

            // make input/output knots? or hooked-up to parent graph
            if (node.Chunk is questPhaseNodeDefinition qpnd && qpnd.PhaseGraph != null)
            {
                var subgraph = RenderNodes(qpnd.PhaseGraph.Chunk.Nodes, node.Chunk);
                nvm = new PhaseNodeViewModel(this, node.Chunk, subgraph)
                {
                    Width = subgraph.BoundingBox.Size.Width + 40,
                    Height = subgraph.BoundingBox.Size.Height + 40,
                };
            }
            else
            {
                nvm = new NodeViewModel(this, node.Chunk);
                if (parent != null)
                {
                    if (node.Chunk is questInputNodeDefinition input)
                    {
                        foreach (var socket in parent.Sockets)
                        {
                            if (socket.Chunk is questSocketDefinition socketDef && socketDef.Name == input.SocketName)
                            {
                                var svm = new SocketViewModel(socketDef);
                                nvm.Inputs.Add(svm);
                                SocketLookup.Add(socketDef.GetHashCode(), svm);
                            }
                        }
                    }
                    if (node.Chunk is questOutputNodeDefinition output)
                    {
                        foreach (var socket in parent.Sockets)
                        {
                            if (socket.Chunk is questSocketDefinition socketDef && socketDef.Name == output.SocketName)
                            {
                                var svm = new SocketViewModel(socketDef);
                                nvm.Outputs.Add(svm);
                                SocketLookup.Add(socketDef.GetHashCode(), svm);
                            }
                        }
                    }
                }
            }
            NodeLookup.Add(node.Chunk.GetHashCode(), nvm);
            var size = nvm.GetSize();
            var msaglNode = new Node(
                CurveFactory.CreateRectangle(size.Width, size.Height, new Microsoft.Msagl.Core.Geometry.Point()))
            {
                UserData = node.Chunk.GetHashCode()
            };
            msaglNodes.Add(node.Chunk.GetHashCode(), msaglNode);
            graph.Nodes.Add(msaglNode);
        }

        foreach (var (hash, connection) in connections)
        {
            ConnectionLookup.Add(hash, new ConnectionViewModel(this, connection));
            var source = socketNodeLookup[connection.Source.Chunk.GetHashCode()];
            var dest = socketNodeLookup[connection.Destination.Chunk.GetHashCode()];
            graph.Edges.Add(new Edge(msaglNodes[source], msaglNodes[dest]));
        }

        var settings = new SugiyamaLayoutSettings
        {
            Transformation = PlaneTransformation.Rotation(Math.PI / 2),
            EdgeRoutingSettings = { EdgeRoutingMode = EdgeRoutingMode.Spline }
        };
        var layout = new LayeredLayout(graph, settings);
        layout.Run();

        ArrangeNodes(graph);

        //Location = new Point(graph.BoundingBox.Center.X, graph.BoundingBox.Center.Y);

        return graph;
    }

    private void ArrangeNodes(GeometryGraph graph, double xOffset = 0, double yOffset = 0)
    {
        foreach (var node in graph.Nodes)
        {
            var nvm = NodeLookup[(int)node.UserData];
            nvm.Location = new Point(
                node.Center.X - graph.BoundingBox.Center.X - nvm.GetSize().Width / 2 + xOffset,
                node.Center.Y - graph.BoundingBox.Center.Y - nvm.GetSize().Height / 2 + yOffset);
            if (nvm is PhaseNodeViewModel pnvm)
            {
                ArrangeNodes(pnvm.GeoGraph, node.Center.X - graph.BoundingBox.Center.X + xOffset, node.Center.Y - graph.BoundingBox.Center.Y + yOffset);
            }
        }
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

    public string GraphText { get; set; } = "";

    public Point Location { get; set; }

    public ObservableCollection<NodeViewModel> SelectedNodes { get; set; } = new();

    public ChunkViewModel? SelectedChunk { get; set; }
}

public enum ConnectorFlow
{
    Input,
    Output
}

public enum ConnectorShape
{
    Circle,
    Triangle,
    Square,
}
