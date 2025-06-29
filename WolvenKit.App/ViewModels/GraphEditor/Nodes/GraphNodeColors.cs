using System.Windows;
using System.Windows.Media;
using WolvenKit.Interfaces.Extensions;
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