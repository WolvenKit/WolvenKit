using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSavedStatsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statModifiers")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> StatModifiers
		{
			get => GetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(1)] 
		[RED("modifiersBuffer")] 
		public DataBuffer ModifiersBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("inactiveStats")] 
		public CArray<CEnum<gamedataStatType>> InactiveStats
		{
			get => GetPropertyValue<CArray<CEnum<gamedataStatType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataStatType>>>(value);
		}

		[Ordinal(3)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameSavedStatsData()
		{
			StatModifiers = new();
			InactiveStats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
