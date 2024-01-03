using System;
using System.IO;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.Common;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

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
        if (_castedData.SceneFile.DepotPath != ResourcePath.Empty && _castedData.SceneFile.DepotPath.IsResolvable)
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
        else
        {
            throw new Exception();
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("Default INT", Enums.questSocketType.Output);
        CreateSocket("Default RET", Enums.questSocketType.Output);
    }
}