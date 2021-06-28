using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class movePolicies : IScriptable
	{
		private Vector3 _destination;
		private Vector3 _destinationTangent;
		private Vector3 _startTangent;
		private AIObjectId _targetSmartObject;
		private CHandle<gameSetupWorkspotActionEvent> _targetWorkspot;
		private CUInt64 _targetSmartObjectHash;
		private wCHandle<gameObject> _targetObject;
		private moveStrafingTarget _strafingTarget;
		private CBool _useFollowSlots;
		private CStatic<Vector3> _followSlotOverrides;
		private CBool _hasLocalTargetOffset;
		private Vector3 _localTargetOffset;
		private CFloat _desiredDistance;
		private CFloat _toleranceRadius;
		private CFloat _minMovementDistance;
		private CFloat _strafingRotationOffset;
		private CFloat _minFollowerDistance;
		private CFloat _maxFollowerDistance;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveCirclingDirection> _circlingDirection;
		private CBool _stopOnObstacle;
		private CBool _avoidObstacleWithinTolerance;
		private CBool _useCollisionAvoidance;
		private CBool _useDestReservation;
		private CBool _inRestrictedArea;
		private CBool _isSpline;
		private CBool _startFromClosestPoint;
		private CBool _ignoreNavigation;
		private CBool _useStart;
		private CBool _useStop;
		private CBool _isEvaluated;
		private CBool _useOffMeshAllowedTags;
		private CBool _useOffMeshBlockedTags;

		[Ordinal(0)] 
		[RED("destination")] 
		public Vector3 Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		[Ordinal(1)] 
		[RED("destinationTangent")] 
		public Vector3 DestinationTangent
		{
			get => GetProperty(ref _destinationTangent);
			set => SetProperty(ref _destinationTangent, value);
		}

		[Ordinal(2)] 
		[RED("startTangent")] 
		public Vector3 StartTangent
		{
			get => GetProperty(ref _startTangent);
			set => SetProperty(ref _startTangent, value);
		}

		[Ordinal(3)] 
		[RED("targetSmartObject")] 
		public AIObjectId TargetSmartObject
		{
			get => GetProperty(ref _targetSmartObject);
			set => SetProperty(ref _targetSmartObject, value);
		}

		[Ordinal(4)] 
		[RED("targetWorkspot")] 
		public CHandle<gameSetupWorkspotActionEvent> TargetWorkspot
		{
			get => GetProperty(ref _targetWorkspot);
			set => SetProperty(ref _targetWorkspot, value);
		}

		[Ordinal(5)] 
		[RED("targetSmartObjectHash")] 
		public CUInt64 TargetSmartObjectHash
		{
			get => GetProperty(ref _targetSmartObjectHash);
			set => SetProperty(ref _targetSmartObjectHash, value);
		}

		[Ordinal(6)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		[Ordinal(7)] 
		[RED("strafingTarget")] 
		public moveStrafingTarget StrafingTarget
		{
			get => GetProperty(ref _strafingTarget);
			set => SetProperty(ref _strafingTarget, value);
		}

		[Ordinal(8)] 
		[RED("useFollowSlots")] 
		public CBool UseFollowSlots
		{
			get => GetProperty(ref _useFollowSlots);
			set => SetProperty(ref _useFollowSlots, value);
		}

		[Ordinal(9)] 
		[RED("followSlotOverrides", 4)] 
		public CStatic<Vector3> FollowSlotOverrides
		{
			get => GetProperty(ref _followSlotOverrides);
			set => SetProperty(ref _followSlotOverrides, value);
		}

		[Ordinal(10)] 
		[RED("hasLocalTargetOffset")] 
		public CBool HasLocalTargetOffset
		{
			get => GetProperty(ref _hasLocalTargetOffset);
			set => SetProperty(ref _hasLocalTargetOffset, value);
		}

		[Ordinal(11)] 
		[RED("localTargetOffset")] 
		public Vector3 LocalTargetOffset
		{
			get => GetProperty(ref _localTargetOffset);
			set => SetProperty(ref _localTargetOffset, value);
		}

		[Ordinal(12)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(13)] 
		[RED("toleranceRadius")] 
		public CFloat ToleranceRadius
		{
			get => GetProperty(ref _toleranceRadius);
			set => SetProperty(ref _toleranceRadius, value);
		}

		[Ordinal(14)] 
		[RED("minMovementDistance")] 
		public CFloat MinMovementDistance
		{
			get => GetProperty(ref _minMovementDistance);
			set => SetProperty(ref _minMovementDistance, value);
		}

		[Ordinal(15)] 
		[RED("strafingRotationOffset")] 
		public CFloat StrafingRotationOffset
		{
			get => GetProperty(ref _strafingRotationOffset);
			set => SetProperty(ref _strafingRotationOffset, value);
		}

		[Ordinal(16)] 
		[RED("minFollowerDistance")] 
		public CFloat MinFollowerDistance
		{
			get => GetProperty(ref _minFollowerDistance);
			set => SetProperty(ref _minFollowerDistance, value);
		}

		[Ordinal(17)] 
		[RED("maxFollowerDistance")] 
		public CFloat MaxFollowerDistance
		{
			get => GetProperty(ref _maxFollowerDistance);
			set => SetProperty(ref _maxFollowerDistance, value);
		}

		[Ordinal(18)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(19)] 
		[RED("circlingDirection")] 
		public CEnum<moveCirclingDirection> CirclingDirection
		{
			get => GetProperty(ref _circlingDirection);
			set => SetProperty(ref _circlingDirection, value);
		}

		[Ordinal(20)] 
		[RED("stopOnObstacle")] 
		public CBool StopOnObstacle
		{
			get => GetProperty(ref _stopOnObstacle);
			set => SetProperty(ref _stopOnObstacle, value);
		}

		[Ordinal(21)] 
		[RED("avoidObstacleWithinTolerance")] 
		public CBool AvoidObstacleWithinTolerance
		{
			get => GetProperty(ref _avoidObstacleWithinTolerance);
			set => SetProperty(ref _avoidObstacleWithinTolerance, value);
		}

		[Ordinal(22)] 
		[RED("useCollisionAvoidance")] 
		public CBool UseCollisionAvoidance
		{
			get => GetProperty(ref _useCollisionAvoidance);
			set => SetProperty(ref _useCollisionAvoidance, value);
		}

		[Ordinal(23)] 
		[RED("useDestReservation")] 
		public CBool UseDestReservation
		{
			get => GetProperty(ref _useDestReservation);
			set => SetProperty(ref _useDestReservation, value);
		}

		[Ordinal(24)] 
		[RED("inRestrictedArea")] 
		public CBool InRestrictedArea
		{
			get => GetProperty(ref _inRestrictedArea);
			set => SetProperty(ref _inRestrictedArea, value);
		}

		[Ordinal(25)] 
		[RED("isSpline")] 
		public CBool IsSpline
		{
			get => GetProperty(ref _isSpline);
			set => SetProperty(ref _isSpline, value);
		}

		[Ordinal(26)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get => GetProperty(ref _startFromClosestPoint);
			set => SetProperty(ref _startFromClosestPoint, value);
		}

		[Ordinal(27)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(28)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(29)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(30)] 
		[RED("isEvaluated")] 
		public CBool IsEvaluated
		{
			get => GetProperty(ref _isEvaluated);
			set => SetProperty(ref _isEvaluated, value);
		}

		[Ordinal(31)] 
		[RED("useOffMeshAllowedTags")] 
		public CBool UseOffMeshAllowedTags
		{
			get => GetProperty(ref _useOffMeshAllowedTags);
			set => SetProperty(ref _useOffMeshAllowedTags, value);
		}

		[Ordinal(32)] 
		[RED("useOffMeshBlockedTags")] 
		public CBool UseOffMeshBlockedTags
		{
			get => GetProperty(ref _useOffMeshBlockedTags);
			set => SetProperty(ref _useOffMeshBlockedTags, value);
		}

		public movePolicies(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
