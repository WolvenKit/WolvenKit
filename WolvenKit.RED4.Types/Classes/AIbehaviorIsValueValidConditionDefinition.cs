using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorIsValueValidConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<AIArgumentMapping> Value
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorIsValueValidConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
