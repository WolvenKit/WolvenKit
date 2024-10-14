using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questDisableableNodeDefinitionWrapper<T> : questNodeDefinitionWrapper<T> where T : questDisableableNodeDefinition
{
    public questDisableableNodeDefinitionWrapper(T questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
        Title = $"[{_castedData.Id}] {Title}";
    }
}