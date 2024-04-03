using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes;

internal class NodeProperties
{
    public static Dictionary<string, string> GetPropertiesFor(questNodeDefinition? node)
    {
        Dictionary<string, string> details = new();

        details["Type"] = GetNameFromClass(node);

        if (node is questPauseConditionNodeDefinition pauseCondCasted)
        {
            details.AddRange(GetPropertiesForConditions(pauseCondCasted?.Condition?.Chunk));
        }
        else if (node is questConditionNodeDefinition condCasted)
        {
            details.AddRange(GetPropertiesForConditions(condCasted?.Condition?.Chunk));
        }
        else if (node is questFactsDBManagerNodeDefinition factDBManagerCasted)
        {
            if (factDBManagerCasted?.Type?.Chunk is questSetVar_NodeType setVarCasted)
            {
                details["Fact Name"] = setVarCasted?.FactName ?? "";
                details["Set Exact Value"] = setVarCasted?.SetExactValue == true ? "True" : "False";
                details["Value"] = setVarCasted?.Value.ToString() ?? "";
            }
        }

        return details;
    }

    private static Dictionary<string, string> GetPropertiesForConditions(questIBaseCondition? node, string logicalCondIndex = "")
    {
        Dictionary<string, string> details = new();

        details[logicalCondIndex + "Condition type"] = GetNameFromClass(node);

        if (node is questTimeCondition condTimeCasted)
        {
            string ConditionTimeTypeName = logicalCondIndex + "Time condition";
            string ConditionTimeValTypeName = logicalCondIndex + "Time";

            if (condTimeCasted?.Type?.Chunk is questRealtimeDelay_ConditionType nodeRealtimeCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeRealtimeCondCasted);
                details[ConditionTimeValTypeName] =
                    FormatNumber(nodeRealtimeCondCasted?.Hours) + ":" +
                    FormatNumber(nodeRealtimeCondCasted?.Minutes) + ":" +
                    FormatNumber(nodeRealtimeCondCasted?.Seconds) + "." +
                    FormatNumber(nodeRealtimeCondCasted?.Miliseconds, true);
            }

            if (condTimeCasted?.Type?.Chunk is questGameTimeDelay_ConditionType nodeGameTimeCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeGameTimeCondCasted);
                details[ConditionTimeValTypeName] =
                    FormatNumber(nodeGameTimeCondCasted?.Days) + "d " +
                    FormatNumber(nodeGameTimeCondCasted?.Hours) + ":" +
                    FormatNumber(nodeGameTimeCondCasted?.Minutes) + ":" +
                    FormatNumber(nodeGameTimeCondCasted?.Seconds);
            }

