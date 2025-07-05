using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questSignalStoppingNodeDefinitionWrapper<T> : questDisableableNodeDefinitionWrapper<T> where T : questSignalStoppingNodeDefinition
{
    public questSignalStoppingNodeDefinitionWrapper(T questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }
}