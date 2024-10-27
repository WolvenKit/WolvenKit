using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questStartEndNodeDefinitionWrapper<T> : questDisableableNodeDefinitionWrapper<T> where T : questStartEndNodeDefinition
{
    public questStartEndNodeDefinitionWrapper(T questStartEndNodeDefinition) : base(questStartEndNodeDefinition)
    {
    }
}