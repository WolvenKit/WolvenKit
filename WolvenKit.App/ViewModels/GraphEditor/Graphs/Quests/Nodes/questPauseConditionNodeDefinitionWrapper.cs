using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questPauseConditionNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questPauseConditionNodeDefinition>
{
    public questPauseConditionNodeDefinitionWrapper(questPauseConditionNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
        /*if (graphGraphNodeDefinition.Condition?.Chunk != null)
        {
            var (suffix, details) = QuestConditionHelper.GetDetails(graphGraphNodeDefinition.Condition.Chunk);

            Title += " " + graphGraphNodeDefinition.Condition.Chunk.GetType().Name[5..^9] + suffix;
            foreach (var detail in details)
            {
                Details.Add(detail.Key, detail.Value);
            }
        }*/

        Details.AddRange(NodeProperties.GetPropertiesFor(graphGraphNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}