using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;
using System.Reflection;
using System.Linq;
using System;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public abstract class BaseQuestViewModel : GraphEditor.NodeViewModel, IRefreshableDetails
{
    public override uint UniqueId { get; }

    public Brush Background { get; protected set; }
    public Brush ContentBackground { get; protected set; }

    /// <summary>
    /// Whether this node is a player node (has refLocalPlayer set to true)
    /// </summary>
    public bool IsPlayerNode { get; protected set; }

    protected BaseQuestViewModel(graphGraphNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
        // Use the actual quest node ID if available, otherwise fall back to hash code
        if (graphGraphNodeDefinition is questNodeDefinition questNode)
        {
            UniqueId = questNode.Id;
        }
        else
        {
            UniqueId = (uint)graphGraphNodeDefinition.GetHashCode();
        }
        
        // Detect if this is a player node
        DetectPlayerNode(graphGraphNodeDefinition);
        
        Title = FormatQuestNodeName(graphGraphNodeDefinition.GetType().Name);
        Background = GetBackgroundForNodeType(graphGraphNodeDefinition);
        ContentBackground = GetContentBackgroundForNodeType(graphGraphNodeDefinition);
        
        // Check if this is a simple node type that should have uniform colors
        UpdateBackgroundsBasedOnNodeType(graphGraphNodeDefinition);
    }

    /// <summary>
    /// Detect if this node is a player node (has refLocalPlayer set to true anywhere in its structure)
    /// </summary>
    private void DetectPlayerNode(graphGraphNodeDefinition graphGraphNodeDefinition)
    {
        try
        {
            // Exclude organizational/logical nodes that don't need player labels
            if (graphGraphNodeDefinition is questPhaseNodeDefinition or
                questDeletionMarkerNodeDefinition or
                questCheckpointNodeDefinition or
                questLogicalHubNodeDefinition or
                questLogicalAndNodeDefinition or
                questLogicalXorNodeDefinition or
                questFactsDBManagerNodeDefinition or
                questSceneNodeDefinition)
            {
                IsPlayerNode = false;
                return;
            }
            
            // Check for player node patterns recursively with visited set to prevent infinite loops
            var visited = new HashSet<object>();
            IsPlayerNode = CheckForPlayerNodeRecursively(graphGraphNodeDefinition, visited);
        }
        catch (System.Exception)
        {
            // If detection fails, assume it's not a player node
            IsPlayerNode = false;
        }
    }

    /// <summary>
    /// Recursively check an object for player node indicators
    /// </summary>
    protected bool CheckForPlayerNodeRecursively(object obj, HashSet<object> visited)
    {
        if (obj == null) return false;
        
        // Prevent infinite recursion by checking if we've already visited this object
        if (!visited.Add(obj)) return false;

        // Check questUniversalRef for refLocalPlayer
        if (obj is questUniversalRef universalRef && universalRef.RefLocalPlayer == true)
        {
            return true;
        }

        // Check gameEntityReference for player references
        if (obj is gameEntityReference entityRef)
        {
            // Check if reference contains player identifier
            var resolvedText = entityRef.Reference.GetResolvedText()!;
            if (!string.IsNullOrEmpty(resolvedText) && 
                (resolvedText.Contains("player", StringComparison.OrdinalIgnoreCase) ||
                 resolvedText == "#player"))
            {
                return true;
            }
            
            // Check dynamic entity unique name for player
            var dynamicEntityName = entityRef.DynamicEntityUniqueName.GetResolvedText();
            if (!string.IsNullOrEmpty(dynamicEntityName) &&
                dynamicEntityName.Contains("player", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        // Check specific quest condition types that commonly have player flags
        if (obj is questTriggerCondition triggerCondition && triggerCondition.IsPlayerActivator == true)
        {
            return true;
        }

        // Check various quest node types that have specific player flags
        if (obj is questNodeDefinition questNode)
        {
            return CheckQuestNodeForPlayerFlags(questNode, visited);
        }

        // For IRedBaseHandle, check the contained value
        if (obj is IRedBaseHandle handle)
        {
            var handleValue = handle.GetValue();
            if (handleValue != null)
            {
                return CheckForPlayerNodeRecursively(handleValue, visited);
            }
        }

        // For collections, check each item
        if (obj is System.Collections.IEnumerable enumerable and not string)
        {
            foreach (var item in enumerable)
            {
                if (item != null)
                {
                    if (CheckForPlayerNodeRecursively(item, visited))
                        return true;
                }
            }
        }

        // For RedBaseClass objects, check all properties
        if (obj is RedBaseClass redObj)
        {
            return CheckRedBaseClassForPlayerFlags(redObj, visited);
        }

        return false;
    }

    /// <summary>
    /// Check quest node definitions for player-related flags
    /// </summary>
    private bool CheckQuestNodeForPlayerFlags(questNodeDefinition questNode, HashSet<object> visited)
    {
        // Check common quest node types that have player-specific properties
        switch (questNode)
        {
            case questPauseConditionNodeDefinition pauseCondNode:
                if (pauseCondNode.Condition?.Chunk != null && CheckForPlayerNodeRecursively(pauseCondNode.Condition.Chunk, visited))
                    return true;
                break;
                
            case questConditionNodeDefinition condNode:
                if (condNode.Condition?.Chunk != null && CheckForPlayerNodeRecursively(condNode.Condition.Chunk, visited))
                    return true;
                break;
        }

        // Check all properties of the quest node recursively (but avoid circular references)
        return CheckRedBaseClassForPlayerFlags(questNode, visited);
    }

    /// <summary>
    /// Check RedBaseClass properties for player flags
    /// </summary>
    private bool CheckRedBaseClassForPlayerFlags(RedBaseClass obj, HashSet<object> visited)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();
        
        foreach (var prop in properties)
        {
            try
            {
                // Skip properties that might cause issues
                if (prop.Name == "Chunk" || prop.Name == "Parent") continue;
                
                var value = prop.GetValue(obj);
                if (value != null)
                {
                    // Check for specific player-related properties
                    if (prop.Name.Contains("Player", System.StringComparison.OrdinalIgnoreCase) ||
                        prop.Name.Contains("refLocalPlayer", System.StringComparison.OrdinalIgnoreCase))
                    {
                        if (value is CBool boolValue && boolValue == true)
                        {
                            return true;
                        }
                    }
                    
                    // Recursively check the property value
                    if (CheckForPlayerNodeRecursively(value, visited))
                        return true;
                }
            }
            catch (System.Exception)
            {
                // Skip properties that cause exceptions
                continue;
            }
        }
        
        return false;
    }

    /// <summary>
    /// Format quest node type name for display by removing common prefixes and suffixes
    /// </summary>
    private static string FormatQuestNodeName(string typeName)
    {
        // Remove "quest" prefix
        if (typeName.StartsWith("quest"))
        {
            typeName = typeName[5..];
        }

        // Remove "NodeDefinition" suffix
        if (typeName.EndsWith("NodeDefinition"))
        {
            typeName = typeName[..^14];
        }

        // Remove "Definition" suffix
        if (typeName.EndsWith("Definition"))
        {
            typeName = typeName[..^10];
        }

        return typeName;
    }

    private static Brush GetBackgroundForNodeType(graphGraphNodeDefinition node)
    {
        if (node is questNodeDefinition questNode)
        {
            if (Application.Current?.Resources != null)
            {
                return GraphNodeStyling.GetBackgroundForQuestNodeType(questNode);
            }
            
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33666666"));
        }
        
        return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33666666")); // Default darker gray tint
    }

    private static Brush GetContentBackgroundForNodeType(graphGraphNodeDefinition node)
    {
        if (node is questNodeDefinition questNode)
        {
            if (Application.Current?.Resources != null)
            {
                return GraphNodeStyling.GetContentBackgroundForQuestNodeType(questNode);
            }
            
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11666666"));
        }
        
        return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#11666666")); // Very subtle default gray tint
    }

    internal virtual void CreateDefaultSockets()
    {

    }

    /// <summary>
    /// Refresh the quest node's detail information from the underlying data
    /// </summary>
    public virtual void RefreshDetails()
    {
        // Create a new Details dictionary to trigger UI updates
        var tempDetails = new Dictionary<string, string>();
        
        // Repopulate details from the underlying quest node data
        PopulateDetailsInto(tempDetails);
        
        // Replace the Details dictionary to trigger WPF binding updates
        Details = tempDetails;
        
        // Also refresh the title in case it depends on the data
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
        
        // Re-detect player node status in case the data changed
        DetectPlayerNode((graphGraphNodeDefinition)Data);
        OnPropertyChanged(nameof(IsPlayerNode));
    }

    /// <summary>
    /// Override RefreshFromData for quest nodes to avoid breaking connections
    /// Quest nodes don't need socket regeneration during property sync
    /// </summary>
    public override void RefreshFromData()
    {
        // Re-detect player node status in case the data changed
        DetectPlayerNode((graphGraphNodeDefinition)Data);
        
        // Update title
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
        
        // Refresh details
        RefreshDetails();
    }

    /// <summary>
    /// Populate quest node details into the provided dictionary
    /// </summary>
    protected virtual void PopulateDetailsInto(Dictionary<string, string> details)
    {
        if (Data is questNodeDefinition questNode)
        {
            // Use the existing NodeProperties helper to get quest node details
            var nodeDetails = NodeProperties.GetPropertiesFor(questNode);
            foreach (var kvp in nodeDetails)
            {
                details[kvp.Key] = kvp.Value;
            }
        }
    }

    /// <summary>
    /// Update the node title - can be overridden by specific quest node types
    /// </summary>
    protected override void UpdateTitle()
    {
        // Format quest node titles properly  
        Title = FormatQuestNodeName(Data.GetType().Name);
        
        // Also notify about player node properties in case they changed
        OnPropertyChanged(nameof(IsPlayerNode));
    }

    private void UpdateBackgroundsBasedOnNodeType(graphGraphNodeDefinition node)
    {
        // Simple logical/control nodes that should have uniform colors
        if (node is questLogicalAndNodeDefinition or questLogicalXorNodeDefinition or questLogicalHubNodeDefinition or 
            questDeletionMarkerNodeDefinition or questFlowControlNodeDefinition)
        {
            ContentBackground = Background;
        }
    }
}

public class BaseQuestViewModel<T> : BaseQuestViewModel where T : graphGraphNodeDefinition
{
    protected T _castedData => (T)Data;

    public BaseQuestViewModel(graphGraphNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
    }

    protected questSocketDefinition CreateSocket(string name, Enums.questSocketType type)
    {
        var socket = new questSocketDefinition { Name = name, Type = type };

        _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(socket));

        return socket;
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        Output.Clear();

        foreach (var socketHandle in _castedData.Sockets)
        {
            if (socketHandle.Chunk is questSocketDefinition socketDefinition)
            {
                var name = socketDefinition.Name.GetResolvedText()!;

                if (socketDefinition.Type == Enums.questSocketType.Input ||
                    socketDefinition.Type == Enums.questSocketType.CutDestination)
                {
                    Input.Add(new QuestInputConnectorViewModel(name, name, UniqueId, socketDefinition));
                }

                if (socketDefinition.Type == Enums.questSocketType.Output ||
                    socketDefinition.Type == Enums.questSocketType.CutSource)
                {
                    Output.Add(new QuestOutputConnectorViewModel(name, name, UniqueId, socketDefinition));
                }
            }
        }
    }
}