using System;
using System.IO;
using System.Linq;
using WolvenKit.App.Factories;
using WolvenKit.Common;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questPhaseNodeDefinitionWrapper : questEmbeddedGraphNodeDefinitionWrapper<questPhaseNodeDefinition>, IGraphProvider
{
    private readonly INodeWrapperFactory _nodeWrapperFactory;
    private readonly IArchiveManager _archiveManager;

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


    public questPhaseNodeDefinitionWrapper(questPhaseNodeDefinition questPhaseNodeDefinition, INodeWrapperFactory nodeWrapperFactory, IArchiveManager archiveManager) : base(questPhaseNodeDefinition)
    {
        _nodeWrapperFactory = nodeWrapperFactory;
        _archiveManager = archiveManager;

        Title = $"{Title} [{questPhaseNodeDefinition.Id}]";
        if (_castedData.PhaseResource.DepotPath != ResourcePath.Empty && _castedData.PhaseResource.DepotPath.IsResolvable)
        {
            Details.Add("Filename", Path.GetFileName(_castedData.PhaseResource.DepotPath.GetResolvedText())!);
        }
    }

    private void GenerateSubGraph()
    {
        if (_castedData.PhaseGraph != null && _castedData.PhaseGraph.Chunk != null)
        {
            _graph = RedGraph.GenerateQuestGraph(Title, _castedData.PhaseGraph.Chunk, _nodeWrapperFactory);
        }
        else if (_castedData.PhaseResource.DepotPath != ResourcePath.Empty)
        {
            var cr2w = _archiveManager.GetCR2WFile(_castedData.PhaseResource.DepotPath);

            if (cr2w is not { RootChunk: questQuestPhaseResource res } || res.Graph?.Chunk == null)
            {
                throw new Exception();
            }

            var fileName = ((ulong)_castedData.PhaseResource.DepotPath).ToString();
            if (_castedData.PhaseResource.DepotPath.IsResolvable)
            {
                fileName = Path.GetFileName(_castedData.PhaseResource.DepotPath.GetResolvedText());
            }

            _graph = RedGraph.GenerateQuestGraph(fileName!, res.Graph.Chunk, _nodeWrapperFactory);
        }
        else
        {
            throw new Exception();
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

        if (_castedData.PhaseResource.DepotPath != ResourcePath.Empty)
        {
            var cr2w = _archiveManager.GetCR2WFile(_castedData.PhaseResource.DepotPath);

            if (cr2w is not { RootChunk: questQuestPhaseResource res } || res.Graph?.Chunk == null)
            {
                throw new Exception();
            }

            InternalRecalculateSockets(res.Graph.Chunk);
        }

        if (_castedData.PhaseGraph is { Chunk: { } phaseGraph })
        {
            InternalRecalculateSockets(phaseGraph);
        }

        GenerateSockets();

        void InternalRecalculateSockets(graphGraphDefinition graphDefinition)
        {
            foreach (var nodeHandle in graphDefinition.Nodes)
            {
                if (nodeHandle.Chunk is questInputNodeDefinition inputNode)
                {
                    _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
                    {
                        Name = inputNode.SocketName,
                        Type = Enums.questSocketType.Input
                    }));
                }

                if (nodeHandle.Chunk is questOutputNodeDefinition outputNode)
                {
                    _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
                    {
                        Name = outputNode.SocketName,
                        Type = Enums.questSocketType.Output
                    }));
                }
            }
        }
    }

    internal override void CreateDefaultSockets() => CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
}