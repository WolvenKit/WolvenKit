using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questSendAICommandNodeDefinitionWrapper : questAICommandNodeBaseWrapper<questSendAICommandNodeDefinition>
{
    public questSendAICommandNodeDefinitionWrapper(questSendAICommandNodeDefinition questAICommandNodeBase) : base(questAICommandNodeBase)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Cancellation", Enums.questSocketType.Output);
        CreateSocket("Failure", Enums.questSocketType.Output);
        CreateSocket("Interruption", Enums.questSocketType.Output);
        CreateSocket("Success", Enums.questSocketType.Output);
    }
}