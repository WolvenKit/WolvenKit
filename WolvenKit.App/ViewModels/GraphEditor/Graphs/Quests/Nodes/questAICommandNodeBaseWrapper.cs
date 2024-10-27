using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questAICommandNodeBaseWrapper<T> : questSignalStoppingNodeDefinitionWrapper<T> where T : questAICommandNodeBase
{
    public questAICommandNodeBaseWrapper(T questAICommandNodeBase) : base(questAICommandNodeBase)
    {
    }
}