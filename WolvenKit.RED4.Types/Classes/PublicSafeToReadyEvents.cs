
namespace WolvenKit.RED4.Types
{
	public partial class PublicSafeToReadyEvents : WeaponEventsTransition
	{
		public PublicSafeToReadyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
