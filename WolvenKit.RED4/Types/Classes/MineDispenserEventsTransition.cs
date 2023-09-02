
namespace WolvenKit.RED4.Types
{
	public abstract partial class MineDispenserEventsTransition : MineDispenserTransition
	{
		public MineDispenserEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
