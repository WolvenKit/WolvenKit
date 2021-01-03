using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntryPhaseSpotsData : CVariable
	{
		[Ordinal(0)]  [RED("entryPhaseName")] public CName EntryPhaseName { get; set; }
		[Ordinal(1)]  [RED("timePeriodsData")] public CArray<communityCommunityEntryPhaseTimePeriodData> TimePeriodsData { get; set; }

		public communityCommunityEntryPhaseSpotsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
