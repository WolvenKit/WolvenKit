using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSavedStatsData : RedBaseClass
	{
		private CArray<CHandle<gameStatModifierData_Deprecated>> _statModifiers;
		private DataBuffer _modifiersBuffer;
		private CArray<CEnum<gamedataStatType>> _inactiveStats;
		private TweakDBID _recordID;
		private CUInt32 _seed;

		[Ordinal(0)] 
		[RED("statModifiers")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> StatModifiers
		{
			get => GetProperty(ref _statModifiers);
			set => SetProperty(ref _statModifiers, value);
		}

		[Ordinal(1)] 
		[RED("modifiersBuffer")] 
		public DataBuffer ModifiersBuffer
		{
			get => GetProperty(ref _modifiersBuffer);
			set => SetProperty(ref _modifiersBuffer, value);
		}

		[Ordinal(2)] 
		[RED("inactiveStats")] 
		public CArray<CEnum<gamedataStatType>> InactiveStats
		{
			get => GetProperty(ref _inactiveStats);
			set => SetProperty(ref _inactiveStats, value);
		}

		[Ordinal(3)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(4)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetProperty(ref _seed);
			set => SetProperty(ref _seed, value);
		}
	}
}
