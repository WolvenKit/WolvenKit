using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questCombatNodeDefinitionWrapper : questConfigurableAICommandNodeWrapper<questCombatNodeDefinition>
{
    public questCombatNodeDefinitionWrapper(questCombatNodeDefinition questConfigurableAICommandNode) : base(questConfigurableAICommandNode)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Success", Enums.questSocketType.Output);
    }
}