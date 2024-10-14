using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.App.Extensions;
using WolvenKit.Common;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Quests.Nodes;

public class questPhaseNodeDefinitionWrapper : questEmbeddedGraphNodeDefinitionWrapper<questPhaseNodeDefinition>, IGraphProvider, INeedsRecalculation, IContextMenuProvider
{
    private readonly GraphContext _context;
    private readonly RedGraphFactory _graphFactory;
    private readonly IArchiveManager _archiveManager;

    private RedGraph? _graph = null;

    public RedGraph? GetGraph()
    {
        if (_graph == null)
        {
            GenerateSubGraph();
        }
        return _graph;
    }

    public void OnContextMenu(ContextMenu menu, UIElement mainView) =>
        menu.AddMenu("Recalculate Sockets", () => RecalculateSockets());


    public questPhaseNodeDefinitionWrapper(questPhaseNodeDefinition questPhaseNodeDefinition, GraphContext context, RedGraphFactory graphFactory, IArchiveManager archiveManager) : base(questPhaseNodeDefinition)
    {
        _context = context;
        _graphFactory = graphFactory;
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
            var chunk = _castedData.PhaseGraph.Chunk;
            _graph = _graphFactory.Create(Title, chunk, _context);
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

            _graph = _graphFactory.Create(fileName!, res, _context);
        }
    }

    public void RecalculateSockets()
    {
        _castedData.Sockets.Clear();

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

        _castedData.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
        {
            Name = "CutDestination",
            Type = Enums.questSocketType.CutDestination
        }));

        GenerateSockets();
    }

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

    internal override void CreateDefaultSockets() => CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
}