using System.Windows;
using System.Windows.Media;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes;

/// <summary>
/// Unified color helper for all graph node types (scene and quest nodes)
/// </summary>
public static class GraphNodeColors
{
    public static Brush GetBackgroundForSceneNodeType(scnSceneGraphNode node)
    {
        var resourceKey = node switch
        {
            scnStartNode => "SceneStartNodeHeader",
            scnEndNode => "SceneEndNodeHeader", 
            scnChoiceNode => "SceneChoiceNodeHeader",
            scnQuestNode => "SceneQuestNodeHeader", // Uses same color scheme as quest nodes
            scnSectionNode => "SceneSectionNodeHeader",
            scnRandomizerNode => "SceneRandomizerNodeHeader",
            scnHubNode => "SceneHubNodeHeader",
            scnAndNode => "SceneAndNodeHeader",
            scnXorNode => "SceneXorNodeHeader",
            _ => "SceneDefaultNodeHeader"
        };

        return GetResourceWithFallback(resourceKey, "SceneDefaultNodeHeader", "#33444444");
    }

    public static Brush GetContentBackgroundForSceneNodeType(scnSceneGraphNode node)
    {
        var resourceKey = node switch
        {
            scnStartNode => "SceneStartNodeContent",
            scnEndNode => "SceneEndNodeContent",
            scnChoiceNode => "SceneChoiceNodeContent", 
            scnQuestNode => "SceneQuestNodeContent", // Uses same color scheme as quest nodes
            scnSectionNode => "SceneSectionNodeContent",
            scnRandomizerNode => "SceneRandomizerNodeContent",
            scnHubNode => "SceneHubNodeContent",
            scnAndNode => "SceneAndNodeContent",
            scnXorNode => "SceneXorNodeContent",
            _ => "SceneDefaultNodeContent"
        };

        return GetResourceWithFallback(resourceKey, "SceneDefaultNodeContent", "#11444444");
    }

    public static Brush GetBackgroundForQuestNodeType(questNodeDefinition node)
    {
        var resourceKey = node switch
        {
            questStartNodeDefinition => "QuestStartNodeHeader",
            questEndNodeDefinition => "QuestEndNodeHeader",
            questInputNodeDefinition => "QuestInputNodeHeader",
            questOutputNodeDefinition => "QuestOutputNodeHeader",
            questConditionNodeDefinition => "QuestConditionNodeHeader",
            questPhaseNodeDefinition => "QuestPhaseNodeHeader",
            questSceneNodeDefinition => "QuestSceneNodeHeader",
            questRandomizerNodeDefinition => "QuestRandomizerNodeHeader",
            questFlowControlNodeDefinition => "QuestFlowControlNodeHeader",
            questSwitchNodeDefinition => "QuestSwitchNodeHeader",
            questLogicalAndNodeDefinition => "QuestLogicalAndNodeHeader",
            questLogicalXorNodeDefinition => "QuestLogicalXorNodeHeader",
            questLogicalHubNodeDefinition => "QuestLogicalHubNodeHeader",
            questFactsDBManagerNodeDefinition => "QuestFactsDBManagerNodeHeader",
            questItemManagerNodeDefinition => "QuestItemManagerNodeHeader",
            questCharacterManagerNodeDefinition => "QuestCharacterManagerNodeHeader",
            questUIManagerNodeDefinition => "QuestUIManagerNodeHeader",
            questAudioNodeDefinition => "QuestAudioNodeHeader",
            questJournalNodeDefinition => "QuestJournalNodeHeader",
            questPauseConditionNodeDefinition => "QuestPauseConditionNodeHeader",
            questSceneManagerNodeDefinition => "QuestSceneManagerNodeHeader",
            questRenderFxManagerNodeDefinition => "QuestRenderFxManagerNodeHeader",
            questSpawnManagerNodeDefinition => "QuestSpawnManagerNodeHeader",
            questTriggerManagerNodeDefinition => "QuestTriggerManagerNodeHeader",
            questEntityManagerNodeDefinition => "QuestEntityManagerNodeHeader",
            questEnvironmentManagerNodeDefinition => "QuestEnvironmentManagerNodeHeader",
            questEventManagerNodeDefinition => "QuestEventManagerNodeHeader",
            questMappinManagerNodeDefinition => "QuestMappinManagerNodeHeader",
            questRewardManagerNodeDefinition => "QuestRewardManagerNodeHeader",
            questTimeManagerNodeDefinition => "QuestTimeManagerNodeHeader",
            questVisionModesManagerNodeDefinition => "QuestVisionModesManagerNodeHeader",
            questVoicesetManagerNodeDefinition => "QuestVoicesetManagerNodeHeader",
            questFXManagerNodeDefinition => "QuestFXManagerNodeHeader",
            questPuppetAIManagerNodeDefinition => "QuestPuppetAIManagerNodeHeader",
            questCrowdManagerNodeDefinition => "QuestCrowdManagerNodeHeader",
            questInteractiveObjectManagerNodeDefinition => "QuestInteractiveObjectManagerNodeHeader",
            questPhoneManagerNodeDefinition => "QuestPhoneManagerNodeHeader",
            _ => "QuestDefaultNodeHeader"
        };

        return GetResourceWithFallback(resourceKey, "QuestDefaultNodeHeader", "#33666666");
    }

