using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBakedDestructionNode : worldMeshNode
	{
		private raRef<CMesh> _meshFractured;
		private CName _meshFracturedAppearance;
		private CFloat _numFrames;
		private CFloat _frameRate;
		private CBool _playOnlyOnce;
		private CBool _restartOnTrigger;
		private CBool _disableCollidersOnTrigger;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;
		private CFloat _damageThreshold;
		private CFloat _damageEndurance;
		private CFloat _impulseToDamage;
		private CFloat _contactToDamage;
		private CBool _accumulateDamage;
		private raRef<worldEffect> _destructionEffect;
		private CName _audioMetadata;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(15)] 
		[RED("meshFractured")] 
		public raRef<CMesh> MeshFractured
		{
			get
			{
				if (_meshFractured == null)
				{
					_meshFractured = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "meshFractured", cr2w, this);
				}
				return _meshFractured;
			}
			set
			{
				if (_meshFractured == value)
				{
					return;
				}
				_meshFractured = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("meshFracturedAppearance")] 
		public CName MeshFracturedAppearance
		{
			get
			{
				if (_meshFracturedAppearance == null)
				{
					_meshFracturedAppearance = (CName) CR2WTypeManager.Create("CName", "meshFracturedAppearance", cr2w, this);
				}
				return _meshFracturedAppearance;
			}
			set
			{
				if (_meshFracturedAppearance == value)
				{
					return;
				}
				_meshFracturedAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("numFrames")] 
		public CFloat NumFrames
		{
			get
			{
				if (_numFrames == null)
				{
					_numFrames = (CFloat) CR2WTypeManager.Create("Float", "numFrames", cr2w, this);
				}
				return _numFrames;
			}
			set
			{
				if (_numFrames == value)
				{
					return;
				}
				_numFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("frameRate")] 
		public CFloat FrameRate
		{
			get
			{
				if (_frameRate == null)
				{
					_frameRate = (CFloat) CR2WTypeManager.Create("Float", "frameRate", cr2w, this);
				}
				return _frameRate;
			}
			set
			{
				if (_frameRate == value)
				{
					return;
				}
				_frameRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("playOnlyOnce")] 
		public CBool PlayOnlyOnce
		{
			get
			{
				if (_playOnlyOnce == null)
				{
					_playOnlyOnce = (CBool) CR2WTypeManager.Create("Bool", "playOnlyOnce", cr2w, this);
				}
				return _playOnlyOnce;
			}
			set
			{
				if (_playOnlyOnce == value)
				{
					return;
				}
				_playOnlyOnce = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("restartOnTrigger")] 
		public CBool RestartOnTrigger
		{
			get
			{
				if (_restartOnTrigger == null)
				{
					_restartOnTrigger = (CBool) CR2WTypeManager.Create("Bool", "restartOnTrigger", cr2w, this);
				}
				return _restartOnTrigger;
			}
			set
			{
				if (_restartOnTrigger == value)
				{
					return;
				}
				_restartOnTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("disableCollidersOnTrigger")] 
		public CBool DisableCollidersOnTrigger
		{
			get
			{
				if (_disableCollidersOnTrigger == null)
				{
					_disableCollidersOnTrigger = (CBool) CR2WTypeManager.Create("Bool", "disableCollidersOnTrigger", cr2w, this);
				}
				return _disableCollidersOnTrigger;
			}
			set
			{
				if (_disableCollidersOnTrigger == value)
				{
					return;
				}
				_disableCollidersOnTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get
			{
				if (_filterDataSource == null)
				{
					_filterDataSource = (CEnum<physicsFilterDataSource>) CR2WTypeManager.Create("physicsFilterDataSource", "filterDataSource", cr2w, this);
				}
				return _filterDataSource;
			}
			set
			{
				if (_filterDataSource == value)
				{
					return;
				}
				_filterDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get
			{
				if (_damageThreshold == null)
				{
					_damageThreshold = (CFloat) CR2WTypeManager.Create("Float", "damageThreshold", cr2w, this);
				}
				return _damageThreshold;
			}
			set
			{
				if (_damageThreshold == value)
				{
					return;
				}
				_damageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get
			{
				if (_damageEndurance == null)
				{
					_damageEndurance = (CFloat) CR2WTypeManager.Create("Float", "damageEndurance", cr2w, this);
				}
				return _damageEndurance;
			}
			set
			{
				if (_damageEndurance == value)
				{
					return;
				}
				_damageEndurance = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get
			{
				if (_impulseToDamage == null)
				{
					_impulseToDamage = (CFloat) CR2WTypeManager.Create("Float", "impulseToDamage", cr2w, this);
				}
				return _impulseToDamage;
			}
			set
			{
				if (_impulseToDamage == value)
				{
					return;
				}
				_impulseToDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get
			{
				if (_contactToDamage == null)
				{
					_contactToDamage = (CFloat) CR2WTypeManager.Create("Float", "contactToDamage", cr2w, this);
				}
				return _contactToDamage;
			}
			set
			{
				if (_contactToDamage == value)
				{
					return;
				}
				_contactToDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get
			{
				if (_accumulateDamage == null)
				{
					_accumulateDamage = (CBool) CR2WTypeManager.Create("Bool", "accumulateDamage", cr2w, this);
				}
				return _accumulateDamage;
			}
			set
			{
				if (_accumulateDamage == value)
				{
					return;
				}
				_accumulateDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get
			{
				if (_destructionEffect == null)
				{
					_destructionEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "destructionEffect", cr2w, this);
				}
				return _destructionEffect;
			}
			set
			{
				if (_destructionEffect == value)
				{
					return;
				}
				_destructionEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
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

		[Ordinal(31)] 
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

		[Ordinal(32)] 
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

		public worldBakedDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
