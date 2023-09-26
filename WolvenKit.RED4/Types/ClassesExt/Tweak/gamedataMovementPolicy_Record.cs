
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMovementPolicy_Record
	{
		[RED("allowedTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AllowedTags
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("avoidObstacleWithinTolerance")]
		[REDProperty(IsIgnored = true)]
		public CBool AvoidObstacleWithinTolerance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("avoidSafeArea")]
		[REDProperty(IsIgnored = true)]
		public CBool AvoidSafeArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("avoidThreat")]
		[REDProperty(IsIgnored = true)]
		public CBool AvoidThreat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("avoidThreatCost")]
		[REDProperty(IsIgnored = true)]
		public CFloat AvoidThreatCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("avoidThreatIgnoringDirection")]
		[REDProperty(IsIgnored = true)]
		public CBool AvoidThreatIgnoringDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("avoidThreatRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat AvoidThreatRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blockedTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> BlockedTags
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("calculateStartTangent")]
		[REDProperty(IsIgnored = true)]
		public CBool CalculateStartTangent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("circlingDirection")]
		[REDProperty(IsIgnored = true)]
		public CName CirclingDirection
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("deadAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat DeadAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("debugName")]
		[REDProperty(IsIgnored = true)]
		public CName DebugName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("destinationOrientationPosition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DestinationOrientationPosition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dontUseStart")]
		[REDProperty(IsIgnored = true)]
		public CBool DontUseStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("dontUseStop")]
		[REDProperty(IsIgnored = true)]
		public CBool DontUseStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("dynamicTargetUpdateDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat DynamicTargetUpdateDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dynamicTargetUpdateTimer")]
		[REDProperty(IsIgnored = true)]
		public CFloat DynamicTargetUpdateTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("getOutOfWay")]
		[REDProperty(IsIgnored = true)]
		public CBool GetOutOfWay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ignoreCollisionAvoidance")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnoreCollisionAvoidance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ignoreLoSPrecheck")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnoreLoSPrecheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ignoreNavigation")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnoreNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ignoreRestrictedMovementArea")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnoreRestrictedMovementArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ignoreSpotReservation")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnoreSpotReservation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("keepLineOfSight")]
		[REDProperty(IsIgnored = true)]
		public CName KeepLineOfSight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("lineOfSightPointPreference")]
		[REDProperty(IsIgnored = true)]
		public CName LineOfSightPointPreference
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("maxPathLength")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxPathLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxPathLengthToDirectDistanceRatioCurve")]
		[REDProperty(IsIgnored = true)]
		public CName MaxPathLengthToDirectDistanceRatioCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("minDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("movementType")]
		[REDProperty(IsIgnored = true)]
		public CName MovementType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("ring")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Ring
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("ringDistanceMult")]
		[REDProperty(IsIgnored = true)]
		public CFloat RingDistanceMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ringDistanceOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat RingDistanceOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ringToleranceMult")]
		[REDProperty(IsIgnored = true)]
		public CFloat RingToleranceMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ringToleranceOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat RingToleranceOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spatialHintMults")]
		[REDProperty(IsIgnored = true)]
		public Vector3 SpatialHintMults
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("stopOnObstacle")]
		[REDProperty(IsIgnored = true)]
		public CBool StopOnObstacle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("strafingPredictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat StrafingPredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("strafingPredictionVelocityMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat StrafingPredictionVelocityMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("strafingRotationOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat StrafingRotationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("strafingTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StrafingTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("symmetricAnglesScores")]
		[REDProperty(IsIgnored = true)]
		public CBool SymmetricAnglesScores
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tolerance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Tolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useFollowSlots")]
		[REDProperty(IsIgnored = true)]
		public CBool UseFollowSlots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useOffMeshAllowedTags")]
		[REDProperty(IsIgnored = true)]
		public CBool UseOffMeshAllowedTags
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useOffMeshBlockedTags")]
		[REDProperty(IsIgnored = true)]
		public CBool UseOffMeshBlockedTags
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("zDiff")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