    public static Brush GetContentBackgroundForQuestNodeType(questNodeDefinition node)
    {
        var resourceKey = node switch
        {
            questStartNodeDefinition => "QuestStartNodeContent",
            questEndNodeDefinition => "QuestEndNodeContent",
            questInputNodeDefinition => "QuestInputNodeContent",
            questOutputNodeDefinition => "QuestOutputNodeContent",
            questConditionNodeDefinition => "QuestConditionNodeContent",
            questPhaseNodeDefinition => "QuestPhaseNodeContent",
            questSceneNodeDefinition => "QuestSceneNodeContent",
            questRandomizerNodeDefinition => "QuestRandomizerNodeContent",
            questFlowControlNodeDefinition => "QuestFlowControlNodeContent",
            questSwitchNodeDefinition => "QuestSwitchNodeContent",
            questLogicalAndNodeDefinition => "QuestLogicalAndNodeContent",
            questLogicalXorNodeDefinition => "QuestLogicalXorNodeContent",
            questLogicalHubNodeDefinition => "QuestLogicalHubNodeContent",
            questFactsDBManagerNodeDefinition => "QuestFactsDBManagerNodeContent",
            questItemManagerNodeDefinition => "QuestItemManagerNodeContent",
            questCharacterManagerNodeDefinition => "QuestCharacterManagerNodeContent",
            questUIManagerNodeDefinition => "QuestUIManagerNodeContent",
            questAudioNodeDefinition => "QuestAudioNodeContent",
            questJournalNodeDefinition => "QuestJournalNodeContent",
            questPauseConditionNodeDefinition => "QuestPauseConditionNodeContent",
            questSceneManagerNodeDefinition => "QuestSceneManagerNodeContent",
            questRenderFxManagerNodeDefinition => "QuestRenderFxManagerNodeContent",
            questSpawnManagerNodeDefinition => "QuestSpawnManagerNodeContent",
            questTriggerManagerNodeDefinition => "QuestTriggerManagerNodeContent",
            questEntityManagerNodeDefinition => "QuestEntityManagerNodeContent",
            questEnvironmentManagerNodeDefinition => "QuestEnvironmentManagerNodeContent",
            questEventManagerNodeDefinition => "QuestEventManagerNodeContent",
            questMappinManagerNodeDefinition => "QuestMappinManagerNodeContent",
            questRewardManagerNodeDefinition => "QuestRewardManagerNodeContent",
            questTimeManagerNodeDefinition => "QuestTimeManagerNodeContent",
            questVisionModesManagerNodeDefinition => "QuestVisionModesManagerNodeContent",
            questVoicesetManagerNodeDefinition => "QuestVoicesetManagerNodeContent",
            questFXManagerNodeDefinition => "QuestFXManagerNodeContent",
            questPuppetAIManagerNodeDefinition => "QuestPuppetAIManagerNodeContent",
            questCrowdManagerNodeDefinition => "QuestCrowdManagerNodeContent",
            questInteractiveObjectManagerNodeDefinition => "QuestInteractiveObjectManagerNodeContent",
            questPhoneManagerNodeDefinition => "QuestPhoneManagerNodeContent",
            _ => "QuestDefaultNodeContent"
        };

        return GetResourceWithFallback(resourceKey, "QuestDefaultNodeContent", "#11666666");
    }

    /// <summary>
    /// Helper method to get XAML resource with cascading fallbacks
    /// </summary>
    private static Brush GetResourceWithFallback(string resourceKey, string defaultResourceKey, string hardcodedFallback)
    {
        // Try to get the specific resource
        if (Application.Current?.TryFindResource(resourceKey) is Brush brush)
        {
            return brush;
        }
        
        // Fall back to default resource
        if (Application.Current?.TryFindResource(defaultResourceKey) is Brush defaultBrush)
        {
            return defaultBrush;
        }
        
        // Final fallback - hard-coded color for design-time safety
        return new SolidColorBrush((Color)ColorConverter.ConvertFromString(hardcodedFallback));
    }
} 