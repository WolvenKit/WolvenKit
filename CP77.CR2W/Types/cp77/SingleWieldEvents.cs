using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SingleWieldEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)]  [RED("hasInstantEquipHackBeenApplied")] public CBool HasInstantEquipHackBeenApplied { get; set; }

		public SingleWieldEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
