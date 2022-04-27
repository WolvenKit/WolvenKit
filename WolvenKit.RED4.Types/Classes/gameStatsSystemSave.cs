using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatsSystemSave : ISerializable
	{
		[Ordinal(0)] 
		[RED("statsObjectsData")] 
		public CArray<gameStatsSeedKey> StatsObjectsData
		{
			get => GetPropertyValue<CArray<gameStatsSeedKey>>();
			set => SetPropertyValue<CArray<gameStatsSeedKey>>(value);
		}

		[Ordinal(1)] 
		[RED("statModifiersData")] 
		public CArray<gameStatModifierSave> StatModifiersData
		{
			get => GetPropertyValue<CArray<gameStatModifierSave>>();
			set => SetPropertyValue<CArray<gameStatModifierSave>>(value);
		}

		public gameStatsSystemSave()
		{
			StatsObjectsData = new();
			StatModifiersData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
