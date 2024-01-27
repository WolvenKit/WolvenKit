using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questInputNodeDefinitionWrapper : questIONodeDefinitionWrapper<questInputNodeDefinition>
{
    public questInputNodeDefinitionWrapper(questInputNodeDefinition node) : base(node)
    {
    }

    internal override void GenerateSockets()
    {
        base.GenerateSockets();

        var name = _castedData.SocketName.GetResolvedText()!;

        Input.Add(new QuestInputConnectorViewModel(name, name, UniqueId, new questSocketDefinition()));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}