using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questSwitchNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questSwitchNodeDefinition>
{
    public questSwitchNodeDefinitionWrapper(questSwitchNodeDefinition questSwitchNodeDefinition) : base(questSwitchNodeDefinition)
    {
        Details.AddRange(NodeProperties.GetPropertiesFor(questSwitchNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Otherwise", Enums.questSocketType.Output);
    }
}