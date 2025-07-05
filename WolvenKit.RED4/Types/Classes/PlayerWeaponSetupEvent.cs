
namespace WolvenKit.RED4.Types
{
	public partial class PlayerWeaponSetupEvent : redEvent
	{
		public PlayerWeaponSetupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
