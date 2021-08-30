using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMoveToParams : questAICommandParams
	{
		private CHandle<questUniversalRef> _movementTargetRef;
		private CHandle<questUniversalRef> _facingTargetRef;
		private CBool _rotateEntityTowardsFacingTarget;
		private CEnum<moveMovementType> _movementType;
		private CBool _ignoreNavigation;
		private CBool _useStart;
		private CBool _useStop;
		private CFloat _desiredDistanceFromTarget;
		private CBool _finishWhenDestinationReached;
		private CBool _repeatCommandOnInterrupt;
		private CBool _executeWhileDespawned;
		private CBool _removeAfterCombat;
		private CBool _ignoreInCombat;
		private CBool _alwaysUseStealth;

		[Ordinal(0)] 
		[RED("movementTargetRef")] 
		public CHandle<questUniversalRef> MovementTargetRef
		{
			get => GetProperty(ref _movementTargetRef);
			set => SetProperty(ref _movementTargetRef, value);
		}

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get => GetProperty(ref _facingTargetRef);
			set => SetProperty(ref _facingTargetRef, value);
		}

		[Ordinal(2)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetProperty(ref _rotateEntityTowardsFacingTarget);
			set => SetProperty(ref _rotateEntityTowardsFacingTarget, value);
		}

		[Ordinal(3)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(4)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(5)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(6)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(7)] 
		[RED("desiredDistanceFromTarget")] 
		public CFloat DesiredDistanceFromTarget
		{
			get => GetProperty(ref _desiredDistanceFromTarget);
			set => SetProperty(ref _desiredDistanceFromTarget, value);
		}

		[Ordinal(8)] 
		[RED("finishWhenDestinationReached")] 
		public CBool FinishWhenDestinationReached
		{
			get => GetProperty(ref _finishWhenDestinationReached);
			set => SetProperty(ref _finishWhenDestinationReached, value);
		}

		[Ordinal(9)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetProperty(ref _repeatCommandOnInterrupt);
			set => SetProperty(ref _repeatCommandOnInterrupt, value);
		}

		[Ordinal(10)] 
		[RED("executeWhileDespawned")] 
		public CBool ExecuteWhileDespawned
		{
			get => GetProperty(ref _executeWhileDespawned);
			set => SetProperty(ref _executeWhileDespawned, value);
		}

		[Ordinal(11)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get => GetProperty(ref _removeAfterCombat);
			set => SetProperty(ref _removeAfterCombat, value);
		}

		[Ordinal(12)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get => GetProperty(ref _ignoreInCombat);
			set => SetProperty(ref _ignoreInCombat, value);
		}

		[Ordinal(13)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetProperty(ref _alwaysUseStealth);
			set => SetProperty(ref _alwaysUseStealth, value);
		}

		public questMoveToParams()
		{
			_useStart = true;
			_useStop = true;
			_finishWhenDestinationReached = true;
			_repeatCommandOnInterrupt = true;
			_executeWhileDespawned = true;
		}
	}
}
