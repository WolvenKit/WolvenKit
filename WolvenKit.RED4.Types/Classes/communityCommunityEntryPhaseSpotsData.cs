using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityCommunityEntryPhaseSpotsData : RedBaseClass
	{
		private CArray<communityCommunityEntryPhaseTimePeriodData> _timePeriodsData;
		private CName _entryPhaseName;

		[Ordinal(0)] 
		[RED("timePeriodsData")] 
		public CArray<communityCommunityEntryPhaseTimePeriodData> TimePeriodsData
		{
			get => GetProperty(ref _timePeriodsData);
			set => SetProperty(ref _timePeriodsData, value);
		}

		[Ordinal(1)] 
		[RED("entryPhaseName")] 
		public CName EntryPhaseName
		{
			get => GetProperty(ref _entryPhaseName);
			set => SetProperty(ref _entryPhaseName, value);
		}
	}
}
