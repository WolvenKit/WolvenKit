using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class graphGraphNodeDefinitionWrapper<T> : BaseQuestViewModel<T> where T : graphGraphNodeDefinition
{
    public graphGraphNodeDefinitionWrapper(T graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
    }
}

public class graphGraphNodeDefinitionWrapper : graphGraphNodeDefinitionWrapper<graphGraphNodeDefinition>
{
    public graphGraphNodeDefinitionWrapper(graphGraphNodeDefinition graphGraphNodeDefinition) : base(graphGraphNodeDefinition)
    {
    }
}