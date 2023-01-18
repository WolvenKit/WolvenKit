using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityCommunityEntrySpotsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("phasesData")] 
		public CArray<communityCommunityEntryPhaseSpotsData> PhasesData
		{
			get => GetPropertyValue<CArray<communityCommunityEntryPhaseSpotsData>>();
			set => SetPropertyValue<CArray<communityCommunityEntryPhaseSpotsData>>(value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public communityCommunityEntrySpotsData()
		{
			PhasesData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
