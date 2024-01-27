using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questMovePuppetNodeDefinitionWrapper : questConfigurableAICommandNodeWrapper<questMovePuppetNodeDefinition>
{
    public questMovePuppetNodeDefinitionWrapper(questMovePuppetNodeDefinition questConfigurableAICommandNode) : base(questConfigurableAICommandNode)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}