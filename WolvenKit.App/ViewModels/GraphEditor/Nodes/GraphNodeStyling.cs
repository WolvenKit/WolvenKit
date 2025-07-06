using System;
using System.Windows;
using System.Windows.Media;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes;

/// <summary>
/// Unified styling helper for all graph node types (scene and quest nodes)
/// Provides colors, icons, and other visual elements
/// </summary>
public static class GraphNodeStyling
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
        var nodeTypeName = node.GetType().Name;
        var resourceKey = $"{nodeTypeName.Replace("Definition", "Header").FirstCharToUpper()}";
        
        return GetResourceWithFallback(resourceKey, "QuestDefaultNodeHeader", "#33666666");
    }

    public static Brush GetContentBackgroundForQuestNodeType(questNodeDefinition node)
    {
        var nodeTypeName = node.GetType().Name;
        var resourceKey = $"{nodeTypeName.Replace("Definition", "Content").FirstCharToUpper()}";
        
        return GetResourceWithFallback(resourceKey, "QuestDefaultNodeContent", "#11666666");
    }

    /// <summary>
    /// Get the emoji icon for a node based on its title/name
    /// </summary>
    public static string GetIconForNodeTitle(string nodeTitle)
    {
        return nodeTitle switch
        {
            // Scene Nodes
            "Start" => "▶️",
            "End" => "⏹️",
            "Section" => "🎬",
            "RewindableSection" => "⏪",
            "Choice" => "🔀",
            "And" => "🔗",
            "Xor" => "🚪",
            "Hub" => "🌐",
            "Randomizer" => "🎲",
            "Scene CutControl" => "✂️",
            "Quest CutControl" => "↪️",
            "InterruptManager" => "⚠️",
            "DeletionMarker" => "👻",
            "FlowControl" => "🚦",
            
            // Quest Nodes
            "Scene" => "🎭",
            "Phase" => "📁",
            "Condition" => "❓",
            "FactsDBManager" => "💾",
            "EntityManager" => "👥",
            "EventManager" => "🛎️",
            "EnvironmentManager" => "🌦️",
            "CrowdManager" => "👫",
            "AchievementManager" => "🏆",
            "DynamicSpawnSystem" => "🪄",
            "Journal" => "📜",
            "MappinManager" => "📍",
            "Minigame" => "🎮",
            "PauseCondition" => "⏸️",
            "RewardManager" => "💰",
            "SceneManager" => "🎬",
            "TriggerManager" => "🔘",
            "Vehicle" => "🚗",
            "Vehicle (Immovable)" => "🗿",
            "UseWorkspot" => "🧍",
            "ItemManager" => "🎒",
            "CharacterManager" => "👤",
            "TimeManager" => "⏰",
            "Audio" => "🔊",
            "Checkpoint" => "🚩",
            "Input" => "⬇️",
            "Output" => "⬆️",
            "InteractiveObjectManager" => "🎯",
            "FXManager" => "✨",
            "InstancedCrowdControl" => "👥",
            "PuppetAIManager" => "🤖",
            "RenderFxManager" => "🎨",
            "Switch" => "🔀",
            "VisionModesManager" => "👁️",
            "VoicesetManager" => "🗣️",
            "MapPinManager" => "📍",
            "ClearForcedBehaviours" => "🧽",
            "ForcedBehaviour" => "🎭",
            "PhoneManager" => "📱",
            "SpawnManager" => "🐣",
            "TransformAnimator" => "🔄",
            "UIManager" => "💻",
            "UIManager (Debug Warning)" => "🐛",
            "WorldDataManager" => "🌍",
            "EquipItem" => "👕",
            "SendAICommand" => "🤖",
            "TeleportPuppet" => "🚀",
            "VehicleNodeCommand" => "🚗",
            "Combat" => "⚔️",
            "MiscAICommand" => "🧩",
            "MovePuppet" => "🚶",
            "LogicalAnd" => "🔗",
            "LogicalHub" => "🌐",
            "LogicalXor" => "🚪",
            "GameManager" => "🎮",
            
            // Default fallback
            _ => "⚪"
        };
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

    /// <summary>
    /// Get the formatted title for a node type (same logic as used by node wrappers)
    /// </summary>
    public static string GetTitleForNodeType(Type nodeType)
    {
        var typeName = nodeType.Name;
        
        // Quest node types - handle specific wrapper title overrides first
        if (typeof(questNodeDefinition).IsAssignableFrom(nodeType))
        {
            // Special cases where wrappers override the default title
            return typeName switch
            {
                "questCutControlNodeDefinition" => "Quest CutControl",
                _ => GetGenericQuestNodeTitle(typeName)
            };
        }
        
        // Scene node types - handle special cases to match wrapper titles
        if (typeof(scnSceneGraphNode).IsAssignableFrom(nodeType))
        {
            // Special cases that have custom titles in their wrappers
            return typeName switch
            {
                "scnCutControlNode" => "Scene CutControl",
                "questCutControlNodeDefinition" => "Quest CutControl",
                "DynamicSceneGraphNode" => "DynamicSceneGraph",
                _ => typeName[3..^4] // Default: Remove "scn" prefix and "Node" suffix
            };
        }
        
        return typeName;
    }

    /// <summary>
    /// Get the generic quest node title using the same logic as BaseQuestViewModel
    /// </summary>
    private static string GetGenericQuestNodeTitle(string typeName)
    {
        // Use the same logic as NodeProperties.GetNameFromClass and BaseQuestViewModel
        if (typeName.StartsWith("quest"))
        {
            typeName = typeName[5..]; // Remove "quest" prefix
        }
        
        if (typeName.EndsWith("NodeDefinition"))
        {
            typeName = typeName[..^14]; // Remove "NodeDefinition" suffix
        }
        else if (typeName.EndsWith("Node"))
        {
            typeName = typeName[..^4]; // Remove "Node" suffix  
        }
        
        return typeName;
    }
} 