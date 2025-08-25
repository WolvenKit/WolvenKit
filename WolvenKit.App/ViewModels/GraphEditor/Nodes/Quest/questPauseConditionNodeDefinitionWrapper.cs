using System.Collections.Generic;
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

    /// <summary>
    /// Override RefreshDetails to preserve semantic condition details
    /// </summary>
    public override void RefreshDetails()
    {
        // Create a new Details dictionary to trigger UI updates (like base class)
        var tempDetails = new Dictionary<string, string>();
        
        // Use the same logic as constructor to preserve semantic details
        if (_castedData.Condition?.Chunk != null)
        {
            // Get semantic condition details
            var semanticDetails = QuestConditionHelper.GetSemanticConditionDisplay(_castedData.Condition.Chunk);
            foreach (var kvp in semanticDetails)
            {
                tempDetails.Add(kvp.Key, kvp.Value);
            }
        }
        else
        {
            // Fallback to general properties if no condition
            var genericDetails = NodeProperties.GetPropertiesFor(_castedData);
            foreach (var kvp in genericDetails)
            {
                tempDetails.Add(kvp.Key, kvp.Value);
            }
        }
        
        // Replace the Details dictionary to trigger WPF binding updates
        Details = tempDetails;
        
        // Also refresh the title in case it depends on the data (from base class)
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
    }
}