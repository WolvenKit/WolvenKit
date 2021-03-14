using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSkinnedMeshComponent : entISkinTargetComponent
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CBool _acceptDismemberment;
		private CUInt64 _chunkMask;
		private CName _renderingPlaneAnimationParam;
		private CName _visibilityAnimationParam;
		private CBool _isEnabled;
		private CEnum<entMeshComponentLODMode> _lODMode;
		private CBool _useProxyMeshAsShadowMesh;

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get
			{
				if (_acceptDismemberment == null)
				{
					_acceptDismemberment = (CBool) CR2WTypeManager.Create("Bool", "acceptDismemberment", cr2w, this);
				}
				return _acceptDismemberment;
			}
			set
			{
				if (_acceptDismemberment == value)
				{
					return;
				}
				_acceptDismemberment = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("renderingPlaneAnimationParam")] 
		public CName RenderingPlaneAnimationParam
		{
			get
			{
				if (_renderingPlaneAnimationParam == null)
				{
					_renderingPlaneAnimationParam = (CName) CR2WTypeManager.Create("CName", "renderingPlaneAnimationParam", cr2w, this);
				}
				return _renderingPlaneAnimationParam;
			}
			set
			{
				if (_renderingPlaneAnimationParam == value)
				{
					return;
				}
				_renderingPlaneAnimationParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get
			{
				if (_visibilityAnimationParam == null)
				{
					_visibilityAnimationParam = (CName) CR2WTypeManager.Create("CName", "visibilityAnimationParam", cr2w, this);
				}
				return _visibilityAnimationParam;
			}
			set
			{
				if (_visibilityAnimationParam == value)
				{
					return;
				}
				_visibilityAnimationParam = value;
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
		[RED("useProxyMeshAsShadowMesh")] 
		public CBool UseProxyMeshAsShadowMesh
		{
			get
			{
				if (_useProxyMeshAsShadowMesh == null)
				{
					_useProxyMeshAsShadowMesh = (CBool) CR2WTypeManager.Create("Bool", "useProxyMeshAsShadowMesh", cr2w, this);
				}
				return _useProxyMeshAsShadowMesh;
			}
			set
			{
				if (_useProxyMeshAsShadowMesh == value)
				{
					return;
				}
				_useProxyMeshAsShadowMesh = value;
				PropertySet(this);
			}
		}

		public entSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
