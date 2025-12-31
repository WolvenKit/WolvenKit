using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
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
    private readonly Cr2WTools _cr2WTools;

    public StreamingSectorTools(ILoggerService loggerService,
        Cr2WTools cr2WTools, INotificationService notificationService)
    {
        _loggerService = loggerService;
        _cr2WTools = cr2WTools;
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


    private static worldNodeData CopyDataNode(worldNodeData node)
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

        // var nodeIndices = nodeData.Where((node, index) => index >= sectorStartIndex && index < sectorEndIndex)
        //     .Select(node => node.NodeIndex).Distinct().ToList();

        return nodeData.Where((_, index) => index >= sectorStartIndex && index < sectorEndIndex).ToDictionary(n => n,
            n =>
            {
                if (n.NodeIndex < sector.Nodes.Count)
                {
                    return null;
                }

                return sector.Nodes[n.NodeIndex].Chunk;
            });
    }

    private static worldNode? CopyNode(worldNode? node)
    {
        return node switch
        {
            null => null,
            worldMeshNode meshNode => new worldMeshNode()
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
            },
            _ => new worldNode()
            {
                DebugName = node.DebugName,
                IsHostOnly = node.IsHostOnly,
                IsVisibleInGame = node.IsVisibleInGame,
                ProxyScale = node.ProxyScale,
                SourcePrefabHash = node.SourcePrefabHash,
                Tag = node.Tag,
                TagExt = node.TagExt,
            }
        };
    }

    public void CheckForStreamingSectorFiles(Cp77Project project)
    {
        var sectorFiles = project.ModFiles.Where(s => s.HasFileExtension(".streamingsector")).ToList();
        if (sectorFiles.Count == 0)
        {
            throw new WolvenKitException(0, "You need to have at least one .streamingsector in your project");
        }
    }

    public void AddSectorVariants(worldStreamingBlock block, Cp77Project project)
    {
        var result = Interactions.ShowNewSectorVariantView((block, project, this));
        result?.GenerateResults();
        if (result is null || result.NewAppearances.Count == 0 || result.NewVariantNameOrPrefix is null ||
            string.IsNullOrEmpty(result.TemplateVariant))
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
                RootChunk: worldStreamingSector sector
            } sectorCr2W)
        {
            _notificationService.Info($"Failed to find sector '{result.SectorRelativePath}', aborting");
            _loggerService.Info($"Failed to find sector '{result.SectorRelativePath}', aborting");
            return;
        }

        ValidateSector(sector);

        var sectorPrefix = "";
        if (result.NewAppearances.Count > 1)
        {
            sectorPrefix = result.NewVariantNameOrPrefix + (result.NewVariantNameOrPrefix.EndsWith('_') ? "" : "_");
        }

        EnsureSectorDataNodes();

        // Now iterate and create variants
        foreach (var replaceString in result.NewAppearances)
        {
            var sectorName = $"{sectorPrefix}{replaceString}";

            var matchingDescriptor = block.Descriptors.FirstOrDefault(desc =>
                desc.Data.DepotPath.GetResolvedText() == result.SectorRelativePath);

            if (matchingDescriptor?.Variants.Select(v => v.Name.GetResolvedText()).Where(s => !string.IsNullOrEmpty(s))
                    .Contains(sectorName) == true)
            {
                _loggerService.Warning(
                    $"Sector variant {sectorName} already defined in {result.SectorRelativePath}, skipping");
                continue;
            }

            if (matchingDescriptor is null)
            {
                _loggerService.Error($"Failed to find a matching descriptor for {result.SectorRelativePath}");
                continue;
            }

            var matchingVariant = matchingDescriptor.Variants.FirstOrDefault(var =>
                var.Name.GetResolvedText()?.Contains(result.TemplateVariant!) == true);


            if (matchingVariant is null)
            {
                _loggerService.Error($"Failed to find a matching variant for name {result.TemplateVariant}");
                continue;
            }


            var rangeIndex = AddVariantInSector(replaceString);
            AddVariantInStreamingBlock(rangeIndex, sectorName, matchingDescriptor, matchingVariant);
        }

        _cr2WTools.WriteCr2W(sectorCr2W, sectorPath);

        return;

        void EnsureSectorDataNodes()
        {
            if (result.DataNodes.Count > 0)
            {
                return;
            }
            // TODO: write result.DataNodes by reading them from sector
        }

        int AddVariantInSector(string replaceString)
        {
            // would have thrown an exception in ValidateSector if this wasn't valid
            var startIndex = (int)sector.VariantIndices.Last();
            var endIndex = sector.VariantIndices.Count();

            List<worldNode?> newNodes = [];

            // would have thrown an exception in ValidateSector if this wasn't valid
            var nodeData = (worldNodeDataBuffer)sector.NodeData.Buffer.Data!;

            foreach (var (data, node) in result.DataNodes)
            {
                var newNode = CopyNode(node);
                var newData = CopyDataNode(data);

                if (newNode is not null)
                {
                    if (newNode is IRedMeshNode meshNode && !string.IsNullOrEmpty(result.SearchInAppearances))
                    {
                        meshNode.MeshAppearance = StringHelper.ReplaceInString(meshNode.MeshAppearance!,
                            result.SearchInAppearances, replaceString,
                            false,
                            false);
                    }

                    sector.Nodes.Add(newNode);
                    newData.NodeIndex = (CUInt16)(sector.Nodes.Count - 1);
                }

                nodeData.Add(newData);
            }

            if (nodeData.Count - 1 == startIndex)
            {
                throw new WolvenKitException(0, "Failed to add sector variant");
            }

            sector.VariantIndices.Add(endIndex);
            return sector.VariantIndices.Count;
        }

        void AddVariantInStreamingBlock(int rangeIndex, string sectorName,
            worldStreamingSectorDescriptor matchingDescriptor, worldStreamingSectorVariant matchingVariant)
        {
            var newVariant = new worldStreamingSectorVariant()
            {
                Name = sectorName,
                EnabledByDefault = matchingVariant.EnabledByDefault,
                NodeRef = matchingVariant.NodeRef,
                ParentVariantID = matchingVariant.ParentVariantID,
                RangeIndex = (uint)rangeIndex,
                VariantId = 0
            };
            matchingDescriptor.Variants.Add(newVariant);
        }
    }
}
