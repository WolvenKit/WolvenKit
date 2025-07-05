using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questEntityManagerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questEntityManagerNodeDefinition>
{
    public questEntityManagerNodeDefinitionWrapper(questEntityManagerNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
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