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
using System.Windows.Threading;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using Syncfusion.UI.Xaml.TreeView.Engine;
using Syncfusion.Windows.Shared;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Functionality.Controllers;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;
using Microsoft.Msagl.Core;
using Microsoft.Msagl.Layout.Layered;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTGraphViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();

        protected readonly IRedType _data;

        public Dictionary<int, FlowNodeViewModel> NodeLookup = new();

        public List<FlowNodeViewModel> Nodes => NodeLookup.Values.ToList();

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

            SelectedNodes.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems[0] is FlowNodeViewModel fnvm)
                {
                    //SelectedChunk = new ChunkViewModel(fnvm.RedNode, (RDTDataViewModel)File.TabItemViewModels[0]);
                }
            };

            CreateConnectionCommand = new DelegateCommand(x => { });
        }

        public void RenderNodes(CArray<CHandle<graphGraphNodeDefinition>> nodes)
        {
            var graph = new GeometryGraph();
            var connections = new Dictionary<int, graphGraphConnectionDefinition>();
            var msaglNodes = new Dictionary<int, Microsoft.Msagl.Core.Layout.Node>();
            var socketNodeLookup = new Dictionary<int, int>();
            foreach (var node in nodes)
            {
                byte inputs = 0, outputs = 0;
                float width = 200, height = 200;

                foreach (var socket in node.Chunk.Sockets)
                {
                    var isInput = false;
                    if (socket.Chunk is questSocketDefinition qsd)
                    {
                        isInput = qsd.Type.Value == Enums.questSocketType.Input;
                    }
                    else
                    {
                        isInput = socket.Chunk.Name.ToString().Contains("In") || socket.Chunk.Name.ToString().Contains("Source");
                    }
                    if (isInput)
                    {
                        inputs++;
                    }
                    else
                    {
                        outputs++;
                    }

                    socketNodeLookup.Add(socket.Chunk.GetHashCode(), node.Chunk.GetHashCode());
                    foreach (var connection in socket.Chunk.Connections)
                    {
                        if (!connections.ContainsKey(connection.Chunk.GetHashCode()))
                        {
                            connections.Add(connection.Chunk.GetHashCode(), connection.Chunk);
                        }
                    }
                }
                height = Math.Max(inputs, outputs) * 20 + 40;
                var fnvm = new FlowNodeViewModel(this, node.Chunk)
                {
                    Location = new System.Windows.Point(-width /2, -height/2)
                };
                NodeLookup.Add(node.Chunk.GetHashCode(), fnvm);
                var msaglNode = new Microsoft.Msagl.Core.Layout.Node(
                    CurveFactory.CreateRectangle(width, height, new Microsoft.Msagl.Core.Geometry.Point()))
                {
                    //DebugId = node.Chunk.GetHashCode(),
                    UserData = node.Chunk.GetHashCode()
                    //UserData = NodeLookup[node.Chunk.GetHashCode()]
                };
                msaglNodes.Add(node.Chunk.GetHashCode(), msaglNode);
                graph.Nodes.Add(msaglNode);

                //if (node.Chunk is questPhaseNodeDefinition qpnd && qpnd.PhaseGraph != null)
                //{
                //    RenderNodes(qpnd.PhaseGraph.Chunk.Nodes);
                //}
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

            foreach (var node in graph.Nodes)
            {
                var oldLocation = NodeLookup[(int)node.UserData].Location;
                NodeLookup[(int)node.UserData].Location = new System.Windows.Point(oldLocation.X + node.Center.X, oldLocation.Y + node.Center.Y);
                //((FlowNodeViewModel)node.UserData).Location = new System.Windows.Point(node.Center.X, node.Center.Y);
            }
            Location = new System.Windows.Point(graph.BoundingBox.Center.X, graph.BoundingBox.Center.Y);
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

        public string GraphText { get; set; } = "";

        public System.Windows.Point Location { get; set; }

        public ObservableCollection<FlowNodeViewModel> SelectedNodes { get; set; } = new();

        public ChunkViewModel SelectedChunk { get; set; }

        public ICommand CreateConnectionCommand { get; set; }
    }

    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isDirty;
        public bool IsDirty
        {
            get => _isDirty;
            protected set
            {
                if (_isDirty != value)
                {
                    _isDirty = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool SetProperty<T>(ref T reference, T value, [CallerMemberName] in string propertyName = default!)
        {
            if (!Equals(reference, value))
            {
                reference = value;
                IsDirty = true;
                OnPropertyChanged(propertyName);
                return true;
            }

            return false;
        }

        protected void OnPropertyChanged([CallerMemberName] in string propertyName = default)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class PendingConnectionViewModel : ObservableObject
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
        //        FlowNodeViewModel flow => $"{(canConnect ? "Connect" : "Can't connect")} to {flow.Title ?? "node"}",
        //        _ => $"Drop on connector"
        //    };
        //}
    }

    public abstract class NodeViewModel : ObservableObject
    {
        [Reactive] public RDTGraphViewModel Graph { get; set; }

        private System.Windows.Point _location;
        public System.Windows.Point Location
        {
            get => _location;
            set => SetProperty(ref _location, value);
        }

    }

    public class FlowNodeViewModel : NodeViewModel
    {
        public string Header { get; set; }
        public string Footer { get; set; }

        public ObservableCollection<SocketViewModel> Input { get; } = new();
        public ObservableCollection<SocketViewModel> Output { get; } = new();

        public graphGraphNodeDefinition RedNode { get; set; }

        public FlowNodeViewModel()
        {
            //Input.WhenAdded(c => c.Node = this)
            //     .WhenRemoved(c => c.Disconnect());

            //Output.WhenAdded(c => c.Node = this)
            //     .WhenRemoved(c => c.Disconnect());

            Input.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
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
            Output.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
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

        private void SetupNode(graphGraphNodeDefinition node)
        {
            if (node is questInputNodeDefinition qind)
            {
                Header = qind.SocketName;
            }
            else if (node is questCheckpointNodeDefinition qcnd)
            {
                Header = qcnd.DebugString;
            }
            else
            {
                Header = node.GetType().Name.Replace("quest", "").Replace("NodeDefinition", "");
            }

            Footer = node.GetType().Name;
        }

        public FlowNodeViewModel(RDTGraphViewModel graph, graphGraphNodeDefinition node) : this()
        {
            Graph = graph;
            RedNode = node;

            SetupNode(node);

            foreach (var socket in node.Sockets)
            {
                //if (!Graph.SocketLookup.ContainsKey(socket.Chunk.GetHashCode()))
                //{
                var svm = new SocketViewModel(socket.Chunk);

                var isInput = false;
                if (socket.Chunk is questSocketDefinition qsd)
                {
                    isInput = qsd.Type.Value == Enums.questSocketType.Input;
                }
                else
                {
                    isInput = socket.Chunk.Name.ToString().Contains("In") || socket.Chunk.Name.ToString().Contains("Source");
                }
                if (isInput)
                {
                    Input.Add(svm);
                }
                else
                {
                    Output.Add(svm);
                }
                Graph.SocketLookup.Add(socket.Chunk.GetHashCode(), svm);
                //}
            }
        }

        public void Disconnect()
        {
            Input.Clear();
            Output.Clear();
        }
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

    public class SocketViewModel : ObservableObject
    {
        [Reactive] public string Title { get; set; }

        [Reactive] public bool IsConnected { get; set; }

        private System.Windows.Point _anchor;
        public System.Windows.Point Anchor
        {
            get => _anchor;
            set => SetProperty(ref _anchor, value);
        }

        [Reactive] public NodeViewModel Node { get; set; }

        [Reactive] public ConnectorShape Shape { get; set; }

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
                        if (item.Input != null)
                        {
                            item.Input.IsConnected = true;
                        }
                        if (item.Output != null)
                        {
                            item.Output.IsConnected = true;
                        }
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (ConnectionViewModel item in e.OldItems)
                    {
                        if (item.Input.Connections.Count == 0)
                        {
                            item.Input.IsConnected = false;
                        }
                        if (item.Output.Connections.Count == 0)
                        {
                            item.Output.IsConnected = false;
                        }
                    }
                }
            };

            //Connections.WhenAdded(c =>
            //{
            //    c.Input.IsConnected = true;
            //    c.Output.IsConnected = true;
            //}).WhenRemoved(c =>
            //{
            //    if (c.Input.Connections.Count == 0)
            //    {
            //        c.Input.IsConnected = false;
            //    }

            //    if (c.Output.Connections.Count == 0)
            //    {
            //        c.Output.IsConnected = false;
            //    }
            //});
        }

        public SocketViewModel(graphGraphSocketDefinition socket) : this()
        {
            Title = socket.Name;
        }

        protected virtual void OnNodeChanged()
        {
            if (Node is FlowNodeViewModel flow)
            {
                Flow = flow.Input.Contains(this) ? ConnectorFlow.Input : ConnectorFlow.Output;
            }
            //else if (Node is KnotNodeViewModel knot)
            //{
            //    Flow = knot.Flow;
            //}
        }

        public bool IsConnectedTo(SocketViewModel con)
            => Connections.Any(c => c.Input == con || c.Output == con);

        public virtual bool AllowsNewConnections()
            => Connections.Count < MaxConnections;

        public void Disconnect() { }
        //    => Node.Graph.Schema.DisconnectConnector(this);
    }

    public class ConnectionViewModel : ObservableObject
    {
        [Reactive] public RDTGraphViewModel Graph { get; set; }

        [Reactive] public SocketViewModel Input { get; set; }

        [Reactive] public SocketViewModel Output { get; set; }

        public ConnectionViewModel(RDTGraphViewModel graph, graphGraphConnectionDefinition connection)
        {
            Graph = graph;
            Input = Graph.SocketLookup[connection.Source.Chunk.GetHashCode()];
            Input.Connections.Add(this);
            Output = Graph.SocketLookup[connection.Destination.Chunk.GetHashCode()];
            Output.Connections.Add(this);
        }

        public void Split(System.Windows.Point point) { }
        //    => Graph.Schema.SplitConnection(this, point);

        public void Remove() { }
        //=> Graph.Connections.Remove(this);
    }

    public static class NodeViewModelExtensions
    {
        public static System.Windows.Rect GetBoundingBox(this IList<NodeViewModel> nodes, double padding = 0, int gridCellSize = 15)
        {
            double minX = double.MaxValue;
            double minY = double.MaxValue;

            double maxX = double.MinValue;
            double maxY = double.MinValue;

            for (int i = 0; i < nodes.Count; i++)
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
                for (int i = 0; i < itemsCol.Count; i++)
                {
                    col.Add(itemsCol[i]);
                }
            }
            else if (items is T[] itemsArr)
            {
                for (int i = 0; i < itemsArr.Length; i++)
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
