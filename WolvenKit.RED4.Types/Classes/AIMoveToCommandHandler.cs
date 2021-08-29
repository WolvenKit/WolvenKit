using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMoveToCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outIsDynamicMove;
		private CHandle<AIArgumentMapping> _outMovementTarget;
		private CHandle<AIArgumentMapping> _outMovementTargetPos;
		private CHandle<AIArgumentMapping> _outRotateEntityTowardsFacingTarget;
		private CHandle<AIArgumentMapping> _outFacingTarget;
		private CHandle<AIArgumentMapping> _outMovementType;
		private CHandle<AIArgumentMapping> _outIgnoreNavigation;
		private CHandle<AIArgumentMapping> _outUseStart;
		private CHandle<AIArgumentMapping> _outUseStop;
		private CHandle<AIArgumentMapping> _outDesiredDistanceFromTarget;
		private CHandle<AIArgumentMapping> _outFinishWhenDestinationReached;

		[Ordinal(1)] 
		[RED("outIsDynamicMove")] 
		public CHandle<AIArgumentMapping> OutIsDynamicMove
		{
			get => GetProperty(ref _outIsDynamicMove);
			set => SetProperty(ref _outIsDynamicMove, value);
		}

		[Ordinal(2)] 
		[RED("outMovementTarget")] 
		public CHandle<AIArgumentMapping> OutMovementTarget
		{
			get => GetProperty(ref _outMovementTarget);
			set => SetProperty(ref _outMovementTarget, value);
		}

		[Ordinal(3)] 
		[RED("outMovementTargetPos")] 
		public CHandle<AIArgumentMapping> OutMovementTargetPos
		{
			get => GetProperty(ref _outMovementTargetPos);
			set => SetProperty(ref _outMovementTargetPos, value);
		}

		[Ordinal(4)] 
		[RED("outRotateEntityTowardsFacingTarget")] 
		public CHandle<AIArgumentMapping> OutRotateEntityTowardsFacingTarget
		{
			get => GetProperty(ref _outRotateEntityTowardsFacingTarget);
			set => SetProperty(ref _outRotateEntityTowardsFacingTarget, value);
		}

		[Ordinal(5)] 
		[RED("outFacingTarget")] 
		public CHandle<AIArgumentMapping> OutFacingTarget
		{
			get => GetProperty(ref _outFacingTarget);
			set => SetProperty(ref _outFacingTarget, value);
		}

		[Ordinal(6)] 
		[RED("outMovementType")] 
		public CHandle<AIArgumentMapping> OutMovementType
		{
			get => GetProperty(ref _outMovementType);
			set => SetProperty(ref _outMovementType, value);
		}

		[Ordinal(7)] 
		[RED("outIgnoreNavigation")] 
		public CHandle<AIArgumentMapping> OutIgnoreNavigation
		{
			get => GetProperty(ref _outIgnoreNavigation);
			set => SetProperty(ref _outIgnoreNavigation, value);
		}

		[Ordinal(8)] 
		[RED("outUseStart")] 
		public CHandle<AIArgumentMapping> OutUseStart
		{
			get => GetProperty(ref _outUseStart);
			set => SetProperty(ref _outUseStart, value);
		}

		[Ordinal(9)] 
		[RED("outUseStop")] 
		public CHandle<AIArgumentMapping> OutUseStop
		{
			get => GetProperty(ref _outUseStop);
			set => SetProperty(ref _outUseStop, value);
		}

		[Ordinal(10)] 
		[RED("outDesiredDistanceFromTarget")] 
		public CHandle<AIArgumentMapping> OutDesiredDistanceFromTarget
		{
			get => GetProperty(ref _outDesiredDistanceFromTarget);
			set => SetProperty(ref _outDesiredDistanceFromTarget, value);
		}

		[Ordinal(11)] 
		[RED("outFinishWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> OutFinishWhenDestinationReached
		{
			get => GetProperty(ref _outFinishWhenDestinationReached);
			set => SetProperty(ref _outFinishWhenDestinationReached, value);
		}
	}
}
