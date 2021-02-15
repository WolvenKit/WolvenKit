using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastTravelPointsUpdated : redEvent
	{
		[Ordinal(0)] [RED("updateTrackingAlternative")] public CBool UpdateTrackingAlternative { get; set; }

		public FastTravelPointsUpdated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
