using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questRenderFxManagerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questRenderFxManagerNodeDefinition>
{
    public questRenderFxManagerNodeDefinitionWrapper(questRenderFxManagerNodeDefinition node) : base(node)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}