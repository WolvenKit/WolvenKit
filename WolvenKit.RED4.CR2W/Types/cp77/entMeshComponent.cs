using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMeshComponent : entIVisualComponent
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CFloat _motionBlurScale;
		private Vector3 _visualScale;
		private CEnum<ERenderingPlane> _renderingPlane;
		private CEnum<ERenderObjectType> _objectTypeID;
		private CUInt32 _numInstances;
		private CUInt64 _chunkMask;
		private CBool _isEnabled;
		private CEnum<entMeshComponentLODMode> _lODMode;
		private CBool _overrideMeshNavigationImpact;
		private NavGenNavigationSetting _navigationImpact;

		[Ordinal(8)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
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
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(19)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get => GetProperty(ref _lODMode);
			set => SetProperty(ref _lODMode, value);
		}

		[Ordinal(20)] 
		[RED("overrideMeshNavigationImpact")] 
		public CBool OverrideMeshNavigationImpact
		{
			get => GetProperty(ref _overrideMeshNavigationImpact);
			set => SetProperty(ref _overrideMeshNavigationImpact, value);
		}

		[Ordinal(21)] 
		[RED("navigationImpact")] 
		public NavGenNavigationSetting NavigationImpact
		{
			get => GetProperty(ref _navigationImpact);
			set => SetProperty(ref _navigationImpact, value);
		}

		public entMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
