using System;
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

        // ID is now shown separately via NodeIdText
        if (_castedData.SceneFile.DepotPath != ResourcePath.Empty && _castedData.SceneFile.DepotPath.IsResolvable)
        {
            Details.Add("Filename", Path.GetFileName(_castedData.SceneFile.DepotPath.GetResolvedText())!);
            Details.Add("Scene location", _castedData.SceneLocation.NodeRef.GetResolvedText()!);
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
        _castedData.Sockets.Clear();
        _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
        {
            Name = "CutDestination",
            Type = Enums.questSocketType.CutDestination
        }));

        if (_castedData.SceneFile.DepotPath != ResourcePath.Empty)
        {
            var cr2w = _archiveManager.GetCR2WFile(_castedData.SceneFile.DepotPath);

            if (cr2w!.RootChunk is not scnSceneResource res)
            {
                throw new Exception();
            }

            foreach (var entryPoint in res.EntryPoints)
            {
                _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
                {
                    Name = entryPoint.Name,
                    Type = Enums.questSocketType.Input
                }));
            }

            foreach (var exitPoint in res.ExitPoints)
            {
                _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
                {
                    Name = exitPoint.Name,
                    Type = Enums.questSocketType.Output
                }));
            }
        }

        _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
        {
            Name = "Default INT",
            Type = Enums.questSocketType.Output
        }));
        _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
        {
            Name = "Default RET",
            Type = Enums.questSocketType.Output
        }));

        GenerateSockets();
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Default INT", Enums.questSocketType.Output);
        CreateSocket("Default RET", Enums.questSocketType.Output);
    }
}