using System;
using WolvenKit.App.Controllers;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
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

    public NodeViewModel Create(object nodeData) => nodeData switch
    {
        // Quest nodes
        questPhaseNodeDefinition qpn => QuestPhaseNodeDefinitionWrapper(qpn),
        questSceneNodeDefinition qsn => QuestSceneNodeDefinitionWrapper(qsn),
        
        // Scene nodes - derived types first, then base types
        scnAndNode an => new scnAndNodeWrapper(an),
        scnXorNode xn => new scnXorNodeWrapper(xn),
        scnHubNode hn => new scnHubNodeWrapper(hn),
        scnRandomizerNode rn => new scnRandomizerNodeWrapper(rn),
        scnCutControlNode ccn => new scnCutControlNodeWrapper(ccn),
        scnInterruptManagerNode imn => new scnInterruptManagerNodeWrapper(imn),
        scnDeletionMarkerNode dmn => new scnDeletionMarkerNodeWrapper(dmn),
        
        // Note: Some scene nodes like scnStartNode, scnEndNode, scnSectionNode, etc. require
        // additional constructor parameters (entryPoint, exitPoint, scnSceneResource) that we
        // don't have access to in this generic factory context
        _ => throw new NotSupportedException($"Unsupported node type: {nodeData.GetType().Name}")
    };
}