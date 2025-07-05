using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questDynamicSpawnSystemNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questDynamicSpawnSystemNodeDefinition>
{
    public questDynamicSpawnSystemNodeDefinitionWrapper(questDynamicSpawnSystemNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
        Details.AddRange(NodeProperties.GetPropertiesFor(questDisableableNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}