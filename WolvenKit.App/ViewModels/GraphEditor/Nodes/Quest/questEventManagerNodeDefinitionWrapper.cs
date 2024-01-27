using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questEventManagerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questEventManagerNodeDefinition>
{
    public questEventManagerNodeDefinitionWrapper(questEventManagerNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
        Details.Add("Manager Name", questDisableableNodeDefinition.ManagerName);
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}