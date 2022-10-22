
namespace WolvenKit.RED4.Types
{
	public partial class DelayedItemEquipped : redEvent
	{
		public DelayedItemEquipped()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
