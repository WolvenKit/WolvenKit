using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalBriefingMapSection : gameJournalBriefingBaseSection
	{
		[Ordinal(1)] [RED("mapLocation")] public Vector3 MapLocation { get; set; }

		public gameJournalBriefingMapSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
