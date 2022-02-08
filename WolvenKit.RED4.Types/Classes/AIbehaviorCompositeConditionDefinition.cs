using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCompositeConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<AIbehaviorConditionDefinition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorConditionDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorConditionDefinition>>>(value);
		}
	}
}
