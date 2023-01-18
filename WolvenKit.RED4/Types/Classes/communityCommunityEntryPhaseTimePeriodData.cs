using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityCommunityEntryPhaseTimePeriodData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("periodName")] 
		public CName PeriodName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("spotNodeIds")] 
		public CArray<worldGlobalNodeID> SpotNodeIds
		{
			get => GetPropertyValue<CArray<worldGlobalNodeID>>();
			set => SetPropertyValue<CArray<worldGlobalNodeID>>(value);
		}

		[Ordinal(2)] 
		[RED("isSequence")] 
		public CBool IsSequence
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public communityCommunityEntryPhaseTimePeriodData()
		{
			SpotNodeIds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
