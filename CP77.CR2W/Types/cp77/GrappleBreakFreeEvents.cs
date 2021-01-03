using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GrappleBreakFreeEvents : GrappleStandEvents
	{
		[Ordinal(0)]  [RED("playerPositionVerified")] public CBool PlayerPositionVerified { get; set; }
		[Ordinal(1)]  [RED("shouldPushPlayerAway")] public CBool ShouldPushPlayerAway { get; set; }

		public GrappleBreakFreeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
