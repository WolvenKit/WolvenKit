using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public abstract class BaseQuestViewModel : GraphEditor.NodeViewModel, IRefreshableDetails
{
    public override uint UniqueId { get; }

    public Brush Background { get; protected set; }
    public Brush ContentBackground { get; protected set; }

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
        Title = FormatQuestNodeName(graphGraphNodeDefinition.GetType().Name);
        Background = GetBackgroundForNodeType(graphGraphNodeDefinition);
        ContentBackground = GetContentBackgroundForNodeType(graphGraphNodeDefinition);
        
        // Check if this is a simple node type that should have uniform colors
        UpdateBackgroundsBasedOnNodeType(graphGraphNodeDefinition);
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

        // Remove common suffixes
        if (typeName.EndsWith("NodeDefinition"))
        {
            typeName = typeName[..^14];
        }
        else if (typeName.EndsWith("Node"))
        {
            typeName = typeName[..^4];
        }

        return typeName;
    }

    private static Brush GetBackgroundForNodeType(graphGraphNodeDefinition node)
    {
        if (node is questNodeDefinition questNode)
        {
            if (Application.Current?.Resources != null)
            {
                return GraphNodeColors.GetBackgroundForQuestNodeType(questNode);
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
                return GraphNodeColors.GetContentBackgroundForQuestNodeType(questNode);
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
        if (Data is questNodeDefinition questNode)
        {
            var formattedName = FormatQuestNodeName(questNode.GetType().Name);
            Title = formattedName; // ID is now shown separately via NodeIdText
        }
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