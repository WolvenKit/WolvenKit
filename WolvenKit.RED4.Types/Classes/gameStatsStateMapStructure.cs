using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatsStateMapStructure : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("keys")] 
		public CArray<gameStatsObjectID> Keys
		{
			get => GetPropertyValue<CArray<gameStatsObjectID>>();
			set => SetPropertyValue<CArray<gameStatsObjectID>>(value);
		}

		[Ordinal(1)] 
		[RED("values")] 
		public CArray<gameSavedStatsData> Values
		{
			get => GetPropertyValue<CArray<gameSavedStatsData>>();
			set => SetPropertyValue<CArray<gameSavedStatsData>>(value);
		}

		public gameStatsStateMapStructure()
		{
			Keys = new();
			Values = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
