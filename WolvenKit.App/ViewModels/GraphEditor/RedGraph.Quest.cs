using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
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
                .Where(x => typeof(graphGraphNodeDefinition).IsAssignableFrom(x) && !x.IsAbstract)
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
        }

        return questNode;
    }

    private void RemoveQuestNode(BaseQuestViewModel node)
    {
        foreach (var inputConnectorViewModel in node.Input)
        {
            var inputConnector = (QuestInputConnectorViewModel)inputConnectorViewModel;

            foreach (var inputConnectionHandle in inputConnector.Data.Connections)
            {
                var inputConnection = inputConnectionHandle.Chunk!;

                for (var i = inputConnection.Source.Chunk!.Connections.Count - 1; i >= 0; i--)
                {
                    if (ReferenceEquals(inputConnection.Source.Chunk!.Connections[i].Chunk, inputConnection))
                    {
                        inputConnection.Source.Chunk!.Connections.RemoveAt(i);
                    }
                }

                for (var i = Connections.Count - 1; i >= 0; i--)
                {
                    var connection = (QuestConnectionViewModel)Connections[i];
                    if (ReferenceEquals(connection.ConnectionDefinition, inputConnection))
                    {
                        connection.Source.IsConnected = ((QuestOutputConnectorViewModel)connection.Source).Data.Connections.Count > 0;
                        Connections.RemoveAt(i);
                        RefreshCVM([((QuestOutputConnectorViewModel)connection.Source).Data]);
                    }
                }
            }
        }

        foreach (var outputConnectorViewModel in node.Output)
        {
            var outputConnector = (QuestOutputConnectorViewModel)outputConnectorViewModel;

            foreach (var outputConnectionHandle in outputConnector.Data.Connections)
            {
                var outputConnection = outputConnectionHandle.Chunk!;

                for (var i = outputConnection.Destination.Chunk!.Connections.Count - 1; i >= 0; i--)
                {
                    if (ReferenceEquals(outputConnection.Destination.Chunk!.Connections[i].Chunk, outputConnection))
                    {
                        outputConnection.Destination.Chunk!.Connections.RemoveAt(i);
                    }
                }

                for (var i = Connections.Count - 1; i >= 0; i--)
                {
                    var connection = (QuestConnectionViewModel)Connections[i];
                    if (ReferenceEquals(connection.ConnectionDefinition, outputConnection))
                    {
                        connection.Target.IsConnected = ((QuestInputConnectorViewModel)connection.Target).Data.Connections.Count > 0;
                        Connections.RemoveAt(i);
                        RefreshCVM([((QuestInputConnectorViewModel)connection.Target).Data]);
                    }
                }
            }
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
        else if (wrapperType == typeof(questSceneNodeDefinition))
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
        RefreshCVM([questSource.Data, questTarget.Data]);
    }

    private void RefreshCVM(questSocketDefinition[] sockets)
    {
        if (GetQuestNodesChunkViewModel() is { } nodes)
        {
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
            }
        }
    }

    private ChunkViewModel? GetQuestNodesChunkViewModel()
    {
        if (DocumentViewModel?.GetMainFile() is not RDTDataViewModel dataViewModel)
        {
            return null;
        }

        if (dataViewModel.Chunks[0].GetModelFromPath("graph.nodes") is not { } nodes)
        {
            return null;
        }

        return nodes;
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
    }

    public static RedGraph GenerateQuestGraph(string title, graphGraphDefinition questGraph, INodeWrapperFactory nodeWrapperFactory)
    {
        var graph = new RedGraph(title, questGraph);
        graph._nodeWrapperFactory = nodeWrapperFactory;

        var socketNodeLookup = new Dictionary<graphGraphSocketDefinition, QuestInputConnectorViewModel>();

        var nodeCache = new Dictionary<uint, BaseQuestViewModel>();
        foreach (var nodeHandle in questGraph.Nodes)
        {
            ArgumentNullException.ThrowIfNull(nodeHandle.Chunk);

            var node = nodeHandle.Chunk;

            if (node is questNodeDefinition nodeDefinition)
            {
                graph._currentQuestNodeId = Math.Max(graph._currentQuestNodeId, nodeDefinition.Id);
            }

            var nvm = graph.WrapQuestNode(node, false);

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