using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questConditionNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questConditionNodeDefinition>
{
    public questConditionNodeDefinitionWrapper(questConditionNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
        /*if (questDisableableNodeDefinition.Condition?.Chunk != null)
        {
            var (suffix, details) = QuestConditionHelper.GetDetails(questDisableableNodeDefinition.Condition.Chunk);

            Title += " " + questDisableableNodeDefinition.Condition.Chunk.GetType().Name[5..^9] + suffix;
            foreach (var detail in details)
            {
                Details.Add(detail.Key, detail.Value);
            }
        }*/

        if (questDisableableNodeDefinition.Condition?.Chunk != null)
        {
            var semantic = QuestConditionHelper.GetSemanticConditionDisplay(questDisableableNodeDefinition.Condition.Chunk);
            var hasCond = semantic.TryGetValue("Condition", out var condText);
            var isGeneric = !hasCond || string.IsNullOrWhiteSpace(condText) || condText.TrimEnd().EndsWith(" condition");

            if (!isGeneric)
            {
                Details.AddRange(semantic);
            }
            else
            {
                // Fall back to comprehensive node property discovery for full detail list
                Details.AddRange(NodeProperties.GetPropertiesFor(questDisableableNodeDefinition));
            }
        }
        else
        {
            Details.AddRange(NodeProperties.GetPropertiesFor(questDisableableNodeDefinition));
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("False", Enums.questSocketType.Output);
        CreateSocket("True", Enums.questSocketType.Output);
    }
}