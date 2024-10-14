using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

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

        Details.AddRange(NodeProperties.GetPropertiesFor(questDisableableNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("False", Enums.questSocketType.Output);
        CreateSocket("True", Enums.questSocketType.Output);
    }
}