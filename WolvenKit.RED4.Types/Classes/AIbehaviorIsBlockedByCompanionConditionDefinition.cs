using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIsBlockedByCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(3)] 
		[RED("distance")] 
		public CHandle<AIArgumentMapping> Distance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
