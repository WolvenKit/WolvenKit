using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMappingConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<AIArgumentMapping> Value
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorMappingConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
