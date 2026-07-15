using System.Collections.Generic;

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
        "questUseWorkspotNodeDefinition",
        "questUIManagerNodeDefinition",
        "questJournalNodeDefinition"
    ];

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
            "questConditionNodeDefinition",
            "scnRandomizerNode",
            "questFactsDBManagerNodeDefinition",
            "questCutControlNodeDefinition",
            "questPauseConditionNodeDefinition",
            null,
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
