using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatModifierSave : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statModifierUnions")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> StatModifierUnions
		{
			get => GetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(1)] 
		[RED("statsObjectID")] 
		public gameStatsObjectID StatsObjectID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		[Ordinal(2)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameStatModifierSave()
		{
			StatModifierUnions = new();
			StatsObjectID = new() { IdType = Enums.gameStatIDType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
