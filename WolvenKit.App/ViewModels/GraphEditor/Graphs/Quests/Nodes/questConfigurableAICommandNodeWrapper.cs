using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questConfigurableAICommandNodeWrapper<T> : questAICommandNodeBaseWrapper<T> where T : questConfigurableAICommandNode
{
    public questConfigurableAICommandNodeWrapper(T questConfigurableAICommandNode) : base(questConfigurableAICommandNode)
    {
    }
}