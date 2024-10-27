using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questLogicalBaseNodeDefinitionWrapper<T> : questSignalStoppingNodeDefinitionWrapper<T> where T : questLogicalBaseNodeDefinition
{
    public questLogicalBaseNodeDefinitionWrapper(T questLogicalBaseNodeDefinition) : base(questLogicalBaseNodeDefinition)
    {
    }
}