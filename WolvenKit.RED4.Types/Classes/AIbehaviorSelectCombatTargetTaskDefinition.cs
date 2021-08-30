using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSelectCombatTargetTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CBool _targetClosest;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("targetClosest")] 
		public CBool TargetClosest
		{
			get => GetProperty(ref _targetClosest);
			set => SetProperty(ref _targetClosest, value);
		}

		public AIbehaviorSelectCombatTargetTaskDefinition()
		{
			_targetClosest = true;
		}
	}
}
