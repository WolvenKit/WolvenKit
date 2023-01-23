using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMoveToParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("movementTargetRef")] 
		public CHandle<questUniversalRef> MovementTargetRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(2)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(4)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("desiredDistanceFromTarget")] 
		public CFloat DesiredDistanceFromTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("finishWhenDestinationReached")] 
		public CBool FinishWhenDestinationReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("executeWhileDespawned")] 
		public CBool ExecuteWhileDespawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMoveToParams()
		{
			UseStart = true;
			UseStop = true;
			FinishWhenDestinationReached = true;
			RepeatCommandOnInterrupt = true;
			ExecuteWhileDespawned = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
