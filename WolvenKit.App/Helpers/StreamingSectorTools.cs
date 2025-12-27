using System;
using System.Collections.Generic;
using System.Linq;
using DynamicData;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public class StreamingSectorTools
{
    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;
    private readonly IProjectManager _projectManager;
    private readonly IModTools _modTools;
    private readonly Cr2WTools _cr2WTools;
    private readonly DocumentTools _documentTools;
    private readonly ProjectResourceTools _projectResourceTools;
    private readonly ISettingsManager _settingsManager;
    private readonly IAppArchiveManager _archiveManager;

    public StreamingSectorTools(ILoggerService loggerService, IProjectManager projectManager, IModTools modTools,
        Cr2WTools cr2WTools, DocumentTools documentTools, ProjectResourceTools projectResourceTools,
        ISettingsManager settingsManager, IAppArchiveManager archiveManager, INotificationService notificationService)
    {
        _loggerService = loggerService;
        _projectManager = projectManager;
        _modTools = modTools;
        _cr2WTools = cr2WTools;
        _documentTools = documentTools;
        _projectResourceTools = projectResourceTools;
        _settingsManager = settingsManager;
        _settingsManager = settingsManager;
        _archiveManager = archiveManager;
        _notificationService = notificationService;
    }

    private static void ValidateSector(worldStreamingSector sector)
    {
        if (sector.VariantIndices.Count == 0)
        {
            throw new WolvenKitException(0, "You need to have at least one sector variant configured");
        }

        if (sector.NodeData.Buffer.Data is not worldNodeDataBuffer nodeData)
        {
            throw new WolvenKitException(0, "Invalid node data buffer");
        }

        var variantIndices = sector.VariantIndices.Select(i => (int)i).OrderBy(i => i).ToList();
        if (nodeData.Count > variantIndices.Last())
        {
            throw new WolvenKitException(0, "Invalid variant index");
        }
    }


    private static worldNodeData CopyDataNode(worldNodeData node, worldStreamingSector sector)
    {
        return new worldNodeData()
        {
            NodeIndex = node.NodeIndex,
            Id = node.Id,
            Bounds = node.Bounds,
            Orientation = node.Orientation,
            Pivot = node.Pivot,
            Scale = node.Scale,
            Position = node.Position,
            MaxStreamingDistance = node.MaxStreamingDistance,
            QuestPrefabRefHash = node.QuestPrefabRefHash,
            CookedPrefabData = node.CookedPrefabData
        };
    }

    public List<string> GetNodeAppearances(uint rangeIndex, string absolutePath) =>
        GetDataNodes(rangeIndex, absolutePath).Values.OfType<IRedMeshNode>()
            .Select(n => n.MeshAppearance.ToString() ?? "")
            .Where(s => !string.IsNullOrEmpty(s)).Distinct().ToList();


    public Dictionary<worldNodeData, worldNode?> GetDataNodes(uint rangeIndex, string absolutePath)
    {
        if (_cr2WTools.ReadCr2W(absolutePath) is not { RootChunk: worldStreamingSector sector } ||
            sector.VariantIndices.Count < rangeIndex)
        {
            return [];
        }

        ValidateSector(sector);

        var sectorStartIndex = sector.VariantIndices[(int)(rangeIndex - 1)];
        var sectorEndIndex = sector.VariantIndices.Count - 1;
        if (sector.VariantIndices.Count >= rangeIndex + 1)
        {
            sectorEndIndex = sector.VariantIndices[(int)rangeIndex];
        }

        // will have thrown an exception in ValidateSector if this wasn't valid
        var nodeData = (worldNodeDataBuffer)sector.NodeData.Buffer.Data!;

        var nodeIndices = nodeData.Where((node, index) => index >= sectorStartIndex && index < sectorEndIndex)
            .Select(node => node.NodeIndex).Distinct().ToList();

        return nodeData.Where((node, index) => index >= sectorStartIndex && index < sectorEndIndex).ToDictionary(n => n,
            n =>
            {
                if (n.NodeIndex < sector.Nodes.Count)
                {
                    return null;
                }

                return sector.Nodes[n.NodeIndex].Chunk;
            });
    }

    private worldNode? CopyNodeRef(worldNodeData dataNode, worldStreamingSector sector)
    {
        if (sector.Nodes.Count < dataNode.NodeIndex)
        {
            throw new WolvenKitException(-1, $"Node index of data node {dataNode.Id} out of range");
        }

        var sectorNode = sector.Nodes[dataNode.NodeIndex];

        var newNode = new CHandle<worldNode>() { };
        if (sectorNode.Chunk is not worldNode node)
        {
            return null;
            // _loggerService.Error($"world node {dataNode.NodeIndex} has invalid node data");
            // newNode.Chunk = new worldNode();
        }

        if (sectorNode.Chunk is worldMeshNode meshNode)
        {
            newNode.Chunk = new worldMeshNode()
            {
                MeshAppearance = meshNode.MeshAppearance,
                Mesh = meshNode.Mesh,
                Tag = meshNode.Tag,
                TagExt = meshNode.TagExt,
                CastLocalShadows = meshNode.CastLocalShadows,
                CastShadows = meshNode.CastShadows,
                OccluderAutohideDistanceScale = meshNode.OccluderAutohideDistanceScale,
                OccluderType = meshNode.OccluderType,
                ForceAutoHideDistance = meshNode.ForceAutoHideDistance,
                DebugName = meshNode.DebugName,
                IsHostOnly = meshNode.IsHostOnly,
                IsVisibleInGame = meshNode.IsVisibleInGame,
                ProxyScale = meshNode.ProxyScale,
                SourcePrefabHash = meshNode.SourcePrefabHash,
                CastRayTracedGlobalShadows = meshNode.CastRayTracedGlobalShadows,
                CastRayTracedLocalShadows = meshNode.CastRayTracedLocalShadows,
                LodLevelScales = meshNode.LodLevelScales,
                RemoveFromRainMap = meshNode.RemoveFromRainMap,
                RenderSceneLayerMask = meshNode.RenderSceneLayerMask,
                Version = meshNode.Version,
                WindImpulseEnabled = meshNode.WindImpulseEnabled
            };
        }
        else
        {
            sectorNode.Chunk = new worldNode()
            {
                DebugName = node.DebugName,
                IsHostOnly = node.IsHostOnly,
                IsVisibleInGame = node.IsVisibleInGame,
                ProxyScale = node.ProxyScale,
                SourcePrefabHash = node.SourcePrefabHash,
                Tag = node.Tag,
                TagExt = node.TagExt,
            };
        }

        sector.Nodes.Add(newNode);
        return newNode;
    }

    private static string ReplaceInNodes(List<worldNode?> newNodes, string? searchP = null, string? replaceP = null,
        bool? isRegexP = false,
        bool? isWholeWordP = false)
    {
        return "";
        // if (newNodes.Count == 0)
        // {
        //     return "";
        // }
        //
        // var search = searchP;
        // var replace = replaceP;
        // var isRegex = isRegexP;
        // var isWholeWord = isWholeWordP;
        //
        // if (search is null || replace is null)
        // {
        //     var dropdownOptions = newNodes.OfType<IRedMeshNode>()
        //         .Select(n => n.MeshAppearance.ToString() ?? "")
        //         .Where(s => !string.IsNullOrEmpty(s))
        //         .ToList();
        //
        //     (string search, string replace, bool isRegex, bool wholeWord) result =
        //         Interactions.ShowSearchReplaceDialog(("Search and replace in mesh appearances", false,
        //             dropdownOptions));
        //
        //     search = result.search;
        //     replace = result.replace;
        //     isRegex = result.isRegex;
        //     isWholeWord = result.wholeWord;
        // }
        //
        // if (string.IsNullOrEmpty(search) || string.IsNullOrEmpty(replace))
        // {
        //     return "";
        // }
        //
        // foreach (var worldNode in newNodes.Where(n => n is IRedMeshNode).OfType<IRedMeshNode>()
        //              .Where(n => !string.IsNullOrEmpty(n.MeshAppearance)))
        // {
        //     worldNode.MeshAppearance = StringHelper.ReplaceInString(worldNode.MeshAppearance!, search, replace,
        //         isWholeWord ?? false,
        //         isRegex ?? false);
        // }
        //
        // return replace;
    }

    public string AddSectorVariant(worldStreamingSector sector)
    {
        try
        {
            ValidateSector(sector);
        }
        catch (WolvenKitException e)
        {
            _loggerService.Error(e.Message);
            _notificationService.Error(e.Message);
            return "";
        }

        List<worldNode?> newNodes = [];
        try
        {
            var startIndex = (int)sector.VariantIndices.Last();

            // would have thrown an exception in ValidateSector if this wasn't valid
            var nodeData = (worldNodeDataBuffer)sector.NodeData.Buffer.Data!;

            foreach (var newDataNode in nodeData.Where((node, index) => index >= startIndex)
                         .Select((node) => (worldNodeData)node.DeepCopy()).ToList())
            {
                newNodes.Add(CopyNodeRef(newDataNode, sector));

                newDataNode.NodeIndex = (CUInt16)(newNodes.Count - 1);

                nodeData.Add(newDataNode);
            }

            if (nodeData.Count - 1 == startIndex)
            {
                throw new WolvenKitException(0, "Failed to add sector variant");
            }

            sector.VariantIndices.Add(nodeData.Count);
        }
        catch (Exception e)
        {
            _loggerService.Error(e.Message);
            _notificationService.Error(e.Message);
        }

        return ReplaceInNodes(newNodes);
    }

    private static string GetNodeAppearance(worldStreamingSector sector, CUInt16 nodeIndex)
    {
        if (sector.Nodes.Count < nodeIndex)
        {
            return "";
        }

        var sectorNode = sector.Nodes[nodeIndex];

        if (sectorNode.Chunk is not IRedMeshNode meshNode || string.IsNullOrEmpty(meshNode.MeshAppearance))
        {
            return "";
        }

        return meshNode.MeshAppearance!;
    }


    public List<string> AddSectorVariants(worldStreamingSector sector)
    {
        try
        {
            ValidateSector(sector);
        }
        catch (WolvenKitException e)
        {
            _loggerService.Error(e.Message);
            _notificationService.Error(e.Message);
            return [];
        }


        var startIndex = (int)sector.VariantIndices.Last();

        // would have thrown an exception in ValidateSector if this wasn't valid
        var nodeData = (worldNodeDataBuffer)sector.NodeData.Buffer.Data!;

        // get node appearance names for search&replace
        var nodeAppearanceNames = nodeData.Where((node, index) => index >= startIndex)
            .Select(node => GetNodeAppearance(sector, node.NodeIndex)).Distinct().ToList();

        List<string> newSectorNodes = [];
        //
        // (string search, string replace, bool isRegex, bool wholeWord) result = Interactions.ShowSearchReplaceDialog(
        //     ("Search and replace in mesh appearances (separate multiple entries by comma or linebreak)", true,
        //         nodeAppearanceNames));
        //
        // if (string.IsNullOrEmpty(result.search) || string.IsNullOrEmpty(result.replace))
        // {
        //     return [];
        // }
        // foreach (var replace in result.replace.Split(",").SelectMany(s => s.Split("\n")).Select(s => s.Trim()).ToList())
        // {
        //     List<worldNode?> newNodes = [];
        //     // try
        //     // {
        //
        //     foreach (var newDataNode in nodeData.Where((node, index) => index >= startIndex)
        //                  .Select((node) => CopyDataNode(node, sector)).ToList())
        //     {
        //         newNodes.Add(CopyNodeRef(newDataNode, sector));
        //         newDataNode.NodeIndex = (CUInt16)(newNodes.Count - 1);
        //
        //         nodeData.Add(newDataNode);
        //     }
        //
        //     if (nodeData.Count - 1 == startIndex)
        //     {
        //         throw new WolvenKitException(0, "Failed to add sector variant");
        //     }
        //
        //     sector.VariantIndices.Add(nodeData.Count - 1);
        //     // }
        //     // catch (Exception e)
        //     // {
        //     //     _loggerService.Error(e.Message);
        //     //     _notificationService.Error(e.Message);
        //     // }
        //
        //     newSectorNodes.Add(ReplaceInNodes(newNodes, result.search, replace, result.isRegex, result.wholeWord));
        // }

        return newSectorNodes;
    }

    public void CheckForStreamingSectorFiles(Cp77Project project)
    {
        var sectorFiles = project.ModFiles.Where(s => s.HasFileExtension(".streamingsector")).ToList();
        if (sectorFiles.Count == 0)
        {
            throw new WolvenKitException(0, "You need to have at least one .streamingsector in your project");
        }
    }

    public void AddSectorVariants(worldStreamingBlock sector, Cp77Project project)
    {
        var result = Interactions.ShowNewSectorVariantView((sector, project));
        result?.GenerateResults();
        if (result is null || result.NewAppearances.Count == 0 || result.NewVariantNameOrPrefix is null)
        {
            return;
        }

        if (string.IsNullOrEmpty(result.SectorRelativePath))
        {
            CheckForStreamingSectorFiles(project);
            var sectorFiles = project.ModFiles.Where(s => s.HasFileExtension(".streamingsector")).ToList();
            result.SectorRelativePath = Interactions.AskForDropdownOption((sectorFiles, "Select a sector",
                "Failed to read sector from streamingblock. Please select one of the following sector files:", "", true,
                null));
        }

        if (string.IsNullOrEmpty(result.SectorRelativePath) || !project.ModFiles.Contains(result.SectorRelativePath) ||
            project.GetAbsolutePath(result.SectorRelativePath) is not string sectorPath ||
            _cr2WTools.ReadCr2WNoException(sectorPath) is not CR2WFile
            {
                RootChunk: worldStreamingSector streamingSector
            })
        {
            _notificationService.Info($"Failed to find sector '{result.SectorRelativePath}', aborting");
            _loggerService.Info($"Failed to find sector '{result.SectorRelativePath}', aborting");
            return;
        }

        ValidateSector(streamingSector);

        var sectorPrefix = "";
        if (result.NewAppearances.Count > 1)
        {
            sectorPrefix = result.NewVariantNameOrPrefix + (result.NewVariantNameOrPrefix.EndsWith('_') ? "" : "_");
        }

        // Now iterate and create variants
        foreach (var replaceString in result.NewAppearances)
        {
            // in sector: add nodes
        }
    }
}
