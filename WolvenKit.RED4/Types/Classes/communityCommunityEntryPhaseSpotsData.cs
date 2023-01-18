using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityCommunityEntryPhaseSpotsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timePeriodsData")] 
		public CArray<communityCommunityEntryPhaseTimePeriodData> TimePeriodsData
		{
			get => GetPropertyValue<CArray<communityCommunityEntryPhaseTimePeriodData>>();
			set => SetPropertyValue<CArray<communityCommunityEntryPhaseTimePeriodData>>(value);
		}

		[Ordinal(1)] 
		[RED("entryPhaseName")] 
		public CName EntryPhaseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public communityCommunityEntryPhaseSpotsData()
		{
			TimePeriodsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
