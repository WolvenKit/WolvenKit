﻿using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questVehicleNodeCommandDefinitionWrapper : questAICommandNodeBaseWrapper<questVehicleNodeCommandDefinition>
{
    public questVehicleNodeCommandDefinitionWrapper(questVehicleNodeCommandDefinition questAICommandNodeBase) : base(questAICommandNodeBase)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Success", Enums.questSocketType.Output);
    }
}