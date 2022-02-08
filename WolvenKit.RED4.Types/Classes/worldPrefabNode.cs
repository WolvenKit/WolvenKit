using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("ignoreMeshEmbeddedOccluders")] 
		public CBool IgnoreMeshEmbeddedOccluders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("ignoreAllOccluders")] 
		public CBool IgnoreAllOccluders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("occluderAutoHideDistanceScale")] 
		public CUInt8 OccluderAutoHideDistanceScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(14)] 
		[RED("proxyMeshOnly")] 
		public CEnum<worldPrefabProxyMeshOnly> ProxyMeshOnly
		{
			get => GetPropertyValue<CEnum<worldPrefabProxyMeshOnly>>();
			set => SetPropertyValue<CEnum<worldPrefabProxyMeshOnly>>(value);
		}

		[Ordinal(15)] 
		[RED("proxyScaleOverride")] 
		public CBool ProxyScaleOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
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
		}
	}
}
