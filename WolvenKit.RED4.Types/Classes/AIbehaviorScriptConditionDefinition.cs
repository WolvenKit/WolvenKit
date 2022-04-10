using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorScriptConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviorconditionScript> Script
		{
			get => GetPropertyValue<CHandle<AIbehaviorconditionScript>>();
			set => SetPropertyValue<CHandle<AIbehaviorconditionScript>>(value);
		}

		[Ordinal(2)] 
		[RED("disableLazyInitialization")] 
		public CBool DisableLazyInitialization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorScriptConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
