using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDebugFailsafeConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("logMessage")] 
		public CHandle<AIArgumentMapping> LogMessage
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorDebugFailsafeConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
