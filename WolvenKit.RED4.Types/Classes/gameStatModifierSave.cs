using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatModifierSave : RedBaseClass
	{
		private CArray<CHandle<gameStatModifierData_Deprecated>> _statModifierUnions;
		private gameStatsObjectID _statsObjectID;
		private TweakDBID _recordID;
		private CUInt32 _seed;

		[Ordinal(0)] 
		[RED("statModifierUnions")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> StatModifierUnions
		{
			get => GetProperty(ref _statModifierUnions);
			set => SetProperty(ref _statModifierUnions, value);
		}

		[Ordinal(1)] 
		[RED("statsObjectID")] 
		public gameStatsObjectID StatsObjectID
		{
			get => GetProperty(ref _statsObjectID);
			set => SetProperty(ref _statsObjectID, value);
		}

		[Ordinal(2)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(3)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetProperty(ref _seed);
			set => SetProperty(ref _seed, value);
		}
	}
}
