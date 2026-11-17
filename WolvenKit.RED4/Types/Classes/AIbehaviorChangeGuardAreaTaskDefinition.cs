using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorChangeGuardAreaTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("guardAreaNodeRef")] 
		public CHandle<AIArgumentMapping> GuardAreaNodeRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorChangeGuardAreaTaskDefinition()
		{
			GuardAreaNodeRef = new AIArgumentMapping { Type = Enums.AIArgumentType.NodeRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "NodeRef" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
