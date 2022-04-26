
namespace WolvenKit.RED4.Types
{
	public partial class FakeUpdateEvent : gameTickableEvent
	{
		public FakeUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
