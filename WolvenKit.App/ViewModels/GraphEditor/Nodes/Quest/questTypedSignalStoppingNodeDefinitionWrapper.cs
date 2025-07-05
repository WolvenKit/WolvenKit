using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questTypedSignalStoppingNodeDefinitionWrapper<T> : questSignalStoppingNodeDefinitionWrapper<T> where T : questTypedSignalStoppingNodeDefinition
{
    public questTypedSignalStoppingNodeDefinitionWrapper(T questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }
}