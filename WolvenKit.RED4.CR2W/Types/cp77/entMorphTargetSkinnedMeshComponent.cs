using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetSkinnedMeshComponent : entISkinTargetComponent
	{
		private raRef<MorphTargetMesh> _morphResource;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _hACK_isMaterialPriorityBumped;
		private CBool _castLocalShadows;
		private CBool _acceptDismemberment;
		private CUInt64 _chunkMask;
		private CName _renderingPlaneAnimationParam;
		private CName _visibilityAnimationParam;
		private CBool _isEnabled;
		private redTagList _tags;

		[Ordinal(10)] 
		[RED("morphResource")] 
		public raRef<MorphTargetMesh> MorphResource
		{
			get
			{
				if (_morphResource == null)
				{
					_morphResource = (raRef<MorphTargetMesh>) CR2WTypeManager.Create("raRef:MorphTargetMesh", "morphResource", cr2w, this);
				}
				return _morphResource;
			}
			set
			{
				if (_morphResource == value)
				{
					return;
				}
				_morphResource = value;
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
		[RED("HACK_isMaterialPriorityBumped")] 
		public CBool HACK_isMaterialPriorityBumped
		{
			get
			{
				if (_hACK_isMaterialPriorityBumped == null)
				{
					_hACK_isMaterialPriorityBumped = (CBool) CR2WTypeManager.Create("Bool", "HACK_isMaterialPriorityBumped", cr2w, this);
				}
				return _hACK_isMaterialPriorityBumped;
			}
			set
			{
				if (_hACK_isMaterialPriorityBumped == value)
				{
					return;
				}
				_hACK_isMaterialPriorityBumped = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public entMorphTargetSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
