using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questVisionModesManagerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questVisionModesManagerNodeDefinition>
{
    public questVisionModesManagerNodeDefinitionWrapper(questVisionModesManagerNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}