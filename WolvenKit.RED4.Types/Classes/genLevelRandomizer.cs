using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class genLevelRandomizer : gameObject
	{
		[Ordinal(40)] 
		[RED("entries")] 
		public CArray<genLevelRandomizerEntry> Entries
		{
			get => GetPropertyValue<CArray<genLevelRandomizerEntry>>();
			set => SetPropertyValue<CArray<genLevelRandomizerEntry>>(value);
		}

		[Ordinal(41)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(42)] 
		[RED("dataSource")] 
		public CEnum<genLevelRandomizerDataSource> DataSource
		{
			get => GetPropertyValue<CEnum<genLevelRandomizerDataSource>>();
			set => SetPropertyValue<CEnum<genLevelRandomizerDataSource>>(value);
		}

		[Ordinal(43)] 
		[RED("supervisorType")] 
		public CName SupervisorType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("debugSpawnAll")] 
		public CBool DebugSpawnAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public genLevelRandomizer()
		{
			Entries = new();
		}
	}
}
