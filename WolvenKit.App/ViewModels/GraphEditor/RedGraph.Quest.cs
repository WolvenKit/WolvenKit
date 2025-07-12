using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.GraphEditor;

public partial class RedGraph
{
    private static Dictionary<Type, Type> s_questWrapperMap = new();

    private static List<Type>? s_questNodeTypes;

    private INodeWrapperFactory? _nodeWrapperFactory;

    private static void GenerateQuestWrapperMap()
    {
        s_questWrapperMap.Add(typeof(questAchievementManagerNodeDefinition), typeof(questAchievementManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questConditionNodeDefinition), typeof(questConditionNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questCrowdManagerNodeDefinition), typeof(questCrowdManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questCutControlNodeDefinition), typeof(questCutControlNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questDynamicSpawnSystemNodeDefinition), typeof(questDynamicSpawnSystemNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questEntityManagerNodeDefinition), typeof(questEntityManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questEnvironmentManagerNodeDefinition), typeof(questEnvironmentManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questEventManagerNodeDefinition), typeof(questEventManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questFactsDBManagerNodeDefinition), typeof(questFactsDBManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questFlowControlNodeDefinition), typeof(questFlowControlNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questFXManagerNodeDefinition), typeof(questFXManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questInstancedCrowdControlNodeDefinition), typeof(questInstancedCrowdControlNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questInteractiveObjectManagerNodeDefinition), typeof(questInteractiveObjectManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questItemManagerNodeDefinition), typeof(questItemManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questMappinManagerNodeDefinition), typeof(questMappinManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questPuppetAIManagerNodeDefinition), typeof(questPuppetAIManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questRandomizerNodeDefinition), typeof(questRandomizerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questRenderFxManagerNodeDefinition), typeof(questRenderFxManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questRewardManagerNodeDefinition), typeof(questRewardManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questSwitchNodeDefinition), typeof(questSwitchNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questTimeManagerNodeDefinition), typeof(questTimeManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questTriggerManagerNodeDefinition), typeof(questTriggerManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questVisionModesManagerNodeDefinition), typeof(questVisionModesManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questVoicesetManagerNodeDefinition), typeof(questVoicesetManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(tempshitMapPinManagerNodeDefinition), typeof(tempshitMapPinManagerNodeDefinitionWrapper));

        // questIONodeDefinition
        s_questWrapperMap.Add(typeof(questInputNodeDefinition), typeof(questInputNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questOutputNodeDefinition), typeof(questOutputNodeDefinitionWrapper));

        // questSignalStoppingNodeDefinition
        s_questWrapperMap.Add(typeof(questAudioNodeDefinition), typeof(questAudioNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questCharacterManagerNodeDefinition), typeof(questCharacterManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questCheckpointNodeDefinition), typeof(questCheckpointNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questClearForcedBehavioursNodeDefinition), typeof(questClearForcedBehavioursNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questDeletionMarkerNodeDefinition), typeof(questDeletionMarkerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questForcedBehaviourNodeDefinition), typeof(questForcedBehaviourNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questJournalNodeDefinition), typeof(questJournalNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questPauseConditionNodeDefinition), typeof(questPauseConditionNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questPhoneManagerNodeDefinition), typeof(questPhoneManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questSceneManagerNodeDefinition), typeof(questSceneManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questSceneNodeDefinition), typeof(questSceneNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questSpawnManagerNodeDefinition), typeof(questSpawnManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questTransformAnimatorNodeDefinition), typeof(questTransformAnimatorNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questUIManagerNodeDefinition), typeof(questUIManagerNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questVehicleNodeDefinition), typeof(questVehicleNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questWorldDataManagerNodeDefinition), typeof(questWorldDataManagerNodeDefinitionWrapper));
        // -- questAICommandNodeBase
        s_questWrapperMap.Add(typeof(questEquipItemNodeDefinition), typeof(questEquipItemNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questSendAICommandNodeDefinition), typeof(questSendAICommandNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questTeleportPuppetNodeDefinition), typeof(questTeleportPuppetNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questUseWorkspotNodeDefinition), typeof(questUseWorkspotNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questVehicleNodeCommandDefinition), typeof(questVehicleNodeCommandDefinitionWrapper));
        // ---- questConfigurableAICommandNode
        s_questWrapperMap.Add(typeof(questCombatNodeDefinition), typeof(questCombatNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questMiscAICommandNode), typeof(questMiscAICommandNodeWrapper));
        s_questWrapperMap.Add(typeof(questMovePuppetNodeDefinition), typeof(questMovePuppetNodeDefinitionWrapper));
        // -- questEmbeddedGraphNodeDefinition
        s_questWrapperMap.Add(typeof(questPhaseNodeDefinition), typeof(questPhaseNodeDefinitionWrapper));
        // -- questLogicalBaseNodeDefinition
        s_questWrapperMap.Add(typeof(questLogicalAndNodeDefinition), typeof(questLogicalAndNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questLogicalHubNodeDefinition), typeof(questLogicalHubNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questLogicalXorNodeDefinition), typeof(questLogicalXorNodeDefinitionWrapper));
        // -- questTypedSignalStoppingNodeDefinition
        s_questWrapperMap.Add(typeof(questGameManagerNodeDefinition), typeof(questGameManagerNodeDefinitionWrapper));

        // questStartEndNodeDefinition
        s_questWrapperMap.Add(typeof(questEndNodeDefinition), typeof(questEndNodeDefinitionWrapper));
        s_questWrapperMap.Add(typeof(questStartNodeDefinition), typeof(questStartNodeDefinitionWrapper));

        s_questWrapperMap.Add(typeof(questNodeDefinition), typeof(questNodeDefinitionWrapper));
    }

    public List<Type> GetQuestNodeTypes()
    {
        if (s_questNodeTypes == null)
        {
            s_questNodeTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(questNodeDefinition).IsAssignableFrom(x) && !x.IsAbstract)
                .ToList();
        }

        return s_questNodeTypes;
    }

