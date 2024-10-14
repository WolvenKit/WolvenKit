using WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questOutputNodeDefinitionWrapper : questIONodeDefinitionWrapper<questOutputNodeDefinition>
{
    public questOutputNodeDefinitionWrapper(questOutputNodeDefinition questOutputNodeDefinition) : base(questOutputNodeDefinition)
    {
    }

    internal override void GenerateSockets()
    {
        base.GenerateSockets();

        var name = _castedData.SocketName.GetResolvedText()!;
        Output.Add(new QuestOutputConnectorViewModel(name, name, UniqueId, new questSocketDefinition()));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
    }
}