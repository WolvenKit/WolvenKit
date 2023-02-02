using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorStackScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviortaskStackScript> Script
		{
			get => GetPropertyValue<CHandle<AIbehaviortaskStackScript>>();
			set => SetPropertyValue<CHandle<AIbehaviortaskStackScript>>(value);
		}

		public AIbehaviorStackScriptTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