    public void CreateQuestNode(Type type, System.Windows.Point point)
    {
        var instance = InternalCreateQuestNode(type);
        var wrappedInstance = WrapQuestNode(instance, true);
        wrappedInstance.Location = point;

        ((graphGraphDefinition)_data).Nodes.Add(new CHandle<graphGraphNodeDefinition>(instance));
        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        Nodes.Add(wrappedInstance);
    }

    private graphGraphNodeDefinition InternalCreateQuestNode(Type type)
    {
        var instance = System.Activator.CreateInstance(type);
        if (instance is not graphGraphNodeDefinition questNode)
        {
            throw new Exception();
        }

        if (instance is questNodeDefinition nodeDefinition)
        {
            nodeDefinition.Id = ++_currentQuestNodeId;

            // Special initialization for certain quest node types
            if (nodeDefinition is questFactsDBManagerNodeDefinition factsDBNode)
            {
                // Initialize the Type property with questSetVar_NodeType (the only implementation)
                factsDBNode.Type = new CHandle<questIFactsDBManagerNodeType>(new questSetVar_NodeType());
            }
        }

        return questNode;
    }

    /// <summary>
    /// Determines if a quest node should use a deletion marker when deleted
    /// </summary>
    private static bool ShouldUseDeletionMarker(BaseQuestViewModel node)
    {
        // Check if it's a signal-stopping node (blocks quest progression)
        if (node.Data is questSignalStoppingNodeDefinition)
        {
            return true;
        }

        // Additional nodes that should use deletion markers for safety
        var criticalTypes = new[]
        {
            typeof(questSwitchNodeDefinition),
            typeof(questFlowControlNodeDefinition)
        };

        return criticalTypes.Contains(node.Data.GetType());
    }

    /// <summary>
    /// Replace a quest node with a deletion marker node that preserves all connections
    /// </summary>
    /// <param name="node">The quest node to replace with a deletion marker</param>
    private void ReplaceNodeWithQuestDeletionMarkerInternal(BaseQuestViewModel node)
    {
        if (_data is not graphGraphDefinition graphDefinition)
        {
            _loggerService?.Error("Cannot replace quest node with deletion marker: not a quest graph");
            return;
        }

        if (node.Data is questDeletionMarkerNodeDefinition)
        {
            _loggerService?.Warning("Cannot replace a deletion marker with another deletion marker");
            return;
        }

        if (node.Data is not questNodeDefinition originalQuestNode)
        {
            _loggerService?.Error("Cannot replace non-quest node with quest deletion marker");
            return;
        }

        // 1. Create a quest deletion marker with the same ID as the node being replaced
        var deletionMarker = new questDeletionMarkerNodeDefinition
        {
            Id = originalQuestNode.Id
        };

        // 2. Store the ID of the deleted node
        deletionMarker.DeletedNodeIds.Add(originalQuestNode.Id);

        // 3. Create a node wrapper for the deletion marker (this will create default sockets)
        var markerWrapper = new questDeletionMarkerNodeDefinitionWrapper(deletionMarker);
        markerWrapper.Location = node.Location;
        markerWrapper.DocumentViewModel = DocumentViewModel;

        // 4. Generate the default sockets for the deletion marker (CutDestination, In, Out)
        markerWrapper.CreateDefaultSockets();
        markerWrapper.GenerateSockets();

        // 5. Remove the original node from the graph data
        for (var i = graphDefinition.Nodes.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(graphDefinition.Nodes[i].Chunk, node.Data))
            {
                graphDefinition.Nodes.RemoveAt(i);
                break;
            }
        }

        // 6. Add the deletion marker node to the graph data
        graphDefinition.Nodes.Add(new CHandle<graphGraphNodeDefinition>(deletionMarker));

