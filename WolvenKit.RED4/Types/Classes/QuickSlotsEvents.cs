
namespace WolvenKit.RED4.Types
{
	public abstract partial class QuickSlotsEvents : QuickSlotsTransition
	{
		public QuickSlotsEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
