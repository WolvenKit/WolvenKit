using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entMeshComponent : entIVisualComponent
	{
		private CResourceAsyncReference<CMesh> _mesh;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CFloat _motionBlurScale;
		private Vector3 _visualScale;
		private CEnum<ERenderingPlane> _renderingPlane;
		private CEnum<ERenderObjectType> _objectTypeID;
		private CUInt32 _numInstances;
		private CUInt64 _chunkMask;
		private CUInt8 _order;
		private CBool _isEnabled;
		private CEnum<entMeshComponentLODMode> _lODMode;
		private CEnum<entForcedLodDistance> _forcedLodDistance;
		private CBool _overrideMeshNavigationImpact;
		private NavGenNavigationSetting _navigationImpact;

		[Ordinal(8)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(9)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(10)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(11)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(12)] 
		[RED("motionBlurScale")] 
		public CFloat MotionBlurScale
		{
			get => GetProperty(ref _motionBlurScale);
			set => SetProperty(ref _motionBlurScale, value);
		}

		[Ordinal(13)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get => GetProperty(ref _visualScale);
			set => SetProperty(ref _visualScale, value);
		}

		[Ordinal(14)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get => GetProperty(ref _renderingPlane);
			set => SetProperty(ref _renderingPlane, value);
		}

		[Ordinal(15)] 
		[RED("objectTypeID")] 
		public CEnum<ERenderObjectType> ObjectTypeID
		{
			get => GetProperty(ref _objectTypeID);
			set => SetProperty(ref _objectTypeID, value);
		}

		[Ordinal(16)] 
		[RED("numInstances")] 
		public CUInt32 NumInstances
		{
			get => GetProperty(ref _numInstances);
			set => SetProperty(ref _numInstances, value);
		}

		[Ordinal(17)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetProperty(ref _chunkMask);
			set => SetProperty(ref _chunkMask, value);
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
		[RED("forcedLodDistance")] 
		public CEnum<entForcedLodDistance> ForcedLodDistance
		{
			get => GetProperty(ref _forcedLodDistance);
			set => SetProperty(ref _forcedLodDistance, value);
		}

		[Ordinal(22)] 
		[RED("overrideMeshNavigationImpact")] 
		public CBool OverrideMeshNavigationImpact
		{
			get => GetProperty(ref _overrideMeshNavigationImpact);
			set => SetProperty(ref _overrideMeshNavigationImpact, value);
		}

		[Ordinal(23)] 
		[RED("navigationImpact")] 
		public NavGenNavigationSetting NavigationImpact
		{
			get => GetProperty(ref _navigationImpact);
			set => SetProperty(ref _navigationImpact, value);
		}
	}
}
