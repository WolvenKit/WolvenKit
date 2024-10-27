﻿using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questStartNodeDefinitionWrapper : questStartEndNodeDefinitionWrapper<questStartNodeDefinition>
{
    public questStartNodeDefinitionWrapper(questStartNodeDefinition questStartEndNodeDefinition) : base(questStartEndNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}