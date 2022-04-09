
namespace WolvenKit.RED4.Types
{
	public partial class RefreshPowerOnSlavesEvent : ProcessDevicesEvent
	{
		public RefreshPowerOnSlavesEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
