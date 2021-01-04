using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPrefab : resStreamedResource
	{
		[Ordinal(0)]  [RED("booleanProxyHelper")] public raRef<worldPrefab> BooleanProxyHelper { get; set; }
		[Ordinal(1)]  [RED("boostInnerNodesToProxyDistance")] public CBool BoostInnerNodesToProxyDistance { get; set; }
		[Ordinal(2)]  [RED("customProxyMeshHelper")] public raRef<CMesh> CustomProxyMeshHelper { get; set; }
		[Ordinal(3)]  [RED("defaultVariants")] public CHandle<worldPrefabVariantsList> DefaultVariants { get; set; }
		[Ordinal(4)]  [RED("environmentDefinition")] public raRef<worldEnvironmentDefinition> EnvironmentDefinition { get; set; }
		[Ordinal(5)]  [RED("excludeOnConsole")] public CBool ExcludeOnConsole { get; set; }
		[Ordinal(6)]  [RED("foliageBrushToTerrainLayerMapping")] public raRef<worldAutoFoliageMapping> FoliageBrushToTerrainLayerMapping { get; set; }
		[Ordinal(7)]  [RED("ignoreAllOccluders")] public CBool IgnoreAllOccluders { get; set; }
		[Ordinal(8)]  [RED("ignoreMeshEmbeddedOccluders")] public CBool IgnoreMeshEmbeddedOccluders { get; set; }
		[Ordinal(9)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(10)]  [RED("isMerged")] public CBool IsMerged { get; set; }
		[Ordinal(11)]  [RED("isProxyMeshOnly")] public CBool IsProxyMeshOnly { get; set; }
		[Ordinal(12)]  [RED("isTerrainPrefab")] public CBool IsTerrainPrefab { get; set; }
		[Ordinal(13)]  [RED("mainGroup")] public CHandle<worldNodesGroup> MainGroup { get; set; }
		[Ordinal(14)]  [RED("maxBounds")] public Box MaxBounds { get; set; }
		[Ordinal(15)]  [RED("metadataArray")] public CArray<CHandle<worldPrefabMetadata>> MetadataArray { get; set; }
		[Ordinal(16)]  [RED("minimapContribution")] public CEnum<worldPrefabMinimapContribution> MinimapContribution { get; set; }
		[Ordinal(17)]  [RED("prefabUniqueId")] public CRUID PrefabUniqueId { get; set; }
		[Ordinal(18)]  [RED("proxyDistanceFactor")] public CFloat ProxyDistanceFactor { get; set; }
		[Ordinal(19)]  [RED("proxyLimiterHelper")] public raRef<worldPrefab> ProxyLimiterHelper { get; set; }
		[Ordinal(20)]  [RED("proxyMesh")] public raRef<CMesh> ProxyMesh { get; set; }
		[Ordinal(21)]  [RED("proxyMeshBuildParams")] public worldProxyMeshBuildParams ProxyMeshBuildParams { get; set; }
		[Ordinal(22)]  [RED("proxyScale")] public Vector3 ProxyScale { get; set; }
		[Ordinal(23)]  [RED("streamingOcclusion")] public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusion { get; set; }
		[Ordinal(24)]  [RED("teamOwnership")] public CEnum<worldPrefabOwnership> TeamOwnership { get; set; }
		[Ordinal(25)]  [RED("terrainMultilayerSetup")] public raRef<Multilayer_Setup> TerrainMultilayerSetup { get; set; }
		[Ordinal(26)]  [RED("type")] public CEnum<worldPrefabType> Type { get; set; }

		public worldPrefab(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
