using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questSceneManagerNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questSceneManagerNodeDefinition>
{
    public questSceneManagerNodeDefinitionWrapper(questSceneManagerNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}