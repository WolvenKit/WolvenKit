using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPopulationSpawnerNode : worldNode
	{
		private TweakDBID _objectRecordId;
		private CName _appearanceName;
		private CBool _spawnOnStart;
		private CEnum<gameAlwaysSpawnedState> _alwaysSpawned;
		private CEnum<gameSpawnInViewState> _spawnInView;
		private CBool _prefetchAppearance;

		[Ordinal(4)] 
		[RED("objectRecordId")] 
		public TweakDBID ObjectRecordId
		{
			get
			{
				if (_objectRecordId == null)
				{
					_objectRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "objectRecordId", cr2w, this);
				}
				return _objectRecordId;
			}
			set
			{
				if (_objectRecordId == value)
				{
					return;
				}
				_objectRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get
			{
				if (_appearanceName == null)
				{
					_appearanceName = (CName) CR2WTypeManager.Create("CName", "appearanceName", cr2w, this);
				}
				return _appearanceName;
			}
			set
			{
				if (_appearanceName == value)
				{
					return;
				}
				_appearanceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get
			{
				if (_alwaysSpawned == null)
				{
					_alwaysSpawned = (CEnum<gameAlwaysSpawnedState>) CR2WTypeManager.Create("gameAlwaysSpawnedState", "alwaysSpawned", cr2w, this);
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

		[Ordinal(8)] 
		[RED("spawnInView")] 
		public CEnum<gameSpawnInViewState> SpawnInView
		{
			get
			{
				if (_spawnInView == null)
				{
					_spawnInView = (CEnum<gameSpawnInViewState>) CR2WTypeManager.Create("gameSpawnInViewState", "spawnInView", cr2w, this);
				}
				return _spawnInView;
			}
			set
			{
				if (_spawnInView == value)
				{
					return;
				}
				_spawnInView = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		public worldPopulationSpawnerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
