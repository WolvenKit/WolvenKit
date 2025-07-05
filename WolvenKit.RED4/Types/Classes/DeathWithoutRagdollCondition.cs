
namespace WolvenKit.RED4.Types
{
	public partial class DeathWithoutRagdollCondition : AIDeathConditions
	{
		public DeathWithoutRagdollCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
