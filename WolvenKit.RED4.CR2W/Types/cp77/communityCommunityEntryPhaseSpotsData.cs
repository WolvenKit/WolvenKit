using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntryPhaseSpotsData : CVariable
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

		public communityCommunityEntryPhaseSpotsData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
