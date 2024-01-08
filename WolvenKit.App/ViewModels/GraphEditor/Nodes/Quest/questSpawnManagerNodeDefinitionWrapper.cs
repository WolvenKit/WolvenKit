using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questSpawnManagerNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questSpawnManagerNodeDefinition>
{
    public questSpawnManagerNodeDefinitionWrapper(questSpawnManagerNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
        var actions = new List<string>();
        foreach (var action in questSignalStoppingNodeDefinition.Actions)
        {
            actions.Add(action.Type.Chunk!.Action.ToEnumString());
        }

        if (actions.Count > 0)
        {
            Details.Add("Actions", string.Join(", ", actions));
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}