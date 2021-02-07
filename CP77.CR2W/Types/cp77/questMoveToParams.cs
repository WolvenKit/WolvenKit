using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMoveToParams : questAICommandParams
	{
		[Ordinal(0)]  [RED("movementTargetRef")] public CHandle<questUniversalRef> MovementTargetRef { get; set; }
		[Ordinal(1)]  [RED("facingTargetRef")] public CHandle<questUniversalRef> FacingTargetRef { get; set; }
		[Ordinal(2)]  [RED("rotateEntityTowardsFacingTarget")] public CBool RotateEntityTowardsFacingTarget { get; set; }
		[Ordinal(3)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(4)]  [RED("ignoreNavigation")] public CBool IgnoreNavigation { get; set; }
		[Ordinal(5)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(6)]  [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(7)]  [RED("desiredDistanceFromTarget")] public CFloat DesiredDistanceFromTarget { get; set; }
		[Ordinal(8)]  [RED("finishWhenDestinationReached")] public CBool FinishWhenDestinationReached { get; set; }
		[Ordinal(9)]  [RED("repeatCommandOnInterrupt")] public CBool RepeatCommandOnInterrupt { get; set; }
		[Ordinal(10)]  [RED("executeWhileDespawned")] public CBool ExecuteWhileDespawned { get; set; }
		[Ordinal(11)]  [RED("removeAfterCombat")] public CBool RemoveAfterCombat { get; set; }
		[Ordinal(12)]  [RED("ignoreInCombat")] public CBool IgnoreInCombat { get; set; }
		[Ordinal(13)]  [RED("alwaysUseStealth")] public CBool AlwaysUseStealth { get; set; }

		public questMoveToParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
