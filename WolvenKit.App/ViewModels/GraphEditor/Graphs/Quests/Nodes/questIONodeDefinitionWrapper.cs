using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questIONodeDefinitionWrapper<T> : questDisableableNodeDefinitionWrapper<T> where T : questIONodeDefinition
{
    public questIONodeDefinitionWrapper(T questIONodeDefinition) : base(questIONodeDefinition)
    {
    }
}