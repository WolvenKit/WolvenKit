using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questWithCompanionMoveOnSplineParams : CVariable
	{
		[Ordinal(0)]  [RED("movementType")] public AIMovementTypeSpec MovementType { get; set; }
		[Ordinal(1)]  [RED("facingTargetRef")] public CHandle<questUniversalRef> FacingTargetRef { get; set; }
		[Ordinal(2)]  [RED("rotateEntityTowardsFacingTarget")] public CBool RotateEntityTowardsFacingTarget { get; set; }
		[Ordinal(3)]  [RED("snapToTerrain")] public CBool SnapToTerrain { get; set; }
		[Ordinal(4)]  [RED("shootingTargetRef")] public CHandle<questUniversalRef> ShootingTargetRef { get; set; }
		[Ordinal(5)]  [RED("companionRef")] public CHandle<questUniversalRef> CompanionRef { get; set; }
		[Ordinal(6)]  [RED("companionDistancePreset")] public CEnum<gamedataCompanionDistancePreset> CompanionDistancePreset { get; set; }
		[Ordinal(7)]  [RED("companionPosition")] public CEnum<questCompanionPositions> CompanionPosition { get; set; }
		[Ordinal(8)]  [RED("catchUpWithCompanion")] public CBool CatchUpWithCompanion { get; set; }
		[Ordinal(9)]  [RED("teleportToCompanion")] public CBool TeleportToCompanion { get; set; }
		[Ordinal(10)]  [RED("useMatchForSpeedForPlayer")] public CBool UseMatchForSpeedForPlayer { get; set; }
		[Ordinal(11)]  [RED("ignoreNavigation")] public CBool IgnoreNavigation { get; set; }
		[Ordinal(12)]  [RED("ignoreLineOfSightCheck")] public CBool IgnoreLineOfSightCheck { get; set; }
		[Ordinal(13)]  [RED("useOffMeshLinkReservation")] public CBool UseOffMeshLinkReservation { get; set; }
		[Ordinal(14)]  [RED("lookAtTargetRef")] public CHandle<questUniversalRef> LookAtTargetRef { get; set; }
		[Ordinal(15)]  [RED("minSearchAngle")] public CFloat MinSearchAngle { get; set; }
		[Ordinal(16)]  [RED("maxSearchAngle")] public CFloat MaxSearchAngle { get; set; }
		[Ordinal(17)]  [RED("interruptCapability")] public CEnum<scnInterruptCapability> InterruptCapability { get; set; }
		[Ordinal(18)]  [RED("maxCompanionDistanceOnSpline")] public CFloat MaxCompanionDistanceOnSpline { get; set; }

		public questWithCompanionMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
