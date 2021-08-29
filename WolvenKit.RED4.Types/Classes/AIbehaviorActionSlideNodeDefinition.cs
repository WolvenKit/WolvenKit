using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionSlideNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _duration;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _rotateTowardsMovementDirection;

		[Ordinal(1)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("ignoreNavigation")] 
		public CHandle<AIArgumentMapping> IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(3)] 
		[RED("rotateTowardsMovementDirection")] 
		public CHandle<AIArgumentMapping> RotateTowardsMovementDirection
		{
			get => GetProperty(ref _rotateTowardsMovementDirection);
			set => SetProperty(ref _rotateTowardsMovementDirection, value);
		}
	}
}
