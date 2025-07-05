using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questCheckpointNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questCheckpointNodeDefinition>
{
    public questCheckpointNodeDefinitionWrapper(questCheckpointNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
        Details.Add("Debug String", questSignalStoppingNodeDefinition.DebugString);
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}