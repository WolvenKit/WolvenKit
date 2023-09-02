
namespace WolvenKit.RED4.Types
{
	public abstract partial class MeleeAttackGenericDecisions : MeleeTransition
	{
		public MeleeAttackGenericDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
