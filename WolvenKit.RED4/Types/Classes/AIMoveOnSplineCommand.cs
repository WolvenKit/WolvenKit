using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIMoveOnSplineCommand : AIMoveCommand
	{
		[Ordinal(7)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("movementType")] 
		public AIMovementTypeSpec MovementType
		{
			get => GetPropertyValue<AIMovementTypeSpec>();
			set => SetPropertyValue<AIMovementTypeSpec>(value);
		}

		[Ordinal(9)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("facingTarget")] 
		public CWeakHandle<gameObject> FacingTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(11)] 
		[RED("shootingTarget")] 
		public CWeakHandle<gameObject> ShootingTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("companion")] 
		public CWeakHandle<gameObject> Companion
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(13)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("deadZoneRadius")] 
		public CFloat DeadZoneRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("catchUpWithCompanion")] 
		public CBool CatchUpWithCompanion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("teleportToCompanion")] 
		public CBool TeleportToCompanion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("useMatchForSpeedForPlayer")] 
		public CBool UseMatchForSpeedForPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("ignoreLineOfSightCheck")] 
		public CBool IgnoreLineOfSightCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("useAlertedState")] 
		public CBool UseAlertedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("useCombatState")] 
		public CBool UseCombatState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("useOMLReservation")] 
		public CBool UseOMLReservation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("lookAtTarget")] 
		public CWeakHandle<gameObject> LookAtTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(29)] 
		[RED("minSearchAngle")] 
		public CFloat MinSearchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("maxSearchAngle")] 
		public CFloat MaxSearchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("noWaitToEndDistance")] 
		public CFloat NoWaitToEndDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("noWaitToEndCompanionDistance")] 
		public CFloat NoWaitToEndCompanionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("maxCompanionDistanceOnSpline")] 
		public CFloat MaxCompanionDistanceOnSpline
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIMoveOnSplineCommand()
		{
			MovementType = new() { UseNPCMovementParams = true };
			DesiredDistance = -5.000000F;
			DeadZoneRadius = 2.000000F;
			CatchUpWithCompanion = true;
			TeleportToCompanion = true;
			UseMatchForSpeedForPlayer = true;
			SnapToTerrain = true;
			UseStart = true;
			UseStop = true;
			MinSearchAngle = 22.500000F;
			MaxSearchAngle = 60.000000F;
			NoWaitToEndDistance = 10.000000F;
			NoWaitToEndCompanionDistance = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
