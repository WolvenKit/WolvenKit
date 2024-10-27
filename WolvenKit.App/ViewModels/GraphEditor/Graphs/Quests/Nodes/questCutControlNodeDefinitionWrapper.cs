using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questCutControlNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questCutControlNodeDefinition>
{
    public questCutControlNodeDefinitionWrapper(questCutControlNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("CutSource", Enums.questSocketType.CutSource);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}