using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPrefabNode : worldNode
	{
		[Ordinal(4)] 
		[RED("prefab")] 
		public CResourceAsyncReference<worldPrefab> Prefab
		{
			get => GetPropertyValue<CResourceAsyncReference<worldPrefab>>();
			set => SetPropertyValue<CResourceAsyncReference<worldPrefab>>(value);
		}

		[Ordinal(5)] 
		[RED("instanceData")] 
		public CHandle<worldPrefabInstanceData> InstanceData
		{
			get => GetPropertyValue<CHandle<worldPrefabInstanceData>>();
			set => SetPropertyValue<CHandle<worldPrefabInstanceData>>(value);
		}

		[Ordinal(6)] 
		[RED("enabledVariants")] 
		public CHandle<worldPrefabVariantsList> EnabledVariants
		{
			get => GetPropertyValue<CHandle<worldPrefabVariantsList>>();
			set => SetPropertyValue<CHandle<worldPrefabVariantsList>>(value);
		}

		[Ordinal(7)] 
		[RED("canBeToggledInGame")] 
		public CBool CanBeToggledInGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("noCollision")] 
		public CBool NoCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("enableRenderSceneLayerOverride")] 
		public CBool EnableRenderSceneLayerOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("renderSceneLayerMask")] 
		public CBitField<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
			set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
		}

		[Ordinal(11)] 
		[RED("applyMaxStreamingDistance")] 
		public CBool ApplyMaxStreamingDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("streamingImportance")] 
		public CEnum<worldPrefabStreamingImportance> StreamingImportance
		{
			get => GetPropertyValue<CEnum<worldPrefabStreamingImportance>>();
			set => SetPropertyValue<CEnum<worldPrefabStreamingImportance>>(value);
		}

		[Ordinal(13)] 
		[RED("streamingOcclusionOverride")] 
		public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusionOverride
		{
			get => GetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>();
			set => SetPropertyValue<CEnum<worldPrefabStreamingOcclusion>>(value);
		}

		[Ordinal(14)] 
		[RED("interiorMapContribution")] 
		public CEnum<worldPrefabInteriorMapContribution> InteriorMapContribution
		{
			get => GetPropertyValue<CEnum<worldPrefabInteriorMapContribution>>();
			set => SetPropertyValue<CEnum<worldPrefabInteriorMapContribution>>(value);
		}

		[Ordinal(15)] 
		[RED("ignoreMeshEmbeddedOccluders")] 
		public CBool IgnoreMeshEmbeddedOccluders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("ignoreAllOccluders")] 
		public CBool IgnoreAllOccluders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("occluderAutoHideDistanceScale")] 
		public CUInt8 OccluderAutoHideDistanceScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(18)] 
		[RED("proxyMeshOnly")] 
		public CEnum<worldPrefabProxyMeshOnly> ProxyMeshOnly
		{
			get => GetPropertyValue<CEnum<worldPrefabProxyMeshOnly>>();
			set => SetPropertyValue<CEnum<worldPrefabProxyMeshOnly>>(value);
		}

		[Ordinal(19)] 
		[RED("proxyScaleOverride")] 
		public CBool ProxyScaleOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("proxyScale")] 
		public Vector3 ProxyScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public worldPrefabNode()
		{
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			OccluderAutoHideDistanceScale = 255;
			ProxyScale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
