using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questEndNodeDefinitionWrapper : questStartEndNodeDefinitionWrapper<questEndNodeDefinition>
{
    public questEndNodeDefinitionWrapper(questEndNodeDefinition questStartEndNodeDefinition) : base(questStartEndNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
    }
}