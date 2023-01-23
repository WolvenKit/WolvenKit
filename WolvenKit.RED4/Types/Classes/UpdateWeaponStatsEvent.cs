
namespace WolvenKit.RED4.Types
{
	public partial class UpdateWeaponStatsEvent : redEvent
	{
		public UpdateWeaponStatsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
