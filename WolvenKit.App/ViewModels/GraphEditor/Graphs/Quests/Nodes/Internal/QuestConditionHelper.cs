using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes.Internal;

public class QuestConditionHelper
{
    public static (string suffix, Dictionary<string, string> details) GetDetails(questIBaseCondition data)
    {
        var suffix = "";
        var details = new Dictionary<string, string>();

        if (data is questTriggerCondition triggerCondition)
        {
            details.Add("Trigger Area", triggerCondition.TriggerAreaRef.GetResolvedText()!);
            details.Add("Type", triggerCondition.Type.ToEnumString());
        }

        if (data is questObjectCondition objectCondition && objectCondition.Type.Chunk is questDevice_ConditionType deviceCondition)
        {
            details.Add("Object", deviceCondition.ObjectRef.GetResolvedText()!);
            details.Add("Class", deviceCondition.DeviceControllerClass.GetResolvedText()!);
            details.Add("Function", deviceCondition.DeviceConditionFunction.GetResolvedText()!);
        }

        if (data is questFactsDBCondition factsDbCondition && factsDbCondition.Type.Chunk is questVarComparison_ConditionType varComparisonCondition)
        {
            suffix = " - Compare";
            details.Add("Name", varComparisonCondition.FactName);
            details.Add("Comparison", varComparisonCondition.ComparisonType.ToEnumString());
            details.Add("Value", varComparisonCondition.Value.ToString());
        }

        if (data is questSpawnerCondition spawnerCondition && spawnerCondition.Type.Chunk is questSpawnerReady_ConditionType spawnerReadyCondition)
        {
            suffix = " - Is Ready";
            details.Add("Reference", spawnerReadyCondition.SpawnerReference.GetResolvedText()!);
        }

        if (data is questCharacterCondition characterCondition && characterCondition.Type.Chunk is questCharacterMount_ConditionType characterMountCondition)
        {
            suffix = " - Is Mounted";
            details.Add("Parent Ref", characterMountCondition.ParentRef.Reference.GetResolvedText()!);
        }

        return (suffix, details);
    }
}