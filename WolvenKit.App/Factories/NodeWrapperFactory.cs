using WolvenKit.App.Controllers;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.Common;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Factories;

public class NodeWrapperFactory : INodeWrapperFactory
{
    private readonly IArchiveManager _archiveManager;
    private readonly IGameControllerFactory _gameController;

    public NodeWrapperFactory(IArchiveManager archiveManager, IGameControllerFactory gameController)
    {
        _archiveManager = archiveManager;
        _gameController = gameController;
    }

    public questPhaseNodeDefinitionWrapper QuestPhaseNodeDefinitionWrapper(questPhaseNodeDefinition nodeDefinition) =>
        new(nodeDefinition, this, _archiveManager);

    public questSceneNodeDefinitionWrapper QuestSceneNodeDefinitionWrapper(questSceneNodeDefinition nodeDefinition) =>
        new(nodeDefinition, _gameController, _archiveManager);
}