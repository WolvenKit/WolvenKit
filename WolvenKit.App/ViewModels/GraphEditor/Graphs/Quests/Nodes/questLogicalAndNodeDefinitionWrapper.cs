using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questLogicalAndNodeDefinitionWrapper : questLogicalBaseNodeDefinitionWrapper<questLogicalAndNodeDefinition>
{
    public questLogicalAndNodeDefinitionWrapper(questLogicalAndNodeDefinition questLogicalBaseNodeDefinition) : base(questLogicalBaseNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In1", Enums.questSocketType.Input);
        CreateSocket("In2", Enums.questSocketType.Input);
        CreateSocket("Out1", Enums.questSocketType.Output);
    }
}