using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFollowTargetCommand : AIMoveCommand
	{
		[Ordinal(0)]  [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }
		[Ordinal(1)]  [RED("lookAtTarget")] public wCHandle<gameObject> LookAtTarget { get; set; }
		[Ordinal(2)]  [RED("matchSpeed")] public CBool MatchSpeed { get; set; }
		[Ordinal(3)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(4)]  [RED("stopWhenDestinationReached")] public CBool StopWhenDestinationReached { get; set; }
		[Ordinal(5)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(6)]  [RED("teleport")] public CBool Teleport { get; set; }
		[Ordinal(7)]  [RED("tolerance")] public CFloat Tolerance { get; set; }

		public AIFollowTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
