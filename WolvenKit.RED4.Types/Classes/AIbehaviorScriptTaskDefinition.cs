using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviortaskScript> Script
		{
			get => GetPropertyValue<CHandle<AIbehaviortaskScript>>();
			set => SetPropertyValue<CHandle<AIbehaviortaskScript>>(value);
		}

		[Ordinal(2)] 
		[RED("disableLazyInitialization")] 
		public CBool DisableLazyInitialization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorScriptTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
