
namespace WolvenKit.RED4.Types
{
	public abstract partial class StaminaEventsTransition : StaminaTransition
	{
		public StaminaEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
