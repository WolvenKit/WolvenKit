using System;
using System.Collections.Generic;
using System.Linq;
using DynamicData;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor;

public partial class RedGraph
{
    private static List<Type>? s_sceneNodeTypes;

    public List<Type> GetSceneNodeTypes()
    {
        if (s_sceneNodeTypes == null)
        {
            s_sceneNodeTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(scnSceneGraphNode).IsAssignableFrom(x) && !x.IsAbstract)
                .ToList();
        }

        return s_sceneNodeTypes;
    }

    public void CreateSceneNode(Type type, System.Windows.Point point)
    {
        var instance = InternalCreateSceneNode(type);
        var wrappedInstance = WrapSceneNode(instance);
        wrappedInstance.Location = point;

        ((scnSceneResource)_data).SceneGraph.Chunk!.Graph.Add(new CHandle<scnSceneGraphNode>(instance));
        if (GetSceneNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        Nodes.Add(wrappedInstance);
    }

    private scnSceneGraphNode InternalCreateSceneNode(Type type)
    {
        var instance = System.Activator.CreateInstance(type);
        if (instance is not scnSceneGraphNode sceneGraphNode)
        {
            throw new Exception();
        }

        sceneGraphNode.NodeId.Id = ++_currentSceneNodeId;
        sceneGraphNode.OutputSockets.Add(new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = 0 } });

        if (sceneGraphNode is scnChoiceNode)
        {
            ((scnSceneResource)_data).NotablePoints.Add(new scnNotablePoint
            {
                NodeId = new scnNodeId
                {
                    Id = sceneGraphNode.NodeId.Id
                }
            });
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

    private void RemoveSceneNode(BaseSceneViewModel node)
    {
        foreach (var inputConnectorViewModel in node.Input)
        {
            Disconnect(inputConnectorViewModel);
        }

        foreach (var outputConnectorViewModel in node.Output)
        {
            Disconnect(outputConnectorViewModel);
        }

        var graph = ((scnSceneResource)_data).SceneGraph.Chunk!.Graph!;
        for (var i = graph.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(graph[i].Chunk, node.Data))
            {
                graph.RemoveAt(i);

                if (GetSceneNodesChunkViewModel() is { } nodes)
                {
                    nodes.RecalculateProperties();
                }
            }
        }

        Nodes.Remove(node);
    }

    private BaseSceneViewModel WrapSceneNode(scnSceneGraphNode node)
    {
        var sceneResource = (scnSceneResource)_data;

        BaseSceneViewModel nodeWrapper;
        if (node is scnAndNode andNode)
        {
            nodeWrapper = new scnAndNodeWrapper(andNode);
        }
        else if (node is scnChoiceNode choiceNode)
        {
            nodeWrapper = new scnChoiceNodeWrapper(choiceNode, sceneResource);
        }
        else if (node is scnCutControlNode cutControlNode)
        {
            nodeWrapper = new scnCutControlNodeWrapper(cutControlNode);
        }
        else if (node is scnDeletionMarkerNode deletionMarkerNode)
        {
            nodeWrapper = new scnDeletionMarkerNodeWrapper(deletionMarkerNode);
        }
        else if (node is scnEndNode endNode)
        {
            var endPoint = sceneResource
                .ExitPoints
                .FirstOrDefault(x => x.NodeId.Id == endNode.NodeId.Id);

            if (endPoint == null)
            {
                endPoint = new scnExitPoint
                {
                    NodeId = new scnNodeId
                    {
                        Id = endNode.NodeId.Id
                    }
                };
                sceneResource.ExitPoints.Add(endPoint);
            }

            nodeWrapper = new scnEndNodeWrapper(endNode, endPoint);
        }
        else if (node is scnHubNode hubNode)
        {
            nodeWrapper = new scnHubNodeWrapper(hubNode);
        }
        else if (node is scnInterruptManagerNode interruptManagerNode)
        {
            nodeWrapper = new scnInterruptManagerNodeWrapper(interruptManagerNode);
        }
        else if (node is scnQuestNode questNode)
        {
            nodeWrapper = new scnQuestNodeWrapper(questNode, sceneResource);
        }
        else if (node is scnRandomizerNode randomizerNode)
        {
            nodeWrapper = new scnRandomizerNodeWrapper(randomizerNode);
        }
        else if (node is scnRewindableSectionNode rewindableSectionNode)
        {
            nodeWrapper = new scnRewindableSectionNodeWrapper(rewindableSectionNode, sceneResource);
        }
        else if (node is scnSectionNode sectionNode)
        {
            nodeWrapper = new scnSectionNodeWrapper(sectionNode, sceneResource);
        }
        else if (node is scnStartNode startNode)
        {
            var entryPoint = sceneResource
                .EntryPoints
                .FirstOrDefault(x => x.NodeId.Id == startNode.NodeId.Id);

            if (entryPoint == null)
            {
                entryPoint = new scnEntryPoint
                {
                    NodeId = new scnNodeId
                    {
                        Id = startNode.NodeId.Id
                    }
                };
                sceneResource.EntryPoints.Add(entryPoint);
            }

            nodeWrapper = new scnStartNodeWrapper(startNode, entryPoint);
        }
        else if (node is scnXorNode xorNode)
        {
            nodeWrapper = new scnXorNodeWrapper(xorNode);
        }
        else
        {
            // shouldn't happen, just for failsafe
            nodeWrapper = new scnSceneGraphNodeWrapper(node);
        }

        nodeWrapper.GenerateSockets();

        return nodeWrapper;
    }

    private void ConnectScene(SceneOutputConnectorViewModel sceneSource, SceneInputConnectorViewModel sceneTarget)
    {
        for (var i = Connections.Count - 1; i >= 0; i--)
        {
            if (!ReferenceEquals(Connections[i].Source, sceneSource) ||
                !ReferenceEquals(Connections[i].Target, sceneTarget))
            {
                continue;
            }

            for (var j = sceneSource.Data.Destinations.Count - 1; j >= 0; j--)
            {
                if (sceneSource.Data.Destinations[j].NodeId.Id == sceneTarget.OwnerId &&
                    sceneSource.Data.Destinations[j].IsockStamp.Ordinal == sceneTarget.Ordinal)
                {
                    sceneSource.Data.Destinations.RemoveAt(j);
                }
            }

            sceneSource.IsConnected = sceneSource.Data.Destinations.Count > 0;
            UpdateTargetNode(sceneTarget);

            Connections.RemoveAt(i);
            RefreshCVM(sceneSource.Data);

            return;
        }

        var input = new scnInputSocketId
        {
            NodeId = new scnNodeId
            {
                Id = sceneTarget.OwnerId
            },
            IsockStamp = new scnInputSocketStamp
            {
                Name = 0,
                Ordinal = sceneTarget.Ordinal
            }
        };

        sceneSource.Data.Destinations.Add(input);
        Connections.Add(new SceneConnectionViewModel(sceneSource, sceneTarget));
        RefreshCVM(sceneSource.Data);
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

    private void RefreshCVM(scnOutputSocket socket)
    {
        if (GetSceneNodesChunkViewModel() is { } nodes)
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

    private ChunkViewModel? GetSceneNodesChunkViewModel()
    {
        if (DocumentViewModel?.GetMainFile() is not RDTDataViewModel dataViewModel)
        {
            return null;
        }

        if (dataViewModel.Chunks[0].GetModelFromPath("sceneGraph.graph") is not { } nodes)
        {
            return null;
        }

        return nodes;
    }

    private void RemoveSceneConnection(SceneConnectionViewModel sceneConnection)
    {
        var sceneSource = (SceneOutputConnectorViewModel)sceneConnection.Source;
        var sceneDestination = sceneSource.Data.Destinations.FirstOrDefault(x => x.NodeId.Id == sceneConnection.Target.OwnerId);

        if (sceneDestination != null)
        {
            sceneSource.Data.Destinations.Remove(sceneDestination);
            sceneSource.IsConnected = sceneSource.Data.Destinations.Count > 0;
            UpdateTargetNode((SceneInputConnectorViewModel)sceneConnection.Target);

            Connections.Remove(sceneConnection);
            RefreshCVM(sceneSource.Data);
        }
    }

    public static RedGraph GenerateSceneGraph(string title, scnSceneResource sceneResource)
    {
        var graph = new RedGraph(title, sceneResource);

        var nodeCache = new Dictionary<uint, BaseSceneViewModel>();
        foreach (var nodeHandle in sceneResource.SceneGraph.Chunk!.Graph)
        {
            ArgumentNullException.ThrowIfNull(nodeHandle.Chunk);

            var node = nodeHandle.Chunk;

            var nvm = graph.WrapSceneNode(node);

            if (!nodeCache.ContainsKey(nvm.UniqueId))
            {
                nodeCache.Add(nvm.UniqueId, nvm);
                graph.Nodes.Add(nvm);

                graph._currentSceneNodeId = Math.Max(graph._currentSceneNodeId, nvm.UniqueId);
            }
            else
            {
                _loggerService?.Warning("Duplicate node ID: " + nvm.UniqueId.ToString() + ". Some nodes may be missing in graph view. File: " + title);
            }
        }

        foreach (var node in graph.Nodes)
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
                        _loggerService?.Warning($"Output isock ordinal ({destination.IsockStamp.Ordinal}) of node {sceneNode.UniqueId} is higher than node {targetNode.UniqueId} input max ordinal ({targetNode.Input.Count - 1}). Some connections may be missing in graph view. File: " + title);
                        continue;
                    }

                    graph.Connections.Add(new SceneConnectionViewModel(outputConnector, targetNode.Input[destination.IsockStamp.Ordinal]));
                }
            }
        }

        return graph;
    }
}