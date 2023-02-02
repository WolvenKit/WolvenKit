using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSelectCombatTargetTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("targetClosest")] 
		public CBool TargetClosest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorSelectCombatTargetTaskDefinition()
		{
			TargetClosest = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
