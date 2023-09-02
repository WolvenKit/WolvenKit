
namespace WolvenKit.RED4.Types
{
	public abstract partial class QuickSlotsTapEvents : QuickSlotsEvents
	{
		public QuickSlotsTapEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
