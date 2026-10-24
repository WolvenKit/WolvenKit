using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPrefab : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("mainGroup")] 
		public CHandle<worldNodesGroup> MainGroup
		{
			get => GetPropertyValue<CHandle<worldNodesGroup>>();
			set => SetPropertyValue<CHandle<worldNodesGroup>>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<worldPrefabType> Type
		{
			get => GetPropertyValue<CEnum<worldPrefabType>>();
			set => SetPropertyValue<CEnum<worldPrefabType>>(value);
		}

		[Ordinal(3)] 
		[RED("teamOwnership")] 
		public CEnum<worldPrefabOwnership> TeamOwnership
		{
			get => GetPropertyValue<CEnum<worldPrefabOwnership>>();
			set => SetPropertyValue<CEnum<worldPrefabOwnership>>(value);
		}

		[Ordinal(4)] 
		[RED("streamingOcclusion")] 
		public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusion
		{
			get => GetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>();
			set => SetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>(value);
		}

		[Ordinal(5)] 
		[RED("streamingImportance")] 
		public CEnum<worldPrefabStreamingImportance> StreamingImportance
		{
			get => GetPropertyValue<CEnum<worldPrefabStreamingImportance>>();
			set => SetPropertyValue<CEnum<worldPrefabStreamingImportance>>(value);
		}

		[Ordinal(6)] 
		[RED("defaultVariants")] 
		public CHandle<worldPrefabVariantsList> DefaultVariants
		{
			get => GetPropertyValue<CHandle<worldPrefabVariantsList>>();
			set => SetPropertyValue<CHandle<worldPrefabVariantsList>>(value);
		}

		[Ordinal(7)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("maxBounds")] 
		public Box MaxBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(9)] 
		[RED("environmentDefinition")] 
		public CResourceAsyncReference<worldEnvironmentDefinition> EnvironmentDefinition
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEnvironmentDefinition>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEnvironmentDefinition>>(value);
		}

		[Ordinal(10)] 
		[RED("terrainMultilayerSetup")] 
		public CResourceAsyncReference<Multilayer_Setup> TerrainMultilayerSetup
		{
			get => GetPropertyValue<CResourceAsyncReference<Multilayer_Setup>>();
			set => SetPropertyValue<CResourceAsyncReference<Multilayer_Setup>>(value);
		}

		[Ordinal(11)] 
		[RED("foliageBrushToTerrainLayerMapping")] 
		public CResourceAsyncReference<worldAutoFoliageMapping> FoliageBrushToTerrainLayerMapping
		{
			get => GetPropertyValue<CResourceAsyncReference<worldAutoFoliageMapping>>();
			set => SetPropertyValue<CResourceAsyncReference<worldAutoFoliageMapping>>(value);
		}

		[Ordinal(12)] 
		[RED("prefabUniqueId")] 
		public CRUID PrefabUniqueId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(13)] 
		[RED("metadataArray")] 
		public CArray<CHandle<worldPrefabMetadata>> MetadataArray
		{
			get => GetPropertyValue<CArray<CHandle<worldPrefabMetadata>>>();
			set => SetPropertyValue<CArray<CHandle<worldPrefabMetadata>>>(value);
		}

		[Ordinal(14)] 
		[RED("isMerged")] 
		public CBool IsMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("proxyMeshBuildParams")] 
		public worldProxyMeshBuildParams ProxyMeshBuildParams
		{
			get => GetPropertyValue<worldProxyMeshBuildParams>();
			set => SetPropertyValue<worldProxyMeshBuildParams>(value);
		}

		[Ordinal(16)] 
		[RED("isProxyMeshOnly")] 
		public CBool IsProxyMeshOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("proxyMesh")] 
		public CResourceAsyncReference<CMesh> ProxyMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(18)] 
		[RED("proxyScale")] 
		public Vector3 ProxyScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(19)] 
		[RED("maxProxyStreamingDistance")] 
		public CFloat MaxProxyStreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("proxyDistanceFactor")] 
		public CFloat ProxyDistanceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("averageNodeDiagonal")] 
		public CFloat AverageNodeDiagonal
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("boostInnerNodesToProxyDistance")] 
		public CBool BoostInnerNodesToProxyDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("overrideStreamingPosWithBBoxCenter")] 
		public CBool OverrideStreamingPosWithBBoxCenter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("ignoreMeshEmbeddedOccluders")] 
		public CBool IgnoreMeshEmbeddedOccluders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("ignoreAllOccluders")] 
		public CBool IgnoreAllOccluders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("excludeOnConsole")] 
		public CBool ExcludeOnConsole
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("excludeOnNextGenConsoles")] 
		public CBool ExcludeOnNextGenConsoles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("isTerrainPrefab")] 
		public CBool IsTerrainPrefab
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("minimapContribution")] 
		public CEnum<worldPrefabMinimapContribution> MinimapContribution
		{
			get => GetPropertyValue<CEnum<worldPrefabMinimapContribution>>();
			set => SetPropertyValue<CEnum<worldPrefabMinimapContribution>>(value);
		}

		[Ordinal(30)] 
		[RED("interiorMapContribution")] 
		public CEnum<worldPrefabInteriorMapContribution> InteriorMapContribution
		{
			get => GetPropertyValue<CEnum<worldPrefabInteriorMapContribution>>();
			set => SetPropertyValue<CEnum<worldPrefabInteriorMapContribution>>(value);
		}

		[Ordinal(31)] 
		[RED("booleanProxyHelper")] 
		public CResourceAsyncReference<worldPrefab> BooleanProxyHelper
		{
			get => GetPropertyValue<CResourceAsyncReference<worldPrefab>>();
			set => SetPropertyValue<CResourceAsyncReference<worldPrefab>>(value);
		}

		[Ordinal(32)] 
		[RED("proxyLimiterHelper")] 
		public CResourceAsyncReference<worldPrefab> ProxyLimiterHelper
		{
			get => GetPropertyValue<CResourceAsyncReference<worldPrefab>>();
			set => SetPropertyValue<CResourceAsyncReference<worldPrefab>>(value);
		}

		[Ordinal(33)] 
		[RED("customProxyMeshHelper")] 
		public CResourceAsyncReference<CMesh> CustomProxyMeshHelper
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		public worldPrefab()
		{
			MainGroup = new worldNodesGroup { Id = 1 };
			DefaultVariants = new worldPrefabVariantsList();
			MaxBounds = new Box { Min = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue }, Max = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue } };
			EnvironmentDefinition = new CResourceAsyncReference<worldEnvironmentDefinition>(@"engine\preview_panel\preview_panel_env_base.env");
			MetadataArray = new();
			ProxyMeshBuildParams = new worldProxyMeshBuildParams();
			ProxyScale = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			ProxyDistanceFactor = 1.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
