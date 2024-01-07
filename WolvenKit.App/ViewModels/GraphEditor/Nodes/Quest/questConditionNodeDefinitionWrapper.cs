using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questConditionNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questConditionNodeDefinition>
{
    public questConditionNodeDefinitionWrapper(questConditionNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("False", Enums.questSocketType.Output);
        CreateSocket("True", Enums.questSocketType.Output);
    }
}