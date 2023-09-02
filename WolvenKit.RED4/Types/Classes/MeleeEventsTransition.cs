
namespace WolvenKit.RED4.Types
{
	public abstract partial class MeleeEventsTransition : MeleeTransition
	{
		public MeleeEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
