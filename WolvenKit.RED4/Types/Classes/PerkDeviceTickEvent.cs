
namespace WolvenKit.RED4.Types
{
	public partial class PerkDeviceTickEvent : gameTickableEvent
	{
		public PerkDeviceTickEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
