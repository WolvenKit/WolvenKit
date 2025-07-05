using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questLogicalHubNodeDefinitionWrapper : questLogicalBaseNodeDefinitionWrapper<questLogicalHubNodeDefinition>
{
    public questLogicalHubNodeDefinitionWrapper(questLogicalHubNodeDefinition questLogicalBaseNodeDefinition) : base(questLogicalBaseNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In1", Enums.questSocketType.Input);
        CreateSocket("Out1", Enums.questSocketType.Output);
    }
}