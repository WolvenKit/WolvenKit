using System;
using WolvenKit.App.Controllers;
using WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes.Internal;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests;

public class QuestGraphFactory(
    RedGraphFactory graphFactory,
    IArchiveManager archiveManager,
    IGameControllerFactory gameController,
    ILoggerService log)
{
    public RedGraph Create(string title, questQuestPhaseResource resource, GraphContext context)
    {
        var data = new GraphData(title, context);
        return new RedGraph(
            data,
            new QuestGraphService(data, resource, this, log),
            log);
    }

    public BaseQuestViewModel CreateView(graphGraphNodeDefinition graphNode, GraphContext context, questQuestPhaseResource resource, QuestGraphService graphService)
    {
        return graphNode switch
        {
            questAchievementManagerNodeDefinition node => new questAchievementManagerNodeDefinitionWrapper(node),
            questConditionNodeDefinition node => new questConditionNodeDefinitionWrapper(node),
            questCrowdManagerNodeDefinition node => new questCrowdManagerNodeDefinitionWrapper(node),
            questCutControlNodeDefinition node => new questCutControlNodeDefinitionWrapper(node),
            questDynamicSpawnSystemNodeDefinition node => new questDynamicSpawnSystemNodeDefinitionWrapper(node),
            questEntityManagerNodeDefinition node => new questEntityManagerNodeDefinitionWrapper(node),
            questEnvironmentManagerNodeDefinition node => new questEnvironmentManagerNodeDefinitionWrapper(node),
            questEventManagerNodeDefinition node => new questEventManagerNodeDefinitionWrapper(node),
            questFactsDBManagerNodeDefinition node => new questFactsDBManagerNodeDefinitionWrapper(node),
            questFlowControlNodeDefinition node => new questFlowControlNodeDefinitionWrapper(node),
            questFXManagerNodeDefinition node => new questFXManagerNodeDefinitionWrapper(node),
            questInstancedCrowdControlNodeDefinition node => new questInstancedCrowdControlNodeDefinitionWrapper(node),
            questInteractiveObjectManagerNodeDefinition node => new questInteractiveObjectManagerNodeDefinitionWrapper(node),
            questItemManagerNodeDefinition node => new questItemManagerNodeDefinitionWrapper(node),
            questMappinManagerNodeDefinition node => new questMappinManagerNodeDefinitionWrapper(node),
            questPuppetAIManagerNodeDefinition node => new questPuppetAIManagerNodeDefinitionWrapper(node),
            questRandomizerNodeDefinition node => new questRandomizerNodeDefinitionWrapper(node),
            questRenderFxManagerNodeDefinition node => new questRenderFxManagerNodeDefinitionWrapper(node),
            questRewardManagerNodeDefinition node => new questRewardManagerNodeDefinitionWrapper(node),
            questSwitchNodeDefinition node => new questSwitchNodeDefinitionWrapper(node),
            questTimeManagerNodeDefinition node => new questTimeManagerNodeDefinitionWrapper(node),
            questTriggerManagerNodeDefinition node => new questTriggerManagerNodeDefinitionWrapper(node),
            questVisionModesManagerNodeDefinition node => new questVisionModesManagerNodeDefinitionWrapper(node),
            questVoicesetManagerNodeDefinition node => new questVoicesetManagerNodeDefinitionWrapper(node),
            tempshitMapPinManagerNodeDefinition node => new tempshitMapPinManagerNodeDefinitionWrapper(node),
            questInputNodeDefinition node => new questInputNodeDefinitionWrapper(node),
            questOutputNodeDefinition node => new questOutputNodeDefinitionWrapper(node),
            questAudioNodeDefinition node => new questAudioNodeDefinitionWrapper(node),
            questCharacterManagerNodeDefinition node => new questCharacterManagerNodeDefinitionWrapper(node),
            questCheckpointNodeDefinition node => new questCheckpointNodeDefinitionWrapper(node),
            questClearForcedBehavioursNodeDefinition node => new questClearForcedBehavioursNodeDefinitionWrapper(node),
            questDeletionMarkerNodeDefinition node => new questDeletionMarkerNodeDefinitionWrapper(node),
            questForcedBehaviourNodeDefinition node => new questForcedBehaviourNodeDefinitionWrapper(node),
            questJournalNodeDefinition node => new questJournalNodeDefinitionWrapper(node),
            questPauseConditionNodeDefinition node => new questPauseConditionNodeDefinitionWrapper(node),
            questPhoneManagerNodeDefinition node => new questPhoneManagerNodeDefinitionWrapper(node),
            questSceneManagerNodeDefinition node => new questSceneManagerNodeDefinitionWrapper(node),
            questSceneNodeDefinition node => new questSceneNodeDefinitionWrapper(node, context, graphFactory, graphService, archiveManager, gameController),
            questSpawnManagerNodeDefinition node => new questSpawnManagerNodeDefinitionWrapper(node),
            questTransformAnimatorNodeDefinition node => new questTransformAnimatorNodeDefinitionWrapper(node),
            questUIManagerNodeDefinition node => new questUIManagerNodeDefinitionWrapper(node),
            questVehicleNodeDefinition node => new questVehicleNodeDefinitionWrapper(node),
            questWorldDataManagerNodeDefinition node => new questWorldDataManagerNodeDefinitionWrapper(node),
            questEquipItemNodeDefinition node => new questEquipItemNodeDefinitionWrapper(node),
            questSendAICommandNodeDefinition node => new questSendAICommandNodeDefinitionWrapper(node),
            questTeleportPuppetNodeDefinition node => new questTeleportPuppetNodeDefinitionWrapper(node),
            questUseWorkspotNodeDefinition node => new questUseWorkspotNodeDefinitionWrapper(node),
            questVehicleNodeCommandDefinition node => new questVehicleNodeCommandDefinitionWrapper(node),
            questCombatNodeDefinition node => new questCombatNodeDefinitionWrapper(node),
            questMiscAICommandNode node => new questMiscAICommandNodeWrapper(node),
            questMovePuppetNodeDefinition node => new questMovePuppetNodeDefinitionWrapper(node),
            questPhaseNodeDefinition node => new questPhaseNodeDefinitionWrapper(node, context, graphFactory, archiveManager),
            questLogicalAndNodeDefinition node => new questLogicalAndNodeDefinitionWrapper(node),
            questLogicalHubNodeDefinition node => new questLogicalHubNodeDefinitionWrapper(node),
            questLogicalXorNodeDefinition node => new questLogicalXorNodeDefinitionWrapper(node),
            questGameManagerNodeDefinition node => new questGameManagerNodeDefinitionWrapper(node),
            questEndNodeDefinition node => new questEndNodeDefinitionWrapper(node),
            questStartNodeDefinition node => new questStartNodeDefinitionWrapper(node),
            questNodeDefinition node => new questNodeDefinitionWrapper(node),
            _ => throw new ArgumentException($"Unsupported node type: {graphNode.GetType().Name}")
        };
    }
}