#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.App.Services;


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

        if (sceneGraphNode is scnChoiceNode choiceNode)
        {
            ((scnSceneResource)_data).NotablePoints.Add(new scnNotablePoint
            {
                NodeId = new scnNodeId
                {
                    Id = sceneGraphNode.NodeId.Id
                }
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

    /// <summary>
    /// Replace a node with a deletion marker node that preserves all connections
    /// </summary>
    /// <param name="node">The node to replace with a deletion marker</param>
    public void ReplaceNodeWithDeletionMarker(BaseSceneViewModel node)
    {
        if (_data is not scnSceneResource sceneResource)
        {
            _loggerService?.Error("Cannot replace node with deletion marker: not a scene resource");
            return;
        }

        if (node.Data is scnDeletionMarkerNode)
        {
            _loggerService?.Warning("Cannot replace a deletion marker with another deletion marker");
            return;
        }

        // 1. Create a deletion marker node with the same ID as the node being replaced
        var deletionMarker = new scnDeletionMarkerNode();
        deletionMarker.NodeId.Id = node.UniqueId;

        // 2. Match output sockets count with the original node to maintain connections
        while (deletionMarker.OutputSockets.Count < (node.Data as scnSceneGraphNode)?.OutputSockets.Count)
        {
            deletionMarker.OutputSockets.Add(new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = (ushort)deletionMarker.OutputSockets.Count, Ordinal = 0 } });
        }

        // 3. Copy all the destination connections to the marker node
        for (int i = 0; i < deletionMarker.OutputSockets.Count && i < (node.Data as scnSceneGraphNode)?.OutputSockets.Count; i++)
        {
            var originalSocket = (node.Data as scnSceneGraphNode)?.OutputSockets[i];
            if (originalSocket != null)
            {
                foreach (var destination in originalSocket.Destinations)
                {
                    deletionMarker.OutputSockets[i].Destinations.Add(destination);
                }
            }
        }

        // 4. Create a node wrapper for the deletion marker
        var markerWrapper = new scnDeletionMarkerNodeWrapper(deletionMarker);
        markerWrapper.Location = node.Location;
        markerWrapper.DocumentViewModel = DocumentViewModel;

        // 5. Find source connections to this node to preserve incoming connections
        var incomingConnections = new List<(SceneOutputConnectorViewModel source, SceneInputConnectorViewModel target)>();
        foreach (var connection in Connections.OfType<SceneConnectionViewModel>())
        {
            if (connection.Target.OwnerId == node.UniqueId)
            {
                incomingConnections.Add(((SceneOutputConnectorViewModel)connection.Source, (SceneInputConnectorViewModel)connection.Target));
            }
        }

        // 6. Remove the original node from the graph data
        var graph = sceneResource.SceneGraph.Chunk?.Graph;
        if (graph != null)
        {
            for (var i = graph.Count - 1; i >= 0; i--)
            {
                if (ReferenceEquals(graph[i].Chunk, node.Data))
                {
                    graph.RemoveAt(i);
                }
            }

            // 7. Add the deletion marker node to the graph data
            graph.Add(new CHandle<scnSceneGraphNode>(deletionMarker));
        }
        else
        {
            _loggerService?.Error("Cannot replace node with deletion marker: scene graph is null");
            return;
        }

        // 8. Generate input sockets based on incoming connections
        markerWrapper.GenerateSockets();
        
        // Add enough input sockets for all incoming connections
        var maxOrdinal = incomingConnections.Count > 0 ? 
            incomingConnections.Max(c => c.target.Ordinal) : 
            0;
            
        while (markerWrapper.Input.Count <= maxOrdinal)
        {
            markerWrapper.AddInput();
        }

        // 9. Remove the original node from UI
        Nodes.Remove(node);
        
        // 10. Add the deletion marker wrapper to UI
        Nodes.Add(markerWrapper);
        
        // 11. Recreate connections
        Connections.Clear();  // Clear all UI connections
        
        // Rebuild all connections
        foreach (var nodeViewModel in Nodes)
        {
            if (nodeViewModel is BaseSceneViewModel sceneNodeViewModel)
            {
                foreach (var output in sceneNodeViewModel.Output.OfType<SceneOutputConnectorViewModel>())
                {
                    foreach (var destination in output.Data.Destinations)
                    {
                        if (destination.NodeId == null) continue;
                        
                        var targetNode = Nodes.FirstOrDefault(n => n is BaseSceneViewModel && (n as BaseSceneViewModel)?.UniqueId == destination.NodeId.Id) as BaseSceneViewModel;
                        if (targetNode != null)
                        {
                            int socketIndex;
                            if (targetNode is scnQuestNodeWrapper)
                            {
                                socketIndex = destination.IsockStamp.Ordinal;
                            }
                            else
                            {
                                socketIndex = destination.IsockStamp.Name;
                            }

                            if (socketIndex < targetNode.Input.Count)
                            {
                                Connections.Add(new SceneConnectionViewModel(output, targetNode.Input[socketIndex]));
                            }
                        }
                    }
                }
            }
        }
        
        // 12. Update properties in the nodes collection
        if (GetSceneNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }
        
        // Mark document as dirty since we modified the graph
        DocumentViewModel?.SetIsDirty(true);
        
        _loggerService?.Info($"Replaced node {node.UniqueId} with a deletion marker");
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
        if (!(_data is scnSceneResource sceneResource))
        {
            _loggerService?.Error($"RedGraph internal data is not scnSceneResource, cannot create node wrappers correctly.");
            sceneResource = new scnSceneResource();
        }

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
            nodeWrapper = new scnSceneGraphNodeWrapper(node);
        }

        nodeWrapper.GenerateSockets();
        
        // Set document reference for property change syncing
        nodeWrapper.DocumentViewModel = DocumentViewModel;

        return nodeWrapper;
    }

    private DynamicSceneViewModel WrapDynamicSceneNode(DynamicBaseClass node)
    {
        var nodeWrapper = new DynamicSceneViewModel(node);

        nodeWrapper.GenerateSockets();
        
        // Set document reference for property change syncing
        nodeWrapper.DocumentViewModel = DocumentViewModel;

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
                if (sceneSource.Data.Destinations[j].NodeId.Id == sceneTarget.OwnerId)
                {
                    // Determine target type (quest vs scene)
                    var tgtNode = Nodes.FirstOrDefault(n => n is BaseSceneViewModel bsvm && bsvm.UniqueId == sceneTarget.OwnerId) as BaseSceneViewModel;
                    bool isQuest = tgtNode is scnQuestNodeWrapper;

                    bool sameSocket = isQuest
                        ? sceneSource.Data.Destinations[j].IsockStamp.Ordinal == sceneTarget.Ordinal
                        : sceneSource.Data.Destinations[j].IsockStamp.Name == sceneTarget.Ordinal;

                    if (sameSocket)
                {
                    sceneSource.Data.Destinations.RemoveAt(j);
                    }
                }
            }

            sceneSource.IsConnected = sceneSource.Data.Destinations.Count > 0;
            UpdateTargetNode(sceneTarget);

            Connections.RemoveAt(i);
            RefreshCVM(sceneSource.Data);
            
            // Invalidate converter cache for affected nodes to force ChunkViewModel regeneration
            InvalidateConverterCacheForNode(sceneSource.OwnerId);
            InvalidateConverterCacheForNode(sceneTarget.OwnerId);
            
            // Restore general property sync (but don't let it regenerate sockets)
            NotifyNodesUpdated(sceneSource.OwnerId, sceneTarget.OwnerId);
            
            // Mark document as dirty since we modified connections
            DocumentViewModel?.SetIsDirty(true);

            return;
        }

        // Determine the Name and Ordinal values based on target node type
        ushort name = 0;
        ushort ordinal = sceneTarget.Ordinal;
        
        // Get the target node from the nodes collection
        var targetNode = Nodes.FirstOrDefault(n => n is BaseSceneViewModel bsvm && bsvm.UniqueId == sceneTarget.OwnerId) as BaseSceneViewModel;
        
        if (targetNode is not scnQuestNodeWrapper)
        {
            // For scene nodes: Name determines the socket type
            // Socket index 0 = Name 0 (normal input)
            // Socket index 1 = Name 1 (cut input)
            name = sceneTarget.Ordinal;
            ordinal = 0; // Scene nodes always use ordinal 0
        }

        var input = new scnInputSocketId
        {
            NodeId = new scnNodeId
            {
                Id = sceneTarget.OwnerId
            },
            IsockStamp = new scnInputSocketStamp
            {
                Name = name,
                Ordinal = ordinal
            }
        };

        sceneSource.Data.Destinations.Add(input);
        Connections.Add(new SceneConnectionViewModel(sceneSource, sceneTarget));
        RefreshCVM(sceneSource.Data);
        
        // Invalidate converter cache for affected nodes to force ChunkViewModel regeneration
        InvalidateConverterCacheForNode(sceneSource.OwnerId);
        InvalidateConverterCacheForNode(sceneTarget.OwnerId);
        
        // Restore general property sync (but don't let it regenerate sockets)
        NotifyNodesUpdated(sceneSource.OwnerId, sceneTarget.OwnerId);
        
        // Mark document as dirty since we modified connections
        DocumentViewModel?.SetIsDirty(true);
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
                    if (destination.NodeId != null && 
                        destination.NodeId.Id == sceneTarget.OwnerId && 
                        node.Output.Count > 0)
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
            // Ensure properties are up-to-date before searching
            nodes.RecalculateProperties();
            nodes.ForceLoadPropertiesRecursive();
            
            var list = new List<ChunkViewModel>();
            foreach (var cvm in nodes.GetAllProperties())
            {
                if (ReferenceEquals(cvm.Data, socket.Destinations))
                {
                    list.Add(cvm);                   // the destinations array itself
                    list.AddRange(cvm.Properties);   // its existing children
                    if (cvm.Parent != null) list.Add(cvm.Parent);
                }
            }

            foreach (var model in list.Distinct())
            {
                // --- begin enhanced refresh logic for expanded destinations ---
                model.RecalculateProperties();
                // Ensure already expanded branches refresh their children
                model.ForceLoadPropertiesRecursive();

                // Raise change notifications so WPF rebinds visible TreeViewItems
                model.NotifyChain(nameof(model.Properties));
                model.NotifyChain(nameof(model.TVProperties));
                // --- end enhanced refresh logic ---
            }

            // Additionally refresh the root nodes collection to ensure UI picks up structural changes
            nodes.RecalculateProperties();
            nodes.NotifyChain(nameof(nodes.Properties));

            // Force the property panel to refresh by notifying NodeSelectionService
            var nodeSelectionService = NodeSelectionService.Instance;
            var selectedNode = nodeSelectionService.SelectedNode;
            
            if (selectedNode != null)
            {
                // Check if the selected node's data was updated or if any updated chunk belongs to the selected node
                bool nodeDataUpdated = list.Any(updatedChunk => 
                {
                    // Direct match: the chunk data is the selected node data
                    if (ReferenceEquals(updatedChunk.Data, selectedNode.Data))
                    {
                        return true;
                    }
                    
                    // Parent-child relationship: the updated chunk is a child of the selected node
                    if (IsChildOf(updatedChunk, selectedNode.Data))
                    {
                        return true;
                    }
                    
                    // Property relationship: check if the updated chunk data is a property of the selected node
                    if (IsPropertyOf(updatedChunk.Data, selectedNode.Data))
                    {
                        return true;
                    }
                    
                    return false;
                });
                
                if (nodeDataUpdated)
                {
                    // Try a different approach: Force the binding to think the Data property changed
                    // while the node is still selected, then refresh the selection
                    
                    // Step 1: Trigger Data property change while node is still selected
                    selectedNode.TriggerPropertyChanged(nameof(selectedNode.Data));
                    
                    // Step 2: Force NodeSelectionService to re-notify about the same node
                    // This should make the binding re-evaluate even though it's the same node
                    var currentNode = selectedNode;
                    nodeSelectionService.SelectedNode = null;
                    
                    // Small delay to ensure UI processes the null selection
                    System.Threading.Thread.Sleep(1);
                    
                    nodeSelectionService.SelectedNode = currentNode;
                    
                    // Step 3: Trigger Data change again after restoration
                    currentNode.TriggerPropertyChanged(nameof(currentNode.Data));
                }
            }
        }
    }

    private ChunkViewModel? GetSceneNodesChunkViewModel()
    {
        if (DocumentViewModel?.GetMainFile() is not RDTDataViewModel dataViewModel)
        {
            return null;
        }

        if (dataViewModel.Chunks[0].GetPropertyFromPath("sceneGraph.graph") is not { } nodes)
        {
            return null;
        }

        return nodes;
    }

    private bool IsChildOf(ChunkViewModel child, ChunkViewModel potentialParent)
    {
        var current = child.Parent;
        while (current != null)
        {
            if (current == potentialParent)
                return true;
            current = current.Parent;
        }
        return false;
    }
    
    private bool IsChildOf(ChunkViewModel child, IRedType potentialParentData)
    {
        var current = child.Parent;
        while (current != null)
        {
            if (ReferenceEquals(current.Data, potentialParentData))
                return true;
            current = current.Parent;
        }
        return false;
    }
    
    private bool IsPropertyOf(IRedType childData, IRedType parentData)
    {
        if (parentData is not RedBaseClass parentClass)
            return false;
            
        // Check if childData is directly referenced by any property of parentData
        foreach (var propertyInfo in parentClass.GetType().GetProperties())
        {
            try
            {
                var propertyValue = propertyInfo.GetValue(parentClass);
                
                // Direct reference check
                if (ReferenceEquals(propertyValue, childData))
                    return true;
                
                // Check inside arrays/collections
                if (propertyValue is System.Collections.IEnumerable enumerable && propertyValue is not string)
                {
                    foreach (var item in enumerable)
                    {
                        if (ReferenceEquals(item, childData))
                            return true;
                    }
                }
            }
            catch
            {
                // Skip properties that can't be accessed
                continue;
            }
        }
        
        return false;
    }

    private void RemoveSceneConnection(SceneConnectionViewModel sceneConnection)
    {
        var sceneSource = (SceneOutputConnectorViewModel)sceneConnection.Source;
        var sceneDestination = sceneSource.Data.Destinations.FirstOrDefault(x => x.NodeId != null && x.NodeId.Id == sceneConnection.Target.OwnerId);

        if (sceneDestination != null)
        {
            // Determine if this destination maps to the specified socket
            var tgtNode = Nodes.FirstOrDefault(n => n is BaseSceneViewModel bsvm && bsvm.UniqueId == ((SceneInputConnectorViewModel)sceneConnection.Target).OwnerId) as BaseSceneViewModel;
            bool isQuest = tgtNode is scnQuestNodeWrapper;

            bool sameSocket = isQuest
                ? sceneDestination.IsockStamp.Ordinal == ((SceneInputConnectorViewModel)sceneConnection.Target).Ordinal
                : sceneDestination.IsockStamp.Name == ((SceneInputConnectorViewModel)sceneConnection.Target).Ordinal;

            if (!sameSocket)
            {
                sceneDestination = null; // different socket; keep connection
            }
        }

        if (sceneDestination != null)
        {
            sceneSource.Data.Destinations.Remove(sceneDestination);
            sceneSource.IsConnected = sceneSource.Data.Destinations.Count > 0;
            UpdateTargetNode((SceneInputConnectorViewModel)sceneConnection.Target);

            Connections.Remove(sceneConnection);
            RefreshCVM(sceneSource.Data);
            
            // Invalidate converter cache for affected nodes to force ChunkViewModel regeneration
            InvalidateConverterCacheForNode(sceneSource.OwnerId);
            InvalidateConverterCacheForNode(((SceneInputConnectorViewModel)sceneConnection.Target).OwnerId);
            
            // Restore general property sync (but don't let it regenerate sockets)
            NotifyNodesUpdated(sceneSource.OwnerId, ((SceneInputConnectorViewModel)sceneConnection.Target).OwnerId);
            
            // Mark document as dirty since we modified connections
            DocumentViewModel?.SetIsDirty(true);
        }
    }

    public void RemoveSceneConnectionPublic(SceneConnectionViewModel sceneConnection)
    {
        RemoveSceneConnection(sceneConnection);
    }

    public void DuplicateSceneNode(BaseSceneViewModel originalNode)
    {
        if (originalNode.Data is not IRedCloneable cloneable)
        {
            _loggerService?.Error($"Cannot duplicate node of type {originalNode.Data.GetType().Name} - it doesn't implement IRedCloneable");
            return;
        }

        var duplicatedData = (scnSceneGraphNode)cloneable.DeepCopy();
        
        var newNodeId = GetNextAvailableSceneNodeId();
        duplicatedData.NodeId.Id = newNodeId;
        _currentSceneNodeId = Math.Max(_currentSceneNodeId, newNodeId);
        
        // For scnQuestNode, also update the quest node's ID to match
        if (duplicatedData is scnQuestNode questNode && questNode.QuestNode?.Chunk != null)
        {
            questNode.QuestNode.Chunk.Id = (ushort)duplicatedData.NodeId.Id;
        }

        foreach (var outputSocket in duplicatedData.OutputSockets)
        {
            outputSocket.Destinations.Clear();
        }

        var wrappedDuplicate = WrapSceneNode(duplicatedData);
        
        wrappedDuplicate.Location = new System.Windows.Point(
            originalNode.Location.X + 50, 
            originalNode.Location.Y + 50
        );

        ((scnSceneResource)_data).SceneGraph.Chunk!.Graph.Add(new CHandle<scnSceneGraphNode>(duplicatedData));
        
        if (GetSceneNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        Nodes.Add(wrappedDuplicate);
        
        _loggerService?.Info($"Duplicated scene node with new ID: {duplicatedData.NodeId.Id}");
    }

    private uint GetNextAvailableSceneNodeId()
    {
        var sceneResource = (scnSceneResource)_data;
        
        uint candidateId = _currentSceneNodeId + 1;
        
        if (!IsSceneNodeIdInUse(candidateId, sceneResource))
        {
            return candidateId;
        }
        
        // Fallback: if there's a collision, keep searching
        do
        {
            candidateId++;
        } while (IsSceneNodeIdInUse(candidateId, sceneResource));
        
        return candidateId;
    }
    
    private bool IsSceneNodeIdInUse(uint nodeId, scnSceneResource sceneResource)
    {
        foreach (var nodeHandle in sceneResource.SceneGraph.Chunk!.Graph)
        {
            if (nodeHandle.GetValue() is scnSceneGraphNode node && node.NodeId.Id == nodeId)
            {
                return true;
            }
        }
        
        return false;
    }

    public static RedGraph GenerateSceneGraph(string title, scnSceneResource sceneResource)
    {
        var graph = new RedGraph(title, sceneResource);

        var nodeCache = new Dictionary<uint, BaseSceneViewModel>();
        foreach (var nodeHandle in sceneResource.SceneGraph.Chunk!.Graph)
        {
            var node = nodeHandle.GetValue();
            if (node is null)
            {
                throw new Exception("Empty nodes aren't supported!");
            }

            var nvm = node switch
            {
                DynamicBaseClass dynamicBaseClass => graph.WrapDynamicSceneNode(dynamicBaseClass),
                scnSceneGraphNode scnSceneGraphNode => graph.WrapSceneNode(scnSceneGraphNode),
                _ => throw new Exception($"Node of type \"{node.GetType()}\" isn't supported!")
            };

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
                        nodeCache.TryGetValue(destination.NodeId.Id, out var targetNode);
                        if (targetNode is null)
                        {
                            _loggerService?.Error($"NodeId {destination.NodeId.Id} is missing. Delete all existing connections to this NodeId");
                            continue;
                        }
                        if (targetNode is IDynamicInputNode dynamicInputNode)
                        {
                            int requiredIndex = destination.IsockStamp.Ordinal;
                            if (targetNode is not scnQuestNodeWrapper)
                            {
                                requiredIndex = destination.IsockStamp.Name;
                            }
                            while (dynamicInputNode.Input.Count <= requiredIndex)
                            {
                                dynamicInputNode.AddInput();
                            }
                        }

                        int destIndexCheck = destination.IsockStamp.Ordinal;
                        if (targetNode is not scnQuestNodeWrapper)
                        {
                            destIndexCheck = destination.IsockStamp.Name;
                        }

                        if (destIndexCheck >= targetNode.Input.Count)
                        {
                            _loggerService?.Warning($"Output isock ordinal ({destination.IsockStamp.Ordinal}) of node {sceneNode.UniqueId} is higher than node {targetNode.UniqueId} input max ordinal ({targetNode.Input.Count - 1}). Some connections may be missing in graph view. File: " + title);
                            continue;
                        }

                        // For scene nodes (not quest nodes), use Name field to determine socket index
                        // Quest nodes use Ordinal, scene nodes use Name for socket mapping
                        int socketIndex = destination.IsockStamp.Ordinal;
                        
                        // Check if this is a scene-specific node (not a quest node)
                        if (targetNode is not scnQuestNodeWrapper)
                        {
                            // For scene nodes:
                            // Name 0 = Normal input (socket index 0)
                            // Name 1 = Cut input (socket index 1)
                            socketIndex = destination.IsockStamp.Name;
                            
                            // Validate socket index
                            if (socketIndex >= targetNode.Input.Count)
                            {
                                _loggerService?.Warning($"Scene node connection name ({destination.IsockStamp.Name}) of node {sceneNode.UniqueId} is higher than node {targetNode.UniqueId} input count ({targetNode.Input.Count}). Some connections may be missing in graph view. File: " + title);
                                continue;
                            }
                        }

                        graph.Connections.Add(new SceneConnectionViewModel(outputConnector, targetNode.Input[socketIndex]));
                }
            }
        }

        return graph;
    }

    /// <summary>
    /// Invalidates the RedTypeToChunkViewModelCollectionConverter cache for a specific node
    /// to force regeneration of its ChunkViewModel when destinations change.
    /// </summary>
    /// <param name="nodeId">UniqueId of the node to invalidate</param>
    private void InvalidateConverterCacheForNode(uint nodeId)
    {
        var node = Nodes.FirstOrDefault(n => n.UniqueId == nodeId);
        if (node?.Data != null)
        {
            // Use the converter cache service to invalidate the cache for this node
            var cacheService = new ConverterCacheService();
            cacheService.InvalidateConverterCache((RedBaseClass)node.Data);
            
            // Trigger Data property change to force UI refresh
            node.TriggerPropertyChanged(nameof(node.Data));
        }
    }


}
