
namespace WolvenKit.RED4.Types
{
	public partial class ConsumableStartupEvents : ConsumableTransitions
	{
		public ConsumableStartupEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
