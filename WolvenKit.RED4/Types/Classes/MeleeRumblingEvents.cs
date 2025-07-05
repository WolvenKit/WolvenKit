
namespace WolvenKit.RED4.Types
{
	public abstract partial class MeleeRumblingEvents : MeleeEventsTransition
	{
		public MeleeRumblingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
