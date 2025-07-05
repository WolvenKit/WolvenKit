using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questDeletionMarkerNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questDeletionMarkerNodeDefinition>
{
    public questDeletionMarkerNodeDefinitionWrapper(questDeletionMarkerNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}