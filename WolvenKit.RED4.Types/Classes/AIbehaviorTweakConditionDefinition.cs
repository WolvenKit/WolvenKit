using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTweakConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
