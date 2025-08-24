using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.App.Factories;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questPhaseNodeDefinitionWrapper : questEmbeddedGraphNodeDefinitionWrapper<questPhaseNodeDefinition>, IGraphProvider
{
    private readonly ILoggerService _loggerService;
    private readonly INodeWrapperFactory _nodeWrapperFactory;
    private readonly IArchiveManager _archiveManager;

    private RedGraph? _graph = null;

    public RedGraph? Graph
    {
        get
        {
            if (_graph == null)
            {
                GenerateSubGraph();
            }
            return _graph;
        }
    }


    public questPhaseNodeDefinitionWrapper(questPhaseNodeDefinition questPhaseNodeDefinition, ILoggerService loggerService, INodeWrapperFactory nodeWrapperFactory, IArchiveManager archiveManager) : base(questPhaseNodeDefinition)
    {
        _loggerService = loggerService;
        _nodeWrapperFactory = nodeWrapperFactory;
        _archiveManager = archiveManager;

        RefreshDetails();
    }

    protected override void PopulateDetailsInto(Dictionary<string, string> details)
    {
        details.Add("Type", "Phase");
        
        if (_castedData.PhaseResource.DepotPath != ResourcePath.Empty && _castedData.PhaseResource.DepotPath.IsResolvable)
        {
            details.Add("Phase Resource", Path.GetFileName(_castedData.PhaseResource.DepotPath.GetResolvedText())!);
        }
        
        // Add node count for the phase
        var nodeCount = GetPhaseNodeCount();
        if (nodeCount > 0)
        {
            details.Add("Total Nodes", nodeCount.ToString());
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
            if (cr2w == null)
            {
                _loggerService.Error($"The file \"{_castedData.PhaseResource.DepotPath}\" could not be found!");
                return;
            }

            if (cr2w is not { RootChunk: questQuestPhaseResource res } || res.Graph?.Chunk == null)
            {
                _loggerService.Error($"The file \"{_castedData.PhaseResource.DepotPath}\" could not be opened!");
                return;
            }

            var fileName = ((ulong)_castedData.PhaseResource.DepotPath).ToString();
            if (_castedData.PhaseResource.DepotPath.IsResolvable)
            {
                fileName = Path.GetFileName(_castedData.PhaseResource.DepotPath.GetResolvedText());
            }

            _graph = RedGraph.GenerateQuestGraph(fileName!, res.Graph.Chunk, _nodeWrapperFactory);
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

    /// <summary>
    /// Get the total count of nodes in this phase graph
    /// </summary>
    private int GetPhaseNodeCount()
    {
        // Check embedded graph first
        if (_castedData.PhaseGraph?.Chunk != null)
        {
            return _castedData.PhaseGraph.Chunk.Nodes?.Count ?? 0;
        }
        
        // Check external phase resource
        if (_castedData.PhaseResource.DepotPath != ResourcePath.Empty)
        {
            try
            {
                var cr2w = _archiveManager.GetCR2WFile(_castedData.PhaseResource.DepotPath);
                if (cr2w is { RootChunk: questQuestPhaseResource res } && res.Graph?.Chunk != null)
                {
                    return res.Graph.Chunk.Nodes?.Count ?? 0;
                }
            }
            catch (Exception)
            {
                // Silently fail if we can't load the resource
            }
        }
        
        return 0;
    }
}