            if (condTimeCasted?.Type?.Chunk is questTickDelay_ConditionType nodeTickCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeTickCondCasted);
                details[ConditionTimeValTypeName] = FormatNumber(nodeTickCondCasted?.TickCount) + " ticks";
            }

            if (condTimeCasted?.Type?.Chunk is questTimePeriod_ConditionType nodeTimePeriodCondCasted)
            {
                details[ConditionTimeTypeName] = GetNameFromClass(nodeTimePeriodCondCasted);
                details[ConditionTimeValTypeName] =
                    "from " + FormatNumber(nodeTimePeriodCondCasted?.Begin?.Seconds) +
                    " to " + FormatNumber(nodeTimePeriodCondCasted?.End?.Seconds);
            }
        }
        else if (node is questFactsDBCondition condFactCasted)
        {
            if (condFactCasted?.Type?.Chunk is questVarComparison_ConditionType nodeVarCompCondCasted)
            {
                details[logicalCondIndex + "Fact Name"] = nodeVarCompCondCasted?.FactName!;
                details[logicalCondIndex + "Comparison Type"] = nodeVarCompCondCasted?.ComparisonType.ToEnumString()!;
                details[logicalCondIndex + "Value"] = nodeVarCompCondCasted?.Value.ToString()!;
            }

            if (condFactCasted?.Type?.Chunk is questVarVsVarComparison_ConditionType nodeVarVsVarCondCasted)
            {
                details[logicalCondIndex + "Comparison Type"] = nodeVarVsVarCondCasted?.ComparisonType.ToEnumString()!;
                details[logicalCondIndex + "Fact 1 Name"] = nodeVarVsVarCondCasted?.FactName1!;
                details[logicalCondIndex + "Fact 2 Name"] = nodeVarVsVarCondCasted?.FactName2!;
            }
        }
        else if (node is questLogicalCondition condLogicalCasted)
        {
            details[logicalCondIndex + "Operation"] = condLogicalCasted?.Operation.ToEnumString()!;
            if (condLogicalCasted?.Conditions != null)
            {
                for (int i = 0; i <  condLogicalCasted.Conditions.Count; i++)
                {
                    details.AddRange(GetPropertiesForConditions(condLogicalCasted.Conditions[i]?.Chunk, logicalCondIndex + "#" + i + " "));
                }
            }
        }
        else if (node is questCharacterCondition condCharacterCasted)
        {
            if (condCharacterCasted?.Type?.Chunk is questCharacterBodyType_CondtionType nodeCharBodyTypeCondCasted)
            {
                details[logicalCondIndex + "Gender"] = nodeCharBodyTypeCondCasted?.Gender.ToString()!;
                details[logicalCondIndex + "Object Ref"] = ParseGameEntityReference(nodeCharBodyTypeCondCasted?.ObjectRef);
                details[logicalCondIndex + "Is Player"] = nodeCharBodyTypeCondCasted?.IsPlayer == true ? "True" : "False";
            }
        }
        else if (node is questTriggerCondition condTriggerCasted)
        {
            details[logicalCondIndex + "Activator Ref"] = ParseGameEntityReference(condTriggerCasted?.ActivatorRef);
            details[logicalCondIndex + "Is Player Activator"] = condTriggerCasted?.IsPlayerActivator == true ? "True" : "False";
            details[logicalCondIndex + "Trigger Area Ref"] = condTriggerCasted?.TriggerAreaRef.GetResolvedText()!;
            details[logicalCondIndex + "Trigger Type"] = condTriggerCasted?.Type.ToEnumString()!;
        }

        return details;
    }

    private static string ParseGameEntityReference(gameEntityReference? entRef)
    {
        string str = "-";

        if (entRef != null)
        {
            if (entRef.DynamicEntityUniqueName != "None")
            {
                str = entRef.DynamicEntityUniqueName!;
            }
            if (entRef.Reference != 0)
            {
                str = entRef.Reference.GetResolvedText()!;
            }
        }

        return str;
    }

    private static Dictionary<string, string> GetClassProperties(string logicalCondIndex, object obj)
    {
        Dictionary<string, string> details = new();

        foreach (var prop in obj.GetType().GetProperties())
        {
            var val = prop.GetValue(obj, null);
            string valStr = "";

            if (val is CName typeCName)
            {
                valStr = typeCName.ToString() ?? "";
            }
            else if (val is CString typeCString)
            {
                valStr = typeCString;
            }
            else if (val is CBool typeCBool)
            {
                valStr = typeCBool == true ? "True" : "False";
            }
            else if (val?.GetType() == typeof(CEnum))
            {
                valStr = "";
            }
            else if (val?.GetType()?.Name == "CArray`1")
            {
                valStr = "";
            }

            details[logicalCondIndex + prop.Name] = valStr;
        }

        return details;
    }

    private static string GetNameFromClass(RedBaseClass? node)
    {
        string name = "";

        if (node != null)
        {
            name = node.GetType().Name;

            name = name.Replace("quest", "");
            name = name.Replace("_ConditionType", "");
            name = name.Replace("NodeDefinition", "");

            //name = AddSpacesToSentence(name);
        }

        return name;
    }

    private static string AddSpacesToSentence(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return "";
        }

        StringBuilder newText = new StringBuilder(text.Length * 2);
        newText.Append(text[0]);
        for (int i = 1; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]) && text[i - 1] != ' ')
            {
                newText.Append(' ');
            }

            newText.Append(text[i]);
        }
        return newText.ToString();
    }

    private static string FormatNumber(CUInt32? number, bool three = false)
    {
        if (number < 10 && !three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else if (number < 10 && three)
        {
            return "00" + (number.ToString() ?? "0");
        }
        else if (number < 100 && three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else
        {
            return (number.ToString() ?? (three ? "000" : "00"));
        }
    }

    private static string FormatNumber(CInt32? number, bool three = false)
    {
        if (number < 10 && !three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else if (number < 10 && three)
        {
            return "00" + (number.ToString() ?? "0");
        }
        else if (number < 100 && three)
        {
            return "0" + (number.ToString() ?? "0");
        }
        else
        {
            return (number.ToString() ?? (three ? "000" : "00"));
        }
    }
}
