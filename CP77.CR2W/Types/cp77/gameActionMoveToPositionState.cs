using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToPositionState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(1)]  [RED("strafingTarget")] public wCHandle<gameObject> StrafingTarget { get; set; }
		[Ordinal(2)]  [RED("target")] public Vector3 Target { get; set; }
		[Ordinal(3)]  [RED("usePathfinding")] public CBool UsePathfinding { get; set; }
		[Ordinal(4)]  [RED("useSpotReservation")] public CBool UseSpotReservation { get; set; }
		[Ordinal(5)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(6)]  [RED("useStop")] public CBool UseStop { get; set; }

		public gameActionMoveToPositionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
