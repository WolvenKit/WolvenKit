using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIsValueValidConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<AIArgumentMapping> Value
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
