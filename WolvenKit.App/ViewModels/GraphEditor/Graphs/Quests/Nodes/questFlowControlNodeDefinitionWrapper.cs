using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questFlowControlNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questFlowControlNodeDefinition>
{
    public questFlowControlNodeDefinitionWrapper(questFlowControlNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Close", Enums.questSocketType.Input);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Open", Enums.questSocketType.Input);
        CreateSocket("Switch", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}