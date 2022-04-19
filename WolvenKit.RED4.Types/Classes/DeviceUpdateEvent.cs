
namespace WolvenKit.RED4.Types
{
	public partial class DeviceUpdateEvent : gameTickableEvent
	{
		public DeviceUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
