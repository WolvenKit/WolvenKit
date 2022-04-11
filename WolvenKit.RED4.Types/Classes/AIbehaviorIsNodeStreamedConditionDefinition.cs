using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIsNodeStreamedConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("nodeRef")] 
		public CHandle<AIArgumentMapping> NodeRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
