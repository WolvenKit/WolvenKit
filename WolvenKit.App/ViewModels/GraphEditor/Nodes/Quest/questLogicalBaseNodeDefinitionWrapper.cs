using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questLogicalBaseNodeDefinitionWrapper<T> : questSignalStoppingNodeDefinitionWrapper<T> where T : questLogicalBaseNodeDefinition
{
    public questLogicalBaseNodeDefinitionWrapper(T questLogicalBaseNodeDefinition) : base(questLogicalBaseNodeDefinition)
    {
    }
}