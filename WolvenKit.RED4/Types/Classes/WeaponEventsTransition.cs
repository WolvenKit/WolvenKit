
namespace WolvenKit.RED4.Types
{
	public abstract partial class WeaponEventsTransition : WeaponTransition
	{
		public WeaponEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
