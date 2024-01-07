using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questJournalNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questJournalNodeDefinition>
{
    public questJournalNodeDefinitionWrapper(questJournalNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
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