using System.Windows.Media;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public abstract class BaseQuestViewModel : GraphEditor.NodeViewModel
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