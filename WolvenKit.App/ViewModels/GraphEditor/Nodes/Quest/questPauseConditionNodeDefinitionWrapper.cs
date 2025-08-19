using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questPauseConditionNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questPauseConditionNodeDefinition>
{
    public questPauseConditionNodeDefinitionWrapper(questPauseConditionNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
        // Use semantic condition display for details only, don't modify title
        if (graphGraphNodeDefinition.Condition?.Chunk != null)
        {
            // Get semantic condition details
            var semanticDetails = QuestConditionHelper.GetSemanticConditionDisplay(graphGraphNodeDefinition.Condition.Chunk);
            Details.AddRange(semanticDetails);
        }
        else
        {
            // Fallback to general properties if no condition
            Details.AddRange(NodeProperties.GetPropertiesFor(graphGraphNodeDefinition));
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}