using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalBriefingMapSection : gameJournalBriefingBaseSection
	{
		[Ordinal(1)] [RED("mapLocation")] public Vector3 MapLocation { get; set; }

		public gameJournalBriefingMapSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
