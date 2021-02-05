using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GrappleBreakFreeEvents : GrappleStandEvents
	{
		[Ordinal(0)]  [RED("stateMachineInitData")] public wCHandle<LocomotionTakedownInitData> StateMachineInitData { get; set; }
		[Ordinal(1)]  [RED("isWalking")] public CBool IsWalking { get; set; }
		[Ordinal(2)]  [RED("playerPositionVerified")] public CBool PlayerPositionVerified { get; set; }
		[Ordinal(3)]  [RED("shouldPushPlayerAway")] public CBool ShouldPushPlayerAway { get; set; }

		public GrappleBreakFreeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
