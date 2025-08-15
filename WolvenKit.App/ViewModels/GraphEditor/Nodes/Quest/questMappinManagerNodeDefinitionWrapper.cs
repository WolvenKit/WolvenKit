using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questMappinManagerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questMappinManagerNodeDefinition>
{
    public questMappinManagerNodeDefinitionWrapper(questMappinManagerNodeDefinition questMappinManagerNodeDefinition) : base(questMappinManagerNodeDefinition)
    {
        Details.AddRange(NodeProperties.GetPropertiesFor(questMappinManagerNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Active", Enums.questSocketType.Input);
        CreateSocket("Inactive", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}