using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowTargetCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(8)] [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }
		[Ordinal(9)] [RED("tolerance")] public CFloat Tolerance { get; set; }
		[Ordinal(10)] [RED("stopWhenDestinationReached")] public CBool StopWhenDestinationReached { get; set; }
		[Ordinal(11)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(12)] [RED("lookAtTarget")] public wCHandle<gameObject> LookAtTarget { get; set; }
		[Ordinal(13)] [RED("matchSpeed")] public CBool MatchSpeed { get; set; }
		[Ordinal(14)] [RED("teleport")] public CBool Teleport { get; set; }

		public AIFollowTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
