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
			get
			{
				if (_destination == null)
				{
					_destination = (Vector3) CR2WTypeManager.Create("Vector3", "destination", cr2w, this);
				}
				return _destination;
			}
			set
			{
				if (_destination == value)
				{
					return;
				}
				_destination = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destinationTangent")] 
		public Vector3 DestinationTangent
		{
			get
			{
				if (_destinationTangent == null)
				{
					_destinationTangent = (Vector3) CR2WTypeManager.Create("Vector3", "destinationTangent", cr2w, this);
				}
				return _destinationTangent;
			}
			set
			{
				if (_destinationTangent == value)
				{
					return;
				}
				_destinationTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startTangent")] 
		public Vector3 StartTangent
		{
			get
			{
				if (_startTangent == null)
				{
					_startTangent = (Vector3) CR2WTypeManager.Create("Vector3", "startTangent", cr2w, this);
				}
				return _startTangent;
			}
			set
			{
				if (_startTangent == value)
				{
					return;
				}
				_startTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetSmartObject")] 
		public AIObjectId TargetSmartObject
		{
			get
			{
				if (_targetSmartObject == null)
				{
					_targetSmartObject = (AIObjectId) CR2WTypeManager.Create("AIObjectId", "targetSmartObject", cr2w, this);
				}
				return _targetSmartObject;
			}
			set
			{
				if (_targetSmartObject == value)
				{
					return;
				}
				_targetSmartObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetWorkspot")] 
		public CHandle<gameSetupWorkspotActionEvent> TargetWorkspot
		{
			get
			{
				if (_targetWorkspot == null)
				{
					_targetWorkspot = (CHandle<gameSetupWorkspotActionEvent>) CR2WTypeManager.Create("handle:gameSetupWorkspotActionEvent", "targetWorkspot", cr2w, this);
				}
				return _targetWorkspot;
			}
			set
			{
				if (_targetWorkspot == value)
				{
					return;
				}
				_targetWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetSmartObjectHash")] 
		public CUInt64 TargetSmartObjectHash
		{
			get
			{
				if (_targetSmartObjectHash == null)
				{
					_targetSmartObjectHash = (CUInt64) CR2WTypeManager.Create("Uint64", "targetSmartObjectHash", cr2w, this);
				}
				return _targetSmartObjectHash;
			}
			set
			{
				if (_targetSmartObjectHash == value)
				{
					return;
				}
				_targetSmartObjectHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get
			{
				if (_targetObject == null)
				{
					_targetObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObject", cr2w, this);
				}
				return _targetObject;
			}
			set
			{
				if (_targetObject == value)
				{
					return;
				}
				_targetObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("strafingTarget")] 
		public moveStrafingTarget StrafingTarget
		{
			get
			{
				if (_strafingTarget == null)
				{
					_strafingTarget = (moveStrafingTarget) CR2WTypeManager.Create("moveStrafingTarget", "strafingTarget", cr2w, this);
				}
				return _strafingTarget;
			}
			set
			{
				if (_strafingTarget == value)
				{
					return;
				}
				_strafingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("useFollowSlots")] 
		public CBool UseFollowSlots
		{
			get
			{
				if (_useFollowSlots == null)
				{
					_useFollowSlots = (CBool) CR2WTypeManager.Create("Bool", "useFollowSlots", cr2w, this);
				}
				return _useFollowSlots;
			}
			set
			{
				if (_useFollowSlots == value)
				{
					return;
				}
				_useFollowSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("followSlotOverrides", 4)] 
		public CStatic<Vector3> FollowSlotOverrides
		{
			get
			{
				if (_followSlotOverrides == null)
				{
					_followSlotOverrides = (CStatic<Vector3>) CR2WTypeManager.Create("static:4,Vector3", "followSlotOverrides", cr2w, this);
				}
				return _followSlotOverrides;
			}
			set
			{
				if (_followSlotOverrides == value)
				{
					return;
				}
				_followSlotOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("hasLocalTargetOffset")] 
		public CBool HasLocalTargetOffset
		{
			get
			{
				if (_hasLocalTargetOffset == null)
				{
					_hasLocalTargetOffset = (CBool) CR2WTypeManager.Create("Bool", "hasLocalTargetOffset", cr2w, this);
				}
				return _hasLocalTargetOffset;
			}
			set
			{
				if (_hasLocalTargetOffset == value)
				{
					return;
				}
				_hasLocalTargetOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("localTargetOffset")] 
		public Vector3 LocalTargetOffset
		{
			get
			{
				if (_localTargetOffset == null)
				{
					_localTargetOffset = (Vector3) CR2WTypeManager.Create("Vector3", "localTargetOffset", cr2w, this);
				}
				return _localTargetOffset;
			}
			set
			{
				if (_localTargetOffset == value)
				{
					return;
				}
				_localTargetOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get
			{
				if (_desiredDistance == null)
				{
					_desiredDistance = (CFloat) CR2WTypeManager.Create("Float", "desiredDistance", cr2w, this);
				}
				return _desiredDistance;
			}
			set
			{
				if (_desiredDistance == value)
				{
					return;
				}
				_desiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("toleranceRadius")] 
		public CFloat ToleranceRadius
		{
			get
			{
				if (_toleranceRadius == null)
				{
					_toleranceRadius = (CFloat) CR2WTypeManager.Create("Float", "toleranceRadius", cr2w, this);
				}
				return _toleranceRadius;
			}
			set
			{
				if (_toleranceRadius == value)
				{
					return;
				}
				_toleranceRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("minMovementDistance")] 
		public CFloat MinMovementDistance
		{
			get
			{
				if (_minMovementDistance == null)
				{
					_minMovementDistance = (CFloat) CR2WTypeManager.Create("Float", "minMovementDistance", cr2w, this);
				}
				return _minMovementDistance;
			}
			set
			{
				if (_minMovementDistance == value)
				{
					return;
				}
				_minMovementDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("strafingRotationOffset")] 
		public CFloat StrafingRotationOffset
		{
			get
			{
				if (_strafingRotationOffset == null)
				{
					_strafingRotationOffset = (CFloat) CR2WTypeManager.Create("Float", "strafingRotationOffset", cr2w, this);
				}
				return _strafingRotationOffset;
			}
			set
			{
				if (_strafingRotationOffset == value)
				{
					return;
				}
				_strafingRotationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("minFollowerDistance")] 
		public CFloat MinFollowerDistance
		{
			get
			{
				if (_minFollowerDistance == null)
				{
					_minFollowerDistance = (CFloat) CR2WTypeManager.Create("Float", "minFollowerDistance", cr2w, this);
				}
				return _minFollowerDistance;
			}
			set
			{
				if (_minFollowerDistance == value)
				{
					return;
				}
				_minFollowerDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("maxFollowerDistance")] 
		public CFloat MaxFollowerDistance
		{
			get
			{
				if (_maxFollowerDistance == null)
				{
					_maxFollowerDistance = (CFloat) CR2WTypeManager.Create("Float", "maxFollowerDistance", cr2w, this);
				}
				return _maxFollowerDistance;
			}
			set
			{
				if (_maxFollowerDistance == value)
				{
					return;
				}
				_maxFollowerDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("circlingDirection")] 
		public CEnum<moveCirclingDirection> CirclingDirection
		{
			get
			{
				if (_circlingDirection == null)
				{
					_circlingDirection = (CEnum<moveCirclingDirection>) CR2WTypeManager.Create("moveCirclingDirection", "circlingDirection", cr2w, this);
				}
				return _circlingDirection;
			}
			set
			{
				if (_circlingDirection == value)
				{
					return;
				}
				_circlingDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("stopOnObstacle")] 
		public CBool StopOnObstacle
		{
			get
			{
				if (_stopOnObstacle == null)
				{
					_stopOnObstacle = (CBool) CR2WTypeManager.Create("Bool", "stopOnObstacle", cr2w, this);
				}
				return _stopOnObstacle;
			}
			set
			{
				if (_stopOnObstacle == value)
				{
					return;
				}
				_stopOnObstacle = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("avoidObstacleWithinTolerance")] 
		public CBool AvoidObstacleWithinTolerance
		{
			get
			{
				if (_avoidObstacleWithinTolerance == null)
				{
					_avoidObstacleWithinTolerance = (CBool) CR2WTypeManager.Create("Bool", "avoidObstacleWithinTolerance", cr2w, this);
				}
				return _avoidObstacleWithinTolerance;
			}
			set
			{
				if (_avoidObstacleWithinTolerance == value)
				{
					return;
				}
				_avoidObstacleWithinTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("useCollisionAvoidance")] 
		public CBool UseCollisionAvoidance
		{
			get
			{
				if (_useCollisionAvoidance == null)
				{
					_useCollisionAvoidance = (CBool) CR2WTypeManager.Create("Bool", "useCollisionAvoidance", cr2w, this);
				}
				return _useCollisionAvoidance;
			}
			set
			{
				if (_useCollisionAvoidance == value)
				{
					return;
				}
				_useCollisionAvoidance = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("useDestReservation")] 
		public CBool UseDestReservation
		{
			get
			{
				if (_useDestReservation == null)
				{
					_useDestReservation = (CBool) CR2WTypeManager.Create("Bool", "useDestReservation", cr2w, this);
				}
				return _useDestReservation;
			}
			set
			{
				if (_useDestReservation == value)
				{
					return;
				}
				_useDestReservation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("inRestrictedArea")] 
		public CBool InRestrictedArea
		{
			get
			{
				if (_inRestrictedArea == null)
				{
					_inRestrictedArea = (CBool) CR2WTypeManager.Create("Bool", "inRestrictedArea", cr2w, this);
				}
				return _inRestrictedArea;
			}
			set
			{
				if (_inRestrictedArea == value)
				{
					return;
				}
				_inRestrictedArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isSpline")] 
		public CBool IsSpline
		{
			get
			{
				if (_isSpline == null)
				{
					_isSpline = (CBool) CR2WTypeManager.Create("Bool", "isSpline", cr2w, this);
				}
				return _isSpline;
			}
			set
			{
				if (_isSpline == value)
				{
					return;
				}
				_isSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get
			{
				if (_startFromClosestPoint == null)
				{
					_startFromClosestPoint = (CBool) CR2WTypeManager.Create("Bool", "startFromClosestPoint", cr2w, this);
				}
				return _startFromClosestPoint;
			}
			set
			{
				if (_startFromClosestPoint == value)
				{
					return;
				}
				_startFromClosestPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get
			{
				if (_ignoreNavigation == null)
				{
					_ignoreNavigation = (CBool) CR2WTypeManager.Create("Bool", "ignoreNavigation", cr2w, this);
				}
				return _ignoreNavigation;
			}
			set
			{
				if (_ignoreNavigation == value)
				{
					return;
				}
				_ignoreNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (CBool) CR2WTypeManager.Create("Bool", "useStart", cr2w, this);
				}
				return _useStart;
			}
			set
			{
				if (_useStart == value)
				{
					return;
				}
				_useStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (CBool) CR2WTypeManager.Create("Bool", "useStop", cr2w, this);
				}
				return _useStop;
			}
			set
			{
				if (_useStop == value)
				{
					return;
				}
				_useStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("isEvaluated")] 
		public CBool IsEvaluated
		{
			get
			{
				if (_isEvaluated == null)
				{
					_isEvaluated = (CBool) CR2WTypeManager.Create("Bool", "isEvaluated", cr2w, this);
				}
				return _isEvaluated;
			}
			set
			{
				if (_isEvaluated == value)
				{
					return;
				}
				_isEvaluated = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("useOffMeshAllowedTags")] 
		public CBool UseOffMeshAllowedTags
		{
			get
			{
				if (_useOffMeshAllowedTags == null)
				{
					_useOffMeshAllowedTags = (CBool) CR2WTypeManager.Create("Bool", "useOffMeshAllowedTags", cr2w, this);
				}
				return _useOffMeshAllowedTags;
			}
			set
			{
				if (_useOffMeshAllowedTags == value)
				{
					return;
				}
				_useOffMeshAllowedTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("useOffMeshBlockedTags")] 
		public CBool UseOffMeshBlockedTags
		{
			get
			{
				if (_useOffMeshBlockedTags == null)
				{
					_useOffMeshBlockedTags = (CBool) CR2WTypeManager.Create("Bool", "useOffMeshBlockedTags", cr2w, this);
				}
				return _useOffMeshBlockedTags;
			}
			set
			{
				if (_useOffMeshBlockedTags == value)
				{
					return;
				}
				_useOffMeshBlockedTags = value;
				PropertySet(this);
			}
		}

		public movePolicies(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
