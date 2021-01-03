using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalBriefingMapSection : gameJournalBriefingBaseSection
	{
		[Ordinal(0)]  [RED("mapLocation")] public Vector3 MapLocation { get; set; }

		public gameJournalBriefingMapSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
