using System;
using System.IO;
using WolvenKit.App.Controllers;
using WolvenKit.Common;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questSceneNodeDefinitionWrapper : questSignalStoppingNodeDefinitionWrapper<questSceneNodeDefinition>, IGraphProvider
{
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

    public questSceneNodeDefinitionWrapper(questSceneNodeDefinition nodeDefinition, IGameControllerFactory gameController, IArchiveManager archiveManager) : base(nodeDefinition)
    {
        _archiveManager = archiveManager;
        _gameController = gameController;

        Title = $"{Title} [{nodeDefinition.Id}]";
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

            if (cr2w!.RootChunk is not scnSceneResource res)
            {
                throw new Exception();
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