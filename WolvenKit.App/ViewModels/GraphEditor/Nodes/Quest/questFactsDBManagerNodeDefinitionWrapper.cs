using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

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
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}