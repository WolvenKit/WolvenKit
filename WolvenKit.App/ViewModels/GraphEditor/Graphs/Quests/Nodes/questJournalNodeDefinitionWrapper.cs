using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questJournalNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questJournalNodeDefinition>
{
    public questJournalNodeDefinitionWrapper(questJournalNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
        Details.AddRange(NodeProperties.GetPropertiesFor(questSignalStoppingNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Active", Enums.questSocketType.Input);
        CreateSocket("Failed", Enums.questSocketType.Input);
        CreateSocket("Inactive", Enums.questSocketType.Input);
        CreateSocket("Succeeded", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}