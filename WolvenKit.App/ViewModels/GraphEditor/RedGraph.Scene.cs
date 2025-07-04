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
using WolvenKit.Core.Extensions;


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

    public uint CreateSceneNode(Type type, System.Windows.Point point)
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
        
        DocumentViewModel?.SetIsDirty(true);
        
        return instance.NodeId.Id;
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
            var sceneResource = (scnSceneResource)_data;
            
            // Add notablePoint for choice nodes
            sceneResource.NotablePoints.Add(new scnNotablePoint
            {
                NodeId = new scnNodeId
                {
                    Id = sceneGraphNode.NodeId.Id
                }
            });

            // Create proper screenplay entries for the default choice option
            var random = new Random();
            var cruid = (CRUID)random.NextCRUID();
            
            // first id is always 2, don't know why
            var id = (CUInt32)2;
            if (sceneResource.ScreenplayStore.Options.Count > 0)
            {
                // needs to be 256 higher, if lower the previous text is used, if higher nothing is shown...
                id = sceneResource.ScreenplayStore.Options[^1].ItemId.Id + 256;
            }

            sceneResource.LocStore.VpEntries.Add(new scnlocLocStoreEmbeddedVariantPayloadEntry
            {
                Content = "Default Option",
                VariantId = new scnlocVariantId
                {
                    Ruid = cruid
                }
            });

            sceneResource.LocStore.VdEntries.Add(new scnlocLocStoreEmbeddedVariantDescriptorEntry
            {
                LocstringId = new scnlocLocstringId
                {
                    Ruid = cruid - 4
                },
                VariantId = new scnlocVariantId
                {
                    Ruid = cruid
                },
                VpeIndex = (uint)(sceneResource.LocStore.VpEntries.Count - 1),
                Signature = new scnlocSignature
                {
                    Val = 3
                }
            });

            sceneResource.ScreenplayStore.Options.Add(new scnscreenplayChoiceOption
            {
                LocstringId = new scnlocLocstringId
                {
                    Ruid = cruid - 4
                },
                ItemId = new scnscreenplayItemId
                {
                    Id = id
                },
                Usage = new scnscreenplayOptionUsage
                {
                    PlayerGenderMask = new scnGenderMask
                    {
                        Mask = 3 // both
                    }
                }
            });

            // Create default choice option with proper screenplay reference
            choiceNode.Options.Add(new scnChoiceNodeOption
            {
                ScreenplayOptionId = new scnscreenplayItemId()
                {
                    Id = id
                }
            });

            // Refresh the property panel to show the new notablePoint AND screenplay entries
            RefreshSceneResourcePropertiesInTabs();

            choiceNode.OutputSockets =
            [
                // Choice option socket (name=0, ordinal=0) for the default option
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = 0 } },
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
            questNode.IsockMappings.Add("Cancel");
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
    /// Maps original socket coordinates to deletion marker coordinates based on common patterns
    /// </summary>
    /// <param name="originalCoords">Original socket coordinates (name, ordinal)</param>
    /// <returns>Mapped deletion marker coordinates</returns>
    private static (ushort name, ushort ordinal) MapToDeleteionMarkerCoordinates((ushort name, ushort ordinal) originalCoords)
    {
        // Handle special cases first
        if (originalCoords.name == 1026)
        {
            // Keep 1026 sockets as-is (Cut Control failsafe pattern)
            return originalCoords;
        }
        
        // Map common input patterns to deletion marker 666-based coordinates
        return originalCoords switch
        {
            // Standard input patterns
            (0, 0) => (666, 0),    // Main input -> (666,0)
            (1, 0) => (666, 1),    // Cancel input -> (666,1) - most common pattern
            (2, 0) => (666, 2),    // Additional inputs
            (3, 0) => (666, 3),
            
            // Handle ordinal variations  
            (0, var ord) => (666, ord),
            (1, var ord) => (666, (ushort)(ord + 1)), // Offset by 1 to avoid collision with (0,0)->(666,0)
            (2, var ord) => (666, (ushort)(ord + 2)), // Offset by 2
            
            // Default: map to 666 with preserved ordinal
            _ => (666, originalCoords.ordinal)
        };
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
        // Use 666 naming convention for deletion marker sockets
        while (deletionMarker.OutputSockets.Count < (node.Data as scnSceneGraphNode)?.OutputSockets.Count)
        {
            deletionMarker.OutputSockets.Add(new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 666, Ordinal = (ushort)deletionMarker.OutputSockets.Count } });
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

        // 6. Remove notablePoint if this was a choice node
        RemoveNotablePointForNode(node.UniqueId);

        // 7. Remove the original node from the graph data
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

            // 8. Add the deletion marker node to the graph data
            graph.Add(new CHandle<scnSceneGraphNode>(deletionMarker));
        }
        else
        {
            _loggerService?.Error("Cannot replace node with deletion marker: scene graph is null");
            return;
        }

        // 9. Generate input sockets based on incoming connections and update destination data
        markerWrapper.GenerateSockets();
        
        // Create a mapping from original input socket coordinates to deletion marker socket coordinates
        var socketMapping = new Dictionary<(ushort name, ushort ordinal), (ushort name, ushort ordinal)>();
        
        // Add input sockets for all incoming connections and build mapping
        foreach (var incomingConn in incomingConnections)
        {
            var originalCoords = (incomingConn.target.NameId, incomingConn.target.Ordinal);
            if (!socketMapping.ContainsKey(originalCoords))
            {
                // Map original coordinates to deletion marker coordinates
                (ushort newName, ushort newOrdinal) = MapToDeleteionMarkerCoordinates(originalCoords);
                socketMapping[originalCoords] = (newName, newOrdinal);
                
                // Create the input socket with the mapped coordinates
                markerWrapper.AddInputWithCoordinates(newName, newOrdinal);
            }
        }
        
        // Update destination data in all output sockets to point to deletion marker's 666-based coordinates
        foreach (var nodeViewModel in Nodes)
        {
            if (nodeViewModel is BaseSceneViewModel sceneNodeViewModel)
            {
                foreach (var output in sceneNodeViewModel.Output.OfType<SceneOutputConnectorViewModel>())
                {
                    if (output.Data == null) continue;
                    
                    for (int i = 0; i < output.Data.Destinations.Count; i++)
                    {
                        var dest = output.Data.Destinations[i];
                                                 if (dest.NodeId.Id == node.UniqueId) // Points to the node being replaced
                         {
                             var originalCoords = (dest.IsockStamp.Name, dest.IsockStamp.Ordinal);
                             if (socketMapping.TryGetValue(originalCoords, out var newCoords))
                             {
                                 // Update to deletion marker coordinates
                                 dest.NodeId.Id = markerWrapper.UniqueId;
                                 dest.IsockStamp.Name = newCoords.name;
                                 dest.IsockStamp.Ordinal = newCoords.ordinal;
                             }
                         }
                    }
                }
            }
        }

        // 10. Remove the original node from UI
        Nodes.Remove(node);
        
        // 11. Add the deletion marker wrapper to UI
        Nodes.Add(markerWrapper);
        
        // 12. Recreate connections
        Connections.Clear();  // Clear all UI connections
        
        // Rebuild all connections
        foreach (var nodeViewModel in Nodes)
        {
            if (nodeViewModel is BaseSceneViewModel sceneNodeViewModel)
            {
                foreach (var output in sceneNodeViewModel.Output.OfType<SceneOutputConnectorViewModel>())
                {
                    if (output.Data == null) continue;
                    
                    foreach (var destination in output.Data.Destinations)
                    {
                        if (destination.NodeId == null) continue;
                        
                        var targetNode = Nodes.FirstOrDefault(n => n is BaseSceneViewModel && (n as BaseSceneViewModel)?.UniqueId == destination.NodeId.Id) as BaseSceneViewModel;
                        if (targetNode != null)
                        {
                            int socketIndex;
                            if (targetNode is scnQuestNodeWrapper || targetNode is scnDeletionMarkerNodeWrapper)
                            {
                                // Quest nodes and deletion marker nodes use ordinal for socket indexing
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
        
        // 13. Update properties in the nodes collection
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

        // Remove notablePoint if this was a choice node
        RemoveNotablePointForNode(node.UniqueId);

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
        else if (node is scnFlowControlNode flowControl)
        {
            nodeWrapper = new scnFlowControlNodeWrapper(flowControl);
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

        // Set document reference for property change syncing BEFORE generating sockets
        nodeWrapper.DocumentViewModel = DocumentViewModel;
        
        nodeWrapper.GenerateSockets();
        
        // Clear the flag after initial loading is complete
        nodeWrapper.IsInitialLoad = false;

        return nodeWrapper;
    }

    private DynamicSceneViewModel WrapDynamicSceneNode(DynamicBaseClass node)
    {
        var nodeWrapper = new DynamicSceneViewModel(node);

        // Set document reference for property change syncing BEFORE generating sockets
        nodeWrapper.DocumentViewModel = DocumentViewModel;
        
        nodeWrapper.GenerateSockets();
        
        // Clear the flag after initial loading is complete
        nodeWrapper.IsInitialLoad = false;

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

            for (var j = sceneSource.Data!.Destinations.Count - 1; j >= 0; j--)
            {
                if (sceneSource.Data.Destinations[j].NodeId.Id == sceneTarget.OwnerId &&
                    sceneSource.Data.Destinations[j].IsockStamp.Ordinal == sceneTarget.Ordinal)
                {
                    sceneSource.Data.Destinations.RemoveAt(j);
                }
            }
            
            // 1026 Failsafe Cleanup: When Cut Control FALSE socket disconnects from any cut destination socket,
            // also remove the hidden connection to (1026,0) on the same destination node
            var sourceNodeForDisconnect = Nodes.FirstOrDefault(n => n.UniqueId == sceneSource.OwnerId) as BaseSceneViewModel;
            if (sourceNodeForDisconnect is scnCutControlNodeWrapper && 
                sceneSource.Data.Stamp.Name == 1 && // FALSE socket of Cut Control
                IsCutDestinationSocket(sceneTarget)) // Any cut destination socket
            {
                // Remove the hidden connection to (1026,0)
                for (var j = sceneSource.Data.Destinations.Count - 1; j >= 0; j--)
                {
                    var dest = sceneSource.Data.Destinations[j];
                    if (dest.NodeId.Id == sceneTarget.OwnerId &&
                        dest.IsockStamp.Name == 1026 && dest.IsockStamp.Ordinal == 0)
                    {
                        sceneSource.Data.Destinations.RemoveAt(j);
                        break;
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

        var socketData = sceneSource.Data;
        if (socketData == null)
        {
            var ownerNodeVM = Nodes.FirstOrDefault(n => n.UniqueId == sceneSource.OwnerId);
            if (ownerNodeVM is BaseSceneViewModel { Data: scnSceneGraphNode ownerNodeData })
            {
                socketData = new scnOutputSocket
                {
                    Stamp = new scnOutputSocketStamp { Name = sceneSource.NameId, Ordinal = sceneSource.Ordinal },
                    Destinations = new CArray<scnInputSocketId>()
                };
                ownerNodeData.OutputSockets.Add(socketData);
                sceneSource.Data = socketData;
            }
        }
        
        if (socketData == null)
        {
            _loggerService?.Error("Could not create socket data for connection.");
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
                Name = sceneTarget.NameId,
                Ordinal = sceneTarget.Ordinal
            }
        };

        socketData.Destinations.Add(input);
        Connections.Add(new SceneConnectionViewModel(sceneSource, sceneTarget));
        
        // 1026 Failsafe: When Cut Control FALSE socket connects to any cut destination socket,
        // automatically add hidden connection to (1026,0) on the same destination node
        var sourceNode = Nodes.FirstOrDefault(n => n.UniqueId == sceneSource.OwnerId) as BaseSceneViewModel;
        if (sourceNode is scnCutControlNodeWrapper && 
            socketData.Stamp.Name == 1 && // FALSE socket of Cut Control
            IsCutDestinationSocket(sceneTarget)) // Any cut destination socket
        {
            var hiddenInput = new scnInputSocketId
            {
                NodeId = new scnNodeId
                {
                    Id = sceneTarget.OwnerId
                },
                IsockStamp = new scnInputSocketStamp
                {
                    Name = 1026,
                    Ordinal = 0
                }
            };
            
            // Add the hidden connection to data only (not to UI Connections)
            socketData.Destinations.Add(hiddenInput);
        }
        
        RefreshCVM(socketData);
        
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
                if (output.Data == null)
                {
                    continue;
                }
                
                foreach (var destination in output.Data.Destinations)
                {
                    if (destination.NodeId != null && 
                        destination.NodeId.Id == sceneTarget.OwnerId && 
                        destination.IsockStamp.Name == sceneTarget.NameId &&
                        destination.IsockStamp.Ordinal == sceneTarget.Ordinal)
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

    /// <summary>
    /// Removes a notablePoint from the scnSceneResource if it exists for the given node ID
    /// </summary>
    /// <param name="nodeId">The node ID to remove from notablePoints</param>
    private void RemoveNotablePointForNode(uint nodeId)
    {
        var sceneResource = (scnSceneResource)_data;
        var notablePointToRemove = sceneResource.NotablePoints
            .FirstOrDefault(np => np.NodeId.Id == nodeId);
            
        if (notablePointToRemove != null)
        {
            sceneResource.NotablePoints.Remove(notablePointToRemove);
            
            // Refresh the property panel to show the removal
            RefreshSceneResourcePropertiesInTabs();
        }
    }

    /// <summary>
    /// Refreshes the property panel to show changes to root scnSceneResource properties
    /// </summary>
    public void RefreshSceneResourcePropertiesInTabs()
    {
        // Invalidate converter cache for the root scnSceneResource
        var cacheService = new ConverterCacheService();
        cacheService.InvalidateConverterCache((scnSceneResource)_data);
        
        // Force refresh of the tab content in SceneGraphViewModel
        if (DocumentViewModel != null)
        {
            var sceneGraphTab = DocumentViewModel.TabItemViewModels
                .OfType<SceneGraphViewModel>()
                .FirstOrDefault();
                
            if (sceneGraphTab?.SelectedTab != null)
            {
                // Directly recreate the tab content with fresh filtered data
                var freshRootChunk = sceneGraphTab.RDTViewModel.GetRootChunk();
                if (freshRootChunk != null)
                {
                    // Force fresh calculation of properties
                    freshRootChunk.RecalculateProperties();
                    freshRootChunk.ForceLoadPropertiesRecursive();
                    
                    // Apply the filter to get fresh filtered content
                    var freshFilteredList = new List<ChunkViewModel>(
                        freshRootChunk.TVProperties.Where(c => sceneGraphTab.SelectedTab.Filter(c))
                    );
                    
                    // Expand the first level of items by default
                    foreach (var item in freshFilteredList)
                    {
                        item.IsExpanded = true;
                    }
                    
                    // Directly set the new content
                    sceneGraphTab.SelectedTabContent = freshFilteredList;
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
        var sceneTarget = (SceneInputConnectorViewModel)sceneConnection.Target;
        var sceneDestination = sceneSource.Data!.Destinations.FirstOrDefault(x => x.NodeId.Id == sceneTarget.OwnerId);

        if (sceneDestination != null)
        {
            sceneSource.Data.Destinations.Remove(sceneDestination);
            
            // 1026 Failsafe Cleanup: When Cut Control FALSE socket disconnects from any cut destination socket,
            // also remove the hidden connection to (1026,0) on the same destination node
            var sourceNode = Nodes.FirstOrDefault(n => n.UniqueId == sceneSource.OwnerId) as BaseSceneViewModel;
            if (sourceNode is scnCutControlNodeWrapper && 
                sceneSource.Data.Stamp.Name == 1 && // FALSE socket of Cut Control
                IsCutDestinationSocket(sceneTarget)) // Any cut destination socket
            {
                // Remove the hidden connection to (1026,0)
                for (var j = sceneSource.Data.Destinations.Count - 1; j >= 0; j--)
                {
                    var dest = sceneSource.Data.Destinations[j];
                    if (dest.NodeId.Id == sceneTarget.OwnerId &&
                        dest.IsockStamp.Name == 1026 && dest.IsockStamp.Ordinal == 0)
                    {
                        sceneSource.Data.Destinations.RemoveAt(j);
                        break;
                    }
                }
            }
            
            sceneSource.IsConnected = sceneSource.Data.Destinations.Count > 0;
            UpdateTargetNode(sceneTarget);

            Connections.Remove(sceneConnection);
            RefreshCVM(sceneSource.Data);
            
            // Invalidate converter cache for affected nodes to force ChunkViewModel regeneration
            InvalidateConverterCacheForNode(sceneSource.OwnerId);
            InvalidateConverterCacheForNode(sceneTarget.OwnerId);
            
            // Restore general property sync (but don't let it regenerate sockets)
            NotifyNodesUpdated(sceneSource.OwnerId, sceneTarget.OwnerId);
            
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

    /// <summary>
    /// Ensures that a node has the required input socket, creating it if necessary
    /// </summary>
    /// <param name="targetNode">The node that needs the input socket</param>
    /// <param name="socketName">The socket name coordinate</param>
    /// <param name="socketOrdinal">The socket ordinal coordinate</param>
    private void EnsureInputSocket(BaseSceneViewModel targetNode, ushort socketName, ushort socketOrdinal)
    {
        // Skip creating visible sockets for (1026,0) - these should remain hidden data-only connections
        // They are automatically created by Cut Control failsafe logic and should not clutter the UI
        if (socketName == 1026 && socketOrdinal == 0)
        {
            return; // (1026,0) connections exist only as hidden data, no visible socket needed
        }

        // Check if socket already exists
        var existingSocket = targetNode.Input
            .Cast<SceneInputConnectorViewModel>()
            .FirstOrDefault(x => x.NameId == socketName && x.Ordinal == socketOrdinal);

        if (existingSocket != null)
        {
            return; // Socket already exists
        }

        // Handle different node types
        if (targetNode is scnDeletionMarkerNodeWrapper deletionMarker)
        {
            // Deletion markers can dynamically create any input socket
            deletionMarker.AddInputWithCoordinates(socketName, socketOrdinal);
        }
        else if (targetNode is scnHubNodeWrapper hubNode)
        {
            // Hub nodes can create sockets with arbitrary coordinates
            hubNode.AddInputWithCoordinates(socketName, socketOrdinal);
        }
        else if (targetNode is scnAndNodeWrapper andNode)
        {
            // And nodes can create sockets with arbitrary coordinates
            andNode.AddInputWithCoordinates(socketName, socketOrdinal);
        }
        else if (targetNode is scnXorNodeWrapper xorNode)
        {
            // Xor nodes can create sockets with arbitrary coordinates
            xorNode.AddInputWithCoordinates(socketName, socketOrdinal);
        }
        else if (targetNode is IDynamicInputNode dynamicInput)
        {
            // Other dynamic input nodes - add standard input (limited capability)
            dynamicInput.AddInput();
        }
        else
        {
            // For static nodes, create a basic input socket manually if possible
            var label = GetInputSocketLabel(socketName, socketOrdinal);
            var input = new SceneInputConnectorViewModel($"({socketName},{socketOrdinal})", $"({socketName},{socketOrdinal})", targetNode.UniqueId, socketName, socketOrdinal);
            input.Subtitle = label;
            targetNode.Input.Add(input);
            
            _loggerService?.Info($"Created missing input socket ({socketName},{socketOrdinal}) on node {targetNode.UniqueId}");
        }
    }

    /// <summary>
    /// Determines if a socket is a cut destination socket that should trigger failsafe logic
    /// </summary>
    /// <param name="socket">The input socket to check</param>
    /// <returns>True if this is a cut destination socket</returns>
    private bool IsCutDestinationSocket(SceneInputConnectorViewModel socket)
    {
        // Check for cut destination patterns based on socket coordinates and target node type
        var targetNode = Nodes.FirstOrDefault(n => n.UniqueId == socket.OwnerId) as BaseSceneViewModel;
        
        if (targetNode == null) return false;

        // Pattern 1: Cancel socket (1,0) - traditional scene nodes
        if (socket.NameId == 1 && socket.Ordinal == 0)
        {
            return true;
        }

        // Pattern 2: Quest node cut destination (0,0) - quest nodes use this for cut destination
        if (socket.NameId == 0 && socket.Ordinal == 0 && targetNode.Data is scnQuestNode)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Gets a human-readable label for an input socket based on its coordinates
    /// </summary>
    /// <param name="name">Socket name coordinate</param>
    /// <param name="ordinal">Socket ordinal coordinate</param>
    /// <returns>Human-readable socket label</returns>
    private static string GetInputSocketLabel(ushort name, ushort ordinal)
    {
        return (name, ordinal) switch
        {
            (0, 0) => "In",
            (1, 0) => "Cancel",
            (666, 0) => "In",
            (666, 1) => "In1",
            (666, var ord) => $"In{ord}",
            (1026, 0) => "Failsafe",
            (1026, var ord) => $"Failsafe{ord}",
            _ => $"In_{name}_{ordinal}"
        };
    }

    public static RedGraph GenerateSceneGraph(string title, scnSceneResource sceneResource, RedDocumentViewModel doc)
    {
        var graph = new RedGraph(title, sceneResource, doc);

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

        // Socket Discovery Phase: Ensure all necessary sockets exist before creating connections
        foreach (var node in graph.Nodes)
        {
            var sceneNode = (BaseSceneViewModel)node;

            foreach (var outputConnector in sceneNode.Output)
            {
                var sceneOutputConnector = (SceneOutputConnectorViewModel)outputConnector;

                if (sceneOutputConnector.Data == null)
                {
                    continue;
                }
                
                foreach (var destination in sceneOutputConnector.Data!.Destinations)
                {
                    if (!nodeCache.TryGetValue(destination.NodeId.Id, out var targetNode))
                    {
                        continue; // Skip if target node doesn't exist
                    }

                    // Check if target node has the required input socket
                    var existingSocket = targetNode.Input
                        .Cast<SceneInputConnectorViewModel>()
                        .FirstOrDefault(x => x.NameId == destination.IsockStamp.Name && x.Ordinal == destination.IsockStamp.Ordinal);

                    // If socket doesn't exist, try to create it
                    if (existingSocket == null)
                    {
                        graph.EnsureInputSocket(targetNode, destination.IsockStamp.Name, destination.IsockStamp.Ordinal);
                    }
                }
            }
        }

        // Connection Creation Phase: Now that all sockets exist, create the connections
        foreach (var node in graph.Nodes)
        {
            var sceneNode = (BaseSceneViewModel)node;

            foreach (var outputConnector in sceneNode.Output)
            {
                var sceneOutputConnector = (SceneOutputConnectorViewModel)outputConnector;

                if (sceneOutputConnector.Data == null)
                {
                    continue;
                }
                
                foreach (var destination in sceneOutputConnector.Data!.Destinations)
                {
                    if (!nodeCache.TryGetValue(destination.NodeId.Id, out var targetNode))
                    {
                        continue; // Skip if target node doesn't exist
                    }

                    var sceneInputConnector = targetNode.Input
                        .Cast<SceneInputConnectorViewModel>()
                        .FirstOrDefault(x => x.NameId == destination.IsockStamp.Name && x.Ordinal == destination.IsockStamp.Ordinal);

                    if (sceneInputConnector != null)
                    {
                        graph.Connections.Add(new SceneConnectionViewModel(outputConnector, sceneInputConnector));
                    }
                    else
                    {
                        // Skip logging warnings for (1026,0) - these are intentionally hidden failsafe connections
                        if (!(destination.IsockStamp.Name == 1026 && destination.IsockStamp.Ordinal == 0))
                        {
                            _loggerService?.Warning($"Could not find input socket ({destination.IsockStamp.Name},{destination.IsockStamp.Ordinal}) on node {destination.NodeId.Id} in file: {title}");
                        }
                    }
                }
            }
        }

        return graph;
    }

    // Overload for backward compatibility when document is not available
    public static RedGraph GenerateSceneGraph(string title, scnSceneResource sceneResource)
    {
        // Create a graph without document reference - used for sub-graphs like quest scene nodes
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

        // Socket Discovery Phase: Ensure all necessary sockets exist before creating connections
        foreach (var node in graph.Nodes)
        {
            var sceneNode = (BaseSceneViewModel)node;

            foreach (var outputConnector in sceneNode.Output)
            {
                var sceneOutputConnector = (SceneOutputConnectorViewModel)outputConnector;

                if (sceneOutputConnector.Data == null)
                {
                    continue;
                }
                
                foreach (var destination in sceneOutputConnector.Data!.Destinations)
                {
                    if (!nodeCache.TryGetValue(destination.NodeId.Id, out var targetNode))
                    {
                        continue; // Skip if target node doesn't exist
                    }

                    // Check if target node has the required input socket
                    var existingSocket = targetNode.Input
                        .Cast<SceneInputConnectorViewModel>()
                        .FirstOrDefault(x => x.NameId == destination.IsockStamp.Name && x.Ordinal == destination.IsockStamp.Ordinal);

                    // If socket doesn't exist, try to create it
                    if (existingSocket == null)
                    {
                        graph.EnsureInputSocket(targetNode, destination.IsockStamp.Name, destination.IsockStamp.Ordinal);
                    }
                }
            }
        }

        // Connection Creation Phase: Now that all sockets exist, create the connections
        foreach (var node in graph.Nodes)
        {
            var sceneNode = (BaseSceneViewModel)node;

            foreach (var outputConnector in sceneNode.Output)
            {
                var sceneOutputConnector = (SceneOutputConnectorViewModel)outputConnector;

                if (sceneOutputConnector.Data == null)
                {
                    continue;
                }
                
                foreach (var destination in sceneOutputConnector.Data!.Destinations)
                {
                    if (!nodeCache.TryGetValue(destination.NodeId.Id, out var targetNode))
                    {
                        continue; // Skip if target node doesn't exist
                    }

                    var sceneInputConnector = targetNode.Input
                        .Cast<SceneInputConnectorViewModel>()
                        .FirstOrDefault(x => x.NameId == destination.IsockStamp.Name && x.Ordinal == destination.IsockStamp.Ordinal);

                    if (sceneInputConnector != null)
                    {
                        graph.Connections.Add(new SceneConnectionViewModel(outputConnector, sceneInputConnector));
                    }
                    else
                    {
                        // Skip logging warnings for (1026,0) - these are intentionally hidden failsafe connections
                        if (!(destination.IsockStamp.Name == 1026 && destination.IsockStamp.Ordinal == 0))
                        {
                            _loggerService?.Warning($"Could not find input socket ({destination.IsockStamp.Name},{destination.IsockStamp.Ordinal}) on node {destination.NodeId.Id} in file: {title}");
                        }
                    }
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

    private RedGraph(string title, scnSceneResource data, RedDocumentViewModel doc) : this(title, (IRedType)data)
    {
        DocumentViewModel = doc;
    }

    // Constructor overload for backward compatibility when document is not available
    private RedGraph(string title, scnSceneResource data) : this(title, (IRedType)data)
    {
        DocumentViewModel = null; // Sub-graphs don't have document reference
    }
}
