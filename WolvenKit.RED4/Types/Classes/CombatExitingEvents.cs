
namespace WolvenKit.RED4.Types
{
	public partial class CombatExitingEvents : ExitingEvents
	{
		public CombatExitingEvents()
		{
			ExitSlot = "combat";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
