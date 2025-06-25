using System.Collections.Generic;
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

    protected BaseQuestViewModel(graphGraphNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
        UniqueId = (uint)graphGraphNodeDefinition.GetHashCode();
        Title = $"{graphGraphNodeDefinition.GetType().Name[5..^14]}";
        Background = GetBackgroundForNodeType(graphGraphNodeDefinition);
    }

    private static Brush GetBackgroundForNodeType(graphGraphNodeDefinition node)
    {
        // Create a slight dark tint background based on quest node type
        return node switch
        {
            questStartNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33228B22")), // Dark green tint
            questEndNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B22222")), // Dark red tint
            questInputNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#332288B2")), // Dark blue tint
            questOutputNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B28822")), // Dark orange tint
            questConditionNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2B222")), // Dark yellow tint
            questPhaseNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B222B2")), // Dark purple tint
            questSceneNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3322B2B2")), // Dark cyan tint
            questRandomizerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B2AA22")), // Dark orange tint
            questFlowControlNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3355AA22")), // Dark lime tint
            questSwitchNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA2255")), // Dark pink tint
            questLogicalAndNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#332255AA")), // Dark light blue tint
            questLogicalXorNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA5522")), // Dark brown tint
            questLogicalHubNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3355AA55")), // Dark green-blue tint
            questFactsDBManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA22AA")), // Dark magenta tint
            questItemManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3377AA22")), // Dark olive tint
            questCharacterManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA7722")), // Dark amber tint
            questUIManagerNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#332277AA")), // Dark teal tint
            questAudioNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33AA2277")), // Dark rose tint
            questJournalNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3377AA77")), // Dark sage tint
            questPauseConditionNodeDefinition => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33B28822")), // Dark orange tint
            _ => new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33666666")) // Default darker gray tint
        };
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
            Title = $"[{questNode.Id}] {questNode.GetType().Name[5..^14]}";
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