using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questTypedSignalStoppingNodeDefinitionWrapper<T> : questSignalStoppingNodeDefinitionWrapper<T> where T : questTypedSignalStoppingNodeDefinition
{
    public questTypedSignalStoppingNodeDefinitionWrapper(T questSignalStoppingNodeDefinition) : base(questSignalStoppingNodeDefinition)
    {
    }
}