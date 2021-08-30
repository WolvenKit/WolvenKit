using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSkinnedMeshComponent : entISkinTargetComponent
	{
		private CResourceAsyncReference<CMesh> _mesh;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CBool _acceptDismemberment;
		private CUInt64 _chunkMask;
		private CName _renderingPlaneAnimationParam;
		private CName _visibilityAnimationParam;
		private CUInt8 _order;
		private CBool _isEnabled;
		private CEnum<entMeshComponentLODMode> _lODMode;
		private CBool _useProxyMeshAsShadowMesh;
		private CEnum<entForcedLodDistance> _forcedLodDistance;
		private CBool _overrideMeshNavigationImpact;
		private NavGenNavigationSetting _navigationImpact;

		[Ordinal(10)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(11)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(12)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(13)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(14)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetProperty(ref _acceptDismemberment);
			set => SetProperty(ref _acceptDismemberment, value);
		}

		[Ordinal(15)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetProperty(ref _chunkMask);
			set => SetProperty(ref _chunkMask, value);
		}

		[Ordinal(16)] 
		[RED("renderingPlaneAnimationParam")] 
		public CName RenderingPlaneAnimationParam
		{
			get => GetProperty(ref _renderingPlaneAnimationParam);
			set => SetProperty(ref _renderingPlaneAnimationParam, value);
		}

		[Ordinal(17)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetProperty(ref _visibilityAnimationParam);
			set => SetProperty(ref _visibilityAnimationParam, value);
		}

		[Ordinal(18)] 
		[RED("order")] 
		public CUInt8 Order
		{
			get => GetProperty(ref _order);
			set => SetProperty(ref _order, value);
		}

		[Ordinal(19)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(20)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get => GetProperty(ref _lODMode);
			set => SetProperty(ref _lODMode, value);
		}

		[Ordinal(21)] 
		[RED("useProxyMeshAsShadowMesh")] 
		public CBool UseProxyMeshAsShadowMesh
		{
			get => GetProperty(ref _useProxyMeshAsShadowMesh);
			set => SetProperty(ref _useProxyMeshAsShadowMesh, value);
		}

		[Ordinal(22)] 
		[RED("forcedLodDistance")] 
		public CEnum<entForcedLodDistance> ForcedLodDistance
		{
			get => GetProperty(ref _forcedLodDistance);
			set => SetProperty(ref _forcedLodDistance, value);
		}

		[Ordinal(23)] 
		[RED("overrideMeshNavigationImpact")] 
		public CBool OverrideMeshNavigationImpact
		{
			get => GetProperty(ref _overrideMeshNavigationImpact);
			set => SetProperty(ref _overrideMeshNavigationImpact, value);
		}

		[Ordinal(24)] 
		[RED("navigationImpact")] 
		public NavGenNavigationSetting NavigationImpact
		{
			get => GetProperty(ref _navigationImpact);
			set => SetProperty(ref _navigationImpact, value);
		}

		public entSkinnedMeshComponent()
		{
			_meshAppearance = "default";
			_castShadows = true;
			_castLocalShadows = true;
			_acceptDismemberment = true;
			_chunkMask = 18446744073709551615;
			_isEnabled = true;
			_overrideMeshNavigationImpact = true;
		}
	}
}
