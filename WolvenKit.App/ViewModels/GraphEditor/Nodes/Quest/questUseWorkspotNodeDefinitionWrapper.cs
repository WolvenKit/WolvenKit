using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questUseWorkspotNodeDefinitionWrapper : questAICommandNodeBaseWrapper<questUseWorkspotNodeDefinition>
{
    public questUseWorkspotNodeDefinitionWrapper(questUseWorkspotNodeDefinition questAICommandNodeBase) : base(questAICommandNodeBase)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Success", Enums.questSocketType.Output);
        //CreateSocket("Work Started", Enums.questSocketType.Output); TODO[Graph]
    }
}