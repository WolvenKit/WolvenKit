using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class genLevelRandomizer : gameObject
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
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(41)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetProperty(ref _seed);
			set => SetProperty(ref _seed, value);
		}

		[Ordinal(42)] 
		[RED("dataSource")] 
		public CEnum<genLevelRandomizerDataSource> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(43)] 
		[RED("supervisorType")] 
		public CName SupervisorType
		{
			get => GetProperty(ref _supervisorType);
			set => SetProperty(ref _supervisorType, value);
		}

		[Ordinal(44)] 
		[RED("debugSpawnAll")] 
		public CBool DebugSpawnAll
		{
			get => GetProperty(ref _debugSpawnAll);
			set => SetProperty(ref _debugSpawnAll, value);
		}
	}
}
