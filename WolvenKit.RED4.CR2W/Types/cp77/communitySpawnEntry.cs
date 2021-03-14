using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communitySpawnEntry : ISerializable
	{
		private CName _entryName;
		private TweakDBID _characterRecordId;
		private CArray<CHandle<communitySpawnPhase>> _phases;
		private CEnum<gameSpawnInViewState> _spawnInView;
		private CArray<CHandle<communitySpawnInitializer>> _initializers;

		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (CName) CR2WTypeManager.Create("CName", "entryName", cr2w, this);
				}
				return _entryName;
			}
			set
			{
				if (_entryName == value)
				{
					return;
				}
				_entryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get
			{
				if (_characterRecordId == null)
				{
					_characterRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "characterRecordId", cr2w, this);
				}
				return _characterRecordId;
			}
			set
			{
				if (_characterRecordId == value)
				{
					return;
				}
				_characterRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<CHandle<communitySpawnPhase>> Phases
		{
			get
			{
				if (_phases == null)
				{
					_phases = (CArray<CHandle<communitySpawnPhase>>) CR2WTypeManager.Create("array:handle:communitySpawnPhase", "phases", cr2w, this);
				}
				return _phases;
			}
			set
			{
				if (_phases == value)
				{
					return;
				}
				_phases = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("initializers")] 
		public CArray<CHandle<communitySpawnInitializer>> Initializers
		{
			get
			{
				if (_initializers == null)
				{
					_initializers = (CArray<CHandle<communitySpawnInitializer>>) CR2WTypeManager.Create("array:handle:communitySpawnInitializer", "initializers", cr2w, this);
				}
				return _initializers;
			}
			set
			{
				if (_initializers == value)
				{
					return;
				}
				_initializers = value;
				PropertySet(this);
			}
		}

		public communitySpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
