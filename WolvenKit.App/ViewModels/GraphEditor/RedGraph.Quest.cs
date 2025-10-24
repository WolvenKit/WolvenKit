using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

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

            if (nodeDefinition is questInputNodeDefinition inputNode)
            {
                inputNode.SocketName = "In1";
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

        // Find affected nodes and trigger property panel refresh for each
        var affectedNodeIds = sockets
            .Select(socket => Nodes.FirstOrDefault(n =>
                n.Output.OfType<QuestOutputConnectorViewModel>()
                    .Any(output => ReferenceEquals(output.Data, socket)) ||
                n.Input.OfType<QuestInputConnectorViewModel>()
                    .Any(input => ReferenceEquals(input.Data, socket))))
            .Where(node => node != null)
            .Select(node => node!.UniqueId)
            .ToHashSet();

        // Trigger property panel refresh for affected nodes
         foreach (var nodeId in affectedNodeIds)
         {
             var node = Nodes.FirstOrDefault(n => n.UniqueId == nodeId);
             if (node != null)
             {
                 node.TriggerPropertyChanged(nameof(node.Data));
             }
         }
    }

    private ChunkViewModel? GetQuestNodesChunkViewModel()
    {
        if (DocumentViewModel?.GetMainFile() is not RDTDataViewModel dataViewModel)
        {
            return null;
        }

        if (dataViewModel.Chunks[0].GetPropertyChild("graph", "nodes") is not { } nodes)
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

    public void PasteQuestNode(IRedType copiedData, System.Windows.Point location)
    {
        questNodeDefinition questNodeData;

        // Cross-type paste: Scene -> Quest (unwrap scnQuestNode)
        if (copiedData is scnQuestNode sceneQuestNode)
        {
            if (sceneQuestNode.QuestNode?.Chunk == null)
            {
                _loggerService?.Error($"Cannot paste scnQuestNode - embedded quest node is null");
                return;
            }

            // Extract the embedded quest node
            questNodeData = sceneQuestNode.QuestNode.Chunk;
        }
        // Same-type paste: Quest -> Quest
        else if (copiedData is questNodeDefinition questDef)
        {
            questNodeData = questDef;
        }
        else
        {
            _loggerService?.Error($"Cannot paste node data of type {copiedData.GetType().Name} into quest graph. Only nodes inheriting questNodeDefinition or scnQuestNode are allowed.");
            return;
        }

        if (questNodeData is not IRedCloneable cloneable)
        {
            _loggerService?.Error($"Cannot paste node of type {questNodeData.GetType().Name} - it doesn't implement IRedCloneable");
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

        wrappedDuplicate.Location = location;

        ((graphGraphDefinition)_data).Nodes.Add(new CHandle<graphGraphNodeDefinition>(duplicatedData));

        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        Nodes.Add(wrappedDuplicate);
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

    public void UnpackPhase(questPhaseNodeDefinitionWrapper phaseNode)
    {
        var mainGraphDef = (graphGraphDefinition)_data;
        if (phaseNode.Data is not questPhaseNodeDefinition phaseNodeDef)
        {
            return;
        }

        var phaseGraphDef = phaseNodeDef.PhaseGraph?.Chunk;

        if (phaseGraphDef == null)
        {
            _loggerService?.Warning("Phase node has no internal graph to unpack.");
            return;
        }

        if (phaseNode.Graph == null)
        {
            _loggerService?.Warning("Phase node has no subgraph.");
            return;
        }

        // 1. Cache connections to/from the phase node before removing it
        var incomingConnections = Connections.OfType<QuestConnectionViewModel>()
            .Where(c => c.Target.OwnerId == phaseNode.UniqueId)
            .ToList();
        var outgoingConnections = Connections.OfType<QuestConnectionViewModel>()
            .Where(c => c.Source.OwnerId == phaseNode.UniqueId)
            .ToList();

        // 2. Move nodes from the phase's graph to the main graph
        var idMap = MigrateNodesFromPhase(phaseNode, mainGraphDef, phaseGraphDef);

        // 3. Re-wire connections
        RewireConnectionsForUnpackedPhase(phaseNode, incomingConnections, outgoingConnections);

        // 4. Remove the phase node itself
        RemoveQuestNode(phaseNode);

        // 5. Cleanup
        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
            nodes.RecalculateProperties();
        }

        // Clean up orphaned connections
        CleanUpOrphanedConnections(phaseGraphDef);

        RebuildQuestConnections();
        GraphStateSave();
        DocumentViewModel?.SetIsDirty(true);
    }

    private Dictionary<ushort, ushort> MigrateNodesFromPhase(questPhaseNodeDefinitionWrapper phaseNode, graphGraphDefinition mainGraphDef, questGraphDefinition phaseGraphDef)
    {
        var nodesToMove = phaseGraphDef.Nodes
            .Select(h => h.Chunk)
            .OfType<questNodeDefinition>()
            .ToList();

        var idMap = new Dictionary<ushort, ushort>();
        foreach (var nodeDef in nodesToMove)
        {
            if (nodeDef is questInputNodeDefinition or questOutputNodeDefinition)
            {
                continue;
            }

            if (IsQuestNodeIdInUse(nodeDef.Id, mainGraphDef))
            {
                var newNodeId = GetNextAvailableQuestNodeId();
                idMap[nodeDef.Id] = newNodeId;
                _currentQuestNodeId = Math.Max(_currentQuestNodeId, newNodeId);
            }
        }

        foreach (var nodeDef in nodesToMove.Where(nodeDef => nodeDef is not (questInputNodeDefinition or questOutputNodeDefinition)))
        {
            // Update the node's own ID if it was remapped
            if (idMap.TryGetValue(nodeDef.Id, out var newId))
            {
                nodeDef.Id = newId;
            }

            // Update properties of the node that might reference other node IDs
            if (nodeDef is questDeletionMarkerNodeDefinition deletionMarker)
            {
                for (var i = 0; i < deletionMarker.DeletedNodeIds.Count; i++)
                {
                    if (idMap.TryGetValue(deletionMarker.DeletedNodeIds[i], out var newRefId))
                    {
                        deletionMarker.DeletedNodeIds[i] = newRefId;
                    }
                }
            }

            mainGraphDef.Nodes.Add(new CHandle<graphGraphNodeDefinition>(nodeDef));
            var wrappedNode = WrapQuestNode(nodeDef, false);
            wrappedNode.Location = new System.Windows.Point(
                phaseNode.Location.X + new Random().Next(-50, 50),
                phaseNode.Location.Y + new Random().Next(-50, 50)
            );
            Nodes.Add(wrappedNode);
        }

        return idMap;
    }

    private void RewireConnectionsForUnpackedPhase(questPhaseNodeDefinitionWrapper phaseNode,
        List<QuestConnectionViewModel> incomingConnections, List<QuestConnectionViewModel> outgoingConnections)
    {
        // Connect nodes that were connected to the phase's inputs
        foreach (var incomingConn in incomingConnections)
        {
            var externalSourceConnector = (QuestOutputConnectorViewModel)incomingConn.Source;
            var phaseInputSocketName = incomingConn.Target.Name;

            var internalTargetSockets = FindInternalTargetSockets(phaseNode, phaseInputSocketName);
            foreach (var internalTargetSocket in internalTargetSockets)
            {
                AddQuestConnection(externalSourceConnector, internalTargetSocket);
            }
        }

        // Connect nodes that were connected from the phase's outputs
        foreach (var outgoingConn in outgoingConnections)
        {
            var phaseOutputSocketName = outgoingConn.Source.Name;
            var externalTargetConnector = (QuestInputConnectorViewModel)outgoingConn.Target;

            var internalSourceSockets = FindInternalSourceSockets(phaseNode, phaseOutputSocketName);
            foreach (var internalSourceSocket in internalSourceSockets)
            {
                AddQuestConnection(internalSourceSocket, externalTargetConnector);
            }
        }
    }

    private List<QuestInputConnectorViewModel> FindInternalTargetSockets(questPhaseNodeDefinitionWrapper phaseNode, string phaseInputSocketName)
    {
        var internalTargetSockets = new List<QuestInputConnectorViewModel>();
        if (phaseNode.Graph == null)
        {
            return internalTargetSockets;
        }

        var inputNode = phaseNode.Graph.Nodes.FirstOrDefault(n =>
        {
            if (n is questInputNodeDefinitionWrapper { Data: questInputNodeDefinition def })
            {
                return def.SocketName.GetResolvedText() == phaseInputSocketName;
            }
            return false;
        });

        if (inputNode == null)
        {
            return internalTargetSockets;
        }

        var outputSockets = inputNode.Output.OfType<QuestOutputConnectorViewModel>();
        foreach (var outputSocket in outputSockets)
        {
            var conns = phaseNode.Graph.Connections.Where(c => c.Source == outputSocket);
            internalTargetSockets.AddRange(conns.Select(c => (QuestInputConnectorViewModel)c.Target));
        }

        return internalTargetSockets;
    }

    private List<QuestOutputConnectorViewModel> FindInternalSourceSockets(questPhaseNodeDefinitionWrapper phaseNode, string phaseOutputSocketName)
    {
        var internalSourceSockets = new List<QuestOutputConnectorViewModel>();
        if (phaseNode.Graph == null)
        {
            return internalSourceSockets;
        }

        var outputNode = phaseNode.Graph.Nodes.FirstOrDefault(n =>
        {
            if (n is questOutputNodeDefinitionWrapper w && w.Data is questOutputNodeDefinition def)
            {
                return def.SocketName.GetResolvedText() == phaseOutputSocketName;
            }
            return false;
        });

        if (outputNode == null)
        {
            return internalSourceSockets;
        }

        var inputSockets = outputNode.Input.OfType<QuestInputConnectorViewModel>();
        foreach (var inputSocket in inputSockets)
        {
            var conns = phaseNode.Graph.Connections.Where(c => c.Target == inputSocket);
            internalSourceSockets.AddRange(conns.Select(c => (QuestOutputConnectorViewModel)c.Source));
        }

        return internalSourceSockets;
    }

    public void CreatePhaseFromSelection(IEnumerable<object> selectedNodes)
    {
        var questNodes = selectedNodes.OfType<BaseQuestViewModel>().ToList();
        if (questNodes.Count < 2)
        {
            return;
        }

        var mainGraphDef = (graphGraphDefinition)_data;
        var selectedNodeIds = questNodes.Select(x => x.UniqueId).ToHashSet();

        // Find connections between the selection and the outside world
        var allConnections = Connections.OfType<QuestConnectionViewModel>().ToList();
        var incomingConnections = allConnections.Where(c => !selectedNodeIds.Contains(c.Source.OwnerId) && selectedNodeIds.Contains(c.Target.OwnerId)).ToList();
        var outgoingConnections = allConnections.Where(c => selectedNodeIds.Contains(c.Source.OwnerId) && !selectedNodeIds.Contains(c.Target.OwnerId)).ToList();

        // 1. Create the phase node definition and its internal graph
        var phaseNodeDef = (questPhaseNodeDefinition)InternalCreateQuestNode(typeof(questPhaseNodeDefinition));
        if (phaseNodeDef.PhaseGraph?.Chunk == null)
        {
            phaseNodeDef.PhaseGraph = new CHandle<questGraphDefinition>(new questGraphDefinition());
        }
        var phaseGraphDef = phaseNodeDef.PhaseGraph!.Chunk;
        if (phaseGraphDef == null)
        {
            _loggerService?.Error("Could not create internal graph for the new phase.");
            return;
        }

        var incomingGroupedBySource = incomingConnections
            .Where(c => ((QuestInputConnectorViewModel)c.Target).Data.Type != Enums.questSocketType.CutDestination)
            .GroupBy(c => c.Source)
            .ToList();
        var inputNodeDefs = new List<questInputNodeDefinition>();
        if (incomingGroupedBySource.Count > 0)
        {
            if (incomingGroupedBySource.Count == 1)
            {
                var inputNodeDef = (questInputNodeDefinition)InternalCreateQuestNode(typeof(questInputNodeDefinition));
                inputNodeDef.SocketName = "In";
                phaseGraphDef.Nodes.Add(new CHandle<graphGraphNodeDefinition>(inputNodeDef));
                inputNodeDefs.Add(inputNodeDef);
            }
            else
            {
                for (var i = 0; i < incomingGroupedBySource.Count; i++)
                {
                    var inputNodeDef = (questInputNodeDefinition)InternalCreateQuestNode(typeof(questInputNodeDefinition));
                    inputNodeDef.SocketName = $"In{i + 1}";
                    phaseGraphDef.Nodes.Add(new CHandle<graphGraphNodeDefinition>(inputNodeDef));
                    inputNodeDefs.Add(inputNodeDef);
                }
            }
        }

        var outgoingGroupedBySource = outgoingConnections.GroupBy(c => c.Source).ToList();
        var outputNodeDefs = new List<questOutputNodeDefinition>();
        for (var i = 0; i < outgoingGroupedBySource.Count; i++)
        {
            var outputNodeDef = (questOutputNodeDefinition)InternalCreateQuestNode(typeof(questOutputNodeDefinition));
            outputNodeDef.SocketName = $"Out{i + 1}";
            phaseGraphDef.Nodes.Add(new CHandle<graphGraphNodeDefinition>(outputNodeDef));
            outputNodeDefs.Add(outputNodeDef);
        }

        // 3. Handle CutDestination sockets by adding a corresponding input node to the phase graph
        var cutDestinationConnections = incomingConnections
            .Where(c => ((QuestInputConnectorViewModel)c.Target).Data.Type == Enums.questSocketType.CutDestination)
            .ToList();

        questInputNodeDefinition? internalCutDestInputNodeDef = null;
        if (cutDestinationConnections.Any())
        {
            internalCutDestInputNodeDef = (questInputNodeDefinition)InternalCreateQuestNode(typeof(questInputNodeDefinition));
            internalCutDestInputNodeDef.SocketName = "CutDestination";
            phaseGraphDef.Nodes.Add(new CHandle<graphGraphNodeDefinition>(internalCutDestInputNodeDef));
        }

        // 4. Create the wrapper for the phase node. This will generate its sockets based on the I/O nodes now in its graph.
        var wrappedPhaseNode = (questPhaseNodeDefinitionWrapper)WrapQuestNode(phaseNodeDef, true);
        wrappedPhaseNode.Location = new System.Windows.Point(
            questNodes.Average(n => n.Location.X),
            questNodes.Average(n => n.Location.Y)
        );
        mainGraphDef.Nodes.Add(new CHandle<graphGraphNodeDefinition>(phaseNodeDef));
        Nodes.Add(wrappedPhaseNode);

        // 5. Move the selected nodes from the main graph into the phase's subgraph
        foreach (var nodeVM in questNodes)
        {
            // Use a reverse for-loop to safely remove items
            for (int i = mainGraphDef.Nodes.Count - 1; i >= 0; i--)
            {
                if (mainGraphDef.Nodes[i].Chunk == nodeVM.Data)
                {
                    mainGraphDef.Nodes.RemoveAt(i);
                }
            }
            Nodes.Remove(nodeVM);
            phaseGraphDef.Nodes.Add(new CHandle<graphGraphNodeDefinition>((graphGraphNodeDefinition)nodeVM.Data));
        }

        wrappedPhaseNode.RecalculateSockets();

        // 6. Re-wire all the connections

        // Helper to add a connection directly to the data model
        void AddConnectionToData(QuestOutputConnectorViewModel source, QuestInputConnectorViewModel dest)
        {
            var connection = new graphGraphConnectionDefinition
            {
                Source = new CWeakHandle<graphGraphSocketDefinition>(source.Data),
                Destination = new CWeakHandle<graphGraphSocketDefinition>(dest.Data)
            };
            var handle = new CHandle<graphGraphConnectionDefinition>(connection);
            source.Data.Connections.Add(handle);
            dest.Data.Connections.Add(handle);
        }

        // Re-route standard incoming connections
        if (incomingGroupedBySource.Count == 1)
        {
            var group = incomingGroupedBySource.First();
            var inputNodeDef = inputNodeDefs.First();
            var phaseInSocket = (QuestInputConnectorViewModel)wrappedPhaseNode.Input.First(s => s.Name == "In");
            var tempWrappedInput = WrapQuestNode(inputNodeDef, true);
            var internalOutSocket = (QuestOutputConnectorViewModel)tempWrappedInput.Output.First();

            ConnectQuest((QuestOutputConnectorViewModel)group.Key, phaseInSocket);
            foreach (var conn in group)
            {
                AddConnectionToData(internalOutSocket, (QuestInputConnectorViewModel)conn.Target);
                RemoveQuestConnection(conn);
            }
        }
        else
        {
            for (var i = 0; i < incomingGroupedBySource.Count; i++)
            {
                var group = incomingGroupedBySource[i];
                var inputNodeDef = inputNodeDefs[i];
                var phaseInSocket = (QuestInputConnectorViewModel)wrappedPhaseNode.Input.First(s => s.Name == inputNodeDef.SocketName);
                var tempWrappedInput = WrapQuestNode(inputNodeDef, true);
                var internalOutSocket = (QuestOutputConnectorViewModel)tempWrappedInput.Output.First();

                ConnectQuest((QuestOutputConnectorViewModel)group.Key, phaseInSocket);
                foreach (var conn in group)
                {
                    AddConnectionToData(internalOutSocket, (QuestInputConnectorViewModel)conn.Target);
                    RemoveQuestConnection(conn);
                }
            }
        }

        // Re-route standard outgoing connections
        for (var i = 0; i < outgoingGroupedBySource.Count; i++)
        {
            var group = outgoingGroupedBySource[i];
            var outputNodeDef = outputNodeDefs[i];
            var phaseOutSocket = (QuestOutputConnectorViewModel)wrappedPhaseNode.Output.First(s => s.Name == outputNodeDef.SocketName);
            var tempWrappedOutput = WrapQuestNode(outputNodeDef, true);
            var internalInSocket = (QuestInputConnectorViewModel)tempWrappedOutput.Input.First(s => ((QuestInputConnectorViewModel)s).Data.Type == Enums.questSocketType.Input);

            AddConnectionToData((QuestOutputConnectorViewModel)group.Key, internalInSocket);
            foreach (var conn in group)
            {
                ConnectQuest(phaseOutSocket, (QuestInputConnectorViewModel)conn.Target);
                RemoveQuestConnection(conn);
            }
        }

        // Re-route CutDestination connections
        if (cutDestinationConnections.Any())
        {
            var phaseCutDestSocket = (QuestInputConnectorViewModel)wrappedPhaseNode.Input.First(s => s.Name == "CutDestination");

            var tempWrappedInternalCutDest = WrapQuestNode(internalCutDestInputNodeDef!, true);
            var internalCutDestOutSocket = (QuestOutputConnectorViewModel)tempWrappedInternalCutDest.Output.First();

            foreach (var conn in cutDestinationConnections)
            {
                ConnectQuest((QuestOutputConnectorViewModel)conn.Source, phaseCutDestSocket);
                AddConnectionToData(internalCutDestOutSocket, (QuestInputConnectorViewModel)conn.Target);
                RemoveQuestConnection(conn);
            }
        }

        // 7. Refresh the whole graph view
        RebuildQuestConnections();
        GraphStateSave();
        DocumentViewModel?.SetIsDirty(true);
    }

    private void CleanUpOrphanedConnections(questGraphDefinition phaseGraphDef)
    {
        var unmigratedSockets = new HashSet<graphGraphSocketDefinition>();
        foreach (var nodeDef in phaseGraphDef.Nodes.Select(h => h.Chunk).OfType<questNodeDefinition>())
        {
            if (nodeDef is questInputNodeDefinition or questOutputNodeDefinition)
            {
                foreach (var socketHandle in nodeDef.Sockets)
                {
                    if (socketHandle.Chunk is { } socket)
                    {
                        unmigratedSockets.Add(socket);
                    }
                }
            }
        }

        foreach (var nodeViewModel in Nodes.OfType<BaseQuestViewModel>())
        {
            foreach (var socket in nodeViewModel.Input.OfType<QuestInputConnectorViewModel>())
            {
                for (var i = socket.Data.Connections.Count - 1; i >= 0; i--)
                {
                    var connection = socket.Data.Connections[i].Chunk;
                    if (connection != null &&
                        ((connection.Source.Chunk != null && unmigratedSockets.Contains(connection.Source.Chunk)) ||
                         (connection.Destination.Chunk != null && unmigratedSockets.Contains(connection.Destination.Chunk))))
                    {
                        socket.Data.Connections.RemoveAt(i);
                    }
                }
            }
            foreach (var socket in nodeViewModel.Output.OfType<QuestOutputConnectorViewModel>())
            {
                for (var i = socket.Data.Connections.Count - 1; i >= 0; i--)
                {
                    var connection = socket.Data.Connections[i].Chunk;
                    if (connection != null &&
                        ((connection.Source.Chunk != null && unmigratedSockets.Contains(connection.Source.Chunk)) ||
                         (connection.Destination.Chunk != null && unmigratedSockets.Contains(connection.Destination.Chunk))))
                    {
                        socket.Data.Connections.RemoveAt(i);
                    }
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
                    var connection = connectionHandle.Chunk;
                    if (connection?.Destination?.Chunk != null && socketNodeLookup.TryGetValue(connection.Destination.Chunk, out var targetInput))
                    {
                        graph.Connections.Add(new QuestConnectionViewModel(questOutputConnector, targetInput, connection));
                    }
                }
            }
        }

        return graph;
    }
}
