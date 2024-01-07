using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questInstancedCrowdControlNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questInstancedCrowdControlNodeDefinition>
{
    public questInstancedCrowdControlNodeDefinitionWrapper(questInstancedCrowdControlNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}