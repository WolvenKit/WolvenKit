using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class movePolicies : IScriptable
	{
		[Ordinal(0)]  [RED("avoidObstacleWithinTolerance")] public CBool AvoidObstacleWithinTolerance { get; set; }
		[Ordinal(1)]  [RED("circlingDirection")] public CEnum<moveCirclingDirection> CirclingDirection { get; set; }
		[Ordinal(2)]  [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }
		[Ordinal(3)]  [RED("destination")] public Vector3 Destination { get; set; }
		[Ordinal(4)]  [RED("destinationTangent")] public Vector3 DestinationTangent { get; set; }
		[Ordinal(5)]  [RED("followSlotOverrides")] public CStatic<4,Vector3> FollowSlotOverrides { get; set; }
		[Ordinal(6)]  [RED("hasLocalTargetOffset")] public CBool HasLocalTargetOffset { get; set; }
		[Ordinal(7)]  [RED("ignoreNavigation")] public CBool IgnoreNavigation { get; set; }
		[Ordinal(8)]  [RED("inRestrictedArea")] public CBool InRestrictedArea { get; set; }
		[Ordinal(9)]  [RED("isEvaluated")] public CBool IsEvaluated { get; set; }
		[Ordinal(10)]  [RED("isSpline")] public CBool IsSpline { get; set; }
		[Ordinal(11)]  [RED("localTargetOffset")] public Vector3 LocalTargetOffset { get; set; }
		[Ordinal(12)]  [RED("maxFollowerDistance")] public CFloat MaxFollowerDistance { get; set; }
		[Ordinal(13)]  [RED("minFollowerDistance")] public CFloat MinFollowerDistance { get; set; }
		[Ordinal(14)]  [RED("minMovementDistance")] public CFloat MinMovementDistance { get; set; }
		[Ordinal(15)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(16)]  [RED("startFromClosestPoint")] public CBool StartFromClosestPoint { get; set; }
		[Ordinal(17)]  [RED("startTangent")] public Vector3 StartTangent { get; set; }
		[Ordinal(18)]  [RED("stopOnObstacle")] public CBool StopOnObstacle { get; set; }
		[Ordinal(19)]  [RED("strafingRotationOffset")] public CFloat StrafingRotationOffset { get; set; }
		[Ordinal(20)]  [RED("strafingTarget")] public moveStrafingTarget StrafingTarget { get; set; }
		[Ordinal(21)]  [RED("targetObject")] public wCHandle<gameObject> TargetObject { get; set; }
		[Ordinal(22)]  [RED("targetSmartObject")] public AIObjectId TargetSmartObject { get; set; }
		[Ordinal(23)]  [RED("targetSmartObjectHash")] public CUInt64 TargetSmartObjectHash { get; set; }
		[Ordinal(24)]  [RED("targetWorkspot")] public CHandle<gameSetupWorkspotActionEvent> TargetWorkspot { get; set; }
		[Ordinal(25)]  [RED("toleranceRadius")] public CFloat ToleranceRadius { get; set; }
		[Ordinal(26)]  [RED("useCollisionAvoidance")] public CBool UseCollisionAvoidance { get; set; }
		[Ordinal(27)]  [RED("useDestReservation")] public CBool UseDestReservation { get; set; }
		[Ordinal(28)]  [RED("useFollowSlots")] public CBool UseFollowSlots { get; set; }
		[Ordinal(29)]  [RED("useOffMeshAllowedTags")] public CBool UseOffMeshAllowedTags { get; set; }
		[Ordinal(30)]  [RED("useOffMeshBlockedTags")] public CBool UseOffMeshBlockedTags { get; set; }
		[Ordinal(31)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(32)]  [RED("useStop")] public CBool UseStop { get; set; }

		public movePolicies(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
