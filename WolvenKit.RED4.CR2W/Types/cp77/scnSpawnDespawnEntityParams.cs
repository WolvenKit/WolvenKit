using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSpawnDespawnEntityParams : CVariable
	{
		private CName _dynamicEntityUniqueName;
		private CName _spawnMarker;
		private CEnum<scnMarkerType> _spawnMarkerType;
		private NodeRef _spawnMarkerNodeRef;
		private Transform _spawnOffset;
		private scnPerformerId _itemOwnerId;
		private TweakDBID _specRecordId;
		private CName _appearance;
		private CBool _spawnOnStart;
		private CBool _isEnabled;
		private CBool _validateSpawnPostion;
		private CBool _alwaysSpawned;
		private CBool _keepAlive;
		private CBool _findInWorld;
		private CBool _forceMaxVisibility;
		private CBool _prefetchAppearance;

		[Ordinal(0)] 
		[RED("dynamicEntityUniqueName")] 
		public CName DynamicEntityUniqueName
		{
			get
			{
				if (_dynamicEntityUniqueName == null)
				{
					_dynamicEntityUniqueName = (CName) CR2WTypeManager.Create("CName", "dynamicEntityUniqueName", cr2w, this);
				}
				return _dynamicEntityUniqueName;
			}
			set
			{
				if (_dynamicEntityUniqueName == value)
				{
					return;
				}
				_dynamicEntityUniqueName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spawnMarker")] 
		public CName SpawnMarker
		{
			get
			{
				if (_spawnMarker == null)
				{
					_spawnMarker = (CName) CR2WTypeManager.Create("CName", "spawnMarker", cr2w, this);
				}
				return _spawnMarker;
			}
			set
			{
				if (_spawnMarker == value)
				{
					return;
				}
				_spawnMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawnMarkerType")] 
		public CEnum<scnMarkerType> SpawnMarkerType
		{
			get
			{
				if (_spawnMarkerType == null)
				{
					_spawnMarkerType = (CEnum<scnMarkerType>) CR2WTypeManager.Create("scnMarkerType", "spawnMarkerType", cr2w, this);
				}
				return _spawnMarkerType;
			}
			set
			{
				if (_spawnMarkerType == value)
				{
					return;
				}
				_spawnMarkerType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("spawnMarkerNodeRef")] 
		public NodeRef SpawnMarkerNodeRef
		{
			get
			{
				if (_spawnMarkerNodeRef == null)
				{
					_spawnMarkerNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "spawnMarkerNodeRef", cr2w, this);
				}
				return _spawnMarkerNodeRef;
			}
			set
			{
				if (_spawnMarkerNodeRef == value)
				{
					return;
				}
				_spawnMarkerNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("spawnOffset")] 
		public Transform SpawnOffset
		{
			get
			{
				if (_spawnOffset == null)
				{
					_spawnOffset = (Transform) CR2WTypeManager.Create("Transform", "spawnOffset", cr2w, this);
				}
				return _spawnOffset;
			}
			set
			{
				if (_spawnOffset == value)
				{
					return;
				}
				_spawnOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemOwnerId")] 
		public scnPerformerId ItemOwnerId
		{
			get
			{
				if (_itemOwnerId == null)
				{
					_itemOwnerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "itemOwnerId", cr2w, this);
				}
				return _itemOwnerId;
			}
			set
			{
				if (_itemOwnerId == value)
				{
					return;
				}
				_itemOwnerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("specRecordId")] 
		public TweakDBID SpecRecordId
		{
			get
			{
				if (_specRecordId == null)
				{
					_specRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "specRecordId", cr2w, this);
				}
				return _specRecordId;
			}
			set
			{
				if (_specRecordId == value)
				{
					return;
				}
				_specRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get
			{
				if (_appearance == null)
				{
					_appearance = (CName) CR2WTypeManager.Create("CName", "appearance", cr2w, this);
				}
				return _appearance;
			}
			set
			{
				if (_appearance == value)
				{
					return;
				}
				_appearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("spawnOnStart")] 
		public CBool SpawnOnStart
		{
			get
			{
				if (_spawnOnStart == null)
				{
					_spawnOnStart = (CBool) CR2WTypeManager.Create("Bool", "spawnOnStart", cr2w, this);
				}
				return _spawnOnStart;
			}
			set
			{
				if (_spawnOnStart == value)
				{
					return;
				}
				_spawnOnStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("validateSpawnPostion")] 
		public CBool ValidateSpawnPostion
		{
			get
			{
				if (_validateSpawnPostion == null)
				{
					_validateSpawnPostion = (CBool) CR2WTypeManager.Create("Bool", "validateSpawnPostion", cr2w, this);
				}
				return _validateSpawnPostion;
			}
			set
			{
				if (_validateSpawnPostion == value)
				{
					return;
				}
				_validateSpawnPostion = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("alwaysSpawned")] 
		public CBool AlwaysSpawned
		{
			get
			{
				if (_alwaysSpawned == null)
				{
					_alwaysSpawned = (CBool) CR2WTypeManager.Create("Bool", "alwaysSpawned", cr2w, this);
				}
				return _alwaysSpawned;
			}
			set
			{
				if (_alwaysSpawned == value)
				{
					return;
				}
				_alwaysSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("keepAlive")] 
		public CBool KeepAlive
		{
			get
			{
				if (_keepAlive == null)
				{
					_keepAlive = (CBool) CR2WTypeManager.Create("Bool", "keepAlive", cr2w, this);
				}
				return _keepAlive;
			}
			set
			{
				if (_keepAlive == value)
				{
					return;
				}
				_keepAlive = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("findInWorld")] 
		public CBool FindInWorld
		{
			get
			{
				if (_findInWorld == null)
				{
					_findInWorld = (CBool) CR2WTypeManager.Create("Bool", "findInWorld", cr2w, this);
				}
				return _findInWorld;
			}
			set
			{
				if (_findInWorld == value)
				{
					return;
				}
				_findInWorld = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get
			{
				if (_forceMaxVisibility == null)
				{
					_forceMaxVisibility = (CBool) CR2WTypeManager.Create("Bool", "forceMaxVisibility", cr2w, this);
				}
				return _forceMaxVisibility;
			}
			set
			{
				if (_forceMaxVisibility == value)
				{
					return;
				}
				_forceMaxVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get
			{
				if (_prefetchAppearance == null)
				{
					_prefetchAppearance = (CBool) CR2WTypeManager.Create("Bool", "prefetchAppearance", cr2w, this);
				}
				return _prefetchAppearance;
			}
			set
			{
				if (_prefetchAppearance == value)
				{
					return;
				}
				_prefetchAppearance = value;
				PropertySet(this);
			}
		}

		public scnSpawnDespawnEntityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
