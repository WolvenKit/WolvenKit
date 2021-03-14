using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalDestructionNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CInt32 _forceLODLevel;
		private CFloat _forceAutoHideDistance;
		private physicsDestructionParams _destructionParams;
		private CArray<physicsDestructionLevelData> _destructionLevelData;
		private CName _audioMetadata;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("forceLODLevel")] 
		public CInt32 ForceLODLevel
		{
			get
			{
				if (_forceLODLevel == null)
				{
					_forceLODLevel = (CInt32) CR2WTypeManager.Create("Int32", "forceLODLevel", cr2w, this);
				}
				return _forceLODLevel;
			}
			set
			{
				if (_forceLODLevel == value)
				{
					return;
				}
				_forceLODLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get
			{
				if (_navigationSetting == null)
				{
					_navigationSetting = (NavGenNavigationSetting) CR2WTypeManager.Create("NavGenNavigationSetting", "navigationSetting", cr2w, this);
				}
				return _navigationSetting;
			}
			set
			{
				if (_navigationSetting == value)
				{
					return;
				}
				_navigationSetting = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get
			{
				if (_useMeshNavmeshSettings == null)
				{
					_useMeshNavmeshSettings = (CBool) CR2WTypeManager.Create("Bool", "useMeshNavmeshSettings", cr2w, this);
				}
				return _useMeshNavmeshSettings;
			}
			set
			{
				if (_useMeshNavmeshSettings == value)
				{
					return;
				}
				_useMeshNavmeshSettings = value;
				PropertySet(this);
			}
		}

		public worldPhysicalDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
