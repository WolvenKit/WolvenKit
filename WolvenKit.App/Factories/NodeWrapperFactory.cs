using WolvenKit.App.Controllers;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Factories;

public class NodeWrapperFactory : INodeWrapperFactory
{
    private readonly ILoggerService _loggerService;
    private readonly IArchiveManager _archiveManager;
    private readonly IGameControllerFactory _gameController;

    public NodeWrapperFactory(ILoggerService loggerService, IArchiveManager archiveManager, IGameControllerFactory gameController)
    {
        _loggerService = loggerService;
        _archiveManager = archiveManager;
        _gameController = gameController;
    }

    public questPhaseNodeDefinitionWrapper QuestPhaseNodeDefinitionWrapper(questPhaseNodeDefinition nodeDefinition) =>
        new(nodeDefinition, _loggerService, this, _archiveManager);

    public questSceneNodeDefinitionWrapper QuestSceneNodeDefinitionWrapper(questSceneNodeDefinition nodeDefinition) =>
        new(nodeDefinition, _loggerService, _gameController, _archiveManager);
}