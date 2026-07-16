using System;
using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.GraphEditor;

#nullable enable
internal sealed record GraphNodeCreationCategory(string Name, IReadOnlyList<string?> TypeNames);

internal static class GraphNodeCreationCatalog
{
    internal static IReadOnlyList<string> CommonTypeNames { get; } =
    [
        "scnSectionNode",
        "scnChoiceNode",
        "questPauseConditionNodeDefinition",
        "questFactsDBManagerNodeDefinition",
        "questJournalNodeDefinition",
        "questUseWorkspotNodeDefinition",
        "questConditionNodeDefinition",
        "questSpawnManagerNodeDefinition"
    ];

    private static readonly HashSet<Type> s_searchOnlyTypes =
    [
        typeof(questDebugShowMessageNodeDefinition),
        typeof(questTestNodeDefinition),
        typeof(tempshitJournalNodeDefinition),
        typeof(tempshitMapPinManagerNodeDefinition),
        typeof(questMultiplayerAIDirectorNodeDefinition),
        typeof(questMultiplayerChoiceTokenNodeDefinition),
        typeof(questMultiplayerHeistNodeDefinition),
        typeof(questMultiplayerJunctionDialogNodeDefinition),
        typeof(questMultiplayerTeleportPuppetNodeDefinition),
        typeof(questPopulactionControllerNodeDefinition),
        typeof(questStartNodeDefinition),
        typeof(questEndNodeDefinition),
        typeof(questTeleportVehicleNodeDefinition),
        typeof(questUnequipItemNodeDefinition),
        typeof(questRotateToNodeDefinition),
        typeof(questPuppeteerNodeDefinition),
        typeof(questAudioCharacterManagerNodeDefinition)
    ];

    internal static bool IsSearchOnly(Type type) => s_searchOnlyTypes.Contains(type);

    internal static IReadOnlyList<GraphNodeCreationCategory> Categories { get; } =
    [
        new("Flow & Logic",
        [
            "scnStartNode",
            "scnEndNode",
            null,
            "scnAndNode",
            "scnHubNode",
            "scnXorNode",
            "scnFlowControlNode",
            "scnCutControlNode",
            "scnInterruptManagerNode",
            null,
            "questInputNodeDefinition",
            "questOutputNodeDefinition",
            null,
            "questLogicalAndNodeDefinition",
            "questLogicalHubNodeDefinition",
            "questLogicalXorNodeDefinition",
            "questFlowControlNodeDefinition",
            "questRandomizerNodeDefinition",
            "questConditionNodeDefinition",
            "questFactsDBManagerNodeDefinition",
            "questCutControlNodeDefinition",
            "questPauseConditionNodeDefinition",
            null,
            "scnRandomizerNode",
            "questSwitchNodeDefinition"
        ]),
        new("Character & AI",
        [
            "questCharacterManagerNodeDefinition",
            "questBehaviourManagerNodeDefinition",
            "questPuppetAIManagerNodeDefinition",
            "questPuppeteerNodeDefinition",
            "questForcedBehaviourNodeDefinition",
            "questUseWorkspotNodeDefinition",
            null,
            "questMovePuppetNodeDefinition",
            "questTeleportPuppetNodeDefinition",
            null,
            "questMiscAICommandNode",
            "questCombatNodeDefinition",
            "questSendAICommandNodeDefinition"
        ]),
        new("Game & World",
        [
            "questCheckpointNodeDefinition",
            "questTimeManagerNodeDefinition",
            "questEnvironmentManagerNodeDefinition",
            "questWorldDataManagerNodeDefinition",
            "questEntityManagerNodeDefinition",
            "questEventManagerNodeDefinition",
            "questInteractiveObjectManagerNodeDefinition",
            "questTriggerManagerNodeDefinition",
            null,
            "questSpawnManagerNodeDefinition",
            "questCrowdManagerNodeDefinition"
        ]),
        new("Journal & Mappins",
        [
            "questJournalNodeDefinition",
            "questMappinManagerNodeDefinition"
        ]),
        new("Vehicle",
        [
            "questVehicleNodeDefinition",
            "questVehicleNodeCommandDefinition",
            "questTeleportVehicleNodeDefinition"
        ]),
        new("Items & Inventory",
        [
            "questItemManagerNodeDefinition",
            "questEquipItemNodeDefinition",
            "questUnequipItemNodeDefinition"
        ]),
        new("Audio & FX",
        [
            "questAudioNodeDefinition",
            "questAudioCharacterManagerNodeDefinition",
            "questVoicesetManagerNodeDefinition",
            "questFXManagerNodeDefinition",
            "questRenderFxManagerNodeDefinition",
            "questVisionModesManagerNodeDefinition"
        ]),
        new("Debug",
        [
            "scnDeletionMarkerNode",
            "questDeletionMarkerNodeDefinition",
            "questPlaceholderNodeDefinition"
        ])
    ];
}
