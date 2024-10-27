using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public abstract class questEmbeddedGraphNodeDefinitionWrapper<T> : questSignalStoppingNodeDefinitionWrapper<T> where T : questEmbeddedGraphNodeDefinition
{
    public questEmbeddedGraphNodeDefinitionWrapper(T questEmbeddedGraphNodeDefinition) : base(questEmbeddedGraphNodeDefinition)
    {
    }
}