
namespace WolvenKit.RED4.Types
{
	public partial class AIFollowerCombatCommand : AIFollowerCommand
	{
		public AIFollowerCombatCommand()
		{
			CombatCommand = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
