using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questAICommandNodeBaseWrapper<T> : questSignalStoppingNodeDefinitionWrapper<T> where T : questAICommandNodeBase
{
    public questAICommandNodeBaseWrapper(T questAICommandNodeBase) : base(questAICommandNodeBase)
    {
    }
}