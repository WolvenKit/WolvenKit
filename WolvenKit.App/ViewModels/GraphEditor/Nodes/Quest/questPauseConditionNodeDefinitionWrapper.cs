using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questPauseConditionNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questPauseConditionNodeDefinition>
{
    public questPauseConditionNodeDefinitionWrapper(questPauseConditionNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
        if (graphGraphNodeDefinition.Condition?.Chunk != null)
        {
            Details.Add("Type", graphGraphNodeDefinition.Condition.Chunk.GetType().Name[5..^9]);
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}