using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class movePolicies : IScriptable
	{
		[Ordinal(0)] 
		[RED("destination")] 
		public Vector3 Destination
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("destinationTangent")] 
		public Vector3 DestinationTangent
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("startTangent")] 
		public Vector3 StartTangent
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("targetSmartObject")] 
		public AIObjectId TargetSmartObject
		{
			get => GetPropertyValue<AIObjectId>();
			set => SetPropertyValue<AIObjectId>(value);
		}

		[Ordinal(4)] 
		[RED("targetWorkspot")] 
		public CHandle<gameSetupWorkspotActionEvent> TargetWorkspot
		{
			get => GetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>();
			set => SetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>(value);
		}

		[Ordinal(5)] 
		[RED("targetSmartObjectHash")] 
		public CUInt64 TargetSmartObjectHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(6)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(7)] 
		[RED("strafingTarget")] 
		public moveStrafingTarget StrafingTarget
		{
			get => GetPropertyValue<moveStrafingTarget>();
			set => SetPropertyValue<moveStrafingTarget>(value);
		}

		[Ordinal(8)] 
		[RED("useFollowSlots")] 
		public CBool UseFollowSlots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("followSlotOverrides", 4)] 
		public CStatic<Vector3> FollowSlotOverrides
		{
			get => GetPropertyValue<CStatic<Vector3>>();
			set => SetPropertyValue<CStatic<Vector3>>(value);
		}

		[Ordinal(10)] 
		[RED("hasLocalTargetOffset")] 
		public CBool HasLocalTargetOffset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("localTargetOffset")] 
		public Vector3 LocalTargetOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(12)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("toleranceRadius")] 
		public CFloat ToleranceRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("minMovementDistance")] 
		public CFloat MinMovementDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("strafingRotationOffset")] 
		public CFloat StrafingRotationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("minFollowerDistance")] 
		public CFloat MinFollowerDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("maxFollowerDistance")] 
		public CFloat MaxFollowerDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(19)] 
		[RED("circlingDirection")] 
		public CEnum<moveCirclingDirection> CirclingDirection
		{
			get => GetPropertyValue<CEnum<moveCirclingDirection>>();
			set => SetPropertyValue<CEnum<moveCirclingDirection>>(value);
		}

		[Ordinal(20)] 
		[RED("stopOnObstacle")] 
		public CBool StopOnObstacle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("avoidObstacleWithinTolerance")] 
		public CBool AvoidObstacleWithinTolerance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("useCollisionAvoidance")] 
		public CBool UseCollisionAvoidance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("useDestReservation")] 
		public CBool UseDestReservation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("inRestrictedArea")] 
		public CBool InRestrictedArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("isSpline")] 
		public CBool IsSpline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isEvaluated")] 
		public CBool IsEvaluated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("useOffMeshAllowedTags")] 
		public CBool UseOffMeshAllowedTags
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("useOffMeshBlockedTags")] 
		public CBool UseOffMeshBlockedTags
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public movePolicies()
		{
			Destination = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };
			DestinationTangent = new();
			StartTangent = new();
			TargetSmartObject = new();
			StrafingTarget = new() { Position = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity } };
			FollowSlotOverrides = new(0);
			LocalTargetOffset = new();
			MinFollowerDistance = 1.000000F;
			MaxFollowerDistance = 3.000000F;
			UseCollisionAvoidance = true;
			UseStart = true;
			UseStop = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
