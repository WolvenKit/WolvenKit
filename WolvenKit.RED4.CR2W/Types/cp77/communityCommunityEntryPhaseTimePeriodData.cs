using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntryPhaseTimePeriodData : CVariable
	{
		[Ordinal(0)] [RED("periodName")] public CName PeriodName { get; set; }
		[Ordinal(1)] [RED("spotNodeIds")] public CArray<worldGlobalNodeID> SpotNodeIds { get; set; }
		[Ordinal(2)] [RED("isSequence")] public CBool IsSequence { get; set; }

		public communityCommunityEntryPhaseTimePeriodData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
