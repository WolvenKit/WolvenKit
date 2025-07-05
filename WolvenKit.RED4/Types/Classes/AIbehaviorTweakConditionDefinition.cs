using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorTweakConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public AIbehaviorTweakConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