        // 7. Replace the node in the UI
        var nodeIndex = Nodes.IndexOf(node);
        if (nodeIndex >= 0)
        {
            Nodes[nodeIndex] = markerWrapper;
        }
        else
        {
            Nodes.Remove(node);
            Nodes.Add(markerWrapper);
        }

        // 8. Map connections from original node to deletion marker's default sockets
        MapConnectionsToStandardSockets(originalQuestNode, markerWrapper);

        // 9. Update properties in the nodes collection
        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        // Save graph state and mark document as dirty
        GraphStateSave();
        DocumentViewModel?.SetIsDirty(true);

        _loggerService?.Info($"Replaced quest node {node.UniqueId} with a deletion marker");
    }

    /// <summary>
    /// Maps connections from the original node to the deletion marker's standard sockets (In, Out, CutDestination)
    /// </summary>
    /// <param name="originalNode">The original node that was replaced</param>
    /// <param name="markerWrapper">The deletion marker wrapper with default sockets</param>
    private void MapConnectionsToStandardSockets(questNodeDefinition originalNode, questDeletionMarkerNodeDefinitionWrapper markerWrapper)
    {
        // Get the deletion marker's default sockets
        var markerInSocket = markerWrapper.Input.FirstOrDefault(s => s.Name == "In") as QuestInputConnectorViewModel;
        var markerOutSocket = markerWrapper.Output.FirstOrDefault(s => s.Name == "Out") as QuestOutputConnectorViewModel;
        var markerCutDestSocket = markerWrapper.Input.FirstOrDefault(s => s.Name == "CutDestination") as QuestInputConnectorViewModel;

        if (markerInSocket == null || markerOutSocket == null || markerCutDestSocket == null)
        {
            _loggerService?.Error("Failed to find deletion marker's default sockets");
            return;
        }

        // Process each socket from the original node
        foreach (var originalSocketHandle in originalNode.Sockets)
        {
            var originalSocket = originalSocketHandle.Chunk;
            if (originalSocket == null) continue;

            // Process each connection from this socket
            foreach (var connectionHandle in originalSocket.Connections.ToList())
            {
                var connection = connectionHandle.Chunk;
                if (connection == null) continue;

                // Determine if this is an input or output connection from the original node's perspective
                bool isInputConnection = ReferenceEquals(connection.Destination.Chunk, originalSocket);
                bool isOutputConnection = ReferenceEquals(connection.Source.Chunk, originalSocket);

                if (isInputConnection)
                {
                    // Connection coming TO the original node -> redirect to deletion marker's In socket
                    // (unless it's a CutDestination type, then use CutDestination socket)
                    var targetSocket = markerInSocket; // Default to In socket
                    if (originalSocket is questSocketDefinition questSocket && questSocket.Type == Enums.questSocketType.CutDestination)
                    {
                        targetSocket = markerCutDestSocket;
                    }

                    connection.Destination = new CWeakHandle<graphGraphSocketDefinition>(targetSocket.Data);

                    // Remove from original socket and add to new socket
                    originalSocket.Connections.Remove(connectionHandle);
                    targetSocket.Data.Connections.Add(connectionHandle);
                }
                else if (isOutputConnection)
                {
                    // Connection going FROM the original node -> redirect from deletion marker's Out socket
                    connection.Source = new CWeakHandle<graphGraphSocketDefinition>(markerOutSocket.Data);

                    // Remove from original socket and add to new socket
                    originalSocket.Connections.Remove(connectionHandle);
                    markerOutSocket.Data.Connections.Add(connectionHandle);
                }
            }
        }

        // Update connection states
        markerInSocket.IsConnected = markerInSocket.Data.Connections.Count > 0;
        markerOutSocket.IsConnected = markerOutSocket.Data.Connections.Count > 0;
        markerCutDestSocket.IsConnected = markerCutDestSocket.Data.Connections.Count > 0;

        // Rebuild UI connections
        RebuildQuestConnections();
    }

    /// <summary>
    /// Rebuilds the quest connections in the UI after socket changes
    /// </summary>
    private void RebuildQuestConnections()
    {
        Connections.Clear();

        // Create socket lookup table for quest input connectors
        var socketNodeLookup = new Dictionary<graphGraphSocketDefinition, QuestInputConnectorViewModel>();
        foreach (var nodeViewModel in Nodes.OfType<BaseQuestViewModel>())
        {
            foreach (var inputConnector in nodeViewModel.Input.OfType<QuestInputConnectorViewModel>())
            {
                socketNodeLookup[inputConnector.Data] = inputConnector;
            }
        }

        // Rebuild connections by iterating through output connectors
        foreach (var nodeViewModel in Nodes.OfType<BaseQuestViewModel>())
        {
            foreach (var outputConnector in nodeViewModel.Output.OfType<QuestOutputConnectorViewModel>())
            {
                foreach (var connectionHandle in outputConnector.Data.Connections)
                {
                    var connection = connectionHandle.Chunk;
                    if (connection?.Destination?.Chunk != null && socketNodeLookup.TryGetValue(connection.Destination.Chunk, out var targetInput))
                    {
                        Connections.Add(new QuestConnectionViewModel(outputConnector, targetInput, connection));
                    }
                }
            }
        }
    }

    /// <summary>
    /// Replace a quest node with a deletion marker node that preserves all connections
    /// </summary>
    /// <param name="node">The quest node to replace with a deletion marker</param>
    private void ReplaceNodeWithQuestDeletionMarkerInternal(BaseQuestViewModel node)
    {
        if (_data is not graphGraphDefinition graphDefinition)
        {
            _loggerService?.Error("Cannot replace quest node with deletion marker: not a quest graph");
            return;
        }

        if (node.Data is questDeletionMarkerNodeDefinition)
        {
            _loggerService?.Warning("Cannot replace a deletion marker with another deletion marker");
            return;
        }

        if (node.Data is not questNodeDefinition originalQuestNode)
        {
            _loggerService?.Error("Cannot replace non-quest node with quest deletion marker");
            return;
        }

        // 1. Create a quest deletion marker with the same ID as the node being replaced
        var deletionMarker = new questDeletionMarkerNodeDefinition
        {
            Id = originalQuestNode.Id
        };

        // 2. Store the ID of the deleted node
        deletionMarker.DeletedNodeIds.Add(originalQuestNode.Id);

        // 3. Create a node wrapper for the deletion marker (this will create default sockets)
        var markerWrapper = new questDeletionMarkerNodeDefinitionWrapper(deletionMarker);
        markerWrapper.Location = node.Location;
        markerWrapper.DocumentViewModel = DocumentViewModel;

        // 4. Generate the default sockets for the deletion marker (CutDestination, In, Out)
        markerWrapper.CreateDefaultSockets();
        markerWrapper.GenerateSockets();

        // 5. Remove the original node from the graph data
        for (var i = graphDefinition.Nodes.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(graphDefinition.Nodes[i].Chunk, node.Data))
            {
                graphDefinition.Nodes.RemoveAt(i);
                break;
            }
        }

        // 6. Add the deletion marker node to the graph data
        graphDefinition.Nodes.Add(new CHandle<graphGraphNodeDefinition>(deletionMarker));

        // 7. Replace the node in the UI
        var nodeIndex = Nodes.IndexOf(node);
        if (nodeIndex >= 0)
        {
            Nodes[nodeIndex] = markerWrapper;
        }
        else
        {
            Nodes.Remove(node);
            Nodes.Add(markerWrapper);
        }

        // 8. Map connections from original node to deletion marker's default sockets
        MapConnectionsToStandardSockets(originalQuestNode, markerWrapper);

        // 9. Update properties in the nodes collection
        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        // Save graph state and mark document as dirty
        GraphStateSave();
        DocumentViewModel?.SetIsDirty(true);

        _loggerService?.Info($"Replaced quest node {node.UniqueId} with a deletion marker");
    }

    /// <summary>
    /// Maps connections from the original node to the deletion marker's standard sockets (In, Out, CutDestination)
    /// </summary>
    /// <param name="originalNode">The original node that was replaced</param>
    /// <param name="markerWrapper">The deletion marker wrapper with default sockets</param>
    private void MapConnectionsToStandardSockets(questNodeDefinition originalNode, questDeletionMarkerNodeDefinitionWrapper markerWrapper)
    {
        // Get the deletion marker's default sockets
        var markerInSocket = markerWrapper.Input.FirstOrDefault(s => s.Name == "In") as QuestInputConnectorViewModel;
        var markerOutSocket = markerWrapper.Output.FirstOrDefault(s => s.Name == "Out") as QuestOutputConnectorViewModel;
        var markerCutDestSocket = markerWrapper.Input.FirstOrDefault(s => s.Name == "CutDestination") as QuestInputConnectorViewModel;

        if (markerInSocket == null || markerOutSocket == null || markerCutDestSocket == null)
        {
            _loggerService?.Error("Failed to find deletion marker's default sockets");
            return;
        }

        // Process each socket from the original node
        foreach (var originalSocketHandle in originalNode.Sockets)
        {
            var originalSocket = originalSocketHandle.Chunk;
            if (originalSocket == null) continue;

            // Process each connection from this socket
            foreach (var connectionHandle in originalSocket.Connections.ToList())
            {
                var connection = connectionHandle.Chunk;
                if (connection == null) continue;

                // Determine if this is an input or output connection from the original node's perspective
                bool isInputConnection = ReferenceEquals(connection.Destination.Chunk, originalSocket);
                bool isOutputConnection = ReferenceEquals(connection.Source.Chunk, originalSocket);

                if (isInputConnection)
                {
                    // Connection coming TO the original node -> redirect to deletion marker's In socket
                    // (unless it's a CutDestination type, then use CutDestination socket)
                    var targetSocket = markerInSocket; // Default to In socket
                    if (originalSocket is questSocketDefinition questSocket && questSocket.Type == Enums.questSocketType.CutDestination)
                    {
                        targetSocket = markerCutDestSocket;
                    }

                    connection.Destination = new CWeakHandle<graphGraphSocketDefinition>(targetSocket.Data);

                    // Remove from original socket and add to new socket
                    originalSocket.Connections.Remove(connectionHandle);
                    targetSocket.Data.Connections.Add(connectionHandle);
                }
                else if (isOutputConnection)
                {
                    // Connection going FROM the original node -> redirect from deletion marker's Out socket
                    connection.Source = new CWeakHandle<graphGraphSocketDefinition>(markerOutSocket.Data);

                    // Remove from original socket and add to new socket
                    originalSocket.Connections.Remove(connectionHandle);
                    markerOutSocket.Data.Connections.Add(connectionHandle);
                }
            }
        }

        // Update connection states
        markerInSocket.IsConnected = markerInSocket.Data.Connections.Count > 0;
        markerOutSocket.IsConnected = markerOutSocket.Data.Connections.Count > 0;
        markerCutDestSocket.IsConnected = markerCutDestSocket.Data.Connections.Count > 0;

        // Rebuild UI connections
        RebuildQuestConnections();
    }

    /// <summary>
    /// Rebuilds the quest connections in the UI after socket changes
    /// </summary>
    private void RebuildQuestConnections()
    {
        Connections.Clear();

        // Create socket lookup table for quest input connectors
        var socketNodeLookup = new Dictionary<graphGraphSocketDefinition, QuestInputConnectorViewModel>();
        foreach (var nodeViewModel in Nodes.OfType<BaseQuestViewModel>())
        {
            foreach (var inputConnector in nodeViewModel.Input.OfType<QuestInputConnectorViewModel>())
            {
                socketNodeLookup[inputConnector.Data] = inputConnector;
            }
        }

        // Rebuild connections by iterating through output connectors
        foreach (var nodeViewModel in Nodes.OfType<BaseQuestViewModel>())
        {
            foreach (var outputConnector in nodeViewModel.Output.OfType<QuestOutputConnectorViewModel>())
            {
                foreach (var connectionHandle in outputConnector.Data.Connections)
                {
                    var connection = connectionHandle.Chunk;
                    if (connection?.Destination?.Chunk != null && socketNodeLookup.TryGetValue(connection.Destination.Chunk, out var targetInput))
                    {
                        Connections.Add(new QuestConnectionViewModel(outputConnector, targetInput, connection));
                    }
                }
            }
        }
    }

    private void RemoveQuestNode(BaseQuestViewModel node)
    {
        foreach (var inputConnectorViewModel in node.Input)
        {
            Disconnect(inputConnectorViewModel);
        }

        foreach (var outputConnectorViewModel in node.Output)
        {
            Disconnect(outputConnectorViewModel);
        }

        var graph = ((graphGraphDefinition)_data).Nodes;
        for (var i = graph.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(graph[i].Chunk, node.Data))
            {
                graph.RemoveAt(i);

                if (GetQuestNodesChunkViewModel() is { } nodes)
                {
                    nodes.RecalculateProperties();
                }
            }
        }

        Nodes.Remove(node);
    }

    private Type GetWrapperType(Type type)
    {
        foreach (var (nativeType, wrapperType) in s_questWrapperMap)
        {
            if (type.IsAssignableTo(nativeType))
            {
                return wrapperType;
            }
        }

        return typeof(graphGraphNodeDefinitionWrapper);
    }

    private BaseQuestViewModel WrapQuestNode(graphGraphNodeDefinition node, bool isNew)
    {
        var wrapperType = GetWrapperType(node.GetType());

        BaseQuestViewModel nodeWrapper;
        if (wrapperType == typeof(questPhaseNodeDefinitionWrapper))
        {
            nodeWrapper = _nodeWrapperFactory!.QuestPhaseNodeDefinitionWrapper((questPhaseNodeDefinition)node);
        }
        else if (wrapperType == typeof(questSceneNodeDefinitionWrapper))
        {
            nodeWrapper = _nodeWrapperFactory!.QuestSceneNodeDefinitionWrapper((questSceneNodeDefinition)node);
        }
        else
        {
            if (System.Activator.CreateInstance(wrapperType, [node]) is not BaseQuestViewModel tmp)
            {
                throw new Exception();
            }
            nodeWrapper = tmp;
        }

        if (isNew)
        {
            nodeWrapper.CreateDefaultSockets();
        }

        nodeWrapper.GenerateSockets();

        // Set document reference for property change syncing
        nodeWrapper.DocumentViewModel = DocumentViewModel;

        return nodeWrapper;
    }

    private DynamicQuestViewModel WrapDynamicQuestNode(DynamicBaseClass node, bool isNew)
    {
        var nodeWrapper = new DynamicQuestViewModel(node);

        if (isNew)
        {
            nodeWrapper.CreateDefaultSockets();
        }

        nodeWrapper.GenerateSockets();

        // Set document reference for property change syncing
        nodeWrapper.DocumentViewModel = DocumentViewModel;

        return nodeWrapper;
    }

    private void ConnectQuest(QuestOutputConnectorViewModel questSource, QuestInputConnectorViewModel questTarget)
    {
        for (var i = Connections.Count - 1; i >= 0; i--)
        {
            if (!ReferenceEquals(Connections[i].Source, questSource) ||
                !ReferenceEquals(Connections[i].Target, questTarget))
            {
                continue;
            }

            for (var j = questSource.Data.Connections.Count - 1; j >= 0; j--)
            {
                if (ReferenceEquals(questSource.Data.Connections[j].Chunk!.Destination.Chunk, questTarget.Data))
                {
                    questSource.Data.Connections.RemoveAt(j);
                }
            }

            for (var j = questTarget.Data.Connections.Count - 1; j >= 0; j--)
            {
                if (ReferenceEquals(questTarget.Data.Connections[j].Chunk!.Source.Chunk, questSource.Data))
                {
                    questTarget.Data.Connections.RemoveAt(j);
                }
            }

            questSource.IsConnected = questSource.Data.Connections.Count > 0;
            questTarget.IsConnected = questTarget.Data.Connections.Count > 0;

            Connections.RemoveAt(i);
            RefreshCVM([questSource.Data, questTarget.Data]);

            // Notify UI to refresh affected nodes
            NotifyNodesUpdated(questSource.OwnerId, questTarget.OwnerId);

            // Mark document as dirty since we modified connections
            DocumentViewModel?.SetIsDirty(true);

            return;
        }

        var graphGraphConnectionDefinition = new graphGraphConnectionDefinition
        {
            Source = new CWeakHandle<graphGraphSocketDefinition>(questSource.Data),
            Destination = new CWeakHandle<graphGraphSocketDefinition>(questTarget.Data)
        };
        var handle = new CHandle<graphGraphConnectionDefinition>(graphGraphConnectionDefinition);

        questSource.Data.Connections.Add(handle);
        questTarget.Data.Connections.Add(handle);

        Connections.Add(new QuestConnectionViewModel(questSource, questTarget, graphGraphConnectionDefinition));

        // Refresh ChunkViewModels representing the involved sockets
        RefreshCVM([questSource.Data, questTarget.Data]);

        // Notify UI to refresh affected nodes
        NotifyNodesUpdated(questSource.OwnerId, questTarget.OwnerId);

        // Mark document as dirty since we modified connections
        DocumentViewModel?.SetIsDirty(true);
    }

    private void RefreshCVM(questSocketDefinition[] sockets)
    {
        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
            // Ensure properties are up-to-date before searching
            nodes.RecalculateProperties();
            nodes.ForceLoadPropertiesRecursive();

            var list = new List<ChunkViewModel>();
            foreach (var property in nodes.GetAllProperties())
            {
                foreach (var socket in sockets)
                {
                    if (ReferenceEquals(property.Data, socket.Connections))
                    {
                        list.Add(property.Parent!);
                    }
                }
            }
            foreach (var model in list)
            {
                model.RecalculateProperties();
                model.NotifyChain(nameof(model.Properties));
            }

            // Additionally refresh the root nodes collection to ensure UI picks up structural changes
            nodes.RecalculateProperties();
            nodes.NotifyChain(nameof(nodes.Properties));
        }
    }

    private ChunkViewModel? GetQuestNodesChunkViewModel()
    {
        if (DocumentViewModel?.GetMainFile() is not RDTDataViewModel dataViewModel)
        {
            return null;
        }

        if (dataViewModel.Chunks[0].GetPropertyFromPath("graph.nodes") is not { } nodes)
        {
            return null;
        }

        return nodes;
    }

    private void AddQuestConnection(QuestOutputConnectorViewModel source, QuestInputConnectorViewModel destination)
    {
        var connection = new graphGraphConnectionDefinition()
        {
            Source = new CWeakHandle<graphGraphSocketDefinition>(source.Data),
            Destination = new CWeakHandle<graphGraphSocketDefinition>(destination.Data)
        };

        source.Data.Connections.Add(new CHandle<graphGraphConnectionDefinition>(connection));
        destination.Data.Connections.Add(new CHandle<graphGraphConnectionDefinition>(connection));

        Connections.Add(new QuestConnectionViewModel(source, destination, connection));

        // Notify UI to refresh affected nodes
        NotifyNodesUpdated(source.OwnerId, destination.OwnerId);

        // Mark document as dirty since we modified connections
        DocumentViewModel?.SetIsDirty(true);
    }

    private void RemoveQuestConnection(QuestConnectionViewModel questConnection)
    {
        var questSource = (QuestOutputConnectorViewModel)questConnection.Source;
        var questDestination = (QuestInputConnectorViewModel)questConnection.Target;

        for (var i = questSource.Data.Connections.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(questSource.Data.Connections[i].Chunk, questConnection.ConnectionDefinition))
            {
                questSource.Data.Connections.RemoveAt(i);
                questSource.IsConnected = questSource.Data.Connections.Count > 0;
            }
        }

        for (var i = questDestination.Data.Connections.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(questDestination.Data.Connections[i].Chunk, questConnection.ConnectionDefinition))
            {
                questDestination.Data.Connections.RemoveAt(i);
                questDestination.IsConnected = questDestination.Data.Connections.Count > 0;
            }
        }
        Connections.Remove(questConnection);

        // Notify UI to refresh affected nodes
        NotifyNodesUpdated(questSource.OwnerId, questDestination.OwnerId);

        // Mark document as dirty since we modified connections
        DocumentViewModel?.SetIsDirty(true);
    }

    public void RemoveQuestConnectionPublic(QuestConnectionViewModel questConnection)
    {
        RemoveQuestConnection(questConnection);
        RefreshCVM(new[] { ((QuestOutputConnectorViewModel)questConnection.Source).Data, ((QuestInputConnectorViewModel)questConnection.Target).Data });
    }

    public void DuplicateQuestNode(BaseQuestViewModel originalNode)
    {
        if (originalNode.Data is not IRedCloneable cloneable)
        {
            _loggerService?.Error($"Cannot duplicate node of type {originalNode.Data.GetType().Name} - it doesn't implement IRedCloneable");
            return;
        }

        var duplicatedData = (questNodeDefinition)cloneable.DeepCopy();

        var newNodeId = GetNextAvailableQuestNodeId();
        duplicatedData.Id = newNodeId;
        _currentQuestNodeId = Math.Max(_currentQuestNodeId, newNodeId);

        foreach (var socket in duplicatedData.Sockets)
        {
            if (socket.Chunk is questSocketDefinition socketDef)
            {
                socketDef.Connections.Clear();
            }
        }

        var wrappedDuplicate = WrapQuestNode(duplicatedData, false);

        wrappedDuplicate.Location = new System.Windows.Point(
            originalNode.Location.X + 50,
            originalNode.Location.Y + 50
        );

        ((graphGraphDefinition)_data).Nodes.Add(new CHandle<graphGraphNodeDefinition>(duplicatedData));

        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        Nodes.Add(wrappedDuplicate);

        _loggerService?.Info($"Duplicated quest node with new ID: {duplicatedData.Id}");
    }

    private ushort GetNextAvailableQuestNodeId()
    {
        var questGraph = (graphGraphDefinition)_data;

        ushort candidateId = (ushort)(_currentQuestNodeId + 1);

        if (candidateId != ushort.MaxValue && !IsQuestNodeIdInUse(candidateId, questGraph))
        {
            return candidateId;
        }

        // Fallback: if there's a collision, keep searching
        do
        {
            candidateId++;
        } while (candidateId != ushort.MaxValue && IsQuestNodeIdInUse(candidateId, questGraph));

        if (candidateId == ushort.MaxValue)
        {
            _loggerService?.Error("No available quest node IDs remaining!");
        }

        return candidateId;
    }

    private bool IsQuestNodeIdInUse(ushort nodeId, graphGraphDefinition questGraph)
    {
        foreach (var nodeHandle in questGraph.Nodes)
        {
            if (nodeHandle.GetValue() is questNodeDefinition node && node.Id == nodeId)
            {
                return true;
            }
        }

        return false;
    }

    private void RecalculateQuestSockets(IGraphProvider nodeViewModel)
    {
        if (nodeViewModel is not BaseQuestViewModel phaseNode)
        {
            return;
        }

        var inputCache = new Dictionary<string, List<QuestOutputConnectorViewModel>>();
        foreach (var inputConnectorViewModel in phaseNode.Input)
        {
            var questInputConnectorViewModel = (QuestInputConnectorViewModel)inputConnectorViewModel;

            if (questInputConnectorViewModel.Data.Connections.Count > 0)
            {
                inputCache.Add(questInputConnectorViewModel.Name, new List<QuestOutputConnectorViewModel>());
                foreach (var connection in questInputConnectorViewModel.Data.Connections)
                {
                    var source = connection.Chunk!.Source.Chunk!;

                    for (var i = source.Connections.Count - 1; i >= 0; i--)
                    {
                        if (ReferenceEquals(source.Connections[i].Chunk, connection.Chunk))
                        {
                            source.Connections.RemoveAt(i);
                        }
                    }

                    for (var i = Connections.Count - 1; i >= 0; i--)
                    {
                        var questOutputConnectorViewModel = (QuestOutputConnectorViewModel)Connections[i].Source;

                        if (ReferenceEquals(questOutputConnectorViewModel.Data, source) &&
                            ReferenceEquals(Connections[i].Target, questInputConnectorViewModel))
                        {
                            questOutputConnectorViewModel.IsConnected = questOutputConnectorViewModel.Data.Connections.Count > 0;

                            inputCache[questInputConnectorViewModel.Name].Add(questOutputConnectorViewModel);
                            Connections.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        var outputCache = new Dictionary<string, List<QuestInputConnectorViewModel>>();
        foreach (var outputConnectorViewModel in phaseNode.Output)
        {
            var questOutputConnectorViewModel = (QuestOutputConnectorViewModel)outputConnectorViewModel;

            if (questOutputConnectorViewModel.Data.Connections.Count > 0)
            {
                outputCache.Add(questOutputConnectorViewModel.Name, new List<QuestInputConnectorViewModel>());
                foreach (var connection in questOutputConnectorViewModel.Data.Connections)
                {
                    var destination = connection.Chunk!.Destination.Chunk!;

                    for (var i = destination.Connections.Count - 1; i >= 0; i--)
                    {
                        if (ReferenceEquals(destination.Connections[i].Chunk, connection.Chunk))
                        {
                            destination.Connections.RemoveAt(i);
                        }
                    }

                    for (var i = Connections.Count - 1; i >= 0; i--)
                    {
                        var questInputConnectorViewModel = (QuestInputConnectorViewModel)Connections[i].Target;

                        if (ReferenceEquals(Connections[i].Source, questOutputConnectorViewModel) &&
                            ReferenceEquals(questInputConnectorViewModel.Data, destination))
                        {
                            questInputConnectorViewModel.IsConnected = questInputConnectorViewModel.Data.Connections.Count > 0;

                            outputCache[questOutputConnectorViewModel.Name].Add(questInputConnectorViewModel);
                            Connections.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        nodeViewModel.RecalculateSockets();

        foreach (var inputConnectorViewModel in phaseNode.Input)
        {
            var questInputConnectorViewModel = (QuestInputConnectorViewModel)inputConnectorViewModel;

            if (inputCache.TryGetValue(questInputConnectorViewModel.Name, out var sockets))
            {
                foreach (var questOutputConnectorViewModel in sockets)
                {
                    AddQuestConnection(questOutputConnectorViewModel, questInputConnectorViewModel);
                }
            }
        }

        foreach (var outputConnectorViewModel in phaseNode.Output)
        {
            var questOutputConnectorViewModel = (QuestOutputConnectorViewModel)outputConnectorViewModel;

            if (outputCache.TryGetValue(questOutputConnectorViewModel.Name, out var sockets))
            {
                foreach (var questInputConnectorViewModel in sockets)
                {
                    AddQuestConnection(questOutputConnectorViewModel, questInputConnectorViewModel);
                }
            }
        }
    }

    public static RedGraph GenerateQuestGraph(string title, graphGraphDefinition questGraph, INodeWrapperFactory nodeWrapperFactory)
    {
        var graph = new RedGraph(title, questGraph);
        graph._nodeWrapperFactory = nodeWrapperFactory;

        var socketNodeLookup = new Dictionary<graphGraphSocketDefinition, QuestInputConnectorViewModel>();

        var nodeCache = new Dictionary<uint, BaseQuestViewModel>();
        foreach (var nodeHandle in questGraph.Nodes)
        {
            var node = nodeHandle.GetValue();
            if (node is null)
            {
                throw new Exception("Empty nodes aren't supported!");
            }

            if (node is questNodeDefinition nodeDefinition)
            {
                graph._currentQuestNodeId = Math.Max(graph._currentQuestNodeId, nodeDefinition.Id);
            }

            var nvm = node switch
            {
                DynamicBaseClass dynamicBaseClass => graph.WrapDynamicQuestNode(dynamicBaseClass, false),
                graphGraphNodeDefinition graphGraphNodeDefinition => graph.WrapQuestNode(graphGraphNodeDefinition, false),
                _ => throw new Exception($"Node of type \"{node.GetType()}\" isn't supported!")
            };

            nodeCache.Add(nvm.UniqueId, nvm);
            graph.Nodes.Add(nvm);

            foreach (var inputConnector in nvm.Input)
            {
                var questInputConnector = (QuestInputConnectorViewModel)inputConnector;
                socketNodeLookup.Add(questInputConnector.Data, questInputConnector);
            }
        }

        foreach (var node in graph.Nodes)
        {
            var questNode = (BaseQuestViewModel)node;

            foreach (var outputConnector in questNode.Output)
            {
                var questOutputConnector = (QuestOutputConnectorViewModel)outputConnector;

                foreach (var connectionHandle in questOutputConnector.Data.Connections)
                {
                    var connection = connectionHandle.Chunk!;

                    graph.Connections.Add(new QuestConnectionViewModel(questOutputConnector, socketNodeLookup[connection.Destination.Chunk!], connection));
                }
            }
        }

        return graph;
    }
}
