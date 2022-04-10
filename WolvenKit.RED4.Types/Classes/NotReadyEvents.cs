
namespace WolvenKit.RED4.Types
{
	public partial class NotReadyEvents : WeaponEventsTransition
	{
		public NotReadyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
