using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorIsThreatOnPathConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("threatObject")] 
		public CHandle<AIArgumentMapping> ThreatObject
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("threatRadius")] 
		public CHandle<AIArgumentMapping> ThreatRadius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorIsThreatOnPathConditionDefinition()
		{
			ThreatObject = new AIArgumentMapping { Type = Enums.AIArgumentType.Object, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "whandle:gameObject" };
			ThreatRadius = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
