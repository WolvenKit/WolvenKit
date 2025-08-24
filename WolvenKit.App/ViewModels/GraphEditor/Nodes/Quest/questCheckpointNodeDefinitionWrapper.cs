using System.Collections.Generic;
using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questCheckpointNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questCheckpointNodeDefinition>
{
    public questCheckpointNodeDefinitionWrapper(questCheckpointNodeDefinition questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
        RefreshDetails();
    }

    protected override void PopulateDetailsInto(Dictionary<string, string> details)
    {
        details.Add("Debug String", _castedData.DebugString);
        base.PopulateDetailsInto(details);
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}
