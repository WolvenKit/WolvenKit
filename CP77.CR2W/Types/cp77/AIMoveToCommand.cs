using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCommand : AIMoveCommand
	{
		[Ordinal(0)]  [RED("movementTarget")] public AIPositionSpec MovementTarget { get; set; }
		[Ordinal(1)]  [RED("rotateEntityTowardsFacingTarget")] public CBool RotateEntityTowardsFacingTarget { get; set; }
		[Ordinal(2)]  [RED("facingTarget")] public AIPositionSpec FacingTarget { get; set; }
		[Ordinal(3)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(4)]  [RED("ignoreNavigation")] public CBool IgnoreNavigation { get; set; }
		[Ordinal(5)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(6)]  [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(7)]  [RED("desiredDistanceFromTarget")] public CFloat DesiredDistanceFromTarget { get; set; }
		[Ordinal(8)]  [RED("finishWhenDestinationReached")] public CBool FinishWhenDestinationReached { get; set; }

		public AIMoveToCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
