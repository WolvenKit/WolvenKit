
namespace WolvenKit.RED4.Types
{
	public abstract partial class MineDispenserTransition : DefaultTransition
	{
		public MineDispenserTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
