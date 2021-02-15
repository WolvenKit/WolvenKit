using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workTimeOfDayCondition : workIWorkspotCondition
	{
		[Ordinal(2)] [RED("activeAfter")] public GameTime ActiveAfter { get; set; }
		[Ordinal(3)] [RED("activeUntil")] public GameTime ActiveUntil { get; set; }

		public workTimeOfDayCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
