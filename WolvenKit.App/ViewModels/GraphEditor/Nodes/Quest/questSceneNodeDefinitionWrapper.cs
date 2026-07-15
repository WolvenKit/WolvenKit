using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.App.Controllers;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questSceneNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questSceneNodeDefinition>, IGraphProvider
{
    private readonly ILoggerService _loggerService;
    private readonly IArchiveManager _archiveManager;
    private readonly IGameControllerFactory _gameController;

    private RedGraph? _graph = null;

    public RedGraph Graph
    {
        get
        {
            if (_graph == null)
            {
                GenerateSubGraph();
            }
            return _graph!;
        }
    }

    public questSceneNodeDefinitionWrapper(questSceneNodeDefinition nodeDefinition, ILoggerService loggerService, IGameControllerFactory gameController, IArchiveManager archiveManager) : base(nodeDefinition)
    {
        _loggerService = loggerService;
        _archiveManager = archiveManager;
        _gameController = gameController;

        RefreshDetails();
    }

    protected override void PopulateDetailsInto(Dictionary<string, string> details)
    {
        details.Add("Type", "Scene");
        
        if (_castedData.SceneFile.DepotPath != ResourcePath.Empty && _castedData.SceneFile.DepotPath.IsResolvable)
        {
            details.Add("Scene File", Path.GetFileName(_castedData.SceneFile.DepotPath.GetResolvedText())!);
            details.Add("Scene location", _castedData.SceneLocation.NodeRef.GetResolvedText()!);
        }
    }

    public void AddSceneToProject()
    {
        if (_castedData.SceneFile.DepotPath != ResourcePath.Empty)
        {
            _gameController.GetRed4Controller().AddToMod(_castedData.SceneFile.DepotPath);
        }
    }

    private void GenerateSubGraph()
    {
        if (_castedData.SceneFile.DepotPath != ResourcePath.Empty)
        {
            var cr2w = _archiveManager.GetCR2WFile(_castedData.SceneFile.DepotPath);
            if (cr2w == null)
            {
                _loggerService.Error($"The file \"{_castedData.SceneFile.DepotPath}\" could not be found!");
                return;
            }

            if (cr2w.RootChunk is not scnSceneResource res)
            {
                _loggerService.Error($"The file \"{_castedData.SceneFile.DepotPath}\" could not be opened!");
                return;
            }

            var fileName = ((ulong)_castedData.SceneFile.DepotPath).ToString();
            if (_castedData.SceneFile.DepotPath.IsResolvable)
            {
                fileName = Path.GetFileName(_castedData.SceneFile.DepotPath.GetResolvedText());
            }

            _graph = RedGraph.GenerateSceneGraph(fileName!, res);
        }
    }

    public void RecalculateSockets()
    {
        var hasPrefetchSocket = false;
        foreach (var socketHandle in _castedData.Sockets)
        {
            if (socketHandle.Chunk is questSocketDefinition socket &&
                socket.Type == Enums.questSocketType.Input &&
                socket.Name.GetResolvedText() == "Prefetch")
            {
                hasPrefetchSocket = true;
                break;
            }
        }

        _castedData.Sockets.Clear();
        AddSocket("CutDestination", Enums.questSocketType.CutDestination);

        if (_castedData.SceneFile.DepotPath != ResourcePath.Empty)
        {
            var cr2w = _archiveManager.GetCR2WFile(_castedData.SceneFile.DepotPath);

            if (cr2w!.RootChunk is not scnSceneResource res)
            {
                throw new Exception();
            }

            foreach (var entryPoint in res.EntryPoints)
            {
                AddSocket(entryPoint.Name, Enums.questSocketType.Input);
            }

            foreach (var exitPoint in res.ExitPoints)
            {
                AddSocket(exitPoint.Name, Enums.questSocketType.Output);
            }

            foreach (var scenario in res.InterruptionScenarios)
            {
                if (!scenario.Name.TryGetResolvedText(out var scenarioName) || string.IsNullOrEmpty(scenarioName))
                {
                    continue;
                }

                AddSocket($"{scenarioName} INT", Enums.questSocketType.Output);
                AddSocket($"{scenarioName} RET", Enums.questSocketType.Output);
            }
        }

        if (hasPrefetchSocket)
        {
            AddSocket("Prefetch", Enums.questSocketType.Input);
        }

        GenerateSockets();

        void AddSocket(CName name, Enums.questSocketType type) =>
            _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
            {
                Name = name,
                Type = type
            }));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Default INT", Enums.questSocketType.Output);
        CreateSocket("Default RET", Enums.questSocketType.Output);
    }
}
