using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questFactsDBManagerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questFactsDBManagerNodeDefinition>
{
    private questSetVar_NodeType _helper => (questSetVar_NodeType)_castedData.Type.Chunk!;

    public string FactName
    {
        get => _helper.FactName;
        set => _helper.FactName = value;
    }

    public int Value
    {
        get => _helper.Value;
        set => _helper.Value = value;
    }

    public bool SetExactValue
    {
        get => _helper.SetExactValue;
        set => _helper.SetExactValue = value;
    }

    public questFactsDBManagerNodeDefinitionWrapper(questFactsDBManagerNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
        /*if (_castedData.Type?.Chunk is questSetVar_NodeType setVar)
        {
            Title += " - Set";
            Details["Name"] = setVar.FactName;
            Details["Value"] = setVar.Value.ToString();
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