using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFSMEventTransitionsListDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public AIFSMTransitionListDefinition Transitions
		{
			get => GetPropertyValue<AIFSMTransitionListDefinition>();
			set => SetPropertyValue<AIFSMTransitionListDefinition>(value);
		}

		public AIFSMEventTransitionsListDefinition()
		{
			Transitions = new AIFSMTransitionListDefinition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
