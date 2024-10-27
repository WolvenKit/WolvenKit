﻿using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questSwitchNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questSwitchNodeDefinition>
{
    public questSwitchNodeDefinitionWrapper(questSwitchNodeDefinition questSwitchNodeDefinition) : base(questSwitchNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Otherwise", Enums.questSocketType.Output);
    }
}