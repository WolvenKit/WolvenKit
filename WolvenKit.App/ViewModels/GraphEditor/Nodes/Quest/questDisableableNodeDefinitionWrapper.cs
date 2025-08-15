using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questDisableableNodeDefinitionWrapper<T> : questNodeDefinitionWrapper<T> where T : questDisableableNodeDefinition
{
    public questDisableableNodeDefinitionWrapper(T questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
    }
}