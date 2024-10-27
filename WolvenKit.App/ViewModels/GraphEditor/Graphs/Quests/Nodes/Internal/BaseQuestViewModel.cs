using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes.Internal;

public abstract class BaseQuestViewModel : NodeViewModel
{
    public override uint UniqueId { get; }

    protected BaseQuestViewModel(graphGraphNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
        UniqueId = (uint)graphGraphNodeDefinition.GetHashCode();
        Title = $"{graphGraphNodeDefinition.GetType().Name[5..^14]}";
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