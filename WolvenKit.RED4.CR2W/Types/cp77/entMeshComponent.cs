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
			get
			{
				if (_mesh == null)
				{
					_mesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get
			{
				if (_meshAppearance == null)
				{
					_meshAppearance = (CName) CR2WTypeManager.Create("CName", "meshAppearance", cr2w, this);
				}
				return _meshAppearance;
			}
			set
			{
				if (_meshAppearance == value)
				{
					return;
				}
				_meshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get
			{
				if (_castShadows == null)
				{
					_castShadows = (CBool) CR2WTypeManager.Create("Bool", "castShadows", cr2w, this);
				}
				return _castShadows;
			}
			set
			{
				if (_castShadows == value)
				{
					return;
				}
				_castShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get
			{
				if (_castLocalShadows == null)
				{
					_castLocalShadows = (CBool) CR2WTypeManager.Create("Bool", "castLocalShadows", cr2w, this);
				}
				return _castLocalShadows;
			}
			set
			{
				if (_castLocalShadows == value)
				{
					return;
				}
				_castLocalShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("motionBlurScale")] 
		public CFloat MotionBlurScale
		{
			get
			{
				if (_motionBlurScale == null)
				{
					_motionBlurScale = (CFloat) CR2WTypeManager.Create("Float", "motionBlurScale", cr2w, this);
				}
				return _motionBlurScale;
			}
			set
			{
				if (_motionBlurScale == value)
				{
					return;
				}
				_motionBlurScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get
			{
				if (_visualScale == null)
				{
					_visualScale = (Vector3) CR2WTypeManager.Create("Vector3", "visualScale", cr2w, this);
				}
				return _visualScale;
			}
			set
			{
				if (_visualScale == value)
				{
					return;
				}
				_visualScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get
			{
				if (_renderingPlane == null)
				{
					_renderingPlane = (CEnum<ERenderingPlane>) CR2WTypeManager.Create("ERenderingPlane", "renderingPlane", cr2w, this);
				}
				return _renderingPlane;
			}
			set
			{
				if (_renderingPlane == value)
				{
					return;
				}
				_renderingPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("objectTypeID")] 
		public CEnum<ERenderObjectType> ObjectTypeID
		{
			get
			{
				if (_objectTypeID == null)
				{
					_objectTypeID = (CEnum<ERenderObjectType>) CR2WTypeManager.Create("ERenderObjectType", "objectTypeID", cr2w, this);
				}
				return _objectTypeID;
			}
			set
			{
				if (_objectTypeID == value)
				{
					return;
				}
				_objectTypeID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("numInstances")] 
		public CUInt32 NumInstances
		{
			get
			{
				if (_numInstances == null)
				{
					_numInstances = (CUInt32) CR2WTypeManager.Create("Uint32", "numInstances", cr2w, this);
				}
				return _numInstances;
			}
			set
			{
				if (_numInstances == value)
				{
					return;
				}
				_numInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get
			{
				if (_chunkMask == null)
				{
					_chunkMask = (CUInt64) CR2WTypeManager.Create("Uint64", "chunkMask", cr2w, this);
				}
				return _chunkMask;
			}
			set
			{
				if (_chunkMask == value)
				{
					return;
				}
				_chunkMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get
			{
				if (_lODMode == null)
				{
					_lODMode = (CEnum<entMeshComponentLODMode>) CR2WTypeManager.Create("entMeshComponentLODMode", "LODMode", cr2w, this);
				}
				return _lODMode;
			}
			set
			{
				if (_lODMode == value)
				{
					return;
				}
				_lODMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("overrideMeshNavigationImpact")] 
		public CBool OverrideMeshNavigationImpact
		{
			get
			{
				if (_overrideMeshNavigationImpact == null)
				{
					_overrideMeshNavigationImpact = (CBool) CR2WTypeManager.Create("Bool", "overrideMeshNavigationImpact", cr2w, this);
				}
				return _overrideMeshNavigationImpact;
			}
			set
			{
				if (_overrideMeshNavigationImpact == value)
				{
					return;
				}
				_overrideMeshNavigationImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("navigationImpact")] 
		public NavGenNavigationSetting NavigationImpact
		{
			get
			{
				if (_navigationImpact == null)
				{
					_navigationImpact = (NavGenNavigationSetting) CR2WTypeManager.Create("NavGenNavigationSetting", "navigationImpact", cr2w, this);
				}
				return _navigationImpact;
			}
			set
			{
				if (_navigationImpact == value)
				{
					return;
				}
				_navigationImpact = value;
				PropertySet(this);
			}
		}

		public entMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
