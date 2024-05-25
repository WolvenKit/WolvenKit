using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers.StringHelpers;

internal static class StringHelperWorldNode
{
    public static string Stringify(worldNode? worldNode, bool stringifyValue = false)
    {
        if (worldNode is null)
        {
            return "";
        }

        if (stringifyValue)
        {
            return StringifyValue(worldNode);
        }

        if (worldNode.DebugName != CName.Empty)
        {
            return worldNode.DebugName.GetResolvedText() ?? "";
        }

        return "";
    }

    private static string PrintEntNode(worldEntityNode entNode, bool asValue = false) =>
        StringHelper.StringifyOrNull(entNode.EntityTemplate.DepotPath, asValue) ?? "";

    private static string PrintMesh(CResourceAsyncReference<CMesh> mesh, CName? meshAppearance) =>
        StringHelper.StringifyMeshAppearance(mesh, meshAppearance);


    private static string StringifyValue(worldNode? worldNode) => worldNode switch
    {
        worldMeshNode node => $"{PrintMesh(node.Mesh, node.MeshAppearance)}",
        worldBendedMeshNode node => $"{PrintMesh(node.Mesh, node.MeshAppearance)}",
        worldTerrainMeshNode node => $"{PrintMesh(node.MeshRef, null)}",
        worldStaticOccluderMeshNode node => $"${node.OccluderType.ToEnumString()} {node.Mesh.DepotPath.GetResolvedText()}",
        worldStaticParticleNode node => $"${node.ParticleSystem.DepotPath.GetResolvedText()}",
        worldStaticLightNode node => $"{StringHelper.Stringify(node.Color)}",
        worldStaticQuestMarkerNode node => $"{node.QuestType.ToEnumString()}",
        worldStaticSoundEmitterNode node => $"{node.AudioName.GetResolvedText()}",
        worldStaticDecalNode node => $"{node.Material.DepotPath.GetResolvedText()}",
        worldStaticStickerNode node => $"{StringHelper.Stringify(node.Labels.Select((l) => (string)l).ToArray())}",
        worldAIDirectorSpawnAreaNode spawnAreaNode => $"{spawnAreaNode.GroupKey}",
        worldAIDirectorSpawnNode directorSpawnNode => $"{StringHelper.Stringify(directorSpawnNode.Tags)}",
        worldAudioTagNode worldAudioTagNode => $"{worldAudioTagNode.AudioTag}",
        worldFoliageNode worldFoliageNode => $"{PrintMesh(worldFoliageNode.Mesh, worldFoliageNode.MeshAppearance)}",
        worldDeviceNode node => $"{PrintEntNode(node)} [{node.DeviceConnections.Count}]",
        worldEntityNode node => $"{PrintEntNode(node)}",
        worldEffectNode worldEffectNode => $"[{worldEffectNode.Effect.DepotPath.GetResolvedText()}]",
        worldDistantGINode worldDistantGiNode => $"[{worldDistantGiNode.DataAlbedo.DepotPath.GetResolvedText()}]",

        _ => ""
    };
}