using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class genLevelRandomizer : gameObject
	{
		private CArray<genLevelRandomizerEntry> _entries;
		private CUInt32 _seed;
		private CEnum<genLevelRandomizerDataSource> _dataSource;
		private CName _supervisorType;
		private CBool _debugSpawnAll;

		[Ordinal(40)] 
		[RED("entries")] 
		public CArray<genLevelRandomizerEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<genLevelRandomizerEntry>) CR2WTypeManager.Create("array:genLevelRandomizerEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get
			{
				if (_seed == null)
				{
					_seed = (CUInt32) CR2WTypeManager.Create("Uint32", "seed", cr2w, this);
				}
				return _seed;
			}
			set
			{
				if (_seed == value)
				{
					return;
				}
				_seed = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("dataSource")] 
		public CEnum<genLevelRandomizerDataSource> DataSource
		{
			get
			{
				if (_dataSource == null)
				{
					_dataSource = (CEnum<genLevelRandomizerDataSource>) CR2WTypeManager.Create("genLevelRandomizerDataSource", "dataSource", cr2w, this);
				}
				return _dataSource;
			}
			set
			{
				if (_dataSource == value)
				{
					return;
				}
				_dataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("supervisorType")] 
		public CName SupervisorType
		{
			get
			{
				if (_supervisorType == null)
				{
					_supervisorType = (CName) CR2WTypeManager.Create("CName", "supervisorType", cr2w, this);
				}
				return _supervisorType;
			}
			set
			{
				if (_supervisorType == value)
				{
					return;
				}
				_supervisorType = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("debugSpawnAll")] 
		public CBool DebugSpawnAll
		{
			get
			{
				if (_debugSpawnAll == null)
				{
					_debugSpawnAll = (CBool) CR2WTypeManager.Create("Bool", "debugSpawnAll", cr2w, this);
				}
				return _debugSpawnAll;
			}
			set
			{
				if (_debugSpawnAll == value)
				{
					return;
				}
				_debugSpawnAll = value;
				PropertySet(this);
			}
		}

		public genLevelRandomizer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
