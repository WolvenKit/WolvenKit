using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questTransformAnimatorNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questTransformAnimatorNodeDefinition>
{
    public questTransformAnimatorNodeDefinitionWrapper(questTransformAnimatorNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}