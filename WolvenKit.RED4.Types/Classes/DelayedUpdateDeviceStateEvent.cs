
namespace WolvenKit.RED4.Types
{
	public partial class DelayedUpdateDeviceStateEvent : redEvent
	{
		public DelayedUpdateDeviceStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
