using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("gridData")] 
		public CArray<CellData> GridData
		{
			get => GetPropertyValue<CArray<CellData>>();
			set => SetPropertyValue<CArray<CellData>>(value);
		}

		[Ordinal(1)] 
		[RED("playerBufferSize")] 
		public CInt32 PlayerBufferSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("basicAccess")] 
		public ProgramData BasicAccess
		{
			get => GetPropertyValue<ProgramData>();
			set => SetPropertyValue<ProgramData>(value);
		}

		[Ordinal(3)] 
		[RED("playerPrograms")] 
		public CArray<ProgramData> PlayerPrograms
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		[Ordinal(4)] 
		[RED("enemyBufferSize")] 
		public CInt32 EnemyBufferSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("enemyLockNetwork")] 
		public ProgramData EnemyLockNetwork
		{
			get => GetPropertyValue<ProgramData>();
			set => SetPropertyValue<ProgramData>(value);
		}

		[Ordinal(6)] 
		[RED("enemyPrograms")] 
		public CArray<ProgramData> EnemyPrograms
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		public NetworkMinigameData()
		{
			GridData = new();
			BasicAccess = new ProgramData { CommandLists = new(), Effects = new() };
			PlayerPrograms = new();
			EnemyLockNetwork = new ProgramData { CommandLists = new(), Effects = new() };
			EnemyPrograms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
