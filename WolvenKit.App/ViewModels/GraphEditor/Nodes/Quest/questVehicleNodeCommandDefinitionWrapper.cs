﻿using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questVehicleNodeCommandDefinitionWrapper : questAICommandNodeBaseWrapper<questVehicleNodeCommandDefinition>
{
    public questVehicleNodeCommandDefinitionWrapper(questVehicleNodeCommandDefinition questAICommandNodeBase) : base(questAICommandNodeBase)
    {
        Details.AddRange(NodeProperties.GetPropertiesFor(questAICommandNodeBase));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Success", Enums.questSocketType.Output);
    }
}