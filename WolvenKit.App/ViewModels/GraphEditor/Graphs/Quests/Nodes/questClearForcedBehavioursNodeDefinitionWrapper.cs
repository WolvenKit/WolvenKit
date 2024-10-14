using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questClearForcedBehavioursNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questClearForcedBehavioursNodeDefinition>
{
    public questClearForcedBehavioursNodeDefinitionWrapper(questClearForcedBehavioursNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}