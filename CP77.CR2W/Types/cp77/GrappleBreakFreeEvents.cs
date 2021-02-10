using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GrappleBreakFreeEvents : GrappleStandEvents
	{
		[Ordinal(2)]  [RED("playerPositionVerified")] public CBool PlayerPositionVerified { get; set; }
		[Ordinal(3)]  [RED("shouldPushPlayerAway")] public CBool ShouldPushPlayerAway { get; set; }

		public GrappleBreakFreeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
