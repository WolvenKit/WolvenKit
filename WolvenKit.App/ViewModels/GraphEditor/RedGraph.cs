using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Layout.Layered;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor;

public enum RedGraphType
{
    Invalid,
    Quest,
    Scene
}

public partial class RedGraph : IDisposable
{
    private IRedType _data;

    private uint _currentSceneNodeId;
    private ushort _currentQuestNodeId;

    public RedGraphType GraphType { get; } = RedGraphType.Invalid;

    public string Title { get; }
    public ObservableCollection<NodeViewModel> Nodes { get; } = new();
    public ObservableCollection<ConnectionViewModel> Connections { get; } = new();
    public PendingConnectionViewModel PendingConnection { get; }

    public ICommand ConnectCommand { get; }
    public ICommand DisconnectCommand { get; }

    public RedDocumentViewModel? DocumentViewModel { get; set; }

    private static ILoggerService? _loggerService;

    static RedGraph()
    {
        GenerateQuestWrapperMap();
    }

    public RedGraph(string title, IRedType data)
    {
        _data = data;
        if (_data is graphGraphDefinition)
        {
            GraphType = RedGraphType.Quest;
        }
        else if (_data is scnSceneResource)
        {
            GraphType = RedGraphType.Scene;
        }

        Title = title;
        PendingConnection = new PendingConnectionViewModel();

        ConnectCommand = new RelayCommand(Connect);
        DisconnectCommand = new RelayCommand<BaseConnectorViewModel>(Disconnect);

        _loggerService = Locator.Current.GetService<ILoggerService>();
    }

    public void Connect()
    {
        if (PendingConnection.Target is IDynamicInputNode dynIn)
        {
            PendingConnection.Target = dynIn.AddInput();
        }

        if (PendingConnection.Target is IDynamicOutputNode dynOut)
        {
            PendingConnection.Target = dynOut.AddOutput();
        }

        if (PendingConnection is { Source: OutputConnectorViewModel output1, Target: InputConnectorViewModel input1 })
        {
            if (GraphType == RedGraphType.Quest)
            {
                ConnectQuest((QuestOutputConnectorViewModel)output1, (QuestInputConnectorViewModel)input1);
            }

            if (GraphType == RedGraphType.Scene)
            {
                ConnectScene((SceneOutputConnectorViewModel)output1, (SceneInputConnectorViewModel)input1);
            }
        }

        if (PendingConnection is { Source: InputConnectorViewModel input2, Target: OutputConnectorViewModel output2 })
        {
            if (GraphType == RedGraphType.Quest)
            {
                ConnectQuest((QuestOutputConnectorViewModel)output2, (QuestInputConnectorViewModel)input2);
            }

            if (GraphType == RedGraphType.Scene)
            {
                ConnectScene((SceneOutputConnectorViewModel)output2, (SceneInputConnectorViewModel)input2);
            }
        }
    }

    private void Disconnect(BaseConnectorViewModel? baseConnectorViewModel)
    {
        if (baseConnectorViewModel is OutputConnectorViewModel outputConnector)
        {
            for (var i = Connections.Count - 1; i >= 0; i--)
            {
                if (Connections[i].Source == outputConnector)
                {
                    if (GraphType == RedGraphType.Quest)
                    {
                        RemoveQuestConnection((QuestConnectionViewModel)Connections[i]);
                    }

                    if (GraphType == RedGraphType.Scene)
                    {
                        RemoveSceneConnection((SceneConnectionViewModel)Connections[i]);
                    }
                }
            }
        }

        if (baseConnectorViewModel is InputConnectorViewModel inputConnector)
        {
            for (var i = Connections.Count - 1; i >= 0; i--)
            {
                if (Connections[i].Target == inputConnector)
                {
                    if (GraphType == RedGraphType.Quest)
                    {
                        RemoveQuestConnection((QuestConnectionViewModel)Connections[i]);
                    }

                    if (GraphType == RedGraphType.Scene)
                    {
                        RemoveSceneConnection((SceneConnectionViewModel)Connections[i]);
                    }
                }
            }
        }
    }

    public void RemoveNode(NodeViewModel node)
    {
        if (!Nodes.Contains(node))
        {
            return;
        }

        if (GraphType == RedGraphType.Scene && node is BaseSceneViewModel sceneNode)
        {
            RemoveSceneNode(sceneNode);
        }

        if (GraphType == RedGraphType.Quest && node is BaseQuestViewModel questNode)
        {
            RemoveQuestNode(questNode);
        }
    }

    public void RemoveNodes(IList<object> nodes)
    {
        var removableNodes = new List<NodeViewModel>();
        foreach (var node in nodes)
        {
            if (node is not NodeViewModel nvm)
            {
                throw new Exception();
            }

            removableNodes.Add(nvm);
        }

        foreach (var node in removableNodes)
        {
            RemoveNode(node);
        }
    }

    public void RecalculateSockets(IGraphProvider nodeViewModel)
    {
        if (nodeViewModel is BaseQuestViewModel)
        {
            RecalculateQuestSockets(nodeViewModel);
        }
    }

    public void ArrangeNodes(double xOffset = 0, double yOffset = 0)
    {
        var graph = new GeometryGraph();
        var msaglNodes = new Dictionary<uint, Node>();

        foreach (var node in Nodes)
        {
            var msaglNode = new Node(CurveFactory.CreateRectangle(node.Size.Width, node.Size.Height, new Microsoft.Msagl.Core.Geometry.Point()))
            {
                UserData = node
            };

            msaglNodes.Add(node.UniqueId, msaglNode);
            graph.Nodes.Add(msaglNode);
        }

        foreach (var connection in Connections.Reverse())
        {
            graph.Edges.Add(new Edge(msaglNodes[connection.Source.OwnerId], msaglNodes[connection.Target.OwnerId]));
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
            var nvm = (NodeViewModel)node.UserData;
            nvm.Location = new System.Windows.Point(
                node.Center.X - graph.BoundingBox.Center.X - (nvm.Size.Width / 2) + xOffset,
                node.Center.Y - graph.BoundingBox.Center.Y - (nvm.Size.Height / 2) + yOffset);
        }
    }

    #region IDisposable

    private bool _disposedValue;

    ~RedGraph() => Dispose(false);

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                foreach (var node in Nodes)
                {
                    node.Dispose();
                }
            }

            _disposedValue = true;
        }
    }

    #endregion IDisposable
}