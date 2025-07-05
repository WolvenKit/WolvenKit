using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Factories;

public interface INodeWrapperFactory
{
    public questPhaseNodeDefinitionWrapper QuestPhaseNodeDefinitionWrapper(questPhaseNodeDefinition nodeDefinition);
    public questSceneNodeDefinitionWrapper QuestSceneNodeDefinitionWrapper(questSceneNodeDefinition nodeDefinition);
    public NodeViewModel Create(object nodeData);
}