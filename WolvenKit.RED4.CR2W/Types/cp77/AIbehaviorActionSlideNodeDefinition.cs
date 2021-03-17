using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideNodeDefinition : AIbehaviorActionTreeNodeDefinition
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

		public AIbehaviorActionSlideNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
