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
			LogMessage = new AIArgumentMapping { Type = Enums.AIArgumentType.CName, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "CName" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
