
namespace WolvenKit.RED4.Types
{
	public partial class gameInventoryChangedEvent : redEvent
	{
		public gameInventoryChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
