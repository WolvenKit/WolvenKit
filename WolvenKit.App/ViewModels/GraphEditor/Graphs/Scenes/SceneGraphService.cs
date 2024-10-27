using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes.Internal;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using Activator = System.Activator;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.GraphEditor.Scenes;

public class SceneGraphService(
    GraphData data,
    scnSceneResource resource,
    SceneGraphFactory factory,
    ILoggerService log) : BaseGraphService(data, new LayoutService(data), new IdGraphCache(data), log)
{
    private static List<Type>? s_behaviorNodeTypes;
    private uint _currentSceneNodeId;

    public override List<Type> GetNodeTypes() =>
        s_behaviorNodeTypes ??= AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(scnSceneGraphNode).IsAssignableFrom(x) && !x.IsAbstract)
            .ToList();

    public override string CleanTypeName(string typeName)
    {
        if (typeName.StartsWith("quest"))
        {
            typeName = typeName[5..];
        }
        else if (typeName.StartsWith("scn"))
        {
            typeName = typeName[3..];
        }

        if (typeName.EndsWith("NodeDefinition"))
        {
            typeName = typeName[..^14];
        }
        else if (typeName.EndsWith("Node"))
        {
            typeName = typeName[..^4];
        }

        return typeName;
    }

    public override void CreateNode(Type type, Point point)
    {
        var instance = InternalCreateSceneNode(type);
        var wrappedInstance = WrapNode(instance);
        wrappedInstance.Location = point;

        resource.SceneGraph.Chunk!.Graph.Add(new CHandle<scnSceneGraphNode>(instance));

        if (GetNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        Nodes.Add(wrappedInstance);
    }

    public override void RemoveNode(NodeViewModel node)
    {
        if (node is not BaseSceneViewModel sceneNode)
        {
            return;
        }

        foreach (var inputConnectorViewModel in sceneNode.Input)
        {
            Disconnect(inputConnectorViewModel);
        }

        foreach (var outputConnectorViewModel in sceneNode.Output)
        {
            Disconnect(outputConnectorViewModel);
        }

        var graph = resource.SceneGraph.Chunk!.Graph!;
        for (var i = graph.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(graph[i].Chunk, sceneNode.Data))
            {
                graph.RemoveAt(i);

                if (GetNodesChunkViewModel() is { } nodes)
                {
                    nodes.RecalculateProperties();
                }
            }
        }

        Nodes.Remove(sceneNode);
    }

    public override void Connect(OutputConnectorViewModel source, InputConnectorViewModel target)
    {
        if (source is not SceneOutputConnectorViewModel sceneSource ||
            target is not SceneInputConnectorViewModel sceneTarget)
        {
            return;
        }

        var input = new scnInputSocketId
        {
            NodeId = new scnNodeId { Id = sceneTarget.OwnerId },
            IsockStamp = new scnInputSocketStamp { Name = 0, Ordinal = sceneTarget.Ordinal }
        };

        sceneSource.Data.Destinations.Add(input);
        Connections.Add(new SceneConnectionViewModel(sceneSource, sceneTarget));
        RefreshCVM(sceneSource.Data);
    }

    public override void Disconnect(BaseConnectorViewModel connector)
    {
        if (connector is SceneOutputConnectorViewModel outputConnector)
        {
            for (var i = Connections.Count - 1; i >= 0; i--)
            {
                if (Connections[i].Source == outputConnector)
                {
                    RemoveConnection((SceneConnectionViewModel)Connections[i]);
                }
            }
        }
        else if (connector is SceneInputConnectorViewModel inputConnector)
        {
            for (var i = Connections.Count - 1; i >= 0; i--)
            {
                if (Connections[i].Target == inputConnector)
                {
                    RemoveConnection((SceneConnectionViewModel)Connections[i]);
                }
            }
        }
    }

    public BaseSceneViewModel WrapNode(scnSceneGraphNode sceneGraphNode)
    {
        var view = factory.CreateView(sceneGraphNode, resource);
        view.GenerateSockets();
        return view;
    }

    public override void GenerateGraph()
    {
        var nodeCache = new Dictionary<uint, BaseSceneViewModel>();
        foreach (var nodeHandle in resource.SceneGraph.Chunk!.Graph)
        {
            ArgumentNullException.ThrowIfNull(nodeHandle.Chunk);

            var node = nodeHandle.Chunk;

            var nvm = WrapNode(node);

            if (!nodeCache.ContainsKey(nvm.UniqueId))
            {
                nodeCache.Add(nvm.UniqueId, nvm);
                Nodes.Add(nvm);

                _currentSceneNodeId = Math.Max(_currentSceneNodeId, nvm.UniqueId);
            }
            //_loggerService.Warning("Duplicate node ID: " + nvm.UniqueId.ToString() + ". Some nodes may be missing in graph view.");
        }

        foreach (var node in Nodes)
        {
            var sceneNode = (BaseSceneViewModel)node;

            foreach (var outputConnector in sceneNode.Output)
            {
                var sceneOutputConnector = (SceneOutputConnectorViewModel)outputConnector;

                foreach (var destination in sceneOutputConnector.Data.Destinations)
                {
                    var targetNode = nodeCache[destination.NodeId.Id];
                    if (targetNode is IDynamicInputNode dynamicInputNode)
                    {
                        while (dynamicInputNode.Input.Count <= destination.IsockStamp.Ordinal)
                        {
                            dynamicInputNode.AddInput();
                        }
                    }

                    if (destination.IsockStamp.Ordinal >= targetNode.Input.Count)
                    {
                        //_loggerService.Warning($"Output isock ordinal ({destination.IsockStamp.Ordinal}) of node {sceneNode.UniqueId} is higher than node {targetNode.UniqueId} input max ordinal ({targetNode.Input.Count - 1}). Some connections may be missing in graph view.");
                        continue;
                    }

                    Connections.Add(new SceneConnectionViewModel(outputConnector,
                        targetNode.Input[destination.IsockStamp.Ordinal]));
                }
            }
        }
    }

    private scnSceneGraphNode InternalCreateSceneNode(Type type)
    {
        var instance = Activator.CreateInstance(type);
        if (instance is not scnSceneGraphNode sceneGraphNode)
        {
            throw new Exception($"Failed to create instance of {type}");
        }

        sceneGraphNode.NodeId.Id = ++_currentSceneNodeId;
        sceneGraphNode.OutputSockets.Add(new scnOutputSocket
        {
            Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = 0 }
        });

        if (sceneGraphNode is scnChoiceNode choiceNode)
        {
            resource.NotablePoints.Add(new scnNotablePoint
            {
                NodeId = new scnNodeId { Id = sceneGraphNode.NodeId.Id }
            });

            choiceNode.OutputSockets =
            [
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 1, Ordinal = 0 } },
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 2, Ordinal = 0 } },
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 3, Ordinal = 0 } },
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 4, Ordinal = 0 } },
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 5, Ordinal = 0 } },
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 6, Ordinal = 0 } }
            ];
        }

        if (sceneGraphNode is scnQuestNode questNode)
        {
            questNode.IsockMappings.Add("CutDestination");
            questNode.IsockMappings.Add("In");
            questNode.OsockMappings.Add("Out");
        }

        if (sceneGraphNode is scnRandomizerNode randomizerNode)
        {
            randomizerNode.NumOutSockets = 1;
            randomizerNode.Weights[0] = 1;
        }

        return sceneGraphNode;
    }

    private scnEndNodeWrapper CreateEndNodeWrapper(scnEndNode endNode)
    {
        var endPoint = resource.ExitPoints.FirstOrDefault(x => x.NodeId.Id == endNode.NodeId.Id);

        if (endPoint == null)
        {
            endPoint = new scnExitPoint { NodeId = new scnNodeId { Id = endNode.NodeId.Id } };
            resource.ExitPoints.Add(endPoint);
        }

        return new scnEndNodeWrapper(endNode, endPoint);
    }

    private scnStartNodeWrapper CreateStartNodeWrapper(scnStartNode startNode)
    {
        var entryPoint = resource.EntryPoints.FirstOrDefault(x => x.NodeId.Id == startNode.NodeId.Id);

        if (entryPoint == null)
        {
            entryPoint = new scnEntryPoint { NodeId = new scnNodeId { Id = startNode.NodeId.Id } };
            resource.EntryPoints.Add(entryPoint);
        }

        return new scnStartNodeWrapper(startNode, entryPoint);
    }

    private void RefreshCVM(scnOutputSocket socket)
    {
        if (GetNodesChunkViewModel() is { } nodes)
        {
            var list = new List<ChunkViewModel>();
            foreach (var property in nodes.GetAllProperties())
            {
                if (ReferenceEquals(property.Data, socket.Destinations))
                {
                    list.Add(property.Parent!);
                }
            }

            foreach (var model in list)
            {
                model.RecalculateProperties();
            }
        }
    }

    private void RemoveConnection(SceneConnectionViewModel sceneConnection)
    {
        var sceneSource = (SceneOutputConnectorViewModel)sceneConnection.Source;
        var sceneDestination =
            sceneSource.Data.Destinations.FirstOrDefault(x => x.NodeId.Id == sceneConnection.Target.OwnerId);

        if (sceneDestination != null)
        {
            sceneSource.Data.Destinations.Remove(sceneDestination);
            sceneSource.IsConnected = sceneSource.Data.Destinations.Count > 0;
            UpdateTargetNode((SceneInputConnectorViewModel)sceneConnection.Target);

            Connections.Remove(sceneConnection);
            RefreshCVM(sceneSource.Data);
        }
    }

    private void UpdateTargetNode(SceneInputConnectorViewModel sceneTarget)
    {
        sceneTarget.IsConnected = false;
        foreach (var node in Nodes)
        {
            foreach (SceneOutputConnectorViewModel output in node.Output)
            {
                foreach (var destination in output.Data.Destinations)
                {
                    if (destination.NodeId.Id == sceneTarget.OwnerId && node.Output.Count > 0)
                    {
                        sceneTarget.IsConnected = true;
                        return;
                    }
                }
            }
        }
    }
}