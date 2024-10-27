using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questNodeDefinitionWrapper<T> : graphGraphNodeDefinitionWrapper<T> where T : questNodeDefinition
{
    public questNodeDefinitionWrapper(T questNodeDefinition) : base(questNodeDefinition)
    {
    }
}

public class questNodeDefinitionWrapper : questNodeDefinitionWrapper<questNodeDefinition>
{
    public questNodeDefinitionWrapper(questNodeDefinition questNodeDefinition) : base(questNodeDefinition)
    {
    }
}