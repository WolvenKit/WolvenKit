using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalDestructionComponent : entIVisualComponent
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CFloat _forceAutoHideDistance;
		private physicsDestructionParams _destructionParams;
		private CArray<physicsDestructionLevelData> _destructionLevelData;
		private CBool _isEnabled;
		private CName _audioMetadata;

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
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get
			{
				if (_forceAutoHideDistance == null)
				{
					_forceAutoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "forceAutoHideDistance", cr2w, this);
				}
				return _forceAutoHideDistance;
			}
			set
			{
				if (_forceAutoHideDistance == value)
				{
					return;
				}
				_forceAutoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get
			{
				if (_destructionParams == null)
				{
					_destructionParams = (physicsDestructionParams) CR2WTypeManager.Create("physicsDestructionParams", "destructionParams", cr2w, this);
				}
				return _destructionParams;
			}
			set
			{
				if (_destructionParams == value)
				{
					return;
				}
				_destructionParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get
			{
				if (_destructionLevelData == null)
				{
					_destructionLevelData = (CArray<physicsDestructionLevelData>) CR2WTypeManager.Create("array:physicsDestructionLevelData", "destructionLevelData", cr2w, this);
				}
				return _destructionLevelData;
			}
			set
			{
				if (_destructionLevelData == value)
				{
					return;
				}
				_destructionLevelData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get
			{
				if (_audioMetadata == null)
				{
					_audioMetadata = (CName) CR2WTypeManager.Create("CName", "audioMetadata", cr2w, this);
				}
				return _audioMetadata;
			}
			set
			{
				if (_audioMetadata == value)
				{
					return;
				}
				_audioMetadata = value;
				PropertySet(this);
			}
		}

		public entPhysicalDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
