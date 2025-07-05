using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questForcedBehaviourNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questForcedBehaviourNodeDefinition>
{
    public questForcedBehaviourNodeDefinitionWrapper(questForcedBehaviourNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}