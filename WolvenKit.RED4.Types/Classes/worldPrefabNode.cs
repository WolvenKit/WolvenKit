using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPrefabNode : worldNode
	{
		private CResourceAsyncReference<worldPrefab> _prefab;
		private CHandle<worldPrefabInstanceData> _instanceData;
		private CHandle<worldPrefabVariantsList> _enabledVariants;
		private CBool _canBeToggledInGame;
		private CBool _noCollision;
		private CBool _enableRenderSceneLayerOverride;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;
		private CBool _ignoreMeshEmbeddedOccluders;
		private CBool _ignoreAllOccluders;
		private CUInt8 _occluderAutoHideDistanceScale;
		private CEnum<worldPrefabProxyMeshOnly> _proxyMeshOnly;
		private CBool _proxyScaleOverride;
		private Vector3 _proxyScale;

		[Ordinal(4)] 
		[RED("prefab")] 
		public CResourceAsyncReference<worldPrefab> Prefab
		{
			get => GetProperty(ref _prefab);
			set => SetProperty(ref _prefab, value);
		}

		[Ordinal(5)] 
		[RED("instanceData")] 
		public CHandle<worldPrefabInstanceData> InstanceData
		{
			get => GetProperty(ref _instanceData);
			set => SetProperty(ref _instanceData, value);
		}

		[Ordinal(6)] 
		[RED("enabledVariants")] 
		public CHandle<worldPrefabVariantsList> EnabledVariants
		{
			get => GetProperty(ref _enabledVariants);
			set => SetProperty(ref _enabledVariants, value);
		}

		[Ordinal(7)] 
		[RED("canBeToggledInGame")] 
		public CBool CanBeToggledInGame
		{
			get => GetProperty(ref _canBeToggledInGame);
			set => SetProperty(ref _canBeToggledInGame, value);
		}

		[Ordinal(8)] 
		[RED("noCollision")] 
		public CBool NoCollision
		{
			get => GetProperty(ref _noCollision);
			set => SetProperty(ref _noCollision, value);
		}

		[Ordinal(9)] 
		[RED("enableRenderSceneLayerOverride")] 
		public CBool EnableRenderSceneLayerOverride
		{
			get => GetProperty(ref _enableRenderSceneLayerOverride);
			set => SetProperty(ref _enableRenderSceneLayerOverride, value);
		}

		[Ordinal(10)] 
		[RED("renderSceneLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetProperty(ref _renderSceneLayerMask);
			set => SetProperty(ref _renderSceneLayerMask, value);
		}

		[Ordinal(11)] 
		[RED("ignoreMeshEmbeddedOccluders")] 
		public CBool IgnoreMeshEmbeddedOccluders
		{
			get => GetProperty(ref _ignoreMeshEmbeddedOccluders);
			set => SetProperty(ref _ignoreMeshEmbeddedOccluders, value);
		}

		[Ordinal(12)] 
		[RED("ignoreAllOccluders")] 
		public CBool IgnoreAllOccluders
		{
			get => GetProperty(ref _ignoreAllOccluders);
			set => SetProperty(ref _ignoreAllOccluders, value);
		}

		[Ordinal(13)] 
		[RED("occluderAutoHideDistanceScale")] 
		public CUInt8 OccluderAutoHideDistanceScale
		{
			get => GetProperty(ref _occluderAutoHideDistanceScale);
			set => SetProperty(ref _occluderAutoHideDistanceScale, value);
		}

		[Ordinal(14)] 
		[RED("proxyMeshOnly")] 
		public CEnum<worldPrefabProxyMeshOnly> ProxyMeshOnly
		{
			get => GetProperty(ref _proxyMeshOnly);
			set => SetProperty(ref _proxyMeshOnly, value);
		}

		[Ordinal(15)] 
		[RED("proxyScaleOverride")] 
		public CBool ProxyScaleOverride
		{
			get => GetProperty(ref _proxyScaleOverride);
			set => SetProperty(ref _proxyScaleOverride, value);
		}

		[Ordinal(16)] 
		[RED("proxyScale")] 
		public Vector3 ProxyScale
		{
			get => GetProperty(ref _proxyScale);
			set => SetProperty(ref _proxyScale, value);
		}

		public worldPrefabNode()
		{
			_renderSceneLayerMask = new() { Value = Enums.RenderSceneLayerMask.Default };
			_occluderAutoHideDistanceScale = 255;
		}
	}
}
