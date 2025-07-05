
namespace WolvenKit.RED4.Types
{
	public partial class RefreshBuyQueueEvent : redEvent
	{
		public RefreshBuyQueueEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
