using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCompanionConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("companion")] 
		public CHandle<AIArgumentMapping> Companion
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorCompanionConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
