using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Msagl.Core;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Layout.Layered;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using Syncfusion.UI.Xaml.TreeView.Engine;
using Syncfusion.Windows.Shared;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;
using Point = System.Windows.Point;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTGraphViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();

        protected readonly IRedType _data;

        public Dictionary<int, NodeViewModel> NodeLookup = new();

        public List<NodeViewModel> Nodes => NodeLookup.Values.ToList();

        public Dictionary<int, ConnectionViewModel> ConnectionLookup = new();

        public List<ConnectionViewModel> Connections => ConnectionLookup.Values.ToList();

        public Dictionary<int, SocketViewModel> SocketLookup = new();

        public List<SocketViewModel> Sockets => SocketLookup.Values.ToList();

        public PendingConnectionViewModel PendingConnection { get; }

        public RDTGraphViewModel(IRedType data, RedDocumentViewModel file)
        {
            File = file;
            _data = data;
            Header = "Graph Editor";

            PendingConnection = new PendingConnectionViewModel
            {
                Graph = this
            };

            if (data is graphGraphResource ggr)
            {
                RenderNodes(ggr.Graph.Chunk.Nodes);
            }
            else if (data is scnSceneResource ssr)
            {
                RenderNodes(ssr.SceneGraph.Chunk.Graph);
            }

            SelectedNodes.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems[0] is NodeViewModel fnvm)
                {
                    //SelectedChunk = new ChunkViewModel(fnvm.RedNode, (RDTDataViewModel)File.TabItemViewModels[0]);
                }
            };

            CreateConnectionCommand = new DelegateCommand(x => { });
        }

        public GeometryGraph RenderNodes(CArray<CHandle<scnSceneGraphNode>> nodes)
        {
            var graph = new GeometryGraph();

            //foreach (var node in nodes)
            //{
            //    node.Chunk.OutputSockets
            //}

            return graph;
        }

        public GeometryGraph RenderNodes(CArray<CHandle<graphGraphNodeDefinition>> nodes, graphGraphNodeDefinition parent = null)
        {
            var graph = new GeometryGraph();
            var connections = new Dictionary<int, graphGraphConnectionDefinition>();
            var msaglNodes = new Dictionary<int, Microsoft.Msagl.Core.Layout.Node>();
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
                    nvm = new PhaseNodeViewModel(this, node.Chunk)
                    {
                        Width = subgraph.BoundingBox.Size.Width + 40,
                        Height = subgraph.BoundingBox.Size.Height + 40,
                        GeoGraph = subgraph
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
                var msaglNode = new Microsoft.Msagl.Core.Layout.Node(
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

        public ChunkViewModel SelectedChunk { get; set; }

        public ICommand CreateConnectionCommand { get; set; }
    }

    public class PendingConnectionViewModel : ReactiveObject
    {
        [Reactive] public RDTGraphViewModel Graph { get; set; }

        [Reactive] public SocketViewModel Source { get; set; }

        [Reactive] public object PreviewTarget { get; set; }

        [Reactive] public string PreviewText { get; set; } = "Drop on connector";

        //protected virtual void OnPreviewTargetChanged()
        //{
        //    bool canConnect = PreviewTarget != null && Graph.Schema.CanAddConnection(Source!, PreviewTarget);
        //    PreviewText = PreviewTarget switch
        //    {
        //        SocketViewModel con when con == Source => $"Can't connect to self",
        //        SocketViewModel con => $"{(canConnect ? "Connect" : "Can't connect")} to {con.Title ?? "pin"}",
        //        NodeViewModel flow => $"{(canConnect ? "Connect" : "Can't connect")} to {flow.Title ?? "node"}",
        //        _ => $"Drop on connector"
        //    };
        //}
    }

    public class NodeViewModel : ReactiveObject, INode<SocketViewModel>
    {
        [Reactive] public RDTGraphViewModel Graph { get; set; }

        [Reactive] public Point Location { get; set; }

        [Reactive] public bool IsSelected { get; set; }

        public string Header { get; set; }
        public Dictionary<string, string> Details { get; set; } = new();
        public string Footer { get; set; }

        public IList<SocketViewModel> Inputs { get; set; } = new ObservableCollection<SocketViewModel>();
        public IList<SocketViewModel> Outputs { get; set; } = new ObservableCollection<SocketViewModel>();

        public graphGraphNodeDefinition RedNode { get; set; }

        public NodeViewModel()
        {
            ((ObservableCollection<SocketViewModel>)Inputs).CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (SocketViewModel item in e.NewItems)
                    {
                        item.Node = this;
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (SocketViewModel item in e.OldItems)
                    {
                        item.Disconnect();
                    }
                }
            };
            ((ObservableCollection<SocketViewModel>)Outputs).CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (SocketViewModel item in e.NewItems)
                    {
                        item.Node = this;
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (SocketViewModel item in e.OldItems)
                    {
                        item.Disconnect();
                    }
                }
            };
        }

        public virtual Size GetSize()
        {
            var size = new Size(200, 0);
            if (Header != null)
            {
                size.Height += 23;
            }

            size.Height += Details.Count * 15;

            size.Height += Math.Max(Inputs.Count, Outputs.Count) * 19;

            if (Footer != null)
            {
                size.Height += 23;
            }
            return size;
        }

        private void SetupNode(graphGraphNodeDefinition node)
        {
            if (node is questInputNodeDefinition qind)
            {
                Header = qind.SocketName;
            }
            else if (node is questOutputNodeDefinition qond)
            {
                Header = qond.SocketName;
            }
            else if (node is questEventManagerNodeDefinition qemnd)
            {
                Header = qemnd.ManagerName;
            }
            else if (node is questCheckpointNodeDefinition qcpnd)
            {
                Header = qcpnd.DebugString;
            }
            else if (node is questPauseConditionNodeDefinition or questConditionNodeDefinition)
            {
                questIBaseCondition condition = null;
                if (node is questPauseConditionNodeDefinition qpcnd)
                {
                    Header = "Pause ";
                    condition = qpcnd.Condition.Chunk;
                }
                else if (node is questConditionNodeDefinition qcnd)
                {
                    Header = "";
                    condition = qcnd.Condition.Chunk;
                }

                if (condition is questTriggerCondition qtc)
                {
                    Header += "Trigger Condition";
                    Details["Trigger Area"] = qtc.TriggerAreaRef;
                    Details["Type"] = qtc.Type.ToEnumString();
                }
                else if (condition is questObjectCondition qoc)
                {
                    Header += "Object Condition";
                    if (qoc.Type.Chunk is questDevice_ConditionType qdct)
                    {
                        Details["Object"] = qdct.ObjectRef;
                        Details["Class"] = qdct.DeviceControllerClass;
                        Details["Function"] = qdct.DeviceConditionFunction;
                    }
                }
                else if (condition is questFactsDBCondition qfc)
                {
                    Header += "FactsDB Condition";
                    if (qfc.Type.Chunk is questVarComparison_ConditionType qvc)
                    {
                        Header += " - Compare";
                        Details["Name"] = qvc.FactName;
                        Details["Comparison"] = qvc.ComparisonType.ToEnumString();
                        Details["Value"] = qvc.Value.ToString();
                    }
                }
                else if (condition is questSpawnerCondition qsc)
                {
                    Header += "Spawner Condition";
                    if (qsc.Type.Chunk is questSpawnerReady_ConditionType qsrct)
                    {
                        Header += " - Is Ready";
                        Details["Reference"] = qsrct.SpawnerReference;
                    }
                }
                else if (condition is questCharacterCondition qcc)
                {
                    Header += "Character Condition";
                    if (qcc.Type.Chunk is questCharacterMount_ConditionType qcmct)
                    {
                        Header += " - Is Mounted";
                        Details["Parent Ref"] = qcmct.ParentRef.Reference;
                    }
                }
                else
                {
                    Header += "Condition";
                }
            }
            else if (node is questSpawnManagerNodeDefinition qsmnd)
            {
                Header = "Spawn Manager";
                foreach (var action in qsmnd.Actions)
                {
                    Header += " - " + action.Type.Chunk.Action.ToEnumString();
                }
            }
            else if (node is questFactsDBManagerNodeDefinition qfmnd)
            {
                Header = "FactsDB Manager";
                if (qfmnd.Type.Chunk is questSetVar_NodeType qsvnt)
                {
                    Header += " - Set";
                    Details["Name"] = qsvnt.FactName;
                    Details["Value"] = qsvnt.Value.ToString();
                }
            }
            else
            {
                Header = node.GetType().Name.Replace("quest", "").Replace("NodeDefinition", "");
            }

            Footer = node.GetType().Name;
            if (node is questNodeDefinition qnd)
            {
                Footer += $" [{qnd.Id}]";
            }
        }

        public NodeViewModel(RDTGraphViewModel graph, graphGraphNodeDefinition node) : this()
        {
            Graph = graph;
            RedNode = node;

            SetupNode(node);

            foreach (var socket in node.Sockets)
            {
                var svm = new SocketViewModel(socket.Chunk);

                bool isInput;
                if (socket.Chunk is questSocketDefinition qsd)
                {
                    isInput = qsd.Type == Enums.questSocketType.Input || qsd.Type == Enums.questSocketType.CutDestination;
                    if (qsd.Type == Enums.questSocketType.CutDestination || qsd.Type == Enums.questSocketType.CutSource)
                    {
                        svm.Color = WkitBrushes.Purple;
                    }
                }
                else
                {
                    isInput = socket.Chunk.Name.ToString().Contains("In") || socket.Chunk.Name.ToString().Contains("Source");
                }
                if (isInput)
                {
                    Inputs.Add(svm);
                }
                else
                {
                    Outputs.Add(svm);
                }
                Graph.SocketLookup.Add(socket.Chunk.GetHashCode(), svm);
            }
        }

        public void Disconnect()
        {
            Inputs.Clear();
            Outputs.Clear();
        }
    }

    public class PhaseNodeViewModel : NodeViewModel
    {
        public GeometryGraph GeoGraph { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public PhaseNodeViewModel(RDTGraphViewModel graph, graphGraphNodeDefinition node) : base()
        {
            Graph = graph;
            RedNode = node;

            if (node is questNodeDefinition qnd)
            {
                Header = $"Phase [{qnd.Id}]";
            }
        }

        public override Size GetSize() => new(Width, Height);
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

    public class SocketViewModel : ReactiveObject, INodeSocket
    {
        [Reactive] public string Title { get; set; }

        [Reactive] public bool IsConnected { get; set; }

        [Reactive] public Point Anchor { get; set; }

        [Reactive] public NodeViewModel Node { get; set; }

        [Reactive] public ConnectorShape Shape { get; set; }

        [Reactive] public Brush Color { get; set; } = WkitBrushes.Cyan;

        public ConnectorFlow Flow { get; private set; }

        public int MaxConnections { get; set; } = 10;

        public ObservableCollection<ConnectionViewModel> Connections { get; } = new();

        public SocketViewModel()
        {
            Connections.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
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
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (ConnectionViewModel item in e.OldItems)
                    {
                        if (item.Source.Connections.Count == 0)
                        {
                            item.Source.IsConnected = false;
                        }
                        if (item.Destination.Connections.Count == 0)
                        {
                            item.Destination.IsConnected = false;
                        }
                    }
                }
            };
        }

        public SocketViewModel(graphGraphSocketDefinition socket) : this() => Title = socket.Name;

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

    public class ConnectionViewModel : ReactiveObject, INodeConnection<SocketViewModel>
    {
        [Reactive] public RDTGraphViewModel Graph { get; set; }

        [Reactive] public SocketViewModel Destination { get; set; }

        [Reactive] public SocketViewModel Source { get; set; }

        public ConnectionViewModel(RDTGraphViewModel graph, graphGraphConnectionDefinition connection)
        {
            Graph = graph;
            var hash = connection.Destination.Chunk.GetHashCode();

            if (Graph.SocketLookup.ContainsKey(hash))
            {
                Destination = Graph.SocketLookup[connection.Destination.Chunk.GetHashCode()];
                Destination.Connections.Add(this);
                Source = Graph.SocketLookup[connection.Source.Chunk.GetHashCode()];
                Source.Connections.Add(this);
            }
            else
            {
                // TODO why is this happening?
            }
        }

        public void Split(Point point) { }
        //    => Graph.Schema.SplitConnection(this, point);

        public void Remove() { }
        //=> Graph.Connections.Remove(this);
    }

    public static class NodeViewModelExtensions
    {
        public static System.Windows.Rect GetBoundingBox(this IList<NodeViewModel> nodes, double padding = 0, int gridCellSize = 15)
        {
            var minX = double.MaxValue;
            var minY = double.MaxValue;

            var maxX = double.MinValue;
            var maxY = double.MinValue;

            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                var width = 200;    //node.Width
                var height = 200;   //node.Height

                if (node.Location.X < minX)
                {
                    minX = node.Location.X;
                }

                if (node.Location.Y < minY)
                {
                    minY = node.Location.Y;
                }

                var sizeX = node.Location.X + width;
                if (sizeX > maxX)
                {
                    maxX = sizeX;
                }

                var sizeY = node.Location.Y + height;
                if (sizeY > maxY)
                {
                    maxY = sizeY;
                }
            }

            var result = new System.Windows.Rect(minX - padding, minY - padding, maxX - minX + padding * 2, maxY - minY + padding * 2);
            result.X = (int)result.X / gridCellSize * gridCellSize;
            result.Y = (int)result.Y / gridCellSize * gridCellSize;
            return result;
        }

        public static void AddRange<T>(this ICollection<T> col, IEnumerable<T> items)
        {
            if (items is IList<T> itemsCol)
            {
                for (var i = 0; i < itemsCol.Count; i++)
                {
                    col.Add(itemsCol[i]);
                }
            }
            else if (items is T[] itemsArr)
            {
                for (var i = 0; i < itemsArr.Length; i++)
                {
                    col.Add(itemsArr[i]);
                }
            }
            else
            {
                foreach (var item in items)
                {
                    col.Add(item);
                }
            }
        }
    }
}
