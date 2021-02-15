using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIMoveOnSplineCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("spline")] public NodeRef Spline { get; set; }
		[Ordinal(8)] [RED("movementType")] public AIMovementTypeSpec MovementType { get; set; }
		[Ordinal(9)] [RED("rotateEntityTowardsFacingTarget")] public CBool RotateEntityTowardsFacingTarget { get; set; }
		[Ordinal(10)] [RED("facingTarget")] public wCHandle<gameObject> FacingTarget { get; set; }
		[Ordinal(11)] [RED("shootingTarget")] public wCHandle<gameObject> ShootingTarget { get; set; }
		[Ordinal(12)] [RED("companion")] public wCHandle<gameObject> Companion { get; set; }
		[Ordinal(13)] [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }
		[Ordinal(14)] [RED("deadZoneRadius")] public CFloat DeadZoneRadius { get; set; }
		[Ordinal(15)] [RED("catchUpWithCompanion")] public CBool CatchUpWithCompanion { get; set; }
		[Ordinal(16)] [RED("teleportToCompanion")] public CBool TeleportToCompanion { get; set; }
		[Ordinal(17)] [RED("useMatchForSpeedForPlayer")] public CBool UseMatchForSpeedForPlayer { get; set; }
		[Ordinal(18)] [RED("startFromClosestPoint")] public CBool StartFromClosestPoint { get; set; }
		[Ordinal(19)] [RED("ignoreNavigation")] public CBool IgnoreNavigation { get; set; }
		[Ordinal(20)] [RED("snapToTerrain")] public CBool SnapToTerrain { get; set; }
		[Ordinal(21)] [RED("ignoreLineOfSightCheck")] public CBool IgnoreLineOfSightCheck { get; set; }
		[Ordinal(22)] [RED("useAlertedState")] public CBool UseAlertedState { get; set; }
		[Ordinal(23)] [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(24)] [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(25)] [RED("useCombatState")] public CBool UseCombatState { get; set; }
		[Ordinal(26)] [RED("reverse")] public CBool Reverse { get; set; }
		[Ordinal(27)] [RED("useOMLReservation")] public CBool UseOMLReservation { get; set; }
		[Ordinal(28)] [RED("lookAtTarget")] public wCHandle<gameObject> LookAtTarget { get; set; }
		[Ordinal(29)] [RED("minSearchAngle")] public CFloat MinSearchAngle { get; set; }
		[Ordinal(30)] [RED("maxSearchAngle")] public CFloat MaxSearchAngle { get; set; }
		[Ordinal(31)] [RED("noWaitToEndDistance")] public CFloat NoWaitToEndDistance { get; set; }
		[Ordinal(32)] [RED("noWaitToEndCompanionDistance")] public CFloat NoWaitToEndCompanionDistance { get; set; }
		[Ordinal(33)] [RED("maxCompanionDistanceOnSpline")] public CFloat MaxCompanionDistanceOnSpline { get; set; }

		public AIMoveOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
