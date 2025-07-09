using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questVehicleNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questVehicleNodeDefinition>
{
    public questVehicleNodeDefinitionWrapper(questVehicleNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
        if (questSignalStoppingNodeDefinition.Type?.Chunk is questSetImmovable_NodeType)
        {
            Title = "Vehicle (Immovable)";
        }
        
        Details.AddRange(NodeProperties.GetPropertiesFor(questSignalStoppingNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}