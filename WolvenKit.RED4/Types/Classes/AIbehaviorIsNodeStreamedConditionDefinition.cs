using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorIsNodeStreamedConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("nodeRef")] 
		public CHandle<AIArgumentMapping> NodeRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorIsNodeStreamedConditionDefinition()
		{
			NodeRef = new AIArgumentMapping { Type = Enums.AIArgumentType.NodeRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "NodeRef" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
